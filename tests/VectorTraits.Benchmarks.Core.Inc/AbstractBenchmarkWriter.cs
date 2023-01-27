using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {
    /// <summary>
    /// Abstract benchmark writer (抽象版基准测试文本写入).
    /// </summary>
    internal abstract class AbstractBenchmarkWriter : IBenchmarkWriter {
        /// <summary>Current <see cref="TextWriter"/> (当前 <see cref="TextWriter"/>).</summary>
        protected TextWriter? _currentTextWriter;
        /// <summary>Current indent (当前缩进).</summary>
        protected string? _currentIndent;

        /// <summary>
        /// Create.
        /// </summary>
        public AbstractBenchmarkWriter() : this(null, null) {
        }

        /// <summary>
        /// Create by currentTextWriter .
        /// </summary>
        /// <param name="currentTextWriter">Current <see cref="TextWriter"/> (当前 <see cref="TextWriter"/>).</param>
        public AbstractBenchmarkWriter(TextWriter? currentTextWriter) : this(currentTextWriter, null) {
        }

        /// <summary>
        /// Create by currentTextWriter, currentIndent .
        /// </summary>
        /// <param name="currentTextWriter">Current <see cref="TextWriter"/> (当前 <see cref="TextWriter"/>).</param>
        /// <param name="currentIndent">Current indent (当前缩进).</param>
        public AbstractBenchmarkWriter(TextWriter? currentTextWriter, string? currentIndent) {
            _currentTextWriter = currentTextWriter;
            _currentIndent = currentIndent;
        }

        public virtual void WriteLine(string? value = null) {
            TextWriter? textWriter = CurrentTextWriter;
            if (null == textWriter) return;
            if (string.IsNullOrEmpty(value)) {
                textWriter.WriteLine();
            } else {
                string? indent = CurrentIndent;
                if (string.IsNullOrEmpty(indent)) {
                    textWriter.WriteLine(value);
                } else {
                    textWriter.WriteLine(indent + value);
                }
            }
        }

        public abstract void WriteTitle(string title);
        public abstract void WriteItem(string name, string text);
        public abstract void WriteItemBenchmark(string name, double us, double mops, double? scale = null);
        public abstract void WriteItemException(string name, Exception ex);

        public virtual TextWriter? CurrentTextWriter {
            get {
                return _currentTextWriter;
            }
            set {
                _currentTextWriter = value;
            }
        }

        public virtual string? CurrentIndent {
            get {
                return _currentIndent;
            }
            set {
                _currentIndent = value;
            }
        }
    }
}
