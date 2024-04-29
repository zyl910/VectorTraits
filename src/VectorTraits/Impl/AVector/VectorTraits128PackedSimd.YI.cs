using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.AVector128;

namespace Zyl.VectorTraits.Impl.AVector {
    using WStatics = WVectorTraits128PackedSimd.Statics;
    using BaseStatics = VectorTraitsBase.Statics;

    partial class VectorTraits128PackedSimd {
#if NET8_0_OR_GREATER
        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.YIsAllTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAllTrue_AcceleratedTypes {
                get {
                    return WStatics.YIsAllTrue_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsAllTrue{T}(Vector{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAllTrue<T>(Vector<T> value) where T : struct {
                return WStatics.YIsAllTrue(value.AsVector128());
            }


            /// <inheritdoc cref="IVectorTraits.YIsAnyTrue_AcceleratedTypes"/>
            public static TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
                get {
                    return WStatics.YIsAnyTrue_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsAnyTrue{T}(Vector{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool YIsAnyTrue<T>(Vector<T> value) where T : struct {
                return WStatics.YIsAnyTrue(value.AsVector128());
            }


            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger_AcceleratedTypes"/>
            public static TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
                get {
                    return WStatics.YIsEvenInteger_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsEvenInteger(Vector<float> value) {
                return WStatics.YIsEvenInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsEvenInteger(Vector<double> value) {
                return WStatics.YIsEvenInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsEvenInteger(Vector<sbyte> value) {
                return WStatics.YIsEvenInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsEvenInteger(Vector<byte> value) {
                return WStatics.YIsEvenInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsEvenInteger(Vector<short> value) {
                return WStatics.YIsEvenInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsEvenInteger(Vector<ushort> value) {
                return WStatics.YIsEvenInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsEvenInteger(Vector<int> value) {
                return WStatics.YIsEvenInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsEvenInteger(Vector<uint> value) {
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

            /// <inheritdoc cref="IVectorTraits.YIsFinite(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsFinite(Vector<float> value) {
                return WStatics.YIsFinite(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.YIsInfinity(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsInfinity(Vector<float> value) {
                return WStatics.YIsInfinity(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsInfinityOrNaN(Vector<float> value) {
                return WStatics.YIsInfinityOrNaN(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.YIsInteger(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsInteger(Vector<float> value) {
                return WStatics.YIsInteger(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.YIsNaN(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNaN(Vector<float> value) {
                return WStatics.YIsNaN(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegative(Vector<float> value) {
                return WStatics.YIsNegative(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsNegative(Vector<double> value) {
                return WStatics.YIsNegative(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsNegative(Vector<sbyte> value) {
                return WStatics.YIsNegative(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsNegative(Vector<short> value) {
                return WStatics.YIsNegative(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegative(Vector<int> value) {
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

            /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegativeInfinity(Vector<float> value) {
                return WStatics.YIsNegativeInfinity(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.YIsNegativeZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNegativeZero(Vector<float> value) {
                return WStatics.YIsNegativeZero(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.YIsNormal(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNormal(Vector<float> value) {
                return WStatics.YIsNormal(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YIsNotEquals(Vector<float> left, Vector<float> right) {
                return WStatics.YIsNotEquals(left.AsVector128(), right.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YIsNotEquals(Vector<double> left, Vector<double> right) {
                return WStatics.YIsNotEquals(left.AsVector128(), right.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsNotEquals(Vector<sbyte> left, Vector<sbyte> right) {
                return WStatics.YIsNotEquals(left.AsVector128(), right.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsNotEquals(Vector<byte> left, Vector<byte> right) {
                return WStatics.YIsNotEquals(left.AsVector128(), right.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsNotEquals(Vector<short> left, Vector<short> right) {
                return WStatics.YIsNotEquals(left.AsVector128(), right.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsNotEquals(Vector<ushort> left, Vector<ushort> right) {
                return WStatics.YIsNotEquals(left.AsVector128(), right.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNotEquals(Vector<int> left, Vector<int> right) {
                return WStatics.YIsNotEquals(left.AsVector128(), right.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsNotEquals(Vector<uint> left, Vector<uint> right) {
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

            /// <inheritdoc cref="IVectorTraits.YIsNotNaN(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsNotNaN(Vector<float> value) {
                return WStatics.YIsNotNaN(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsOddInteger(Vector<float> value) {
                return WStatics.YIsOddInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsOddInteger(Vector<double> value) {
                return WStatics.YIsOddInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsOddInteger(Vector<sbyte> value) {
                return WStatics.YIsOddInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsOddInteger(Vector<byte> value) {
                return WStatics.YIsOddInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsOddInteger(Vector<short> value) {
                return WStatics.YIsOddInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsOddInteger(Vector<ushort> value) {
                return WStatics.YIsOddInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsOddInteger(Vector<int> value) {
                return WStatics.YIsOddInteger(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsOddInteger(Vector<uint> value) {
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

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsPositive(Vector<float> value) {
                return WStatics.YIsPositive(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsPositive(Vector<double> value) {
                return WStatics.YIsPositive(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsPositive(Vector<sbyte> value) {
                return WStatics.YIsPositive(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsPositive(Vector<short> value) {
                return WStatics.YIsPositive(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsPositive(Vector<int> value) {
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

            /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsPositiveInfinity(Vector<float> value) {
                return WStatics.YIsPositiveInfinity(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.YIsSubnormal(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsSubnormal(Vector<float> value) {
                return WStatics.YIsSubnormal(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsZero(Vector<float> value) {
                return WStatics.YIsZero(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZero(Vector<double> value) {
                return WStatics.YIsZero(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YIsZero(Vector<sbyte> value) {
                return WStatics.YIsZero(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YIsZero(Vector<byte> value) {
                return WStatics.YIsZero(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YIsZero(Vector<short> value) {
                return WStatics.YIsZero(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YIsZero(Vector<ushort> value) {
                return WStatics.YIsZero(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsZero(Vector<int> value) {
                return WStatics.YIsZero(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YIsZero(Vector<uint> value) {
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

            /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YIsZeroOrSubnormal(Vector<float> value) {
                return WStatics.YIsZeroOrSubnormal(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YIsZeroOrSubnormal(Vector<double> value) {
                return WStatics.YIsZeroOrSubnormal(value.AsVector128()).AsVector();
            }

        }
#endif // NET8_0_OR_GREATER
    }
}
