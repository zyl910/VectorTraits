using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector128;

namespace Zyl.VectorTraits {
    using BaseStatics = WVectorTraits128Base.Statics;

    partial class Vector128s {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.YClamp_AcceleratedTypes"/>
        public static TypeCodeFlags YClamp_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YClamp_AcceleratedTypes;
#else
                return _instance.YClamp_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YClamp(Vector128<float> value, Vector128<float> amin, Vector128<float> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{double}, Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YClamp(Vector128<sbyte> value, Vector128<sbyte> amin, Vector128<sbyte> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YClamp(Vector128<byte> value, Vector128<byte> amin, Vector128<byte> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YClamp(Vector128<short> value, Vector128<short> amin, Vector128<short> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YClamp(Vector128<ushort> value, Vector128<ushort> amin, Vector128<ushort> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YClamp(Vector128<int> value, Vector128<int> amin, Vector128<int> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YClamp(Vector128<uint> value, Vector128<uint> amin, Vector128<uint> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YClamp(Vector128<long> value, Vector128<long> amin, Vector128<long> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YClamp(Vector128<ulong> value, Vector128<ulong> amin, Vector128<ulong> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_AcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturate_AcceleratedTypes;
#else
                return _instance.YNarrowSaturate_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_FullAcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturate_FullAcceleratedTypes;
#else
                return _instance.YNarrowSaturate_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{short}, Vector128{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YNarrowSaturate(Vector128<short> lower, Vector128<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ushort}, Vector128{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YNarrowSaturate(Vector128<ushort> lower, Vector128<ushort> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{int}, Vector128{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YNarrowSaturate(Vector128<int> lower, Vector128<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{uint}, Vector128{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YNarrowSaturate(Vector128<uint> lower, Vector128<uint> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{long}, Vector128{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YNarrowSaturate(Vector128<long> lower, Vector128<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ulong}, Vector128{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YNarrowSaturate(Vector128<ulong> lower, Vector128<ulong> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturateUnsigned_AcceleratedTypes;
#else
                return _instance.YNarrowSaturateUnsigned_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
#else
                return _instance.YNarrowSaturateUnsigned_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{short}, Vector128{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YNarrowSaturateUnsigned(Vector128<short> lower, Vector128<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{int}, Vector128{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YNarrowSaturateUnsigned(Vector128<int> lower, Vector128<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{long}, Vector128{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YNarrowSaturateUnsigned(Vector128<long> lower, Vector128<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleInsert_AcceleratedTypes;
#else
                return _instance.YShuffleInsert_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleInsert(Vector128<float> back, Vector128<float> vector, Vector128<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleInsert(Vector128<double> back, Vector128<double> vector, Vector128<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleInsert(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleInsert(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleInsert(Vector128<short> back, Vector128<short> vector, Vector128<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleInsert(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleInsert(Vector128<int> back, Vector128<int> vector, Vector128<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleInsert(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleInsert(Vector128<long> back, Vector128<long> vector, Vector128<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleInsert(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert(back, vector, indices);
#else
            return _instance.YShuffleInsert(back, vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleInsert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#else
            _instance.YShuffleInsert_Args(indices, out args0, out args1, out args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleInsert_Core(Vector128<float> back, Vector128<float> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleInsert_Core(Vector128<double> back, Vector128<double> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleInsert_Core(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleInsert_Core(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleInsert_Core(Vector128<short> back, Vector128<short> vector, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleInsert_Core(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleInsert_Core(Vector128<int> back, Vector128<int> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleInsert_Core(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleInsert_Core(Vector128<long> back, Vector128<long> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleInsert_Core(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
#else
            return _instance.YShuffleInsert_Core(back, vector, args0, args1, args2);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YShuffleKernel_AcceleratedTypes;
#else
                return _instance.YShuffleKernel_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleKernel(Vector128<float> vector, Vector128<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleKernel(Vector128<double> vector, Vector128<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleKernel(Vector128<int> vector, Vector128<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleKernel(Vector128<uint> vector, Vector128<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleKernel(Vector128<long> vector, Vector128<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleKernel(Vector128<ulong> vector, Vector128<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel(vector, indices);
#else
            return _instance.YShuffleKernel(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void YShuffleKernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.YShuffleKernel_Args(indices, out args0, out args1);
#else
            _instance.YShuffleKernel_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> YShuffleKernel_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> YShuffleKernel_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleKernel_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleKernel_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleKernel_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleKernel_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> YShuffleKernel_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> YShuffleKernel_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> YShuffleKernel_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> YShuffleKernel_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YShuffleKernel_Core(vector, args0, args1);
#else
            return _instance.YShuffleKernel_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


#endif
    }
}
