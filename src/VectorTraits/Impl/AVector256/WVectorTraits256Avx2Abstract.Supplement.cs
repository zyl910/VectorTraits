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

namespace Zyl.VectorTraits.Impl.AVector256 {
    using Statics = WVectorTraits256Avx2.Statics;

    partial class WVectorTraits256Avx2Abstract {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits256.Abs_AcceleratedTypes"/>
        public override TypeCodeFlags Abs_AcceleratedTypes {
            get {
                return Statics.Abs_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Abs(Vector256<float> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Abs(Vector256<double> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> Abs(Vector256<sbyte> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> Abs(Vector256<short> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> Abs(Vector256<int> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> Abs(Vector256<long> value) {
            return Statics.Abs(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.Add_AcceleratedTypes"/>
        public override TypeCodeFlags Add_AcceleratedTypes {
            get {
                return Statics.Add_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Add(Vector256<float> left, Vector256<float> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Add(Vector256<double> left, Vector256<double> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> Add(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> Add(Vector256<byte> left, Vector256<byte> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> Add(Vector256<short> left, Vector256<short> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> Add(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> Add(Vector256<int> left, Vector256<int> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> Add(Vector256<uint> left, Vector256<uint> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> Add(Vector256<long> left, Vector256<long> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> Add(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.Add(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.AndNot_AcceleratedTypes"/>
        public override TypeCodeFlags AndNot_AcceleratedTypes {
            get {
                return Statics.AndNot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.AndNot{T}(Vector256{T}, Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<T> AndNot<T>(Vector256<T> left, Vector256<T> right) where T : struct {
            return Statics.AndNot(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd_AcceleratedTypes"/>
        public override TypeCodeFlags BitwiseAnd_AcceleratedTypes {
            get {
                return Statics.BitwiseAnd_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd{T}(Vector256{T}, Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<T> BitwiseAnd<T>(Vector256<T> left, Vector256<T> right) where T : struct {
            return Statics.BitwiseAnd(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.BitwiseOr_AcceleratedTypes"/>
        public override TypeCodeFlags BitwiseOr_AcceleratedTypes {
            get {
                return Statics.BitwiseOr_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.BitwiseOr{T}(Vector256{T}, Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<T> BitwiseOr<T>(Vector256<T> left, Vector256<T> right) where T : struct {
            return Statics.BitwiseOr(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect_AcceleratedTypes"/>
        public override TypeCodeFlags ConditionalSelect_AcceleratedTypes {
            get {
                return Statics.ConditionalSelect_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<T> ConditionalSelect<T>(Vector256<T> condition, Vector256<T> left, Vector256<T> right) where T : struct {
            return Statics.ConditionalSelect(condition, left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect(Vector256{int}, Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> ConditionalSelect(Vector256<int> condition, Vector256<float> left, Vector256<float> right) {
            return ConditionalSelect<float>(condition.AsSingle(), left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect(Vector256{long}, Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> ConditionalSelect(Vector256<long> condition, Vector256<double> left, Vector256<double> right) {
            return ConditionalSelect<double>(condition.AsDouble(), left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.Divide_AcceleratedTypes"/>
        public override TypeCodeFlags Divide_AcceleratedTypes {
            get {
                return Statics.Divide_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Divide(Vector256<float> left, Vector256<float> right) {
            return Statics.Divide(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Divide(Vector256<double> left, Vector256<double> right) {
            return Statics.Divide(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.Dot_AcceleratedTypes"/>
        public override TypeCodeFlags Dot_AcceleratedTypes {
            get {
                return Statics.Dot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override float Dot(Vector256<float> left, Vector256<float> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override double Dot(Vector256<double> left, Vector256<double> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override sbyte Dot(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override byte Dot(Vector256<byte> left, Vector256<byte> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override short Dot(Vector256<short> left, Vector256<short> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ushort Dot(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int Dot(Vector256<int> left, Vector256<int> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint Dot(Vector256<uint> left, Vector256<uint> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override long Dot(Vector256<long> left, Vector256<long> right) {
            return Statics.Dot(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong Dot(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.Dot(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.Equals_AcceleratedTypes"/>
        public override TypeCodeFlags Equals_AcceleratedTypes {
            get {
                return Statics.Equals_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Equals(Vector256<float> left, Vector256<float> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Equals(Vector256<double> left, Vector256<double> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> Equals(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> Equals(Vector256<byte> left, Vector256<byte> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> Equals(Vector256<short> left, Vector256<short> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> Equals(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> Equals(Vector256<int> left, Vector256<int> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> Equals(Vector256<uint> left, Vector256<uint> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> Equals(Vector256<long> left, Vector256<long> right) {
            return Statics.Equals(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> Equals(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.Equals(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.EqualsAll_AcceleratedTypes"/>
        public override TypeCodeFlags EqualsAll_AcceleratedTypes {
            get {
                return Statics.EqualsAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector256<float> left, Vector256<float> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector256<double> left, Vector256<double> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector256<byte> left, Vector256<byte> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector256<short> left, Vector256<short> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector256<int> left, Vector256<int> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector256<uint> left, Vector256<uint> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector256<long> left, Vector256<long> right) {
            return Statics.EqualsAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAll(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.EqualsAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.EqualsAny_AcceleratedTypes"/>
        public override TypeCodeFlags EqualsAny_AcceleratedTypes {
            get {
                return Statics.EqualsAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector256<float> left, Vector256<float> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector256<double> left, Vector256<double> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector256<byte> left, Vector256<byte> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector256<short> left, Vector256<short> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector256<int> left, Vector256<int> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector256<uint> left, Vector256<uint> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector256<long> left, Vector256<long> right) {
            return Statics.EqualsAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool EqualsAny(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.EqualsAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.GreaterThan_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThan_AcceleratedTypes {
            get {
                return Statics.GreaterThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> GreaterThan(Vector256<float> left, Vector256<float> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> GreaterThan(Vector256<double> left, Vector256<double> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> GreaterThan(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> GreaterThan(Vector256<byte> left, Vector256<byte> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> GreaterThan(Vector256<short> left, Vector256<short> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> GreaterThan(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> GreaterThan(Vector256<int> left, Vector256<int> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> GreaterThan(Vector256<uint> left, Vector256<uint> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> GreaterThan(Vector256<long> left, Vector256<long> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> GreaterThan(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.GreaterThan(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanAll_AcceleratedTypes {
            get {
                return Statics.GreaterThanAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector256<float> left, Vector256<float> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector256<double> left, Vector256<double> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector256<byte> left, Vector256<byte> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector256<short> left, Vector256<short> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector256<int> left, Vector256<int> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector256<uint> left, Vector256<uint> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector256<long> left, Vector256<long> right) {
            return Statics.GreaterThanAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAll(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.GreaterThanAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanAny_AcceleratedTypes {
            get {
                return Statics.GreaterThanAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector256<float> left, Vector256<float> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector256<double> left, Vector256<double> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector256<byte> left, Vector256<byte> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector256<short> left, Vector256<short> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector256<int> left, Vector256<int> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector256<uint> left, Vector256<uint> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector256<long> left, Vector256<long> right) {
            return Statics.GreaterThanAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanAny(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.GreaterThanAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanOrEqual_AcceleratedTypes {
            get {
                return Statics.GreaterThanOrEqual_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> GreaterThanOrEqual(Vector256<float> left, Vector256<float> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> GreaterThanOrEqual(Vector256<double> left, Vector256<double> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> GreaterThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> GreaterThanOrEqual(Vector256<byte> left, Vector256<byte> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> GreaterThanOrEqual(Vector256<short> left, Vector256<short> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> GreaterThanOrEqual(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> GreaterThanOrEqual(Vector256<int> left, Vector256<int> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> GreaterThanOrEqual(Vector256<uint> left, Vector256<uint> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> GreaterThanOrEqual(Vector256<long> left, Vector256<long> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> GreaterThanOrEqual(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.GreaterThanOrEqual(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanOrEqualAll_AcceleratedTypes {
            get {
                return Statics.GreaterThanOrEqualAll_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector256<float> left, Vector256<float> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector256<double> left, Vector256<double> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector256<byte> left, Vector256<byte> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector256<short> left, Vector256<short> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector256<int> left, Vector256<int> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector256<uint> left, Vector256<uint> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector256<long> left, Vector256<long> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAll(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.GreaterThanOrEqualAll(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThanOrEqualAny_AcceleratedTypes {
            get {
                return Statics.GreaterThanOrEqualAny_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector256<float> left, Vector256<float> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector256<double> left, Vector256<double> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector256<byte> left, Vector256<byte> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector256<short> left, Vector256<short> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector256<int> left, Vector256<int> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector256<uint> left, Vector256<uint> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector256<long> left, Vector256<long> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool GreaterThanOrEqualAny(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.GreaterThanOrEqualAny(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.LessThan_AcceleratedTypes"/>
        public override TypeCodeFlags LessThan_AcceleratedTypes {
            get {
                return Statics.LessThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> LessThan(Vector256<float> left, Vector256<float> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> LessThan(Vector256<double> left, Vector256<double> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> LessThan(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> LessThan(Vector256<byte> left, Vector256<byte> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> LessThan(Vector256<short> left, Vector256<short> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> LessThan(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> LessThan(Vector256<int> left, Vector256<int> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> LessThan(Vector256<uint> left, Vector256<uint> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> LessThan(Vector256<long> left, Vector256<long> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> LessThan(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.LessThan(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.Max_AcceleratedTypes"/>
        public override TypeCodeFlags Max_AcceleratedTypes {
            get {
                return Statics.Max_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Max(Vector256<float> left, Vector256<float> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Max(Vector256<double> left, Vector256<double> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> Max(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> Max(Vector256<byte> left, Vector256<byte> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> Max(Vector256<short> left, Vector256<short> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> Max(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> Max(Vector256<int> left, Vector256<int> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> Max(Vector256<uint> left, Vector256<uint> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> Max(Vector256<long> left, Vector256<long> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> Max(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.Max(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.Min_AcceleratedTypes"/>
        public override TypeCodeFlags Min_AcceleratedTypes {
            get {
                return Statics.Min_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Min(Vector256<float> left, Vector256<float> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Min(Vector256<double> left, Vector256<double> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> Min(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> Min(Vector256<byte> left, Vector256<byte> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> Min(Vector256<short> left, Vector256<short> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> Min(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> Min(Vector256<int> left, Vector256<int> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> Min(Vector256<uint> left, Vector256<uint> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> Min(Vector256<long> left, Vector256<long> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> Min(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.Min(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.Multiply_AcceleratedTypes"/>
        public override TypeCodeFlags Multiply_AcceleratedTypes {
            get {
                return Statics.Multiply_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply_FullAcceleratedTypes"/>
        public override TypeCodeFlags Multiply_FullAcceleratedTypes {
            get {
                return Statics.Multiply_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Multiply(Vector256<float> left, Vector256<float> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Multiply(Vector256<double> left, Vector256<double> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> Multiply(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> Multiply(Vector256<byte> left, Vector256<byte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> Multiply(Vector256<short> left, Vector256<short> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> Multiply(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> Multiply(Vector256<int> left, Vector256<int> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> Multiply(Vector256<uint> left, Vector256<uint> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> Multiply(Vector256<long> left, Vector256<long> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> Multiply(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.Multiply(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.Negate_AcceleratedTypes"/>
        public override TypeCodeFlags Negate_AcceleratedTypes {
            get {
                return Statics.Negate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Negate(Vector256<float> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Negate(Vector256<double> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> Negate(Vector256<sbyte> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> Negate(Vector256<short> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> Negate(Vector256<int> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> Negate(Vector256<long> value) {
            return Statics.Negate(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.OnesComplement_AcceleratedTypes"/>
        public override TypeCodeFlags OnesComplement_AcceleratedTypes {
            get {
                return Statics.OnesComplement_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.OnesComplement{T}(Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<T> OnesComplement<T>(Vector256<T> vector) where T : struct {
            return Statics.OnesComplement(vector);
        }


        /// <inheritdoc cref="IWVectorTraits256.Subtract_AcceleratedTypes"/>
        public override TypeCodeFlags Subtract_AcceleratedTypes {
            get {
                return Statics.Subtract_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Subtract(Vector256<float> left, Vector256<float> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Subtract(Vector256<double> left, Vector256<double> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> Subtract(Vector256<sbyte> left, Vector256<sbyte> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> Subtract(Vector256<byte> left, Vector256<byte> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> Subtract(Vector256<short> left, Vector256<short> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> Subtract(Vector256<ushort> left, Vector256<ushort> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> Subtract(Vector256<int> left, Vector256<int> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> Subtract(Vector256<uint> left, Vector256<uint> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> Subtract(Vector256<long> left, Vector256<long> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> Subtract(Vector256<ulong> left, Vector256<ulong> right) {
            return Statics.Subtract(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.Xor_AcceleratedTypes"/>
        public override TypeCodeFlags Xor_AcceleratedTypes {
            get {
                return Statics.Xor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Xor{T}(Vector256{T}, Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<T> Xor<T>(Vector256<T> left, Vector256<T> right) where T : struct {
            return Statics.Xor(left, right);
        }

#endif
    }
}
