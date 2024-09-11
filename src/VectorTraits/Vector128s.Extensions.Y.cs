#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER
#if NET8_0_OR_GREATER
#define SHORT_CIRCUIT_WASM
#endif // NET8_0_OR_GREATER

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
#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Wasm;
#endif // NET8_0_OR_GREATER
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector128;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits {
    using WasmStatics = WVectorTraits128PackedSimd.Statics;

    static partial class Vector128s {

#if NETCOREAPP3_0_OR_GREATER

#if BCL_TYPE_INT128

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ExInt128}, Vector128{ExInt128}, out Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup2Unzip(Vector128<Int128> data0, Vector128<Int128> data1, out Vector128<Int128> y) {
            var d0 = YGroup2Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), out var d1);
            y = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ExUInt128}, Vector128{ExUInt128}, out Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup2Unzip(Vector128<UInt128> data0, Vector128<UInt128> data1, out Vector128<UInt128> y) {
            var d0 = YGroup2Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), out var d1);
            y = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector128<T> X, Vector128<T> Y) YGroup2Unzip<T>(Vector128<T> data0, Vector128<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<float>)(object)data0, (Vector128<float>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<double>)(object)data0, (Vector128<double>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<sbyte>)(object)data0, (Vector128<sbyte>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<byte>)(object)data0, (Vector128<byte>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<short>)(object)data0, (Vector128<short>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<ushort>)(object)data0, (Vector128<ushort>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<int>)(object)data0, (Vector128<int>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<uint>)(object)data0, (Vector128<uint>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<long>)(object)data0, (Vector128<long>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<ulong>)(object)data0, (Vector128<ulong>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<ExInt128>)(object)data0, (Vector128<ExInt128>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<ExUInt128>)(object)data0, (Vector128<ExUInt128>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<Int128>)(object)data0, (Vector128<Int128>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip((Vector128<UInt128>)(object)data0, (Vector128<UInt128>)(object)data1);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1);
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
        public static (Vector128<float> X, Vector128<float> Y) YGroup2Unzip(Vector128<float> data0, Vector128<float> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> X, Vector128<double> Y) YGroup2Unzip(Vector128<double> data0, Vector128<double> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> X, Vector128<sbyte> Y) YGroup2Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> X, Vector128<byte> Y) YGroup2Unzip(Vector128<byte> data0, Vector128<byte> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> X, Vector128<short> Y) YGroup2Unzip(Vector128<short> data0, Vector128<short> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> X, Vector128<ushort> Y) YGroup2Unzip(Vector128<ushort> data0, Vector128<ushort> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> X, Vector128<int> Y) YGroup2Unzip(Vector128<int> data0, Vector128<int> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> X, Vector128<uint> Y) YGroup2Unzip(Vector128<uint> data0, Vector128<uint> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> X, Vector128<long> Y) YGroup2Unzip(Vector128<long> data0, Vector128<long> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> X, Vector128<ulong> Y) YGroup2Unzip(Vector128<ulong> data0, Vector128<ulong> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExInt128> X, Vector128<ExInt128> Y) YGroup2Unzip(Vector128<ExInt128> data0, Vector128<ExInt128> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExUInt128> X, Vector128<ExUInt128> Y) YGroup2Unzip(Vector128<ExUInt128> data0, Vector128<ExUInt128> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<Int128> X, Vector128<Int128> Y) YGroup2Unzip(Vector128<Int128> data0, Vector128<Int128> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Unzip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<UInt128> X, Vector128<UInt128> Y) YGroup2Unzip(Vector128<UInt128> data0, Vector128<UInt128> data1) {
            var rt0 = YGroup2Unzip(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup2UnzipEven(Vector128<Int128> data0, Vector128<Int128> data1) {
            return YGroup2UnzipEven(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="YGroup2UnzipEven(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup2UnzipEven(Vector128<UInt128> data0, Vector128<UInt128> data1) {
            return YGroup2UnzipEven(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup2UnzipOdd(Vector128<Int128> data0, Vector128<Int128> data1) {
            return YGroup2UnzipOdd(data0.ExAsExInt128(), data1.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="YGroup2UnzipOdd(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup2UnzipOdd(Vector128<UInt128> data0, Vector128<UInt128> data1) {
            return YGroup2UnzipOdd(data0.ExAsExUInt128(), data1.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Zip(Vector128{ExInt128}, Vector128{ExInt128}, out Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup2Zip(Vector128<Int128> x, Vector128<Int128> y, out Vector128<Int128> data1) {
            var d0 = YGroup2Zip(x.ExAsExInt128(), y.ExAsExInt128(), out var d1);
            data1 = d1.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{ExUInt128}, Vector128{ExUInt128}, out Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup2Zip(Vector128<UInt128> x, Vector128<UInt128> y, out Vector128<UInt128> data1) {
            var d0 = YGroup2Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), out var d1);
            data1 = d1.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector128<T> Data0, Vector128<T> Data1) YGroup2Zip<T>(Vector128<T> x, Vector128<T> y) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<float>)(object)x, (Vector128<float>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
            } else if (typeof(double) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<double>)(object)x, (Vector128<double>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<sbyte>)(object)x, (Vector128<sbyte>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
            } else if (typeof(byte) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<byte>)(object)x, (Vector128<byte>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
            } else if (typeof(short) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<short>)(object)x, (Vector128<short>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
            } else if (typeof(ushort) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<ushort>)(object)x, (Vector128<ushort>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
            } else if (typeof(int) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<int>)(object)x, (Vector128<int>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
            } else if (typeof(uint) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<uint>)(object)x, (Vector128<uint>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
            } else if (typeof(long) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<long>)(object)x, (Vector128<long>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
            } else if (typeof(ulong) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<ulong>)(object)x, (Vector128<ulong>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<ExInt128>)(object)x, (Vector128<ExInt128>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<ExUInt128>)(object)x, (Vector128<ExUInt128>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<Int128>)(object)x, (Vector128<Int128>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
            } else if (typeof(UInt128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip((Vector128<UInt128>)(object)x, (Vector128<UInt128>)(object)y);
                return ((Vector128<T>)(object)data0, (Vector128<T>)(object)data1);
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
        public static (Vector128<float> Data0, Vector128<float> Data1) YGroup2Zip(Vector128<float> x, Vector128<float> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Data0, Vector128<double> Data1) YGroup2Zip(Vector128<double> x, Vector128<double> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Data0, Vector128<sbyte> Data1) YGroup2Zip(Vector128<sbyte> x, Vector128<sbyte> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Data0, Vector128<byte> Data1) YGroup2Zip(Vector128<byte> x, Vector128<byte> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Data0, Vector128<short> Data1) YGroup2Zip(Vector128<short> x, Vector128<short> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Data0, Vector128<ushort> Data1) YGroup2Zip(Vector128<ushort> x, Vector128<ushort> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Data0, Vector128<int> Data1) YGroup2Zip(Vector128<int> x, Vector128<int> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Data0, Vector128<uint> Data1) YGroup2Zip(Vector128<uint> x, Vector128<uint> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Data0, Vector128<long> Data1) YGroup2Zip(Vector128<long> x, Vector128<long> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Data0, Vector128<ulong> Data1) YGroup2Zip(Vector128<ulong> x, Vector128<ulong> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExInt128> Data0, Vector128<ExInt128> Data1) YGroup2Zip(Vector128<ExInt128> x, Vector128<ExInt128> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExUInt128> Data0, Vector128<ExUInt128> Data1) YGroup2Zip(Vector128<ExUInt128> x, Vector128<ExUInt128> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<Int128> Data0, Vector128<Int128> Data1) YGroup2Zip(Vector128<Int128> x, Vector128<Int128> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="YGroup2Zip(Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<UInt128> Data0, Vector128<UInt128> Data1) YGroup2Zip(Vector128<UInt128> x, Vector128<UInt128> y) {
            var data0 = YGroup2Zip(x, y, out var data1);
            return (data0, data1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup2ZipHigh(Vector128<Int128> x, Vector128<Int128> y) {
            return YGroup2ZipHigh(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup2ZipHigh(Vector128<UInt128> x, Vector128<UInt128> y) {
            return YGroup2ZipHigh(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ExInt128}, Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup2ZipLow(Vector128<Int128> x, Vector128<Int128> y) {
            return YGroup2ZipLow(x.ExAsExInt128(), y.ExAsExInt128()).ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ExUInt128}, Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup2ZipLow(Vector128<UInt128> x, Vector128<UInt128> y) {
            return YGroup2ZipLow(x.ExAsExUInt128(), y.ExAsExUInt128()).ExAsUInt128();
        }

#endif // BCL_TYPE_INT128


        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Result0, Vector128<T> Result1, Vector128<T> Result2, Vector128<T> Result3) YGroup3ToGroup4<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector128<float>)(object)data0, (Vector128<float>)(object)data1, (Vector128<float>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector128<double>)(object)data0, (Vector128<double>)(object)data1, (Vector128<double>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector128<sbyte>)(object)data0, (Vector128<sbyte>)(object)data1, (Vector128<sbyte>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector128<byte>)(object)data0, (Vector128<byte>)(object)data1, (Vector128<byte>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector128<short>)(object)data0, (Vector128<short>)(object)data1, (Vector128<short>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector128<ushort>)(object)data0, (Vector128<ushort>)(object)data1, (Vector128<ushort>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector128<int>)(object)data0, (Vector128<int>)(object)data1, (Vector128<int>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector128<uint>)(object)data0, (Vector128<uint>)(object)data1, (Vector128<uint>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector128<long>)(object)data0, (Vector128<long>)(object)data1, (Vector128<long>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4((Vector128<ulong>)(object)data0, (Vector128<ulong>)(object)data1, (Vector128<ulong>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
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
        public static (Vector128<float> Result0, Vector128<float> Result1, Vector128<float> Result2, Vector128<float> Result3) YGroup3ToGroup4(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Result0, Vector128<double> Result1, Vector128<double> Result2, Vector128<double> Result3) YGroup3ToGroup4(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1, Vector128<sbyte> Result2, Vector128<sbyte> Result3) YGroup3ToGroup4(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1, Vector128<byte> Result2, Vector128<byte> Result3) YGroup3ToGroup4(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Result0, Vector128<short> Result1, Vector128<short> Result2, Vector128<short> Result3) YGroup3ToGroup4(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1, Vector128<ushort> Result2, Vector128<ushort> Result3) YGroup3ToGroup4(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Result0, Vector128<int> Result1, Vector128<int> Result2, Vector128<int> Result3) YGroup3ToGroup4(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1, Vector128<uint> Result2, Vector128<uint> Result3) YGroup3ToGroup4(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Result0, Vector128<long> Result1, Vector128<long> Result2, Vector128<long> Result3) YGroup3ToGroup4(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1, Vector128<ulong> Result2, Vector128<ulong> Result3) YGroup3ToGroup4(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2) {
            var rt0 = YGroup3ToGroup4(data0, data1, data2, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }


        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> X, Vector128<T> Y, Vector128<T> Z) YGroup3Unzip<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector128<float>)(object)data0, (Vector128<float>)(object)data1, (Vector128<float>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector128<double>)(object)data0, (Vector128<double>)(object)data1, (Vector128<double>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector128<sbyte>)(object)data0, (Vector128<sbyte>)(object)data1, (Vector128<sbyte>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector128<byte>)(object)data0, (Vector128<byte>)(object)data1, (Vector128<byte>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector128<short>)(object)data0, (Vector128<short>)(object)data1, (Vector128<short>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector128<ushort>)(object)data0, (Vector128<ushort>)(object)data1, (Vector128<ushort>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector128<int>)(object)data0, (Vector128<int>)(object)data1, (Vector128<int>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector128<uint>)(object)data0, (Vector128<uint>)(object)data1, (Vector128<uint>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector128<long>)(object)data0, (Vector128<long>)(object)data1, (Vector128<long>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip((Vector128<ulong>)(object)data0, (Vector128<ulong>)(object)data1, (Vector128<ulong>)(object)data2);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
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
        public static (Vector128<float> X, Vector128<float> Y, Vector128<float> Z) YGroup3Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> X, Vector128<double> Y, Vector128<double> Z) YGroup3Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> X, Vector128<sbyte> Y, Vector128<sbyte> Z) YGroup3Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> X, Vector128<byte> Y, Vector128<byte> Z) YGroup3Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> X, Vector128<short> Y, Vector128<short> Z) YGroup3Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> X, Vector128<ushort> Y, Vector128<ushort> Z) YGroup3Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> X, Vector128<int> Y, Vector128<int> Z) YGroup3Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> X, Vector128<uint> Y, Vector128<uint> Z) YGroup3Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> X, Vector128<long> Y, Vector128<long> Z) YGroup3Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> X, Vector128<ulong> Y, Vector128<ulong> Z) YGroup3Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2) {
            var rt0 = YGroup3Unzip(data0, data1, data2, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> X, Vector128<T> XB, Vector128<T> Y, Vector128<T> YB, Vector128<T> Z, Vector128<T> ZB) YGroup3UnzipX2<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, Vector128<T> data3, Vector128<T> data4, Vector128<T> data5) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector128<float>)(object)data0, (Vector128<float>)(object)data1, (Vector128<float>)(object)data2, (Vector128<float>)(object)data3, (Vector128<float>)(object)data4, (Vector128<float>)(object)data5);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector128<double>)(object)data0, (Vector128<double>)(object)data1, (Vector128<double>)(object)data2, (Vector128<double>)(object)data3, (Vector128<double>)(object)data4, (Vector128<double>)(object)data5);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector128<sbyte>)(object)data0, (Vector128<sbyte>)(object)data1, (Vector128<sbyte>)(object)data2, (Vector128<sbyte>)(object)data3, (Vector128<sbyte>)(object)data4, (Vector128<sbyte>)(object)data5);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector128<byte>)(object)data0, (Vector128<byte>)(object)data1, (Vector128<byte>)(object)data2, (Vector128<byte>)(object)data3, (Vector128<byte>)(object)data4, (Vector128<byte>)(object)data5);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector128<short>)(object)data0, (Vector128<short>)(object)data1, (Vector128<short>)(object)data2, (Vector128<short>)(object)data3, (Vector128<short>)(object)data4, (Vector128<short>)(object)data5);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector128<ushort>)(object)data0, (Vector128<ushort>)(object)data1, (Vector128<ushort>)(object)data2, (Vector128<ushort>)(object)data3, (Vector128<ushort>)(object)data4, (Vector128<ushort>)(object)data5);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector128<int>)(object)data0, (Vector128<int>)(object)data1, (Vector128<int>)(object)data2, (Vector128<int>)(object)data3, (Vector128<int>)(object)data4, (Vector128<int>)(object)data5);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector128<uint>)(object)data0, (Vector128<uint>)(object)data1, (Vector128<uint>)(object)data2, (Vector128<uint>)(object)data3, (Vector128<uint>)(object)data4, (Vector128<uint>)(object)data5);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector128<long>)(object)data0, (Vector128<long>)(object)data1, (Vector128<long>)(object)data2, (Vector128<long>)(object)data3, (Vector128<long>)(object)data4, (Vector128<long>)(object)data5);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2((Vector128<ulong>)(object)data0, (Vector128<ulong>)(object)data1, (Vector128<ulong>)(object)data2, (Vector128<ulong>)(object)data3, (Vector128<ulong>)(object)data4, (Vector128<ulong>)(object)data5);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
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
        public static (Vector128<float> X, Vector128<float> XB, Vector128<float> Y, Vector128<float> YB, Vector128<float> Z, Vector128<float> ZB) YGroup3UnzipX2(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, Vector128<float> data4, Vector128<float> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> X, Vector128<double> XB, Vector128<double> Y, Vector128<double> YB, Vector128<double> Z, Vector128<double> ZB) YGroup3UnzipX2(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, Vector128<double> data4, Vector128<double> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> X, Vector128<sbyte> XB, Vector128<sbyte> Y, Vector128<sbyte> YB, Vector128<sbyte> Z, Vector128<sbyte> ZB) YGroup3UnzipX2(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, Vector128<sbyte> data4, Vector128<sbyte> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> X, Vector128<byte> XB, Vector128<byte> Y, Vector128<byte> YB, Vector128<byte> Z, Vector128<byte> ZB) YGroup3UnzipX2(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, Vector128<byte> data4, Vector128<byte> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> X, Vector128<short> XB, Vector128<short> Y, Vector128<short> YB, Vector128<short> Z, Vector128<short> ZB) YGroup3UnzipX2(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, Vector128<short> data4, Vector128<short> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> X, Vector128<ushort> XB, Vector128<ushort> Y, Vector128<ushort> YB, Vector128<ushort> Z, Vector128<ushort> ZB) YGroup3UnzipX2(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, Vector128<ushort> data4, Vector128<ushort> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> X, Vector128<int> XB, Vector128<int> Y, Vector128<int> YB, Vector128<int> Z, Vector128<int> ZB) YGroup3UnzipX2(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, Vector128<int> data4, Vector128<int> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> X, Vector128<uint> XB, Vector128<uint> Y, Vector128<uint> YB, Vector128<uint> Z, Vector128<uint> ZB) YGroup3UnzipX2(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, Vector128<uint> data4, Vector128<uint> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> X, Vector128<long> XB, Vector128<long> Y, Vector128<long> YB, Vector128<long> Z, Vector128<long> ZB) YGroup3UnzipX2(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, Vector128<long> data4, Vector128<long> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }

        /// <inheritdoc cref="YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> X, Vector128<ulong> XB, Vector128<ulong> Y, Vector128<ulong> YB, Vector128<ulong> Z, Vector128<ulong> ZB) YGroup3UnzipX2(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, Vector128<ulong> data4, Vector128<ulong> data5) {
            var rt0 = YGroup3UnzipX2(data0, data1, data2, data3, data4, data5, out var rt1, out var rt2, out var rt3, out var rt4, out var rt5);
            return (rt0, rt1, rt2, rt3, rt4, rt5);
        }


        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Data0, Vector128<T> Data1, Vector128<T> Data2) YGroup3Zip<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector128<float>)(object)x, (Vector128<float>)(object)y, (Vector128<float>)(object)z);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector128<double>)(object)x, (Vector128<double>)(object)y, (Vector128<double>)(object)z);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector128<sbyte>)(object)x, (Vector128<sbyte>)(object)y, (Vector128<sbyte>)(object)z);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector128<byte>)(object)x, (Vector128<byte>)(object)y, (Vector128<byte>)(object)z);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector128<short>)(object)x, (Vector128<short>)(object)y, (Vector128<short>)(object)z);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector128<ushort>)(object)x, (Vector128<ushort>)(object)y, (Vector128<ushort>)(object)z);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector128<int>)(object)x, (Vector128<int>)(object)y, (Vector128<int>)(object)z);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector128<uint>)(object)x, (Vector128<uint>)(object)y, (Vector128<uint>)(object)z);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector128<long>)(object)x, (Vector128<long>)(object)y, (Vector128<long>)(object)z);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip((Vector128<ulong>)(object)x, (Vector128<ulong>)(object)y, (Vector128<ulong>)(object)z);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2);
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
        public static (Vector128<float> Data0, Vector128<float> Data1, Vector128<float> Data2) YGroup3Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Data0, Vector128<double> Data1, Vector128<double> Data2) YGroup3Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Data0, Vector128<sbyte> Data1, Vector128<sbyte> Data2) YGroup3Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Data0, Vector128<byte> Data1, Vector128<byte> Data2) YGroup3Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Data0, Vector128<short> Data1, Vector128<short> Data2) YGroup3Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Data0, Vector128<ushort> Data1, Vector128<ushort> Data2) YGroup3Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Data0, Vector128<int> Data1, Vector128<int> Data2) YGroup3Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Data0, Vector128<uint> Data1, Vector128<uint> Data2) YGroup3Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Data0, Vector128<long> Data1, Vector128<long> Data2) YGroup3Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }

        /// <inheritdoc cref="YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Data0, Vector128<ulong> Data1, Vector128<ulong> Data2) YGroup3Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z) {
            var data0 = YGroup3Zip(x, y, z, out var data1, out var data2);
            return (data0, data1, data2);
        }


        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Data0, Vector128<T> Data1, Vector128<T> Data2, Vector128<T> Data3, Vector128<T> Data4, Vector128<T> Data5) YGroup3ZipX2<T>(Vector128<T> x, Vector128<T> xB, Vector128<T> y, Vector128<T> yB, Vector128<T> z, Vector128<T> zB) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector128<float>)(object)x, (Vector128<float>)(object)xB, (Vector128<float>)(object)y, (Vector128<float>)(object)yB, (Vector128<float>)(object)z, (Vector128<float>)(object)zB);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector128<double>)(object)x, (Vector128<double>)(object)xB, (Vector128<double>)(object)y, (Vector128<double>)(object)yB, (Vector128<double>)(object)z, (Vector128<double>)(object)zB);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector128<sbyte>)(object)x, (Vector128<sbyte>)(object)xB, (Vector128<sbyte>)(object)y, (Vector128<sbyte>)(object)yB, (Vector128<sbyte>)(object)z, (Vector128<sbyte>)(object)zB);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector128<byte>)(object)x, (Vector128<byte>)(object)xB, (Vector128<byte>)(object)y, (Vector128<byte>)(object)yB, (Vector128<byte>)(object)z, (Vector128<byte>)(object)zB);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector128<short>)(object)x, (Vector128<short>)(object)xB, (Vector128<short>)(object)y, (Vector128<short>)(object)yB, (Vector128<short>)(object)z, (Vector128<short>)(object)zB);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector128<ushort>)(object)x, (Vector128<ushort>)(object)xB, (Vector128<ushort>)(object)y, (Vector128<ushort>)(object)yB, (Vector128<ushort>)(object)z, (Vector128<ushort>)(object)zB);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector128<int>)(object)x, (Vector128<int>)(object)xB, (Vector128<int>)(object)y, (Vector128<int>)(object)yB, (Vector128<int>)(object)z, (Vector128<int>)(object)zB);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector128<uint>)(object)x, (Vector128<uint>)(object)xB, (Vector128<uint>)(object)y, (Vector128<uint>)(object)yB, (Vector128<uint>)(object)z, (Vector128<uint>)(object)zB);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector128<long>)(object)x, (Vector128<long>)(object)xB, (Vector128<long>)(object)y, (Vector128<long>)(object)yB, (Vector128<long>)(object)z, (Vector128<long>)(object)zB);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2((Vector128<ulong>)(object)x, (Vector128<ulong>)(object)xB, (Vector128<ulong>)(object)y, (Vector128<ulong>)(object)yB, (Vector128<ulong>)(object)z, (Vector128<ulong>)(object)zB);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3, (Vector128<T>)(object)rt4, (Vector128<T>)(object)rt5);
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
        public static (Vector128<float> Data0, Vector128<float> Data1, Vector128<float> Data2, Vector128<float> Data3, Vector128<float> Data4, Vector128<float> Data5) YGroup3ZipX2(Vector128<float> x, Vector128<float> xB, Vector128<float> y, Vector128<float> yB, Vector128<float> z, Vector128<float> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Data0, Vector128<double> Data1, Vector128<double> Data2, Vector128<double> Data3, Vector128<double> Data4, Vector128<double> Data5) YGroup3ZipX2(Vector128<double> x, Vector128<double> xB, Vector128<double> y, Vector128<double> yB, Vector128<double> z, Vector128<double> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Data0, Vector128<sbyte> Data1, Vector128<sbyte> Data2, Vector128<sbyte> Data3, Vector128<sbyte> Data4, Vector128<sbyte> Data5) YGroup3ZipX2(Vector128<sbyte> x, Vector128<sbyte> xB, Vector128<sbyte> y, Vector128<sbyte> yB, Vector128<sbyte> z, Vector128<sbyte> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Data0, Vector128<byte> Data1, Vector128<byte> Data2, Vector128<byte> Data3, Vector128<byte> Data4, Vector128<byte> Data5) YGroup3ZipX2(Vector128<byte> x, Vector128<byte> xB, Vector128<byte> y, Vector128<byte> yB, Vector128<byte> z, Vector128<byte> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Data0, Vector128<short> Data1, Vector128<short> Data2, Vector128<short> Data3, Vector128<short> Data4, Vector128<short> Data5) YGroup3ZipX2(Vector128<short> x, Vector128<short> xB, Vector128<short> y, Vector128<short> yB, Vector128<short> z, Vector128<short> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Data0, Vector128<ushort> Data1, Vector128<ushort> Data2, Vector128<ushort> Data3, Vector128<ushort> Data4, Vector128<ushort> Data5) YGroup3ZipX2(Vector128<ushort> x, Vector128<ushort> xB, Vector128<ushort> y, Vector128<ushort> yB, Vector128<ushort> z, Vector128<ushort> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Data0, Vector128<int> Data1, Vector128<int> Data2, Vector128<int> Data3, Vector128<int> Data4, Vector128<int> Data5) YGroup3ZipX2(Vector128<int> x, Vector128<int> xB, Vector128<int> y, Vector128<int> yB, Vector128<int> z, Vector128<int> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Data0, Vector128<uint> Data1, Vector128<uint> Data2, Vector128<uint> Data3, Vector128<uint> Data4, Vector128<uint> Data5) YGroup3ZipX2(Vector128<uint> x, Vector128<uint> xB, Vector128<uint> y, Vector128<uint> yB, Vector128<uint> z, Vector128<uint> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Data0, Vector128<long> Data1, Vector128<long> Data2, Vector128<long> Data3, Vector128<long> Data4, Vector128<long> Data5) YGroup3ZipX2(Vector128<long> x, Vector128<long> xB, Vector128<long> y, Vector128<long> yB, Vector128<long> z, Vector128<long> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }

        /// <inheritdoc cref="YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Data0, Vector128<ulong> Data1, Vector128<ulong> Data2, Vector128<ulong> Data3, Vector128<ulong> Data4, Vector128<ulong> Data5) YGroup3ZipX2(Vector128<ulong> x, Vector128<ulong> xB, Vector128<ulong> y, Vector128<ulong> yB, Vector128<ulong> z, Vector128<ulong> zB) {
            var data0 = YGroup3ZipX2(x, xB, y, yB, z, zB, out var data1, out var data2, out var data3, out var data4, out var data5);
            return (data0, data1, data2, data3, data4, data5);
        }


        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Result0, Vector128<T> Result1, Vector128<T> Result2) YGroup4ToGroup3<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, Vector128<T> data3) where T : struct {
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
        /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Result0, Vector128<float> Result1, Vector128<float> Result2) YGroup4ToGroup3(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Result0, Vector128<double> Result1, Vector128<double> Result2) YGroup4ToGroup3(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1, Vector128<sbyte> Result2) YGroup4ToGroup3(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1, Vector128<byte> Result2) YGroup4ToGroup3(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Result0, Vector128<short> Result1, Vector128<short> Result2) YGroup4ToGroup3(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1, Vector128<ushort> Result2) YGroup4ToGroup3(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Result0, Vector128<int> Result1, Vector128<int> Result2) YGroup4ToGroup3(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1, Vector128<uint> Result2) YGroup4ToGroup3(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Result0, Vector128<long> Result1, Vector128<long> Result2) YGroup4ToGroup3(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1, Vector128<ulong> Result2) YGroup4ToGroup3(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


#if BCL_TYPE_INT128

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, out Vector128{ExInt128}, out Vector128{ExInt128}, out Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup4Unzip(Vector128<Int128> data0, Vector128<Int128> data1, Vector128<Int128> data2, Vector128<Int128> data3, out Vector128<Int128> y, out Vector128<Int128> z, out Vector128<Int128> w) {
            var d0 = YGroup4Unzip(data0.ExAsExInt128(), data1.ExAsExInt128(), data2.ExAsExInt128(), data3.ExAsExInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsInt128();
            z = d2.ExAsInt128();
            w = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, out Vector128{ExUInt128}, out Vector128{ExUInt128}, out Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup4Unzip(Vector128<UInt128> data0, Vector128<UInt128> data1, Vector128<UInt128> data2, Vector128<UInt128> data3, out Vector128<UInt128> y, out Vector128<UInt128> z, out Vector128<UInt128> w) {
            var d0 = YGroup4Unzip(data0.ExAsExUInt128(), data1.ExAsExUInt128(), data2.ExAsExUInt128(), data3.ExAsExUInt128(), out var d1, out var d2, out var d3);
            y = d1.ExAsUInt128();
            z = d2.ExAsUInt128();
            w = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> X, Vector128<T> Y, Vector128<T> Z, Vector128<T> W) YGroup4Unzip<T>(Vector128<T> data0, Vector128<T> data1, Vector128<T> data2, Vector128<T> data3) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<float>)(object)data0, (Vector128<float>)(object)data1, (Vector128<float>)(object)data2, (Vector128<float>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<double>)(object)data0, (Vector128<double>)(object)data1, (Vector128<double>)(object)data2, (Vector128<double>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<sbyte>)(object)data0, (Vector128<sbyte>)(object)data1, (Vector128<sbyte>)(object)data2, (Vector128<sbyte>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<byte>)(object)data0, (Vector128<byte>)(object)data1, (Vector128<byte>)(object)data2, (Vector128<byte>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<short>)(object)data0, (Vector128<short>)(object)data1, (Vector128<short>)(object)data2, (Vector128<short>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<ushort>)(object)data0, (Vector128<ushort>)(object)data1, (Vector128<ushort>)(object)data2, (Vector128<ushort>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<int>)(object)data0, (Vector128<int>)(object)data1, (Vector128<int>)(object)data2, (Vector128<int>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<uint>)(object)data0, (Vector128<uint>)(object)data1, (Vector128<uint>)(object)data2, (Vector128<uint>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<long>)(object)data0, (Vector128<long>)(object)data1, (Vector128<long>)(object)data2, (Vector128<long>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<ulong>)(object)data0, (Vector128<ulong>)(object)data1, (Vector128<ulong>)(object)data2, (Vector128<ulong>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<ExInt128>)(object)data0, (Vector128<ExInt128>)(object)data1, (Vector128<ExInt128>)(object)data2, (Vector128<ExInt128>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<ExUInt128>)(object)data0, (Vector128<ExUInt128>)(object)data1, (Vector128<ExUInt128>)(object)data2, (Vector128<ExUInt128>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<Int128>)(object)data0, (Vector128<Int128>)(object)data1, (Vector128<Int128>)(object)data2, (Vector128<Int128>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip((Vector128<UInt128>)(object)data0, (Vector128<UInt128>)(object)data1, (Vector128<UInt128>)(object)data2, (Vector128<UInt128>)(object)data3);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
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
        public static (Vector128<float> X, Vector128<float> Y, Vector128<float> Z, Vector128<float> W) YGroup4Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> X, Vector128<double> Y, Vector128<double> Z, Vector128<double> W) YGroup4Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> X, Vector128<sbyte> Y, Vector128<sbyte> Z, Vector128<sbyte> W) YGroup4Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> X, Vector128<byte> Y, Vector128<byte> Z, Vector128<byte> W) YGroup4Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> X, Vector128<short> Y, Vector128<short> Z, Vector128<short> W) YGroup4Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector128<ushort> X, Vector128<ushort> Y, Vector128<ushort> Z, Vector128<ushort> W) YGroup4Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> X, Vector128<int> Y, Vector128<int> Z, Vector128<int> W) YGroup4Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector128<uint> X, Vector128<uint> Y, Vector128<uint> Z, Vector128<uint> W) YGroup4Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> X, Vector128<long> Y, Vector128<long> Z, Vector128<long> W) YGroup4Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector128<ulong> X, Vector128<ulong> Y, Vector128<ulong> Z, Vector128<ulong> W) YGroup4Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExInt128> X, Vector128<ExInt128> Y, Vector128<ExInt128> Z, Vector128<ExInt128> W) YGroup4Unzip(Vector128<ExInt128> data0, Vector128<ExInt128> data1, Vector128<ExInt128> data2, Vector128<ExInt128> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExUInt128> X, Vector128<ExUInt128> Y, Vector128<ExUInt128> Z, Vector128<ExUInt128> W) YGroup4Unzip(Vector128<ExUInt128> data0, Vector128<ExUInt128> data1, Vector128<ExUInt128> data2, Vector128<ExUInt128> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<Int128> X, Vector128<Int128> Y, Vector128<Int128> Z, Vector128<Int128> W) YGroup4Unzip(Vector128<Int128> data0, Vector128<Int128> data1, Vector128<Int128> data2, Vector128<Int128> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

        /// <inheritdoc cref="YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<UInt128> X, Vector128<UInt128> Y, Vector128<UInt128> Z, Vector128<UInt128> W) YGroup4Unzip(Vector128<UInt128> data0, Vector128<UInt128> data1, Vector128<UInt128> data2, Vector128<UInt128> data3) {
            var rt0 = YGroup4Unzip(data0, data1, data2, data3, out var rt1, out var rt2, out var rt3);
            return (rt0, rt1, rt2, rt3);
        }

#endif // BCL_TYPE_INT128


#if BCL_TYPE_INT128

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, Vector128{ExInt128}, out Vector128{ExInt128}, out Vector128{ExInt128}, out Vector128{ExInt128})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<Int128> YGroup4Zip(Vector128<Int128> x, Vector128<Int128> y, Vector128<Int128> z, Vector128<Int128> w, out Vector128<Int128> data1, out Vector128<Int128> data2, out Vector128<Int128> data3) {
            var d0 = YGroup4Zip(x.ExAsExInt128(), y.ExAsExInt128(), z.ExAsExInt128(), w.ExAsExInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsInt128();
            data2 = d2.ExAsInt128();
            data3 = d3.ExAsInt128();
            return d0.ExAsInt128();
        }

        /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, Vector128{ExUInt128}, out Vector128{ExUInt128}, out Vector128{ExUInt128}, out Vector128{ExUInt128})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<UInt128> YGroup4Zip(Vector128<UInt128> x, Vector128<UInt128> y, Vector128<UInt128> z, Vector128<UInt128> w, out Vector128<UInt128> data1, out Vector128<UInt128> data2, out Vector128<UInt128> data3) {
            var d0 = YGroup4Zip(x.ExAsExUInt128(), y.ExAsExUInt128(), z.ExAsExUInt128(), w.ExAsExUInt128(), out var d1, out var d2, out var d3);
            data1 = d1.ExAsUInt128();
            data2 = d2.ExAsUInt128();
            data3 = d3.ExAsUInt128();
            return d0.ExAsUInt128();
        }

#endif // BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<T> Data0, Vector128<T> Data1, Vector128<T> Data2, Vector128<T> Data3) YGroup4Zip<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z, Vector128<T> w) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<float>)(object)x, (Vector128<float>)(object)y, (Vector128<float>)(object)z, (Vector128<float>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<double>)(object)x, (Vector128<double>)(object)y, (Vector128<double>)(object)z, (Vector128<double>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<sbyte>)(object)x, (Vector128<sbyte>)(object)y, (Vector128<sbyte>)(object)z, (Vector128<sbyte>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<byte>)(object)x, (Vector128<byte>)(object)y, (Vector128<byte>)(object)z, (Vector128<byte>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<short>)(object)x, (Vector128<short>)(object)y, (Vector128<short>)(object)z, (Vector128<short>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<ushort>)(object)x, (Vector128<ushort>)(object)y, (Vector128<ushort>)(object)z, (Vector128<ushort>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<int>)(object)x, (Vector128<int>)(object)y, (Vector128<int>)(object)z, (Vector128<int>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<uint>)(object)x, (Vector128<uint>)(object)y, (Vector128<uint>)(object)z, (Vector128<uint>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<long>)(object)x, (Vector128<long>)(object)y, (Vector128<long>)(object)z, (Vector128<long>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<ulong>)(object)x, (Vector128<ulong>)(object)y, (Vector128<ulong>)(object)z, (Vector128<ulong>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<ExInt128>)(object)x, (Vector128<ExInt128>)(object)y, (Vector128<ExInt128>)(object)z, (Vector128<ExInt128>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<ExUInt128>)(object)x, (Vector128<ExUInt128>)(object)y, (Vector128<ExUInt128>)(object)z, (Vector128<ExUInt128>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<Int128>)(object)x, (Vector128<Int128>)(object)y, (Vector128<Int128>)(object)z, (Vector128<Int128>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip((Vector128<UInt128>)(object)x, (Vector128<UInt128>)(object)y, (Vector128<UInt128>)(object)z, (Vector128<UInt128>)(object)w);
                return ((Vector128<T>)(object)rt0, (Vector128<T>)(object)rt1, (Vector128<T>)(object)rt2, (Vector128<T>)(object)rt3);
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
        public static (Vector128<float> Data0, Vector128<float> Data1, Vector128<float> Data2, Vector128<float> Data3) YGroup4Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z, Vector128<float> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Data0, Vector128<double> Data1, Vector128<double> Data2, Vector128<double> Data3) YGroup4Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z, Vector128<double> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Data0, Vector128<sbyte> Data1, Vector128<sbyte> Data2, Vector128<sbyte> Data3) YGroup4Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, Vector128<sbyte> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Data0, Vector128<byte> Data1, Vector128<byte> Data2, Vector128<byte> Data3) YGroup4Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, Vector128<byte> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Data0, Vector128<short> Data1, Vector128<short> Data2, Vector128<short> Data3) YGroup4Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z, Vector128<short> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> Data0, Vector128<ushort> Data1, Vector128<ushort> Data2, Vector128<ushort> Data3) YGroup4Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, Vector128<ushort> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Data0, Vector128<int> Data1, Vector128<int> Data2, Vector128<int> Data3) YGroup4Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z, Vector128<int> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Data0, Vector128<uint> Data1, Vector128<uint> Data2, Vector128<uint> Data3) YGroup4Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, Vector128<uint> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Data0, Vector128<long> Data1, Vector128<long> Data2, Vector128<long> Data3) YGroup4Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z, Vector128<long> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> Data0, Vector128<ulong> Data1, Vector128<ulong> Data2, Vector128<ulong> Data3) YGroup4Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, Vector128<ulong> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExInt128> Data0, Vector128<ExInt128> Data1, Vector128<ExInt128> Data2, Vector128<ExInt128> Data3) YGroup4Zip(Vector128<ExInt128> x, Vector128<ExInt128> y, Vector128<ExInt128> z, Vector128<ExInt128> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ExUInt128> Data0, Vector128<ExUInt128> Data1, Vector128<ExUInt128> Data2, Vector128<ExUInt128> Data3) YGroup4Zip(Vector128<ExUInt128> x, Vector128<ExUInt128> y, Vector128<ExUInt128> z, Vector128<ExUInt128> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#if BCL_TYPE_INT128

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<Int128> Data0, Vector128<Int128> Data1, Vector128<Int128> Data2, Vector128<Int128> Data3) YGroup4Zip(Vector128<Int128> x, Vector128<Int128> y, Vector128<Int128> z, Vector128<Int128> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

        /// <inheritdoc cref="YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<UInt128> Data0, Vector128<UInt128> Data1, Vector128<UInt128> Data2, Vector128<UInt128> Data3) YGroup4Zip(Vector128<UInt128> x, Vector128<UInt128> y, Vector128<UInt128> z, Vector128<UInt128> w) {
            var data0 = YGroup4Zip(x, y, z, w, out var data1, out var data2, out var data3);
            return (data0, data1, data2, data3);
        }

#endif // BCL_TYPE_INT128


        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        /// <seealso cref="YShuffleG4X2(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector128<T> Result0, Vector128<T> Result1) YShuffleG4X2<T>(Vector128<T> source0, Vector128<T> source1, ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector128<float>)(object)source0, (Vector128<float>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector128<double>)(object)source0, (Vector128<double>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector128<sbyte>)(object)source0, (Vector128<sbyte>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector128<byte>)(object)source0, (Vector128<byte>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector128<short>)(object)source0, (Vector128<short>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector128<ushort>)(object)source0, (Vector128<ushort>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector128<int>)(object)source0, (Vector128<int>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector128<uint>)(object)source0, (Vector128<uint>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector128<long>)(object)source0, (Vector128<long>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2((Vector128<ulong>)(object)source0, (Vector128<ulong>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Result0, Vector128<float> Result1) YShuffleG4X2(Vector128<float> source0, Vector128<float> source1, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control);
            }
#endif // SHORT_CIRCUIT_WASM
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Result0, Vector128<double> Result1) YShuffleG4X2(Vector128<double> source0, Vector128<double> source1, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control);
            }
#endif // SHORT_CIRCUIT_WASM
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1) YShuffleG4X2(Vector128<sbyte> source0, Vector128<sbyte> source1, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control);
            }
#endif // SHORT_CIRCUIT_WASM
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1) YShuffleG4X2(Vector128<byte> source0, Vector128<byte> source1, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control);
            }
#endif // SHORT_CIRCUIT_WASM
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Result0, Vector128<short> Result1) YShuffleG4X2(Vector128<short> source0, Vector128<short> source1, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control);
            }
#endif // SHORT_CIRCUIT_WASM
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1) YShuffleG4X2(Vector128<ushort> source0, Vector128<ushort> source1, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control);
            }
#endif // SHORT_CIRCUIT_WASM
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Result0, Vector128<int> Result1) YShuffleG4X2(Vector128<int> source0, Vector128<int> source1, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control);
            }
#endif // SHORT_CIRCUIT_WASM
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1) YShuffleG4X2(Vector128<uint> source0, Vector128<uint> source1, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control);
            }
#endif // SHORT_CIRCUIT_WASM
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Result0, Vector128<long> Result1) YShuffleG4X2(Vector128<long> source0, Vector128<long> source1, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control);
            }
#endif // SHORT_CIRCUIT_WASM
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed (对于两个向量中的每个 4-元素组, 进行换位).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1) YShuffleG4X2(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control) {
#if SHORT_CIRCUIT_WASM
            if (PackedSimd.IsSupported) {
                return WasmStatics.YShuffleG4X2(source0, source1, control);
            }
#endif // SHORT_CIRCUIT_WASM
            var result0 = YShuffleG4X2(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        /// <seealso cref="YShuffleG4X2_Const(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector128<T> Result0, Vector128<T> Result1) YShuffleG4X2_Const<T>(Vector128<T> source0, Vector128<T> source1, ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector128<float>)(object)source0, (Vector128<float>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector128<double>)(object)source0, (Vector128<double>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector128<sbyte>)(object)source0, (Vector128<sbyte>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector128<byte>)(object)source0, (Vector128<byte>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector128<short>)(object)source0, (Vector128<short>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector128<ushort>)(object)source0, (Vector128<ushort>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector128<int>)(object)source0, (Vector128<int>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector128<uint>)(object)source0, (Vector128<uint>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector128<long>)(object)source0, (Vector128<long>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const((Vector128<ulong>)(object)source0, (Vector128<ulong>)(object)source1, control);
                return ((Vector128<T>)(object)result0, (Vector128<T>)(object)result1);
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }


        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<float> Result0, Vector128<float> Result1) YShuffleG4X2_Const(Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<double> Result0, Vector128<double> Result1) YShuffleG4X2_Const(Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1) YShuffleG4X2_Const(Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> Result0, Vector128<byte> Result1) YShuffleG4X2_Const(Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> Result0, Vector128<short> Result1) YShuffleG4X2_Const(Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1) YShuffleG4X2_Const(Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> Result0, Vector128<int> Result1) YShuffleG4X2_Const(Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector128<uint> Result0, Vector128<uint> Result1) YShuffleG4X2_Const(Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> Result0, Vector128<long> Result1) YShuffleG4X2_Const(Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }

        /// <summary>
        /// For each 4-element group in two vector, shuffle is performed - Constant version (对于两个向量中的每个 4-元素组, 进行换位 - 常量版).
        /// Mnemonic: View for group: <c>rt.xyzw = shuffleG4_ref(control, source0, source1)</c>. View for element: <c>element_ref(i, result0, result1) := element_ref((i&amp;(~3)) | ((control &gt;&gt; ((i&amp;3)*2)) &amp; 3), source0, source1)</c>.
        /// </summary>
        /// <param name="source0">The input source 0 from which values are selected (从中选择值的输入源0).</param>
        /// <param name="source1">The input source 1 from which values are selected (从中选择值的输入源1).</param>
        /// <param name="control">Shuffle control code (换位控制码).</param>
        /// <returns>Returns the two vectors after shuffle (返回换位后的两个向量).</returns>
        /// <seealso cref="YShuffleG4X2_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1) YShuffleG4X2_Const(Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleInsert_Args<TIdx>(Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a0;
                args1 = (Vector128<TIdx>)(object)a1;
                args2 = (Vector128<TIdx>)(object)a2;
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector128s.YShuffleInsert_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2) YShuffleInsert_Args<TIdx>(Vector128<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2) YShuffleInsert_Args(Vector128<sbyte> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2) YShuffleInsert_Args(Vector128<byte> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2) YShuffleInsert_Args(Vector128<short> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2) YShuffleInsert_Args(Vector128<ushort> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) YShuffleInsert_Args(Vector128<int> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2) YShuffleInsert_Args(Vector128<uint> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) YShuffleInsert_Args(Vector128<long> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2) YShuffleInsert_Args(Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleInsert_Core(Vector128<float> back, Vector128<float> vector, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleInsert_Core(Vector128<double> back, Vector128<double> vector, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleInsert_Core(Vector128<sbyte> back, Vector128<sbyte> vector, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleInsert_Core(Vector128<byte> back, Vector128<byte> vector, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleInsert_Core(Vector128<short> back, Vector128<short> vector, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleInsert_Core(Vector128<ushort> back, Vector128<ushort> vector, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleInsert_Core(Vector128<int> back, Vector128<int> vector, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleInsert_Core(Vector128<uint> back, Vector128<uint> vector, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleInsert_Core(Vector128<long> back, Vector128<long> vector, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleInsert_Core(Vector128<ulong> back, Vector128<ulong> vector, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleKernel_Args<TIdx>(Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b) = YShuffleKernel_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector128s.YShuffleKernel_Args{TIdx}(Vector128{TIdx}, out Vector128{TIdx}, out Vector128{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1) YShuffleKernel_Args<TIdx>(Vector128<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1) YShuffleKernel_Args(Vector128<sbyte> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1) YShuffleKernel_Args(Vector128<byte> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1) YShuffleKernel_Args(Vector128<short> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1) YShuffleKernel_Args(Vector128<ushort> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1) YShuffleKernel_Args(Vector128<int> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1) YShuffleKernel_Args(Vector128<uint> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1) YShuffleKernel_Args(Vector128<long> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1) YShuffleKernel_Args(Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleKernel_Core(Vector128<float> vector, (Vector128<int> args0, Vector128<int> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleKernel_Core(Vector128<double> vector, (Vector128<long> args0, Vector128<long> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleKernel_Core(Vector128<sbyte> vector, (Vector128<sbyte> args0, Vector128<sbyte> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleKernel_Core(Vector128<byte> vector, (Vector128<byte> args0, Vector128<byte> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleKernel_Core(Vector128<short> vector, (Vector128<short> args0, Vector128<short> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleKernel_Core(Vector128<ushort> vector, (Vector128<ushort> args0, Vector128<ushort> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleKernel_Core(Vector128<int> vector, (Vector128<int> args0, Vector128<int> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleKernel_Core(Vector128<uint> vector, (Vector128<uint> args0, Vector128<uint> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleKernel_Core(Vector128<long> vector, (Vector128<long> args0, Vector128<long> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleKernel_Core(Vector128<ulong> vector, (Vector128<ulong> args0, Vector128<ulong> args1) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX2_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX2_Args<TIdx>(Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3, out Vector128<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
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
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) YShuffleX2_Args<TIdx>(Vector128<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits128.YShuffleX2_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) YShuffleX2_Args(Vector128<sbyte> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) YShuffleX2_Args(Vector128<byte> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) YShuffleX2_Args(Vector128<short> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) YShuffleX2_Args(Vector128<ushort> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) YShuffleX2_Args(Vector128<int> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) YShuffleX2_Args(Vector128<uint> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) YShuffleX2_Args(Vector128<long> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) YShuffleX2_Args(Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX2_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX2_Core(Vector128<float> vector0, Vector128<float> vector1, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX2_Core(Vector128<double> vector0, Vector128<double> vector1, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX2_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX2_Core(Vector128<byte> vector0, Vector128<byte> vector1, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX2_Core(Vector128<short> vector0, Vector128<short> vector1, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX2_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX2_Core(Vector128<int> vector0, Vector128<int> vector1, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX2_Core(Vector128<uint> vector0, Vector128<uint> vector1, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX2_Core(Vector128<long> vector0, Vector128<long> vector1, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX2_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX2Insert_Args<TIdx>(Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3, out Vector128<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX2Insert_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
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
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) YShuffleX2Insert_Args<TIdx>(Vector128<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) YShuffleX2Insert_Args(Vector128<sbyte> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) YShuffleX2Insert_Args(Vector128<byte> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) YShuffleX2Insert_Args(Vector128<short> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) YShuffleX2Insert_Args(Vector128<ushort> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) YShuffleX2Insert_Args(Vector128<int> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) YShuffleX2Insert_Args(Vector128<uint> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) YShuffleX2Insert_Args(Vector128<long> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) YShuffleX2Insert_Args(Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX2Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX2Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX2Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX2Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX2Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX2Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX2Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX2Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX2Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX2Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <summary>
        /// Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector128s{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vector128s{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX2Kernel_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX2Kernel_Args<TIdx>(Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX2Kernel_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector128s{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vector128s{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3) YShuffleX2Kernel_Args<TIdx>(Vector128<TIdx> indices)
                where TIdx : struct {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector128s{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vector128s{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) YShuffleX2Kernel_Args(Vector128<sbyte> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) YShuffleX2Kernel_Args(Vector128<byte> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) YShuffleX2Kernel_Args(Vector128<short> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) YShuffleX2Kernel_Args(Vector128<ushort> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) YShuffleX2Kernel_Args(Vector128<int> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) YShuffleX2Kernel_Args(Vector128<uint> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) YShuffleX2Kernel_Args(Vector128<long> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) YShuffleX2Kernel_Args(Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX2Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX2Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX2Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX2Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX2Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX2Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX2Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX2Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX2Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX2Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX3_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX3_Args<TIdx>(Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3, out Vector128<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
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
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) YShuffleX3_Args<TIdx>(Vector128<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits128.YShuffleX3_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) YShuffleX3_Args(Vector128<sbyte> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) YShuffleX3_Args(Vector128<byte> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) YShuffleX3_Args(Vector128<short> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) YShuffleX3_Args(Vector128<ushort> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) YShuffleX3_Args(Vector128<int> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) YShuffleX3_Args(Vector128<uint> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) YShuffleX3_Args(Vector128<long> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) YShuffleX3_Args(Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX3_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX3_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX3_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX3_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX3_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX3_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX3_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX3_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX3_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX3_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX3_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX3Insert_Args<TIdx>(Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3, out Vector128<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX3Insert_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
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
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) YShuffleX3Insert_Args<TIdx>(Vector128<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) YShuffleX3Insert_Args(Vector128<sbyte> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) YShuffleX3Insert_Args(Vector128<byte> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) YShuffleX3Insert_Args(Vector128<short> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) YShuffleX3Insert_Args(Vector128<ushort> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) YShuffleX3Insert_Args(Vector128<int> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) YShuffleX3Insert_Args(Vector128<uint> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) YShuffleX3Insert_Args(Vector128<long> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) YShuffleX3Insert_Args(Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX3Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX3Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX3Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX3Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX3Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX3Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX3Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX3Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX3Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX3Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX3Kernel_Args<TIdx>(Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX3Kernel_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
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
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3) YShuffleX3Kernel_Args<TIdx>(Vector128<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) YShuffleX3Kernel_Args(Vector128<sbyte> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) YShuffleX3Kernel_Args(Vector128<byte> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) YShuffleX3Kernel_Args(Vector128<short> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) YShuffleX3Kernel_Args(Vector128<ushort> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) YShuffleX3Kernel_Args(Vector128<int> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) YShuffleX3Kernel_Args(Vector128<uint> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) YShuffleX3Kernel_Args(Vector128<long> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) YShuffleX3Kernel_Args(Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX3Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX3Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX3Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX3Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX3Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX3Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX3Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX3Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX3Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX3Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX4_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX4_Args<TIdx>(Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3, out Vector128<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
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
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) YShuffleX4_Args<TIdx>(Vector128<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits128.YShuffleX4_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) YShuffleX4_Args(Vector128<sbyte> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) YShuffleX4_Args(Vector128<byte> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) YShuffleX4_Args(Vector128<short> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) YShuffleX4_Args(Vector128<ushort> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) YShuffleX4_Args(Vector128<int> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) YShuffleX4_Args(Vector128<uint> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) YShuffleX4_Args(Vector128<long> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) YShuffleX4_Args(Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX4_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX4_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX4_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX4_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX4_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX4_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX4_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX4_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX4_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX4_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX4_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) args) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX4Insert_Args<TIdx>(Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3, out Vector128<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d, var e) = YShuffleX4Insert_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
                args4 = (Vector128<TIdx>)(object)e;
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
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3, Vector128<TIdx> args4) YShuffleX4Insert_Args<TIdx>(Vector128<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) YShuffleX4Insert_Args(Vector128<sbyte> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) YShuffleX4Insert_Args(Vector128<byte> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) YShuffleX4Insert_Args(Vector128<short> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) YShuffleX4Insert_Args(Vector128<ushort> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) YShuffleX4Insert_Args(Vector128<int> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) YShuffleX4Insert_Args(Vector128<uint> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) YShuffleX4Insert_Args(Vector128<long> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) YShuffleX4Insert_Args(Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX4Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX4Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX4Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX4Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX4Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX4Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX4Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX4Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX4Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX4Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <summary>
        /// Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector128s{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vector128s{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX4Kernel_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX4Kernel_Args<TIdx>(Vector128<TIdx> indices, out Vector128<TIdx> args0, out Vector128<TIdx> args1, out Vector128<TIdx> args2, out Vector128<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector128<sbyte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector128<byte>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(short) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector128<short>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector128<ushort>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(int) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector128<int>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector128<uint>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(long) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector128<long>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a, var b, var c, var d) = YShuffleX4Kernel_Args((Vector128<ulong>)(object)indices);
                args0 = (Vector128<TIdx>)(object)a;
                args1 = (Vector128<TIdx>)(object)b;
                args2 = (Vector128<TIdx>)(object)c;
                args3 = (Vector128<TIdx>)(object)d;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector128s{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vector128s{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<TIdx> args0, Vector128<TIdx> args1, Vector128<TIdx> args2, Vector128<TIdx> args3) YShuffleX4Kernel_Args<TIdx>(Vector128<TIdx> indices)
                where TIdx : struct {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector128s{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vector128s{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) YShuffleX4Kernel_Args(Vector128<sbyte> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) YShuffleX4Kernel_Args(Vector128<byte> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) YShuffleX4Kernel_Args(Vector128<short> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) YShuffleX4Kernel_Args(Vector128<ushort> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) YShuffleX4Kernel_Args(Vector128<int> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) YShuffleX4Kernel_Args(Vector128<uint> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) YShuffleX4Kernel_Args(Vector128<long> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector128{sbyte})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) YShuffleX4Kernel_Args(Vector128<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleX4Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleX4Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleX4Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, (Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleX4Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, (Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleX4Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, (Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleX4Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, (Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleX4Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, (Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleX4Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, (Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleX4Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, (Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, ValueTuple{Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}})"/>
        /// <seealso cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleX4Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, (Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
