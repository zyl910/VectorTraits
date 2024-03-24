using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl.AVector512 {
    using Statics = WVectorTraits512Avx512.Statics;

    partial class WVectorTraits512Avx512Abstract {
#if NET8_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits512.Abs_AcceleratedTypes"/>
        public override TypeCodeFlags Abs_AcceleratedTypes {
            get {
                return Statics.Abs_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Abs(Vector512<float> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Abs(Vector512<double> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> Abs(Vector512<sbyte> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> Abs(Vector512<short> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> Abs(Vector512<int> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> Abs(Vector512<long> value) {
            return Statics.Abs(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.Add_AcceleratedTypes"/>
        public override TypeCodeFlags Add_AcceleratedTypes {
            get {
                return Statics.Add_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Add(Vector512<float> left, Vector512<float> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Add(Vector512<double> left, Vector512<double> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> Add(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> Add(Vector512<byte> left, Vector512<byte> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> Add(Vector512<short> left, Vector512<short> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> Add(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> Add(Vector512<int> left, Vector512<int> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> Add(Vector512<uint> left, Vector512<uint> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> Add(Vector512<long> left, Vector512<long> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> Add(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.Add(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.AndNot_AcceleratedTypes"/>
        public override TypeCodeFlags AndNot_AcceleratedTypes {
            get {
                return Statics.AndNot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.AndNot{T}(Vector512{T}, Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<T> AndNot<T>(Vector512<T> left, Vector512<T> right) where T : struct {
            return Statics.AndNot(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.BitwiseAnd_AcceleratedTypes"/>
        public override TypeCodeFlags BitwiseAnd_AcceleratedTypes {
            get {
                return Statics.BitwiseAnd_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.BitwiseAnd{T}(Vector512{T}, Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<T> BitwiseAnd<T>(Vector512<T> left, Vector512<T> right) where T : struct {
            return Statics.BitwiseAnd(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.BitwiseOr_AcceleratedTypes"/>
        public override TypeCodeFlags BitwiseOr_AcceleratedTypes {
            get {
                return Statics.BitwiseOr_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.BitwiseOr{T}(Vector512{T}, Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<T> BitwiseOr<T>(Vector512<T> left, Vector512<T> right) where T : struct {
            return Statics.BitwiseOr(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect_AcceleratedTypes"/>
        public override TypeCodeFlags ConditionalSelect_AcceleratedTypes {
            get {
                return Statics.ConditionalSelect_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect{T}(Vector512{T}, Vector512{T}, Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<T> ConditionalSelect<T>(Vector512<T> condition, Vector512<T> left, Vector512<T> right) where T : struct {
            return Statics.ConditionalSelect(condition, left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect(Vector512{int}, Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> ConditionalSelect(Vector512<int> condition, Vector512<float> left, Vector512<float> right) {
            return ConditionalSelect<float>(condition.AsSingle(), left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect(Vector512{long}, Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> ConditionalSelect(Vector512<long> condition, Vector512<double> left, Vector512<double> right) {
            return ConditionalSelect<double>(condition.AsDouble(), left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.Divide_AcceleratedTypes"/>
        public override TypeCodeFlags Divide_AcceleratedTypes {
            get {
                return Statics.Divide_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Divide(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Divide(Vector512<float> left, Vector512<float> right) {
            return Statics.Divide(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Divide(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Divide(Vector512<double> left, Vector512<double> right) {
            return Statics.Divide(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.Dot_AcceleratedTypes"/>
        public override TypeCodeFlags Dot_AcceleratedTypes {
            get {
                return Statics.Dot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override float Dot(Vector512<float> left, Vector512<float> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override double Dot(Vector512<double> left, Vector512<double> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override sbyte Dot(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override byte Dot(Vector512<byte> left, Vector512<byte> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override short Dot(Vector512<short> left, Vector512<short> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ushort Dot(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int Dot(Vector512<int> left, Vector512<int> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint Dot(Vector512<uint> left, Vector512<uint> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override long Dot(Vector512<long> left, Vector512<long> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong Dot(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.Dot(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.Equals_AcceleratedTypes"/>
        public override TypeCodeFlags Equals_AcceleratedTypes {
            get {
                return Statics.Equals_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Equals(Vector512<float> left, Vector512<float> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Equals(Vector512<double> left, Vector512<double> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> Equals(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> Equals(Vector512<byte> left, Vector512<byte> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> Equals(Vector512<short> left, Vector512<short> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> Equals(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> Equals(Vector512<int> left, Vector512<int> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> Equals(Vector512<uint> left, Vector512<uint> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> Equals(Vector512<long> left, Vector512<long> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> Equals(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.Equals(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.EqualsAll_AcceleratedTypes"/>
        public override TypeCodeFlags EqualsAll_AcceleratedTypes {
            get {
                return Statics.EqualsAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector512<float> left, Vector512<float> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector512<double> left, Vector512<double> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector512<byte> left, Vector512<byte> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector512<short> left, Vector512<short> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector512<int> left, Vector512<int> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector512<uint> left, Vector512<uint> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector512<long> left, Vector512<long> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.EqualsAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.EqualsAny_AcceleratedTypes"/>
        public override TypeCodeFlags EqualsAny_AcceleratedTypes {
            get {
                return Statics.EqualsAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector512<float> left, Vector512<float> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector512<double> left, Vector512<double> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector512<byte> left, Vector512<byte> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector512<short> left, Vector512<short> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector512<int> left, Vector512<int> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector512<uint> left, Vector512<uint> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector512<long> left, Vector512<long> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.EqualsAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.GreaterThan_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThan_AcceleratedTypes {
            get {
                return Statics.GreaterThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> GreaterThan(Vector512<float> left, Vector512<float> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> GreaterThan(Vector512<double> left, Vector512<double> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> GreaterThan(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> GreaterThan(Vector512<byte> left, Vector512<byte> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> GreaterThan(Vector512<short> left, Vector512<short> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> GreaterThan(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> GreaterThan(Vector512<int> left, Vector512<int> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> GreaterThan(Vector512<uint> left, Vector512<uint> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> GreaterThan(Vector512<long> left, Vector512<long> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> GreaterThan(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.GreaterThan(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanAll_AcceleratedTypes {
            get {
                return Statics.GreaterThanAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector512<float> left, Vector512<float> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector512<double> left, Vector512<double> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector512<byte> left, Vector512<byte> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector512<short> left, Vector512<short> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector512<int> left, Vector512<int> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector512<uint> left, Vector512<uint> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector512<long> left, Vector512<long> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.GreaterThanAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanAny_AcceleratedTypes {
            get {
                return Statics.GreaterThanAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector512<float> left, Vector512<float> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector512<double> left, Vector512<double> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector512<byte> left, Vector512<byte> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector512<short> left, Vector512<short> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector512<int> left, Vector512<int> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector512<uint> left, Vector512<uint> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector512<long> left, Vector512<long> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.GreaterThanAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanOrEqual_AcceleratedTypes {
            get {
                return Statics.GreaterThanOrEqual_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> GreaterThanOrEqual(Vector512<float> left, Vector512<float> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> GreaterThanOrEqual(Vector512<double> left, Vector512<double> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> GreaterThanOrEqual(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> GreaterThanOrEqual(Vector512<byte> left, Vector512<byte> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> GreaterThanOrEqual(Vector512<short> left, Vector512<short> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> GreaterThanOrEqual(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> GreaterThanOrEqual(Vector512<int> left, Vector512<int> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> GreaterThanOrEqual(Vector512<uint> left, Vector512<uint> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> GreaterThanOrEqual(Vector512<long> left, Vector512<long> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> GreaterThanOrEqual(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanOrEqualAll_AcceleratedTypes {
            get {
                return Statics.GreaterThanOrEqualAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector512<float> left, Vector512<float> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector512<double> left, Vector512<double> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector512<byte> left, Vector512<byte> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector512<short> left, Vector512<short> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector512<int> left, Vector512<int> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector512<uint> left, Vector512<uint> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector512<long> left, Vector512<long> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanOrEqualAny_AcceleratedTypes {
            get {
                return Statics.GreaterThanOrEqualAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector512<float> left, Vector512<float> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector512<double> left, Vector512<double> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector512<byte> left, Vector512<byte> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector512<short> left, Vector512<short> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector512<int> left, Vector512<int> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector512<uint> left, Vector512<uint> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector512<long> left, Vector512<long> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.LessThan_AcceleratedTypes"/>
        public override TypeCodeFlags LessThan_AcceleratedTypes {
            get {
                return Statics.LessThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> LessThan(Vector512<float> left, Vector512<float> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> LessThan(Vector512<double> left, Vector512<double> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> LessThan(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> LessThan(Vector512<byte> left, Vector512<byte> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> LessThan(Vector512<short> left, Vector512<short> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> LessThan(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> LessThan(Vector512<int> left, Vector512<int> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> LessThan(Vector512<uint> left, Vector512<uint> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> LessThan(Vector512<long> left, Vector512<long> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> LessThan(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.LessThan(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.LessThanAll_AcceleratedTypes"/>
        public override TypeCodeFlags LessThanAll_AcceleratedTypes {
            get {
                return Statics.LessThanAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector512<float> left, Vector512<float> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector512<double> left, Vector512<double> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector512<byte> left, Vector512<byte> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector512<short> left, Vector512<short> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector512<int> left, Vector512<int> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector512<uint> left, Vector512<uint> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector512<long> left, Vector512<long> right) {
            return Statics.LessThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAll(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.LessThanAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.LessThanAny_AcceleratedTypes"/>
        public override TypeCodeFlags LessThanAny_AcceleratedTypes {
            get {
                return Statics.LessThanAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector512<float> left, Vector512<float> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector512<double> left, Vector512<double> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector512<byte> left, Vector512<byte> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector512<short> left, Vector512<short> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector512<int> left, Vector512<int> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector512<uint> left, Vector512<uint> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector512<long> left, Vector512<long> right) {
            return Statics.LessThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanAny(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.LessThanAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual_AcceleratedTypes"/>
        public override TypeCodeFlags LessThanOrEqual_AcceleratedTypes {
            get {
                return Statics.LessThanOrEqual_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> LessThanOrEqual(Vector512<float> left, Vector512<float> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> LessThanOrEqual(Vector512<double> left, Vector512<double> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> LessThanOrEqual(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> LessThanOrEqual(Vector512<byte> left, Vector512<byte> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> LessThanOrEqual(Vector512<short> left, Vector512<short> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> LessThanOrEqual(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> LessThanOrEqual(Vector512<int> left, Vector512<int> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> LessThanOrEqual(Vector512<uint> left, Vector512<uint> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> LessThanOrEqual(Vector512<long> left, Vector512<long> right) {
            return Statics.LessThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> LessThanOrEqual(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.LessThanOrEqual(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll_AcceleratedTypes"/>
        public override TypeCodeFlags LessThanOrEqualAll_AcceleratedTypes {
            get {
                return Statics.LessThanOrEqualAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector512<float> left, Vector512<float> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector512<double> left, Vector512<double> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector512<byte> left, Vector512<byte> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector512<short> left, Vector512<short> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector512<int> left, Vector512<int> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector512<uint> left, Vector512<uint> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector512<long> left, Vector512<long> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAll(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.LessThanOrEqualAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny_AcceleratedTypes"/>
        public override TypeCodeFlags LessThanOrEqualAny_AcceleratedTypes {
            get {
                return Statics.LessThanOrEqualAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector512<float> left, Vector512<float> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector512<double> left, Vector512<double> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector512<byte> left, Vector512<byte> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector512<short> left, Vector512<short> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector512<int> left, Vector512<int> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector512<uint> left, Vector512<uint> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector512<long> left, Vector512<long> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool LessThanOrEqualAny(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.LessThanOrEqualAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.Max_AcceleratedTypes"/>
        public override TypeCodeFlags Max_AcceleratedTypes {
            get {
                return Statics.Max_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Max(Vector512<float> left, Vector512<float> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Max(Vector512<double> left, Vector512<double> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> Max(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> Max(Vector512<byte> left, Vector512<byte> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> Max(Vector512<short> left, Vector512<short> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> Max(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> Max(Vector512<int> left, Vector512<int> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> Max(Vector512<uint> left, Vector512<uint> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> Max(Vector512<long> left, Vector512<long> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> Max(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.Max(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.Min_AcceleratedTypes"/>
        public override TypeCodeFlags Min_AcceleratedTypes {
            get {
                return Statics.Min_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Min(Vector512<float> left, Vector512<float> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Min(Vector512<double> left, Vector512<double> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> Min(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> Min(Vector512<byte> left, Vector512<byte> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> Min(Vector512<short> left, Vector512<short> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> Min(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> Min(Vector512<int> left, Vector512<int> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> Min(Vector512<uint> left, Vector512<uint> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> Min(Vector512<long> left, Vector512<long> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> Min(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.Min(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.Multiply_AcceleratedTypes"/>
        public override TypeCodeFlags Multiply_AcceleratedTypes {
            get {
                return Statics.Multiply_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply_FullAcceleratedTypes"/>
        public override TypeCodeFlags Multiply_FullAcceleratedTypes {
            get {
                return Statics.Multiply_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Multiply(Vector512<float> left, Vector512<float> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Multiply(Vector512<double> left, Vector512<double> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> Multiply(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> Multiply(Vector512<byte> left, Vector512<byte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> Multiply(Vector512<short> left, Vector512<short> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> Multiply(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> Multiply(Vector512<int> left, Vector512<int> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> Multiply(Vector512<uint> left, Vector512<uint> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> Multiply(Vector512<long> left, Vector512<long> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> Multiply(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.Multiply(left, right);
        }

/*
        /// <inheritdoc cref="IWVectorTraits512.Negate_AcceleratedTypes"/>
        public override TypeCodeFlags Negate_AcceleratedTypes {
            get {
                return Statics.Negate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Negate(Vector512<float> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Negate(Vector512<double> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> Negate(Vector512<sbyte> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> Negate(Vector512<short> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> Negate(Vector512<int> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> Negate(Vector512<long> value) {
            return Statics.Negate(value);
        }
*/

        /// <inheritdoc cref="IWVectorTraits512.OnesComplement_AcceleratedTypes"/>
        public override TypeCodeFlags OnesComplement_AcceleratedTypes {
            get {
                return Statics.OnesComplement_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.OnesComplement{T}(Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<T> OnesComplement<T>(Vector512<T> vector) where T : struct {
            return Statics.OnesComplement(vector);
        }

/*
        /// <inheritdoc cref="IWVectorTraits512.Sqrt_AcceleratedTypes"/>
        public override TypeCodeFlags Sqrt_AcceleratedTypes {
            get {
                return Statics.Sqrt_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Sqrt(Vector512<float> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Sqrt(Vector512<double> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> Sqrt(Vector512<sbyte> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> Sqrt(Vector512<byte> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> Sqrt(Vector512<short> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> Sqrt(Vector512<ushort> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> Sqrt(Vector512<int> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> Sqrt(Vector512<uint> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> Sqrt(Vector512<long> value) {
            return Statics.Sqrt(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> Sqrt(Vector512<ulong> value) {
            return Statics.Sqrt(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.Subtract_AcceleratedTypes"/>
        public override TypeCodeFlags Subtract_AcceleratedTypes {
            get {
                return Statics.Subtract_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{float}, Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Subtract(Vector512<float> left, Vector512<float> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{double}, Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Subtract(Vector512<double> left, Vector512<double> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> Subtract(Vector512<sbyte> left, Vector512<sbyte> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> Subtract(Vector512<byte> left, Vector512<byte> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> Subtract(Vector512<short> left, Vector512<short> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> Subtract(Vector512<ushort> left, Vector512<ushort> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> Subtract(Vector512<int> left, Vector512<int> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> Subtract(Vector512<uint> left, Vector512<uint> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> Subtract(Vector512<long> left, Vector512<long> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> Subtract(Vector512<ulong> left, Vector512<ulong> right) {
            return Statics.Subtract(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits512.Xor_AcceleratedTypes"/>
        public override TypeCodeFlags Xor_AcceleratedTypes {
            get {
                return Statics.Xor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Xor{T}(Vector512{T}, Vector512{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<T> Xor<T>(Vector512<T> left, Vector512<T> right) where T : struct {
            return Statics.Xor(left, right);
        }
*/
#endif
    }
}
