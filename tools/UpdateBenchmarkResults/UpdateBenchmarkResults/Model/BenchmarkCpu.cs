using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {
    /// <summary>
    /// The CPU of BenchmarkResults.
    /// </summary>
    internal class BenchmarkCpu : AbstractBenchmarkNode<BenchmarkFramework>, ITitleGetter {

        /// <summary>
        /// The title (标题).
        /// </summary>
        public override string Title { get; set; } = string.Empty;

        /// <summary>
        /// The List.
        /// </summary>
        public override IList<BenchmarkFramework> List { get; set; } = new List<BenchmarkFramework>();

    }
}
