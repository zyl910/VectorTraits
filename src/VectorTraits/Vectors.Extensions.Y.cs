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
