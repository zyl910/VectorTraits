﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateBenchmarkResults.Common {
    /// <summary>
    /// Vector text util
    /// </summary>
    internal static class VectorTextUtil {

        /// <summary>Separator for key-value pairs (键值对的分隔符).</summary>
        public static readonly string KeyValueSeparator = "=";

        /// <summary>
        /// Splitting key-value pairs (拆分键值对).
        /// </summary>
        /// <param name="src">Source string(源字符串).</param>
        /// <param name="key">Returns the key(返回键名)</param>
        /// <param name="separator">The separator (分隔符). Default value is <see cref="KeyValueSeparator"/>.</param>
        /// <returns>Returns the value. Returns empty if there is no value (返回值. 没有值时返回空).</returns>
        public static ReadOnlySpan<char> SplitKeyValue(string src, out string key, string? separator = null) {
            ReadOnlySpan<char> rt = ReadOnlySpan<char>.Empty;
            key = src;
            if (!string.IsNullOrEmpty(src)) {
                if (null == separator || string.IsNullOrEmpty(separator)) {
                    separator = KeyValueSeparator;
                }
                int n = src.IndexOf(separator);
                if (n >= 0) {
                    key = src.Substring(0, n);
                    rt = src.AsSpan(n + separator.Length);
                }
            }
            return rt;
        }

        /// <summary>
        /// Splitting key-value pairs and converting values to integer (拆分键值对, 并将值转换为整数).
        /// </summary>
        /// <param name="src">Source string(源字符串).</param>
        /// <param name="key">Returns the key(返回键名)</param>
        /// <param name="defaultValue">Default value (默认值).</param>
        /// <param name="separator">The separator (分隔符). Default value is <see cref="KeyValueSeparator"/>.</param>
        /// <returns>Returns the value (返回值).</returns>
        public static int SplitKeyValueToInt(string src, out string key, int defaultValue = 0, string? separator = null) {
            int rt = defaultValue;
            ReadOnlySpan<char> v = SplitKeyValue(src, out key, separator);
            if (!v.IsEmpty) {
                if (!TryParseInt32(v, out rt)) {
                    rt = defaultValue;
                }
            }
            return rt;
        }

        /// <inheritdoc cref="int.TryParse(ReadOnlySpan{char}, out int)"/>
        public static bool TryParseInt32(ReadOnlySpan<char> s, out int result) {
#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            return int.TryParse(s, out result);
#else
            return int.TryParse(s.ToString(), out result);
#endif
        }

        /// <summary>
        /// Parse string to <see cref="Int32"/> (解析字符串并转为Int32).
        /// </summary>
        /// <param name="s">Source string (源字符串).</param>
        /// <param name="defaultValue">Default value(默认值).</param>
        /// <returns>Returns the parsed value. If parsing fails, return <paramref name="defaultValue"/> (返回解析后的值. 解析失败时返回 defaultValue).</returns>
        public static int ParseInt32(ReadOnlySpan<char> s, int defaultValue = 0) {
            if (TryParseInt32(s, out int rt)) {
                return rt;
            }
            return defaultValue;
        }

    }
}
