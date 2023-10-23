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
    using Statics = VectorTraits128Avx2.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - Avx2 abstract.
    /// </summary>
    public abstract partial class VectorTraits128Avx2Abstract : VectorTraits128SseAbstract {
        
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

        /// <inheritdoc cref="IBaseTraits.UsedInstructionSets"/>
        public override string UsedInstructionSets {
            get {
                return Statics.UsedInstructionSets;
            }
        }

#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IVectorTraits.ConvertToDouble_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToDouble_AcceleratedTypes {
            get {
                return Statics.ConvertToDouble_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> ConvertToDouble(Vector<long> value) {
            return Statics.ConvertToDouble(value);
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> ConvertToDouble(Vector<ulong> value) {
            return Statics.ConvertToDouble(value);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
