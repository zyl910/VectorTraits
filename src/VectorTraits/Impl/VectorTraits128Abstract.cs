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
            if (VectorTraits128AdvSimd.Instance.IsSupported) return VectorTraits128AdvSimd.Instance;
            return VectorTraits128Base.Instance;
        }

        /// <summary>ByteCount value</summary>
        public const int ByteCountValue = 16;

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

        /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
        public override void ThrowForUnsupported() {
            Statics.ThrowForUnsupported();
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{Int16}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<Int16> ShiftLeft(Vector<Int16> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{Int32}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<Int32> ShiftLeft(Vector<Int32> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{Int32}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<Int32> ShiftRightArithmetic(Vector<Int32> value, int shiftCount) {
            return Statics.ShiftRightArithmetic(value, shiftCount);
        }

    }
}
