using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    using Statics = WVectorTraits128AdvSimd.Statics;

    /// <summary>
    /// <see cref="Vector128{T}"/> traits - AdvSimd abstract.
    /// </summary>
    public abstract class WVectorTraits128AdvSimdAbstract : WVectorTraits128Abstract {
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

#if NET5_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{Int16}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<Int16> ShiftLeft(Vector128<Int16> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{Int32}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<Int32> ShiftLeft(Vector128<Int32> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{Int32}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<Int32> ShiftRightArithmetic(Vector128<Int32> value, int shiftCount) {
            return Statics.ShiftRightArithmetic(value, shiftCount);
        }

#endif // NET5_0_OR_GREATER
    }
}
