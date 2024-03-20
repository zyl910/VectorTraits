using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector512;

namespace Zyl.VectorTraits {
    using BaseStatics = WVectorTraits512Base.Statics;

    partial class Vector512s {
#if NET8_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits512.Abs_AcceleratedTypes"/>
        public static TypeCodeFlags Abs_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Abs_AcceleratedTypes;
#else
                return _instance.Abs_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Abs(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Abs(value);
#else
            return _instance.Abs(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Abs(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Abs(value);
#else
            return _instance.Abs(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Abs(Vector512<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Abs(value);
#else
            return _instance.Abs(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Abs(Vector512<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Abs(value);
#else
            return _instance.Abs(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Abs(Vector512<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Abs(value);
#else
            return _instance.Abs(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Abs(Vector512<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Abs(value);
#else
            return _instance.Abs(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Add_AcceleratedTypes"/>
        public static TypeCodeFlags Add_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Add_AcceleratedTypes;
#else
                return _instance.Add_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Add(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Add(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Add(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> Add(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Add(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> Add(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Add(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> Add(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Add(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> Add(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.AndNot_AcceleratedTypes"/>
        public static TypeCodeFlags AndNot_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.AndNot_AcceleratedTypes;
#else
                return _instance.AndNot_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.AndNot{T}(Vector512{T}, Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> AndNot<T>(Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.AndNot(left, right);
#else
            return _instance.AndNot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.BitwiseAnd_AcceleratedTypes"/>
        public static TypeCodeFlags BitwiseAnd_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.BitwiseAnd_AcceleratedTypes;
#else
                return _instance.BitwiseAnd_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.BitwiseAnd{T}(Vector512{T}, Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> BitwiseAnd<T>(Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.BitwiseAnd(left, right);
#else
            return _instance.BitwiseAnd(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.BitwiseOr_AcceleratedTypes"/>
        public static TypeCodeFlags BitwiseOr_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.BitwiseOr_AcceleratedTypes;
#else
                return _instance.BitwiseOr_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.BitwiseOr{T}(Vector512{T}, Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> BitwiseOr<T>(Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.BitwiseOr(left, right);
#else
            return _instance.BitwiseOr(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect_AcceleratedTypes"/>
        public static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConditionalSelect_AcceleratedTypes;
#else
                return _instance.ConditionalSelect_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect{T}(Vector512{T}, Vector512{T}, Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> ConditionalSelect<T>(Vector512<T> condition, Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ConditionalSelect(condition, left, right);
#else
            return _instance.ConditionalSelect(condition, left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect(Vector512{int}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> ConditionalSelect(Vector512<int> condition, Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return ConditionalSelect<float>(condition.AsSingle(), left, right);
#else
            return _instance.ConditionalSelect(condition, left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect(Vector512{long}, Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> ConditionalSelect(Vector512<long> condition, Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return ConditionalSelect<double>(condition.AsDouble(), left, right);
#else
            return _instance.ConditionalSelect(condition, left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Divide_AcceleratedTypes"/>
        public static TypeCodeFlags Divide_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Divide_AcceleratedTypes;
#else
                return _instance.Divide_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Divide(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Divide(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Divide(left, right);
#else
            return _instance.Divide(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Divide(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Divide(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Divide(left, right);
#else
            return _instance.Divide(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Dot_AcceleratedTypes"/>
        public static TypeCodeFlags Dot_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Dot_AcceleratedTypes;
#else
                return _instance.Dot_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Dot(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Dot(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Dot(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Dot(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Dot(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Dot(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Dot(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Dot(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Dot(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Dot(left, right);
#else
            return _instance.Dot(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Equals_AcceleratedTypes"/>
        public static TypeCodeFlags Equals_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Equals_AcceleratedTypes;
#else
                return _instance.Equals_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Equals(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Equals(left, right);
#else
            return _instance.Equals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Equals(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Equals(left, right);
#else
            return _instance.Equals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Equals(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Equals(left, right);
#else
            return _instance.Equals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> Equals(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Equals(left, right);
#else
            return _instance.Equals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Equals(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Equals(left, right);
#else
            return _instance.Equals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> Equals(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Equals(left, right);
#else
            return _instance.Equals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Equals(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Equals(left, right);
#else
            return _instance.Equals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> Equals(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Equals(left, right);
#else
            return _instance.Equals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Equals(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Equals(left, right);
#else
            return _instance.Equals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> Equals(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Equals(left, right);
#else
            return _instance.Equals(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.EqualsAll_AcceleratedTypes"/>
        public static TypeCodeFlags EqualsAll_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.EqualsAll_AcceleratedTypes;
#else
                return _instance.EqualsAll_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAll(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAll(left, right);
#else
            return _instance.EqualsAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAll(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAll(left, right);
#else
            return _instance.EqualsAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAll(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAll(left, right);
#else
            return _instance.EqualsAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAll(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAll(left, right);
#else
            return _instance.EqualsAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAll(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAll(left, right);
#else
            return _instance.EqualsAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAll(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAll(left, right);
#else
            return _instance.EqualsAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAll(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAll(left, right);
#else
            return _instance.EqualsAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAll(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAll(left, right);
#else
            return _instance.EqualsAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAll(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAll(left, right);
#else
            return _instance.EqualsAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAll(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAll(left, right);
#else
            return _instance.EqualsAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.EqualsAny_AcceleratedTypes"/>
        public static TypeCodeFlags EqualsAny_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.EqualsAny_AcceleratedTypes;
#else
                return _instance.EqualsAny_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAny(left, right);
#else
            return _instance.EqualsAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAny(left, right);
#else
            return _instance.EqualsAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAny(left, right);
#else
            return _instance.EqualsAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAny(left, right);
#else
            return _instance.EqualsAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAny(left, right);
#else
            return _instance.EqualsAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAny(left, right);
#else
            return _instance.EqualsAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAny(left, right);
#else
            return _instance.EqualsAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAny(left, right);
#else
            return _instance.EqualsAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAny(left, right);
#else
            return _instance.EqualsAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool EqualsAny(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.EqualsAny(left, right);
#else
            return _instance.EqualsAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.GreaterThan_AcceleratedTypes"/>
        public static TypeCodeFlags GreaterThan_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.GreaterThan_AcceleratedTypes;
#else
                return _instance.GreaterThan_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> GreaterThan(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> GreaterThan(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> GreaterThan(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GreaterThan(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> GreaterThan(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> GreaterThan(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> GreaterThan(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> GreaterThan(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> GreaterThan(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> GreaterThan(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll_AcceleratedTypes"/>
        public static TypeCodeFlags GreaterThanAll_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.GreaterThanAll_AcceleratedTypes;
#else
                return _instance.GreaterThanAll_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAll(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAll(left, right);
#else
            return _instance.GreaterThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAll(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAll(left, right);
#else
            return _instance.GreaterThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAll(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAll(left, right);
#else
            return _instance.GreaterThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAll(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAll(left, right);
#else
            return _instance.GreaterThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAll(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAll(left, right);
#else
            return _instance.GreaterThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAll(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAll(left, right);
#else
            return _instance.GreaterThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAll(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAll(left, right);
#else
            return _instance.GreaterThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAll(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAll(left, right);
#else
            return _instance.GreaterThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAll(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAll(left, right);
#else
            return _instance.GreaterThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAll(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAll(left, right);
#else
            return _instance.GreaterThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny_AcceleratedTypes"/>
        public static TypeCodeFlags GreaterThanAny_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.GreaterThanAny_AcceleratedTypes;
#else
                return _instance.GreaterThanAny_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAny(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAny(left, right);
#else
            return _instance.GreaterThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAny(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAny(left, right);
#else
            return _instance.GreaterThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAny(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAny(left, right);
#else
            return _instance.GreaterThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAny(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAny(left, right);
#else
            return _instance.GreaterThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAny(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAny(left, right);
#else
            return _instance.GreaterThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAny(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAny(left, right);
#else
            return _instance.GreaterThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAny(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAny(left, right);
#else
            return _instance.GreaterThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAny(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAny(left, right);
#else
            return _instance.GreaterThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAny(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAny(left, right);
#else
            return _instance.GreaterThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanAny(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanAny(left, right);
#else
            return _instance.GreaterThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual_AcceleratedTypes"/>
        public static TypeCodeFlags GreaterThanOrEqual_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.GreaterThanOrEqual_AcceleratedTypes;
#else
                return _instance.GreaterThanOrEqual_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> GreaterThanOrEqual(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqual(left, right);
#else
            return _instance.GreaterThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> GreaterThanOrEqual(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.GreaterThanOrEqual(left, right);
#else
            return _instance.GreaterThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> GreaterThanOrEqual(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqual(left, right);
#else
            return _instance.GreaterThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> GreaterThanOrEqual(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqual(left, right);
#else
            return _instance.GreaterThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> GreaterThanOrEqual(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqual(left, right);
#else
            return _instance.GreaterThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> GreaterThanOrEqual(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqual(left, right);
#else
            return _instance.GreaterThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> GreaterThanOrEqual(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqual(left, right);
#else
            return _instance.GreaterThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> GreaterThanOrEqual(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqual(left, right);
#else
            return _instance.GreaterThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> GreaterThanOrEqual(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.GreaterThanOrEqual(left, right);
#else
            return _instance.GreaterThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> GreaterThanOrEqual(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.GreaterThanOrEqual(left, right);
#else
            return _instance.GreaterThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll_AcceleratedTypes"/>
        public static TypeCodeFlags GreaterThanOrEqualAll_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.GreaterThanOrEqualAll_AcceleratedTypes;
#else
                return _instance.GreaterThanOrEqualAll_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAll(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAll(left, right);
#else
            return _instance.GreaterThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAll(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAll(left, right);
#else
            return _instance.GreaterThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAll(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAll(left, right);
#else
            return _instance.GreaterThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAll(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAll(left, right);
#else
            return _instance.GreaterThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAll(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAll(left, right);
#else
            return _instance.GreaterThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAll(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAll(left, right);
#else
            return _instance.GreaterThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAll(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAll(left, right);
#else
            return _instance.GreaterThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAll(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAll(left, right);
#else
            return _instance.GreaterThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAll(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAll(left, right);
#else
            return _instance.GreaterThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAll(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAll(left, right);
#else
            return _instance.GreaterThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny_AcceleratedTypes"/>
        public static TypeCodeFlags GreaterThanOrEqualAny_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.GreaterThanOrEqualAny_AcceleratedTypes;
#else
                return _instance.GreaterThanOrEqualAny_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAny(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAny(left, right);
#else
            return _instance.GreaterThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAny(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAny(left, right);
#else
            return _instance.GreaterThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAny(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAny(left, right);
#else
            return _instance.GreaterThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAny(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAny(left, right);
#else
            return _instance.GreaterThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAny(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAny(left, right);
#else
            return _instance.GreaterThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAny(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAny(left, right);
#else
            return _instance.GreaterThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAny(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAny(left, right);
#else
            return _instance.GreaterThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAny(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAny(left, right);
#else
            return _instance.GreaterThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAny(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAny(left, right);
#else
            return _instance.GreaterThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool GreaterThanOrEqualAny(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.GreaterThanOrEqualAny(left, right);
#else
            return _instance.GreaterThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.LessThan_AcceleratedTypes"/>
        public static TypeCodeFlags LessThan_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.LessThan_AcceleratedTypes;
#else
                return _instance.LessThan_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> LessThan(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> LessThan(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> LessThan(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> LessThan(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> LessThan(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> LessThan(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> LessThan(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return Vector512.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> LessThan(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> LessThan(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> LessThan(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.LessThanAll_AcceleratedTypes"/>
        public static TypeCodeFlags LessThanAll_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.LessThanAll_AcceleratedTypes;
#else
                return _instance.LessThanAll_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAll(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAll(left, right);
#else
            return _instance.LessThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAll(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAll(left, right);
#else
            return _instance.LessThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAll(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAll(left, right);
#else
            return _instance.LessThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAll(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAll(left, right);
#else
            return _instance.LessThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAll(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAll(left, right);
#else
            return _instance.LessThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAll(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAll(left, right);
#else
            return _instance.LessThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAll(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAll(left, right);
#else
            return _instance.LessThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAll(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAll(left, right);
#else
            return _instance.LessThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAll(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAll(left, right);
#else
            return _instance.LessThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAll(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAll(left, right);
#else
            return _instance.LessThanAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.LessThanAny_AcceleratedTypes"/>
        public static TypeCodeFlags LessThanAny_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.LessThanAny_AcceleratedTypes;
#else
                return _instance.LessThanAny_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAny(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAny(left, right);
#else
            return _instance.LessThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAny(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAny(left, right);
#else
            return _instance.LessThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAny(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAny(left, right);
#else
            return _instance.LessThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAny(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAny(left, right);
#else
            return _instance.LessThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAny(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAny(left, right);
#else
            return _instance.LessThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAny(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAny(left, right);
#else
            return _instance.LessThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAny(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAny(left, right);
#else
            return _instance.LessThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAny(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAny(left, right);
#else
            return _instance.LessThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAny(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAny(left, right);
#else
            return _instance.LessThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanAny(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanAny(left, right);
#else
            return _instance.LessThanAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual_AcceleratedTypes"/>
        public static TypeCodeFlags LessThanOrEqual_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.LessThanOrEqual_AcceleratedTypes;
#else
                return _instance.LessThanOrEqual_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> LessThanOrEqual(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqual(left, right);
#else
            return _instance.LessThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> LessThanOrEqual(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.LessThanOrEqual(left, right);
#else
            return _instance.LessThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> LessThanOrEqual(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqual(left, right);
#else
            return _instance.LessThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> LessThanOrEqual(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqual(left, right);
#else
            return _instance.LessThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> LessThanOrEqual(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqual(left, right);
#else
            return _instance.LessThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> LessThanOrEqual(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqual(left, right);
#else
            return _instance.LessThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> LessThanOrEqual(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqual(left, right);
#else
            return _instance.LessThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> LessThanOrEqual(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqual(left, right);
#else
            return _instance.LessThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> LessThanOrEqual(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.LessThanOrEqual(left, right);
#else
            return _instance.LessThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> LessThanOrEqual(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.LessThanOrEqual(left, right);
#else
            return _instance.LessThanOrEqual(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll_AcceleratedTypes"/>
        public static TypeCodeFlags LessThanOrEqualAll_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.LessThanOrEqualAll_AcceleratedTypes;
#else
                return _instance.LessThanOrEqualAll_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAll(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAll(left, right);
#else
            return _instance.LessThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAll(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAll(left, right);
#else
            return _instance.LessThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAll(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAll(left, right);
#else
            return _instance.LessThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAll(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAll(left, right);
#else
            return _instance.LessThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAll(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAll(left, right);
#else
            return _instance.LessThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAll(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAll(left, right);
#else
            return _instance.LessThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAll(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAll(left, right);
#else
            return _instance.LessThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAll(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAll(left, right);
#else
            return _instance.LessThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAll(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAll(left, right);
#else
            return _instance.LessThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAll(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAll(left, right);
#else
            return _instance.LessThanOrEqualAll(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny_AcceleratedTypes"/>
        public static TypeCodeFlags LessThanOrEqualAny_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.LessThanOrEqualAny_AcceleratedTypes;
#else
                return _instance.LessThanOrEqualAny_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAny(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAny(left, right);
#else
            return _instance.LessThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAny(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAny(left, right);
#else
            return _instance.LessThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAny(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAny(left, right);
#else
            return _instance.LessThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAny(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAny(left, right);
#else
            return _instance.LessThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAny(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAny(left, right);
#else
            return _instance.LessThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAny(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAny(left, right);
#else
            return _instance.LessThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAny(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAny(left, right);
#else
            return _instance.LessThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAny(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAny(left, right);
#else
            return _instance.LessThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAny(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAny(left, right);
#else
            return _instance.LessThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool LessThanOrEqualAny(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.LessThanOrEqualAny(left, right);
#else
            return _instance.LessThanOrEqualAny(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Max_AcceleratedTypes"/>
        public static TypeCodeFlags Max_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Max_AcceleratedTypes;
#else
                return _instance.Max_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Max(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Max(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Max(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> Max(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Max(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> Max(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Max(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> Max(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Max(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> Max(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Min_AcceleratedTypes"/>
        public static TypeCodeFlags Min_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Min_AcceleratedTypes;
#else
                return _instance.Min_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Min(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Min(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Min(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> Min(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Min(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> Min(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Min(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> Min(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Min(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> Min(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Multiply_AcceleratedTypes"/>
        public static TypeCodeFlags Multiply_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Multiply_AcceleratedTypes;
#else
                return _instance.Multiply_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply_FullAcceleratedTypes"/>
        public static TypeCodeFlags Multiply_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Multiply_FullAcceleratedTypes;
#else
                return _instance.Multiply_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Multiply(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Multiply(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Multiply(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> Multiply(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Multiply(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> Multiply(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Multiply(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> Multiply(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Multiply(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> Multiply(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Negate_AcceleratedTypes"/>
        public static TypeCodeFlags Negate_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Negate_AcceleratedTypes;
#else
                return _instance.Negate_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Negate(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Negate(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Negate(Vector512<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Negate(Vector512<short> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Negate(Vector512<int> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Negate(Vector512<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.OnesComplement_AcceleratedTypes"/>
        public static TypeCodeFlags OnesComplement_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.OnesComplement_AcceleratedTypes;
#else
                return _instance.OnesComplement_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.OnesComplement{T}(Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> OnesComplement<T>(Vector512<T> vector) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.OnesComplement(vector);
#else
            return _instance.OnesComplement(vector);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Sqrt_AcceleratedTypes"/>
        public static TypeCodeFlags Sqrt_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Sqrt_AcceleratedTypes;
#else
                return _instance.Sqrt_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Sqrt(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Sqrt(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Sqrt(Vector512<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> Sqrt(Vector512<byte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Sqrt(Vector512<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> Sqrt(Vector512<ushort> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Sqrt(Vector512<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> Sqrt(Vector512<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Sqrt(Vector512<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> Sqrt(Vector512<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sqrt(value);
#else
            return _instance.Sqrt(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Subtract_AcceleratedTypes"/>
        public static TypeCodeFlags Subtract_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Subtract_AcceleratedTypes;
#else
                return _instance.Subtract_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Subtract(Vector512<float> left, Vector512<float> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Subtract(Vector512<double> left, Vector512<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Subtract(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> Subtract(Vector512<byte> left, Vector512<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Subtract(Vector512<short> left, Vector512<short> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> Subtract(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Subtract(Vector512<int> left, Vector512<int> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> Subtract(Vector512<uint> left, Vector512<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Subtract(Vector512<long> left, Vector512<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> Subtract(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Xor_AcceleratedTypes"/>
        public static TypeCodeFlags Xor_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Xor_AcceleratedTypes;
#else
                return _instance.Xor_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Xor{T}(Vector512{T}, Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<T> Xor<T>(Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Xor(left, right);
#else
            return _instance.Xor(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

#endif
    }
}
