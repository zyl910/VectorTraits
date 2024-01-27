using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {
    /// <summary>
    /// The case of input.
    /// </summary>
    internal class InputCase {

        /// <summary>
        /// The title.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The Lines.
        /// </summary>
        public List<string> Lines { get; } = new List<string>();

    }
}
