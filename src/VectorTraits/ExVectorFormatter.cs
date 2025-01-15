#define Use_Format_Reflection // Fix AoT.
#if NET5_0_OR_GREATER
#define BCL_TYPE_HALF
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.ExTypes;

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
        private static string CallFormat_Vector<T>(string? format, Vector<T> arg, IFormatProvider formatProvider) where T : struct {
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

        /// <inheritdoc cref="CallFormat_Vector"/>
        private static string CallFormat<T>(string? format, Vector<T> arg, IFormatProvider formatProvider) where T : struct {
            return CallFormat_Vector(format, arg, formatProvider);
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
        private static string CallFormat_Vector64<T>(string? format, Vector64<T> arg, IFormatProvider formatProvider) where T : struct {
            if (Vector64s.IsNativeSupported<T>()) {
                return HandleOtherFormats(format, arg, formatProvider);
            }
            var sb = new StringBuilder();
            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
            int Count = Vector64<byte>.Count / Unsafe.SizeOf<T>();
            ref T p = ref Unsafe.As<Vector64<T>, T>(ref arg);
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

        /// <inheritdoc cref="CallFormat_Vector64"/>
        private static string CallFormat<T>(string? format, Vector64<T> arg, IFormatProvider formatProvider) where T : struct {
            return CallFormat_Vector64(format, arg, formatProvider);
        }

        /// <summary>
        /// Call Format method (调用 Format 方法).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="format">A format string containing formatting specifications (包含格式规范的格式字符串).</param>
        /// <param name="arg">An object to format(要设置其格式的对象).</param>
        /// <param name="formatProvider">An object that supplies format information about the current instance (一个对象，提供有关当前实例的区域性特定格式信息).</param>
        /// <returns>Formatted string (格式化之后的字符串).</returns>
        private static string CallFormat_Vector128<T>(string? format, Vector128<T> arg, IFormatProvider formatProvider) where T : struct {
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

        /// <inheritdoc cref="CallFormat_Vector128"/>
        private static string CallFormat<T>(string? format, Vector128<T> arg, IFormatProvider formatProvider) where T : struct {
            return CallFormat_Vector128(format, arg, formatProvider);
        }

        /// <summary>
        /// Call Format method (调用 Format 方法).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="format">A format string containing formatting specifications (包含格式规范的格式字符串).</param>
        /// <param name="arg">An object to format(要设置其格式的对象).</param>
        /// <param name="formatProvider">An object that supplies format information about the current instance (一个对象，提供有关当前实例的区域性特定格式信息).</param>
        /// <returns>Formatted string (格式化之后的字符串).</returns>
        private static string CallFormat_Vector256<T>(string? format, Vector256<T> arg, IFormatProvider formatProvider) where T : struct {
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

        /// <inheritdoc cref="CallFormat_Vector256"/>
        private static string CallFormat<T>(string? format, Vector256<T> arg, IFormatProvider formatProvider) where T : struct {
            return CallFormat_Vector256(format, arg, formatProvider);
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
        private static string CallFormat_Vector512<T>(string? format, Vector512<T> arg, IFormatProvider formatProvider) where T : struct {
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

        /// <inheritdoc cref="CallFormat_Vector512"/>
        private static string CallFormat<T>(string? format, Vector512<T> arg, IFormatProvider formatProvider) where T : struct {
            return CallFormat_Vector512(format, arg, formatProvider);
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
            string rt;
#if Use_Format_Reflection && (NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_0_OR_GREATER)
            rt = Format_Reflection(format, arg, provider);
#else
            rt = Format_Dynamic(format, arg, provider);
#endif
            return rt;
        }

        /// <inheritdoc cref="Format(string?, object?, IFormatProvider?)"/>
#if NET5_0_OR_GREATER
        [RequiresUnreferencedCode("Use 'Format_Reflection' instead")]
#endif // NET5_0_OR_GREATER
        public string Format_Dynamic(string? format, object arg, IFormatProvider formatProvider) {
#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
            //if (!RuntimeFeature.IsDynamicCodeSupported) {
            //    throw new NotSupportedException("Not supported DynamicCode at Format_Dynamic!");
            //}
#endif
            return CallFormat(format, arg as dynamic, formatProvider);
        }

#if Use_Format_Reflection && (NETCOREAPP1_0_OR_GREATER || NETSTANDARD2_0_OR_GREATER)

        /// <inheritdoc cref="Format(string?, object?, IFormatProvider?)"/>
        public string Format_Reflection(string? format, object arg, IFormatProvider formatProvider) {
            Type argType = arg.GetType();
            MethodInfoBuffer? found = null;
            if (argType.IsGenericType) {
                Type defineType = argType.GetGenericTypeDefinition();
                foreach (MethodInfoBuffer item in _methodInfoBufferList) {
                    if (defineType.Equals(item.VectorType)) {
                        found = item;
                        break;
                    }
                }
                if (null != found) {
                    Type[] typeMethodArguments = argType.GetGenericArguments();
                    Type typeMethodArgument = typeMethodArguments[0];
                    MethodInfo? methodInfo;
                    if (!found.Buffer.TryGetValue(typeMethodArgument, out methodInfo)) {
                        methodInfo = null;
                    }
                    if (null == methodInfo && null != found.SourceMethodInfo) {
#pragma warning disable IL2060 // Call to 'System.Reflection.MethodInfo.MakeGenericMethod' can not be statically analyzed. It's not possible to guarantee the availability of requirements of the generic method.
#pragma warning disable IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
                        // Fixed the exception of MakeGenericMethod in ExVectorFormatter.Format_Reflection method on AOT - GetHashByAllCallFormat
                        methodInfo = found.SourceMethodInfo.MakeGenericMethod(typeMethodArguments);
#pragma warning restore IL3050 // Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.
#pragma warning restore IL2060 // Call to 'System.Reflection.MethodInfo.MakeGenericMethod' can not be statically analyzed. It's not possible to guarantee the availability of requirements of the generic method.
                        found.Buffer.Add(typeMethodArgument, methodInfo);
                    }
                    if (null != methodInfo) {
                        object? rt = methodInfo.Invoke(null, [format, arg, formatProvider]);
                        return rt?.ToString() ?? string.Empty;
                    }
                }
            }
            return HandleOtherFormats(format, arg, formatProvider);
        }

        private record MethodInfoBuffer {
            public Type? VectorType { get; set; }
            public MethodInfo? SourceMethodInfo { get; set; }
            public Dictionary<Type, MethodInfo> Buffer { get; } = [];

            public MethodInfoBuffer() : this(null, null) {
            }

            public MethodInfoBuffer(Type? vectorType) : this(vectorType, null) {
            }

            public MethodInfoBuffer(Type? vectorType, MethodInfo? sourceMethodInfo) {
                VectorType = vectorType;
                SourceMethodInfo = sourceMethodInfo;
            }
        }

        private static readonly List<MethodInfoBuffer> _methodInfoBufferList = new List<MethodInfoBuffer>();

        /// <summary>
        /// Get the hash of the return value of all CallFormat methods. It is used to fill metadata for AOT (取得所有CallFormat方法的返回值的hash. 它用于AOT时填充元数据).
        /// </summary>
        /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
        /// <param name="format"></param>
        /// <param name="formatProvider"></param>
        /// <returns></returns>
        public static int GetHashByAllCallFormat<T>(string? format = null, IFormatProvider? formatProvider = null) where T : struct {
            int rt = 0;
            if (null == format) format = "{0}";
            if (null== formatProvider) formatProvider = CultureInfo.CurrentCulture;
            int byteSize = Unsafe.SizeOf<T>();
            try {
                if (byteSize <= Vector<byte>.Count) rt ^= CallFormat(format, Vectors<T>.Zero, formatProvider).GetHashCode();
#if NETCOREAPP3_0_OR_GREATER
                if (byteSize <= Vector64<byte>.Count) rt ^= CallFormat(format, Vector64s<T>.Zero, formatProvider).GetHashCode();
                if (byteSize <= Vector128<byte>.Count) rt ^= CallFormat(format, Vector128s<T>.Zero, formatProvider).GetHashCode();
                if (byteSize <= Vector256<byte>.Count) rt ^= CallFormat(format, Vector256s<T>.Zero, formatProvider).GetHashCode();
#endif
#if NET8_0_OR_GREATER
                if (byteSize <= Vector512<byte>.Count) rt ^= CallFormat(format, Vector512s<T>.Zero, formatProvider).GetHashCode();
#endif
            } catch (Exception ex) {
                Console.WriteLine(string.Format("Not support `{0}` type! {1}", typeof(T).Name , ex.ToString()));
            }
            return rt;
        }

        static ExVectorFormatter() {
            const BindingFlags flags = BindingFlags.Static | BindingFlags.NonPublic;
            Type selfType = typeof(ExVectorFormatter);
            _methodInfoBufferList.Add(new MethodInfoBuffer(typeof(Vector<>), selfType.GetMethod(nameof(CallFormat_Vector), flags)));

#if NETCOREAPP3_0_OR_GREATER
            _methodInfoBufferList.Add(new MethodInfoBuffer(typeof(Vector64<>), selfType.GetMethod(nameof(CallFormat_Vector64), flags)));
            _methodInfoBufferList.Add(new MethodInfoBuffer(typeof(Vector128<>), selfType.GetMethod(nameof(CallFormat_Vector128), flags)));
            _methodInfoBufferList.Add(new MethodInfoBuffer(typeof(Vector256<>), selfType.GetMethod(nameof(CallFormat_Vector256), flags)));
#endif

#if NET8_0_OR_GREATER
            _methodInfoBufferList.Add(new MethodInfoBuffer(typeof(Vector512<>), selfType.GetMethod(nameof(CallFormat_Vector512), flags)));
#endif
            // Fill metadata for AOT.
            int hash = 0;
            hash ^= GetHashByAllCallFormat<float>();
            hash ^= GetHashByAllCallFormat<double>();
            hash ^= GetHashByAllCallFormat<sbyte>();
            hash ^= GetHashByAllCallFormat<byte>();
            hash ^= GetHashByAllCallFormat<short>();
            hash ^= GetHashByAllCallFormat<ushort>();
            hash ^= GetHashByAllCallFormat<int>();
            hash ^= GetHashByAllCallFormat<uint>();
            hash ^= GetHashByAllCallFormat<long>();
            hash ^= GetHashByAllCallFormat<ulong>();
            hash ^= GetHashByAllCallFormat<ExInt128>();
            hash ^= GetHashByAllCallFormat<ExUInt128>();
#if BCL_TYPE_INT128
            hash ^= GetHashByAllCallFormat<Int128>();
            hash ^= GetHashByAllCallFormat<UInt128>();
#endif // BCL_TYPE_INT128
#if NET7_0_OR_GREATER
            hash ^= GetHashByAllCallFormat<nint>();
            hash ^= GetHashByAllCallFormat<nuint>();
#endif // NET7_0_OR_GREATER
#if BCL_TYPE_HALF
            //hash ^= GetHashByAllCallFormat<Half>(); // TODO: Need vector type supported Half.
#endif // BCL_TYPE_HALF
        }

#endif

    }

}
