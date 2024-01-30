using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static UpdateBenchmarkResults.Service.BenchmarkResultsService;
using UpdateBenchmarkResults.Model;

namespace UpdateBenchmarkResults.Common {
    /// <summary>
    /// Benchmark string util.
    /// </summary>
    internal static class BenchmarkStringUtil {
        /// <summary>
        /// Common comparison type.
        /// </summary>
        public const StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;

        /// <summary>
        /// Prefix - CpuModelName.
        /// </summary>
        public static readonly string CpuModelNamePrefix = "VectorEnvironment.CpuModelName:";

        /// <summary>
        /// Prefix - OSArchitecture.
        /// </summary>
        public static readonly string OSArchitecturePrefix = "RuntimeInformation.OSArchitecture:";

        /// <summary>
        /// Architecture string to architecture family dictionary (架构系列转架构系列的词典).
        /// </summary>
        public static readonly IDictionary<string, string> ToArchitectureFamilyDictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {
            { "Arm", "Arm" },
            { "Arm64", "Arm" },
            { "Armv6", "Arm" },
            { "LoongArch64", "LoongArch" },
            { "Ppc64le", "PowerPC" },
            { "S390x", "S390x" },
            { "Wasm", "Wasm" },
            { "X64", "X86" },
            { "X86", "X86" },
        };

        /// <summary>
        /// Architecture family to architecture sort code dictionary (架构系列转架构系列的词典).
        /// </summary>
        public static readonly IDictionary<string, string> ToArchitectureSortCodeDictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {
            { "Arm", "20" },
            { "Arm64", "21" },
            { "Armv6", "22" },
            { "LoongArch", "30" },
            { "LoongArch64", "31" },
            { "PowerPC", "40" },
            { "Ppc64le", "41" },
            { "S390x", "60" },
            { "Wasm", "50" },
            { "X64", "11" },
            { "X86", "10" },
        };

        /// <summary>
        /// Get value by prefix (根据前缀获得值).
        /// </summary>
        /// <param name="prefix">The prefix (前缀).</param>
        /// <param name="src">Source text (源文本).</param>
        /// <returns>Returns value (返回值). 找不到时返回空串.</returns>
        public static string GetValueByPrefix(string prefix, string src) {
            string rt = string.Empty;
            int m = src.IndexOf(prefix, comparisonType);
            if (m >= 0) {
                rt = src.Substring(m + prefix.Length).Trim();
            }
            return rt;
        }

        /// <summary>
        /// Get sub path (取得子路径).
        /// </summary>
        /// <param name="rootPath">Root path (根路径).</param>
        /// <param name="fullPath">Full path (完全路径).</param>
        /// <returns>Returns sub path (返回子路径).</returns>
        public static string GetSubPath(string? rootPath, string fullPath) {
            string rt = fullPath;
            if (null == rootPath || rootPath.Length <= 1) return rt;
            if (fullPath.Length <= rootPath.Length) return rt;
            int m = rootPath.Length;
            char ch = fullPath[m];
            if (ch == '/' || ch == '\\') {
                ++m;
            }
            rt = fullPath.Substring(m);
            return rt;
        }

        /// <summary>
        /// Extract case title (提取事例标题). 会去除方括号.
        /// </summary>
        /// <param name="line">Text line (文本行).</param>
        /// <returns>Returns case name (返回事例标题). 找不到时返回空串.</returns>
        public static string ExtractCaseTitle(string line) {
            string rt = string.Empty;
            if (string.IsNullOrEmpty(line)) return rt;
            if (line.StartsWith('[')) {
                int n = line.IndexOf(']');
                if (n > 0) {
                    rt = line.Substring(1, n - 1);
                }
            }
            return rt;
        }

        /// <summary>
        /// Get case base title (返回事例基本标题). 即圆括号左侧的内容.
        /// </summary>
        /// <param name="src">Source text (源文本).</param>
        /// <returns>Returns case base name (返回事例基本标题). 找不到时返回空串.</returns>
        public static string GetCaseBaseTitle(string src) {
            string rt = string.Empty;
            if (string.IsNullOrEmpty(src)) return rt;
            int n = src.IndexOf('(');
            if (n > 0) {
                rt = src.Substring(0, n).Trim();
            }
            return rt;
        }

        /// <summary>
        /// Get case primary title (返回事例主标题). 即最后一个下换线左侧的内容.
        /// </summary>
        /// <param name="src">Source text (源文本).</param>
        /// <returns>Returns case primary name (返回事例主标题). 找不到时返回空串.</returns>
        public static string GetCasePrimaryTitle(string src) {
            string rt = string.Empty;
            if (string.IsNullOrEmpty(src)) return rt;
            int n = src.LastIndexOf('_');
            if (n > 0) {
                rt = src.Substring(0, n).Trim();
            }
            return rt;
        }

        /// <summary>
        /// Get architecture family (取得架构系列).
        /// </summary>
        /// <param name="architectureString">Architecture string (架构字符串).</param>
        /// <returns>Returns architecture family (返回架构系列). 找不到时返回源值.</returns>
        public static string GetArchitectureFamily(string architectureString) {
            string? rt;
            if (!ToArchitectureFamilyDictionary.TryGetValue(architectureString, out rt)) {
                rt = null;
            }
            if (null == rt) rt = architectureString;
            return rt;
        }

        /// <summary>
        /// Get architecture sort code (取得架构排序代码).
        /// </summary>
        /// <param name="architectureFamily">Architecture family (架构系列).</param>
        /// <returns>Returns architecture sort code (返回架构排序代码). 找不到时返回源值.</returns>
        public static string GetArchitectureSortCode(string architectureFamily) {
            string? rt;
            if (!ToArchitectureSortCodeDictionary.TryGetValue(architectureFamily, out rt)) {
                rt = null;
            }
            if (null == rt) rt = architectureFamily;
            return rt;
        }

    }
}
