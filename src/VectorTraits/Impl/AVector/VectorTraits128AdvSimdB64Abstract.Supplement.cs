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
    using Statics = VectorTraits128AdvSimdB64.Statics;

    partial class VectorTraits128AdvSimdB64Abstract {
#if NET5_0_OR_GREATER

        /// <inheritdoc cref="IVectorTraits.Dot_AcceleratedTypes"/>
        public override TypeCodeFlags Dot_AcceleratedTypes {
            get {
                return Statics.Dot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override double Dot(Vector<double> left, Vector<double> right) {
            return Statics.Dot(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.Multiply_AcceleratedTypes"/>
        public override TypeCodeFlags Multiply_AcceleratedTypes {
            get {
                return Statics.Multiply_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Multiply_FullAcceleratedTypes"/>
        public override TypeCodeFlags Multiply_FullAcceleratedTypes {
            get {
                return Statics.Multiply_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Multiply(Vector<double> left, Vector<double> right) {
            return Statics.Multiply(left, right);
        }

#endif // NET5_0_OR_GREATER
    }
}
