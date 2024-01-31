using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {
    /// <summary>
    /// The framework of BenchmarkResults.
    /// </summary>
    internal class BenchmarkFramework : ITitleGetter {

        /// <summary>
        /// The title (标题).
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The Header lines.
        /// </summary>
        public List<string> Header { get; set; } = new List<string>();

        /// <summary>
        /// The Cases.
        /// </summary>
        public IDictionary<string, BenchmarkCase> Cases { get; set; } = new SortedDictionary<string, BenchmarkCase>();

        /// <summary>
        /// Group counter (组的计数器).
        /// </summary>
        public IDictionary<string, int> GroupCounter { get; set; } = new SortedDictionary<string, int>();

        /// <summary>
        /// Get group names.
        /// </summary>
        /// <returns>Returns group names.</returns>
        public string GetGroupNames() {
            string[] list = GroupCounter.Keys.ToArray();
            string rt = string.Join(", ", list);
            return rt;
        }

        /// <summary>
        /// Find case by title.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <returns>Return found item.</returns>
        public BenchmarkCase? FindByTitle(string title) {
            BenchmarkCase? rt;
            if (!Cases.TryGetValue(title, out rt)) {
                rt = null;
            }
            return rt;
        }

    }
}
