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


            /// <inheritdoc cref="IVectorTraits.YShuffleG2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG2_AcceleratedTypes {
                get {
                    return WStatics.YShuffleG2_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG2(Vector<float> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG2(Vector<double> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG2(Vector<sbyte> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG2(Vector<byte> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG2(Vector<short> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG2(Vector<ushort> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG2(Vector<int> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG2(Vector<uint> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG2(Vector<long> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG2(Vector<ulong> source, ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG2_Const(Vector<float> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG2_Const(Vector<double> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG2_Const(Vector<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG2_Const(Vector<byte> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG2_Const(Vector<short> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG2_Const(Vector<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG2_Const(Vector<int> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG2_Const(Vector<uint> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG2_Const(Vector<long> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG2_Const(Vector<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
                return WStatics.YShuffleG2_Const(source.AsVector128(), control).AsVector();
            }
#endif // !REDUCE_MEMORY_USAGE


            /// <inheritdoc cref="IVectorTraits.YShuffleG4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4_AcceleratedTypes {
                get {
                    return WStatics.YShuffleG4_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4(Vector<float> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4(Vector<double> source, ShuffleControlG4 control) {
                throw new NotSupportedException(string.Format(VectorMessageFormats.FORMAT_YSHUFFLEG4_MUST4_1, Vector<ulong>.Count));
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4(Vector<sbyte> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4(Vector<byte> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4(Vector<short> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4(Vector<ushort> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4(Vector<int> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4(Vector<uint> source, ShuffleControlG4 control) {
                return WStatics.YShuffleG4(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG4(Vector<long> source, ShuffleControlG4 control) {
                throw new NotSupportedException(string.Format(VectorMessageFormats.FORMAT_YSHUFFLEG4_MUST4_1, Vector<ulong>.Count));
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4(Vector<ulong> source, ShuffleControlG4 control) {
                throw new NotSupportedException(string.Format(VectorMessageFormats.FORMAT_YSHUFFLEG4_MUST4_1, Vector<ulong>.Count));
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4_Const(Vector<float> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4_Const(Vector<double> source, [ConstantExpected] ShuffleControlG4 control) {
                throw new NotSupportedException(string.Format(VectorMessageFormats.FORMAT_YSHUFFLEG4_MUST4_1, Vector<ulong>.Count));
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4_Const(Vector<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4_Const(Vector<byte> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4_Const(Vector<short> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4_Const(Vector<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4_Const(Vector<int> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4_Const(Vector<uint> source, [ConstantExpected] ShuffleControlG4 control) {
                return WStatics.YShuffleG4_Const(source.AsVector128(), control).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG4_Const(Vector<long> source, [ConstantExpected] ShuffleControlG4 control) {
                throw new NotSupportedException(string.Format(VectorMessageFormats.FORMAT_YSHUFFLEG4_MUST4_1, Vector<ulong>.Count));
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4_Const(Vector<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
                throw new NotSupportedException(string.Format(VectorMessageFormats.FORMAT_YSHUFFLEG4_MUST4_1, Vector<ulong>.Count));
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
                get {
                    return WStatics.YShuffleG4X2_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{float}, Vector{float}, ShuffleControlG4, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4X2(Vector<float> source0, Vector<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<float> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{double}, Vector{double}, ShuffleControlG4, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4X2(Vector<double> source0, Vector<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<double> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4X2(Vector<sbyte> source0, Vector<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<sbyte> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4X2(Vector<byte> source0, Vector<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<byte> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{short}, Vector{short}, ShuffleControlG4, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4X2(Vector<short> source0, Vector<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<short> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ushort}, Vector{ushort}, ShuffleControlG4, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4X2(Vector<ushort> source0, Vector<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ushort> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{int}, Vector{int}, ShuffleControlG4, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4X2(Vector<int> source0, Vector<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<int> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{uint}, Vector{uint}, ShuffleControlG4, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4X2(Vector<uint> source0, Vector<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<uint> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{long}, Vector{long}, ShuffleControlG4, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG4X2(Vector<long> source0, Vector<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<long> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4X2(Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ulong> result1) {
                var rt0 = WStatics.YShuffleG4X2(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{float}, Vector{float}, ShuffleControlG4, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4X2_Const(Vector<float> source0, Vector<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<float> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{double}, Vector{double}, ShuffleControlG4, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4X2_Const(Vector<double> source0, Vector<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<double> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4X2_Const(Vector<sbyte> source0, Vector<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<sbyte> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4X2_Const(Vector<byte> source0, Vector<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<byte> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{short}, Vector{short}, ShuffleControlG4, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4X2_Const(Vector<short> source0, Vector<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<short> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{ushort}, Vector{ushort}, ShuffleControlG4, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4X2_Const(Vector<ushort> source0, Vector<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ushort> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{int}, Vector{int}, ShuffleControlG4, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4X2_Const(Vector<int> source0, Vector<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<int> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{uint}, Vector{uint}, ShuffleControlG4, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4X2_Const(Vector<uint> source0, Vector<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<uint> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{long}, Vector{long}, ShuffleControlG4, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG4X2_Const(Vector<long> source0, Vector<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<long> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4X2_Const(Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ulong> result1) {
                var rt0 = WStatics.YShuffleG4X2_Const(source0.AsVector128(), source1.AsVector128(), control, out var rt1);
                result1 = rt1.AsVector();
                return rt0.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
                get {
                    return WStatics.YShuffleInsert_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleInsert(Vector<float> back, Vector<float> vector, Vector<int> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleInsert(Vector<double> back, Vector<double> vector, Vector<long> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleInsert(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleInsert(Vector<byte> back, Vector<byte> vector, Vector<byte> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleInsert(Vector<short> back, Vector<short> vector, Vector<short> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleInsert(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleInsert(Vector<int> back, Vector<int> vector, Vector<int> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleInsert(Vector<uint> back, Vector<uint> vector, Vector<uint> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleInsert(Vector<long> back, Vector<long> vector, Vector<long> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleInsert(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> indices) {
                return WStatics.YShuffleInsert(back.AsVector128(), vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2) {
                WStatics.YShuffleInsert_Args(indices.AsVector128(), out var a0, out var a1, out var a2);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
                args2 = a2.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleInsert_Core(Vector<float> back, Vector<float> vector, Vector<int> args0, Vector<int> args1, Vector<int> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleInsert_Core(Vector<double> back, Vector<double> vector, Vector<long> args0, Vector<long> args1, Vector<long> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleInsert_Core(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleInsert_Core(Vector<byte> back, Vector<byte> vector, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleInsert_Core(Vector<short> back, Vector<short> vector, Vector<short> args0, Vector<short> args1, Vector<short> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleInsert_Core(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleInsert_Core(Vector<int> back, Vector<int> vector, Vector<int> args0, Vector<int> args1, Vector<int> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleInsert_Core(Vector<uint> back, Vector<uint> vector, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleInsert_Core(Vector<long> back, Vector<long> vector, Vector<long> args0, Vector<long> args1, Vector<long> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleInsert_Core(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2) {
                return WStatics.YShuffleInsert_Core(back.AsVector128(), vector.AsVector128(), args0.AsVector128(), args1.AsVector128(), args2.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
                get {
                    return WStatics.YShuffleKernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleKernel(Vector<float> vector, Vector<int> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleKernel(Vector<double> vector, Vector<long> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleKernel(Vector<sbyte> vector, Vector<sbyte> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleKernel(Vector<byte> vector, Vector<byte> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleKernel(Vector<short> vector, Vector<short> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleKernel(Vector<ushort> vector, Vector<ushort> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleKernel(Vector<int> vector, Vector<int> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleKernel(Vector<uint> vector, Vector<uint> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleKernel(Vector<long> vector, Vector<long> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleKernel(Vector<ulong> vector, Vector<ulong> indices) {
                return WStatics.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1) {
                WStatics.YShuffleKernel_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{float}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleKernel_Core(Vector<float> vector, Vector<int> args0, Vector<int> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{double}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleKernel_Core(Vector<double> vector, Vector<long> args0, Vector<long> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleKernel_Core(Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleKernel_Core(Vector<byte> vector, Vector<byte> args0, Vector<byte> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleKernel_Core(Vector<short> vector, Vector<short> args0, Vector<short> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleKernel_Core(Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleKernel_Core(Vector<int> vector, Vector<int> args0, Vector<int> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleKernel_Core(Vector<uint> vector, Vector<uint> args0, Vector<uint> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleKernel_Core(Vector<long> vector, Vector<long> args0, Vector<long> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleKernel_Core(Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1) {
                return WStatics.YShuffleKernel_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YSign_AcceleratedTypes"/>
            public static TypeCodeFlags YSign_AcceleratedTypes {
                get {
                    return WStatics.YSign_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YSign(Vector<double> value) {
                return WStatics.YSign(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YSign(Vector<long> value) {
                return WStatics.YSign(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.YSignFloat_AcceleratedTypes"/>
            public static TypeCodeFlags YSignFloat_AcceleratedTypes {
                get {
                    return WStatics.YSignFloat_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YSignFloat(Vector<double> value) {
                return WStatics.YSignFloat(value.AsVector128()).AsVector();
            }

        }
#endif // NET5_0_OR_GREATER
    }
    }
