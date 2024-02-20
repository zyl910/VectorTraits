using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {

    /// <summary>
    /// Benchmark group - Case (基准测试组-案例).
    /// </summary>
    internal class BenchmarkGroupCase : AbstractBenchmarkNode<BenchmarkGroupRow>, ITitleGetter {

        /// <summary>
        /// The title (标题).
        /// </summary>
        public override string Title { get; set; } = string.Empty;

        /// <summary>
        /// The base title (基本标题).
        /// </summary>
        public string BaseTitle { get; set; } = string.Empty;

        /// <summary>
        /// The List.
        /// </summary>
        public override IList<BenchmarkGroupRow> List { get; set; } = new List<BenchmarkGroupRow>();

    }
}
