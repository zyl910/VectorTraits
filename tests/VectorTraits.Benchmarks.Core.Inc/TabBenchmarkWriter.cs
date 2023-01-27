using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {
    /// <summary>
    /// Tab separated benchmark writer (制表符分隔版基准测试文本写入).
    /// </summary>
    internal class TabBenchmarkWriter : AbstractBenchmarkWriter {

        /// <summary>
        /// Create.
        /// </summary>
        public TabBenchmarkWriter() : this(null, null) {
        }

        /// <summary>
        /// Create by currentTextWriter .
        /// </summary>
        /// <param name="currentTextWriter">Current <see cref="TextWriter"/> (当前 <see cref="TextWriter"/>).</param>
        public TabBenchmarkWriter(TextWriter? currentTextWriter) : this(currentTextWriter, null) {
        }

        /// <summary>
        /// Create by currentTextWriter, currentIndent .
        /// </summary>
        /// <param name="currentTextWriter">Current <see cref="TextWriter"/> (当前 <see cref="TextWriter"/>).</param>
        /// <param name="currentIndent">Current indent (当前缩进).</param>
        public TabBenchmarkWriter(TextWriter? currentTextWriter, string? currentIndent) : base(currentTextWriter, currentIndent) {
        }

        public override void WriteItem(string name, string text) {
            string msg = string.Format("{0}\t{1}", name, text);
            WriteLine(msg);
        }

        public override void WriteItemBenchmark(string name, double us, double mops, double? scale = null) {
            string msg;
            if (null != scale) {
                msg = string.Format("{0}\t{1:F3}\t{2:F3}\t{3:F6}", name, us, mops, scale);
            } else {
                msg = string.Format("{0}\t{1:F3}\t{2:F3}", name, us, mops);
            }
            WriteLine(msg);
        }

        public override void WriteItemException(string name, Exception ex) {
            string msg = string.Format("{0}\t{1}", name, ex.Message);
            WriteLine(msg);
        }

        public override void WriteTitle(string title) {
            //WriteLine();
            string msg = string.Format("[{0}]", title);
            WriteLine(msg);
            WriteLine("---");
            WriteLine("NAME\tUS\tMOPS\tSCALE");
        }
    }
}
