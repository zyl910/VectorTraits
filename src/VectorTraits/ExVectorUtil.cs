using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Zyl.VectorTraits {

    /// <summary>
    /// Some utility functions are provided for ExType vectors. For example, the Format function can be used to safely output an ExType vector (为ExType 向量, 提供了一些 的工具函数. 例如用 Format 函数可以安全的输出ExType 向量).
    /// </summary>
    public static class ExVectorUtil {

        /// <inheritdoc cref="string.Format(string, object?)"/>
        public static string Format(
#if NET7_0_OR_GREATER
                [StringSyntax(StringSyntaxAttribute.CompositeFormat)]
#endif // NET7_0_OR_GREATER
                string format, object? arg0) {
            return string.Format(ExVectorFormatter.Instance, format, arg0);
        }

        /// <inheritdoc cref="string.Format(string, object?, object?)"/>
        public static string Format(
#if NET7_0_OR_GREATER
                [StringSyntax(StringSyntaxAttribute.CompositeFormat)]
#endif // NET7_0_OR_GREATER
                string format, object? arg0, object? arg1) {
            return string.Format(ExVectorFormatter.Instance, format, arg0, arg1);
        }

        /// <inheritdoc cref="string.Format(string, object?, object?, object?)"/>
        public static string Format(
#if NET7_0_OR_GREATER
                [StringSyntax(StringSyntaxAttribute.CompositeFormat)]
#endif // NET7_0_OR_GREATER
                string format, object? arg0, object? arg1, object? arg2) {
            return string.Format(ExVectorFormatter.Instance, format, arg0, arg1, arg2);
        }

        /// <inheritdoc cref="string.Format(string, object?[])"/>
        public static string Format(
#if NET7_0_OR_GREATER
                [StringSyntax(StringSyntaxAttribute.CompositeFormat)]
#endif // NET7_0_OR_GREATER
                string format, params object?[] args) {
            return string.Format(ExVectorFormatter.Instance, format, args);
        }

        /// <inheritdoc cref="string.Format(IFormatProvider?, string, object?)"/>
        public static string Format(IFormatProvider? provider,
#if NET7_0_OR_GREATER
                [StringSyntax(StringSyntaxAttribute.CompositeFormat)]
#endif // NET7_0_OR_GREATER
                string format, object? arg0) {
            return string.Format(new ExVectorFormatter(provider), format, arg0);
        }

        /// <inheritdoc cref="string.Format(IFormatProvider?, string, object?, object?)"/>
        public static string Format(IFormatProvider? provider,
#if NET7_0_OR_GREATER
                [StringSyntax(StringSyntaxAttribute.CompositeFormat)]
#endif // NET7_0_OR_GREATER
                string format, object? arg0, object? arg1) {
            return string.Format(new ExVectorFormatter(provider), format, arg0, arg1);
        }

        /// <inheritdoc cref="string.Format(IFormatProvider?, string, object?, object?, object?)"/>
        public static string Format(IFormatProvider? provider,
#if NET7_0_OR_GREATER
                [StringSyntax(StringSyntaxAttribute.CompositeFormat)]
#endif // NET7_0_OR_GREATER
                string format, object? arg0, object? arg1, object? arg2) {
            return string.Format(new ExVectorFormatter(provider), format, arg0, arg1, arg2);
        }

        /// <inheritdoc cref="string.Format(IFormatProvider?, string, object?[])"/>
        public static string Format(IFormatProvider? provider,
#if NET7_0_OR_GREATER
                [StringSyntax(StringSyntaxAttribute.CompositeFormat)]
#endif // NET7_0_OR_GREATER
                string format, params object?[] args) {
            return string.Format(new ExVectorFormatter(provider), format, args);
        }

#if NET8_0_OR_GREATER

        /// <inheritdoc cref="string.Format{TArg0}(IFormatProvider?, CompositeFormat, TArg0)"/>
        public static string Format<TArg0>(IFormatProvider? provider, CompositeFormat format, TArg0 arg0) {
            return string.Format(new ExVectorFormatter(provider), format, arg0);
        }

        /// <inheritdoc cref="string.Format{TArg0, TArg1}(IFormatProvider?, CompositeFormat, TArg0, TArg1)"/>
        public static string Format<TArg0, TArg1>(IFormatProvider? provider, CompositeFormat format, TArg0 arg0, TArg1 arg1) {
            return string.Format(new ExVectorFormatter(provider), format, arg0, arg1);
        }

        /// <inheritdoc cref="string.Format{TArg0, TArg1, TArg2}(IFormatProvider?, CompositeFormat, TArg0, TArg1, TArg2)"/>
        public static string Format<TArg0, TArg1, TArg2>(IFormatProvider? provider, CompositeFormat format, TArg0 arg0, TArg1 arg1, TArg2 arg2) {
            return string.Format(new ExVectorFormatter(provider), format, arg0, arg1, arg2);
        }

        /// <inheritdoc cref="string.Format(IFormatProvider?, CompositeFormat, object?[])"/>
        public static string Format(IFormatProvider? provider, CompositeFormat format, params object?[] args) {
            return string.Format(new ExVectorFormatter(provider), format, args);
        }

        /// <inheritdoc cref="string.Format(IFormatProvider?, CompositeFormat, ReadOnlySpan{object?})"/>
        public static string Format(IFormatProvider? provider, CompositeFormat format, ReadOnlySpan<object?> args) {
            return string.Format(new ExVectorFormatter(provider), format, args);
        }

#endif // NET8_0_OR_GREATER

    }

}
