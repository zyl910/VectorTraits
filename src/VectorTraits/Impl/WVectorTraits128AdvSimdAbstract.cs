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

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> ShiftLeft(Vector128<byte> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> ShiftLeft(Vector128<short> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> ShiftLeft(Vector128<int> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> ShiftLeftFast(Vector128<byte> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> ShiftLeftFast(Vector128<short> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> ShiftLeftFast(Vector128<int> value, int shiftCount) {
            return Statics.ShiftLeftFast(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftCount) {
            return Statics.ShiftRightArithmetic(value, shiftCount);
        }

#endif // NET5_0_OR_GREATER
    }
}
