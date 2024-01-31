using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {
    /// <summary>
    /// The architecture of BenchmarkResults.
    /// </summary>
    internal class BenchmarkArchitecture : ITitleGetter, IBenchmarkNode<BenchmarkCpu> {

        /// <summary>
        /// The title (标题).
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The List.
        /// </summary>
        public IList<BenchmarkCpu> List { get; set; } = new List<BenchmarkCpu>();
    }
}
