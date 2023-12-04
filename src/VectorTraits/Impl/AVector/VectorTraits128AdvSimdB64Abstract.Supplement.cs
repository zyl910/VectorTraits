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


        /// <inheritdoc cref="IVectorTraits.Sqrt_AcceleratedTypes"/>
        public override TypeCodeFlags Sqrt_AcceleratedTypes {
            get {
                return Statics.Sqrt_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Sqrt(Vector<float> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Sqrt(Vector<double> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> Sqrt(Vector<sbyte> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> Sqrt(Vector<byte> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> Sqrt(Vector<short> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> Sqrt(Vector<ushort> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> Sqrt(Vector<int> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> Sqrt(Vector<uint> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> Sqrt(Vector<long> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> Sqrt(Vector<ulong> value) {
            return Statics.Sqrt(value);
        }

#endif // NET5_0_OR_GREATER
    }
}
