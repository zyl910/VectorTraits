using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Zyl.VectorTraits.Impl.AVector {
    using Statics = VectorTraitsBase.Statics;

    partial class VectorTraitsAbstract {

        /// <inheritdoc cref="IVectorTraits.Add_AcceleratedTypes"/>
        public virtual TypeCodeFlags Add_AcceleratedTypes {
            get {
                return Statics.Add_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<float> Add(Vector<float> left, Vector<float> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<double> Add(Vector<double> left, Vector<double> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<sbyte> Add(Vector<sbyte> left, Vector<sbyte> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<byte> Add(Vector<byte> left, Vector<byte> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<short> Add(Vector<short> left, Vector<short> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<ushort> Add(Vector<ushort> left, Vector<ushort> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<int> Add(Vector<int> left, Vector<int> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<uint> Add(Vector<uint> left, Vector<uint> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<long> Add(Vector<long> left, Vector<long> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<ulong> Add(Vector<ulong> left, Vector<ulong> right) {
            return Statics.Add(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.Dot_AcceleratedTypes"/>
        public virtual TypeCodeFlags Dot_AcceleratedTypes {
            get {
                return Statics.Dot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual float Dot(Vector<float> left, Vector<float> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual double Dot(Vector<double> left, Vector<double> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual sbyte Dot(Vector<sbyte> left, Vector<sbyte> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual byte Dot(Vector<byte> left, Vector<byte> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual short Dot(Vector<short> left, Vector<short> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual ushort Dot(Vector<ushort> left, Vector<ushort> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual int Dot(Vector<int> left, Vector<int> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint Dot(Vector<uint> left, Vector<uint> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual long Dot(Vector<long> left, Vector<long> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual ulong Dot(Vector<ulong> left, Vector<ulong> right) {
            return Statics.Dot(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.Multiply_AcceleratedTypes"/>
        public virtual TypeCodeFlags Multiply_AcceleratedTypes {
            get {
                return Statics.Multiply_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Multiply_FullAcceleratedTypes"/>
        public virtual TypeCodeFlags Multiply_FullAcceleratedTypes {
            get {
                return Statics.Multiply_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<float> Multiply(Vector<float> left, Vector<float> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<double> Multiply(Vector<double> left, Vector<double> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<sbyte> Multiply(Vector<sbyte> left, Vector<sbyte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<byte> Multiply(Vector<byte> left, Vector<byte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<short> Multiply(Vector<short> left, Vector<short> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<ushort> Multiply(Vector<ushort> left, Vector<ushort> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<int> Multiply(Vector<int> left, Vector<int> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<uint> Multiply(Vector<uint> left, Vector<uint> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<long> Multiply(Vector<long> left, Vector<long> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<ulong> Multiply(Vector<ulong> left, Vector<ulong> right) {
            return Statics.Multiply(left, right);
        }


        /// <inheritdoc cref="IVectorTraits.Sqrt_AcceleratedTypes"/>
        public virtual TypeCodeFlags Sqrt_AcceleratedTypes {
            get {
                return Statics.Sqrt_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<float> Sqrt(Vector<float> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<double> Sqrt(Vector<double> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<sbyte> Sqrt(Vector<sbyte> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<byte> Sqrt(Vector<byte> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<short> Sqrt(Vector<short> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<ushort> Sqrt(Vector<ushort> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<int> Sqrt(Vector<int> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<uint> Sqrt(Vector<uint> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<long> Sqrt(Vector<long> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<ulong> Sqrt(Vector<ulong> value) {
            return Statics.Sqrt(value);
        }


    }
}
