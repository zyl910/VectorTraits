using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    using Statics = WVectorTraits256Avx2.Statics;

    /// <summary>
    /// <see cref="Vector256{T}"/> traits - Avx2 abstract.
    /// </summary>
    public abstract class WVectorTraits256Avx2Abstract : WVectorTraits256Abstract {
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

#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{Int16}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<Int16> ShiftLeft(Vector256<Int16> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{Int32}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<Int32> ShiftLeft(Vector256<Int32> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{Int32}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<Int32> ShiftRightArithmetic(Vector256<Int32> value, int shiftCount) {
            return Statics.ShiftRightArithmetic(value, shiftCount);
        }

#endif
    }
}
