using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Zyl.VectorTraits.Impl.Util {
#if NETSTANDARD1_0_OR_GREATER && !NETSTANDARD2_0_OR_GREATER
    using Trace = Debug;
#endif

    /// <summary>
    /// Process util (进程工具).
    /// </summary>
    public static class ProcessUtil {

        private static bool _SupportedProcess = false;

        /// <summary>
        /// Run and fetch text lines (运行与获取每行文本)
        /// </summary>
        /// <param name="onFetch">The callback function of fetch line text (获取单行文本的回调函数). Prototype: `bool isBreak = onFetch(bool isError, string line)`. <see cref="OperationCanceledException"/> is cancel, other is throw.</param>
        /// <param name="fileName">The application or document to start (启动的应用程序或文档).</param>
        /// <param name="arguments">Command-line arguments to use when starting the application(启动应用程序时要使用的一组命令行参数).</param>
        /// <param name="allowError">Whether to allow output error streams(是否允许输出错误流).</param>
        /// <param name="onBefore">The callback function of before run (运行之前的回调函数). Prototype: `bool isBreak = onBefore(object processObj)`. <see cref="OperationCanceledException"/> is cancel, other is throw.</param>
        /// <returns>Returns the ExitCode of the <see cref="Process"/> (返回进程的 ExitCode).</returns>
        public static int RunAndFetchLines(Func<bool, string, bool> onFetch, string fileName, string arguments = "", bool allowError = false, Func<object, bool>? onBefore = null) {
            int exitCode = -1;
#if NETSTANDARD1_0_OR_GREATER && !NETSTANDARD2_0_OR_GREATER
            throw new NotSupportedException();
#else
            string? line;
            Process processObj = new Process();
            if (!_SupportedProcess) {
                _SupportedProcess = true;
            }
            try {
                ProcessStartInfo startInfo = processObj.StartInfo;
                startInfo.FileName = fileName;
                startInfo.Arguments = arguments;
                startInfo.UseShellExecute = false;
                //startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                if (allowError) {
                    startInfo.RedirectStandardError = true;
                }
                startInfo.CreateNoWindow = true;
                if (null!= onBefore) {
                    try {
                        onBefore(startInfo);
                    } catch (Exception ex) {
                        if (ex is OperationCanceledException) {
                            return exitCode;
                        } else {
                            throw;
                        }
                    }
                }
                processObj.Start();
                // StandardOutput.
                bool isError = false;
                if (true) {
                    StreamReader outStream = processObj.StandardOutput;
                    while (null != (line = outStream.ReadLine())) {
                        try {
                            bool isBreak = onFetch(isError, line);
                            if (isBreak) break;
                        } catch (Exception ex) {
                            if (ex is OperationCanceledException) {
                                return exitCode;
                            } else {
                                throw;
                            }
                        }
                    }
                }
                // StandardError.
                if (allowError) {
                    isError = true;
                    StreamReader errStream = processObj.StandardError;
                    while (null != (line = errStream.ReadLine())) {
                        try {
                            bool isBreak = onFetch(isError, line);
                            if (isBreak) break;
                        } catch (Exception ex) {
                            if (ex is OperationCanceledException) {
                                return exitCode;
                            } else {
                                throw;
                            }
                        }
                    }
                }
                // done.
                exitCode = 0;
                processObj.WaitForExit();
                if (processObj.HasExited) {
                    try {
                        exitCode = processObj.ExitCode;
                    } catch (Exception ex0) {
                        Trace.WriteLine(ex0);
                    }
                }
            } finally {
                try {
                    processObj.Dispose();
                } catch (Exception ex0) {
                    Trace.WriteLine(ex0);
                }
            }
            return exitCode;
#endif
        }

        /// <summary>
        /// Whether the creation of process objects is supported (是否支持创建进程对象).
        /// </summary>
        public static bool SupportedProcess { get => _SupportedProcess; }

    }

}
