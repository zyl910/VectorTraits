using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {
    /// <summary>
    /// The case record of BenchmarkResults.
    /// </summary>
    internal class BenchmarkCaseRecord : ITitleGetter {

        /// <summary>
        /// The title (标题).
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The title (微秒us).
        /// </summary>
        public string us { get; set; } = string.Empty;

        /// <summary>
        /// The mops (兆每秒 (Mega/second)).
        /// </summary>
        public string mops { get; set; } = string.Empty;

        /// <summary>
        /// The scale (倍数).
        /// </summary>
        public string scale { get; set; } = string.Empty;

    }

}

