using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;

namespace Zyl.VectorTraits {
    /// <summary>
    /// (ExType) Format provider for extended type vectors (扩展类型向量的格式提供者).
    /// </summary>
    public class ExVectorFormatter : IFormatProvider, ICustomFormatter {
        /// <summary>
        /// Global Instance (全局实例).
        /// </summary>
        public static readonly ExVectorFormatter Instance = new ExVectorFormatter();

        /// <summary>
        /// Next format provider (下一个格式提供者).
        /// </summary>
        public IFormatProvider? NextProvider { get; set; }

        /// <summary>
        /// Create ExVectorFormatter, with nextProvider params.
        /// </summary>
        public ExVectorFormatter(IFormatProvider? nextProvider) {
            NextProvider = nextProvider;
        }

        /// <summary>
        /// Create ExVectorFormatter.
        /// </summary>
        public ExVectorFormatter() : this(null) {
        }

        /// <inheritdoc cref="IFormatProvider.GetFormat(Type?)"/>
        public object? GetFormat(Type? formatType) {
            if (typeof(ICustomFormatter) == formatType)
                return this;
            else
                return null;
        }

        /// <summary>
        /// Handle other formats (处理其他格式).
        /// </summary>
        /// <param name="format">A format string containing formatting specifications (包含格式规范的格式字符串).</param>
        /// <param name="arg">An object to format(要设置其格式的对象).</param>
        /// <param name="formatProvider">An object that supplies format information about the current instance (一个对象，提供有关当前实例的区域性特定格式信息).</param>
        /// <returns>Formatted string (格式化之后的字符串).</returns>
        private static string HandleOtherFormats(string? format, object? arg, IFormatProvider formatProvider) {
            if (arg == null) return string.Empty;
            if (arg is IFormattable) return ((IFormattable)arg).ToString(format, formatProvider);
            return arg.ToString() ?? string.Empty;
        }

        /// <summary>
        /// Call Format method (调用 Format 方法).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="format">A format string containing formatting specifications (包含格式规范的格式字符串).</param>
        /// <param name="arg">An object to format(要设置其格式的对象).</param>
        /// <param name="formatProvider">An object that supplies format information about the current instance (一个对象，提供有关当前实例的区域性特定格式信息).</param>
        /// <returns>Formatted string (格式化之后的字符串).</returns>
        private static string CallFormat<T>(string? format, Vector<T> arg, IFormatProvider formatProvider) where T : struct {
            if (Vectors.IsNativeSupported<T>()) {
                return HandleOtherFormats(format, arg, formatProvider);
            }
            var sb = new StringBuilder();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            int Count = Vector<byte>.Count / Unsafe.SizeOf<T>();
            ref T p = ref Unsafe.As<Vector<T>, T>(ref arg);
            sb.Append('<');
            string temp = HandleOtherFormats(format, p, formatProvider);
            sb.Append(temp);
            for (int i = 1; i < Count; i++) {
                p = ref Unsafe.Add(ref p, 1);
                sb.Append(separator);
                sb.Append(' ');
                temp = HandleOtherFormats(format, p, formatProvider);
                sb.Append(temp);
            }
            sb.Append('>');
            return sb.ToString();
        }

#if NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// Call Format method (调用 Format 方法).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="format">A format string containing formatting specifications (包含格式规范的格式字符串).</param>
        /// <param name="arg">An object to format(要设置其格式的对象).</param>
        /// <param name="formatProvider">An object that supplies format information about the current instance (一个对象，提供有关当前实例的区域性特定格式信息).</param>
        /// <returns>Formatted string (格式化之后的字符串).</returns>
        private static string CallFormat<T>(string? format, Vector128<T> arg, IFormatProvider formatProvider) where T : struct {
            if (Vector128s.IsNativeSupported<T>()) {
                return HandleOtherFormats(format, arg, formatProvider);
            }
            var sb = new StringBuilder();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            int Count = Vector128<byte>.Count / Unsafe.SizeOf<T>();
            ref T p = ref Unsafe.As<Vector128<T>, T>(ref arg);
            sb.Append('<');
            string temp = HandleOtherFormats(format, p, formatProvider);
            sb.Append(temp);
            for (int i = 1; i < Count; i++) {
                p = ref Unsafe.Add(ref p, 1);
                sb.Append(separator);
                sb.Append(' ');
                temp = HandleOtherFormats(format, p, formatProvider);
                sb.Append(temp);
            }
            sb.Append('>');
            return sb.ToString();
        }

        /// <summary>
        /// Call Format method (调用 Format 方法).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="format">A format string containing formatting specifications (包含格式规范的格式字符串).</param>
        /// <param name="arg">An object to format(要设置其格式的对象).</param>
        /// <param name="formatProvider">An object that supplies format information about the current instance (一个对象，提供有关当前实例的区域性特定格式信息).</param>
        /// <returns>Formatted string (格式化之后的字符串).</returns>
        private static string CallFormat<T>(string? format, Vector256<T> arg, IFormatProvider formatProvider) where T : struct {
            if (Vector256s.IsNativeSupported<T>()) {
                return HandleOtherFormats(format, arg, formatProvider);
            }
            var sb = new StringBuilder();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            int Count = Vector256<byte>.Count / Unsafe.SizeOf<T>();
            ref T p = ref Unsafe.As<Vector256<T>, T>(ref arg);
            sb.Append('<');
            string temp = HandleOtherFormats(format, p, formatProvider);
            sb.Append(temp);
            for (int i = 1; i < Count; i++) {
                p = ref Unsafe.Add(ref p, 1);
                sb.Append(separator);
                sb.Append(' ');
                temp = HandleOtherFormats(format, p, formatProvider);
                sb.Append(temp);
            }
            sb.Append('>');
            return sb.ToString();
        }

#endif

#if NET8_0_OR_GREATER
        /// <summary>
        /// Call Format method (调用 Format 方法).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="format">A format string containing formatting specifications (包含格式规范的格式字符串).</param>
        /// <param name="arg">An object to format(要设置其格式的对象).</param>
        /// <param name="formatProvider">An object that supplies format information about the current instance (一个对象，提供有关当前实例的区域性特定格式信息).</param>
        /// <returns>Formatted string (格式化之后的字符串).</returns>
        private static string CallFormat<T>(string? format, Vector512<T> arg, IFormatProvider formatProvider) where T : struct {
            if (Vector512s.IsNativeSupported<T>()) {
                return HandleOtherFormats(format, arg, formatProvider);
            }
            var sb = new StringBuilder();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            int Count = Vector512<byte>.Count / Unsafe.SizeOf<T>();
            ref T p = ref Unsafe.As<Vector512<T>, T>(ref arg);
            sb.Append('<');
            string temp = HandleOtherFormats(format, p, formatProvider);
            sb.Append(temp);
            for (int i = 1; i < Count; i++) {
                p = ref Unsafe.Add(ref p, 1);
                sb.Append(separator);
                sb.Append(' ');
                temp = HandleOtherFormats(format, p, formatProvider);
                sb.Append(temp);
            }
            sb.Append('>');
            return sb.ToString();
        }
#endif // NET8_0_OR_GREATER

        /// <summary>
        /// Call Format method (调用 Format 方法).
        /// </summary>
        /// <param name="format">A format string containing formatting specifications (包含格式规范的格式字符串).</param>
        /// <param name="arg">An object to format(要设置其格式的对象).</param>
        /// <param name="formatProvider">An object that supplies format information about the current instance (一个对象，提供有关当前实例的区域性特定格式信息).</param>
        /// <returns>Formatted string (格式化之后的字符串).</returns>
        private static string CallFormat(string? format, object arg, IFormatProvider formatProvider) {
            return HandleOtherFormats(format, arg, formatProvider);
        }

        /// <inheritdoc cref="ICustomFormatter.Format(string?, object?, IFormatProvider?)"/>
        public string Format(string? format, object? arg, IFormatProvider? formatProvider) {
            if (arg == null) return string.Empty;
            IFormatProvider provider = NextProvider ?? CultureInfo.CurrentCulture;
            return CallFormat(format, (dynamic)arg, provider);
        }
    }

}
