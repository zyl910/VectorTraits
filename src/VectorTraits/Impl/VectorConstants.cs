using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Extensions.SameW;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// The constants used in <see cref="Vector{T}"/> methods (<see cref="Vector{T}"/> 方法所用的常数).
    /// </summary>
    public static class VectorConstants {

        #region Vectors_T
        // == Vectors_T: originate from Vectors<T> ==

        /// <summary>Sign mask (符号掩码) - Single.</summary>
        public static Vector<float> SignMask_Single {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<uint>(0x80000000U).AsSingle(); // .NET5+ has better performance .
#else
                return Vectors<float>.SignMask;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Sign mask (符号掩码) - Double.</summary>
        public static Vector<double> SignMask_Double {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<ulong>(0x8000000000000000L).AsDouble();
#else
                return Vectors<double>.SignMask;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Exponent mask (指数掩码) - Single.</summary>
        public static Vector<float> ExponentMask_Single {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<int>(0x7F800000).AsSingle();
#else
                return Vectors<float>.ExponentMask;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Exponent mask (指数掩码) - Double.</summary>
        public static Vector<double> ExponentMask_Double {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<long>(0x7FF0000000000000L).AsDouble();
#else
                return Vectors<double>.ExponentMask;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Mantissa mask (尾数掩码) - Single.</summary>
        public static Vector<float> MantissaMask_Single {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<int>(0x007FFFFF).AsSingle();
#else
                return Vectors<float>.MantissaMask;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Mantissa mask (尾数掩码) - Double.</summary>
        public static Vector<double> MantissaMask_Double {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<long>(0x000FFFFFFFFFFFFFL).AsDouble();
#else
                return Vectors<double>.MantissaMask;
#endif // NET5_0_OR_GREATER
            }
        }

        /// <summary>Value 255 (byte.MaxValue) - UInt16.</summary>
        [CLSCompliant(false)]
        public static Vector<ushort> VMaxByte_UInt16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
#if NET5_0_OR_GREATER
                return new Vector<ushort>((ushort)byte.MaxValue);
#else
                return Vectors<ushort>.VMaxByte;
#endif // NET5_0_OR_GREATER
            }
        }

        #endregion // Vectors_T

        #region Shared
        // == Shared ==

        #endregion // Shared

        #region TraitsMethod
        // == TraitsMethod ==

        #endregion // TraitsMethod


    }
}
