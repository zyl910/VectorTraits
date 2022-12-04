using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    using Statics = VectorTraits128Base.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - abstract.
    /// </summary>
    public abstract class VectorTraits128Abstract : VectorTraitsAbstract {

        /// <summary>
        /// Get best instance.
        /// </summary>
        /// <returns>Returns best instance.</returns>
        public new static IVectorTraits GetBestInstance() {
            if (VectorTraits128AdvSimdA64.Instance.IsSupported) return VectorTraits128AdvSimdA64.Instance;
            if (VectorTraits128AdvSimd.Instance.IsSupported) return VectorTraits128AdvSimd.Instance;
            return VectorTraits128Base.Instance;
        }

        /// <summary>ByteCount value</summary>
        public const int ByteCountValue = 16;

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

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeft(Vector<byte> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeft(Vector<short> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeft(Vector<int> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeftFast(Vector<byte> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeftFast(Vector<short> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeftFast(Vector<int> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftCount) {
            return Statics.ShiftRightArithmetic(value, shiftCount);
        }

    }
}
