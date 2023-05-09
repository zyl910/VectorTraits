using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Impl.AVector {
    using Statics = VectorTraits256Base.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 256 - abstract.
    /// </summary>
    public abstract class VectorTraits256Abstract : VectorTraitsAbstract {

        /// <summary>
        /// Get best instance.
        /// </summary>
        /// <returns>Returns best instance.</returns>
        [CLSCompliant(false)]
        public new static IVectorTraits GetBestInstance() {
            if (VectorTraits256Avx2.Instance.IsSupported) return VectorTraits256Avx2.Instance;
            return VectorTraits256Base.Instance;
        }

        /// <summary>ByteCount value</summary>
        public const int ByteCountValue = 32;

        /// <summary>
        /// <see cref="GetUnsupportedMessage"/> - Fill by <see cref="Vector{T}.Count"/> .
        /// </summary>
        /// <param name="rt">The in/out string.</param>
        public static void GetUnsupportedMessage_VectorCount(ref string rt) {
            if (Vector<byte>.Count != ByteCountValue) {
                rt += string.Format(" Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, ByteCountValue);
            }
        }

        /// <inheritdoc cref="IBaseTraits.ByteCount"/>
        public override int ByteCount {
            get {
                return Statics.ByteCount;
            }
        }

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

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftLeft_Fast(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeft_Fast(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeft_Fast(Vector<short> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftLeft_Fast(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeft_Fast(Vector<int> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftLeft_Fast(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftLeft_Fast(Vector<long> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftLeft_Fast(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
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

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmetic_Fast(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightArithmetic_Fast(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightArithmetic_Fast(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightArithmetic_Fast(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
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

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightLogical_Fast(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftRightLogical_Fast(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightLogical_Fast(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftRightLogical_Fast(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightLogical_Fast(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftRightLogical_Fast(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightLogical_Fast(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftRightLogical_Fast(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
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

    }
}
