using System;
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_1_OR_GREATER
using System.Buffers.Binary;
#endif
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits {
    /// <summary>
    /// Provides constants and static methods for binary operations, and other common mathematical functions (为二进制运算和其他通用数学函数提供常数和静态方法).
    /// </summary>
    /// <remarks>
    /// <para>It contains functions from <see cref="Math"/>/<see cref="BitConverter"/>, and generic math interfaces such as <see cref="INumber{TSelf}">INumber</see>. For math functions in classes such as <see cref="BitOperations"/>, you can use the classes (它包含了 <see cref="Math"/>/<see cref="BitConverter"/>, 与 <see cref="INumber{TSelf}">INumber</see> 等泛型数学接口中的函数. 而对于 <see cref="BitOperations"/> 等类中的数学函数, 可使用这些类):</para>
    /// <list type="bullet">
    ///   <item>
    ///     <term><see cref="MathBinaryPrimitives"/></term>
    ///     <description>Compatible with <see cref="BinaryPrimitives"/></description>
    ///   </item>
    ///   <item>
    ///     <term><see cref="MathBitOperations"/></term>
    ///     <description>Compatible with <see cref="BitOperations"/></description>
    ///   </item>
    /// </list>
    /// </remarks>
    /// <seealso cref="BitConverter"/>
    /// <seealso cref="BitOperations"/>
    /// <seealso cref="Math"/>
    public abstract partial class BitMath: BitMathCore {

    }
}
