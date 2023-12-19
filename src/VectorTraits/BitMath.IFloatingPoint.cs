using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits {
    // IFloatingPoint: https://learn.microsoft.com/zh-cn/dotnet/api/system.numerics.ifloatingpoint-1
    // Referenced from generic math (参考了泛型数学): https://learn.microsoft.com/en-us/dotnet/standard/generics/math
    partial class BitMath {

        /// <inheritdoc cref="MathIFloatingPoint.Truncate(float)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Truncate(float x) {
            return MathIFloatingPoint.Truncate(x);
        }

        /// <inheritdoc cref="MathIFloatingPoint.Truncate(double)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Truncate(double x) {
            return MathIFloatingPoint.Truncate(x);
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="MathIFloatingPoint.Truncate(Half)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Half Truncate(Half x) {
            return MathIFloatingPoint.Truncate(x);
        }
#endif // NET5_0_OR_GREATER


    }
}
