using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    using Statics = WVectorTraits256Base.Statics;

    /// <summary>
    /// <see cref="Vector256{T}"/> traits - abstract.
    /// </summary>
    public abstract class WVectorTraits256Abstract : IWVectorTraits256, IBaseTraits {

        /// <summary>
        /// Get best instance.
        /// </summary>
        /// <returns>Returns best instance.</returns>
        [CLSCompliant(false)]
        public static IWVectorTraits256 GetBestInstance() {
            if (WVectorTraits256Avx2.Instance.IsSupported) return WVectorTraits256Avx2.Instance;
            return WVectorTraits256Base.Instance;
        }

        /// <summary>ByteCount value</summary>
        public const int ByteCountValue = 32;

        /// <inheritdoc cref="IBaseTraits.ByteCount"/>
        public int ByteCount {
            get {
                return Statics.ByteCount;
            }
        }

        /// <inheritdoc cref="IBaseTraits.IsSupported"/>
        public virtual bool IsSupported {
            get {
                return Statics.IsSupported;
            }
        }

        /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
        public virtual bool GetIsSupported(bool noStrict = false) {
            return Statics.GetIsSupported(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
        public virtual string GetUnsupportedMessage(bool noStrict = false) {
            return Statics.GetUnsupportedMessage(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
        public virtual void ThrowForUnsupported(bool noStrict = false) {
            Statics.ThrowForUnsupported(noStrict);
        }

#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        public virtual TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
                return Statics.ShiftLeft_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> ShiftLeft(Vector256<short> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> ShiftLeft(Vector256<int> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> ShiftLeft(Vector256<long> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast_AcceleratedTypes"/>
        public virtual TypeCodeFlags ShiftLeftFast_AcceleratedTypes {
            get {
                return Statics.ShiftLeftFast_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> ShiftLeftFast(Vector256<sbyte> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> ShiftLeftFast(Vector256<byte> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> ShiftLeftFast(Vector256<short> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> ShiftLeftFast(Vector256<ushort> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> ShiftLeftFast(Vector256<int> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> ShiftLeftFast(Vector256<uint> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> ShiftLeftFast(Vector256<long> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> ShiftLeftFast(Vector256<ulong> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftCount) {
            return Statics.ShiftRightArithmetic(value, shiftCount);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
