using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl.AVector128 {
    using Statics = WVectorTraits128PackedSimd.Statics;

    partial class WVectorTraits128PackedSimdAbstract {
#if NET8_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.Abs_AcceleratedTypes"/>
        public override TypeCodeFlags Abs_AcceleratedTypes {
            get {
                return Statics.Abs_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Abs(Vector128<float> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Abs(Vector128<double> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> Abs(Vector128<sbyte> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> Abs(Vector128<short> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> Abs(Vector128<int> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Abs(Vector128<long> value) {
            return Statics.Abs(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.Add_AcceleratedTypes"/>
        public override TypeCodeFlags Add_AcceleratedTypes {
            get {
                return Statics.Add_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Add(Vector128<float> left, Vector128<float> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Add(Vector128<double> left, Vector128<double> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> Add(Vector128<short> left, Vector128<short> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> Add(Vector128<int> left, Vector128<int> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Add(Vector128<long> left, Vector128<long> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Add(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.AndNot_AcceleratedTypes"/>
        public override TypeCodeFlags AndNot_AcceleratedTypes {
            get {
                return Statics.AndNot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.AndNot{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<T> AndNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.AndNot(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd_AcceleratedTypes"/>
        public override TypeCodeFlags BitwiseAnd_AcceleratedTypes {
            get {
                return Statics.BitwiseAnd_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<T> BitwiseAnd<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.BitwiseAnd(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.BitwiseOr_AcceleratedTypes"/>
        public override TypeCodeFlags BitwiseOr_AcceleratedTypes {
            get {
                return Statics.BitwiseOr_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<T> BitwiseOr<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.BitwiseOr(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect_AcceleratedTypes"/>
        public override TypeCodeFlags ConditionalSelect_AcceleratedTypes {
            get {
                return Statics.ConditionalSelect_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<T> ConditionalSelect<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.ConditionalSelect(condition, left, right);
        }

/*
        /// <inheritdoc cref="IWVectorTraits128.Dot_AcceleratedTypes"/>
        public override TypeCodeFlags Dot_AcceleratedTypes {
            get {
                return Statics.Dot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override float Dot(Vector128<float> left, Vector128<float> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override double Dot(Vector128<double> left, Vector128<double> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override sbyte Dot(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override byte Dot(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override short Dot(Vector128<short> left, Vector128<short> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ushort Dot(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int Dot(Vector128<int> left, Vector128<int> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint Dot(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override long Dot(Vector128<long> left, Vector128<long> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong Dot(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Dot(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Equals_AcceleratedTypes"/>
        public override TypeCodeFlags Equals_AcceleratedTypes {
            get {
                return Statics.Equals_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Equals(Vector128<float> left, Vector128<float> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Equals(Vector128<double> left, Vector128<double> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> Equals(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> Equals(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> Equals(Vector128<short> left, Vector128<short> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> Equals(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> Equals(Vector128<int> left, Vector128<int> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> Equals(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Equals(Vector128<long> left, Vector128<long> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> Equals(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Equals(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.EqualsAll_AcceleratedTypes"/>
        public override TypeCodeFlags EqualsAll_AcceleratedTypes {
            get {
                return Statics.EqualsAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector128<float> left, Vector128<float> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector128<double> left, Vector128<double> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector128<byte> left, Vector128<byte> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector128<short> left, Vector128<short> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector128<int> left, Vector128<int> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector128<uint> left, Vector128<uint> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector128<long> left, Vector128<long> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.EqualsAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.EqualsAny_AcceleratedTypes"/>
        public override TypeCodeFlags EqualsAny_AcceleratedTypes {
            get {
                return Statics.EqualsAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector128<float> left, Vector128<float> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector128<double> left, Vector128<double> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector128<byte> left, Vector128<byte> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector128<short> left, Vector128<short> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector128<int> left, Vector128<int> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector128<uint> left, Vector128<uint> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector128<long> left, Vector128<long> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.EqualsAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.GreaterThan_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThan_AcceleratedTypes {
            get {
                return Statics.GreaterThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> GreaterThan(Vector128<float> left, Vector128<float> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> GreaterThan(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> GreaterThan(Vector128<byte> left, Vector128<byte> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> GreaterThan(Vector128<short> left, Vector128<short> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> GreaterThan(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> GreaterThan(Vector128<int> left, Vector128<int> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> GreaterThan(Vector128<uint> left, Vector128<uint> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.GreaterThan(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanAll_AcceleratedTypes {
            get {
                return Statics.GreaterThanAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector128<float> left, Vector128<float> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector128<double> left, Vector128<double> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector128<byte> left, Vector128<byte> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector128<short> left, Vector128<short> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector128<int> left, Vector128<int> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector128<uint> left, Vector128<uint> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector128<long> left, Vector128<long> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.GreaterThanAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanAny_AcceleratedTypes {
            get {
                return Statics.GreaterThanAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector128<float> left, Vector128<float> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector128<double> left, Vector128<double> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector128<byte> left, Vector128<byte> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector128<short> left, Vector128<short> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector128<int> left, Vector128<int> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector128<uint> left, Vector128<uint> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector128<long> left, Vector128<long> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.GreaterThanAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanOrEqual_AcceleratedTypes {
            get {
                return Statics.GreaterThanOrEqual_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> GreaterThanOrEqual(Vector128<float> left, Vector128<float> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> GreaterThanOrEqual(Vector128<double> left, Vector128<double> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> GreaterThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> GreaterThanOrEqual(Vector128<byte> left, Vector128<byte> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> GreaterThanOrEqual(Vector128<short> left, Vector128<short> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> GreaterThanOrEqual(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> GreaterThanOrEqual(Vector128<int> left, Vector128<int> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> GreaterThanOrEqual(Vector128<uint> left, Vector128<uint> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> GreaterThanOrEqual(Vector128<long> left, Vector128<long> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> GreaterThanOrEqual(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanOrEqualAll_AcceleratedTypes {
            get {
                return Statics.GreaterThanOrEqualAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector128<float> left, Vector128<float> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector128<double> left, Vector128<double> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector128<byte> left, Vector128<byte> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector128<short> left, Vector128<short> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector128<int> left, Vector128<int> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector128<uint> left, Vector128<uint> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector128<long> left, Vector128<long> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanOrEqualAny_AcceleratedTypes {
            get {
                return Statics.GreaterThanOrEqualAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector128<float> left, Vector128<float> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector128<double> left, Vector128<double> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector128<byte> left, Vector128<byte> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector128<short> left, Vector128<short> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector128<int> left, Vector128<int> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector128<uint> left, Vector128<uint> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector128<long> left, Vector128<long> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.LessThan_AcceleratedTypes"/>
        public override TypeCodeFlags LessThan_AcceleratedTypes {
            get {
                return Statics.LessThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> LessThan(Vector128<float> left, Vector128<float> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> LessThan(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> LessThan(Vector128<byte> left, Vector128<byte> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> LessThan(Vector128<short> left, Vector128<short> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> LessThan(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> LessThan(Vector128<int> left, Vector128<int> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> LessThan(Vector128<uint> left, Vector128<uint> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> LessThan(Vector128<long> left, Vector128<long> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.LessThan(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.LessThanAll_AcceleratedTypes"/>
        public override TypeCodeFlags LessThanAll_AcceleratedTypes {
            get {
                return Statics.LessThanAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector128<float> left, Vector128<float> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector128<double> left, Vector128<double> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector128<byte> left, Vector128<byte> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector128<short> left, Vector128<short> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector128<int> left, Vector128<int> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector128<uint> left, Vector128<uint> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector128<long> left, Vector128<long> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.LessThanAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.LessThanAny_AcceleratedTypes"/>
        public override TypeCodeFlags LessThanAny_AcceleratedTypes {
            get {
                return Statics.LessThanAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector128<float> left, Vector128<float> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector128<double> left, Vector128<double> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector128<byte> left, Vector128<byte> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector128<short> left, Vector128<short> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector128<int> left, Vector128<int> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector128<uint> left, Vector128<uint> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector128<long> left, Vector128<long> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.LessThanAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual_AcceleratedTypes"/>
        public override TypeCodeFlags LessThanOrEqual_AcceleratedTypes {
            get {
                return Statics.LessThanOrEqual_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> LessThanOrEqual(Vector128<float> left, Vector128<float> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> LessThanOrEqual(Vector128<double> left, Vector128<double> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> LessThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> LessThanOrEqual(Vector128<byte> left, Vector128<byte> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> LessThanOrEqual(Vector128<short> left, Vector128<short> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> LessThanOrEqual(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> LessThanOrEqual(Vector128<int> left, Vector128<int> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> LessThanOrEqual(Vector128<uint> left, Vector128<uint> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> LessThanOrEqual(Vector128<long> left, Vector128<long> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> LessThanOrEqual(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.LessThanOrEqual(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll_AcceleratedTypes"/>
        public override TypeCodeFlags LessThanOrEqualAll_AcceleratedTypes {
            get {
                return Statics.LessThanOrEqualAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector128<float> left, Vector128<float> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector128<double> left, Vector128<double> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector128<byte> left, Vector128<byte> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector128<short> left, Vector128<short> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector128<int> left, Vector128<int> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector128<uint> left, Vector128<uint> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector128<long> left, Vector128<long> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny_AcceleratedTypes"/>
        public override TypeCodeFlags LessThanOrEqualAny_AcceleratedTypes {
            get {
                return Statics.LessThanOrEqualAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector128<float> left, Vector128<float> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector128<double> left, Vector128<double> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector128<byte> left, Vector128<byte> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector128<short> left, Vector128<short> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector128<int> left, Vector128<int> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector128<uint> left, Vector128<uint> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector128<long> left, Vector128<long> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Max_AcceleratedTypes"/>
        public override TypeCodeFlags Max_AcceleratedTypes {
            get {
                return Statics.Max_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Max(Vector128<float> left, Vector128<float> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> Max(Vector128<short> left, Vector128<short> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> Max(Vector128<int> left, Vector128<int> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Max(Vector128<long> left, Vector128<long> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Max(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Min_AcceleratedTypes"/>
        public override TypeCodeFlags Min_AcceleratedTypes {
            get {
                return Statics.Min_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Min(Vector128<float> left, Vector128<float> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> Min(Vector128<short> left, Vector128<short> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> Min(Vector128<int> left, Vector128<int> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Min(Vector128<long> left, Vector128<long> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Min(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Multiply_AcceleratedTypes"/>
        public override TypeCodeFlags Multiply_AcceleratedTypes {
            get {
                return Statics.Multiply_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply_FullAcceleratedTypes"/>
        public override TypeCodeFlags Multiply_FullAcceleratedTypes {
            get {
                return Statics.Multiply_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Multiply(Vector128<float> left, Vector128<float> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Multiply(Vector128<double> left, Vector128<double> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> Multiply(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> Multiply(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> Multiply(Vector128<short> left, Vector128<short> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> Multiply(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> Multiply(Vector128<int> left, Vector128<int> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> Multiply(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Multiply(Vector128<long> left, Vector128<long> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> Multiply(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Multiply(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Negate_AcceleratedTypes"/>
        public override TypeCodeFlags Negate_AcceleratedTypes {
            get {
                return Statics.Negate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Negate(Vector128<float> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Negate(Vector128<double> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> Negate(Vector128<sbyte> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> Negate(Vector128<short> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> Negate(Vector128<int> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Negate(Vector128<long> value) {
            return Statics.Negate(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.OnesComplement_AcceleratedTypes"/>
        public override TypeCodeFlags OnesComplement_AcceleratedTypes {
            get {
                return Statics.OnesComplement_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.OnesComplement{T}(Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<T> OnesComplement<T>(Vector128<T> vector) where T : struct {
            return Statics.OnesComplement(vector);
        }


        /// <inheritdoc cref="IWVectorTraits128.Sqrt_AcceleratedTypes"/>
        public override TypeCodeFlags Sqrt_AcceleratedTypes {
            get {
                return Statics.Sqrt_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Sqrt(Vector128<float> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Sqrt(Vector128<double> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> Sqrt(Vector128<sbyte> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> Sqrt(Vector128<byte> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> Sqrt(Vector128<short> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> Sqrt(Vector128<ushort> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> Sqrt(Vector128<int> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> Sqrt(Vector128<uint> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Sqrt(Vector128<long> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> Sqrt(Vector128<ulong> value) {
            return Statics.Sqrt(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.Subtract_AcceleratedTypes"/>
        public override TypeCodeFlags Subtract_AcceleratedTypes {
            get {
                return Statics.Subtract_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Subtract(Vector128<float> left, Vector128<float> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Subtract(Vector128<double> left, Vector128<double> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> Subtract(Vector128<short> left, Vector128<short> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> Subtract(Vector128<int> left, Vector128<int> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Subtract(Vector128<long> left, Vector128<long> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Subtract(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Xor_AcceleratedTypes"/>
        public override TypeCodeFlags Xor_AcceleratedTypes {
            get {
                return Statics.Xor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Xor{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.Xor(left, right);
        }
*/
#endif
    }
}
