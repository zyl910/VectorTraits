using System;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl.AVector128;

namespace Zyl.VectorTraits.Impl.AVector {
    using WStatics = WVectorTraits128AdvSimdB64.Statics;
    using BaseStatics = VectorTraits128Base.Statics;

    partial class VectorTraits128AdvSimdB64 {
#if NET5_0_OR_GREATER
        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.YBitToByte_IsAccelerated"/>
            public static bool YBitToByte_IsAccelerated {
                get {
                    return WStatics.YBitToByte_IsAccelerated;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YBitToByte(ulong value) {
                return WStatics.YBitToByte((uint)value).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YClamp_AcceleratedTypes"/>
            public static TypeCodeFlags YClamp_AcceleratedTypes {
                get {
                    return WStatics.YClamp_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{double}, Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YClamp(Vector<double> value, Vector<double> amin, Vector<double> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YClamp(Vector<long> value, Vector<long> amin, Vector<long> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YClamp(Vector<ulong> value, Vector<ulong> amin, Vector<ulong> amax) {
                return WStatics.YClamp(value.AsVector128(), amin.AsVector128(), amax.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
                get {
                    return WStatics.YIsEvenInteger_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsEvenInteger(Vector<double> value) {
                return WStatics.YIsEvenInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsEvenInteger(Vector<long> value) {
                return WStatics.YIsEvenInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsEvenInteger(Vector<ulong> value) {
                return WStatics.YIsEvenInteger(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsFinite_AcceleratedTypes"/>
            public static TypeCodeFlags YIsFinite_AcceleratedTypes {
                get {
                    return WStatics.YIsFinite_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsFinite(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsFinite(Vector<double> value) {
                return WStatics.YIsFinite(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinity_AcceleratedTypes {
                get {
                    return WStatics.YIsInfinity_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsInfinity(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsInfinity(Vector<double> value) {
                return WStatics.YIsInfinity(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
                get {
                    return WStatics.YIsInfinityOrNaN_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsInfinityOrNaN(Vector<double> value) {
                return WStatics.YIsInfinityOrNaN(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsInteger_AcceleratedTypes {
                get {
                    return WStatics.YIsInteger_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsInteger(Vector<double> value) {
                return WStatics.YIsInteger(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNaN_AcceleratedTypes {
                get {
                    return WStatics.YIsNaN_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNaN(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNaN(Vector<double> value) {
                return WStatics.YIsNaN(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsNegative_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegative_AcceleratedTypes {
                get {
                    return WStatics.YIsNegative_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegative(Vector<double> value) {
                return WStatics.YIsNegative(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegative(Vector<long> value) {
                return WStatics.YIsNegative(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
                get {
                    return WStatics.YIsNegativeInfinity_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegativeInfinity(Vector<double> value) {
                return WStatics.YIsNegativeInfinity(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsNegativeZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
                get {
                    return WStatics.YIsNegativeZero_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegativeZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegativeZero(Vector<double> value) {
                return WStatics.YIsNegativeZero(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsNormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNormal_AcceleratedTypes {
                get {
                    return WStatics.YIsNormal_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNormal(Vector<double> value) {
                return WStatics.YIsNormal(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsNotEquals_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotEquals_AcceleratedTypes {
                get {
                    return WStatics.YIsNotEquals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YIsNotEquals(Vector<double> left, Vector<double> right) {
                return WStatics.YIsNotEquals(left.AsVector128(), right.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNotEquals(Vector<long> left, Vector<long> right) {
                return WStatics.YIsNotEquals(left.AsVector128(), right.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsNotEquals(Vector<ulong> left, Vector<ulong> right) {
                return WStatics.YIsNotEquals(left.AsVector128(), right.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsNotNaN_AcceleratedTypes"/>
            public static TypeCodeFlags YIsNotNaN_AcceleratedTypes {
                get {
                    return WStatics.YIsNotNaN_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotNaN(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNotNaN(Vector<double> value) {
                return WStatics.YIsNotNaN(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsOddInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsOddInteger_AcceleratedTypes {
                get {
                    return WStatics.YIsOddInteger_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsOddInteger(Vector<double> value) {
                return WStatics.YIsOddInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsOddInteger(Vector<long> value) {
                return WStatics.YIsOddInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsOddInteger(Vector<ulong> value) {
                return WStatics.YIsOddInteger(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsPositive_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositive_AcceleratedTypes {
                get {
                    return WStatics.YIsPositive_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositive(Vector<double> value) {
                return WStatics.YIsPositive(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositive(Vector<long> value) {
                return WStatics.YIsPositive(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity_AcceleratedTypes"/>
            public static TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
                get {
                    return WStatics.YIsPositiveInfinity_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositiveInfinity(Vector<double> value) {
                return WStatics.YIsPositiveInfinity(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsSubnormal_AcceleratedTypes {
                get {
                    return WStatics.YIsSubnormal_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsSubnormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsSubnormal(Vector<double> value) {
                return WStatics.YIsSubnormal(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsZero_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZero_AcceleratedTypes {
                get {
                    return WStatics.YIsZero_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZero(Vector<double> value) {
                return WStatics.YIsZero(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZero(Vector<long> value) {
                return WStatics.YIsZero(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YIsZero(Vector<ulong> value) {
                return WStatics.YIsZero(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal_AcceleratedTypes"/>
            public static TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
                get {
                    return WStatics.YIsZeroOrSubnormal_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZeroOrSubnormal(Vector<double> value) {
                return WStatics.YIsZeroOrSubnormal(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YMaxNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMaxNumber_AcceleratedTypes {
                get {
                    return WStatics.YMaxNumber_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YMaxNumber(Vector<double> left, Vector<double> right) {
                return WStatics.YMaxNumber(left.AsVector128(), right.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YMinNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMinNumber_AcceleratedTypes {
                get {
                    return WStatics.YMinNumber_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YMinNumber(Vector<double> left, Vector<double> right) {
                return WStatics.YMinNumber(left.AsVector128(), right.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YRoundToEven_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
                get {
                    return WStatics.YRoundToEven_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToEven(Vector<double> value) {
                return WStatics.YRoundToEven(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YRoundToZero_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
                get {
                    return WStatics.YRoundToZero_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YRoundToZero(Vector<double> value) {
                return WStatics.YRoundToZero(value.AsVector128()).AsVector();
            }

        }
#endif // NET5_0_OR_GREATER
    }
    }
