using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Extension methods of <seealso cref="IWVectorTraits128"/> (<seealso cref="IWVectorTraits128"/> 的扩展方法)
    /// </summary>
    partial class IWVectorTraits128_Extensions {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="Vector128s.YShuffleG4X2{T}(Vector128{T}, Vector128{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector128<T> Result0, Vector128<T> Result1) YShuffleG4X2<T>(this IWVectorTraits128 athis, Vector128<T> source0, Vector128<T> source1, ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<float>)(object)source0, (Vector128<float>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<double>)(object)source0, (Vector128<double>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<sbyte>)(object)source0, (Vector128<sbyte>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<byte>)(object)source0, (Vector128<byte>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<short>)(object)source0, (Vector128<short>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<ushort>)(object)source0, (Vector128<ushort>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<int>)(object)source0, (Vector128<int>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<uint>)(object)source0, (Vector128<uint>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<long>)(object)source0, (Vector128<long>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2((Vector128<ulong>)(object)source0, (Vector128<ulong>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{float}, Vector128{float}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<float> Result0, Vector128<float> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{double}, Vector128{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<double> Result0, Vector128<double> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{short}, Vector128{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<short> Result0, Vector128<short> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{int}, Vector128{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<int> Result0, Vector128<int> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{uint}, Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{long}, Vector128{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<long> Result0, Vector128<long> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1) YShuffleG4X2(this IWVectorTraits128 athis, Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const{T}(Vector128{T}, Vector128{T}, ShuffleControlG4)"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [CLSCompliant(false)]
        public static (Vector128<T> Result0, Vector128<T> Result1) YShuffleG4X2_Const<T>(this IWVectorTraits128 athis, Vector128<T> source0, Vector128<T> source1, ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<float>)(object)source0, (Vector128<float>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<double>)(object)source0, (Vector128<double>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<sbyte>)(object)source0, (Vector128<sbyte>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<byte>)(object)source0, (Vector128<byte>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<short>)(object)source0, (Vector128<short>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<ushort>)(object)source0, (Vector128<ushort>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<int>)(object)source0, (Vector128<int>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<uint>)(object)source0, (Vector128<uint>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<long>)(object)source0, (Vector128<long>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = athis.YShuffleG4X2_Const((Vector128<ulong>)(object)source0, (Vector128<ulong>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{float}, Vector128{float}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<float> Result0, Vector128<float> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{double}, Vector128{double}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<double> Result0, Vector128<double> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{byte}, Vector128{byte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{short}, Vector128{short}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<short> Result0, Vector128<short> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{int}, Vector128{int}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<int> Result0, Vector128<int> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{uint}, Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{long}, Vector128{long}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<long> Result0, Vector128<long> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <inheritdoc cref="Vector128s.YShuffleG4X2_Const(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1) YShuffleG4X2_Const(this IWVectorTraits128 athis, Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = athis.YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }


#endif // NETCOREAPP3_0_OR_GREATER
    }
}
