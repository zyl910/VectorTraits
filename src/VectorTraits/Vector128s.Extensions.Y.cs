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
using Zyl.VectorTraits.Impl;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits {
    static partial class Vector128s {

#if NETCOREAPP3_0_OR_GREATER

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
        public static (Vector128<float> Result0, Vector128<float> Result1) YShuffleG4X2(Vector128<float> source0, Vector128<float> source1, ShuffleControlG4 control) {
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
        public static (Vector128<double> Result0, Vector128<double> Result1) YShuffleG4X2(Vector128<double> source0, Vector128<double> source1, ShuffleControlG4 control) {
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
        public static (Vector128<sbyte> Result0, Vector128<sbyte> Result1) YShuffleG4X2(Vector128<sbyte> source0, Vector128<sbyte> source1, ShuffleControlG4 control) {
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
        public static (Vector128<byte> Result0, Vector128<byte> Result1) YShuffleG4X2(Vector128<byte> source0, Vector128<byte> source1, ShuffleControlG4 control) {
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
        public static (Vector128<short> Result0, Vector128<short> Result1) YShuffleG4X2(Vector128<short> source0, Vector128<short> source1, ShuffleControlG4 control) {
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
        public static (Vector128<ushort> Result0, Vector128<ushort> Result1) YShuffleG4X2(Vector128<ushort> source0, Vector128<ushort> source1, ShuffleControlG4 control) {
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
        public static (Vector128<int> Result0, Vector128<int> Result1) YShuffleG4X2(Vector128<int> source0, Vector128<int> source1, ShuffleControlG4 control) {
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
        public static (Vector128<uint> Result0, Vector128<uint> Result1) YShuffleG4X2(Vector128<uint> source0, Vector128<uint> source1, ShuffleControlG4 control) {
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
        public static (Vector128<long> Result0, Vector128<long> Result1) YShuffleG4X2(Vector128<long> source0, Vector128<long> source1, ShuffleControlG4 control) {
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
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1) YShuffleG4X2(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control) {
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
        [CLSCompliant(false)]
        public static (Vector128<ulong> Result0, Vector128<ulong> Result1) YShuffleG4X2_Const(Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            var result0 = YShuffleG4X2_Const(source0, source1, control, out var result1);
            return (result0, result1);
        }


#endif // NETCOREAPP3_0_OR_GREATER
    }
}
