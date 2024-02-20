using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {

    /// <summary>
    /// Benchmark group - File (基准测试组-文件).
    /// </summary>
    internal class BenchmarkGroupFile : AbstractBenchmarkNode<BenchmarkGroupPlatform>, ITitleGetter {

        /// <summary>
        /// The title (标题).
        /// </summary>
        public override string Title { get; set; } = string.Empty;

        /// <summary>
        /// The List.
        /// </summary>
        public override IList<BenchmarkGroupPlatform> List { get; set; } = new List<BenchmarkGroupPlatform>();

    }
}
