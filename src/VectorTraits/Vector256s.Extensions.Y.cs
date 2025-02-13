﻿#if NET7_0_OR_GREATER
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
    static partial class Vector256s {

#if NETCOREAPP3_0_OR_GREATER

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
        /// <seealso cref="YShuffleG4X2(Vector256{float}, Vector256{float}, ShuffleControlG4, out Vector256{float})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector256<T> Result0, Vector256<T> Result1) YShuffleG4X2<T>(Vector256<T> source0, Vector256<T> source1, ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2(source0.As<T, float>(), source1.As<T, float>(), control);
                return (result0.As<float, T>(), result1.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2(source0.As<T, double>(), source1.As<T, double>(), control);
                return (result0.As<double, T>(), result1.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2(source0.As<T, sbyte>(), source1.As<T, sbyte>(), control);
                return (result0.As<sbyte, T>(), result1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2(source0.As<T, byte>(), source1.As<T, byte>(), control);
                return (result0.As<byte, T>(), result1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2(source0.As<T, short>(), source1.As<T, short>(), control);
                return (result0.As<short, T>(), result1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2(source0.As<T, ushort>(), source1.As<T, ushort>(), control);
                return (result0.As<ushort, T>(), result1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2(source0.As<T, int>(), source1.As<T, int>(), control);
                return (result0.As<int, T>(), result1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2(source0.As<T, uint>(), source1.As<T, uint>(), control);
                return (result0.As<uint, T>(), result1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2(source0.As<T, long>(), source1.As<T, long>(), control);
                return (result0.As<long, T>(), result1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2(source0.As<T, ulong>(), source1.As<T, ulong>(), control);
                return (result0.As<ulong, T>(), result1.As<ulong, T>());
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
        public static (Vector256<float> Result0, Vector256<float> Result1) YShuffleG4X2(Vector256<float> source0, Vector256<float> source1, ShuffleControlG4 control) {
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
        public static (Vector256<double> Result0, Vector256<double> Result1) YShuffleG4X2(Vector256<double> source0, Vector256<double> source1, ShuffleControlG4 control) {
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
        public static (Vector256<sbyte> Result0, Vector256<sbyte> Result1) YShuffleG4X2(Vector256<sbyte> source0, Vector256<sbyte> source1, ShuffleControlG4 control) {
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
        public static (Vector256<byte> Result0, Vector256<byte> Result1) YShuffleG4X2(Vector256<byte> source0, Vector256<byte> source1, ShuffleControlG4 control) {
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
        public static (Vector256<short> Result0, Vector256<short> Result1) YShuffleG4X2(Vector256<short> source0, Vector256<short> source1, ShuffleControlG4 control) {
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
        public static (Vector256<ushort> Result0, Vector256<ushort> Result1) YShuffleG4X2(Vector256<ushort> source0, Vector256<ushort> source1, ShuffleControlG4 control) {
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
        public static (Vector256<int> Result0, Vector256<int> Result1) YShuffleG4X2(Vector256<int> source0, Vector256<int> source1, ShuffleControlG4 control) {
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
        public static (Vector256<uint> Result0, Vector256<uint> Result1) YShuffleG4X2(Vector256<uint> source0, Vector256<uint> source1, ShuffleControlG4 control) {
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
        public static (Vector256<long> Result0, Vector256<long> Result1) YShuffleG4X2(Vector256<long> source0, Vector256<long> source1, ShuffleControlG4 control) {
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
        public static (Vector256<ulong> Result0, Vector256<ulong> Result1) YShuffleG4X2(Vector256<ulong> source0, Vector256<ulong> source1, ShuffleControlG4 control) {
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
        /// <seealso cref="YShuffleG4X2_Const(Vector256{int}, Vector256{int}, ShuffleControlG4, out Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector256<T> Result0, Vector256<T> Result1) YShuffleG4X2_Const<T>(Vector256<T> source0, Vector256<T> source1, [ConstantExpected] ShuffleControlG4 control) where T : struct {
            if (typeof(float) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const(source0.As<T, float>(), source1.As<T, float>(), control);
                return (result0.As<float, T>(), result1.As<float, T>());
            } else if (typeof(double) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const(source0.As<T, double>(), source1.As<T, double>(), control);
                return (result0.As<double, T>(), result1.As<double, T>());
            } else if (typeof(sbyte) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const(source0.As<T, sbyte>(), source1.As<T, sbyte>(), control);
                return (result0.As<sbyte, T>(), result1.As<sbyte, T>());
            } else if (typeof(byte) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const(source0.As<T, byte>(), source1.As<T, byte>(), control);
                return (result0.As<byte, T>(), result1.As<byte, T>());
            } else if (typeof(short) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const(source0.As<T, short>(), source1.As<T, short>(), control);
                return (result0.As<short, T>(), result1.As<short, T>());
            } else if (typeof(ushort) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const(source0.As<T, ushort>(), source1.As<T, ushort>(), control);
                return (result0.As<ushort, T>(), result1.As<ushort, T>());
            } else if (typeof(int) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const(source0.As<T, int>(), source1.As<T, int>(), control);
                return (result0.As<int, T>(), result1.As<int, T>());
            } else if (typeof(uint) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const(source0.As<T, uint>(), source1.As<T, uint>(), control);
                return (result0.As<uint, T>(), result1.As<uint, T>());
            } else if (typeof(long) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const(source0.As<T, long>(), source1.As<T, long>(), control);
                return (result0.As<long, T>(), result1.As<long, T>());
            } else if (typeof(ulong) == typeof(T)) {
                (var result0, var result1) = YShuffleG4X2_Const(source0.As<T, ulong>(), source1.As<T, ulong>(), control);
                return (result0.As<ulong, T>(), result1.As<ulong, T>());
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
        public static (Vector256<float> Result0, Vector256<float> Result1) YShuffleG4X2_Const(Vector256<float> source0, Vector256<float> source1, [ConstantExpected] ShuffleControlG4 control) {
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
        public static (Vector256<double> Result0, Vector256<double> Result1) YShuffleG4X2_Const(Vector256<double> source0, Vector256<double> source1, [ConstantExpected] ShuffleControlG4 control) {
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
        public static (Vector256<sbyte> Result0, Vector256<sbyte> Result1) YShuffleG4X2_Const(Vector256<sbyte> source0, Vector256<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
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
        public static (Vector256<byte> Result0, Vector256<byte> Result1) YShuffleG4X2_Const(Vector256<byte> source0, Vector256<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
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
        public static (Vector256<short> Result0, Vector256<short> Result1) YShuffleG4X2_Const(Vector256<short> source0, Vector256<short> source1, [ConstantExpected] ShuffleControlG4 control) {
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
        public static (Vector256<ushort> Result0, Vector256<ushort> Result1) YShuffleG4X2_Const(Vector256<ushort> source0, Vector256<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
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
        public static (Vector256<int> Result0, Vector256<int> Result1) YShuffleG4X2_Const(Vector256<int> source0, Vector256<int> source1, [ConstantExpected] ShuffleControlG4 control) {
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
        public static (Vector256<uint> Result0, Vector256<uint> Result1) YShuffleG4X2_Const(Vector256<uint> source0, Vector256<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
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
        public static (Vector256<long> Result0, Vector256<long> Result1) YShuffleG4X2_Const(Vector256<long> source0, Vector256<long> source1, [ConstantExpected] ShuffleControlG4 control) {
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
        public static (Vector256<ulong> Result0, Vector256<ulong> Result1) YShuffleG4X2_Const(Vector256<ulong> source0, Vector256<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleInsert_Args<TIdx>(Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2) = YShuffleInsert_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="Vector256s.YShuffleInsert_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2) YShuffleInsert_Args<TIdx>(Vector256<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2) YShuffleInsert_Args(Vector256<sbyte> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2) YShuffleInsert_Args(Vector256<byte> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2) YShuffleInsert_Args(Vector256<short> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2) YShuffleInsert_Args(Vector256<ushort> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) YShuffleInsert_Args(Vector256<int> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2) YShuffleInsert_Args(Vector256<uint> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) YShuffleInsert_Args(Vector256<long> indices) {
            YShuffleInsert_Args(indices, out var a0, out var a1, out var a2);
            return (a0, a1, a2);
        }

        /// <summary>
        /// Arguments calculation for shuffle and insert (换位并插入的参数计算). Provide arguments for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数). If the index value is out of range, the elements of the background vector will be inserted (若索引值超出范围, 会插入背景向量的元素).
        /// Mnemonic: <c>rt[i] := (0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count)?( vector[indices[i]] ):back[i]</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleInsert_Core (为 YShuffleInsert_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2) YShuffleInsert_Args(Vector256<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleInsert_Core(Vector256<float> back, Vector256<float> vector, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleInsert_Core(Vector256<double> back, Vector256<double> vector, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleInsert_Core(Vector256<sbyte> back, Vector256<sbyte> vector, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleInsert_Core(Vector256<byte> back, Vector256<byte> vector, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleInsert_Core(Vector256<short> back, Vector256<short> vector, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleInsert_Core(Vector256<ushort> back, Vector256<ushort> vector, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleInsert_Core(Vector256<int> back, Vector256<int> vector, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleInsert_Core(Vector256<uint> back, Vector256<uint> vector, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleInsert_Core(Vector256<long> back, Vector256<long> vector, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleInsert_Core(Vector256<ulong> back, Vector256<ulong> vector, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleKernel_Args<TIdx>(Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1) = YShuffleKernel_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1) = YShuffleKernel_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1) = YShuffleKernel_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1) = YShuffleKernel_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1) = YShuffleKernel_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1) = YShuffleKernel_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1) = YShuffleKernel_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1) = YShuffleKernel_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
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
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="Vector256s.YShuffleKernel_Args{TIdx}(Vector256{TIdx}, out Vector256{TIdx}, out Vector256{TIdx})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1) YShuffleKernel_Args<TIdx>(Vector256<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1) YShuffleKernel_Args(Vector256<sbyte> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1) YShuffleKernel_Args(Vector256<byte> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1) YShuffleKernel_Args(Vector256<short> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1) YShuffleKernel_Args(Vector256<ushort> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1) YShuffleKernel_Args(Vector256<int> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1) YShuffleKernel_Args(Vector256<uint> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1) YShuffleKernel_Args(Vector256<long> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }

        /// <summary>
        /// Arguments calculation for only shuffle (仅换位的参数计算). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1) YShuffleKernel_Args(Vector256<ulong> indices) {
            YShuffleKernel_Args(indices, out var a, out var b);
            return (a, b);
        }


        // -- YShuffleKernel_ArgsX: Vector256X2 --
#if ALLOW_VECTOR_TUPLES
        /// <summary>
        /// Arguments calculation for only shuffle - X (仅换位的参数计算 - X). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<sbyte> YShuffleKernel_ArgsX(Vector256<sbyte> indices) {
            return new Vector256X2<sbyte>(YShuffleKernel_Args(indices));
        }

        /// <summary>
        /// Arguments calculation for only shuffle - X (仅换位的参数计算 - X). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<byte> YShuffleKernel_ArgsX(Vector256<byte> indices) {
            return new Vector256X2<byte>(YShuffleKernel_Args(indices));
        }

        /// <summary>
        /// Arguments calculation for only shuffle - X (仅换位的参数计算 - X). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<short> YShuffleKernel_ArgsX(Vector256<short> indices) {
            return new Vector256X2<short>(YShuffleKernel_Args(indices));
        }

        /// <summary>
        /// Arguments calculation for only shuffle - X (仅换位的参数计算 - X). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<ushort> YShuffleKernel_ArgsX(Vector256<ushort> indices) {
            return new Vector256X2<ushort>(YShuffleKernel_Args(indices));
        }

        /// <summary>
        /// Arguments calculation for only shuffle - X (仅换位的参数计算 - X). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<int> YShuffleKernel_ArgsX(Vector256<int> indices) {
            return new Vector256X2<int>(YShuffleKernel_Args(indices));
        }

        /// <summary>
        /// Arguments calculation for only shuffle - X (仅换位的参数计算 - X). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<uint> YShuffleKernel_ArgsX(Vector256<uint> indices) {
            return new Vector256X2<uint>(YShuffleKernel_Args(indices));
        }

        /// <summary>
        /// Arguments calculation for only shuffle - X (仅换位的参数计算 - X). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<long> YShuffleKernel_ArgsX(Vector256<long> indices) {
            return new Vector256X2<long>(YShuffleKernel_Args(indices));
        }

        /// <summary>
        /// Arguments calculation for only shuffle - X (仅换位的参数计算 - X). Provide arguments for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vectors{T}.IndexMask"/> to constrain the parameters (可使用 <see cref="Vectors{T}.IndexMask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from <paramref name="vector" /> (用于从 <paramref name="vector" /> 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleKernel_Core (为 YShuffleKernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256X2<ulong> YShuffleKernel_ArgsX(Vector256<ulong> indices) {
            return new Vector256X2<ulong>(YShuffleKernel_Args(indices));
        }


        // -- YShuffleKernel_Core: Vector256X2 --
        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleKernel_Core(Vector256<float> vector, Vector256X2<int> args) {
            return YShuffleKernel_Core(vector, args.Val.Item1, args.Val.Item2);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleKernel_Core(Vector256<double> vector, Vector256X2<long> args) {
            return YShuffleKernel_Core(vector, args.Val.Item1, args.Val.Item2);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleKernel_Core(Vector256<sbyte> vector, Vector256X2<sbyte> args) {
            return YShuffleKernel_Core(vector, args.Val.Item1, args.Val.Item2);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleKernel_Core(Vector256<byte> vector, Vector256X2<byte> args) {
            return YShuffleKernel_Core(vector, args.Val.Item1, args.Val.Item2);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleKernel_Core(Vector256<short> vector, Vector256X2<short> args) {
            return YShuffleKernel_Core(vector, args.Val.Item1, args.Val.Item2);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{ushort}, Vector256X2{ushort}, Vector256{ushort})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleKernel_Core(Vector256<ushort> vector, Vector256X2<ushort> args) {
            return YShuffleKernel_Core(vector, args.Val.Item1, args.Val.Item2);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleKernel_Core(Vector256<int> vector, Vector256X2<int> args) {
            return YShuffleKernel_Core(vector, args.Val.Item1, args.Val.Item2);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleKernel_Core(Vector256<uint> vector, Vector256X2<uint> args) {
            return YShuffleKernel_Core(vector, args.Val.Item1, args.Val.Item2);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleKernel_Core(Vector256<long> vector, Vector256X2<long> args) {
            return YShuffleKernel_Core(vector, args.Val.Item1, args.Val.Item2);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [Obsolete("It has poor performance and is only suitable for unit testing. In general, it is recommended to use the non-X version of the methods (它的性能较差, 仅适用于单元测试. 一般情况下, 建议使用非X版方法).")]
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleKernel_Core(Vector256<ulong> vector, Vector256X2<ulong> args) {
            return YShuffleKernel_Core(vector, args.Val.Item1, args.Val.Item2);
        }
#endif // ALLOW_VECTOR_TUPLES


        // -- YShuffleKernel_Core: ValueTuple --
        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleKernel_Core(Vector256<float> vector, (Vector256<int> args0, Vector256<int> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleKernel_Core(Vector256<double> vector, (Vector256<long> args0, Vector256<long> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleKernel_Core(Vector256<sbyte> vector, (Vector256<sbyte> args0, Vector256<sbyte> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleKernel_Core(Vector256<byte> vector, (Vector256<byte> args0, Vector256<byte> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleKernel_Core(Vector256<short> vector, (Vector256<short> args0, Vector256<short> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleKernel_Core(Vector256<ushort> vector, (Vector256<ushort> args0, Vector256<ushort> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleKernel_Core(Vector256<int> vector, (Vector256<int> args0, Vector256<int> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleKernel_Core(Vector256<uint> vector, (Vector256<uint> args0, Vector256<uint> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleKernel_Core(Vector256<long> vector, (Vector256<long> args0, Vector256<long> args1) args) {
            return YShuffleKernel_Core(vector, args.args0, args.args1);
        }

        /// <summary>
        /// Core calculation for only shuffle (仅换位的核心计算). Its arguments are derived from YShuffleKernel_Args (其参数来源于 YShuffleKernel_Args).
        /// Mnemonic: <c>rt[i] := vector[indices[i]]</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;Count</c>.
        /// </summary>
        /// <param name="vector">The input vector from which values are selected (从中选择值的输入向量).</param>
        /// <param name="args">The arguments(参数). Derived from YShuffleKernel_Args .</param>
        /// <returns>A new vector containing the values from <paramref name="vector" /> selected by the given <c>indices</c> (一个新向量，其中包含给定 <c>indices</c> 从 <paramref name="vector" /> 中选择的值).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleKernel_Core(Vector256<ulong> vector, (Vector256<ulong> args0, Vector256<ulong> args1) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX2_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX2_Args<TIdx>(Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3, out Vector256<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
                args4 = a4.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
                args4 = a4.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
                args4 = a4.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
                args4 = a4.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
                args4 = a4.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
                args4 = a4.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
                args4 = a4.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
                args4 = a4.As<ulong, TIdx>();
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
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) YShuffleX2_Args<TIdx>(Vector256<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits256.YShuffleX2_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) YShuffleX2_Args(Vector256<sbyte> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) YShuffleX2_Args(Vector256<byte> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) YShuffleX2_Args(Vector256<short> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) YShuffleX2_Args(Vector256<ushort> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) YShuffleX2_Args(Vector256<int> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) YShuffleX2_Args(Vector256<uint> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) YShuffleX2_Args(Vector256<long> indices) {
            YShuffleX2_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) YShuffleX2_Args(Vector256<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX2_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX2_Core(Vector256<float> vector0, Vector256<float> vector1, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX2_Core(Vector256<double> vector0, Vector256<double> vector1, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX2_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX2_Core(Vector256<byte> vector0, Vector256<byte> vector1, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX2_Core(Vector256<short> vector0, Vector256<short> vector1, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX2_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX2_Core(Vector256<int> vector0, Vector256<int> vector1, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX2_Core(Vector256<uint> vector0, Vector256<uint> vector1, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX2_Core(Vector256<long> vector0, Vector256<long> vector1, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return YShuffleX2_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX2_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX2Insert_Args<TIdx>(Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3, out Vector256<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2Insert_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
                args4 = a4.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2Insert_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
                args4 = a4.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2Insert_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
                args4 = a4.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2Insert_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
                args4 = a4.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2Insert_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
                args4 = a4.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2Insert_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
                args4 = a4.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2Insert_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
                args4 = a4.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX2Insert_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
                args4 = a4.As<ulong, TIdx>();
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
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) YShuffleX2Insert_Args<TIdx>(Vector256<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) YShuffleX2Insert_Args(Vector256<sbyte> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) YShuffleX2Insert_Args(Vector256<byte> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) YShuffleX2Insert_Args(Vector256<short> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) YShuffleX2Insert_Args(Vector256<ushort> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) YShuffleX2Insert_Args(Vector256<int> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) YShuffleX2Insert_Args(Vector256<uint> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) YShuffleX2Insert_Args(Vector256<long> indices) {
            YShuffleX2Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) YShuffleX2Insert_Args(Vector256<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX2Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX2Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX2Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX2Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX2Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX2Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX2Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX2Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX2Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX2Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) args) {
            return YShuffleX2Insert_Core(back, vector0, vector1, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <summary>
        /// Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector256s{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vector256s{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX2Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX2Kernel_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX2Kernel_Args<TIdx>(Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX2Kernel_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX2Kernel_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX2Kernel_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX2Kernel_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX2Kernel_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX2Kernel_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX2Kernel_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX2Kernel_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector256s{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vector256s{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3) YShuffleX2Kernel_Args<TIdx>(Vector256<TIdx> indices)
                where TIdx : struct {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 2 vectors (在2个向量上进行仅换位的参数计算). Provide arguments for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector256s{T}.IndexX2Mask"/> to constrain the parameters (可使用 <see cref="Vector256s{T}.IndexX2Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*2)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX2Kernel_Core (为 YShuffleX2Kernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) YShuffleX2Kernel_Args(Vector256<sbyte> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) YShuffleX2Kernel_Args(Vector256<byte> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) YShuffleX2Kernel_Args(Vector256<short> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) YShuffleX2Kernel_Args(Vector256<ushort> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) YShuffleX2Kernel_Args(Vector256<int> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) YShuffleX2Kernel_Args(Vector256<uint> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) YShuffleX2Kernel_Args(Vector256<long> indices) {
            YShuffleX2Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) YShuffleX2Kernel_Args(Vector256<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX2Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX2Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX2Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX2Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX2Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX2Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX2Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX2Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX2Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) args) {
            return YShuffleX2Kernel_Core(vector0, vector1, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX2Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX3_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX3_Args<TIdx>(Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3, out Vector256<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
                args4 = a4.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
                args4 = a4.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
                args4 = a4.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
                args4 = a4.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
                args4 = a4.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
                args4 = a4.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
                args4 = a4.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
                args4 = a4.As<ulong, TIdx>();
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
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) YShuffleX3_Args<TIdx>(Vector256<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits256.YShuffleX3_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) YShuffleX3_Args(Vector256<sbyte> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) YShuffleX3_Args(Vector256<byte> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) YShuffleX3_Args(Vector256<short> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) YShuffleX3_Args(Vector256<ushort> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) YShuffleX3_Args(Vector256<int> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) YShuffleX3_Args(Vector256<uint> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) YShuffleX3_Args(Vector256<long> indices) {
            YShuffleX3_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) YShuffleX3_Args(Vector256<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX3_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX3_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX3_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX3_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX3_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX3_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX3_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX3_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX3_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX3_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return YShuffleX3_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX3_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX3Insert_Args<TIdx>(Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3, out Vector256<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3Insert_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
                args4 = a4.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3Insert_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
                args4 = a4.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3Insert_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
                args4 = a4.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3Insert_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
                args4 = a4.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3Insert_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
                args4 = a4.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3Insert_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
                args4 = a4.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3Insert_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
                args4 = a4.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX3Insert_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
                args4 = a4.As<ulong, TIdx>();
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
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) YShuffleX3Insert_Args<TIdx>(Vector256<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) YShuffleX3Insert_Args(Vector256<sbyte> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) YShuffleX3Insert_Args(Vector256<byte> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) YShuffleX3Insert_Args(Vector256<short> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) YShuffleX3Insert_Args(Vector256<ushort> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) YShuffleX3Insert_Args(Vector256<int> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) YShuffleX3Insert_Args(Vector256<uint> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) YShuffleX3Insert_Args(Vector256<long> indices) {
            YShuffleX3Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) YShuffleX3Insert_Args(Vector256<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX3Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX3Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX3Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX3Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX3Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX3Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX3Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX3Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX3Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return YShuffleX3Insert_Core(back, vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX3Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX3Kernel_Args<TIdx>(Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX3Kernel_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX3Kernel_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX3Kernel_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX3Kernel_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX3Kernel_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX3Kernel_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX3Kernel_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX3Kernel_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
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
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3) YShuffleX3Kernel_Args<TIdx>(Vector256<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) YShuffleX3Kernel_Args(Vector256<sbyte> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) YShuffleX3Kernel_Args(Vector256<byte> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) YShuffleX3Kernel_Args(Vector256<short> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) YShuffleX3Kernel_Args(Vector256<ushort> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) YShuffleX3Kernel_Args(Vector256<int> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) YShuffleX3Kernel_Args(Vector256<uint> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) YShuffleX3Kernel_Args(Vector256<long> indices) {
            YShuffleX3Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) YShuffleX3Kernel_Args(Vector256<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX3Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX3Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX3Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX3Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX3Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX3Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX3Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX3Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX3Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) args) {
            return YShuffleX3Kernel_Core(vector0, vector1, vector2, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX3Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX4_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX4_Args<TIdx>(Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3, out Vector256<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
                args4 = a4.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
                args4 = a4.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
                args4 = a4.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
                args4 = a4.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
                args4 = a4.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
                args4 = a4.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
                args4 = a4.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
                args4 = a4.As<ulong, TIdx>();
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
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) YShuffleX4_Args<TIdx>(Vector256<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits256.YShuffleX4_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) YShuffleX4_Args(Vector256<sbyte> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) YShuffleX4_Args(Vector256<byte> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) YShuffleX4_Args(Vector256<short> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) YShuffleX4_Args(Vector256<ushort> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) YShuffleX4_Args(Vector256<int> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) YShuffleX4_Args(Vector256<uint> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) YShuffleX4_Args(Vector256<long> indices) {
            YShuffleX4_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) YShuffleX4_Args(Vector256<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX4_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX4_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX4_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX4_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX4_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX4_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX4_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX4_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX4_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX4_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return YShuffleX4_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX4_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) args) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX4Insert_Args<TIdx>(Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3, out Vector256<TIdx> args4)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4Insert_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
                args4 = a4.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4Insert_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
                args4 = a4.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4Insert_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
                args4 = a4.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4Insert_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
                args4 = a4.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4Insert_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
                args4 = a4.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4Insert_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
                args4 = a4.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4Insert_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
                args4 = a4.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3, var a4) = YShuffleX4Insert_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
                args4 = a4.As<ulong, TIdx>();
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
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3, Vector256<TIdx> args4) YShuffleX4Insert_Args<TIdx>(Vector256<TIdx> indices)
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
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) YShuffleX4Insert_Args(Vector256<sbyte> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) YShuffleX4Insert_Args(Vector256<byte> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) YShuffleX4Insert_Args(Vector256<short> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) YShuffleX4Insert_Args(Vector256<ushort> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) YShuffleX4Insert_Args(Vector256<int> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) YShuffleX4Insert_Args(Vector256<uint> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) YShuffleX4Insert_Args(Vector256<long> indices) {
            YShuffleX4Insert_Args(indices, out var a, out var b, out var c, out var d, out var e);
            return (a, b, c, d, e);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) YShuffleX4Insert_Args(Vector256<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX4Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX4Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX4Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX4Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX4Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX4Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX4Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX4Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX4Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }

        /// <inheritdoc cref="YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX4Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) args) {
            return YShuffleX4Insert_Core(back, vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3, args.args4);
        }


        /// <summary>
        /// Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector256s{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vector256s{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <param name="args0">Arguments 0 (参数0). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args1">Arguments 1 (参数1). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args2">Arguments 2 (参数2). Used for YShuffleX4Kernel_Core .</param>
        /// <param name="args3">Arguments 3 (参数3). Used for YShuffleX4Kernel_Core .</param>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void YShuffleX4Kernel_Args<TIdx>(Vector256<TIdx> indices, out Vector256<TIdx> args0, out Vector256<TIdx> args1, out Vector256<TIdx> args2, out Vector256<TIdx> args3)
                 where TIdx : struct {
            if (typeof(sbyte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX4Kernel_Args(indices.As<TIdx, sbyte>());
                args0 = a0.As<sbyte, TIdx>();
                args1 = a1.As<sbyte, TIdx>();
                args2 = a2.As<sbyte, TIdx>();
                args3 = a3.As<sbyte, TIdx>();
            } else if (typeof(byte) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX4Kernel_Args(indices.As<TIdx, byte>());
                args0 = a0.As<byte, TIdx>();
                args1 = a1.As<byte, TIdx>();
                args2 = a2.As<byte, TIdx>();
                args3 = a3.As<byte, TIdx>();
            } else if (typeof(short) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX4Kernel_Args(indices.As<TIdx, short>());
                args0 = a0.As<short, TIdx>();
                args1 = a1.As<short, TIdx>();
                args2 = a2.As<short, TIdx>();
                args3 = a3.As<short, TIdx>();
            } else if (typeof(ushort) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX4Kernel_Args(indices.As<TIdx, ushort>());
                args0 = a0.As<ushort, TIdx>();
                args1 = a1.As<ushort, TIdx>();
                args2 = a2.As<ushort, TIdx>();
                args3 = a3.As<ushort, TIdx>();
            } else if (typeof(int) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX4Kernel_Args(indices.As<TIdx, int>());
                args0 = a0.As<int, TIdx>();
                args1 = a1.As<int, TIdx>();
                args2 = a2.As<int, TIdx>();
                args3 = a3.As<int, TIdx>();
            } else if (typeof(uint) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX4Kernel_Args(indices.As<TIdx, uint>());
                args0 = a0.As<uint, TIdx>();
                args1 = a1.As<uint, TIdx>();
                args2 = a2.As<uint, TIdx>();
                args3 = a3.As<uint, TIdx>();
            } else if (typeof(long) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX4Kernel_Args(indices.As<TIdx, long>());
                args0 = a0.As<long, TIdx>();
                args1 = a1.As<long, TIdx>();
                args2 = a2.As<long, TIdx>();
                args3 = a3.As<long, TIdx>();
            } else if (typeof(ulong) == typeof(TIdx)) {
                (var a0, var a1, var a2, var a3) = YShuffleX4Kernel_Args(indices.As<TIdx, ulong>());
                args0 = a0.As<ulong, TIdx>();
                args1 = a1.As<ulong, TIdx>();
                args2 = a2.As<ulong, TIdx>();
                args3 = a3.As<ulong, TIdx>();
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_1, typeof(TIdx).Name));
            }
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector256s{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vector256s{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <typeparam name="TIdx">The element type of the indices parameter (索引参数的元素类型).</typeparam>
        /// <param name="indices">The per-element indices used to select a value from vector (用于从 vector 中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数).</returns>
        /// <exception cref="NotSupportedException">These element types(<typeparamref name="TIdx"/>) are not supported.</exception>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<TIdx> args0, Vector256<TIdx> args1, Vector256<TIdx> args2, Vector256<TIdx> args3) YShuffleX4Kernel_Args<TIdx>(Vector256<TIdx> indices)
                where TIdx : struct {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <summary>
        /// Arguments calculation for only shuffle on 4 vectors (在4个向量上进行仅换位的参数计算). Provide arguments for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数). If the index value is out of range, the result is undefined (若索引值超出范围, 结果是未定义的). You can use the <see cref="Vector256s{T}.IndexX4Mask"/> to constrain the parameters (可使用 <see cref="Vector256s{T}.IndexX4Mask"/> 掩码来约束参数).
        /// Mnemonic: <c>rt[i] := element_ref(indices[i], vector0, vector1, vector2, vector3)</c>. Conditions: <c>0&lt;=indices[i] &amp;&amp; indices[i]&lt;(Count*4)</c>.
        /// </summary>
        /// <param name="indices">The per-element indices used to select a value from vectors (用于从输入向量集中选择值的每个元素索引).</param>
        /// <returns>The arguments provided for YShuffleX4Kernel_Core (为 YShuffleX4Kernel_Core 提供参数).</returns>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) YShuffleX4Kernel_Args(Vector256<sbyte> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) YShuffleX4Kernel_Args(Vector256<byte> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) YShuffleX4Kernel_Args(Vector256<short> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) YShuffleX4Kernel_Args(Vector256<ushort> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) YShuffleX4Kernel_Args(Vector256<int> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) YShuffleX4Kernel_Args(Vector256<uint> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) YShuffleX4Kernel_Args(Vector256<long> indices) {
            YShuffleX4Kernel_Args(indices, out var a, out var b, out var c, out var d);
            return (a, b, c, d);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Args(Vector256{sbyte})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) YShuffleX4Kernel_Args(Vector256<ulong> indices) {
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
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_AcceleratedTypes"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YShuffleX4Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YShuffleX4Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleX4Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, (Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleX4Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, (Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleX4Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, (Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleX4Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, (Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YShuffleX4Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, (Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YShuffleX4Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, (Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YShuffleX4Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, (Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

        /// <inheritdoc cref="YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, ValueTuple{Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}})"/>
        /// <seealso cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YShuffleX4Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, (Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) args) {
            return YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args.args0, args.args1, args.args2, args.args3);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
