using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    using Statics = VectorTraits128AdvSimdB64.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - AdvSimd 64bit abstract.
    /// </summary>
    public abstract class VectorTraits128AdvSimdB64Abstract : VectorTraits128AdvSimdAbstract {

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


#endif // NET5_0_OR_GREATER
    }
}
