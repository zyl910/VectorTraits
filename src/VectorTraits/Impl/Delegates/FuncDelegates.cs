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
    /// Functions with 4 input parameters and 3 output parameter (具有2个输入参数与1个输出参数的函数).
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

}
