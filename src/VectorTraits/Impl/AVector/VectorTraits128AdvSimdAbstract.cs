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
    using Statics = VectorTraits128AdvSimd.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - AdvSimd abstract.
    /// </summary>
    public abstract class VectorTraits128AdvSimdAbstract : VectorTraits128Abstract {

        /// <inheritdoc cref="IBaseTraits.IsSupported"/>
        public override bool IsSupported {
            get {
                return Statics.IsSupported;
            }
        }

        /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
        public override bool GetIsSupported(bool noStrict = false) {
            return Statics.GetIsSupported(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
        public override string GetUnsupportedMessage(bool noStrict = false) {
            return Statics.GetUnsupportedMessage(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
        public override void ThrowForUnsupported(bool noStrict = false) {
            Statics.ThrowForUnsupported(noStrict);
        }

#if NET5_0_OR_GREATER

        /// <inheritdoc cref="IVectorTraits.Ceiling_AcceleratedTypes"/>
        public override TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
                return Statics.Ceiling_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Ceiling(Vector<float> value) {
            return Statics.Ceiling(value);
        }

        /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Ceiling(Vector<double> value) {
            return Statics.Ceiling(value);
        }


        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits_AcceleratedTypes"/>
        public override TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
            get {
                return Statics.ExtractMostSignificantBits_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<float> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<double> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<sbyte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<byte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<short> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<ushort> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<int> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<uint> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<long> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong ExtractMostSignificantBits(Vector<ulong> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }


        /// <inheritdoc cref="IVectorTraits.Floor_AcceleratedTypes"/>
        public override TypeCodeFlags Floor_AcceleratedTypes {
            get {
                return Statics.Floor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Floor(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Floor(Vector<float> value) {
            return Statics.Floor(value);
        }

        /// <inheritdoc cref="IVectorTraits.Floor(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Floor(Vector<double> value) {
            return Statics.Floor(value);
        }


        /// <inheritdoc cref="IVectorTraits.Narrow_AcceleratedTypes"/>
        public override TypeCodeFlags Narrow_AcceleratedTypes {
            get {
                return Statics.Narrow_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{double}, Vector{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Narrow(Vector<double> lower, Vector<double> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{short}, Vector{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> Narrow(Vector<short> lower, Vector<short> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ushort}, Vector{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> Narrow(Vector<ushort> lower, Vector<ushort> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{int}, Vector{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> Narrow(Vector<int> lower, Vector<int> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{uint}, Vector{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> Narrow(Vector<uint> lower, Vector<uint> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{long}, Vector{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> Narrow(Vector<long> lower, Vector<long> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ulong}, Vector{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> Narrow(Vector<ulong> lower, Vector<ulong> upper) {
            return Statics.Narrow(lower, upper);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
                return Statics.ShiftLeft_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftLeft(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeft(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeft(Vector<short> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftLeft(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeft(Vector<int> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftLeft(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftLeft(Vector<long> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftLeftFast(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeftFast(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeftFast(Vector<short> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftLeftFast(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeftFast(Vector<int> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftLeftFast(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftLeftFast(Vector<long> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftLeftFast(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
                return Statics.ShiftRightArithmetic_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightArithmetic(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmeticFast(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightArithmeticFast(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightArithmeticFast(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightArithmeticFast(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
                return Statics.ShiftRightLogical_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightLogical(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftRightLogical(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightLogical(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftRightLogical(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightLogical(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftRightLogical(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightLogical(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftRightLogical(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightLogicalFast(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftRightLogicalFast(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightLogicalFast(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftRightLogicalFast(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightLogicalFast(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftRightLogicalFast(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightLogicalFast(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftRightLogicalFast(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        public override TypeCodeFlags Shuffle_AcceleratedTypes {
            get {
                return Statics.Shuffle_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Shuffle(Vector<float> vector, Vector<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Shuffle(Vector<double> vector, Vector<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> Shuffle(Vector<sbyte> vector, Vector<sbyte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> Shuffle(Vector<byte> vector, Vector<byte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> Shuffle(Vector<short> vector, Vector<short> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> Shuffle(Vector<ushort> vector, Vector<ushort> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> Shuffle(Vector<int> vector, Vector<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> Shuffle(Vector<uint> vector, Vector<uint> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> Shuffle(Vector<long> vector, Vector<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> Shuffle(Vector<ulong> vector, Vector<ulong> indices) {
            return Statics.Shuffle(vector, indices);
        }


        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{float}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Shuffle_Core(Vector<float> vector, Vector<int> args0, Vector<int> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{double}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Shuffle_Core(Vector<double> vector, Vector<long> args0, Vector<long> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> Shuffle_Core(Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> Shuffle_Core(Vector<byte> vector, Vector<byte> args0, Vector<byte> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> Shuffle_Core(Vector<short> vector, Vector<short> args0, Vector<short> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> Shuffle_Core(Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> Shuffle_Core(Vector<int> vector, Vector<int> args0, Vector<int> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> Shuffle_Core(Vector<uint> vector, Vector<uint> args0, Vector<uint> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> Shuffle_Core(Vector<long> vector, Vector<long> args0, Vector<long> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> Shuffle_Core(Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }


        /// <inheritdoc cref="IVectorTraits.Sum_AcceleratedTypes"/>
        public override TypeCodeFlags Sum_AcceleratedTypes {
            get {
                return Statics.Sum_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override float Sum(Vector<float> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override double Sum(Vector<double> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override sbyte Sum(Vector<sbyte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override byte Sum(Vector<byte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override short Sum(Vector<short> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ushort Sum(Vector<ushort> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int Sum(Vector<int> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint Sum(Vector<uint> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override long Sum(Vector<long> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong Sum(Vector<ulong> value) {
            return Statics.Sum(value);
        }


        /// <inheritdoc cref="IVectorTraits.Widen_AcceleratedTypes"/>
        public override TypeCodeFlags Widen_AcceleratedTypes {
            get {
                return Statics.Widen_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<float> source, out Vector<double> lower, out Vector<double> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<short> source, out Vector<int> lower, out Vector<int> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper) {
            Statics.Widen(source, out lower, out upper);
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

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleG4(Vector<double> source, ShuffleControlG4 control) {
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

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleG4(Vector<long> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleG4(Vector<ulong> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> YShuffleG4_Const(Vector<float> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> YShuffleG4_Const(Vector<double> source, [ConstantExpected] ShuffleControlG4 control) {
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

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> YShuffleG4_Const(Vector<long> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> YShuffleG4_Const(Vector<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
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

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{float}, Vector{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<float> Result0, Vector<float> Result1) YShuffleG4X2(Vector<float> source0, Vector<float> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{double}, Vector{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<double> Result0, Vector<double> Result1) YShuffleG4X2(Vector<double> source0, Vector<double> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<sbyte> Result0, Vector<sbyte> Result1) YShuffleG4X2(Vector<sbyte> source0, Vector<sbyte> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<byte> Result0, Vector<byte> Result1) YShuffleG4X2(Vector<byte> source0, Vector<byte> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{short}, Vector{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<short> Result0, Vector<short> Result1) YShuffleG4X2(Vector<short> source0, Vector<short> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ushort}, Vector{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<ushort> Result0, Vector<ushort> Result1) YShuffleG4X2(Vector<ushort> source0, Vector<ushort> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{int}, Vector{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<int> Result0, Vector<int> Result1) YShuffleG4X2(Vector<int> source0, Vector<int> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{uint}, Vector{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<uint> Result0, Vector<uint> Result1) YShuffleG4X2(Vector<uint> source0, Vector<uint> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{long}, Vector{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<long> Result0, Vector<long> Result1) YShuffleG4X2(Vector<long> source0, Vector<long> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ulong}, Vector{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<ulong> Result0, Vector<ulong> Result1) YShuffleG4X2(Vector<ulong> source0, Vector<ulong> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{float}, Vector{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<float> Result0, Vector<float> Result1) YShuffleG4X2_Const(Vector<float> source0, Vector<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{double}, Vector{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<double> Result0, Vector<double> Result1) YShuffleG4X2_Const(Vector<double> source0, Vector<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<sbyte> Result0, Vector<sbyte> Result1) YShuffleG4X2_Const(Vector<sbyte> source0, Vector<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{byte}, Vector{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<byte> Result0, Vector<byte> Result1) YShuffleG4X2_Const(Vector<byte> source0, Vector<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{short}, Vector{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<short> Result0, Vector<short> Result1) YShuffleG4X2_Const(Vector<short> source0, Vector<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{ushort}, Vector{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<ushort> Result0, Vector<ushort> Result1) YShuffleG4X2_Const(Vector<ushort> source0, Vector<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{int}, Vector{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<int> Result0, Vector<int> Result1) YShuffleG4X2_Const(Vector<int> source0, Vector<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{uint}, Vector{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<uint> Result0, Vector<uint> Result1) YShuffleG4X2_Const(Vector<uint> source0, Vector<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{long}, Vector{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<long> Result0, Vector<long> Result1) YShuffleG4X2_Const(Vector<long> source0, Vector<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{ulong}, Vector{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override (Vector<ulong> Result0, Vector<ulong> Result1) YShuffleG4X2_Const(Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
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


        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}))"/>
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


#endif // NET5_0_OR_GREATER
    }
}
