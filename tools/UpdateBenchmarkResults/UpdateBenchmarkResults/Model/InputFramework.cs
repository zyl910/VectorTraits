using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {
    /// <summary>
    /// The framework of input.
    /// </summary>
    internal class InputFramework {

        /// <summary>
        /// The title.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The Header lines.
        /// </summary>
        public List<string> Header { get; } = new List<string>();

        /// <summary>
        /// The Cases.
        /// </summary>
        public IDictionary<string, InputCase> Cases { get; } = new SortedDictionary<string, InputCase>();

    }
}
