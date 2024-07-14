using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits {

    /// <summary>
    /// Some utility functions are provided for ExType vectors. For example, the Format function can be used to safely output an ExType vector (为ExType 向量, 提供了一些 的工具函数. 例如用 Format 函数可以安全的输出ExType 向量).
    /// </summary>
    /// <remarks>
    /// <para>When a vector type contains an ExType, an exception will occur if it is format as a string. Using methods of this class, the format can be done safely. (当向量类型里含有 ExType 时, 若直接使用字符串格式化, 会有异常. 而使用本类的办法后, 能安全地进行格式化).</para>
    /// </remarks>
    public static class ExVectorUtil {

        /// <summary>
        /// Returns a string that represents the current object. It is used to replace the ToString method for vector types and no longer throws exceptions (返回表示当前对象的字符串. 用于替代向量类型的 ToString 方法. 它用于替换向量类型的 ToString 方法，不再抛出异常).
        /// </summary>
        /// <typeparam name="T">Type of parameter (参数的类型).</typeparam>
        /// <param name="arg">The parameter (参数).</param>
        /// <returns>A string that represents the current object (表示当前对象的字符串).</returns>
        public static string Format<T>(T arg) {
            return string.Format(ExVectorFormatter.Instance, "{0}", arg);
        }

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

#if NETCOREAPP1_0_OR_GREATER || NET46_OR_GREATER || NETSTANDARD1_3_OR_GREATER
        // FormattableString: .NET Core 1.0+, .NET Framework 4.6+, .NET Standard 1.3+

        /// <summary>
        /// Safely convert interpolated string to <see cref="string"/>. Based on <see cref="FormattableString"/> (安全地将内插字符串转为 <see cref="string"/>. 基于 <see cref="FormattableString"/>).
        /// </summary>
        /// <param name="message">The format (格式).</param>
        /// <returns>Formatted string (格式化之后的字符串).</returns>
        /// <remarks>
        /// <para>When a vector type contains an ExType, an exception occurs if the vector type is directly interpolated. With this method, the format can be done safely (当向量类型里含有 ExType 时, 若直接使用内插字符串, 会有异常. 而使用本办法后, 能安全地进行格式化).</para>
        /// <code>
        /// var temp = Vectors&lt;int&gt;.Serial.ExAsExInt128();
        /// // Bug! - Console.Out.WriteLine($"InterpolatedString:\t{temp}."); // System.NotSupportedException: Specified type is not supported
        /// Console.Out.WriteLine(ExVectorUtil.ToString($"InterpolatedString:\t{temp}.")); // Successes.
        /// </code>
        /// </remarks>
        public static string ToString(FormattableString message) {
            return message.ToString(ExVectorFormatter.Instance);
        }

        /// <summary>
        /// Safely convert interpolated string to <see cref="string"/>, with <paramref name="provider"/> parameter. Based on <see cref="FormattableString"/> (安全地将内插字符串转为 <see cref="string"/>, 带有 <paramref name="provider"/> 参数. 基于 <see cref="FormattableString"/>).
        /// </summary>
        /// <param name="provider">An object that provides culture-specific formatting information (一个提供区域性特定的格式设置信息的对象).</param>
        /// <param name="message">The format (格式).</param>
        /// <returns>Formatted string (格式化之后的字符串).</returns>
        public static string ToString(IFormatProvider? provider, FormattableString message) {
            return message.ToString(new ExVectorFormatter(provider));
        }
#endif

#if NET6_0_OR_GREATER
        // DefaultInterpolatedStringHandler: .NET 6+
        // But throw exception before call ToString - System.NotSupportedException: Specified type is not supported
/*
        /// <summary>
        /// Safely convert interpolated string to <see cref="string"/>. Based on <see cref="DefaultInterpolatedStringHandler"/> (安全地将内插字符串转为 <see cref="string"/>. 基于 <see cref="DefaultInterpolatedStringHandler"/>).
        /// </summary>
        /// <param name="handler">The interpolated string, passed by reference (按引用传递的内插字符串).</param>
        /// <returns>Formatted string (格式化之后的字符串).</returns>
        /// <remarks>
        /// <para>When a vector type contains an ExType, an exception occurs if the vector type is directly interpolated. With this method, the format can be done safely (当向量类型里含有 ExType 时, 若直接使用内插字符串, 会有异常. 而使用本办法后, 能安全地进行格式化).</para>
        /// <code>
        /// var temp = Vectors&lt;int&gt;.Serial.ExAsExInt128();
        /// // Bug! - Console.Out.WriteLine($"InterpolatedString:\t{temp}."); // System.NotSupportedException: Specified type is not supported
        /// Console.Out.WriteLine(ExVectorUtil.ToString($"InterpolatedString:\t{temp}.")); // Successes.
        /// </code>
        /// </remarks>
        public static string ToString(ref DefaultInterpolatedStringHandler handler) {
            return string.Create(ExVectorFormatter.Instance, ref handler);
        }

        /// <summary>
        /// Safely convert interpolated string to <see cref="string"/>, with <paramref name="provider"/> parameter. Based on <see cref="DefaultInterpolatedStringHandler"/> (安全地将内插字符串转为 <see cref="string"/>, 带有 <paramref name="provider"/> 参数. 基于 <see cref="DefaultInterpolatedStringHandler"/>).
        /// </summary>
        /// <param name="provider">An object that provides culture-specific formatting information (一个提供区域性特定的格式设置信息的对象).</param>
        /// <param name="handler">The interpolated string, passed by reference (按引用传递的内插字符串).</param>
        /// <returns>Formatted string (格式化之后的字符串).</returns>
        public static string ToString(IFormatProvider? provider, ref DefaultInterpolatedStringHandler handler) {
            return string.Create(new ExVectorFormatter(provider), ref handler);
        }
*/
#endif // NET6_0_OR_GREATER

    }

}
