using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;

namespace Zyl.VectorTraits {
    using BaseStatics = VectorTraitsBase.Statics;

    partial class Vectors {

        /// <inheritdoc cref="IVectorTraits.Add_AcceleratedTypes"/>
        public static TypeCodeFlags Add_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Add_AcceleratedTypes;
#else
                return _instance.Add_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> Add(Vector<float> left, Vector<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC)
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> Add(Vector<double> left, Vector<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> Add(Vector<sbyte> left, Vector<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> Add(Vector<byte> left, Vector<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> Add(Vector<short> left, Vector<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC)
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> Add(Vector<ushort> left, Vector<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> Add(Vector<int> left, Vector<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC)
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> Add(Vector<uint> left, Vector<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> Add(Vector<long> left, Vector<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Add(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> Add(Vector<ulong> left, Vector<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.Dot_AcceleratedTypes"/>
        public static TypeCodeFlags Dot_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Dot_AcceleratedTypes;
#else
                return _instance.Dot_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(Vector<float> left, Vector<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC)
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Dot(Vector<double> left, Vector<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Dot(Vector<sbyte> left, Vector<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Dot(Vector<byte> left, Vector<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Dot(Vector<short> left, Vector<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC)
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Dot(Vector<ushort> left, Vector<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Dot(Vector<int> left, Vector<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC)
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Dot(Vector<uint> left, Vector<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Dot(Vector<long> left, Vector<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Dot(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Dot(Vector<ulong> left, Vector<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.Multiply_AcceleratedTypes"/>
        public static TypeCodeFlags Multiply_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Multiply_AcceleratedTypes;
#else
                return _instance.Multiply_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Multiply_FullAcceleratedTypes"/>
        public static TypeCodeFlags Multiply_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Multiply_FullAcceleratedTypes;
#else
                return _instance.Multiply_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> Multiply(Vector<float> left, Vector<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC)
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> Multiply(Vector<double> left, Vector<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> Multiply(Vector<sbyte> left, Vector<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> Multiply(Vector<byte> left, Vector<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> Multiply(Vector<short> left, Vector<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC)
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> Multiply(Vector<ushort> left, Vector<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> Multiply(Vector<int> left, Vector<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC)
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> Multiply(Vector<uint> left, Vector<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> Multiply(Vector<long> left, Vector<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> Multiply(Vector<ulong> left, Vector<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.Sqrt_AcceleratedTypes"/>
        public static TypeCodeFlags Sqrt_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Sqrt_AcceleratedTypes;
#else
                return _instance.Sqrt_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> Sqrt(Vector<float> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> Sqrt(Vector<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> Sqrt(Vector<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> Sqrt(Vector<byte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> Sqrt(Vector<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> Sqrt(Vector<ushort> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> Sqrt(Vector<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> Sqrt(Vector<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> Sqrt(Vector<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> Sqrt(Vector<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


    }
}
