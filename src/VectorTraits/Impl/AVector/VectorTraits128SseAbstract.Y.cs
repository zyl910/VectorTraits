using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Impl.AVector {
    using Statics = VectorTraits128Sse.Statics;

    partial class VectorTraits128SseAbstract {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IVectorTraits.YBitToByte_IsAccelerated"/>
        public override bool YBitToByte_IsAccelerated {
            get {
                return Statics.YBitToByte_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YBitToByte"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YBitToByte(ulong value) {
            return Statics.YBitToByte(value);
        }


        /// <inheritdoc cref="IVectorTraits.YBitToInt16_IsAccelerated"/>
        public override bool YBitToInt16_IsAccelerated {
            get {
                return Statics.YBitToInt16_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YBitToInt16"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YBitToInt16(ulong value) {
            return Statics.YBitToInt16(value);
        }


        /// <inheritdoc cref="IVectorTraits.YBitToInt32_IsAccelerated"/>
        public override bool YBitToInt32_IsAccelerated {
            get {
                return Statics.YBitToInt32_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YBitToInt32"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YBitToInt32(ulong value) {
            return Statics.YBitToInt32(value);
        }


        /// <inheritdoc cref="IVectorTraits.YBitToInt64_IsAccelerated"/>
        public override bool YBitToInt64_IsAccelerated {
            get {
                return Statics.YBitToInt64_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YBitToInt64"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YBitToInt64(ulong value) {
            return Statics.YBitToInt64(value);
        }


        /// <inheritdoc cref="IVectorTraits.YClamp_AcceleratedTypes"/>
        public override TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return Statics.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YClamp(Vector<float> value, Vector<float> amin, Vector<float> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{double}, Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YClamp(Vector<double> value, Vector<double> amin, Vector<double> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YClamp(Vector<sbyte> value, Vector<sbyte> amin, Vector<sbyte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YClamp(Vector<byte> value, Vector<byte> amin, Vector<byte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YClamp(Vector<short> value, Vector<short> amin, Vector<short> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YClamp(Vector<ushort> value, Vector<ushort> amin, Vector<ushort> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YClamp(Vector<int> value, Vector<int> amin, Vector<int> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YClamp(Vector<uint> value, Vector<uint> amin, Vector<uint> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YClamp(Vector<long> value, Vector<long> amin, Vector<long> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YClamp(Vector<ulong> value, Vector<ulong> amin, Vector<ulong> amax) {
            return Statics.YClamp(value, amin, amax);
        }


        /// <inheritdoc cref="IVectorTraits.YCopySign_AcceleratedTypes"/>
        public override TypeCodeFlags YCopySign_AcceleratedTypes {
            get {
                return Statics.YCopySign_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YCopySign(Vector<float> value, Vector<float> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YCopySign(Vector<double> value, Vector<double> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YCopySign(Vector<sbyte> value, Vector<sbyte> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YCopySign(Vector<short> value, Vector<short> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YCopySign(Vector<int> value, Vector<int> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IVectorTraits.YCopySign(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YCopySign(Vector<long> value, Vector<long> sign) {
            return Statics.YCopySign(value, sign);
        }


        /// <inheritdoc cref="IVectorTraits.YIsAllTrue_AcceleratedTypes"/>
        public override TypeCodeFlags YIsAllTrue_AcceleratedTypes {
            get {
                return Statics.YIsAllTrue_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsAllTrue{T}(Vector{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool YIsAllTrue<T>(Vector<T> value) where T : struct {
            return Statics.YIsAllTrue(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsAnyTrue_AcceleratedTypes"/>
        public override TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
            get {
                return Statics.YIsAnyTrue_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsAnyTrue{T}(Vector{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool YIsAnyTrue<T>(Vector<T> value) where T : struct {
            return Statics.YIsAnyTrue(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger_AcceleratedTypes"/>
        public override TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
            get {
                return Statics.YIsEvenInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsEvenInteger(Vector<float> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsEvenInteger(Vector<double> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YIsEvenInteger(Vector<sbyte> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YIsEvenInteger(Vector<byte> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YIsEvenInteger(Vector<short> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YIsEvenInteger(Vector<ushort> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsEvenInteger(Vector<int> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YIsEvenInteger(Vector<uint> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsEvenInteger(Vector<long> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsEvenInteger(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YIsEvenInteger(Vector<ulong> value) {
            return Statics.YIsEvenInteger(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsFinite_AcceleratedTypes"/>
        public override TypeCodeFlags YIsFinite_AcceleratedTypes {
            get {
                return Statics.YIsFinite_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsFinite(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsFinite(Vector<float> value) {
            return Statics.YIsFinite(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsFinite(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsFinite(Vector<double> value) {
            return Statics.YIsFinite(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsInfinity_AcceleratedTypes"/>
        public override TypeCodeFlags YIsInfinity_AcceleratedTypes {
            get {
                return Statics.YIsInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsInfinity(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsInfinity(Vector<float> value) {
            return Statics.YIsInfinity(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsInfinity(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsInfinity(Vector<double> value) {
            return Statics.YIsInfinity(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN_AcceleratedTypes"/>
        public override TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
            get {
                return Statics.YIsInfinityOrNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsInfinityOrNaN(Vector<float> value) {
            return Statics.YIsInfinityOrNaN(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsInfinityOrNaN(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsInfinityOrNaN(Vector<double> value) {
            return Statics.YIsInfinityOrNaN(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsInteger_AcceleratedTypes"/>
        public override TypeCodeFlags YIsInteger_AcceleratedTypes {
            get {
                return Statics.YIsInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsInteger(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsInteger(Vector<float> value) {
            return Statics.YIsInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsInteger(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsInteger(Vector<double> value) {
            return Statics.YIsInteger(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNaN_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNaN_AcceleratedTypes {
            get {
                return Statics.YIsNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNaN(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNaN(Vector<float> value) {
            return Statics.YIsNaN(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNaN(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNaN(Vector<double> value) {
            return Statics.YIsNaN(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNegative_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNegative_AcceleratedTypes {
            get {
                return Statics.YIsNegative_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNegative(Vector<float> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNegative(Vector<double> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YIsNegative(Vector<sbyte> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YIsNegative(Vector<short> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNegative(Vector<int> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegative(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNegative(Vector<long> value) {
            return Statics.YIsNegative(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
            get {
                return Statics.YIsNegativeInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNegativeInfinity(Vector<float> value) {
            return Statics.YIsNegativeInfinity(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegativeInfinity(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNegativeInfinity(Vector<double> value) {
            return Statics.YIsNegativeInfinity(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNegativeZero_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
            get {
                return Statics.YIsNegativeZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegativeZero(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNegativeZero(Vector<float> value) {
            return Statics.YIsNegativeZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNegativeZero(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNegativeZero(Vector<double> value) {
            return Statics.YIsNegativeZero(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNormal_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNormal_AcceleratedTypes {
            get {
                return Statics.YIsNormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNormal(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNormal(Vector<float> value) {
            return Statics.YIsNormal(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNormal(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNormal(Vector<double> value) {
            return Statics.YIsNormal(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNotEquals_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNotEquals_AcceleratedTypes {
            get {
                return Statics.YIsNotEquals_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YIsNotEquals(Vector<float> left, Vector<float> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YIsNotEquals(Vector<double> left, Vector<double> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YIsNotEquals(Vector<sbyte> left, Vector<sbyte> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YIsNotEquals(Vector<byte> left, Vector<byte> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YIsNotEquals(Vector<short> left, Vector<short> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YIsNotEquals(Vector<ushort> left, Vector<ushort> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNotEquals(Vector<int> left, Vector<int> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YIsNotEquals(Vector<uint> left, Vector<uint> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNotEquals(Vector<long> left, Vector<long> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotEquals(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YIsNotEquals(Vector<ulong> left, Vector<ulong> right) {
            return Statics.YIsNotEquals(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.YIsNotNaN_AcceleratedTypes"/>
        public override TypeCodeFlags YIsNotNaN_AcceleratedTypes {
            get {
                return Statics.YIsNotNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotNaN(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsNotNaN(Vector<float> value) {
            return Statics.YIsNotNaN(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsNotNaN(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsNotNaN(Vector<double> value) {
            return Statics.YIsNotNaN(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsOddInteger_AcceleratedTypes"/>
        public override TypeCodeFlags YIsOddInteger_AcceleratedTypes {
            get {
                return Statics.YIsOddInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsOddInteger(Vector<float> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsOddInteger(Vector<double> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YIsOddInteger(Vector<sbyte> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YIsOddInteger(Vector<byte> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YIsOddInteger(Vector<short> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YIsOddInteger(Vector<ushort> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsOddInteger(Vector<int> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YIsOddInteger(Vector<uint> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsOddInteger(Vector<long> value) {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsOddInteger(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YIsOddInteger(Vector<ulong> value) {
            return Statics.YIsOddInteger(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsPositive_AcceleratedTypes"/>
        public override TypeCodeFlags YIsPositive_AcceleratedTypes {
            get {
                return Statics.YIsPositive_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsPositive(Vector<float> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsPositive(Vector<double> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YIsPositive(Vector<sbyte> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YIsPositive(Vector<short> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsPositive(Vector<int> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositive(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsPositive(Vector<long> value) {
            return Statics.YIsPositive(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity_AcceleratedTypes"/>
        public override TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
            get {
                return Statics.YIsPositiveInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsPositiveInfinity(Vector<float> value) {
            return Statics.YIsPositiveInfinity(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsPositiveInfinity(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsPositiveInfinity(Vector<double> value) {
            return Statics.YIsPositiveInfinity(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsSubnormal_AcceleratedTypes"/>
        public override TypeCodeFlags YIsSubnormal_AcceleratedTypes {
            get {
                return Statics.YIsSubnormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsSubnormal(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsSubnormal(Vector<float> value) {
            return Statics.YIsSubnormal(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsSubnormal(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsSubnormal(Vector<double> value) {
            return Statics.YIsSubnormal(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsZero_AcceleratedTypes"/>
        public override TypeCodeFlags YIsZero_AcceleratedTypes {
            get {
                return Statics.YIsZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsZero(Vector<float> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsZero(Vector<double> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YIsZero(Vector<sbyte> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YIsZero(Vector<byte> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YIsZero(Vector<short> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YIsZero(Vector<ushort> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsZero(Vector<int> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YIsZero(Vector<uint> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsZero(Vector<long> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZero(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YIsZero(Vector<ulong> value) {
            return Statics.YIsZero(value);
        }


        /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal_AcceleratedTypes"/>
        public override TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
            get {
                return Statics.YIsZeroOrSubnormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YIsZeroOrSubnormal(Vector<float> value) {
            return Statics.YIsZeroOrSubnormal(value);
        }

        /// <inheritdoc cref="IVectorTraits.YIsZeroOrSubnormal(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YIsZeroOrSubnormal(Vector<double> value) {
            return Statics.YIsZeroOrSubnormal(value);
        }


        /// <inheritdoc cref="IVectorTraits.YMaxNumber_AcceleratedTypes"/>
        public override TypeCodeFlags YMaxNumber_AcceleratedTypes {
            get {
                return Statics.YMaxNumber_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YMaxNumber(Vector<float> left, Vector<float> right) {
            return Statics.YMaxNumber(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YMaxNumber(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YMaxNumber(Vector<double> left, Vector<double> right) {
            return Statics.YMaxNumber(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.YMinNumber_AcceleratedTypes"/>
        public override TypeCodeFlags YMinNumber_AcceleratedTypes {
            get {
                return Statics.YMinNumber_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YMinNumber(Vector<float> left, Vector<float> right) {
            return Statics.YMinNumber(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.YMinNumber(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YMinNumber(Vector<double> left, Vector<double> right) {
            return Statics.YMinNumber(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_AcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_FullAcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{short}, Vector{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YNarrowSaturate(Vector<short> lower, Vector<short> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ushort}, Vector{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YNarrowSaturate(Vector<ushort> lower, Vector<ushort> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{int}, Vector{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YNarrowSaturate(Vector<int> lower, Vector<int> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{uint}, Vector{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YNarrowSaturate(Vector<uint> lower, Vector<uint> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{long}, Vector{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YNarrowSaturate(Vector<long> lower, Vector<long> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ulong}, Vector{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YNarrowSaturate(Vector<ulong> lower, Vector<ulong> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }


        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{short}, Vector{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YNarrowSaturateUnsigned(Vector<short> lower, Vector<short> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{int}, Vector{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YNarrowSaturateUnsigned(Vector<int> lower, Vector<int> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{long}, Vector{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YNarrowSaturateUnsigned(Vector<long> lower, Vector<long> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }


        /// <inheritdoc cref="IVectorTraits.YOrNot_AcceleratedTypes"/>
        public override TypeCodeFlags YOrNot_AcceleratedTypes {
            get {
                return Statics.YOrNot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YOrNot{T}(Vector{T}, Vector{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<T> YOrNot<T>(Vector<T> left, Vector<T> right) where T : struct {
            return Statics.YOrNot(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.YRoundToEven_AcceleratedTypes"/>
        public override TypeCodeFlags YRoundToEven_AcceleratedTypes {
            get {
                return Statics.YRoundToEven_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YRoundToEven(Vector<float> value) {
            return Statics.YRoundToEven(value);
        }

        /// <inheritdoc cref="IVectorTraits.YRoundToEven(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YRoundToEven(Vector<double> value) {
            return Statics.YRoundToEven(value);
        }


        /// <inheritdoc cref="IVectorTraits.YRoundToZero_AcceleratedTypes"/>
        public override TypeCodeFlags YRoundToZero_AcceleratedTypes {
            get {
                return Statics.YRoundToZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YRoundToZero(Vector<float> value) {
            return Statics.YRoundToZero(value);
        }

        /// <inheritdoc cref="IVectorTraits.YRoundToZero(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YRoundToZero(Vector<double> value) {
            return Statics.YRoundToZero(value);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleG2_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG2_AcceleratedTypes {
            get {
                return Statics.YShuffleG2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG2(Vector<float> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleG2(Vector<double> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleG2(Vector<sbyte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleG2(Vector<byte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleG2(Vector<short> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleG2(Vector<ushort> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleG2(Vector<int> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleG2(Vector<uint> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleG2(Vector<long> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleG2(Vector<ulong> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

#if !REDUCE_MEMORY_USAGE
        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG2_Const(Vector<float> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleG2_Const(Vector<double> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleG2_Const(Vector<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleG2_Const(Vector<byte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleG2_Const(Vector<short> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleG2_Const(Vector<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleG2_Const(Vector<int> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleG2_Const(Vector<uint> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleG2_Const(Vector<long> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleG2_Const(Vector<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }
#endif // !REDUCE_MEMORY_USAGE


        /// <inheritdoc cref="IVectorTraits.YShuffleG4_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG4_AcceleratedTypes {
            get {
                return Statics.YShuffleG4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG4(Vector<float> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleG4(Vector<sbyte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleG4(Vector<byte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleG4(Vector<short> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleG4(Vector<ushort> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleG4(Vector<int> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleG4(Vector<uint> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG4_Const(Vector<float> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleG4_Const(Vector<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleG4_Const(Vector<byte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleG4_Const(Vector<short> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleG4_Const(Vector<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleG4_Const(Vector<int> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleG4_Const(Vector<uint> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
            get {
                return Statics.YShuffleG4X2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{float}, Vector{float}, ShuffleControlG4, out Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG4X2(Vector<float> source0, Vector<float> source1, ShuffleControlG4 control, out Vector<float> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{double}, Vector{double}, ShuffleControlG4, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleG4X2(Vector<double> source0, Vector<double> source1, ShuffleControlG4 control, out Vector<double> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleG4X2(Vector<sbyte> source0, Vector<sbyte> source1, ShuffleControlG4 control, out Vector<sbyte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleG4X2(Vector<byte> source0, Vector<byte> source1, ShuffleControlG4 control, out Vector<byte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{short}, Vector{short}, ShuffleControlG4, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleG4X2(Vector<short> source0, Vector<short> source1, ShuffleControlG4 control, out Vector<short> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ushort}, Vector{ushort}, ShuffleControlG4, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleG4X2(Vector<ushort> source0, Vector<ushort> source1, ShuffleControlG4 control, out Vector<ushort> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{int}, Vector{int}, ShuffleControlG4, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleG4X2(Vector<int> source0, Vector<int> source1, ShuffleControlG4 control, out Vector<int> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{uint}, Vector{uint}, ShuffleControlG4, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleG4X2(Vector<uint> source0, Vector<uint> source1, ShuffleControlG4 control, out Vector<uint> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{long}, Vector{long}, ShuffleControlG4, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleG4X2(Vector<long> source0, Vector<long> source1, ShuffleControlG4 control, out Vector<long> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleG4X2(Vector<ulong> source0, Vector<ulong> source1, ShuffleControlG4 control, out Vector<ulong> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{float}, Vector{float}, ShuffleControlG4, out Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG4X2_Const(Vector<float> source0, Vector<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<float> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{double}, Vector{double}, ShuffleControlG4, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleG4X2_Const(Vector<double> source0, Vector<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<double> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleG4X2_Const(Vector<sbyte> source0, Vector<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<sbyte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleG4X2_Const(Vector<byte> source0, Vector<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<byte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{short}, Vector{short}, ShuffleControlG4, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleG4X2_Const(Vector<short> source0, Vector<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<short> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{ushort}, Vector{ushort}, ShuffleControlG4, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleG4X2_Const(Vector<ushort> source0, Vector<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ushort> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{int}, Vector{int}, ShuffleControlG4, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleG4X2_Const(Vector<int> source0, Vector<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<int> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{uint}, Vector{uint}, ShuffleControlG4, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleG4X2_Const(Vector<uint> source0, Vector<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<uint> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{long}, Vector{long}, ShuffleControlG4, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleG4X2_Const(Vector<long> source0, Vector<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<long> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleG4X2_Const(Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ulong> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
                return Statics.YShuffleInsert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleInsert(Vector<float> back, Vector<float> vector, Vector<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleInsert(Vector<double> back, Vector<double> vector, Vector<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleInsert(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleInsert(Vector<byte> back, Vector<byte> vector, Vector<byte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleInsert(Vector<short> back, Vector<short> vector, Vector<short> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleInsert(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleInsert(Vector<int> back, Vector<int> vector, Vector<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleInsert(Vector<uint> back, Vector<uint> vector, Vector<uint> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleInsert(Vector<long> back, Vector<long> vector, Vector<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleInsert(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleInsert_Core(Vector<float> back, Vector<float> vector, Vector<int> args0, Vector<int> args1, Vector<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleInsert_Core(Vector<double> back, Vector<double> vector, Vector<long> args0, Vector<long> args1, Vector<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleInsert_Core(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleInsert_Core(Vector<byte> back, Vector<byte> vector, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleInsert_Core(Vector<short> back, Vector<short> vector, Vector<short> args0, Vector<short> args1, Vector<short> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleInsert_Core(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleInsert_Core(Vector<int> back, Vector<int> vector, Vector<int> args0, Vector<int> args1, Vector<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleInsert_Core(Vector<uint> back, Vector<uint> vector, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleInsert_Core(Vector<long> back, Vector<long> vector, Vector<long> args0, Vector<long> args1, Vector<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleInsert_Core(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
                return Statics.YShuffleKernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleKernel(Vector<float> vector, Vector<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleKernel(Vector<double> vector, Vector<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleKernel(Vector<sbyte> vector, Vector<sbyte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleKernel(Vector<byte> vector, Vector<byte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleKernel(Vector<short> vector, Vector<short> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleKernel(Vector<ushort> vector, Vector<ushort> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleKernel(Vector<int> vector, Vector<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleKernel(Vector<uint> vector, Vector<uint> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleKernel(Vector<long> vector, Vector<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleKernel(Vector<ulong> vector, Vector<ulong> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{float}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleKernel_Core(Vector<float> vector, Vector<int> args0, Vector<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{double}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleKernel_Core(Vector<double> vector, Vector<long> args0, Vector<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YShuffleKernel_Core(Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> YShuffleKernel_Core(Vector<byte> vector, Vector<byte> args0, Vector<byte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YShuffleKernel_Core(Vector<short> vector, Vector<short> args0, Vector<short> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> YShuffleKernel_Core(Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YShuffleKernel_Core(Vector<int> vector, Vector<int> args0, Vector<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> YShuffleKernel_Core(Vector<uint> vector, Vector<uint> args0, Vector<uint> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleKernel_Core(Vector<long> vector, Vector<long> args0, Vector<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleKernel_Core(Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }


        /// <inheritdoc cref="IVectorTraits.YSign_AcceleratedTypes"/>
        public override TypeCodeFlags YSign_AcceleratedTypes {
            get {
                return Statics.YSign_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YSign(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YSign(Vector<float> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IVectorTraits.YSign(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YSign(Vector<double> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IVectorTraits.YSign(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> YSign(Vector<sbyte> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IVectorTraits.YSign(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> YSign(Vector<short> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IVectorTraits.YSign(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> YSign(Vector<int> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IVectorTraits.YSign(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YSign(Vector<long> value) {
            return Statics.YSign(value);
        }


        /// <inheritdoc cref="IVectorTraits.YSignFloat_AcceleratedTypes"/>
        public override TypeCodeFlags YSignFloat_AcceleratedTypes {
            get {
                return Statics.YSignFloat_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YSignFloat(Vector<float> value) {
            return Statics.YSignFloat(value);
        }

        /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YSignFloat(Vector<double> value) {
            return Statics.YSignFloat(value);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
