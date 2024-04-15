using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits.Impl.Util {
#if NETSTANDARD1_0_OR_GREATER && !NETSTANDARD2_0_OR_GREATER
    using Trace = Debug;
#endif

    /// <summary>
    /// Cpu detection helper (CPU检测工具).
    /// </summary>
    public class CpuDetectionHelper {

        // ## Fields ##
        // == Fields - static ==
        private static CpuDetectionHelper? _Instance = null;

        // == Fields - object ==
        private string _CpuModelName = "";
        private string _CpuFlags = "";
        private string _CpuDetectionCommand = "";
        private Exception? _CpuDetectionException = null;
        private readonly List<string> _CpuDetectionResult = new List<string>();

        // ## Methods ##

        /// <summary>
        /// Get <see cref="Path.DirectorySeparatorChar"/> is Windows format.
        /// </summary>
        /// <returns>Returns true if <see cref="Path.DirectorySeparatorChar"/> is Windows format.</returns>
        public static bool IsWindowsPath() {
            const char DirectorySeparatorCharWindows = '\\';
            bool flag;
            //flag = OperatingSystem.IsWindows();
#if NETSTANDARD1_0_OR_GREATER && !NETSTANDARD1_3_OR_GREATER
            string str = Path.Combine("a", "b");
            flag = DirectorySeparatorCharWindows == str[1];
#else
            flag = DirectorySeparatorCharWindows == Path.DirectorySeparatorChar;
#endif
            return flag;
        }

        /// <summary>
        /// Refresh information (刷新信息).
        /// </summary>
        public static void Refresh() {
            CpuDetectionHelper p = new CpuDetectionHelper();
            try {
                p.RefreshSelf();
            } catch(Exception ex) {
                Trace.WriteLine("RefreshSelf fail!");
                Trace.WriteLine(ex);
            }
            _Instance = p;
        }

        /// <summary>
        /// Refresh self (刷新自己).
        /// </summary>
        public void RefreshSelf() {
            // Clear.
            _CpuModelName = "";
            _CpuFlags = "";
            _CpuDetectionCommand = "";
            _CpuDetectionException = null;
            _CpuDetectionResult.Clear();
            // By command.
            if (IsWindowsPath()) {
                // wmic.
                try {
                    RefreshSelf_Wmic(_CpuDetectionResult, ref _CpuDetectionCommand);
                } catch (Exception ex) {
                    if (null == _CpuDetectionException) {
                        _CpuDetectionException = ex;
                    }
                    Trace.WriteLine("RefreshSelf_Wmic fail!");
                    Trace.WriteLine(ex);
                }
            } else {
#if NET5_0_OR_GREATER
                Architecture architectureWasm = Architecture.Wasm;
#else
                Architecture architectureWasm = (Architecture)4; // Wasm
#endif // NET5_0_OR_GREATER
                if (System.Runtime.InteropServices.RuntimeInformation.OSArchitecture == architectureWasm) {
                    _CpuDetectionException = new PlatformNotSupportedException(string.Format("Not supported on this platform({0}).", System.Runtime.InteropServices.RuntimeInformation.OSArchitecture));
                    return;
                }
                bool useCommnand = true;
                if (useCommnand) {
                    // lscpu.
                    try {
                        RefreshSelf_Lscpu(_CpuDetectionResult, ref _CpuDetectionCommand);
                    } catch (Exception ex) {
                        if (null == _CpuDetectionException) {
                            _CpuDetectionException = ex;
                        }
                        Trace.WriteLine("RefreshSelf_Lscpu fail!");
                        Trace.WriteLine(ex);
                    }
                    // Others.
                    if (string.IsNullOrEmpty(_CpuModelName)) {
                        string cmd = "";
                        List<string> list = new List<string>();
                        // sysctl.
                        try {
                            RefreshSelf_Sysctl(list, ref cmd);
                            _CpuDetectionCommand = cmd;
                            _CpuDetectionResult.Clear();
                            _CpuDetectionResult.AddRange(list);
                            _CpuDetectionException = null;
                        } catch (Exception ex) {
                            if (null == _CpuDetectionException) {
                                _CpuDetectionException = ex;
                            }
                            Trace.WriteLine("RefreshSelf_Sysctl fail!");
                            Trace.WriteLine(ex);
                        }
                    }
                } // if (useCommnand)
                // /proc/cpuinfo
                if (string.IsNullOrEmpty(_CpuModelName) || string.IsNullOrEmpty(_CpuFlags)) {
                    string cmd = "";
                    List<string> list = new List<string>();
                    bool allowPut = string.IsNullOrEmpty(_CpuModelName);
                    try {
                        RefreshSelf_ProcCpuinfo(list, ref cmd);
                        if (allowPut) {
                            _CpuDetectionCommand = cmd;
                            _CpuDetectionResult.Clear();
                            _CpuDetectionResult.AddRange(list);
                            _CpuDetectionException = null;
                        }
                    } catch (Exception ex) {
                        if (null == _CpuDetectionException && allowPut) {
                            _CpuDetectionException = ex;
                        }
                        Trace.WriteLine("RefreshSelf_ProcCpuinfo fail!");
                        Trace.WriteLine(ex);
                    }
                }
            } // if (IsWindowsPath())
        }

        /// <summary>
        /// Refresh self - wmic. It use for Windows system.
        /// </summary>
        /// <param name="list">Output list (输出列表).</param>
        /// <param name="commandName">Returns command name (返回命令名).</param>
        public void RefreshSelf_Wmic(IList<string> list, ref string commandName) {
            const StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
            string fileName = "wmic";
            string arguments = "cpu get /format:list";
            int countBlank = 0;
            commandName = fileName;
            list.Clear();
            ProcessUtil.RunAndFetchLines(delegate (bool isError, string line) {
                bool isBreak = false;
                bool needAdd = true;
                if (string.IsNullOrEmpty(line)) {
                    // Skip odd blank line.
                    ++countBlank;
                    if (0!=(countBlank&1)) {
                        needAdd = false;
                    }
                } else {
                    countBlank = 0;
                }
                if (needAdd) {
                    list.Add(line);
                }
                // parse.
                if (!string.IsNullOrEmpty(line)) {
                    if (isError) {
                        // StandardError
                    } else {
                        // StandardOutput
                        int n = line.IndexOf('=');
                        if (n > 0) {
                            string key = line.Substring(0, n).Trim();
                            if ("Name".Equals(key, comparisonType)) {
                                string val = line.Substring(n + 1).Trim();
                                if (string.IsNullOrEmpty(_CpuModelName)) {
                                    _CpuModelName = val;
                                }
                            }
                        }
                    }
                }
                return isBreak;
            }, fileName, arguments);
        }

        /// <summary>
        /// Refresh self - lscpu. It use for Linux system.
        /// </summary>
        public void RefreshSelf_Lscpu(IList<string> list, ref string commandName) {
            const StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
            string fileName = "lscpu";
            string arguments = "";
            commandName = fileName;
            list.Clear();
            ProcessUtil.RunAndFetchLines(delegate (bool isError, string line) {
                bool isBreak = false;
                bool needAdd = true;
                if (needAdd) {
                    list.Add(line);
                }
                // parse.
                if (!string.IsNullOrEmpty(line)) {
                    if (isError) {
                        // StandardError
                    } else {
                        // StandardOutput
                        int n = line.IndexOf(':');
                        if (n > 0) {
                            string key = line.Substring(0, n).Trim();
                            string val = line.Substring(n + 1).Trim();
                            if ("Model name".Equals(key, comparisonType)) {
                                if (string.IsNullOrEmpty(_CpuModelName)) {
                                    _CpuModelName = val;
                                }
                            } else if ("Flags".Equals(key, comparisonType)) {
                                if (string.IsNullOrEmpty(_CpuFlags)) {
                                    _CpuFlags = val;
                                }
                            }
                        }
                    }
                }
                return isBreak;
            }, fileName, arguments);
        }

        /// <summary>
        /// Refresh self - sysctl. It use for Mac OS system.
        /// </summary>
        public void RefreshSelf_Sysctl(IList<string> list, ref string commandName) {
            const StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
            string fileName = "sysctl";
            string arguments = "-a";
            commandName = fileName;
            list.Clear();
            ProcessUtil.RunAndFetchLines(delegate (bool isError, string line) {
                bool isBreak = false;
                bool needAdd = !string.IsNullOrEmpty(line) && line.Contains("cpu");
                if (needAdd) {
                    list.Add(line);
                }
                // parse.
                if (!string.IsNullOrEmpty(line)) {
                    if (isError) {
                        // StandardError
                    } else {
                        // StandardOutput
                        int n = line.IndexOf(':');
                        if (n > 0) {
                            string key = line.Substring(0, n).Trim();
                            if ("machdep.cpu.brand_string".Equals(key, comparisonType)) {
                                string val = line.Substring(n + 1).Trim();
                                if (string.IsNullOrEmpty(_CpuModelName)) {
                                    _CpuModelName = val;
                                }
                            }
                        }
                    }
                }
                return isBreak;
            }, fileName, arguments);
        }

        /// <summary>
        /// Refresh self - `/proc/cpuinfo`. It use for Linux system.
        /// </summary>
        public void RefreshSelf_ProcCpuinfo(IList<string> list, ref string commandName) {
            const StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
            string fileName = "/proc/cpuinfo";
            commandName = fileName;
            list.Clear();
            Func<bool, string, bool> onFetch = delegate (bool isError, string line) {
                bool isBreak = false;
                bool needAdd = true;
                if (needAdd) {
                    list.Add(line);
                }
                // parse.
                if (!string.IsNullOrEmpty(line)) {
                    if (isError) {
                        // StandardError
                    } else {
                        // StandardOutput
                        int n = line.IndexOf(':');
                        if (n > 0) {
                            string key = line.Substring(0, n).Trim();
                            string val = line.Substring(n + 1).Trim();
                            if ("model name".Equals(key, comparisonType)) {
                                if (string.IsNullOrEmpty(_CpuModelName)) {
                                    _CpuModelName = val;
                                }
                            } else if ("Features".Equals(key, comparisonType)) {
                                if (string.IsNullOrEmpty(_CpuFlags)) {
                                    _CpuFlags = val;
                                }
                            }
                        }
                    }
                }
                return isBreak;
            };
#if NETSTANDARD1_0_OR_GREATER && !NETSTANDARD1_3_OR_GREATER
            //throw new NotSupportedException("Not supported File!");
            string arguments = fileName;
            fileName = "cat";
            ProcessUtil.RunAndFetchLines(onFetch, fileName, arguments);
#else
            foreach (string line in File.ReadLines(fileName)) {
                onFetch(false, line);
            }
#endif
        }

        /// <summary>The instance (实例). </summary>
        public static CpuDetectionHelper Instance {
            get {
                if (null == _Instance) {
                    Refresh();
                }
                if (null == _Instance) {
                    throw new NotSupportedException("Not supported CpuDetectionHelper!");
                }
                return _Instance;
            }
        }

        /// <summary>
        /// CPU model name (CPU型号名).
        /// </summary>
        public string CpuModelName {
            get {
                return _CpuModelName;
            }
        }

        /// <summary>
        /// CPU feature Flags (CPU特征标志).
        /// </summary>
        public string CpuFlags {
            get {
                return _CpuFlags;
            }
        }

        /// <summary>
        /// Command used for CPU detection (CPU检测所用命令). e.g. `wmic` ...
        /// </summary>
        public string CpuDetectionCommand {
            get {
                return _CpuDetectionCommand;
            }
        }

        /// <summary>
        /// Latest exception during CPU detection (CPU检测时的最新异常).
        /// </summary>
        public Exception? CpuDetectionException {
            get {
                return _CpuDetectionException;
            }
        }

        /// <summary>
        /// The raw return value of the CPU detection. It is related to <see cref="CpuDetectionCommand"/> (CPU检测的原始返回值. 它与 CpuDetectionCommand 有关.).
        /// </summary>
        public IReadOnlyList<string> CpuDetectionResult {
            get {
                return _CpuDetectionResult;
            }
        }

    }
}
