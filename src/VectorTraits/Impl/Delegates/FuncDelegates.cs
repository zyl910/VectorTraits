using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Impl.Delegates {

    /// <summary>
    /// Functions with 2 input parameters and 1 output parameter (具有2个输入参数与1个输出参数的函数).
    /// </summary>
    /// <typeparam name="T">Type of parameter (参数的类型).</typeparam>
    /// <param name="in0">The 0th input parameter (第0个输入参数).</param>
    /// <param name="in1">The 1th input parameter (第1个输入参数).</param>
    /// <param name="result1">The 1th output parameter (第1个输出参数).</param>
    /// <returns>The 0th output parameter (第0个输出参数).</returns>
    public delegate T FuncIn2Out1<T>(T in0, T in1, out T result1);

    /// <summary>
    /// Functions with 3 input parameters and 2 output parameter (具有3个输入参数与2个输出参数的函数).
    /// </summary>
    /// <typeparam name="T">Type of parameter (参数的类型).</typeparam>
    /// <param name="in0">The 0th input parameter (第0个输入参数).</param>
    /// <param name="in1">The 1th input parameter (第1个输入参数).</param>
    /// <param name="in2">The 1th input parameter (第2个输入参数).</param>
    /// <param name="result1">The 1th output parameter (第1个输出参数).</param>
    /// <param name="result2">The 1th output parameter (第2个输出参数).</param>
    /// <returns>The 0th output parameter (第0个输出参数).</returns>
    public delegate T FuncIn3Out2<T>(T in0, T in1, T in2, out T result1, out T result2);

    /// <summary>
    /// Functions with 3 input parameters and 3 output parameter (具有3个输入参数与3个输出参数的函数).
    /// </summary>
    /// <typeparam name="T">Type of parameter (参数的类型).</typeparam>
    /// <param name="in0">The 0th input parameter (第0个输入参数).</param>
    /// <param name="in1">The 1th input parameter (第1个输入参数).</param>
    /// <param name="in2">The 1th input parameter (第2个输入参数).</param>
    /// <param name="result1">The 1th output parameter (第1个输出参数).</param>
    /// <param name="result2">The 1th output parameter (第2个输出参数).</param>
    /// <param name="result3">The 1th output parameter (第3个输出参数).</param>
    /// <returns>The 0th output parameter (第0个输出参数).</returns>
    public delegate T FuncIn3Out3<T>(T in0, T in1, T in2, out T result1, out T result2, out T result3);

    /// <summary>
    /// Functions with 4 input parameters and 3 output parameter (具有4个输入参数与3个输出参数的函数).
    /// </summary>
    /// <typeparam name="T">Type of parameter (参数的类型).</typeparam>
    /// <param name="in0">The 0th input parameter (第0个输入参数).</param>
    /// <param name="in1">The 1th input parameter (第1个输入参数).</param>
    /// <param name="in2">The 1th input parameter (第2个输入参数).</param>
    /// <param name="in3">The 1th input parameter (第3个输入参数).</param>
    /// <param name="result1">The 1th output parameter (第1个输出参数).</param>
    /// <param name="result2">The 1th output parameter (第2个输出参数).</param>
    /// <returns>The 0th output parameter (第0个输出参数).</returns>
    public delegate T FuncIn4Out2<T>(T in0, T in1, T in2, T in3, out T result1, out T result2);

    /// <summary>
    /// Functions with 4 input parameters and 3 output parameter (具有4个输入参数与3个输出参数的函数).
    /// </summary>
    /// <typeparam name="T">Type of parameter (参数的类型).</typeparam>
    /// <param name="in0">The 0th input parameter (第0个输入参数).</param>
    /// <param name="in1">The 1th input parameter (第1个输入参数).</param>
    /// <param name="in2">The 1th input parameter (第2个输入参数).</param>
    /// <param name="in3">The 1th input parameter (第3个输入参数).</param>
    /// <param name="result1">The 1th output parameter (第1个输出参数).</param>
    /// <param name="result2">The 1th output parameter (第2个输出参数).</param>
    /// <param name="result3">The 1th output parameter (第3个输出参数).</param>
    /// <returns>The 0th output parameter (第0个输出参数).</returns>
    public delegate T FuncIn4Out3<T>(T in0, T in1, T in2, T in3, out T result1, out T result2, out T result3);

    /// <summary>
    /// Functions with 6 input parameters and 5 output parameter (具有6个输入参数与5个输出参数的函数).
    /// </summary>
    /// <typeparam name="T">Type of parameter (参数的类型).</typeparam>
    /// <param name="in0">The 0th input parameter (第0个输入参数).</param>
    /// <param name="in1">The 1th input parameter (第1个输入参数).</param>
    /// <param name="in2">The 1th input parameter (第2个输入参数).</param>
    /// <param name="in3">The 1th input parameter (第3个输入参数).</param>
    /// <param name="in4">The 1th input parameter (第4个输入参数).</param>
    /// <param name="in5">The 1th input parameter (第5个输入参数).</param>
    /// <param name="result1">The 1th output parameter (第1个输出参数).</param>
    /// <param name="result2">The 1th output parameter (第2个输出参数).</param>
    /// <param name="result3">The 1th output parameter (第3个输出参数).</param>
    /// <param name="result4">The 1th output parameter (第4个输出参数).</param>
    /// <param name="result5">The 1th output parameter (第5个输出参数).</param>
    /// <returns>The 0th output parameter (第0个输出参数).</returns>
    public delegate T FuncIn6Out5<T>(T in0, T in1, T in2, T in3, T in4, T in5, out T result1, out T result2, out T result3, out T result4, out T result5);

}
