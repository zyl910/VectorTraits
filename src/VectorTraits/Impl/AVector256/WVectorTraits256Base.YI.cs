using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector256 {
    partial class WVectorTraits256Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector256<T> value) where T : struct {
#if NET7_0_OR_GREATER
                return YIsAllTrue_Bcl(value);
#else
                return YIsAllTrue_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue_Basic<T>(Vector256<T> value) where T : struct {
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<T>, FixedArray4<long>>(ref value);
                long total = p.I0 & p.I1 & p.I2 & p.I3;
                return -1 == total;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue_Bcl<T>(Vector256<T> value) where T : struct {
                Vector256<int> allBitsSet = Vector256<int>.AllBitsSet;
                return Vector256.EqualsAll(value.AsInt32(), allBitsSet);
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector256<T> value) where T : struct {
#if NET7_0_OR_GREATER
                return YIsAnyTrue_Bcl(value);
#else
                return YIsAnyTrue_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue_Basic<T>(Vector256<T> value) where T : struct {
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<T>, FixedArray4<long>>(ref value);
                long total = p.I0 | p.I1 | p.I2 | p.I3;
                return 0 != total;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue_Bcl<T>(Vector256<T> value) where T : struct {
                Vector256<byte> allBitsSet = Vector256<byte>.AllBitsSet; // Must use byte.
                return Vector256.EqualsAny(value.AsByte(), allBitsSet);
            }
#endif // NET7_0_OR_GREATER

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
