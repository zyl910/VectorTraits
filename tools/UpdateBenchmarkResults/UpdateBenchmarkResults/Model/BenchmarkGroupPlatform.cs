using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UpdateBenchmarkResults.Model {

    /// <summary>
    /// Benchmark group - Platform (基准测试组-平台).
    /// </summary>
    internal class BenchmarkGroupPlatform : AbstractBenchmarkNode<BenchmarkGroupCase>, ITitleGetter {

        /// <summary>
        /// The title (标题).
        /// </summary>
        public override string Title { get; set; } = string.Empty;

        /// <summary>
        /// Raw (原始数据).
        /// </summary>
        public BenchmarkCpu? Raw { get; set; } = null;

        /// <summary>
        /// Field names (字段名列表).
        /// </summary>
        public IList<string> FieldNames { get; set; } = new List<string>();

        /// <summary>
        /// The List.
        /// </summary>
        public override IList<BenchmarkGroupCase> List { get; set; } = new List<BenchmarkGroupCase>();

    }
}
