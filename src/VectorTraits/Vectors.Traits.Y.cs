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

        /// <inheritdoc cref="IVectorTraits.YClamp_AcceleratedTypes"/>
        public static TypeCodeFlags YClamp_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YClamp_AcceleratedTypes;
#else
                return _instance.YClamp_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YClamp(Vector<float> value, Vector<float> amin, Vector<float> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{double}, Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YClamp(Vector<double> value, Vector<double> amin, Vector<double> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YClamp(Vector<sbyte> value, Vector<sbyte> amin, Vector<sbyte> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YClamp(Vector<byte> value, Vector<byte> amin, Vector<byte> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YClamp(Vector<short> value, Vector<short> amin, Vector<short> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YClamp(Vector<ushort> value, Vector<ushort> amin, Vector<ushort> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YClamp(Vector<int> value, Vector<int> amin, Vector<int> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YClamp(Vector<uint> value, Vector<uint> amin, Vector<uint> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YClamp(Vector<long> value, Vector<long> amin, Vector<long> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YClamp(Vector<ulong> value, Vector<ulong> amin, Vector<ulong> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_AcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturate_AcceleratedTypes;
#else
                return _instance.YNarrowSaturate_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_FullAcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturate_FullAcceleratedTypes;
#else
                return _instance.YNarrowSaturate_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{short}, Vector{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YNarrowSaturate(Vector<short> lower, Vector<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ushort}, Vector{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YNarrowSaturate(Vector<ushort> lower, Vector<ushort> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{int}, Vector{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YNarrowSaturate(Vector<int> lower, Vector<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{uint}, Vector{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YNarrowSaturate(Vector<uint> lower, Vector<uint> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{long}, Vector{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YNarrowSaturate(Vector<long> lower, Vector<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ulong}, Vector{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YNarrowSaturate(Vector<ulong> lower, Vector<ulong> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturateUnsigned_AcceleratedTypes;
#else
                return _instance.YNarrowSaturateUnsigned_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
#else
                return _instance.YNarrowSaturateUnsigned_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{short}, Vector{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YNarrowSaturateUnsigned(Vector<short> lower, Vector<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{int}, Vector{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YNarrowSaturateUnsigned(Vector<int> lower, Vector<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{long}, Vector{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YNarrowSaturateUnsigned(Vector<long> lower, Vector<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleInsert_AcceleratedTypes;
#else
                return _instance.YShuffleInsert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{float}, Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleInsert(Vector<float> back, Vector<float> vector, Vector<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{double}, Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleInsert(Vector<double> back, Vector<double> vector, Vector<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleInsert(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleInsert(Vector<byte> back, Vector<byte> vector, Vector<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleInsert(Vector<short> back, Vector<short> vector, Vector<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleInsert(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleInsert(Vector<int> back, Vector<int> vector, Vector<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleInsert(Vector<uint> back, Vector<uint> vector, Vector<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleInsert(Vector<long> back, Vector<long> vector, Vector<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleInsert(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleKernel_AcceleratedTypes;
#else
                return _instance.YShuffleKernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YShuffleKernel(Vector<float> vector, Vector<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YShuffleKernel(Vector<double> vector, Vector<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleKernel(Vector<sbyte> vector, Vector<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleKernel(Vector<byte> vector, Vector<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleKernel(Vector<short> vector, Vector<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleKernel(Vector<ushort> vector, Vector<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YShuffleKernel(Vector<int> vector, Vector<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YShuffleKernel(Vector<uint> vector, Vector<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YShuffleKernel(Vector<long> vector, Vector<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YShuffleKernel(Vector<ulong> vector, Vector<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


    }
}
