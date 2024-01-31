using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {
    /// <summary>
    /// The CPU of BenchmarkResults.
    /// </summary>
    internal class BenchmarkCpu : ITitleGetter, IBenchmarkNode<BenchmarkFramework> {

        /// <summary>
        /// The title (标题).
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The List.
        /// </summary>
        public IList<BenchmarkFramework> List { get; set; } = new List<BenchmarkFramework>();

    }
}
