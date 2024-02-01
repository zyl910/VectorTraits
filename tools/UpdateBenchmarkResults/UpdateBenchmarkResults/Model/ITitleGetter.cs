using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {
    /// <summary>
    /// Title getter interface.
    /// </summary>
    public interface ITitleGetter {

        /// <summary>
        /// The title (标题).
        /// </summary>
        public string Title { get; set; }

    }
}
