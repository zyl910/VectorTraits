using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl.AVector128 {
    using Statics = WVectorTraits128AdvSimdB64.Statics;

    partial class WVectorTraits128AdvSimdB64Abstract {
#if NET5_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.YBitToByte_IsAccelerated"/>
        public override bool YBitToByte_IsAccelerated {
            get {
                return Statics.YBitToByte_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YBitToByte"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YBitToByte(uint value) {
            return Statics.YBitToByte(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YClamp_AcceleratedTypes"/>
        public override TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return Statics.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{double}, Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YClamp(Vector128<long> value, Vector128<long> amin, Vector128<long> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YClamp(Vector128<ulong> value, Vector128<ulong> amin, Vector128<ulong> amax) {
            return Statics.YClamp(value, amin, amax);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger_AcceleratedTypes"/>
        public override TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
            get {
                return Statics.YIsEvenInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsEvenInteger(Vector128<double> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsEvenInteger(Vector128<long> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsEvenInteger(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YIsEvenInteger(Vector128<ulong> value) {
            return Statics.YIsEvenInteger(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsFinite_AcceleratedTypes"/>
        public override TypeCodeFlags YIsFinite_AcceleratedTypes {
            get {
                return Statics.YIsFinite_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsFinite(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsFinite(Vector128<double> value) {
            return Statics.YIsFinite(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsInfinity_AcceleratedTypes"/>
        public override TypeCodeFlags YIsInfinity_AcceleratedTypes {
            get {
                return Statics.YIsInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInfinity(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsInfinity(Vector128<double> value) {
            return Statics.YIsInfinity(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN_AcceleratedTypes"/>
        public override TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
            get {
                return Statics.YIsInfinityOrNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInfinityOrNaN(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsInfinityOrNaN(Vector128<double> value) {
            return Statics.YIsInfinityOrNaN(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsInteger_AcceleratedTypes"/>
        public override TypeCodeFlags YIsInteger_AcceleratedTypes {
            get {
                return Statics.YIsInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsInteger(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsInteger(Vector128<double> value) {
            return Statics.YIsInteger(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNaN_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNaN_AcceleratedTypes {
            get {
                return Statics.YIsNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNaN(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNaN(Vector128<double> value) {
            return Statics.YIsNaN(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNegative_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNegative_AcceleratedTypes {
            get {
                return Statics.YIsNegative_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNegative(Vector128<double> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegative(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNegative(Vector128<long> value) {
            return Statics.YIsNegative(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
            get {
                return Statics.YIsNegativeInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeInfinity(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNegativeInfinity(Vector128<double> value) {
            return Statics.YIsNegativeInfinity(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
            get {
                return Statics.YIsNegativeZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNegativeZero(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNegativeZero(Vector128<double> value) {
            return Statics.YIsNegativeZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNormal_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNormal_AcceleratedTypes {
            get {
                return Statics.YIsNormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNormal(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNormal(Vector128<double> value) {
            return Statics.YIsNormal(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNotNaN_AcceleratedTypes {
            get {
                return Statics.YIsNotNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsNotNaN(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsNotNaN(Vector128<double> value) {
            return Statics.YIsNotNaN(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger_AcceleratedTypes"/>
        public override TypeCodeFlags YIsOddInteger_AcceleratedTypes {
            get {
                return Statics.YIsOddInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsOddInteger(Vector128<double> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsOddInteger(Vector128<long> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsOddInteger(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YIsOddInteger(Vector128<ulong> value) {
            return Statics.YIsOddInteger(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsPositive_AcceleratedTypes"/>
        public override TypeCodeFlags YIsPositive_AcceleratedTypes {
            get {
                return Statics.YIsPositive_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsPositive(Vector128<double> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositive(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsPositive(Vector128<long> value) {
            return Statics.YIsPositive(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity_AcceleratedTypes"/>
        public override TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
            get {
                return Statics.YIsPositiveInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsPositiveInfinity(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsPositiveInfinity(Vector128<double> value) {
            return Statics.YIsPositiveInfinity(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal_AcceleratedTypes"/>
        public override TypeCodeFlags YIsSubnormal_AcceleratedTypes {
            get {
                return Statics.YIsSubnormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsSubnormal(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsSubnormal(Vector128<double> value) {
            return Statics.YIsSubnormal(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsZero_AcceleratedTypes"/>
        public override TypeCodeFlags YIsZero_AcceleratedTypes {
            get {
                return Statics.YIsZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsZero(Vector128<double> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsZero(Vector128<long> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZero(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YIsZero(Vector128<ulong> value) {
            return Statics.YIsZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal_AcceleratedTypes"/>
        public override TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
            get {
                return Statics.YIsZeroOrSubnormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YIsZeroOrSubnormal(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YIsZeroOrSubnormal(Vector128<double> value) {
            return Statics.YIsZeroOrSubnormal(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YRoundToEven_AcceleratedTypes"/>
        public override TypeCodeFlags YRoundToEven_AcceleratedTypes {
            get {
                return Statics.YRoundToEven_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YRoundToEven(Vector128<double> value) {
            return Statics.YRoundToEven(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YRoundToZero_AcceleratedTypes"/>
        public override TypeCodeFlags YRoundToZero_AcceleratedTypes {
            get {
                return Statics.YRoundToZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YRoundToZero(Vector128<double> value) {
            return Statics.YRoundToZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG2_AcceleratedTypes {
            get {
                return Statics.YShuffleG2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG2(Vector128<float> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleG2(Vector128<double> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG2(Vector128<sbyte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG2(Vector128<byte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG2(Vector128<short> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG2(Vector128<ushort> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG2(Vector128<int> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG2(Vector128<uint> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleG2(Vector128<long> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleG2(Vector128<ulong> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

#if !REDUCE_MEMORY_USAGE
        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG2_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleG2_Const(Vector128<double> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG2_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG2_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG2_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG2_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG2_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG2_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleG2_Const(Vector128<long> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleG2_Const(Vector128<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }
#endif // !REDUCE_MEMORY_USAGE


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG4_AcceleratedTypes {
            get {
                return Statics.YShuffleG4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG4(Vector128<float> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG4(Vector128<sbyte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG4(Vector128<byte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG4(Vector128<short> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG4(Vector128<ushort> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG4(Vector128<int> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG4(Vector128<uint> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG4_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG4_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG4_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG4_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG4_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG4_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG4_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
            get {
                return Statics.YShuffleG4X2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG4X2(Vector128<float> source0, Vector128<float> source1, ShuffleControlG4 control, out Vector128<float> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{double}, Vector128{double}, ShuffleControlG4, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleG4X2(Vector128<double> source0, Vector128<double> source1, ShuffleControlG4 control, out Vector128<double> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG4X2(Vector128<sbyte> source0, Vector128<sbyte> source1, ShuffleControlG4 control, out Vector128<sbyte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG4X2(Vector128<byte> source0, Vector128<byte> source1, ShuffleControlG4 control, out Vector128<byte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG4X2(Vector128<short> source0, Vector128<short> source1, ShuffleControlG4 control, out Vector128<short> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG4X2(Vector128<ushort> source0, Vector128<ushort> source1, ShuffleControlG4 control, out Vector128<ushort> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG4X2(Vector128<int> source0, Vector128<int> source1, ShuffleControlG4 control, out Vector128<int> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG4X2(Vector128<uint> source0, Vector128<uint> source1, ShuffleControlG4 control, out Vector128<uint> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleG4X2(Vector128<long> source0, Vector128<long> source1, ShuffleControlG4 control, out Vector128<long> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleG4X2(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control, out Vector128<ulong> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG4X2_Const(Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<float> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{double}, Vector128{double}, ShuffleControlG4, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleG4X2_Const(Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<double> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG4X2_Const(Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<sbyte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG4X2_Const(Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<byte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG4X2_Const(Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<short> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG4X2_Const(Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ushort> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG4X2_Const(Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<int> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG4X2_Const(Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<uint> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleG4X2_Const(Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<long> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleG4X2_Const(Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ulong> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
                return Statics.YShuffleInsert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleInsert(Vector128<float> back, Vector128<float> vector, Vector128<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleInsert(Vector128<double> back, Vector128<double> vector, Vector128<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleInsert(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleInsert(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleInsert(Vector128<short> back, Vector128<short> vector, Vector128<short> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleInsert(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleInsert(Vector128<int> back, Vector128<int> vector, Vector128<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleInsert(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleInsert(Vector128<long> back, Vector128<long> vector, Vector128<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleInsert(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleInsert_Core(Vector128<float> back, Vector128<float> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleInsert_Core(Vector128<double> back, Vector128<double> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleInsert_Core(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleInsert_Core(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleInsert_Core(Vector128<short> back, Vector128<short> vector, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleInsert_Core(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleInsert_Core(Vector128<int> back, Vector128<int> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleInsert_Core(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleInsert_Core(Vector128<long> back, Vector128<long> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleInsert_Core(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
                return Statics.YShuffleKernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleKernel(Vector128<float> vector, Vector128<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleKernel(Vector128<double> vector, Vector128<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleKernel(Vector128<int> vector, Vector128<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleKernel(Vector128<uint> vector, Vector128<uint> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleKernel(Vector128<long> vector, Vector128<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleKernel(Vector128<ulong> vector, Vector128<ulong> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleKernel_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleKernel_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleKernel_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleKernel_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleKernel_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleKernel_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleKernel_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleKernel_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleKernel_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleKernel_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

#endif
    }
}
