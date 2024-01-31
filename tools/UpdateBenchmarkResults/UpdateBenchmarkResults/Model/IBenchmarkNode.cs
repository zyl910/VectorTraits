using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {
    /// <summary>
    /// Benchmark node interface.
    /// </summary>
    internal interface IBenchmarkNode<T> : ITitleGetter where T : ITitleGetter, new() {

        /// <summary>
        /// The List.
        /// </summary>
        public IList<T> List { get; set; }

        /// <summary>
        /// Find item by title.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="comparisonType">The comparison type.</param>
        /// <returns>Return found item.</returns>
        public T? FindByTitle(string title, StringComparison comparisonType = StringComparison.OrdinalIgnoreCase) {
            T? rt = List.FirstOrDefault(x => title.Equals(x.Title, comparisonType));
            return rt;
        }

    }

}
