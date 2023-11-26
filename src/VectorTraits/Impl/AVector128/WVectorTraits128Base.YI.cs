using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector128 {
    partial class WVectorTraits128Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector128<T> value) where T : struct {
#if NET7_0_OR_GREATER
                return YIsAllTrue_Bcl(value);
#else
                return YIsAllTrue_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue_Basic<T>(Vector128<T> value) where T : struct {
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<T>, FixedArray2<long>>(ref value);
                long total = p.I0 & p.I1;
                return -1 == total;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits128.YIsAllTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue_Bcl<T>(Vector128<T> value) where T : struct {
                Vector128<int> allBitsSet = Vector128<int>.AllBitsSet;
                return Vector128.EqualsAll(value.AsInt32(), allBitsSet);
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector128<T> value) where T : struct {
#if NET7_0_OR_GREATER
                return YIsAnyTrue_Bcl(value);
#else
                return YIsAnyTrue_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue_Basic<T>(Vector128<T> value) where T : struct {
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<T>, FixedArray2<long>>(ref value);
                long total = p.I0 | p.I1;
                return 0 != total;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits128.YIsAnyTrue{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue_Bcl<T>(Vector128<T> value) where T : struct {
                Vector128<byte> allBitsSet = Vector128<byte>.AllBitsSet; // Must use byte.
                return Vector128.EqualsAny(value.AsByte(), allBitsSet);
            }
#endif // NET7_0_OR_GREATER

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
