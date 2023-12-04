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
    using Statics = VectorTraits256Avx2.Statics;

    partial class VectorTraits256Avx2Abstract {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IVectorTraits.Dot_AcceleratedTypes"/>
        public override TypeCodeFlags Dot_AcceleratedTypes {
            get {
                return Statics.Dot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override float Dot(Vector<float> left, Vector<float> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override double Dot(Vector<double> left, Vector<double> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override sbyte Dot(Vector<sbyte> left, Vector<sbyte> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override byte Dot(Vector<byte> left, Vector<byte> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override short Dot(Vector<short> left, Vector<short> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ushort Dot(Vector<ushort> left, Vector<ushort> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int Dot(Vector<int> left, Vector<int> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint Dot(Vector<uint> left, Vector<uint> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override long Dot(Vector<long> left, Vector<long> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong Dot(Vector<ulong> left, Vector<ulong> right) {
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

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
