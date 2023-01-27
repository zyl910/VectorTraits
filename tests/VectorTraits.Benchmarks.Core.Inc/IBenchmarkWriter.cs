using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {
    /// <summary>
    /// Benchmark writer inteface (基准测试的文本写入接口).
    /// </summary>
    internal interface IBenchmarkWriter {
        /// <summary>Current <see cref="TextWriter"/> (当前 <see cref="TextWriter"/>).</summary>
        TextWriter? CurrentTextWriter { get; set; }
        /// <summary>Current indent (当前缩进).</summary>
        string? CurrentIndent { get; set; }

        /// <summary>
        /// Writes a string to the text stream (将字符串输出到流). If the given string is null, nothing is written to the text stream (如果所给字符串为null, 则不会写入到流.).
        /// </summary>
        /// <param name="value">The given string (所给字符串).</param>
        void WriteLine(string? value = null);

        /// <summary>
        /// Write title to the text stream (将标题输出到流).
        /// </summary>
        /// <param name="title">The title (标题).</param>
        void WriteTitle(string title);

        /// <summary>
        /// Write item text to the text stream (将条目文本输出到流).
        /// </summary>
        /// <param name="name">Item name (条目名).</param>
        /// <param name="text">The text (文本).</param>
        void WriteItem(string name, string text);

        /// <summary>
        /// Write item's <see cref="Exception"/> to the text stream (将条目的异常输出到流).
        /// </summary>
        /// <param name="name">Item name (条目名).</param>
        /// <param name="ex">The <see cref="Exception"/>.</param>
        void WriteItemException(string name, Exception ex);

        /// <summary>
        /// Write item's benchmark info to the text stream (将条目的基准测试信息输出到流).
        /// </summary>
        /// <param name="name">Item name (条目名).</param>
        /// <param name="us">Number of nanoseconds elapsed (耗时纳秒数).</param>
        /// <param name="mops">Million operations per second (百万次操作/秒).</param>
        /// <param name="scale">Performance scale for base benchmark (基础基准的性能比例). The value is null when the base benchmark (为基础基准时，其值为null).</param>
        void WriteItemBenchmark(string name, double us, double mops, double? scale = null);

    }
}
