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
        /// Extract case base title (返回事例基本标题). 即圆括号左侧的内容.
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

    }
}
