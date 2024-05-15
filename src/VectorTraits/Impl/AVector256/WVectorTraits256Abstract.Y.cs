using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Numerics;
using System.Runtime.InteropServices;
#endif

namespace Zyl.VectorTraits.Impl.AVector256 {
    using Statics = WVectorTraits256Base.Statics;

    partial class WVectorTraits256Abstract {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits256.YBitToByte_IsAccelerated"/>
        public virtual bool YBitToByte_IsAccelerated {
            get {
                return Statics.YBitToByte_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YBitToByte"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YBitToByte(uint value) {
            return Statics.YBitToByte(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YBitToInt16_IsAccelerated"/>
        public virtual bool YBitToInt16_IsAccelerated {
            get {
                return Statics.YBitToInt16_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YBitToInt16"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YBitToInt16(uint value) {
            return Statics.YBitToInt16(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YBitToInt32_IsAccelerated"/>
        public virtual bool YBitToInt32_IsAccelerated {
            get {
                return Statics.YBitToInt32_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YBitToInt32"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YBitToInt32(uint value) {
            return Statics.YBitToInt32(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YBitToInt64_IsAccelerated"/>
        public virtual bool YBitToInt64_IsAccelerated {
            get {
                return Statics.YBitToInt64_IsAccelerated;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YBitToInt64"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YBitToInt64(uint value) {
            return Statics.YBitToInt64(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YClamp_AcceleratedTypes"/>
        public virtual TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return Statics.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{float}, Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YClamp(Vector256<float> value, Vector256<float> amin, Vector256<float> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{double}, Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YClamp(Vector256<double> value, Vector256<double> amin, Vector256<double> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YClamp(Vector256<sbyte> value, Vector256<sbyte> amin, Vector256<sbyte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YClamp(Vector256<byte> value, Vector256<byte> amin, Vector256<byte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YClamp(Vector256<short> value, Vector256<short> amin, Vector256<short> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YClamp(Vector256<ushort> value, Vector256<ushort> amin, Vector256<ushort> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YClamp(Vector256<int> value, Vector256<int> amin, Vector256<int> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YClamp(Vector256<uint> value, Vector256<uint> amin, Vector256<uint> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YClamp(Vector256<long> value, Vector256<long> amin, Vector256<long> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YClamp(Vector256<ulong> value, Vector256<ulong> amin, Vector256<ulong> amax) {
            return Statics.YClamp(value, amin, amax);
        }


        /// <inheritdoc cref="IWVectorTraits256.YCopySign_AcceleratedTypes"/>
        public virtual TypeCodeFlags YCopySign_AcceleratedTypes {
            get {
                return Statics.YCopySign_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YCopySign(Vector256<float> value, Vector256<float> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YCopySign(Vector256<double> value, Vector256<double> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YCopySign(Vector256<sbyte> value, Vector256<sbyte> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YCopySign(Vector256<short> value, Vector256<short> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YCopySign(Vector256<int> value, Vector256<int> sign) {
            return Statics.YCopySign(value, sign);
        }

        /// <inheritdoc cref="IWVectorTraits256.YCopySign(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YCopySign(Vector256<long> value, Vector256<long> sign) {
            return Statics.YCopySign(value, sign);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsAllTrue_AcceleratedTypes {
            get {
                return Statics.YIsAllTrue_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual bool YIsAllTrue<T>(Vector256<T> value) where T : struct {
            return Statics.YIsAllTrue(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
            get {
                return Statics.YIsAnyTrue_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual bool YIsAnyTrue<T>(Vector256<T> value) where T : struct {
            return Statics.YIsAnyTrue(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsEvenInteger_AcceleratedTypes {
            get {
                return Statics.YIsEvenInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsEvenInteger(Vector256<float> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsEvenInteger(Vector256<double> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YIsEvenInteger(Vector256<sbyte> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YIsEvenInteger(Vector256<byte> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YIsEvenInteger(Vector256<short> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YIsEvenInteger(Vector256<ushort> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsEvenInteger(Vector256<int> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YIsEvenInteger(Vector256<uint> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsEvenInteger(Vector256<long> value) {
            return Statics.YIsEvenInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsEvenInteger(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YIsEvenInteger(Vector256<ulong> value) {
            return Statics.YIsEvenInteger(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsFinite_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsFinite_AcceleratedTypes {
            get {
                return Statics.YIsFinite_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsFinite(Vector256<float> value) {
            return Statics.YIsFinite(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsFinite(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsFinite(Vector256<double> value) {
            return Statics.YIsFinite(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsInfinity_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsInfinity_AcceleratedTypes {
            get {
                return Statics.YIsInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsInfinity(Vector256<float> value) {
            return Statics.YIsInfinity(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsInfinity(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsInfinity(Vector256<double> value) {
            return Statics.YIsInfinity(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsInfinityOrNaN_AcceleratedTypes {
            get {
                return Statics.YIsInfinityOrNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsInfinityOrNaN(Vector256<float> value) {
            return Statics.YIsInfinityOrNaN(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsInfinityOrNaN(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsInfinityOrNaN(Vector256<double> value) {
            return Statics.YIsInfinityOrNaN(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsInteger_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsInteger_AcceleratedTypes {
            get {
                return Statics.YIsInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsInteger(Vector256<float> value) {
            return Statics.YIsInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsInteger(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsInteger(Vector256<double> value) {
            return Statics.YIsInteger(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNaN_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNaN_AcceleratedTypes {
            get {
                return Statics.YIsNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsNaN(Vector256<float> value) {
            return Statics.YIsNaN(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNaN(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsNaN(Vector256<double> value) {
            return Statics.YIsNaN(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNegative_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNegative_AcceleratedTypes {
            get {
                return Statics.YIsNegative_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsNegative(Vector256<float> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsNegative(Vector256<double> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YIsNegative(Vector256<sbyte> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YIsNegative(Vector256<short> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsNegative(Vector256<int> value) {
            return Statics.YIsNegative(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegative(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsNegative(Vector256<long> value) {
            return Statics.YIsNegative(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNegativeInfinity_AcceleratedTypes {
            get {
                return Statics.YIsNegativeInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsNegativeInfinity(Vector256<float> value) {
            return Statics.YIsNegativeInfinity(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegativeInfinity(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsNegativeInfinity(Vector256<double> value) {
            return Statics.YIsNegativeInfinity(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNegativeZero_AcceleratedTypes {
            get {
                return Statics.YIsNegativeZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsNegativeZero(Vector256<float> value) {
            return Statics.YIsNegativeZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNegativeZero(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsNegativeZero(Vector256<double> value) {
            return Statics.YIsNegativeZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNormal_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNormal_AcceleratedTypes {
            get {
                return Statics.YIsNormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsNormal(Vector256<float> value) {
            return Statics.YIsNormal(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNormal(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsNormal(Vector256<double> value) {
            return Statics.YIsNormal(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNotEquals_AcceleratedTypes {
            get {
                return Statics.YIsNotEquals_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YIsNotEquals(Vector256<float> left, Vector256<float> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YIsNotEquals(Vector256<double> left, Vector256<double> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YIsNotEquals(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YIsNotEquals(Vector256<byte> left, Vector256<byte> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YIsNotEquals(Vector256<short> left, Vector256<short> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YIsNotEquals(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsNotEquals(Vector256<int> left, Vector256<int> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YIsNotEquals(Vector256<uint> left, Vector256<uint> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsNotEquals(Vector256<long> left, Vector256<long> right) {
            return Statics.YIsNotEquals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotEquals(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YIsNotEquals(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.YIsNotEquals(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsNotNaN_AcceleratedTypes {
            get {
                return Statics.YIsNotNaN_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsNotNaN(Vector256<float> value) {
            return Statics.YIsNotNaN(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsNotNaN(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsNotNaN(Vector256<double> value) {
            return Statics.YIsNotNaN(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsOddInteger_AcceleratedTypes
        {
            get
            {
                return Statics.YIsOddInteger_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsOddInteger(Vector256<float> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsOddInteger(Vector256<double> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YIsOddInteger(Vector256<sbyte> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YIsOddInteger(Vector256<byte> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YIsOddInteger(Vector256<short> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YIsOddInteger(Vector256<ushort> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsOddInteger(Vector256<int> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YIsOddInteger(Vector256<uint> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsOddInteger(Vector256<long> value)
        {
            return Statics.YIsOddInteger(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsOddInteger(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YIsOddInteger(Vector256<ulong> value)
        {
            return Statics.YIsOddInteger(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsPositive_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsPositive_AcceleratedTypes {
            get {
                return Statics.YIsPositive_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsPositive(Vector256<float> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsPositive(Vector256<double> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YIsPositive(Vector256<sbyte> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YIsPositive(Vector256<short> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsPositive(Vector256<int> value) {
            return Statics.YIsPositive(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositive(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsPositive(Vector256<long> value) {
            return Statics.YIsPositive(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsPositiveInfinity_AcceleratedTypes {
            get {
                return Statics.YIsPositiveInfinity_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsPositiveInfinity(Vector256<float> value) {
            return Statics.YIsPositiveInfinity(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsPositiveInfinity(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsPositiveInfinity(Vector256<double> value) {
            return Statics.YIsPositiveInfinity(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsSubnormal_AcceleratedTypes {
            get {
                return Statics.YIsSubnormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsSubnormal(Vector256<float> value) {
            return Statics.YIsSubnormal(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsSubnormal(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsSubnormal(Vector256<double> value) {
            return Statics.YIsSubnormal(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsZero_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsZero_AcceleratedTypes {
            get {
                return Statics.YIsZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsZero(Vector256<float> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsZero(Vector256<double> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YIsZero(Vector256<sbyte> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YIsZero(Vector256<byte> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YIsZero(Vector256<short> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YIsZero(Vector256<ushort> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsZero(Vector256<int> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YIsZero(Vector256<uint> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsZero(Vector256<long> value) {
            return Statics.YIsZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZero(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YIsZero(Vector256<ulong> value) {
            return Statics.YIsZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsZeroOrSubnormal_AcceleratedTypes {
            get {
                return Statics.YIsZeroOrSubnormal_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YIsZeroOrSubnormal(Vector256<float> value) {
            return Statics.YIsZeroOrSubnormal(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsZeroOrSubnormal(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YIsZeroOrSubnormal(Vector256<double> value) {
            return Statics.YIsZeroOrSubnormal(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YMaxNumber_AcceleratedTypes"/>
        public virtual TypeCodeFlags YMaxNumber_AcceleratedTypes {
            get {
                return Statics.YMaxNumber_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YMaxNumber(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YMaxNumber(Vector256<float> left, Vector256<float> right) {
            return Statics.YMaxNumber(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.YMaxNumber(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YMaxNumber(Vector256<double> left, Vector256<double> right) {
            return Statics.YMaxNumber(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.YMinNumber_AcceleratedTypes"/>
        public virtual TypeCodeFlags YMinNumber_AcceleratedTypes {
            get {
                return Statics.YMinNumber_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YMinNumber(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YMinNumber(Vector256<float> left, Vector256<float> right) {
            return Statics.YMinNumber(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.YMinNumber(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YMinNumber(Vector256<double> left, Vector256<double> right) {
            return Statics.YMinNumber(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate_AcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate_FullAcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{short}, Vector256{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YNarrowSaturate(Vector256<short> lower, Vector256<short> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{ushort}, Vector256{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YNarrowSaturate(Vector256<ushort> lower, Vector256<ushort> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{int}, Vector256{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YNarrowSaturate(Vector256<int> lower, Vector256<int> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{uint}, Vector256{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YNarrowSaturate(Vector256<uint> lower, Vector256<uint> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{long}, Vector256{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YNarrowSaturate(Vector256<long> lower, Vector256<long> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{ulong}, Vector256{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YNarrowSaturate(Vector256<ulong> lower, Vector256<ulong> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{short}, Vector256{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YNarrowSaturateUnsigned(Vector256<short> lower, Vector256<short> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{int}, Vector256{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YNarrowSaturateUnsigned(Vector256<int> lower, Vector256<int> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{long}, Vector256{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YNarrowSaturateUnsigned(Vector256<long> lower, Vector256<long> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits256.YOrNot_AcceleratedTypes"/>
        public virtual TypeCodeFlags YOrNot_AcceleratedTypes {
            get {
                return Statics.YOrNot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YOrNot{T}(Vector256{T}, Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<T> YOrNot<T>(Vector256<T> left, Vector256<T> right) where T : struct {
            return Statics.YOrNot(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.YRoundToEven_AcceleratedTypes"/>
        public virtual TypeCodeFlags YRoundToEven_AcceleratedTypes {
            get {
                return Statics.YRoundToEven_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YRoundToEven(Vector256<float> value) {
            return Statics.YRoundToEven(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YRoundToEven(Vector256<double> value) {
            return Statics.YRoundToEven(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YRoundToZero_AcceleratedTypes"/>
        public virtual TypeCodeFlags YRoundToZero_AcceleratedTypes {
            get {
                return Statics.YRoundToZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YRoundToZero(Vector256<float> value) {
            return Statics.YRoundToZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YRoundToZero(Vector256<double> value) {
            return Statics.YRoundToZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleG2_AcceleratedTypes {
            get {
                return Statics.YShuffleG2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleG2(Vector256<float> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleG2(Vector256<double> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleG2(Vector256<sbyte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleG2(Vector256<byte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleG2(Vector256<short> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleG2(Vector256<ushort> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleG2(Vector256<int> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleG2(Vector256<uint> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleG2(Vector256<long> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleG2(Vector256<ulong> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

#if !REDUCE_MEMORY_USAGE
        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleG2_Const(Vector256<float> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleG2_Const(Vector256<double> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleG2_Const(Vector256<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleG2_Const(Vector256<byte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleG2_Const(Vector256<short> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleG2_Const(Vector256<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleG2_Const(Vector256<int> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleG2_Const(Vector256<uint> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleG2_Const(Vector256<long> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleG2_Const(Vector256<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }
#endif // !REDUCE_MEMORY_USAGE


        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleG4_AcceleratedTypes {
            get {
                return Statics.YShuffleG4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleG4(Vector256<float> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleG4(Vector256<double> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleG4(Vector256<sbyte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleG4(Vector256<byte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleG4(Vector256<short> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleG4(Vector256<ushort> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleG4(Vector256<int> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleG4(Vector256<uint> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleG4(Vector256<long> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleG4(Vector256<ulong> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleG4_Const(Vector256<float> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleG4_Const(Vector256<double> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleG4_Const(Vector256<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleG4_Const(Vector256<byte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleG4_Const(Vector256<short> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleG4_Const(Vector256<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleG4_Const(Vector256<int> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleG4_Const(Vector256<uint> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleG4_Const(Vector256<long> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleG4_Const(Vector256<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
            get {
                return Statics.YShuffleG4X2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{float}, Vector256{float}, ShuffleControlG4, out Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleG4X2(Vector256<float> source0, Vector256<float> source1, ShuffleControlG4 control, out Vector256<float> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{double}, Vector256{double}, ShuffleControlG4, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleG4X2(Vector256<double> source0, Vector256<double> source1, ShuffleControlG4 control, out Vector256<double> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{sbyte}, Vector256{sbyte}, ShuffleControlG4, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleG4X2(Vector256<sbyte> source0, Vector256<sbyte> source1, ShuffleControlG4 control, out Vector256<sbyte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleG4X2(Vector256<byte> source0, Vector256<byte> source1, ShuffleControlG4 control, out Vector256<byte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{short}, Vector256{short}, ShuffleControlG4, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleG4X2(Vector256<short> source0, Vector256<short> source1, ShuffleControlG4 control, out Vector256<short> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{ushort}, Vector256{ushort}, ShuffleControlG4, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleG4X2(Vector256<ushort> source0, Vector256<ushort> source1, ShuffleControlG4 control, out Vector256<ushort> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{int}, Vector256{int}, ShuffleControlG4, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleG4X2(Vector256<int> source0, Vector256<int> source1, ShuffleControlG4 control, out Vector256<int> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{uint}, Vector256{uint}, ShuffleControlG4, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleG4X2(Vector256<uint> source0, Vector256<uint> source1, ShuffleControlG4 control, out Vector256<uint> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{long}, Vector256{long}, ShuffleControlG4, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleG4X2(Vector256<long> source0, Vector256<long> source1, ShuffleControlG4 control, out Vector256<long> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{ulong}, Vector256{ulong}, ShuffleControlG4, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleG4X2(Vector256<ulong> source0, Vector256<ulong> source1, ShuffleControlG4 control, out Vector256<ulong> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{float}, Vector256{float}, ShuffleControlG4, out Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleG4X2_Const(Vector256<float> source0, Vector256<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<float> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{double}, Vector256{double}, ShuffleControlG4, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleG4X2_Const(Vector256<double> source0, Vector256<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<double> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{sbyte}, Vector256{sbyte}, ShuffleControlG4, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleG4X2_Const(Vector256<sbyte> source0, Vector256<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<sbyte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleG4X2_Const(Vector256<byte> source0, Vector256<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<byte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{short}, Vector256{short}, ShuffleControlG4, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleG4X2_Const(Vector256<short> source0, Vector256<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<short> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{ushort}, Vector256{ushort}, ShuffleControlG4, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleG4X2_Const(Vector256<ushort> source0, Vector256<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<ushort> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{int}, Vector256{int}, ShuffleControlG4, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleG4X2_Const(Vector256<int> source0, Vector256<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<int> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{uint}, Vector256{uint}, ShuffleControlG4, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleG4X2_Const(Vector256<uint> source0, Vector256<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<uint> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{long}, Vector256{long}, ShuffleControlG4, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleG4X2_Const(Vector256<long> source0, Vector256<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<long> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{ulong}, Vector256{ulong}, ShuffleControlG4, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleG4X2_Const(Vector256<ulong> source0, Vector256<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<ulong> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
                return Statics.YShuffleInsert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleInsert(Vector256<float> back, Vector256<float> vector, Vector256<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleInsert(Vector256<double> back, Vector256<double> vector, Vector256<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleInsert(Vector256<sbyte> back, Vector256<sbyte> vector, Vector256<sbyte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleInsert(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleInsert(Vector256<short> back, Vector256<short> vector, Vector256<short> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleInsert(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleInsert(Vector256<int> back, Vector256<int> vector, Vector256<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleInsert(Vector256<uint> back, Vector256<uint> vector, Vector256<uint> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleInsert(Vector256<long> back, Vector256<long> vector, Vector256<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleInsert(Vector256<ulong> back, Vector256<ulong> vector, Vector256<ulong> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleInsert_Core(Vector256<float> back, Vector256<float> vector, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleInsert_Core(Vector256<double> back, Vector256<double> vector, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleInsert_Core(Vector256<sbyte> back, Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleInsert_Core(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleInsert_Core(Vector256<short> back, Vector256<short> vector, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleInsert_Core(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleInsert_Core(Vector256<int> back, Vector256<int> vector, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleInsert_Core(Vector256<uint> back, Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleInsert_Core(Vector256<long> back, Vector256<long> vector, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleInsert_Core(Vector256<ulong> back, Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
                return Statics.YShuffleKernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleKernel(Vector256<float> vector, Vector256<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleKernel(Vector256<double> vector, Vector256<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleKernel(Vector256<sbyte> vector, Vector256<sbyte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleKernel(Vector256<byte> vector, Vector256<byte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleKernel(Vector256<short> vector, Vector256<short> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleKernel(Vector256<ushort> vector, Vector256<ushort> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleKernel(Vector256<int> vector, Vector256<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleKernel(Vector256<uint> vector, Vector256<uint> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleKernel(Vector256<long> vector, Vector256<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleKernel(Vector256<ulong> vector, Vector256<ulong> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleKernel_Core(Vector256<float> vector, Vector256<int> args0, Vector256<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleKernel_Core(Vector256<double> vector, Vector256<long> args0, Vector256<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleKernel_Core(Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleKernel_Core(Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleKernel_Core(Vector256<short> vector, Vector256<short> args0, Vector256<short> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleKernel_Core(Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleKernel_Core(Vector256<int> vector, Vector256<int> args0, Vector256<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleKernel_Core(Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleKernel_Core(Vector256<long> vector, Vector256<long> args0, Vector256<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleKernel_Core(Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleX2_AcceleratedTypes {
            get {
                return Statics.YShuffleX2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleX2(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleX2(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleX2(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleX2(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleX2(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleX2(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleX2(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleX2(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleX2(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleX2(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
            return Statics.YShuffleX2(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
            Statics.YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleX2_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleX2_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleX2_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleX2_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleX2_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleX2_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleX2_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleX2_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleX2_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleX2_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
            return Statics.YShuffleX2_Core(vector0, vector1, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
            get {
                return Statics.YShuffleX2Insert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleX2Insert(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleX2Insert(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleX2Insert(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleX2Insert(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleX2Insert(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleX2Insert(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleX2Insert(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleX2Insert(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleX2Insert(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleX2Insert(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
            return Statics.YShuffleX2Insert(back, vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Insert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
            Statics.YShuffleX2Insert_Args(indices, out args0, out args1, out args2, out args3, out args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleX2Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleX2Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleX2Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleX2Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleX2Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleX2Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleX2Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleX2Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleX2Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleX2Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
            return Statics.YShuffleX2Insert_Core(back, vector0, vector1, args0, args1, args2, args3, args4);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
            get {
                return Statics.YShuffleX2Kernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleX2Kernel(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleX2Kernel(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleX2Kernel(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleX2Kernel(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleX2Kernel(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleX2Kernel(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleX2Kernel(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleX2Kernel(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleX2Kernel(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleX2Kernel(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
            return Statics.YShuffleX2Kernel(vector0, vector1, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleX2Kernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3) {
            Statics.YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleX2Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleX2Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleX2Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleX2Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleX2Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleX2Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleX2Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleX2Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleX2Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleX2Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) {
            return Statics.YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
        }


        /// <inheritdoc cref="IWVectorTraits256.YSign_AcceleratedTypes"/>
        public virtual TypeCodeFlags YSign_AcceleratedTypes {
            get {
                return Statics.YSign_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YSign(Vector256<float> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YSign(Vector256<double> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YSign(Vector256<sbyte> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YSign(Vector256<short> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YSign(Vector256<int> value) {
            return Statics.YSign(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YSign(Vector256<long> value) {
            return Statics.YSign(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YSignFloat_AcceleratedTypes"/>
        public virtual TypeCodeFlags YSignFloat_AcceleratedTypes {
            get {
                return Statics.YSignFloat_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YSignFloat(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YSignFloat(Vector256<float> value) {
            return Statics.YSignFloat(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YSignFloat(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YSignFloat(Vector256<double> value) {
            return Statics.YSignFloat(value);
        }

#endif
    }
}
