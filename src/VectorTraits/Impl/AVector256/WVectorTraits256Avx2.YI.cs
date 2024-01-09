using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector256 {
    using SuperStatics = WVectorTraits256Base.Statics;

    partial class WVectorTraits256Avx2 {

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
                Vector256<int> mask = OnesComplement(value).AsInt32();
                return Avx.TestZ(mask, mask);
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector256<T> value) where T : struct {
                return !Avx.TestZ(value.AsInt32(), value.AsInt32());
            }


            /// <inheritdoc cref="IWVectorTraits256.YIsFinite_AcceleratedTypes"/>
            public static TypeCodeFlags YIsFinite_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YIsFinite(Vector256<float> value) {
                Vector256<int> exponentMask = Vector256Constants.Single_ExponentMask.AsInt32();
                Vector256<int> exponent = Avx2.And(value.AsInt32(), exponentMask);
                Vector256<int> rt = OnesComplement(Equals(exponent, exponentMask));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YIsFinite(Vector256<double> value) {
                Vector256<long> exponentMask = Vector256Constants.Double_ExponentMask.AsInt64();
                Vector256<long> exponent = Avx2.And(value.AsInt64(), exponentMask);
                Vector256<long> rt = OnesComplement(Equals(exponent, exponentMask));
                return rt;
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
