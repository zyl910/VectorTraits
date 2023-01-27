using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Zyl.VectorTraits.Benchmarks {
    /// <summary>
    /// Simple benchmark writer (简单版基准测试文本写入).
    /// </summary>
    internal class SimpleBenchmarkWriter : AbstractBenchmarkWriter {

        /// <summary>
        /// Create.
        /// </summary>
        public SimpleBenchmarkWriter() : this(null, null) {
        }

        /// <summary>
        /// Create by currentTextWriter .
        /// </summary>
        /// <param name="currentTextWriter">Current <see cref="TextWriter"/> (当前 <see cref="TextWriter"/>).</param>
        public SimpleBenchmarkWriter(TextWriter? currentTextWriter) : this(currentTextWriter, null) {
        }

        /// <summary>
        /// Create by currentTextWriter, currentIndent .
        /// </summary>
        /// <param name="currentTextWriter">Current <see cref="TextWriter"/> (当前 <see cref="TextWriter"/>).</param>
        /// <param name="currentIndent">Current indent (当前缩进).</param>
        public SimpleBenchmarkWriter(TextWriter? currentTextWriter, string? currentIndent) : base(currentTextWriter, currentIndent) {
        }

        public override void WriteItem(string name, string text) {
            string msg = string.Format("{0}:\t{1}", name, text);
            WriteLine(msg);
        }

        public override void WriteItemBenchmark(string name, double us, double mops, double? scale = null) {
            string msg;
            if (null!= scale) {
                msg = string.Format("{0}:\tus={1:F3}, MOPS={2:F3}, scale={3:F6}", name, us, mops, scale);
            } else {
                msg = string.Format("{0}:\tus={1:F3}, MOPS={2:F3}", name, us, mops);
            }
            WriteLine(msg);
        }

        public override void WriteItemException(string name, Exception ex) {
            string msg = string.Format("{0}:\t{1}", name, ex.Message);
            WriteLine(msg);
        }

        public override void WriteTitle(string title) {
            //WriteLine();
            string msg = string.Format("[{0}]", title);
            WriteLine(msg);
        }
    }
}
