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
        /// Extract case name (提取事例名称). 会去除方括号.
        /// </summary>
        /// <param name="line">Text line (文本行).</param>
        /// <returns>Returns case name (返回事例名称). 找不到时返回空串.</returns>
        public static string ExtractCaseName(string line) {
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

    }
}
