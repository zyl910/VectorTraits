﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {
    /// <summary>
    /// The file of BenchmarkResults.
    /// </summary>
    internal class BenchmarkFile : AbstractBenchmarkNode<BenchmarkArchitecture>, ITitleGetter {

        /// <summary>
        /// The title (标题).
        /// </summary>
        public override string Title { get; set; } = string.Empty;

        /// <summary>
        /// The List.
        /// </summary>
        public override IList<BenchmarkArchitecture> List { get; set; } = new List<BenchmarkArchitecture>();
    }
}
