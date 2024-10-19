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
using Zyl.VectorTraits.Extensions.SameW;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits {
    static partial class Vectors {

        /// <inheritdoc cref="YGroup1ToGroup3(Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Result0, Vector<T> Result1, Vector<T> Result2) YGroup1ToGroup3<T>(Vector<T> x) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup1ToGroup3(x.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup1ToGroup3(x.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup1ToGroup3(x.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup1ToGroup3(x.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup1ToGroup3(x.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup1ToGroup3(x.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup1ToGroup3(x.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup1ToGroup3(x.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup1ToGroup3(x.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup1ToGroup3(x.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Convert a 1-element group, to a 3-element group. It also converts grayscale pixel data to packed RGB pixel data (将1-元素组, 转为3-元素组. 它还能将 灰度像素数据, 转换为 已打包的RGB像素数据).
        /// Mnemonic: View for group: <c>(result0, result1, result2) = YGroup3Zip(x, x, x)</c>. View for element: <c>element_ref(i, result0, result1, result2) := x[i/3]</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <returns>Returns the converted data. (返回转换后数据).</returns>
        /// <seealso cref="IVectorTraits.YGroup1ToGroup3_AcceleratedTypes"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Result0, Vector<float> Result1, Vector<float> Result2) YGroup1ToGroup3(Vector<float> x) {
            var rt0 = YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup1ToGroup3(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Result0, Vector<double> Result1, Vector<double> Result2) YGroup1ToGroup3(Vector<double> x) {
            var rt0 = YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup1ToGroup3(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Result0, Vector<sbyte> Result1, Vector<sbyte> Result2) YGroup1ToGroup3(Vector<sbyte> x) {
            var rt0 = YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup1ToGroup3(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Result0, Vector<byte> Result1, Vector<byte> Result2) YGroup1ToGroup3(Vector<byte> x) {
            var rt0 = YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup1ToGroup3(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Result0, Vector<short> Result1, Vector<short> Result2) YGroup1ToGroup3(Vector<short> x) {
            var rt0 = YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup1ToGroup3(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Result0, Vector<ushort> Result1, Vector<ushort> Result2) YGroup1ToGroup3(Vector<ushort> x) {
            var rt0 = YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup1ToGroup3(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Result0, Vector<int> Result1, Vector<int> Result2) YGroup1ToGroup3(Vector<int> x) {
            var rt0 = YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup1ToGroup3(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Result0, Vector<uint> Result1, Vector<uint> Result2) YGroup1ToGroup3(Vector<uint> x) {
            var rt0 = YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup1ToGroup3(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Result0, Vector<long> Result1, Vector<long> Result2) YGroup1ToGroup3(Vector<long> x) {
            var rt0 = YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup1ToGroup3(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Result0, Vector<ulong> Result1, Vector<ulong> Result2) YGroup1ToGroup3(Vector<ulong> x) {
            var rt0 = YGroup1ToGroup3(x, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }


        /// <inheritdoc cref="YGroup1ToGroup4(Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Result0, Vector<T> Result1, Vector<T> Result2, Vector<T> Result3) YGroup1ToGroup4<T>(Vector<T> x) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4(x.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4(x.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4(x.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4(x.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4(x.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4(x.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4(x.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4(x.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4(x.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4(x.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Convert a 1-element group, to a 4-element group. It also converts grayscale pixel data to packed RGBA pixel data (将1-元素组, 转为4-元素组. 它还能将 灰度像素数据, 转换为 已打包的RGBA像素数据).
        /// Mnemonic: View for group: <c>(result0, result1, result2, result4) = YGroup4Zip(x, x, x, x)</c>. View for element: <c>element_ref(i, result0, result1, result2, result4) := x[i/4]</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <returns>Returns the interleaved data (返回交织后数据).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Result0, Vector<float> Result1, Vector<float> Result2, Vector<float> Result3) YGroup1ToGroup4(Vector<float> x) {
            var result0 = YGroup1ToGroup4(x, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Result0, Vector<double> Result1, Vector<double> Result2, Vector<double> Result3) YGroup1ToGroup4(Vector<double> x) {
            var result0 = YGroup1ToGroup4(x, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Result0, Vector<sbyte> Result1, Vector<sbyte> Result2, Vector<sbyte> Result3) YGroup1ToGroup4(Vector<sbyte> x) {
            var result0 = YGroup1ToGroup4(x, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Result0, Vector<byte> Result1, Vector<byte> Result2, Vector<byte> Result3) YGroup1ToGroup4(Vector<byte> x) {
            var result0 = YGroup1ToGroup4(x, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Result0, Vector<short> Result1, Vector<short> Result2, Vector<short> Result3) YGroup1ToGroup4(Vector<short> x) {
            var result0 = YGroup1ToGroup4(x, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Result0, Vector<ushort> Result1, Vector<ushort> Result2, Vector<ushort> Result3) YGroup1ToGroup4(Vector<ushort> x) {
            var result0 = YGroup1ToGroup4(x, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Result0, Vector<int> Result1, Vector<int> Result2, Vector<int> Result3) YGroup1ToGroup4(Vector<int> x) {
            var result0 = YGroup1ToGroup4(x, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Result0, Vector<uint> Result1, Vector<uint> Result2, Vector<uint> Result3) YGroup1ToGroup4(Vector<uint> x) {
            var result0 = YGroup1ToGroup4(x, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Result0, Vector<long> Result1, Vector<long> Result2, Vector<long> Result3) YGroup1ToGroup4(Vector<long> x) {
            var result0 = YGroup1ToGroup4(x, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Result0, Vector<ulong> Result1, Vector<ulong> Result2, Vector<ulong> Result3) YGroup1ToGroup4(Vector<ulong> x) {
            var result0 = YGroup1ToGroup4(x, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }


        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Result0, Vector<T> Result1, Vector<T> Result2, Vector<T> Result3) YGroup1ToGroup4WithW<T>(Vector<T> x, Vector<T> w) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4WithW(x.As<T, float>(), w.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4WithW(x.As<T, double>(), w.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4WithW(x.As<T, sbyte>(), w.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4WithW(x.As<T, byte>(), w.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4WithW(x.As<T, short>(), w.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4WithW(x.As<T, ushort>(), w.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4WithW(x.As<T, int>(), w.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4WithW(x.As<T, uint>(), w.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4WithW(x.As<T, long>(), w.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup1ToGroup4WithW(x.As<T, ulong>(), w.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Convert a 1-element group and w argument, to a 4-element group. It also converts grayscale pixel data to packed RGBA pixel data (将1-元素组及w参数, 转为4-元素组. 它还能将 灰度像素数据, 转换为 已打包的RGBA像素数据).
        /// Mnemonic: View for group: <c>(result0, result1, result2, result4) = YGroup4Zip(x, x, x, w)</c>. View for element: <c>element_ref(i, result0, result1, result2, result4) := ((i%4)&lt;3)?( x[i2] ):( w[i2] )</c>, <c>i2 := i/4</c>.
        /// </summary>
        /// <param name="x">A vector consisting purely of X-components (纯由X分量所组成的向量).</param>
        /// <param name="w">A vector consisting purely of W-components (纯由W分量所组成的向量).</param>
        /// <returns>Returns the interleaved data (返回交织后数据).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Result0, Vector<float> Result1, Vector<float> Result2, Vector<float> Result3) YGroup1ToGroup4WithW(Vector<float> x, Vector<float> w) {
            var result0 = YGroup1ToGroup4WithW(x, w, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Result0, Vector<double> Result1, Vector<double> Result2, Vector<double> Result3) YGroup1ToGroup4WithW(Vector<double> x, Vector<double> w) {
            var result0 = YGroup1ToGroup4WithW(x, w, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Result0, Vector<sbyte> Result1, Vector<sbyte> Result2, Vector<sbyte> Result3) YGroup1ToGroup4WithW(Vector<sbyte> x, Vector<sbyte> w) {
            var result0 = YGroup1ToGroup4WithW(x, w, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Result0, Vector<byte> Result1, Vector<byte> Result2, Vector<byte> Result3) YGroup1ToGroup4WithW(Vector<byte> x, Vector<byte> w) {
            var result0 = YGroup1ToGroup4WithW(x, w, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Result0, Vector<short> Result1, Vector<short> Result2, Vector<short> Result3) YGroup1ToGroup4WithW(Vector<short> x, Vector<short> w) {
            var result0 = YGroup1ToGroup4WithW(x, w, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Result0, Vector<ushort> Result1, Vector<ushort> Result2, Vector<ushort> Result3) YGroup1ToGroup4WithW(Vector<ushort> x, Vector<ushort> w) {
            var result0 = YGroup1ToGroup4WithW(x, w, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Result0, Vector<int> Result1, Vector<int> Result2, Vector<int> Result3) YGroup1ToGroup4WithW(Vector<int> x, Vector<int> w) {
            var result0 = YGroup1ToGroup4WithW(x, w, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Result0, Vector<uint> Result1, Vector<uint> Result2, Vector<uint> Result3) YGroup1ToGroup4WithW(Vector<uint> x, Vector<uint> w) {
            var result0 = YGroup1ToGroup4WithW(x, w, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Result0, Vector<long> Result1, Vector<long> Result2, Vector<long> Result3) YGroup1ToGroup4WithW(Vector<long> x, Vector<long> w) {
            var result0 = YGroup1ToGroup4WithW(x, w, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }

        /// <inheritdoc cref="YGroup1ToGroup4WithW(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Result0, Vector<ulong> Result1, Vector<ulong> Result2, Vector<ulong> Result3) YGroup1ToGroup4WithW(Vector<ulong> x, Vector<ulong> w) {
            var result0 = YGroup1ToGroup4WithW(x, w, out var result1, out var result2, out var result3);
            return (result0, result1, result2, result3);
        }


        /// <inheritdoc cref="YGroup2Transpose(Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector<T> Result0, Vector<T> Result1) YGroup2Transpose<T>(Vector<T> data0, Vector<T> data1) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Transpose(data0.As<T, float>(), data1.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Transpose(data0.As<T, double>(), data1.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Transpose(data0.As<T, sbyte>(), data1.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Transpose(data0.As<T, byte>(), data1.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Transpose(data0.As<T, short>(), data1.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Transpose(data0.As<T, ushort>(), data1.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Transpose(data0.As<T, int>(), data1.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Transpose(data0.As<T, uint>(), data1.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Transpose(data0.As<T, long>(), data1.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Transpose(data0.As<T, ulong>(), data1.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>());
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(T).Name));
            }
        }

        /// <summary>
        /// Transpose a 2*2 matrix (对2*2矩阵进行转置).
        /// Mnemonic: <c>result0[i] := (0==(i&amp;1))?( x[i&amp;~1] ):( y[i&amp;~1] )</c>, <c>result1[i] := (0==(i&amp;1))?( x[(i&amp;~1) + 1] ):( y[(i&amp;~1) + 1] )</c>.
        /// </summary>
        /// <param name="data0">Part 0 of the vector data (向量数据的第0部分).</param>
        /// <param name="data1">Part 1 of the vector data (向量数据的第1部分).</param>
        /// <returns>Returns the transposed data (返回转置后数据).</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Result0, Vector<float> Result1) YGroup2Transpose(Vector<float> data0, Vector<float> data1) {
            var rt0 = YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Transpose(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Result0, Vector<double> Result1) YGroup2Transpose(Vector<double> data0, Vector<double> data1) {
            var rt0 = YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Transpose(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Result0, Vector<sbyte> Result1) YGroup2Transpose(Vector<sbyte> data0, Vector<sbyte> data1) {
            var rt0 = YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Transpose(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Result0, Vector<byte> Result1) YGroup2Transpose(Vector<byte> data0, Vector<byte> data1) {
            var rt0 = YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Transpose(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Result0, Vector<short> Result1) YGroup2Transpose(Vector<short> data0, Vector<short> data1) {
            var rt0 = YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Transpose(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Result0, Vector<ushort> Result1) YGroup2Transpose(Vector<ushort> data0, Vector<ushort> data1) {
            var rt0 = YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Transpose(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Result0, Vector<int> Result1) YGroup2Transpose(Vector<int> data0, Vector<int> data1) {
            var rt0 = YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Transpose(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Result0, Vector<uint> Result1) YGroup2Transpose(Vector<uint> data0, Vector<uint> data1) {
            var rt0 = YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Transpose(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Result0, Vector<long> Result1) YGroup2Transpose(Vector<long> data0, Vector<long> data1) {
            var rt0 = YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }

        /// <inheritdoc cref="YGroup2Transpose(Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Result0, Vector<ulong> Result1) YGroup2Transpose(Vector<ulong> data0, Vector<ulong> data1) {
            var rt0 = YGroup2Transpose(data0, data1, out var rt1);
            return (rt0, rt1);
        }


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
                (var rt0, var rt1) = YGroup2Unzip(data0.As<T, float>(), data1.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.As<T, double>(), data1.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.As<T, sbyte>(), data1.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.As<T, byte>(), data1.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.As<T, short>(), data1.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.As<T, ushort>(), data1.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.As<T, int>(), data1.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.As<T, uint>(), data1.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.As<T, long>(), data1.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.As<T, ulong>(), data1.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>());
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.ExAs<T, ExInt128>(), data1.ExAs<T, ExInt128>());
                return (rt0.ExAs<ExInt128, T>(), rt1.ExAs<ExInt128, T>());
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>());
                return (rt0.ExAs<ExUInt128, T>(), rt1.ExAs<ExUInt128, T>());
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.ExAs<T, Int128>(), data1.ExAs<T, Int128>());
                return (rt0.ExAs<Int128, T>(), rt1.ExAs<Int128, T>());
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1) = YGroup2Unzip(data0.ExAs<T, UInt128>(), data1.ExAs<T, UInt128>());
                return (rt0.ExAs<UInt128, T>(), rt1.ExAs<UInt128, T>());
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
                return YGroup2UnzipEven(data0.As<T, float>(), data1.As<T, float>()).As<float, T>();
            } else if (typeof(double) == typeof(T)) {
                return YGroup2UnzipEven(data0.As<T, double>(), data1.As<T, double>()).As<double, T>();
            } else if (typeof(sbyte) == typeof(T)) {
                return YGroup2UnzipEven(data0.As<T, sbyte>(), data1.As<T, sbyte>()).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T)) {
                return YGroup2UnzipEven(data0.As<T, byte>(), data1.As<T, byte>()).As<byte, T>();
            } else if (typeof(short) == typeof(T)) {
                return YGroup2UnzipEven(data0.As<T, short>(), data1.As<T, short>()).As<short, T>();
            } else if (typeof(ushort) == typeof(T)) {
                return YGroup2UnzipEven(data0.As<T, ushort>(), data1.As<T, ushort>()).As<ushort, T>();
            } else if (typeof(int) == typeof(T)) {
                return YGroup2UnzipEven(data0.As<T, int>(), data1.As<T, int>()).As<int, T>();
            } else if (typeof(uint) == typeof(T)) {
                return YGroup2UnzipEven(data0.As<T, uint>(), data1.As<T, uint>()).As<uint, T>();
            } else if (typeof(long) == typeof(T)) {
                return YGroup2UnzipEven(data0.As<T, long>(), data1.As<T, long>()).As<long, T>();
            } else if (typeof(ulong) == typeof(T)) {
                return YGroup2UnzipEven(data0.As<T, ulong>(), data1.As<T, ulong>()).As<ulong, T>();
            } else if (typeof(ExInt128) == typeof(T)) {
                return YGroup2UnzipEven(data0.ExAs<T, ExInt128>(), data1.ExAs<T, ExInt128>()).ExAs<ExInt128, T>();
            } else if (typeof(ExUInt128) == typeof(T)) {
                return YGroup2UnzipEven(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>()).ExAs<ExUInt128, T>();
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return YGroup2UnzipEven(data0.ExAs<T, Int128>(), data1.ExAs<T, Int128>()).ExAs<Int128, T>();
            } else if (typeof(UInt128) == typeof(T)) {
                return YGroup2UnzipEven(data0.ExAs<T, UInt128>(), data1.ExAs<T, UInt128>()).ExAs<UInt128, T>();
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
                return YGroup2UnzipOdd(data0.As<T, float>(), data1.As<T, float>()).As<float, T>();
            } else if (typeof(double) == typeof(T)) {
                return YGroup2UnzipOdd(data0.As<T, double>(), data1.As<T, double>()).As<double, T>();
            } else if (typeof(sbyte) == typeof(T)) {
                return YGroup2UnzipOdd(data0.As<T, sbyte>(), data1.As<T, sbyte>()).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T)) {
                return YGroup2UnzipOdd(data0.As<T, byte>(), data1.As<T, byte>()).As<byte, T>();
            } else if (typeof(short) == typeof(T)) {
                return YGroup2UnzipOdd(data0.As<T, short>(), data1.As<T, short>()).As<short, T>();
            } else if (typeof(ushort) == typeof(T)) {
                return YGroup2UnzipOdd(data0.As<T, ushort>(), data1.As<T, ushort>()).As<ushort, T>();
            } else if (typeof(int) == typeof(T)) {
                return YGroup2UnzipOdd(data0.As<T, int>(), data1.As<T, int>()).As<int, T>();
            } else if (typeof(uint) == typeof(T)) {
                return YGroup2UnzipOdd(data0.As<T, uint>(), data1.As<T, uint>()).As<uint, T>();
            } else if (typeof(long) == typeof(T)) {
                return YGroup2UnzipOdd(data0.As<T, long>(), data1.As<T, long>()).As<long, T>();
            } else if (typeof(ulong) == typeof(T)) {
                return YGroup2UnzipOdd(data0.As<T, ulong>(), data1.As<T, ulong>()).As<ulong, T>();
            } else if (typeof(ExInt128) == typeof(T)) {
                return YGroup2UnzipOdd(data0.ExAs<T, ExInt128>(), data1.ExAs<T, ExInt128>()).ExAs<ExInt128, T>();
            } else if (typeof(ExUInt128) == typeof(T)) {
                return YGroup2UnzipOdd(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>()).ExAs<ExUInt128, T>();
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return YGroup2UnzipOdd(data0.ExAs<T, Int128>(), data1.ExAs<T, Int128>()).ExAs<Int128, T>();
            } else if (typeof(UInt128) == typeof(T)) {
                return YGroup2UnzipOdd(data0.ExAs<T, UInt128>(), data1.ExAs<T, UInt128>()).ExAs<UInt128, T>();
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
                (var data0, var data1) = YGroup2Zip(x.As<T, float>(), y.As<T, float>());
                return (data0.As<float, T>(), data1.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.As<T, double>(), y.As<T, double>());
                return (data0.As<double, T>(), data1.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.As<T, sbyte>(), y.As<T, sbyte>());
                return (data0.As<sbyte, T>(), data1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.As<T, byte>(), y.As<T, byte>());
                return (data0.As<byte, T>(), data1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.As<T, short>(), y.As<T, short>());
                return (data0.As<short, T>(), data1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.As<T, ushort>(), y.As<T, ushort>());
                return (data0.As<ushort, T>(), data1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.As<T, int>(), y.As<T, int>());
                return (data0.As<int, T>(), data1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.As<T, uint>(), y.As<T, uint>());
                return (data0.As<uint, T>(), data1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.As<T, long>(), y.As<T, long>());
                return (data0.As<long, T>(), data1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.As<T, ulong>(), y.As<T, ulong>());
                return (data0.As<ulong, T>(), data1.As<ulong, T>());
            } else if (typeof(ExInt128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.ExAs<T, ExInt128>(), y.ExAs<T, ExInt128>());
                return (data0.ExAs<ExInt128, T>(), data1.ExAs<ExInt128, T>());
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.ExAs<T, ExUInt128>(), y.ExAs<T, ExUInt128>());
                return (data0.ExAs<ExUInt128, T>(), data1.ExAs<ExUInt128, T>());
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.ExAs<T, Int128>(), y.ExAs<T, Int128>());
                return (data0.ExAs<Int128, T>(), data1.ExAs<Int128, T>());
            } else if (typeof(UInt128) == typeof(T)) {
                (var data0, var data1) = YGroup2Zip(x.ExAs<T, UInt128>(), y.ExAs<T, UInt128>());
                return (data0.ExAs<UInt128, T>(), data1.ExAs<UInt128, T>());
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
                return YGroup2ZipHigh(data0.As<T, float>(), data1.As<T, float>()).As<float, T>();
            } else if (typeof(double) == typeof(T)) {
                return YGroup2ZipHigh(data0.As<T, double>(), data1.As<T, double>()).As<double, T>();
            } else if (typeof(sbyte) == typeof(T)) {
                return YGroup2ZipHigh(data0.As<T, sbyte>(), data1.As<T, sbyte>()).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T)) {
                return YGroup2ZipHigh(data0.As<T, byte>(), data1.As<T, byte>()).As<byte, T>();
            } else if (typeof(short) == typeof(T)) {
                return YGroup2ZipHigh(data0.As<T, short>(), data1.As<T, short>()).As<short, T>();
            } else if (typeof(ushort) == typeof(T)) {
                return YGroup2ZipHigh(data0.As<T, ushort>(), data1.As<T, ushort>()).As<ushort, T>();
            } else if (typeof(int) == typeof(T)) {
                return YGroup2ZipHigh(data0.As<T, int>(), data1.As<T, int>()).As<int, T>();
            } else if (typeof(uint) == typeof(T)) {
                return YGroup2ZipHigh(data0.As<T, uint>(), data1.As<T, uint>()).As<uint, T>();
            } else if (typeof(long) == typeof(T)) {
                return YGroup2ZipHigh(data0.As<T, long>(), data1.As<T, long>()).As<long, T>();
            } else if (typeof(ulong) == typeof(T)) {
                return YGroup2ZipHigh(data0.As<T, ulong>(), data1.As<T, ulong>()).As<ulong, T>();
            } else if (typeof(ExInt128) == typeof(T)) {
                return YGroup2ZipHigh(data0.ExAs<T, ExInt128>(), data1.ExAs<T, ExInt128>()).ExAs<ExInt128, T>();
            } else if (typeof(ExUInt128) == typeof(T)) {
                return YGroup2ZipHigh(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>()).ExAs<ExUInt128, T>();
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return YGroup2ZipHigh(data0.ExAs<T, Int128>(), data1.ExAs<T, Int128>()).ExAs<Int128, T>();
            } else if (typeof(UInt128) == typeof(T)) {
                return YGroup2ZipHigh(data0.ExAs<T, UInt128>(), data1.ExAs<T, UInt128>()).ExAs<UInt128, T>();
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
                return YGroup2ZipLow(data0.As<T, float>(), data1.As<T, float>()).As<float, T>();
            } else if (typeof(double) == typeof(T)) {
                return YGroup2ZipLow(data0.As<T, double>(), data1.As<T, double>()).As<double, T>();
            } else if (typeof(sbyte) == typeof(T)) {
                return YGroup2ZipLow(data0.As<T, sbyte>(), data1.As<T, sbyte>()).As<sbyte, T>();
            } else if (typeof(byte) == typeof(T)) {
                return YGroup2ZipLow(data0.As<T, byte>(), data1.As<T, byte>()).As<byte, T>();
            } else if (typeof(short) == typeof(T)) {
                return YGroup2ZipLow(data0.As<T, short>(), data1.As<T, short>()).As<short, T>();
            } else if (typeof(ushort) == typeof(T)) {
                return YGroup2ZipLow(data0.As<T, ushort>(), data1.As<T, ushort>()).As<ushort, T>();
            } else if (typeof(int) == typeof(T)) {
                return YGroup2ZipLow(data0.As<T, int>(), data1.As<T, int>()).As<int, T>();
            } else if (typeof(uint) == typeof(T)) {
                return YGroup2ZipLow(data0.As<T, uint>(), data1.As<T, uint>()).As<uint, T>();
            } else if (typeof(long) == typeof(T)) {
                return YGroup2ZipLow(data0.As<T, long>(), data1.As<T, long>()).As<long, T>();
            } else if (typeof(ulong) == typeof(T)) {
                return YGroup2ZipLow(data0.As<T, ulong>(), data1.As<T, ulong>()).As<ulong, T>();
            } else if (typeof(ExInt128) == typeof(T)) {
                return YGroup2ZipLow(data0.ExAs<T, ExInt128>(), data1.ExAs<T, ExInt128>()).ExAs<ExInt128, T>();
            } else if (typeof(ExUInt128) == typeof(T)) {
                return YGroup2ZipLow(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>()).ExAs<ExUInt128, T>();
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                return YGroup2ZipLow(data0.ExAs<T, Int128>(), data1.ExAs<T, Int128>()).ExAs<Int128, T>();
            } else if (typeof(UInt128) == typeof(T)) {
                return YGroup2ZipLow(data0.ExAs<T, UInt128>(), data1.ExAs<T, UInt128>()).ExAs<UInt128, T>();
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
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4(data0.As<T, float>(), data1.As<T, float>(), data2.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4(data0.As<T, double>(), data1.As<T, double>(), data2.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4(data0.As<T, sbyte>(), data1.As<T, sbyte>(), data2.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4(data0.As<T, byte>(), data1.As<T, byte>(), data2.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4(data0.As<T, short>(), data1.As<T, short>(), data2.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4(data0.As<T, ushort>(), data1.As<T, ushort>(), data2.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4(data0.As<T, int>(), data1.As<T, int>(), data2.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4(data0.As<T, uint>(), data1.As<T, uint>(), data2.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4(data0.As<T, long>(), data1.As<T, long>(), data2.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup3ToGroup4(data0.As<T, ulong>(), data1.As<T, ulong>(), data2.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>());
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
                (var rt0, var rt1, var rt2) = YGroup3Unzip(data0.As<T, float>(), data1.As<T, float>(), data2.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip(data0.As<T, double>(), data1.As<T, double>(), data2.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip(data0.As<T, sbyte>(), data1.As<T, sbyte>(), data2.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip(data0.As<T, byte>(), data1.As<T, byte>(), data2.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip(data0.As<T, short>(), data1.As<T, short>(), data2.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip(data0.As<T, ushort>(), data1.As<T, ushort>(), data2.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip(data0.As<T, int>(), data1.As<T, int>(), data2.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip(data0.As<T, uint>(), data1.As<T, uint>(), data2.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip(data0.As<T, long>(), data1.As<T, long>(), data2.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Unzip(data0.As<T, ulong>(), data1.As<T, ulong>(), data2.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>());
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
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2(data0.As<T, float>(), data1.As<T, float>(), data2.As<T, float>(), data3.As<T, float>(), data4.As<T, float>(), data5.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>(), rt4.As<float, T>(), rt5.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2(data0.As<T, double>(), data1.As<T, double>(), data2.As<T, double>(), data3.As<T, double>(), data4.As<T, double>(), data5.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>(), rt4.As<double, T>(), rt5.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2(data0.As<T, sbyte>(), data1.As<T, sbyte>(), data2.As<T, sbyte>(), data3.As<T, sbyte>(), data4.As<T, sbyte>(), data5.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>(), rt4.As<sbyte, T>(), rt5.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2(data0.As<T, byte>(), data1.As<T, byte>(), data2.As<T, byte>(), data3.As<T, byte>(), data4.As<T, byte>(), data5.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>(), rt4.As<byte, T>(), rt5.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2(data0.As<T, short>(), data1.As<T, short>(), data2.As<T, short>(), data3.As<T, short>(), data4.As<T, short>(), data5.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>(), rt4.As<short, T>(), rt5.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2(data0.As<T, ushort>(), data1.As<T, ushort>(), data2.As<T, ushort>(), data3.As<T, ushort>(), data4.As<T, ushort>(), data5.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>(), rt4.As<ushort, T>(), rt5.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2(data0.As<T, int>(), data1.As<T, int>(), data2.As<T, int>(), data3.As<T, int>(), data4.As<T, int>(), data5.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>(), rt4.As<int, T>(), rt5.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2(data0.As<T, uint>(), data1.As<T, uint>(), data2.As<T, uint>(), data3.As<T, uint>(), data4.As<T, uint>(), data5.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>(), rt4.As<uint, T>(), rt5.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2(data0.As<T, long>(), data1.As<T, long>(), data2.As<T, long>(), data3.As<T, long>(), data4.As<T, long>(), data5.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>(), rt4.As<long, T>(), rt5.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3UnzipX2(data0.As<T, ulong>(), data1.As<T, ulong>(), data2.As<T, ulong>(), data3.As<T, ulong>(), data4.As<T, ulong>(), data5.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>(), rt4.As<ulong, T>(), rt5.As<ulong, T>());
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
                (var rt0, var rt1, var rt2) = YGroup3Zip(x.As<T, float>(), y.As<T, float>(), z.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip(x.As<T, double>(), y.As<T, double>(), z.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip(x.As<T, sbyte>(), y.As<T, sbyte>(), z.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip(x.As<T, byte>(), y.As<T, byte>(), z.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip(x.As<T, short>(), y.As<T, short>(), z.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip(x.As<T, ushort>(), y.As<T, ushort>(), z.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip(x.As<T, int>(), y.As<T, int>(), z.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip(x.As<T, uint>(), y.As<T, uint>(), z.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip(x.As<T, long>(), y.As<T, long>(), z.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2) = YGroup3Zip(x.As<T, ulong>(), y.As<T, ulong>(), z.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>());
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
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2(x.As<T, float>(), xB.As<T, float>(), y.As<T, float>(), yB.As<T, float>(), z.As<T, float>(), zB.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>(), rt4.As<float, T>(), rt5.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2(x.As<T, double>(), xB.As<T, double>(), y.As<T, double>(), yB.As<T, double>(), z.As<T, double>(), zB.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>(), rt4.As<double, T>(), rt5.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2(x.As<T, sbyte>(), xB.As<T, sbyte>(), y.As<T, sbyte>(), yB.As<T, sbyte>(), z.As<T, sbyte>(), zB.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>(), rt4.As<sbyte, T>(), rt5.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2(x.As<T, byte>(), xB.As<T, byte>(), y.As<T, byte>(), yB.As<T, byte>(), z.As<T, byte>(), zB.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>(), rt4.As<byte, T>(), rt5.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2(x.As<T, short>(), xB.As<T, short>(), y.As<T, short>(), yB.As<T, short>(), z.As<T, short>(), zB.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>(), rt4.As<short, T>(), rt5.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2(x.As<T, ushort>(), xB.As<T, ushort>(), y.As<T, ushort>(), yB.As<T, ushort>(), z.As<T, ushort>(), zB.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>(), rt4.As<ushort, T>(), rt5.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2(x.As<T, int>(), xB.As<T, int>(), y.As<T, int>(), yB.As<T, int>(), z.As<T, int>(), zB.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>(), rt4.As<int, T>(), rt5.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2(x.As<T, uint>(), xB.As<T, uint>(), y.As<T, uint>(), yB.As<T, uint>(), z.As<T, uint>(), zB.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>(), rt4.As<uint, T>(), rt5.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2(x.As<T, long>(), xB.As<T, long>(), y.As<T, long>(), yB.As<T, long>(), z.As<T, long>(), zB.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>(), rt4.As<long, T>(), rt5.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3, var rt4, var rt5) = YGroup3ZipX2(x.As<T, ulong>(), xB.As<T, ulong>(), y.As<T, ulong>(), yB.As<T, ulong>(), z.As<T, ulong>(), zB.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>(), rt4.As<ulong, T>(), rt5.As<ulong, T>());
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


        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        /// <typeparam name="T">The element type of the input parameter (输入参数的元素类型).</typeparam>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<T> Result0, Vector<T> Result1, Vector<T> Result2) YGroup4ToGroup3<T>(Vector<T> data0, Vector<T> data1, Vector<T> data2, Vector<T> data3) where T : struct {
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
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<float> Result0, Vector<float> Result1, Vector<float> Result2) YGroup4ToGroup3(Vector<float> data0, Vector<float> data1, Vector<float> data2, Vector<float> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<double> Result0, Vector<double> Result1, Vector<double> Result2) YGroup4ToGroup3(Vector<double> data0, Vector<double> data1, Vector<double> data2, Vector<double> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<sbyte> Result0, Vector<sbyte> Result1, Vector<sbyte> Result2) YGroup4ToGroup3(Vector<sbyte> data0, Vector<sbyte> data1, Vector<sbyte> data2, Vector<sbyte> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<byte> Result0, Vector<byte> Result1, Vector<byte> Result2) YGroup4ToGroup3(Vector<byte> data0, Vector<byte> data1, Vector<byte> data2, Vector<byte> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<short> Result0, Vector<short> Result1, Vector<short> Result2) YGroup4ToGroup3(Vector<short> data0, Vector<short> data1, Vector<short> data2, Vector<short> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ushort> Result0, Vector<ushort> Result1, Vector<ushort> Result2) YGroup4ToGroup3(Vector<ushort> data0, Vector<ushort> data1, Vector<ushort> data2, Vector<ushort> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<int> Result0, Vector<int> Result1, Vector<int> Result2) YGroup4ToGroup3(Vector<int> data0, Vector<int> data1, Vector<int> data2, Vector<int> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<uint> Result0, Vector<uint> Result1, Vector<uint> Result2) YGroup4ToGroup3(Vector<uint> data0, Vector<uint> data1, Vector<uint> data2, Vector<uint> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<long> Result0, Vector<long> Result1, Vector<long> Result2) YGroup4ToGroup3(Vector<long> data0, Vector<long> data1, Vector<long> data2, Vector<long> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
        }

        /// <inheritdoc cref="YGroup4ToGroup3(Vector{float}, Vector{float}, Vector{float}, Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector<ulong> Result0, Vector<ulong> Result1, Vector<ulong> Result2) YGroup4ToGroup3(Vector<ulong> data0, Vector<ulong> data1, Vector<ulong> data2, Vector<ulong> data3) {
            var rt0 = YGroup4ToGroup3(data0, data1, data2, data3, out var rt1, out var rt2);
            return (rt0, rt1, rt2);
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
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.As<T, float>(), data1.As<T, float>(), data2.As<T, float>(), data3.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.As<T, double>(), data1.As<T, double>(), data2.As<T, double>(), data3.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.As<T, sbyte>(), data1.As<T, sbyte>(), data2.As<T, sbyte>(), data3.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.As<T, byte>(), data1.As<T, byte>(), data2.As<T, byte>(), data3.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.As<T, short>(), data1.As<T, short>(), data2.As<T, short>(), data3.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.As<T, ushort>(), data1.As<T, ushort>(), data2.As<T, ushort>(), data3.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.As<T, int>(), data1.As<T, int>(), data2.As<T, int>(), data3.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.As<T, uint>(), data1.As<T, uint>(), data2.As<T, uint>(), data3.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.As<T, long>(), data1.As<T, long>(), data2.As<T, long>(), data3.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.As<T, ulong>(), data1.As<T, ulong>(), data2.As<T, ulong>(), data3.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>());
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.ExAs<T, ExInt128>(), data1.ExAs<T, ExInt128>(), data2.ExAs<T, ExInt128>(), data3.ExAs<T, ExInt128>());
                return (rt0.ExAs<ExInt128, T>(), rt1.ExAs<ExInt128, T>(), rt2.ExAs<ExInt128, T>(), rt3.ExAs<ExInt128, T>());
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.ExAs<T, ExUInt128>(), data1.ExAs<T, ExUInt128>(), data2.ExAs<T, ExUInt128>(), data3.ExAs<T, ExUInt128>());
                return (rt0.ExAs<ExUInt128, T>(), rt1.ExAs<ExUInt128, T>(), rt2.ExAs<ExUInt128, T>(), rt3.ExAs<ExUInt128, T>());
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.ExAs<T, Int128>(), data1.ExAs<T, Int128>(), data2.ExAs<T, Int128>(), data3.ExAs<T, Int128>());
                return (rt0.ExAs<Int128, T>(), rt1.ExAs<Int128, T>(), rt2.ExAs<Int128, T>(), rt3.ExAs<Int128, T>());
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Unzip(data0.ExAs<T, UInt128>(), data1.ExAs<T, UInt128>(), data2.ExAs<T, UInt128>(), data3.ExAs<T, UInt128>());
                return (rt0.ExAs<UInt128, T>(), rt1.ExAs<UInt128, T>(), rt2.ExAs<UInt128, T>(), rt3.ExAs<UInt128, T>());
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
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.As<T, float>(), y.As<T, float>(), z.As<T, float>(), w.As<T, float>());
                return (rt0.As<float, T>(), rt1.As<float, T>(), rt2.As<float, T>(), rt3.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.As<T, double>(), y.As<T, double>(), z.As<T, double>(), w.As<T, double>());
                return (rt0.As<double, T>(), rt1.As<double, T>(), rt2.As<double, T>(), rt3.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.As<T, sbyte>(), y.As<T, sbyte>(), z.As<T, sbyte>(), w.As<T, sbyte>());
                return (rt0.As<sbyte, T>(), rt1.As<sbyte, T>(), rt2.As<sbyte, T>(), rt3.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.As<T, byte>(), y.As<T, byte>(), z.As<T, byte>(), w.As<T, byte>());
                return (rt0.As<byte, T>(), rt1.As<byte, T>(), rt2.As<byte, T>(), rt3.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.As<T, short>(), y.As<T, short>(), z.As<T, short>(), w.As<T, short>());
                return (rt0.As<short, T>(), rt1.As<short, T>(), rt2.As<short, T>(), rt3.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.As<T, ushort>(), y.As<T, ushort>(), z.As<T, ushort>(), w.As<T, ushort>());
                return (rt0.As<ushort, T>(), rt1.As<ushort, T>(), rt2.As<ushort, T>(), rt3.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.As<T, int>(), y.As<T, int>(), z.As<T, int>(), w.As<T, int>());
                return (rt0.As<int, T>(), rt1.As<int, T>(), rt2.As<int, T>(), rt3.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.As<T, uint>(), y.As<T, uint>(), z.As<T, uint>(), w.As<T, uint>());
                return (rt0.As<uint, T>(), rt1.As<uint, T>(), rt2.As<uint, T>(), rt3.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.As<T, long>(), y.As<T, long>(), z.As<T, long>(), w.As<T, long>());
                return (rt0.As<long, T>(), rt1.As<long, T>(), rt2.As<long, T>(), rt3.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.As<T, ulong>(), y.As<T, ulong>(), z.As<T, ulong>(), w.As<T, ulong>());
                return (rt0.As<ulong, T>(), rt1.As<ulong, T>(), rt2.As<ulong, T>(), rt3.As<ulong, T>());
            } else if (typeof(ExInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.ExAs<T, ExInt128>(), y.ExAs<T, ExInt128>(), z.ExAs<T, ExInt128>(), w.ExAs<T, ExInt128>());
                return (rt0.ExAs<ExInt128, T>(), rt1.ExAs<ExInt128, T>(), rt2.ExAs<ExInt128, T>(), rt3.ExAs<ExInt128, T>());
            } else if (typeof(ExUInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.ExAs<T, ExUInt128>(), y.ExAs<T, ExUInt128>(), z.ExAs<T, ExUInt128>(), w.ExAs<T, ExUInt128>());
                return (rt0.ExAs<ExUInt128, T>(), rt1.ExAs<ExUInt128, T>(), rt2.ExAs<ExUInt128, T>(), rt3.ExAs<ExUInt128, T>());
#if BCL_TYPE_INT128
            } else if (typeof(Int128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.ExAs<T, Int128>(), y.ExAs<T, Int128>(), z.ExAs<T, Int128>(), w.ExAs<T, Int128>());
                return (rt0.ExAs<Int128, T>(), rt1.ExAs<Int128, T>(), rt2.ExAs<Int128, T>(), rt3.ExAs<Int128, T>());
            } else if (typeof(UInt128) == typeof(T)) {
                (var rt0, var rt1, var rt2, var rt3) = YGroup4Zip(x.ExAs<T, UInt128>(), y.ExAs<T, UInt128>(), z.ExAs<T, UInt128>(), w.ExAs<T, UInt128>());
                return (rt0.ExAs<UInt128, T>(), rt1.ExAs<UInt128, T>(), rt2.ExAs<UInt128, T>(), rt3.ExAs<UInt128, T>());
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

    }
}
