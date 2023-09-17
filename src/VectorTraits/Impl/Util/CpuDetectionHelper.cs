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
            // wmic.
            try {
                RefreshSelf_Wmic();
            } catch (Exception ex) {
                if (null== _CpuDetectionException) {
                    _CpuDetectionException = ex;
                }
                Trace.WriteLine("RefreshSelf_Wmic fail!");
                Trace.WriteLine(ex);
            }
        }

        /// <summary>
        /// Refresh self - wmic.
        /// </summary>
        public void RefreshSelf_Wmic() {
            const StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
            string fileName = "wmic";
            string arguments = "cpu get /format:list";
            int countBlank = 0;
            _CpuDetectionResult.Clear();
            ProcessUtil.RunAndFetchLines(delegate (bool isError, string line) {
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
                    _CpuDetectionResult.Add(line);
                }
                // parse.
                if (string.IsNullOrEmpty(line)) return;
                if (isError) {
                    // StandardError
                } else {
                    // StandardOutput
                    int n = line.IndexOf('=');
                    if (n>0) {
                        string key = line.Substring(0, n).Trim();
                        if ("Name".Equals(key, comparisonType)) {
                            string val = line.Substring(n + 1).Trim();
                            if (string.IsNullOrEmpty(_CpuModelName)) {
                                _CpuModelName = val;
                            }
                        }
                    }
                }
            }, fileName, arguments);
            _CpuDetectionCommand = fileName;
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
