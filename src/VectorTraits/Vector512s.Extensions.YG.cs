#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
using System.Numerics;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Impl;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;
#if ALLOW_VECTOR_TUPLES
using Zyl.VectorTraits.Tuples;
#endif // ALLOW_VECTOR_TUPLES

namespace Zyl.VectorTraits {
    static partial class Vector512s {

#if NET8_0_OR_GREATER

#if BCL_TYPE_INT128

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup2Unzip(Vector512<Int128> data0, Vector512<Int128> data1, out Vector512<Int128> y) {
            var d0 = YGroup2Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), out var d1);
            y = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup2Unzip(Vector512<UInt128> data0, Vector512<UInt128> data1, out Vector512<UInt128> y) {
            var d0 = YGroup2Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
            y = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector512<T> X, Vector512<T> Y) YGroup2Unzip<T>(Vector512<T> data0, Vector512<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<float>)(object)data0, (Vector512<float>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<double>)(object)data0, (Vector512<double>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<sbyte>)(object)data0, (Vector512<sbyte>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<byte>)(object)data0, (Vector512<byte>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<short>)(object)data0, (Vector512<short>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<ushort>)(object)data0, (Vector512<ushort>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<int>)(object)data0, (Vector512<int>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<uint>)(object)data0, (Vector512<uint>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<long>)(object)data0, (Vector512<long>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<ulong>)(object)data0, (Vector512<ulong>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<ExInt128>)(object)data0, (Vector512<ExInt128>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<ExUInt128>)(object)data0, (Vector512<ExUInt128>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<Int128>)(object)data0, (Vector512<Int128>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector512<UInt128>)(object)data0, (Vector512<UInt128>)(object)data1);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1);
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
        public static (Vector512<float> X, Vector512<float> Y) YGroup2Unzip(Vector512<float> data0, Vector512<float> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> X, Vector512<double> Y) YGroup2Unzip(Vector512<double> data0, Vector512<double> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> X, Vector512<sbyte> Y) YGroup2Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> X, Vector512<byte> Y) YGroup2Unzip(Vector512<byte> data0, Vector512<byte> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> X, Vector512<short> Y) YGroup2Unzip(Vector512<short> data0, Vector512<short> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> X, Vector512<ushort> Y) YGroup2Unzip(Vector512<ushort> data0, Vector512<ushort> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> X, Vector512<int> Y) YGroup2Unzip(Vector512<int> data0, Vector512<int> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> X, Vector512<uint> Y) YGroup2Unzip(Vector512<uint> data0, Vector512<uint> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> X, Vector512<long> Y) YGroup2Unzip(Vector512<long> data0, Vector512<long> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> X, Vector512<ulong> Y) YGroup2Unzip(Vector512<ulong> data0, Vector512<ulong> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExInt128> X, Vector512<ExInt128> Y) YGroup2Unzip(Vector512<ExInt128> data0, Vector512<ExInt128> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExUInt128> X, Vector512<ExUInt128> Y) YGroup2Unzip(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<Int128> X, Vector512<Int128> Y) YGroup2Unzip(Vector512<Int128> data0, Vector512<Int128> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<UInt128> X, Vector512<UInt128> Y) YGroup2Unzip(Vector512<UInt128> data0, Vector512<UInt128> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2UnzipEven(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup2UnzipEven(Vector512<Int128> data0, Vector512<Int128> data1) {
            return YGroup2UnzipEven(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="YGroup2UnzipEven(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup2UnzipEven(Vector512<UInt128> data0, Vector512<UInt128> data1) {
            return YGroup2UnzipEven(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup2UnzipOdd(Vector512<Int128> data0, Vector512<Int128> data1) {
            return YGroup2UnzipOdd(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup2UnzipOdd(Vector512<UInt128> data0, Vector512<UInt128> data1) {
            return YGroup2UnzipOdd(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Zip(Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup2Zip(Vector512<Int128> x, Vector512<Int128> y, out Vector512<Int128> data1) {
            var d0 = YGroup2Zip(x.ExAsExInt128(), y.ExAsExInt128(), out var d1);
            data1 = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup2Zip(Vector512<UInt128> x, Vector512<UInt128> y, out Vector512<UInt128> data1) {
            var d0 = YGroup2Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
            data1 = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector512<T> Data0, Vector512<T> Data1) YGroup2Zip<T>(Vector512<T> x, Vector512<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<float>)(object)x, (Vector512<float>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<double>)(object)x, (Vector512<double>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<sbyte>)(object)x, (Vector512<sbyte>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<byte>)(object)x, (Vector512<byte>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<short>)(object)x, (Vector512<short>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<ushort>)(object)x, (Vector512<ushort>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<int>)(object)x, (Vector512<int>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<uint>)(object)x, (Vector512<uint>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<long>)(object)x, (Vector512<long>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<ulong>)(object)x, (Vector512<ulong>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<ExInt128>)(object)x, (Vector512<ExInt128>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<ExUInt128>)(object)x, (Vector512<ExUInt128>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<Int128>)(object)x, (Vector512<Int128>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector512<UInt128>)(object)x, (Vector512<UInt128>)(object)y);
                return ((Vector512<T>)(object)data0, (Vector512<T>)(object)data1);
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
        public static (Vector512<float> Data0, Vector512<float> Data1) YGroup2Zip(Vector512<float> x, Vector512<float> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Data0, Vector512<double> Data1) YGroup2Zip(Vector512<double> x, Vector512<double> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> Data0, Vector512<sbyte> Data1) YGroup2Zip(Vector512<sbyte> x, Vector512<sbyte> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> Data0, Vector512<byte> Data1) YGroup2Zip(Vector512<byte> x, Vector512<byte> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Data0, Vector512<short> Data1) YGroup2Zip(Vector512<short> x, Vector512<short> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Data0, Vector512<ushort> Data1) YGroup2Zip(Vector512<ushort> x, Vector512<ushort> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Data0, Vector512<int> Data1) YGroup2Zip(Vector512<int> x, Vector512<int> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Data0, Vector512<uint> Data1) YGroup2Zip(Vector512<uint> x, Vector512<uint> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Data0, Vector512<long> Data1) YGroup2Zip(Vector512<long> x, Vector512<long> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Data0, Vector512<ulong> Data1) YGroup2Zip(Vector512<ulong> x, Vector512<ulong> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExInt128> Data0, Vector512<ExInt128> Data1) YGroup2Zip(Vector512<ExInt128> x, Vector512<ExInt128> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExUInt128> Data0, Vector512<ExUInt128> Data1) YGroup2Zip(Vector512<ExUInt128> x, Vector512<ExUInt128> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<Int128> Data0, Vector512<Int128> Data1) YGroup2Zip(Vector512<Int128> x, Vector512<Int128> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<UInt128> Data0, Vector512<UInt128> Data1) YGroup2Zip(Vector512<UInt128> x, Vector512<UInt128> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup2ZipHigh(Vector512<Int128> x, Vector512<Int128> y) {
            return YGroup2ZipHigh(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipHigh(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup2ZipHigh(Vector512<UInt128> x, Vector512<UInt128> y) {
            return YGroup2ZipHigh(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ExInt128}, Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup2ZipLow(Vector512<Int128> x, Vector512<Int128> y) {
            return YGroup2ZipLow(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup2ZipLow(Vector512{ExUInt128}, Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup2ZipLow(Vector512<UInt128> x, Vector512<UInt128> y) {
            return YGroup2ZipLow(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


        /// <inheritdoc cref="YGroup3ToGroup4(Vector512{float}, Vector512{float}, Vector512{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> Result0, Vector512<T> Result1, Vector512<T> Result2, Vector512<T> Result3) YGroup3ToGroup4<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector512<float>)(object)data0, (Vector512<float>)(object)data1, (Vector512<float>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector512<double>)(object)data0, (Vector512<double>)(object)data1, (Vector512<double>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector512<sbyte>)(object)data0, (Vector512<sbyte>)(object)data1, (Vector512<sbyte>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector512<byte>)(object)data0, (Vector512<byte>)(object)data1, (Vector512<byte>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector512<short>)(object)data0, (Vector512<short>)(object)data1, (Vector512<short>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector512<ushort>)(object)data0, (Vector512<ushort>)(object)data1, (Vector512<ushort>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector512<int>)(object)data0, (Vector512<int>)(object)data1, (Vector512<int>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector512<uint>)(object)data0, (Vector512<uint>)(object)data1, (Vector512<uint>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector512<long>)(object)data0, (Vector512<long>)(object)data1, (Vector512<long>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector512<ulong>)(object)data0, (Vector512<ulong>)(object)data1, (Vector512<ulong>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
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
        public static (Vector512<float> Result0, Vector512<float> Result1, Vector512<float> Result2, Vector512<float> Result3) YGroup3ToGroup4(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Result0, Vector512<double> Result1, Vector512<double> Result2, Vector512<double> Result3) YGroup3ToGroup4(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> Result0, Vector512<sbyte> Result1, Vector512<sbyte> Result2, Vector512<sbyte> Result3) YGroup3ToGroup4(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> Result0, Vector512<byte> Result1, Vector512<byte> Result2, Vector512<byte> Result3) YGroup3ToGroup4(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Result0, Vector512<short> Result1, Vector512<short> Result2, Vector512<short> Result3) YGroup3ToGroup4(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Result0, Vector512<ushort> Result1, Vector512<ushort> Result2, Vector512<ushort> Result3) YGroup3ToGroup4(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Result0, Vector512<int> Result1, Vector512<int> Result2, Vector512<int> Result3) YGroup3ToGroup4(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Result0, Vector512<uint> Result1, Vector512<uint> Result2, Vector512<uint> Result3) YGroup3ToGroup4(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Result0, Vector512<long> Result1, Vector512<long> Result2, Vector512<long> Result3) YGroup3ToGroup4(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Result0, Vector512<ulong> Result1, Vector512<ulong> Result2, Vector512<ulong> Result3) YGroup3ToGroup4(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> X, Vector512<T> Y, Vector512<T> Z) YGroup3Unzip<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector512<float>)(object)data0, (Vector512<float>)(object)data1, (Vector512<float>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector512<double>)(object)data0, (Vector512<double>)(object)data1, (Vector512<double>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector512<sbyte>)(object)data0, (Vector512<sbyte>)(object)data1, (Vector512<sbyte>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector512<byte>)(object)data0, (Vector512<byte>)(object)data1, (Vector512<byte>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector512<short>)(object)data0, (Vector512<short>)(object)data1, (Vector512<short>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector512<ushort>)(object)data0, (Vector512<ushort>)(object)data1, (Vector512<ushort>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector512<int>)(object)data0, (Vector512<int>)(object)data1, (Vector512<int>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector512<uint>)(object)data0, (Vector512<uint>)(object)data1, (Vector512<uint>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector512<long>)(object)data0, (Vector512<long>)(object)data1, (Vector512<long>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector512<ulong>)(object)data0, (Vector512<ulong>)(object)data1, (Vector512<ulong>)(object)data2);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
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
        public static (Vector512<float> X, Vector512<float> Y, Vector512<float> Z) YGroup3Unzip(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> X, Vector512<double> Y, Vector512<double> Z) YGroup3Unzip(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> X, Vector512<sbyte> Y, Vector512<sbyte> Z) YGroup3Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> X, Vector512<byte> Y, Vector512<byte> Z) YGroup3Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> X, Vector512<short> Y, Vector512<short> Z) YGroup3Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> X, Vector512<ushort> Y, Vector512<ushort> Z) YGroup3Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> X, Vector512<int> Y, Vector512<int> Z) YGroup3Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> X, Vector512<uint> Y, Vector512<uint> Z) YGroup3Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> X, Vector512<long> Y, Vector512<long> Z) YGroup3Unzip(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> X, Vector512<ulong> Y, Vector512<ulong> Z) YGroup3Unzip(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


        /// <inheritdoc cref="YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> X, Vector512<T> XB, Vector512<T> Y, Vector512<T> YB, Vector512<T> Z, Vector512<T> ZB) YGroup3UnzipX2<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3, Vector512<T> data4, Vector512<T> data5) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector512<float>)(object)data0, (Vector512<float>)(object)data1, (Vector512<float>)(object)data2, (Vector512<float>)(object)data3, (Vector512<float>)(object)data4, (Vector512<float>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector512<double>)(object)data0, (Vector512<double>)(object)data1, (Vector512<double>)(object)data2, (Vector512<double>)(object)data3, (Vector512<double>)(object)data4, (Vector512<double>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector512<sbyte>)(object)data0, (Vector512<sbyte>)(object)data1, (Vector512<sbyte>)(object)data2, (Vector512<sbyte>)(object)data3, (Vector512<sbyte>)(object)data4, (Vector512<sbyte>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector512<byte>)(object)data0, (Vector512<byte>)(object)data1, (Vector512<byte>)(object)data2, (Vector512<byte>)(object)data3, (Vector512<byte>)(object)data4, (Vector512<byte>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector512<short>)(object)data0, (Vector512<short>)(object)data1, (Vector512<short>)(object)data2, (Vector512<short>)(object)data3, (Vector512<short>)(object)data4, (Vector512<short>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector512<ushort>)(object)data0, (Vector512<ushort>)(object)data1, (Vector512<ushort>)(object)data2, (Vector512<ushort>)(object)data3, (Vector512<ushort>)(object)data4, (Vector512<ushort>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector512<int>)(object)data0, (Vector512<int>)(object)data1, (Vector512<int>)(object)data2, (Vector512<int>)(object)data3, (Vector512<int>)(object)data4, (Vector512<int>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector512<uint>)(object)data0, (Vector512<uint>)(object)data1, (Vector512<uint>)(object)data2, (Vector512<uint>)(object)data3, (Vector512<uint>)(object)data4, (Vector512<uint>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector512<long>)(object)data0, (Vector512<long>)(object)data1, (Vector512<long>)(object)data2, (Vector512<long>)(object)data3, (Vector512<long>)(object)data4, (Vector512<long>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector512<ulong>)(object)data0, (Vector512<ulong>)(object)data1, (Vector512<ulong>)(object)data2, (Vector512<ulong>)(object)data3, (Vector512<ulong>)(object)data4, (Vector512<ulong>)(object)data5);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
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
        public static (Vector512<float> X, Vector512<float> XB, Vector512<float> Y, Vector512<float> YB, Vector512<float> Z, Vector512<float> ZB) YGroup3UnzipX2(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3, Vector512<float> data4, Vector512<float> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> X, Vector512<double> XB, Vector512<double> Y, Vector512<double> YB, Vector512<double> Z, Vector512<double> ZB) YGroup3UnzipX2(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3, Vector512<double> data4, Vector512<double> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> X, Vector512<sbyte> XB, Vector512<sbyte> Y, Vector512<sbyte> YB, Vector512<sbyte> Z, Vector512<sbyte> ZB) YGroup3UnzipX2(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3, Vector512<sbyte> data4, Vector512<sbyte> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> X, Vector512<byte> XB, Vector512<byte> Y, Vector512<byte> YB, Vector512<byte> Z, Vector512<byte> ZB) YGroup3UnzipX2(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3, Vector512<byte> data4, Vector512<byte> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> X, Vector512<short> XB, Vector512<short> Y, Vector512<short> YB, Vector512<short> Z, Vector512<short> ZB) YGroup3UnzipX2(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3, Vector512<short> data4, Vector512<short> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> X, Vector512<ushort> XB, Vector512<ushort> Y, Vector512<ushort> YB, Vector512<ushort> Z, Vector512<ushort> ZB) YGroup3UnzipX2(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3, Vector512<ushort> data4, Vector512<ushort> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> X, Vector512<int> XB, Vector512<int> Y, Vector512<int> YB, Vector512<int> Z, Vector512<int> ZB) YGroup3UnzipX2(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3, Vector512<int> data4, Vector512<int> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> X, Vector512<uint> XB, Vector512<uint> Y, Vector512<uint> YB, Vector512<uint> Z, Vector512<uint> ZB) YGroup3UnzipX2(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3, Vector512<uint> data4, Vector512<uint> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> X, Vector512<long> XB, Vector512<long> Y, Vector512<long> YB, Vector512<long> Z, Vector512<long> ZB) YGroup3UnzipX2(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3, Vector512<long> data4, Vector512<long> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> X, Vector512<ulong> XB, Vector512<ulong> Y, Vector512<ulong> YB, Vector512<ulong> Z, Vector512<ulong> ZB) YGroup3UnzipX2(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3, Vector512<ulong> data4, Vector512<ulong> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }


        /// <inheritdoc cref="YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> Data0, Vector512<T> Data1, Vector512<T> Data2) YGroup3Zip<T>(Vector512<T> x, Vector512<T> y, Vector512<T> z) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector512<float>)(object)x, (Vector512<float>)(object)y, (Vector512<float>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector512<double>)(object)x, (Vector512<double>)(object)y, (Vector512<double>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector512<sbyte>)(object)x, (Vector512<sbyte>)(object)y, (Vector512<sbyte>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector512<byte>)(object)x, (Vector512<byte>)(object)y, (Vector512<byte>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector512<short>)(object)x, (Vector512<short>)(object)y, (Vector512<short>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector512<ushort>)(object)x, (Vector512<ushort>)(object)y, (Vector512<ushort>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector512<int>)(object)x, (Vector512<int>)(object)y, (Vector512<int>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector512<uint>)(object)x, (Vector512<uint>)(object)y, (Vector512<uint>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector512<long>)(object)x, (Vector512<long>)(object)y, (Vector512<long>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector512<ulong>)(object)x, (Vector512<ulong>)(object)y, (Vector512<ulong>)(object)z);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2);
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
        public static (Vector512<float> Data0, Vector512<float> Data1, Vector512<float> Data2) YGroup3Zip(Vector512<float> x, Vector512<float> y, Vector512<float> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Data0, Vector512<double> Data1, Vector512<double> Data2) YGroup3Zip(Vector512<double> x, Vector512<double> y, Vector512<double> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> Data0, Vector512<sbyte> Data1, Vector512<sbyte> Data2) YGroup3Zip(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> Data0, Vector512<byte> Data1, Vector512<byte> Data2) YGroup3Zip(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Data0, Vector512<short> Data1, Vector512<short> Data2) YGroup3Zip(Vector512<short> x, Vector512<short> y, Vector512<short> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Data0, Vector512<ushort> Data1, Vector512<ushort> Data2) YGroup3Zip(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Data0, Vector512<int> Data1, Vector512<int> Data2) YGroup3Zip(Vector512<int> x, Vector512<int> y, Vector512<int> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Data0, Vector512<uint> Data1, Vector512<uint> Data2) YGroup3Zip(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Data0, Vector512<long> Data1, Vector512<long> Data2) YGroup3Zip(Vector512<long> x, Vector512<long> y, Vector512<long> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Data0, Vector512<ulong> Data1, Vector512<ulong> Data2) YGroup3Zip(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }


        /// <inheritdoc cref="YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> Data0, Vector512<T> Data1, Vector512<T> Data2, Vector512<T> Data3, Vector512<T> Data4, Vector512<T> Data5) YGroup3ZipX2<T>(Vector512<T> x, Vector512<T> xB, Vector512<T> y, Vector512<T> yB, Vector512<T> z, Vector512<T> zB) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector512<float>)(object)x, (Vector512<float>)(object)xB, (Vector512<float>)(object)y, (Vector512<float>)(object)yB, (Vector512<float>)(object)z, (Vector512<float>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector512<double>)(object)x, (Vector512<double>)(object)xB, (Vector512<double>)(object)y, (Vector512<double>)(object)yB, (Vector512<double>)(object)z, (Vector512<double>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector512<sbyte>)(object)x, (Vector512<sbyte>)(object)xB, (Vector512<sbyte>)(object)y, (Vector512<sbyte>)(object)yB, (Vector512<sbyte>)(object)z, (Vector512<sbyte>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector512<byte>)(object)x, (Vector512<byte>)(object)xB, (Vector512<byte>)(object)y, (Vector512<byte>)(object)yB, (Vector512<byte>)(object)z, (Vector512<byte>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector512<short>)(object)x, (Vector512<short>)(object)xB, (Vector512<short>)(object)y, (Vector512<short>)(object)yB, (Vector512<short>)(object)z, (Vector512<short>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector512<ushort>)(object)x, (Vector512<ushort>)(object)xB, (Vector512<ushort>)(object)y, (Vector512<ushort>)(object)yB, (Vector512<ushort>)(object)z, (Vector512<ushort>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector512<int>)(object)x, (Vector512<int>)(object)xB, (Vector512<int>)(object)y, (Vector512<int>)(object)yB, (Vector512<int>)(object)z, (Vector512<int>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector512<uint>)(object)x, (Vector512<uint>)(object)xB, (Vector512<uint>)(object)y, (Vector512<uint>)(object)yB, (Vector512<uint>)(object)z, (Vector512<uint>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector512<long>)(object)x, (Vector512<long>)(object)xB, (Vector512<long>)(object)y, (Vector512<long>)(object)yB, (Vector512<long>)(object)z, (Vector512<long>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector512<ulong>)(object)x, (Vector512<ulong>)(object)xB, (Vector512<ulong>)(object)y, (Vector512<ulong>)(object)yB, (Vector512<ulong>)(object)z, (Vector512<ulong>)(object)zB);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3, (Vector512<T>)(object)rt4, (Vector512<T>)(object)rt5);
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
        public static (Vector512<float> Data0, Vector512<float> Data1, Vector512<float> Data2, Vector512<float> Data3, Vector512<float> Data4, Vector512<float> Data5) YGroup3ZipX2(Vector512<float> x, Vector512<float> xB, Vector512<float> y, Vector512<float> yB, Vector512<float> z, Vector512<float> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Data0, Vector512<double> Data1, Vector512<double> Data2, Vector512<double> Data3, Vector512<double> Data4, Vector512<double> Data5) YGroup3ZipX2(Vector512<double> x, Vector512<double> xB, Vector512<double> y, Vector512<double> yB, Vector512<double> z, Vector512<double> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> Data0, Vector512<sbyte> Data1, Vector512<sbyte> Data2, Vector512<sbyte> Data3, Vector512<sbyte> Data4, Vector512<sbyte> Data5) YGroup3ZipX2(Vector512<sbyte> x, Vector512<sbyte> xB, Vector512<sbyte> y, Vector512<sbyte> yB, Vector512<sbyte> z, Vector512<sbyte> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> Data0, Vector512<byte> Data1, Vector512<byte> Data2, Vector512<byte> Data3, Vector512<byte> Data4, Vector512<byte> Data5) YGroup3ZipX2(Vector512<byte> x, Vector512<byte> xB, Vector512<byte> y, Vector512<byte> yB, Vector512<byte> z, Vector512<byte> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Data0, Vector512<short> Data1, Vector512<short> Data2, Vector512<short> Data3, Vector512<short> Data4, Vector512<short> Data5) YGroup3ZipX2(Vector512<short> x, Vector512<short> xB, Vector512<short> y, Vector512<short> yB, Vector512<short> z, Vector512<short> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Data0, Vector512<ushort> Data1, Vector512<ushort> Data2, Vector512<ushort> Data3, Vector512<ushort> Data4, Vector512<ushort> Data5) YGroup3ZipX2(Vector512<ushort> x, Vector512<ushort> xB, Vector512<ushort> y, Vector512<ushort> yB, Vector512<ushort> z, Vector512<ushort> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Data0, Vector512<int> Data1, Vector512<int> Data2, Vector512<int> Data3, Vector512<int> Data4, Vector512<int> Data5) YGroup3ZipX2(Vector512<int> x, Vector512<int> xB, Vector512<int> y, Vector512<int> yB, Vector512<int> z, Vector512<int> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Data0, Vector512<uint> Data1, Vector512<uint> Data2, Vector512<uint> Data3, Vector512<uint> Data4, Vector512<uint> Data5) YGroup3ZipX2(Vector512<uint> x, Vector512<uint> xB, Vector512<uint> y, Vector512<uint> yB, Vector512<uint> z, Vector512<uint> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Data0, Vector512<long> Data1, Vector512<long> Data2, Vector512<long> Data3, Vector512<long> Data4, Vector512<long> Data5) YGroup3ZipX2(Vector512<long> x, Vector512<long> xB, Vector512<long> y, Vector512<long> yB, Vector512<long> z, Vector512<long> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Data0, Vector512<ulong> Data1, Vector512<ulong> Data2, Vector512<ulong> Data3, Vector512<ulong> Data4, Vector512<ulong> Data5) YGroup3ZipX2(Vector512<ulong> x, Vector512<ulong> xB, Vector512<ulong> y, Vector512<ulong> yB, Vector512<ulong> z, Vector512<ulong> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }


        /// <inheritdoc cref="YGroup4ToGroup3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> Result0, Vector512<T> Result1, Vector512<T> Result2) YGroup4ToGroup3<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup4ToGroup3(data0.As<T, float>(), data1.As<T, float>(), data2.As<T, float>(), data3.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup4ToGroup3(data0.As<T, double>(), data1.As<T, double>(), data2.As<T, double>(), data3.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup4ToGroup3(data0.As<T, sbyte>(), data1.As<T, sbyte>(), data2.As<T, sbyte>(), data3.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup4ToGroup3(data0.As<T, byte>(), data1.As<T, byte>(), data2.As<T, byte>(), data3.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup4ToGroup3(data0.As<T, short>(), data1.As<T, short>(), data2.As<T, short>(), data3.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup4ToGroup3(data0.As<T, ushort>(), data1.As<T, ushort>(), data2.As<T, ushort>(), data3.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup4ToGroup3(data0.As<T, int>(), data1.As<T, int>(), data2.As<T, int>(), data3.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup4ToGroup3(data0.As<T, uint>(), data1.As<T, uint>(), data2.As<T, uint>(), data3.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup4ToGroup3(data0.As<T, long>(), data1.As<T, long>(), data2.As<T, long>(), data3.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup4ToGroup3(data0.As<T, ulong>(), data1.As<T, ulong>(), data2.As<T, ulong>(), data3.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Convert a 4-element group, to a 3-element group. It also converts packed RGBA pixel data to packed RGB pixel data (将4-元素组, 转为3-元素组. 它还能将 已打包的RGBA像素数据, 转换为 已打包的RGB像素数据).
        /// Mnemonic: View for group: <c>(result0, result1, result2) = YGroup3Zip(YGroup4Unzip(data0, data1, data2, data3)))</c>. View for element: <c>element_ref(i, result0, result1, result2) := element_ref((i/3)*4+(i%3), data0, data1, data2, data3)</c>.
        /// </summary>
        /// <param name="data0">A vector made of 4-element groups - Part 0 (由4元素组所组成的向量 - 第0部分).</param>
        /// <param name="data1">A vector made of 4-element groups - Part 1 (由4元素组所组成的向量 - 第1部分).</param>
        /// <param name="data2">A vector made of 4-element groups - Part 2 (由4元素组所组成的向量 - 第2部分).</param>
        /// <param name="data3">A vector made of 4-element groups - Part 3 (由4元素组所组成的向量 - 第3部分).</param>
        /// <returns>Returns the converted data. (返回转换后数据).</returns>
        /// <inheritdoc cref="IWVectorTraits512.YGroup4ToGroup3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, out Vector512{float}, out Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<float> Result0, Vector512<float> Result1, Vector512<float> Result2) YGroup4ToGroup3(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Result0, Vector512<double> Result1, Vector512<double> Result2) YGroup4ToGroup3(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> Result0, Vector512<sbyte> Result1, Vector512<sbyte> Result2) YGroup4ToGroup3(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> Result0, Vector512<byte> Result1, Vector512<byte> Result2) YGroup4ToGroup3(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Result0, Vector512<short> Result1, Vector512<short> Result2) YGroup4ToGroup3(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Result0, Vector512<ushort> Result1, Vector512<ushort> Result2) YGroup4ToGroup3(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Result0, Vector512<int> Result1, Vector512<int> Result2) YGroup4ToGroup3(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Result0, Vector512<uint> Result1, Vector512<uint> Result2) YGroup4ToGroup3(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Result0, Vector512<long> Result1, Vector512<long> Result2) YGroup4ToGroup3(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Result0, Vector512<ulong> Result1, Vector512<ulong> Result2) YGroup4ToGroup3(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


#if BCL_TYPE_INT128

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup4Unzip(Vector512<Int128> data0, Vector512<Int128> data1, Vector512<Int128> data2, Vector512<Int128> data3, out Vector512<Int128> y, out Vector512<Int128> z, out Vector512<Int128> w) {
            var d0 = YGroup4Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), data2.ExAsExInt128(), data3.ExAsExInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsInt128();
            z = d2.ExAsInt128();
            w = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Unzip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup4Unzip(Vector512<UInt128> data0, Vector512<UInt128> data1, Vector512<UInt128> data2, Vector512<UInt128> data3, out Vector512<UInt128> y, out Vector512<UInt128> z, out Vector512<UInt128> w) {
            var d0 = YGroup4Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsUInt128();
            z = d2.ExAsUInt128();
            w = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> X, Vector512<T> Y, Vector512<T> Z, Vector512<T> W) YGroup4Unzip<T>(Vector512<T> data0, Vector512<T> data1, Vector512<T> data2, Vector512<T> data3) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<float>)(object)data0, (Vector512<float>)(object)data1, (Vector512<float>)(object)data2, (Vector512<float>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<double>)(object)data0, (Vector512<double>)(object)data1, (Vector512<double>)(object)data2, (Vector512<double>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<sbyte>)(object)data0, (Vector512<sbyte>)(object)data1, (Vector512<sbyte>)(object)data2, (Vector512<sbyte>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<byte>)(object)data0, (Vector512<byte>)(object)data1, (Vector512<byte>)(object)data2, (Vector512<byte>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<short>)(object)data0, (Vector512<short>)(object)data1, (Vector512<short>)(object)data2, (Vector512<short>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<ushort>)(object)data0, (Vector512<ushort>)(object)data1, (Vector512<ushort>)(object)data2, (Vector512<ushort>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<int>)(object)data0, (Vector512<int>)(object)data1, (Vector512<int>)(object)data2, (Vector512<int>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<uint>)(object)data0, (Vector512<uint>)(object)data1, (Vector512<uint>)(object)data2, (Vector512<uint>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<long>)(object)data0, (Vector512<long>)(object)data1, (Vector512<long>)(object)data2, (Vector512<long>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<ulong>)(object)data0, (Vector512<ulong>)(object)data1, (Vector512<ulong>)(object)data2, (Vector512<ulong>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<ExInt128>)(object)data0, (Vector512<ExInt128>)(object)data1, (Vector512<ExInt128>)(object)data2, (Vector512<ExInt128>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<ExUInt128>)(object)data0, (Vector512<ExUInt128>)(object)data1, (Vector512<ExUInt128>)(object)data2, (Vector512<ExUInt128>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<Int128>)(object)data0, (Vector512<Int128>)(object)data1, (Vector512<Int128>)(object)data2, (Vector512<Int128>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector512<UInt128>)(object)data0, (Vector512<UInt128>)(object)data1, (Vector512<UInt128>)(object)data2, (Vector512<UInt128>)(object)data3);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
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
        public static (Vector512<float> X, Vector512<float> Y, Vector512<float> Z, Vector512<float> W) YGroup4Unzip(Vector512<float> data0, Vector512<float> data1, Vector512<float> data2, Vector512<float> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> X, Vector512<double> Y, Vector512<double> Z, Vector512<double> W) YGroup4Unzip(Vector512<double> data0, Vector512<double> data1, Vector512<double> data2, Vector512<double> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> X, Vector512<sbyte> Y, Vector512<sbyte> Z, Vector512<sbyte> W) YGroup4Unzip(Vector512<sbyte> data0, Vector512<sbyte> data1, Vector512<sbyte> data2, Vector512<sbyte> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> X, Vector512<byte> Y, Vector512<byte> Z, Vector512<byte> W) YGroup4Unzip(Vector512<byte> data0, Vector512<byte> data1, Vector512<byte> data2, Vector512<byte> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> X, Vector512<short> Y, Vector512<short> Z, Vector512<short> W) YGroup4Unzip(Vector512<short> data0, Vector512<short> data1, Vector512<short> data2, Vector512<short> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector512<ushort> X, Vector512<ushort> Y, Vector512<ushort> Z, Vector512<ushort> W) YGroup4Unzip(Vector512<ushort> data0, Vector512<ushort> data1, Vector512<ushort> data2, Vector512<ushort> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> X, Vector512<int> Y, Vector512<int> Z, Vector512<int> W) YGroup4Unzip(Vector512<int> data0, Vector512<int> data1, Vector512<int> data2, Vector512<int> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector512<uint> X, Vector512<uint> Y, Vector512<uint> Z, Vector512<uint> W) YGroup4Unzip(Vector512<uint> data0, Vector512<uint> data1, Vector512<uint> data2, Vector512<uint> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> X, Vector512<long> Y, Vector512<long> Z, Vector512<long> W) YGroup4Unzip(Vector512<long> data0, Vector512<long> data1, Vector512<long> data2, Vector512<long> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector512<ulong> X, Vector512<ulong> Y, Vector512<ulong> Z, Vector512<ulong> W) YGroup4Unzip(Vector512<ulong> data0, Vector512<ulong> data1, Vector512<ulong> data2, Vector512<ulong> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExInt128> X, Vector512<ExInt128> Y, Vector512<ExInt128> Z, Vector512<ExInt128> W) YGroup4Unzip(Vector512<ExInt128> data0, Vector512<ExInt128> data1, Vector512<ExInt128> data2, Vector512<ExInt128> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExUInt128> X, Vector512<ExUInt128> Y, Vector512<ExUInt128> Z, Vector512<ExUInt128> W) YGroup4Unzip(Vector512<ExUInt128> data0, Vector512<ExUInt128> data1, Vector512<ExUInt128> data2, Vector512<ExUInt128> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<Int128> X, Vector512<Int128> Y, Vector512<Int128> Z, Vector512<Int128> W) YGroup4Unzip(Vector512<Int128> data0, Vector512<Int128> data1, Vector512<Int128> data2, Vector512<Int128> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<UInt128> X, Vector512<UInt128> Y, Vector512<UInt128> Z, Vector512<UInt128> W) YGroup4Unzip(Vector512<UInt128> data0, Vector512<UInt128> data1, Vector512<UInt128> data2, Vector512<UInt128> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#endif // BCL_TYPE_INT128


#if BCL_TYPE_INT128

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128}, out Vector512{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<Int128> YGroup4Zip(Vector512<Int128> x, Vector512<Int128> y, Vector512<Int128> z, Vector512<Int128> w, out Vector512<Int128> data1, out Vector512<Int128> data2, out Vector512<Int128> data3) {
            var d0 = YGroup4Zip(x.ExAsExInt128(), y.ExAsExInt128(), z.ExAsExInt128(), w.ExAsExInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsInt128();
            data2 = d2.ExAsInt128();
            data3 = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits512.YGroup4Zip(Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128}, out Vector512{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<UInt128> YGroup4Zip(Vector512<UInt128> x, Vector512<UInt128> y, Vector512<UInt128> z, Vector512<UInt128> w, out Vector512<UInt128> data1, out Vector512<UInt128> data2, out Vector512<UInt128> data3) {
            var d0 = YGroup4Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsUInt128();
            data2 = d2.ExAsUInt128();
            data3 = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<T> Data0, Vector512<T> Data1, Vector512<T> Data2, Vector512<T> Data3) YGroup4Zip<T>(Vector512<T> x, Vector512<T> y, Vector512<T> z, Vector512<T> w) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<float>)(object)x, (Vector512<float>)(object)y, (Vector512<float>)(object)z, (Vector512<float>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<double>)(object)x, (Vector512<double>)(object)y, (Vector512<double>)(object)z, (Vector512<double>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<sbyte>)(object)x, (Vector512<sbyte>)(object)y, (Vector512<sbyte>)(object)z, (Vector512<sbyte>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<byte>)(object)x, (Vector512<byte>)(object)y, (Vector512<byte>)(object)z, (Vector512<byte>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<short>)(object)x, (Vector512<short>)(object)y, (Vector512<short>)(object)z, (Vector512<short>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<ushort>)(object)x, (Vector512<ushort>)(object)y, (Vector512<ushort>)(object)z, (Vector512<ushort>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<int>)(object)x, (Vector512<int>)(object)y, (Vector512<int>)(object)z, (Vector512<int>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<uint>)(object)x, (Vector512<uint>)(object)y, (Vector512<uint>)(object)z, (Vector512<uint>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<long>)(object)x, (Vector512<long>)(object)y, (Vector512<long>)(object)z, (Vector512<long>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<ulong>)(object)x, (Vector512<ulong>)(object)y, (Vector512<ulong>)(object)z, (Vector512<ulong>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<ExInt128>)(object)x, (Vector512<ExInt128>)(object)y, (Vector512<ExInt128>)(object)z, (Vector512<ExInt128>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<ExUInt128>)(object)x, (Vector512<ExUInt128>)(object)y, (Vector512<ExUInt128>)(object)z, (Vector512<ExUInt128>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<Int128>)(object)x, (Vector512<Int128>)(object)y, (Vector512<Int128>)(object)z, (Vector512<Int128>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector512<UInt128>)(object)x, (Vector512<UInt128>)(object)y, (Vector512<UInt128>)(object)z, (Vector512<UInt128>)(object)w);
                return ((Vector512<T>)(object)rt0, (Vector512<T>)(object)rt1, (Vector512<T>)(object)rt2, (Vector512<T>)(object)rt3);
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
        public static (Vector512<float> Data0, Vector512<float> Data1, Vector512<float> Data2, Vector512<float> Data3) YGroup4Zip(Vector512<float> x, Vector512<float> y, Vector512<float> z, Vector512<float> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<double> Data0, Vector512<double> Data1, Vector512<double> Data2, Vector512<double> Data3) YGroup4Zip(Vector512<double> x, Vector512<double> y, Vector512<double> z, Vector512<double> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<sbyte> Data0, Vector512<sbyte> Data1, Vector512<sbyte> Data2, Vector512<sbyte> Data3) YGroup4Zip(Vector512<sbyte> x, Vector512<sbyte> y, Vector512<sbyte> z, Vector512<sbyte> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<byte> Data0, Vector512<byte> Data1, Vector512<byte> Data2, Vector512<byte> Data3) YGroup4Zip(Vector512<byte> x, Vector512<byte> y, Vector512<byte> z, Vector512<byte> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<short> Data0, Vector512<short> Data1, Vector512<short> Data2, Vector512<short> Data3) YGroup4Zip(Vector512<short> x, Vector512<short> y, Vector512<short> z, Vector512<short> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ushort> Data0, Vector512<ushort> Data1, Vector512<ushort> Data2, Vector512<ushort> Data3) YGroup4Zip(Vector512<ushort> x, Vector512<ushort> y, Vector512<ushort> z, Vector512<ushort> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<int> Data0, Vector512<int> Data1, Vector512<int> Data2, Vector512<int> Data3) YGroup4Zip(Vector512<int> x, Vector512<int> y, Vector512<int> z, Vector512<int> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<uint> Data0, Vector512<uint> Data1, Vector512<uint> Data2, Vector512<uint> Data3) YGroup4Zip(Vector512<uint> x, Vector512<uint> y, Vector512<uint> z, Vector512<uint> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<long> Data0, Vector512<long> Data1, Vector512<long> Data2, Vector512<long> Data3) YGroup4Zip(Vector512<long> x, Vector512<long> y, Vector512<long> z, Vector512<long> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ulong> Data0, Vector512<ulong> Data1, Vector512<ulong> Data2, Vector512<ulong> Data3) YGroup4Zip(Vector512<ulong> x, Vector512<ulong> y, Vector512<ulong> z, Vector512<ulong> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExInt128> Data0, Vector512<ExInt128> Data1, Vector512<ExInt128> Data2, Vector512<ExInt128> Data3) YGroup4Zip(Vector512<ExInt128> x, Vector512<ExInt128> y, Vector512<ExInt128> z, Vector512<ExInt128> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<ExUInt128> Data0, Vector512<ExUInt128> Data1, Vector512<ExUInt128> Data2, Vector512<ExUInt128> Data3) YGroup4Zip(Vector512<ExUInt128> x, Vector512<ExUInt128> y, Vector512<ExUInt128> z, Vector512<ExUInt128> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<Int128> Data0, Vector512<Int128> Data1, Vector512<Int128> Data2, Vector512<Int128> Data3) YGroup4Zip(Vector512<Int128> x, Vector512<Int128> y, Vector512<Int128> z, Vector512<Int128> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector512<UInt128> Data0, Vector512<UInt128> Data1, Vector512<UInt128> Data2, Vector512<UInt128> Data3) YGroup4Zip(Vector512<UInt128> x, Vector512<UInt128> y, Vector512<UInt128> z, Vector512<UInt128> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#endif // BCL_TYPE_INT128

#endif // NET8_0_OR_GREATER
    }
}
