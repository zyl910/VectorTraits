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
