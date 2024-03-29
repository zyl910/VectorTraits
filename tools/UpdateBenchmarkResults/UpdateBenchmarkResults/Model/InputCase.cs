﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Model {
    /// <summary>
    /// The case of input.
    /// </summary>
    internal class InputCase: ITitleGetter {

        /// <summary>
        /// The title (标题).
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The base title (基本标题).
        /// </summary>
        public string BaseTitle { get; set; } = string.Empty;

        /// <summary>
        /// The primary title (主标题).
        /// </summary>
        public string PrimaryTitle { get; set; } = string.Empty;

        /// <summary>
        /// The text lines (文本行).
        /// </summary>
        public List<string> Lines { get; set; } = new List<string>();

    }
}
