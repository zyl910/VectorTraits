#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Impl;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits {
    static partial class Vectors {

#if BCL_TYPE_INT128

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup2Unzip(Vector<Int128> data0, Vector<Int128> data1, out Vector<Int128> y) {
            var d0 = YGroup2Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), out var d1);
            y = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2Unzip(Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup2Unzip(Vector<UInt128> data0, Vector<UInt128> data1, out Vector<UInt128> y) {
            var d0 = YGroup2Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
            y = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector<T> X, Vector<T> Y) YGroup2Unzip<T>(Vector<T> data0, Vector<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<float>)(object)data0, (Vector<float>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<double>)(object)data0, (Vector<double>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<byte>)(object)data0, (Vector<byte>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<short>)(object)data0, (Vector<short>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<int>)(object)data0, (Vector<int>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<uint>)(object)data0, (Vector<uint>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<long>)(object)data0, (Vector<long>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<ExInt128>)(object)data0, (Vector<ExInt128>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<ExUInt128>)(object)data0, (Vector<ExUInt128>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<Int128>)(object)data0, (Vector<Int128>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector<UInt128>)(object)data0, (Vector<UInt128>)(object)data1);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// De-Interleave 2-element groups into 2 vectors. It converts the 2-element groups AoS to SoA (将2-元素组解交织为2个向量. 它能将2元素组的 数组结构体 转为 结构体数组).
        /// Mnemonic: <c>x[i] =: element_ref(2*i, data0, data1)</c>, <c>y[i] =: element_ref(2*i+1, data0, data1)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 2-element groups - Part 0 (由2元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 2-element groups - Part 1 (由2元素组所组成的向量 - 第1部分).</param>
        /// <returns>Returns the de-interleaved data. They are the X,Y vectors (返回解交织后数据. 它们分别是 X,Y 向量).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> X, Vector<float> Y) YGroup2Unzip(Vector<float> data0, Vector<float> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> X, Vector<double> Y) YGroup2Unzip(Vector<double> data0, Vector<double> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> X, Vector<sbyte> Y) YGroup2Unzip(Vector<sbyte> data0, Vector<sbyte> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> X, Vector<byte> Y) YGroup2Unzip(Vector<byte> data0, Vector<byte> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> X, Vector<short> Y) YGroup2Unzip(Vector<short> data0, Vector<short> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> X, Vector<ushort> Y) YGroup2Unzip(Vector<ushort> data0, Vector<ushort> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> X, Vector<int> Y) YGroup2Unzip(Vector<int> data0, Vector<int> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> X, Vector<uint> Y) YGroup2Unzip(Vector<uint> data0, Vector<uint> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> X, Vector<long> Y) YGroup2Unzip(Vector<long> data0, Vector<long> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> X, Vector<ulong> Y) YGroup2Unzip(Vector<ulong> data0, Vector<ulong> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExInt128> X, Vector<ExInt128> Y) YGroup2Unzip(Vector<ExInt128> data0, Vector<ExInt128> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExUInt128> X, Vector<ExUInt128> Y) YGroup2Unzip(Vector<ExUInt128> data0, Vector<ExUInt128> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<Int128> X, Vector<Int128> Y) YGroup2Unzip(Vector<Int128> data0, Vector<Int128> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<UInt128> X, Vector<UInt128> Y) YGroup2Unzip(Vector<UInt128> data0, Vector<UInt128> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2UnzipEven(Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector<T> YGroup2UnzipEven<T>(Vector<T> data0, Vector<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<float>)(object)data0, (Vector<float>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<double>)(object)data0, (Vector<double>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<byte>)(object)data0, (Vector<byte>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<short>)(object)data0, (Vector<short>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<int>)(object)data0, (Vector<int>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<uint>)(object)data0, (Vector<uint>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<long>)(object)data0, (Vector<long>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<ExInt128>)(object)data0, (Vector<ExInt128>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<ExUInt128>)(object)data0, (Vector<ExUInt128>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<Int128>)(object)data0, (Vector<Int128>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipEven((Vector<UInt128>)(object)data0, (Vector<UInt128>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{ExInt128}, Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup2UnzipEven(Vector<Int128> data0, Vector<Int128> data1) {
            return YGroup2UnzipEven(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="YGroup2UnzipEven(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup2UnzipEven(Vector<UInt128> data0, Vector<UInt128> data1) {
            return YGroup2UnzipEven(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="Vectors.YGroup2UnzipOdd(Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector<T> YGroup2UnzipOdd<T>(Vector<T> data0, Vector<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<float>)(object)data0, (Vector<float>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<double>)(object)data0, (Vector<double>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<byte>)(object)data0, (Vector<byte>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<short>)(object)data0, (Vector<short>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<int>)(object)data0, (Vector<int>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<uint>)(object)data0, (Vector<uint>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<long>)(object)data0, (Vector<long>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<ExInt128>)(object)data0, (Vector<ExInt128>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<ExUInt128>)(object)data0, (Vector<ExUInt128>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<Int128>)(object)data0, (Vector<Int128>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2UnzipOdd((Vector<UInt128>)(object)data0, (Vector<UInt128>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{ExInt128}, Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup2UnzipOdd(Vector<Int128> data0, Vector<Int128> data1) {
            return YGroup2UnzipOdd(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup2UnzipOdd(Vector<UInt128> data0, Vector<UInt128> data1) {
            return YGroup2UnzipOdd(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Zip(Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup2Zip(Vector<Int128> x, Vector<Int128> y, out Vector<Int128> data1) {
            var d0 = YGroup2Zip(x.ExAsExInt128(), y.ExAsExInt128(), out var d1);
            data1 = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup2Zip(Vector<UInt128> x, Vector<UInt128> y, out Vector<UInt128> data1) {
            var d0 = YGroup2Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
            data1 = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector<T> Data0, Vector<T> Data1) YGroup2Zip<T>(Vector<T> x, Vector<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<float>)(object)x, (Vector<float>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<double>)(object)x, (Vector<double>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<sbyte>)(object)x, (Vector<sbyte>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<byte>)(object)x, (Vector<byte>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<short>)(object)x, (Vector<short>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<ushort>)(object)x, (Vector<ushort>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<int>)(object)x, (Vector<int>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<uint>)(object)x, (Vector<uint>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<long>)(object)x, (Vector<long>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<ulong>)(object)x, (Vector<ulong>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<ExInt128>)(object)x, (Vector<ExInt128>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<ExUInt128>)(object)x, (Vector<ExUInt128>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<Int128>)(object)x, (Vector<Int128>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector<UInt128>)(object)x, (Vector<UInt128>)(object)y);
                return ((Vector<T>)(object)data0, (Vector<T>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Interleave 2 vectors into 2-element groups. It converts the 2-element groups SoA to AoS (将2个向量交织为2-元素组. 它能将2元素组的 结构体数组 转为 数组结构体).
        /// Mnemonic: <c>element_ref(i, data0, data1) := (0==(i&amp;1))?( x[i2] ):( y[i2] )</c>, <c>i2 := i/2</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <returns>Returns the interleaved data (返回交织后数据).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Data0, Vector<float> Data1) YGroup2Zip(Vector<float> x, Vector<float> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Data0, Vector<double> Data1) YGroup2Zip(Vector<double> x, Vector<double> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Data0, Vector<sbyte> Data1) YGroup2Zip(Vector<sbyte> x, Vector<sbyte> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Data0, Vector<byte> Data1) YGroup2Zip(Vector<byte> x, Vector<byte> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Data0, Vector<short> Data1) YGroup2Zip(Vector<short> x, Vector<short> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Data0, Vector<ushort> Data1) YGroup2Zip(Vector<ushort> x, Vector<ushort> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Data0, Vector<int> Data1) YGroup2Zip(Vector<int> x, Vector<int> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Data0, Vector<uint> Data1) YGroup2Zip(Vector<uint> x, Vector<uint> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Data0, Vector<long> Data1) YGroup2Zip(Vector<long> x, Vector<long> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Data0, Vector<ulong> Data1) YGroup2Zip(Vector<ulong> x, Vector<ulong> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExInt128> Data0, Vector<ExInt128> Data1) YGroup2Zip(Vector<ExInt128> x, Vector<ExInt128> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExUInt128> Data0, Vector<ExUInt128> Data1) YGroup2Zip(Vector<ExUInt128> x, Vector<ExUInt128> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<Int128> Data0, Vector<Int128> Data1) YGroup2Zip(Vector<Int128> x, Vector<Int128> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<UInt128> Data0, Vector<UInt128> Data1) YGroup2Zip(Vector<UInt128> x, Vector<UInt128> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2ZipHigh(Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector<T> YGroup2ZipHigh<T>(Vector<T> data0, Vector<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<float>)(object)data0, (Vector<float>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<double>)(object)data0, (Vector<double>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<byte>)(object)data0, (Vector<byte>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<short>)(object)data0, (Vector<short>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<int>)(object)data0, (Vector<int>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<uint>)(object)data0, (Vector<uint>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<long>)(object)data0, (Vector<long>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<ExInt128>)(object)data0, (Vector<ExInt128>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<ExUInt128>)(object)data0, (Vector<ExUInt128>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<Int128>)(object)data0, (Vector<Int128>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipHigh((Vector<UInt128>)(object)data0, (Vector<UInt128>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ExInt128}, Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup2ZipHigh(Vector<Int128> x, Vector<Int128> y) {
            //Console.WriteLine(VectorTextUtil.Format("Vectors-Ext: x={0}, y={1}", x, y));
            return YGroup2ZipHigh(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipHigh(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup2ZipHigh(Vector<UInt128> x, Vector<UInt128> y) {
            return YGroup2ZipHigh(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2ZipLow(Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static Vector<T> YGroup2ZipLow<T>(Vector<T> data0, Vector<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<float>)(object)data0, (Vector<float>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<double>)(object)data0, (Vector<double>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<byte>)(object)data0, (Vector<byte>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<short>)(object)data0, (Vector<short>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<int>)(object)data0, (Vector<int>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<uint>)(object)data0, (Vector<uint>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<long>)(object)data0, (Vector<long>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<ExInt128>)(object)data0, (Vector<ExInt128>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<ExUInt128>)(object)data0, (Vector<ExUInt128>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<Int128>)(object)data0, (Vector<Int128>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                return (Vector<T>)(object)YGroup2ZipLow((Vector<UInt128>)(object)data0, (Vector<UInt128>)(object)data1);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ExInt128}, Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup2ZipLow(Vector<Int128> x, Vector<Int128> y) {
            return YGroup2ZipLow(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="IVectorTraits.YGroup2ZipLow(Vector{ExUInt128}, Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup2ZipLow(Vector<UInt128> x, Vector<UInt128> y) {
            return YGroup2ZipLow(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Result0, Vector<T> Result1, Vector<T> Result2, Vector<T> Result3) YGroup3ToGroup4<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector<float>)(object)data0, (Vector<float>)(object)data1, (Vector<float>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector<double>)(object)data0, (Vector<double>)(object)data1, (Vector<double>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1, (Vector<sbyte>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector<byte>)(object)data0, (Vector<byte>)(object)data1, (Vector<byte>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector<short>)(object)data0, (Vector<short>)(object)data1, (Vector<short>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1, (Vector<ushort>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector<int>)(object)data0, (Vector<int>)(object)data1, (Vector<int>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector<uint>)(object)data0, (Vector<uint>)(object)data1, (Vector<uint>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector<long>)(object)data0, (Vector<long>)(object)data1, (Vector<long>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1, (Vector<ulong>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Convert a 3-element group, to a 4-element group. It also converts packed RGB pixel data to packed RGBA pixel data (将3-元素组, 转为4-元素组. 它还能将 已打包的RGB像素数据, 转换为 已打包的RGBA像素数据).
        /// Mnemonic: View for group: <c>(result0, result1, result2, result3) = YGroup4Zip(YGroup3Unzip(data0, data1, data2), Vector.Zero))</c>. View for element: <c>element_ref(i, result0, result1, result2, result3) := (3!=(i%4))?element_ref((i/4)*3+(i%4), data0, data1, data2):0</c>.
        /// </summary>
        /// <param name="data0">A vector made of 4-element groups - Part 0 (由4元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 4-element groups - Part 1 (由4元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 4-element groups - Part 2 (由4元素组所组成的向量 - 第2部分).</param>
        /// <returns>Returns the converted data. (返回转换后数据).</returns>
        /// <seealso cref="YGroup3ToGroup4_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Result0, Vector<float> Result1, Vector<float> Result2, Vector<float> Result3) YGroup3ToGroup4(Vector<float> data0, Vector<float> data1, Vector<float> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Result0, Vector<double> Result1, Vector<double> Result2, Vector<double> Result3) YGroup3ToGroup4(Vector<double> data0, Vector<double> data1, Vector<double> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Result0, Vector<sbyte> Result1, Vector<sbyte> Result2, Vector<sbyte> Result3) YGroup3ToGroup4(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Result0, Vector<byte> Result1, Vector<byte> Result2, Vector<byte> Result3) YGroup3ToGroup4(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Result0, Vector<short> Result1, Vector<short> Result2, Vector<short> Result3) YGroup3ToGroup4(Vector<short> data0, Vector<short> data1, Vector<short> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Result0, Vector<ushort> Result1, Vector<ushort> Result2, Vector<ushort> Result3) YGroup3ToGroup4(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Result0, Vector<int> Result1, Vector<int> Result2, Vector<int> Result3) YGroup3ToGroup4(Vector<int> data0, Vector<int> data1, Vector<int> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Result0, Vector<uint> Result1, Vector<uint> Result2, Vector<uint> Result3) YGroup3ToGroup4(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Result0, Vector<long> Result1, Vector<long> Result2, Vector<long> Result3) YGroup3ToGroup4(Vector<long> data0, Vector<long> data1, Vector<long> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Result0, Vector<ulong> Result1, Vector<ulong> Result2, Vector<ulong> Result3) YGroup3ToGroup4(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> X, Vector<T> Y, Vector<T> Z) YGroup3Unzip<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector<float>)(object)data0, (Vector<float>)(object)data1, (Vector<float>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector<double>)(object)data0, (Vector<double>)(object)data1, (Vector<double>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1, (Vector<sbyte>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector<byte>)(object)data0, (Vector<byte>)(object)data1, (Vector<byte>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector<short>)(object)data0, (Vector<short>)(object)data1, (Vector<short>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1, (Vector<ushort>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector<int>)(object)data0, (Vector<int>)(object)data1, (Vector<int>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector<uint>)(object)data0, (Vector<uint>)(object)data1, (Vector<uint>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector<long>)(object)data0, (Vector<long>)(object)data1, (Vector<long>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1, (Vector<ulong>)(object)data2);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// De-Interleave 3-element groups into 3 vectors. It converts the 3-element groups AoS to SoA. It can also deinterleave packed RGB pixel data into R,G,B planar data (将3-元素组解交织为3个向量. 它能将3元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGB像素数据, 解交织为 R,G,B 平面数据).
        /// Mnemonic: <c>x[i] =: element_ref(3*i, data0, data1, data2)</c>, <c>y[i] =: element_ref(3*i+1, data0, data1, data2)</c>, <c>z[i] =: element_ref(3*i+2, data0, data1, data2)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 3-element groups - Part 0 (由3元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 3-element groups - Part 1 (由3元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 3-element groups - Part 2 (由3元素组所组成的向量 - 第2部分).</param>
        /// <returns>Returns the de-interleaved data. They are the X,Y,Z vectors (返回解交织后数据. 它们分别是 X,Y,Z 向量).</returns>
        /// <seealso cref="YGroup3Unzip_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> X, Vector<float> Y, Vector<float> Z) YGroup3Unzip(Vector<float> data0, Vector<float> data1, Vector<float> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> X, Vector<double> Y, Vector<double> Z) YGroup3Unzip(Vector<double> data0, Vector<double> data1, Vector<double> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> X, Vector<sbyte> Y, Vector<sbyte> Z) YGroup3Unzip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> X, Vector<byte> Y, Vector<byte> Z) YGroup3Unzip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> X, Vector<short> Y, Vector<short> Z) YGroup3Unzip(Vector<short> data0, Vector<short> data1, Vector<short> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> X, Vector<ushort> Y, Vector<ushort> Z) YGroup3Unzip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> X, Vector<int> Y, Vector<int> Z) YGroup3Unzip(Vector<int> data0, Vector<int> data1, Vector<int> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> X, Vector<uint> Y, Vector<uint> Z) YGroup3Unzip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> X, Vector<long> Y, Vector<long> Z) YGroup3Unzip(Vector<long> data0, Vector<long> data1, Vector<long> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> X, Vector<ulong> Y, Vector<ulong> Z) YGroup3Unzip(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> X, Vector<T> XB, Vector<T> Y, Vector<T> YB, Vector<T> Z, Vector<T> ZB) YGroup3UnzipX2<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3, Vector<T> data4, Vector<T> data5) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector<float>)(object)data0, (Vector<float>)(object)data1, (Vector<float>)(object)data2, (Vector<float>)(object)data3, (Vector<float>)(object)data4, (Vector<float>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector<double>)(object)data0, (Vector<double>)(object)data1, (Vector<double>)(object)data2, (Vector<double>)(object)data3, (Vector<double>)(object)data4, (Vector<double>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1, (Vector<sbyte>)(object)data2, (Vector<sbyte>)(object)data3, (Vector<sbyte>)(object)data4, (Vector<sbyte>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector<byte>)(object)data0, (Vector<byte>)(object)data1, (Vector<byte>)(object)data2, (Vector<byte>)(object)data3, (Vector<byte>)(object)data4, (Vector<byte>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector<short>)(object)data0, (Vector<short>)(object)data1, (Vector<short>)(object)data2, (Vector<short>)(object)data3, (Vector<short>)(object)data4, (Vector<short>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1, (Vector<ushort>)(object)data2, (Vector<ushort>)(object)data3, (Vector<ushort>)(object)data4, (Vector<ushort>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector<int>)(object)data0, (Vector<int>)(object)data1, (Vector<int>)(object)data2, (Vector<int>)(object)data3, (Vector<int>)(object)data4, (Vector<int>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector<uint>)(object)data0, (Vector<uint>)(object)data1, (Vector<uint>)(object)data2, (Vector<uint>)(object)data3, (Vector<uint>)(object)data4, (Vector<uint>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector<long>)(object)data0, (Vector<long>)(object)data1, (Vector<long>)(object)data2, (Vector<long>)(object)data3, (Vector<long>)(object)data4, (Vector<long>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1, (Vector<ulong>)(object)data2, (Vector<ulong>)(object)data3, (Vector<ulong>)(object)data4, (Vector<ulong>)(object)data5);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// De-Interleave 3-element groups into 3 vectors and process 2x data (将3-元素组解交织为3个向量, 且处理2倍数据).
        /// Mnemonic: <c>(x, y, z) = YGroup3Unzip(data0, data1, data2)</c>, <c>(xB, yB, zB) = YGroup3Unzip(data3, data4, data5)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 3-element groups - Part 0 (由3元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 3-element groups - Part 1 (由3元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 3-element groups - Part 2 (由3元素组所组成的向量 - 第2部分).</param>
        /// <param name="data3">A vector made of 3-element groups - Part 3 (由3元素组所组成的向量 - 第3部分).</param>
        /// <param name="data4">A vector made of 3-element groups - Part 4 (由3元素组所组成的向量 - 第4部分).</param>
        /// <param name="data5">A vector made of 3-element groups - Part 5 (由3元素组所组成的向量 - 第5部分).</param>
        /// <returns>Returns the de-interleaved data. They are the X,XB,Y,YB,Z,ZB vectors (返回解交织后数据. 它们分别是 X,XB,Y,YB,Z,ZB 向量).</returns>
        /// <seealso cref="YGroup3UnzipX2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> X, Vector<float> XB, Vector<float> Y, Vector<float> YB, Vector<float> Z, Vector<float> ZB) YGroup3UnzipX2(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3, Vector<float> data4, Vector<float> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> X, Vector<double> XB, Vector<double> Y, Vector<double> YB, Vector<double> Z, Vector<double> ZB) YGroup3UnzipX2(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3, Vector<double> data4, Vector<double> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> X, Vector<sbyte> XB, Vector<sbyte> Y, Vector<sbyte> YB, Vector<sbyte> Z, Vector<sbyte> ZB) YGroup3UnzipX2(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3, Vector<sbyte> data4, Vector<sbyte> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> X, Vector<byte> XB, Vector<byte> Y, Vector<byte> YB, Vector<byte> Z, Vector<byte> ZB) YGroup3UnzipX2(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3, Vector<byte> data4, Vector<byte> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> X, Vector<short> XB, Vector<short> Y, Vector<short> YB, Vector<short> Z, Vector<short> ZB) YGroup3UnzipX2(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3, Vector<short> data4, Vector<short> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> X, Vector<ushort> XB, Vector<ushort> Y, Vector<ushort> YB, Vector<ushort> Z, Vector<ushort> ZB) YGroup3UnzipX2(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3, Vector<ushort> data4, Vector<ushort> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> X, Vector<int> XB, Vector<int> Y, Vector<int> YB, Vector<int> Z, Vector<int> ZB) YGroup3UnzipX2(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3, Vector<int> data4, Vector<int> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> X, Vector<uint> XB, Vector<uint> Y, Vector<uint> YB, Vector<uint> Z, Vector<uint> ZB) YGroup3UnzipX2(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3, Vector<uint> data4, Vector<uint> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> X, Vector<long> XB, Vector<long> Y, Vector<long> YB, Vector<long> Z, Vector<long> ZB) YGroup3UnzipX2(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3, Vector<long> data4, Vector<long> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> X, Vector<ulong> XB, Vector<ulong> Y, Vector<ulong> YB, Vector<ulong> Z, Vector<ulong> ZB) YGroup3UnzipX2(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3, Vector<ulong> data4, Vector<ulong> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }


        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Data0, Vector<T> Data1, Vector<T> Data2) YGroup3Zip<T>(Vector<T> x, Vector<T> y, Vector<T> z) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector<float>)(object)x, (Vector<float>)(object)y, (Vector<float>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector<double>)(object)x, (Vector<double>)(object)y, (Vector<double>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector<sbyte>)(object)x, (Vector<sbyte>)(object)y, (Vector<sbyte>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector<byte>)(object)x, (Vector<byte>)(object)y, (Vector<byte>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector<short>)(object)x, (Vector<short>)(object)y, (Vector<short>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector<ushort>)(object)x, (Vector<ushort>)(object)y, (Vector<ushort>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector<int>)(object)x, (Vector<int>)(object)y, (Vector<int>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector<uint>)(object)x, (Vector<uint>)(object)y, (Vector<uint>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector<long>)(object)x, (Vector<long>)(object)y, (Vector<long>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector<ulong>)(object)x, (Vector<ulong>)(object)y, (Vector<ulong>)(object)z);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        ///  Interleave 3 vectors into 3-element groups. It converts the 3-element groups SoA to AoS. It can also interleave R,G,B planar data into packed RGB pixel data (将3-元素组解交织为3个向量. 它能将3元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B 平面数据, 交织为 已打包的RGB像素数据).
        /// Mnemonic: <c>element_ref(i, data0, data1, data2) := (0==(i%3))?( x[i2] ):( (1==(i%3))?( y[i2] ):( z[i2] ) )</c>, <c>i2 := i/3</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <param name="z">A vector consisting purely of Z-components (纯由Z分量所组成的向量).</param>
        /// <returns>Returns the interleaved data (返回交织后数据).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Data0, Vector<float> Data1, Vector<float> Data2) YGroup3Zip(Vector<float> x, Vector<float> y, Vector<float> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Data0, Vector<double> Data1, Vector<double> Data2) YGroup3Zip(Vector<double> x, Vector<double> y, Vector<double> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Data0, Vector<sbyte> Data1, Vector<sbyte> Data2) YGroup3Zip(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Data0, Vector<byte> Data1, Vector<byte> Data2) YGroup3Zip(Vector<byte> x, Vector<byte> y, Vector<byte> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Data0, Vector<short> Data1, Vector<short> Data2) YGroup3Zip(Vector<short> x, Vector<short> y, Vector<short> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Data0, Vector<ushort> Data1, Vector<ushort> Data2) YGroup3Zip(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Data0, Vector<int> Data1, Vector<int> Data2) YGroup3Zip(Vector<int> x, Vector<int> y, Vector<int> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Data0, Vector<uint> Data1, Vector<uint> Data2) YGroup3Zip(Vector<uint> x, Vector<uint> y, Vector<uint> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Data0, Vector<long> Data1, Vector<long> Data2) YGroup3Zip(Vector<long> x, Vector<long> y, Vector<long> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Data0, Vector<ulong> Data1, Vector<ulong> Data2) YGroup3Zip(Vector<ulong> x, Vector<ulong> y, Vector<ulong> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }


        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Data0, Vector<T> Data1, Vector<T> Data2, Vector<T> Data3, Vector<T> Data4, Vector<T> Data5) YGroup3ZipX2<T>(Vector<T> x, Vector<T> xB, Vector<T> y, Vector<T> yB, Vector<T> z, Vector<T> zB) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector<float>)(object)x, (Vector<float>)(object)xB, (Vector<float>)(object)y, (Vector<float>)(object)yB, (Vector<float>)(object)z, (Vector<float>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector<double>)(object)x, (Vector<double>)(object)xB, (Vector<double>)(object)y, (Vector<double>)(object)yB, (Vector<double>)(object)z, (Vector<double>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector<sbyte>)(object)x, (Vector<sbyte>)(object)xB, (Vector<sbyte>)(object)y, (Vector<sbyte>)(object)yB, (Vector<sbyte>)(object)z, (Vector<sbyte>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector<byte>)(object)x, (Vector<byte>)(object)xB, (Vector<byte>)(object)y, (Vector<byte>)(object)yB, (Vector<byte>)(object)z, (Vector<byte>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector<short>)(object)x, (Vector<short>)(object)xB, (Vector<short>)(object)y, (Vector<short>)(object)yB, (Vector<short>)(object)z, (Vector<short>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector<ushort>)(object)x, (Vector<ushort>)(object)xB, (Vector<ushort>)(object)y, (Vector<ushort>)(object)yB, (Vector<ushort>)(object)z, (Vector<ushort>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector<int>)(object)x, (Vector<int>)(object)xB, (Vector<int>)(object)y, (Vector<int>)(object)yB, (Vector<int>)(object)z, (Vector<int>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector<uint>)(object)x, (Vector<uint>)(object)xB, (Vector<uint>)(object)y, (Vector<uint>)(object)yB, (Vector<uint>)(object)z, (Vector<uint>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector<long>)(object)x, (Vector<long>)(object)xB, (Vector<long>)(object)y, (Vector<long>)(object)yB, (Vector<long>)(object)z, (Vector<long>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector<ulong>)(object)x, (Vector<ulong>)(object)xB, (Vector<ulong>)(object)y, (Vector<ulong>)(object)yB, (Vector<ulong>)(object)z, (Vector<ulong>)(object)zB);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3, (Vector<T>)(object)rt4, (Vector<T>)(object)rt5);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Interleave 3 vectors into 3-element groups and process 2x data (将3-元素组解交织为3个向量, 且处理2倍数据).
        /// Mnemonic: <c>(data0, data1, data2) = YGroup3Zip(x, y, z)</c>, <c>(data3, data4, data5) = YGroup3Zip(xB, yB, zB)</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components - Part 0 (纯由X分量所组成的向量 - 第0部分).</param>
        /// <param name="xB">A vector consisting purely of X-components - Part 1 (纯由X分量所组成的向量 - 第1部分).</param>
        /// <param name="y">A vector consisting purely of Y-components - Part 0 (纯由Y分量所组成的向量 - 第0部分).</param>
        /// <param name="yB">A vector consisting purely of Y-components - Part 1 (纯由Y分量所组成的向量 - 第1部分).</param>
        /// <param name="z">A vector consisting purely of Z-components - Part 0 (纯由Z分量所组成的向量 - 第0部分).</param>
        /// <param name="zB">A vector consisting purely of Z-components - Part 1 (纯由Z分量所组成的向量 - 第1部分).</param>
        /// <returns>Returns the interleaved data (返回交织后数据).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Data0, Vector<float> Data1, Vector<float> Data2, Vector<float> Data3, Vector<float> Data4, Vector<float> Data5) YGroup3ZipX2(Vector<float> x, Vector<float> xB, Vector<float> y, Vector<float> yB, Vector<float> z, Vector<float> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Data0, Vector<double> Data1, Vector<double> Data2, Vector<double> Data3, Vector<double> Data4, Vector<double> Data5) YGroup3ZipX2(Vector<double> x, Vector<double> xB, Vector<double> y, Vector<double> yB, Vector<double> z, Vector<double> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Data0, Vector<sbyte> Data1, Vector<sbyte> Data2, Vector<sbyte> Data3, Vector<sbyte> Data4, Vector<sbyte> Data5) YGroup3ZipX2(Vector<sbyte> x, Vector<sbyte> xB, Vector<sbyte> y, Vector<sbyte> yB, Vector<sbyte> z, Vector<sbyte> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Data0, Vector<byte> Data1, Vector<byte> Data2, Vector<byte> Data3, Vector<byte> Data4, Vector<byte> Data5) YGroup3ZipX2(Vector<byte> x, Vector<byte> xB, Vector<byte> y, Vector<byte> yB, Vector<byte> z, Vector<byte> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Data0, Vector<short> Data1, Vector<short> Data2, Vector<short> Data3, Vector<short> Data4, Vector<short> Data5) YGroup3ZipX2(Vector<short> x, Vector<short> xB, Vector<short> y, Vector<short> yB, Vector<short> z, Vector<short> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Data0, Vector<ushort> Data1, Vector<ushort> Data2, Vector<ushort> Data3, Vector<ushort> Data4, Vector<ushort> Data5) YGroup3ZipX2(Vector<ushort> x, Vector<ushort> xB, Vector<ushort> y, Vector<ushort> yB, Vector<ushort> z, Vector<ushort> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Data0, Vector<int> Data1, Vector<int> Data2, Vector<int> Data3, Vector<int> Data4, Vector<int> Data5) YGroup3ZipX2(Vector<int> x, Vector<int> xB, Vector<int> y, Vector<int> yB, Vector<int> z, Vector<int> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Data0, Vector<uint> Data1, Vector<uint> Data2, Vector<uint> Data3, Vector<uint> Data4, Vector<uint> Data5) YGroup3ZipX2(Vector<uint> x, Vector<uint> xB, Vector<uint> y, Vector<uint> yB, Vector<uint> z, Vector<uint> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Data0, Vector<long> Data1, Vector<long> Data2, Vector<long> Data3, Vector<long> Data4, Vector<long> Data5) YGroup3ZipX2(Vector<long> x, Vector<long> xB, Vector<long> y, Vector<long> yB, Vector<long> z, Vector<long> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Data0, Vector<ulong> Data1, Vector<ulong> Data2, Vector<ulong> Data3, Vector<ulong> Data4, Vector<ulong> Data5) YGroup3ZipX2(Vector<ulong> x, Vector<ulong> xB, Vector<ulong> y, Vector<ulong> yB, Vector<ulong> z, Vector<ulong> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }


#if BCL_TYPE_INT128

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup4Unzip(Vector<Int128> data0, Vector<Int128> data1, Vector<Int128> data2, Vector<Int128> data3, out Vector<Int128> y, out Vector<Int128> z, out Vector<Int128> w) {
            var d0 = YGroup4Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), data2.ExAsExInt128(), data3.ExAsExInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsInt128();
            z = d2.ExAsInt128();
            w = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Unzip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup4Unzip(Vector<UInt128> data0, Vector<UInt128> data1, Vector<UInt128> data2, Vector<UInt128> data3, out Vector<UInt128> y, out Vector<UInt128> z, out Vector<UInt128> w) {
            var d0 = YGroup4Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsUInt128();
            z = d2.ExAsUInt128();
            w = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> X, Vector<T> Y, Vector<T> Z, Vector<T> W) YGroup4Unzip<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<float>)(object)data0, (Vector<float>)(object)data1, (Vector<float>)(object)data2, (Vector<float>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<double>)(object)data0, (Vector<double>)(object)data1, (Vector<double>)(object)data2, (Vector<double>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<sbyte>)(object)data0, (Vector<sbyte>)(object)data1, (Vector<sbyte>)(object)data2, (Vector<sbyte>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<byte>)(object)data0, (Vector<byte>)(object)data1, (Vector<byte>)(object)data2, (Vector<byte>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<short>)(object)data0, (Vector<short>)(object)data1, (Vector<short>)(object)data2, (Vector<short>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<ushort>)(object)data0, (Vector<ushort>)(object)data1, (Vector<ushort>)(object)data2, (Vector<ushort>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<int>)(object)data0, (Vector<int>)(object)data1, (Vector<int>)(object)data2, (Vector<int>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<uint>)(object)data0, (Vector<uint>)(object)data1, (Vector<uint>)(object)data2, (Vector<uint>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<long>)(object)data0, (Vector<long>)(object)data1, (Vector<long>)(object)data2, (Vector<long>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<ulong>)(object)data0, (Vector<ulong>)(object)data1, (Vector<ulong>)(object)data2, (Vector<ulong>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<ExInt128>)(object)data0, (Vector<ExInt128>)(object)data1, (Vector<ExInt128>)(object)data2, (Vector<ExInt128>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<ExUInt128>)(object)data0, (Vector<ExUInt128>)(object)data1, (Vector<ExUInt128>)(object)data2, (Vector<ExUInt128>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<Int128>)(object)data0, (Vector<Int128>)(object)data1, (Vector<Int128>)(object)data2, (Vector<Int128>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector<UInt128>)(object)data0, (Vector<UInt128>)(object)data1, (Vector<UInt128>)(object)data2, (Vector<UInt128>)(object)data3);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// De-Interleave 4-element groups into 4 vectors. It converts the 4-element groups AoS to SoA. It can also deinterleave packed RGBA pixel data into R,G,B,A planar data (将4-元素组解交织为4个向量. 它能将4元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGBA像素数据, 解交织为 R,G,B,A 平面数据).
        /// Mnemonic: <c>x[i] =: element_ref(4*i, data0, data1, data2, data3)</c>, <c>y[i] =: element_ref(4*i+1, data0, data1, data2, data3)</c>, <c>z[i] =: element_ref(4*i+2, data0, data1, data2, data3)</c>, <c>w[i] =: element_ref(4*i+3, data0, data1, data2, data3)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 4-element groups - Part 0 (由4元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 4-element groups - Part 1 (由4元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 4-element groups - Part 2 (由4元素组所组成的向量 - 第2部分).</param>
        /// <param name="data3">A vector made of 4-element groups - Part 3 (由4元素组所组成的向量 - 第3部分).</param>
        /// <returns>Returns the de-interleaved data. They are the X,Y,Z,W vectors (返回解交织后数据. 它们分别是 X,Y,Z,W 向量).</returns>
        /// <seealso cref="YGroup4Unzip_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> X, Vector<float> Y, Vector<float> Z, Vector<float> W) YGroup4Unzip(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> X, Vector<double> Y, Vector<double> Z, Vector<double> W) YGroup4Unzip(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> X, Vector<sbyte> Y, Vector<sbyte> Z, Vector<sbyte> W) YGroup4Unzip(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> X, Vector<byte> Y, Vector<byte> Z, Vector<byte> W) YGroup4Unzip(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> X, Vector<short> Y, Vector<short> Z, Vector<short> W) YGroup4Unzip(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector<ushort> X, Vector<ushort> Y, Vector<ushort> Z, Vector<ushort> W) YGroup4Unzip(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> X, Vector<int> Y, Vector<int> Z, Vector<int> W) YGroup4Unzip(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector<uint> X, Vector<uint> Y, Vector<uint> Z, Vector<uint> W) YGroup4Unzip(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> X, Vector<long> Y, Vector<long> Z, Vector<long> W) YGroup4Unzip(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector<ulong> X, Vector<ulong> Y, Vector<ulong> Z, Vector<ulong> W) YGroup4Unzip(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExInt128> X, Vector<ExInt128> Y, Vector<ExInt128> Z, Vector<ExInt128> W) YGroup4Unzip(Vector<ExInt128> data0, Vector<ExInt128> data1, Vector<ExInt128> data2, Vector<ExInt128> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExUInt128> X, Vector<ExUInt128> Y, Vector<ExUInt128> Z, Vector<ExUInt128> W) YGroup4Unzip(Vector<ExUInt128> data0, Vector<ExUInt128> data1, Vector<ExUInt128> data2, Vector<ExUInt128> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<Int128> X, Vector<Int128> Y, Vector<Int128> Z, Vector<Int128> W) YGroup4Unzip(Vector<Int128> data0, Vector<Int128> data1, Vector<Int128> data2, Vector<Int128> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<UInt128> X, Vector<UInt128> Y, Vector<UInt128> Z, Vector<UInt128> W) YGroup4Unzip(Vector<UInt128> data0, Vector<UInt128> data1, Vector<UInt128> data2, Vector<UInt128> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#endif // BCL_TYPE_INT128


#if BCL_TYPE_INT128

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128}, out Vector{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<Int128> YGroup4Zip(Vector<Int128> x, Vector<Int128> y, Vector<Int128> z, Vector<Int128> w, out Vector<Int128> data1, out Vector<Int128> data2, out Vector<Int128> data3) {
            var d0 = YGroup4Zip(x.ExAsExInt128(), y.ExAsExInt128(), z.ExAsExInt128(), w.ExAsExInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsInt128();
            data2 = d2.ExAsInt128();
            data3 = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IVectorTraits.YGroup4Zip(Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128}, out Vector{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<UInt128> YGroup4Zip(Vector<UInt128> x, Vector<UInt128> y, Vector<UInt128> z, Vector<UInt128> w, out Vector<UInt128> data1, out Vector<UInt128> data2, out Vector<UInt128> data3) {
            var d0 = YGroup4Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsUInt128();
            data2 = d2.ExAsUInt128();
            data3 = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Data0, Vector<T> Data1, Vector<T> Data2, Vector<T> Data3) YGroup4Zip<T>(Vector<T> x, Vector<T> y, Vector<T> z, Vector<T> w) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<float>)(object)x, (Vector<float>)(object)y, (Vector<float>)(object)z, (Vector<float>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<double>)(object)x, (Vector<double>)(object)y, (Vector<double>)(object)z, (Vector<double>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<sbyte>)(object)x, (Vector<sbyte>)(object)y, (Vector<sbyte>)(object)z, (Vector<sbyte>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<byte>)(object)x, (Vector<byte>)(object)y, (Vector<byte>)(object)z, (Vector<byte>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<short>)(object)x, (Vector<short>)(object)y, (Vector<short>)(object)z, (Vector<short>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<ushort>)(object)x, (Vector<ushort>)(object)y, (Vector<ushort>)(object)z, (Vector<ushort>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<int>)(object)x, (Vector<int>)(object)y, (Vector<int>)(object)z, (Vector<int>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<uint>)(object)x, (Vector<uint>)(object)y, (Vector<uint>)(object)z, (Vector<uint>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<long>)(object)x, (Vector<long>)(object)y, (Vector<long>)(object)z, (Vector<long>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<ulong>)(object)x, (Vector<ulong>)(object)y, (Vector<ulong>)(object)z, (Vector<ulong>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<ExInt128>)(object)x, (Vector<ExInt128>)(object)y, (Vector<ExInt128>)(object)z, (Vector<ExInt128>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<ExUInt128>)(object)x, (Vector<ExUInt128>)(object)y, (Vector<ExUInt128>)(object)z, (Vector<ExUInt128>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<Int128>)(object)x, (Vector<Int128>)(object)y, (Vector<Int128>)(object)z, (Vector<Int128>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector<UInt128>)(object)x, (Vector<UInt128>)(object)y, (Vector<UInt128>)(object)z, (Vector<UInt128>)(object)w);
                return ((Vector<T>)(object)rt0, (Vector<T>)(object)rt1, (Vector<T>)(object)rt2, (Vector<T>)(object)rt3);
#endif // BCL_TYPE_INT128
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Interleave 4 vectors into 4-element groups. It converts the 4-element groups SoA to AoS. It can also interleave R,G,B,A planar data into packed RGBA pixel data (将4个向量交织为4-元素组. 它能将4元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B,A 平面数据, 交织为 已打包的RGBA像素数据).
        /// Mnemonic: <c>element_ref(i, data0, data1, data2, data3) := (0==(i&amp;3))?( x[i2] ):( (1==(i&amp;3))?( y[i2] ):( (2==(i&amp;s3))?( z[i2] ):( w[i2] ) ) )</c>, <c>i2 := i/4</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="y">A vector consisting purely of Y-components (纯由Y分量所组成的向量).</param>
        /// <param name="z">A vector consisting purely of Z-components (纯由Z分量所组成的向量).</param>
        /// <param name="w">A vector consisting purely of W-components (纯由W分量所组成的向量).</param>
        /// <returns>Returns the interleaved data (返回交织后数据).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Data0, Vector<float> Data1, Vector<float> Data2, Vector<float> Data3) YGroup4Zip(Vector<float> x, Vector<float> y, Vector<float> z, Vector<float> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Data0, Vector<double> Data1, Vector<double> Data2, Vector<double> Data3) YGroup4Zip(Vector<double> x, Vector<double> y, Vector<double> z, Vector<double> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Data0, Vector<sbyte> Data1, Vector<sbyte> Data2, Vector<sbyte> Data3) YGroup4Zip(Vector<sbyte> x, Vector<sbyte> y, Vector<sbyte> z, Vector<sbyte> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Data0, Vector<byte> Data1, Vector<byte> Data2, Vector<byte> Data3) YGroup4Zip(Vector<byte> x, Vector<byte> y, Vector<byte> z, Vector<byte> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Data0, Vector<short> Data1, Vector<short> Data2, Vector<short> Data3) YGroup4Zip(Vector<short> x, Vector<short> y, Vector<short> z, Vector<short> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Data0, Vector<ushort> Data1, Vector<ushort> Data2, Vector<ushort> Data3) YGroup4Zip(Vector<ushort> x, Vector<ushort> y, Vector<ushort> z, Vector<ushort> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Data0, Vector<int> Data1, Vector<int> Data2, Vector<int> Data3) YGroup4Zip(Vector<int> x, Vector<int> y, Vector<int> z, Vector<int> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Data0, Vector<uint> Data1, Vector<uint> Data2, Vector<uint> Data3) YGroup4Zip(Vector<uint> x, Vector<uint> y, Vector<uint> z, Vector<uint> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Data0, Vector<long> Data1, Vector<long> Data2, Vector<long> Data3) YGroup4Zip(Vector<long> x, Vector<long> y, Vector<long> z, Vector<long> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Data0, Vector<ulong> Data1, Vector<ulong> Data2, Vector<ulong> Data3) YGroup4Zip(Vector<ulong> x, Vector<ulong> y, Vector<ulong> z, Vector<ulong> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExInt128> Data0, Vector<ExInt128> Data1, Vector<ExInt128> Data2, Vector<ExInt128> Data3) YGroup4Zip(Vector<ExInt128> x, Vector<ExInt128> y, Vector<ExInt128> z, Vector<ExInt128> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ExUInt128> Data0, Vector<ExUInt128> Data1, Vector<ExUInt128> Data2, Vector<ExUInt128> Data3) YGroup4Zip(Vector<ExUInt128> x, Vector<ExUInt128> y, Vector<ExUInt128> z, Vector<ExUInt128> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<Int128> Data0, Vector<Int128> Data1, Vector<Int128> Data2, Vector<Int128> Data3) YGroup4Zip(Vector<Int128> x, Vector<Int128> y, Vector<Int128> z, Vector<Int128> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<UInt128> Data0, Vector<UInt128> Data1, Vector<UInt128> Data2, Vector<UInt128> Data3) YGroup4Zip(Vector<UInt128> x, Vector<UInt128> y, Vector<UInt128> z, Vector<UInt128> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#endif // BCL_TYPE_INT128


        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        /// <seealso cref="YShuffleG4X2(Vector{float}, Vector{float}, ShuffleControlG4, out Vector{float})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector<T> Result0, Vector<T> Result1) YShuffleG4X2<T>(Vector<T> source0, Vector<T> source1, ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector<float>)(object)source0, (Vector<float>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector<double>)(object)source0, (Vector<double>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector<sbyte>)(object)source0, (Vector<sbyte>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector<byte>)(object)source0, (Vector<byte>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector<short>)(object)source0, (Vector<short>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector<ushort>)(object)source0, (Vector<ushort>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector<int>)(object)source0, (Vector<int>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector<uint>)(object)source0, (Vector<uint>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector<long>)(object)source0, (Vector<long>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector<ulong>)(object)source0, (Vector<ulong>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Result0, Vector<float> Result1) YShuffleG4X2(Vector<float> source0, Vector<float> source1, ShuffleControlG4 control) {
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Result0, Vector<double> Result1) YShuffleG4X2(Vector<double> source0, Vector<double> source1, ShuffleControlG4 control) {
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Result0, Vector<sbyte> Result1) YShuffleG4X2(Vector<sbyte> source0, Vector<sbyte> source1, ShuffleControlG4 control) {
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Result0, Vector<byte> Result1) YShuffleG4X2(Vector<byte> source0, Vector<byte> source1, ShuffleControlG4 control) {
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Result0, Vector<short> Result1) YShuffleG4X2(Vector<short> source0, Vector<short> source1, ShuffleControlG4 control) {
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Result0, Vector<ushort> Result1) YShuffleG4X2(Vector<ushort> source0, Vector<ushort> source1, ShuffleControlG4 control) {
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Result0, Vector<int> Result1) YShuffleG4X2(Vector<int> source0, Vector<int> source1, ShuffleControlG4 control) {
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Result0, Vector<uint> Result1) YShuffleG4X2(Vector<uint> source0, Vector<uint> source1, ShuffleControlG4 control) {
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Result0, Vector<long> Result1) YShuffleG4X2(Vector<long> source0, Vector<long> source1, ShuffleControlG4 control) {
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Result0, Vector<ulong> Result1) YShuffleG4X2(Vector<ulong> source0, Vector<ulong> source1, ShuffleControlG4 control) {
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        /// <seealso cref="YShuffleG4X2_Const(Vector{int}, Vector{int}, ShuffleControlG4, out Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector<T> Result0, Vector<T> Result1) YShuffleG4X2_Const<T>(Vector<T> source0, Vector<T> source1, [ConstantExpected] ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector<float>)(object)source0, (Vector<float>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector<double>)(object)source0, (Vector<double>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector<sbyte>)(object)source0, (Vector<sbyte>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector<byte>)(object)source0, (Vector<byte>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector<short>)(object)source0, (Vector<short>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector<ushort>)(object)source0, (Vector<ushort>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector<int>)(object)source0, (Vector<int>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector<uint>)(object)source0, (Vector<uint>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector<long>)(object)source0, (Vector<long>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector<ulong>)(object)source0, (Vector<ulong>)(object)source1, control);
                return ((Vector<T>)(object)result0, (Vector<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }


        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Result0, Vector<float> Result1) YShuffleG4X2_Const(Vector<float> source0, Vector<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Result0, Vector<double> Result1) YShuffleG4X2_Const(Vector<double> source0, Vector<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Result0, Vector<sbyte> Result1) YShuffleG4X2_Const(Vector<sbyte> source0, Vector<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Result0, Vector<byte> Result1) YShuffleG4X2_Const(Vector<byte> source0, Vector<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Result0, Vector<short> Result1) YShuffleG4X2_Const(Vector<short> source0, Vector<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Result0, Vector<ushort> Result1) YShuffleG4X2_Const(Vector<ushort> source0, Vector<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Result0, Vector<int> Result1) YShuffleG4X2_Const(Vector<int> source0, Vector<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Result0, Vector<uint> Result1) YShuffleG4X2_Const(Vector<uint> source0, Vector<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Result0, Vector<long> Result1) YShuffleG4X2_Const(Vector<long> source0, Vector<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element groups in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Result0, Vector<ulong> Result1) YShuffleG4X2_Const(Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }


        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleInsert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleInsert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleInsert_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleInsert_Args<TIdx>(Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a0;
                args1 = (Vector<TIdx>)(object)a1;
                args2 = (Vector<TIdx>)(object)a2;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vectors.YShuffleInsert_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2) YShuffleInsert_Args<TIdx>(Vector<TIdx> indices)
                where TIdx : struct {
            YShuffleInsert_Args<TIdx>(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2) YShuffleInsert_Args(Vector<sbyte> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2) YShuffleInsert_Args(Vector<byte> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2) YShuffleInsert_Args(Vector<short> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2) YShuffleInsert_Args(Vector<ushort> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2) YShuffleInsert_Args(Vector<int> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2) YShuffleInsert_Args(Vector<uint> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2) YShuffleInsert_Args(Vector<long> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2) YShuffleInsert_Args(Vector<ulong> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }


        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleInsert_Core(Vector<float> back, Vector<float> vector, (Vector<int> args0, Vector<int> args1, Vector<int> args2) args) {
            return YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleInsert_Core(Vector<double> back, Vector<double> vector, (Vector<long> args0, Vector<long> args1, Vector<long> args2) args) {
            return YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleInsert_Core(Vector<sbyte> back, Vector<sbyte> vector, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2) args) {
            return YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleInsert_Core(Vector<byte> back, Vector<byte> vector, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2) args) {
            return YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleInsert_Core(Vector<short> back, Vector<short> vector, (Vector<short> args0, Vector<short> args1, Vector<short> args2) args) {
            return YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleInsert_Core(Vector<ushort> back, Vector<ushort> vector, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2) args) {
            return YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleInsert_Core(Vector<int> back, Vector<int> vector, (Vector<int> args0, Vector<int> args1, Vector<int> args2) args) {
            return YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleInsert_Core(Vector<uint> back, Vector<uint> vector, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2) args) {
            return YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleInsert_Core(Vector<long> back, Vector<long> vector, (Vector<long> args0, Vector<long> args1, Vector<long> args2) args) {
            return YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }

        /// <summary>
        /// Core calculation for shuffle and insert (换位并插入的核心计算). Its arguments are derived from YShuffleInsert_Args (其参数来源于 YShuffleInsert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleInsert_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleInsert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleInsert_Core(Vector<ulong> back, Vector<ulong> vector, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2) args) {
            return YShuffleInsert_Core(back, vector, args.args0, args.args1, args.args2);
        }


        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleKernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleKernel_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleKernel_Args<TIdx>(Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vectors.YShuffleKernel_Args{TIdx}(Vector{TIdx}, out Vector{TIdx}, out Vector{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1) YShuffleKernel_Args<TIdx>(Vector<TIdx> indices)
                where TIdx : struct {
            YShuffleKernel_Args<TIdx>(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1) YShuffleKernel_Args(Vector<sbyte> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1) YShuffleKernel_Args(Vector<byte> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1) YShuffleKernel_Args(Vector<short> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1) YShuffleKernel_Args(Vector<ushort> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1) YShuffleKernel_Args(Vector<int> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1) YShuffleKernel_Args(Vector<uint> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1) YShuffleKernel_Args(Vector<long> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1) YShuffleKernel_Args(Vector<ulong> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }


        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Core(Vector{float}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleKernel_Core(Vector<float> vector, (Vector<int> args0, Vector<int> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Core(Vector{double}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleKernel_Core(Vector<double> vector, (Vector<long> args0, Vector<long> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleKernel_Core(Vector<sbyte> vector, (Vector<sbyte> args0, Vector<sbyte> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleKernel_Core(Vector<byte> vector, (Vector<byte> args0, Vector<byte> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Core(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleKernel_Core(Vector<short> vector, (Vector<short> args0, Vector<short> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleKernel_Core(Vector<ushort> vector, (Vector<ushort> args0, Vector<ushort> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Core(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleKernel_Core(Vector<int> vector, (Vector<int> args0, Vector<int> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleKernel_Core(Vector<uint> vector, (Vector<uint> args0, Vector<uint> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Core(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleKernel_Core(Vector<long> vector, (Vector<long> args0, Vector<long> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleKernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleKernel_Core(Vector<ulong> vector, (Vector<ulong> args0, Vector<ulong> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }


        /// <summary>
        /// Arguments calculation for shuffle and clear on 2 vectors (在2个向量上进行换位并清零的参数计算). Provide arguments for YShuffleX2_Core (为 YShuffleX2_Core 提供参数). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):0</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX2_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX2_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX2_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX2_Core .</param>
        /// <param name="args4">Arguments 4 (参数4). Used for YShuffleX2_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleX2_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX2_Args<TIdx>(Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3, out Vector<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear on 2 vectors (在2个向量上进行换位并清零的参数计算). Provide arguments for YShuffleX2_Core (为 YShuffleX2_Core 提供参数). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):0</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX2_Core (为 YShuffleX2_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) YShuffleX2_Args<TIdx>(Vector<TIdx> indices)
                where TIdx : struct {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear on 2 vectors (在2个向量上进行换位并清零的参数计算). Provide arguments for YShuffleX2_Core (为 YShuffleX2_Core 提供参数). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX2_Core (为 YShuffleX2_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX2_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) YShuffleX2_Args(Vector<sbyte> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) YShuffleX2_Args(Vector<byte> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) YShuffleX2_Args(Vector<short> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) YShuffleX2_Args(Vector<ushort> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) YShuffleX2_Args(Vector<int> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) YShuffleX2_Args(Vector<uint> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) YShuffleX2_Args(Vector<long> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) YShuffleX2_Args(Vector<ulong> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        // -- YShuffleX2_Core: ValueTuple --
        /// <summary>
        /// Core calculation for shuffle and clear on 2 vectors (在2个向量上进行换位并清零的核心计算). Its arguments are derived from YShuffleX2_Args (其参数来源于 YShuffleX2_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):0</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX2_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX2_Core(Vector<float> vector0, Vector<float> vector1, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX2_Core(Vector<double> vector0, Vector<double> vector1, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX2_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX2_Core(Vector<byte> vector0, Vector<byte> vector1, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX2_Core(Vector<short> vector0, Vector<short> vector1, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX2_Core(Vector<ushort> vector0, Vector<ushort> vector1, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX2_Core(Vector<int> vector0, Vector<int> vector1, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX2_Core(Vector<uint> vector0, Vector<uint> vector1, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX2_Core(Vector<long> vector0, Vector<long> vector1, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX2_Core(Vector<ulong> vector0, Vector<ulong> vector1, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <summary>
        /// Arguments calculation for shuffle and insert on 2 vectors (在2个向量上进行换位并插入的参数计算). Provide arguments for YShuffleX2Insert_Core (为 YShuffleX2Insert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):back[i]</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX2Insert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX2Insert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX2Insert_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX2Insert_Core .</param>
        /// <param name="args4">Arguments 4 (参数4). Used for YShuffleX2Insert_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX2Insert_Args<TIdx>(Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3, out Vector<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert on 2 vectors (在2个向量上进行换位并插入的参数计算). Provide arguments for YShuffleX2Insert_Core (为 YShuffleX2Insert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):back[i]</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX2Insert_Core (为 YShuffleX2Insert_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) YShuffleX2Insert_Args<TIdx>(Vector<TIdx> indices)
                where TIdx : struct {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert on 2 vectors (在2个向量上进行换位并插入的参数计算). Provide arguments for YShuffleX2Insert_Core (为 YShuffleX2Insert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX2Insert_Core (为 YShuffleX2Insert_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) YShuffleX2Insert_Args(Vector<sbyte> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) YShuffleX2Insert_Args(Vector<byte> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) YShuffleX2Insert_Args(Vector<short> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) YShuffleX2Insert_Args(Vector<ushort> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) YShuffleX2Insert_Args(Vector<int> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) YShuffleX2Insert_Args(Vector<uint> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) YShuffleX2Insert_Args(Vector<long> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) YShuffleX2Insert_Args(Vector<ulong> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        // -- YShuffleX2Insert_Core: ValueTuple --
        /// <summary>
        /// Core calculation for shuffle and insert on 2 vectors (在2个向量上进行换位并插入的核心计算). Its arguments are derived from YShuffleX2Insert_Args (其参数来源于 YShuffleX2Insert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2))?( element_ref(indices[i], vector0, vector1) ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX2Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX2Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX2Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX2Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX2Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX2Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX2Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX2Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX2Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX2Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <summary>
        /// Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX2Kernel_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX2Kernel_Args<TIdx>(Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3) YShuffleX2Kernel_Args<TIdx>(Vector<TIdx> indices)
                where TIdx : struct {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) YShuffleX2Kernel_Args(Vector<sbyte> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) YShuffleX2Kernel_Args(Vector<byte> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) YShuffleX2Kernel_Args(Vector<short> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) YShuffleX2Kernel_Args(Vector<ushort> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) YShuffleX2Kernel_Args(Vector<int> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) YShuffleX2Kernel_Args(Vector<uint> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) YShuffleX2Kernel_Args(Vector<long> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) YShuffleX2Kernel_Args(Vector<ulong> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        // -- YShuffleX2Kernel_Core: ValueTuple --
        /// <summary>
        /// Core calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX2Kernel_Args (其参数来源于 YShuffleX2Kernel_Args).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX2Kernel_Core(Vector<float> vector0, Vector<float> vector1, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX2Kernel_Core(Vector<double> vector0, Vector<double> vector1, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX2Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX2Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX2Kernel_Core(Vector<short> vector0, Vector<short> vector1, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX2Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX2Kernel_Core(Vector<int> vector0, Vector<int> vector1, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX2Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX2Kernel_Core(Vector<long> vector0, Vector<long> vector1, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX2Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }


        /// <summary>
        /// Arguments calculation for shuffle and clear on 3 vectors (在3个向量上进行换位并清零的参数计算). Provide arguments for YShuffleX3_Core (为 YShuffleX3_Core 提供参数). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):0</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX3_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX3_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX3_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX3_Core .</param>
        /// <param name="args4">Arguments 4 (参数4). Used for YShuffleX3_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleX3_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX3_Args<TIdx>(Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3, out Vector<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear on 3 vectors (在3个向量上进行换位并清零的参数计算). Provide arguments for YShuffleX3_Core (为 YShuffleX3_Core 提供参数). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):0</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX3_Core (为 YShuffleX3_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) YShuffleX3_Args<TIdx>(Vector<TIdx> indices)
                where TIdx : struct {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear on 3 vectors (在3个向量上进行换位并清零的参数计算). Provide arguments for YShuffleX3_Core (为 YShuffleX3_Core 提供参数). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX3_Core (为 YShuffleX3_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX3_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) YShuffleX3_Args(Vector<sbyte> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) YShuffleX3_Args(Vector<byte> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) YShuffleX3_Args(Vector<short> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) YShuffleX3_Args(Vector<ushort> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) YShuffleX3_Args(Vector<int> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) YShuffleX3_Args(Vector<uint> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) YShuffleX3_Args(Vector<long> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) YShuffleX3_Args(Vector<ulong> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        // -- YShuffleX3_Core: ValueTuple --
        /// <summary>
        /// Core calculation for shuffle and clear on 3 vectors (在3个向量上进行换位并清零的核心计算). Its arguments are derived from YShuffleX3_Args (其参数来源于 YShuffleX3_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):0</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX3_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX3_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Core(Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX3_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX3_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX3_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX3_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX3_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX3_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX3_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX3_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX3_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <summary>
        /// Arguments calculation for shuffle and insert on 3 vectors (在3个向量上进行换位并插入的参数计算). Provide arguments for YShuffleX3Insert_Core (为 YShuffleX3Insert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):back[i]</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX3Insert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX3Insert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX3Insert_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX3Insert_Core .</param>
        /// <param name="args4">Arguments 4 (参数4). Used for YShuffleX3Insert_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX3Insert_Args<TIdx>(Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3, out Vector<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert on 3 vectors (在3个向量上进行换位并插入的参数计算). Provide arguments for YShuffleX3Insert_Core (为 YShuffleX3Insert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):back[i]</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX3Insert_Core (为 YShuffleX3Insert_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) YShuffleX3Insert_Args<TIdx>(Vector<TIdx> indices)
                where TIdx : struct {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert on 3 vectors (在3个向量上进行换位并插入的参数计算). Provide arguments for YShuffleX3Insert_Core (为 YShuffleX3Insert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX3Insert_Core (为 YShuffleX3Insert_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) YShuffleX3Insert_Args(Vector<sbyte> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) YShuffleX3Insert_Args(Vector<byte> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) YShuffleX3Insert_Args(Vector<short> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) YShuffleX3Insert_Args(Vector<ushort> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) YShuffleX3Insert_Args(Vector<int> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) YShuffleX3Insert_Args(Vector<uint> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) YShuffleX3Insert_Args(Vector<long> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) YShuffleX3Insert_Args(Vector<ulong> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        // -- YShuffleX3Insert_Core: ValueTuple --
        /// <summary>
        /// Core calculation for shuffle and insert on 3 vectors (在3个向量上进行换位并插入的核心计算). Its arguments are derived from YShuffleX3Insert_Args (其参数来源于 YShuffleX3Insert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3))?( element_ref(indices[i], vector0, vector1, vector2) ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX3Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX3Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX3Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX3Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX3Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX3Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX3Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX3Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX3Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX3Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <summary>
        /// Arguments calculation for only shuffle on 3 vectors (在3个向量上进行仅换位的参数计算). Provide arguments for YShuffleX3Kernel_Core (为 YShuffleX3Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX3Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX3Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX3Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX3Kernel_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX3Kernel_Args<TIdx>(Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 3 vectors (在3个向量上进行仅换位的参数计算). Provide arguments for YShuffleX3Kernel_Core (为 YShuffleX3Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX3Kernel_Core (为 YShuffleX3Kernel_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3) YShuffleX3Kernel_Args<TIdx>(Vector<TIdx> indices)
                where TIdx : struct {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 3 vectors (在3个向量上进行仅换位的参数计算). Provide arguments for YShuffleX3Kernel_Core (为 YShuffleX3Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX3Kernel_Core (为 YShuffleX3Kernel_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) YShuffleX3Kernel_Args(Vector<sbyte> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) YShuffleX3Kernel_Args(Vector<byte> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) YShuffleX3Kernel_Args(Vector<short> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) YShuffleX3Kernel_Args(Vector<ushort> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) YShuffleX3Kernel_Args(Vector<int> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) YShuffleX3Kernel_Args(Vector<uint> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) YShuffleX3Kernel_Args(Vector<long> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) YShuffleX3Kernel_Args(Vector<ulong> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        // -- YShuffleX3Kernel_Core: ValueTuple --
        /// <summary>
        /// Core calculation for only shuffle on 3 vectors (在3个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX3Kernel_Args (其参数来源于 YShuffleX3Kernel_Args).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*3)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX3Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX3Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX3Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX3Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX3Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX3Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX3Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX3Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX3Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX3Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }


        /// <summary>
        /// Arguments calculation for shuffle and clear on 4 vectors (在4个向量上进行换位并清零的参数计算). Provide arguments for YShuffleX4_Core (为 YShuffleX4_Core 提供参数). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):0</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX4_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX4_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX4_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX4_Core .</param>
        /// <param name="args4">Arguments 4 (参数4). Used for YShuffleX4_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleX4_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX4_Args<TIdx>(Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3, out Vector<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear on 4 vectors (在4个向量上进行换位并清零的参数计算). Provide arguments for YShuffleX4_Core (为 YShuffleX4_Core 提供参数). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):0</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX4_Core (为 YShuffleX4_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) YShuffleX4_Args<TIdx>(Vector<TIdx> indices)
                where TIdx : struct {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <summary>
        /// Arguments calculation for shuffle and clear on 4 vectors (在4个向量上进行换位并清零的参数计算). Provide arguments for YShuffleX4_Core (为 YShuffleX4_Core 提供参数). If the indices value is out of range, the element will be cleared (若索引值超出范围, 元素会被清零).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):0</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX4_Core (为 YShuffleX4_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX4_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) YShuffleX4_Args(Vector<sbyte> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) YShuffleX4_Args(Vector<byte> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) YShuffleX4_Args(Vector<short> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) YShuffleX4_Args(Vector<ushort> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) YShuffleX4_Args(Vector<int> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) YShuffleX4_Args(Vector<uint> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) YShuffleX4_Args(Vector<long> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) YShuffleX4_Args(Vector<ulong> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        // -- YShuffleX4_Core: ValueTuple --
        /// <summary>
        /// Core calculation for shuffle and clear on 4 vectors (在4个向量上进行换位并清零的核心计算). Its arguments are derived from YShuffleX4_Args (其参数来源于 YShuffleX4_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):0</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX4_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX4_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX4_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX4_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX4_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX4_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX4_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX4_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX4_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX4_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX4_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <summary>
        /// Arguments calculation for shuffle and insert on 4 vectors (在4个向量上进行换位并插入的参数计算). Provide arguments for YShuffleX4Insert_Core (为 YShuffleX4Insert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):back[i]</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX4Insert_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX4Insert_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX4Insert_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX4Insert_Core .</param>
        /// <param name="args4">Arguments 4 (参数4). Used for YShuffleX4Insert_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX4Insert_Args<TIdx>(Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3, out Vector<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
                args4 = (Vector<TIdx>)(object)e;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert on 4 vectors (在4个向量上进行换位并插入的参数计算). Provide arguments for YShuffleX4Insert_Core (为 YShuffleX4Insert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):back[i]</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX4Insert_Core (为 YShuffleX4Insert_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3, Vector<TIdx> args4) YShuffleX4Insert_Args<TIdx>(Vector<TIdx> indices)
                where TIdx : struct {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert on 4 vectors (在4个向量上进行换位并插入的参数计算). Provide arguments for YShuffleX4Insert_Core (为 YShuffleX4Insert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX4Insert_Core (为 YShuffleX4Insert_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) YShuffleX4Insert_Args(Vector<sbyte> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) YShuffleX4Insert_Args(Vector<byte> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) YShuffleX4Insert_Args(Vector<short> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) YShuffleX4Insert_Args(Vector<ushort> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) YShuffleX4Insert_Args(Vector<int> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) YShuffleX4Insert_Args(Vector<uint> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) YShuffleX4Insert_Args(Vector<long> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) YShuffleX4Insert_Args(Vector<ulong> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        // -- YShuffleX4Insert_Core: ValueTuple --
        /// <summary>
        /// Core calculation for shuffle and insert on 4 vectors (在4个向量上进行换位并插入的核心计算). Its arguments are derived from YShuffleX4Insert_Args (其参数来源于 YShuffleX4Insert_Args).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4))?( element_ref(indices[i], vector0, vector1, vector2, vector3) ):back[i]</c>.
        /// </summary>
        /// <param name="back">The background vector (背景向量).</param>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量2).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量3).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX4Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX4Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX4Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX4Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX4Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX4Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX4Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX4Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX4Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX4Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <summary>
        /// Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX4Kernel_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX4Kernel_Args<TIdx>(Vector<TIdx> indices, out Vector<TIdx> args0, out Vector<TIdx> args1, out Vector<TIdx> args2, out Vector<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector<sbyte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector<byte>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector<short>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector<ushort>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector<int>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector<uint>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector<long>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector<ulong>)(object)indices);
                args0 = (Vector<TIdx>)(object)a;
                args1 = (Vector<TIdx>)(object)b;
                args2 = (Vector<TIdx>)(object)c;
                args3 = (Vector<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<TIdx> args0, Vector<TIdx> args1, Vector<TIdx> args2, Vector<TIdx> args3) YShuffleX4Kernel_Args<TIdx>(Vector<TIdx> indices)
                where TIdx : struct {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) YShuffleX4Kernel_Args(Vector<sbyte> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) YShuffleX4Kernel_Args(Vector<byte> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) YShuffleX4Kernel_Args(Vector<short> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) YShuffleX4Kernel_Args(Vector<ushort> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) YShuffleX4Kernel_Args(Vector<int> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) YShuffleX4Kernel_Args(Vector<uint> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) YShuffleX4Kernel_Args(Vector<long> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector{sbyte})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) YShuffleX4Kernel_Args(Vector<ulong> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        // -- YShuffleX4Kernel_Core: ValueTuple --
        /// <summary>
        /// Core calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的核心计算). Its arguments are derived from YShuffleX4Kernel_Args (其参数来源于 YShuffleX4Kernel_Args).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <param name="vector0">The input vector 0 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector1">The input vector 1 from which values are selected (从中选择值的输入向量0).</param>
        /// <param name="vector2">The input vector 2 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="vector3">The input vector 3 from which values are selected (从中选择值的输入向量1).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from input vectors selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从输入向量集中选择的值).</returns>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleX4Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleX4Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleX4Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, (Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleX4Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, (Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleX4Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, (Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleX4Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, (Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleX4Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, (Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleX4Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, (Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleX4Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, (Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, ValueTuple{Vector{int}, Vector{int}, Vector{int}, Vector{int}})"/>
        /// <seealso cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleX4Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, (Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

    }
}
