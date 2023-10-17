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
    using Statics = VectorTraits128Sse.Statics;

    partial class VectorTraits128SseAbstract {
#if NETCOREAPP3_0_OR_GREATER

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

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Multiply(Vector<float> left, Vector<float> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Multiply(Vector<double> left, Vector<double> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> Multiply(Vector<sbyte> left, Vector<sbyte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> Multiply(Vector<byte> left, Vector<byte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> Multiply(Vector<short> left, Vector<short> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> Multiply(Vector<ushort> left, Vector<ushort> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> Multiply(Vector<int> left, Vector<int> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> Multiply(Vector<uint> left, Vector<uint> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> Multiply(Vector<long> left, Vector<long> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> Multiply(Vector<ulong> left, Vector<ulong> right) {
            return Statics.Multiply(left, right);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
