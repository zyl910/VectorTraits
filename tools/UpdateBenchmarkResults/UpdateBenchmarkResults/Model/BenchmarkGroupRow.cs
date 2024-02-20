using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {

    /// <summary>
    /// Benchmark group - Row (基准测试组-行).
    /// </summary>
    internal class BenchmarkGroupRow : ITitleGetter {

        /// <summary>
        /// The title (标题).
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The field values (字段值列表).
        /// </summary>
        public IList<string> Values { get; set; } = new List<string>();
    }

}
