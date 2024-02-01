using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {
    /// <summary>
    /// Benchmark node interface.
    /// </summary>
    /// <typeparam name="T">The item type.</typeparam>
    public interface IBenchmarkNode<T> : ITitleGetter where T : ITitleGetter, new() {

        /// <summary>
        /// The List.
        /// </summary>
        public IList<T> List { get; set; }

    }

}
