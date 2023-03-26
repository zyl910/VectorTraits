using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    using Statics = WVectorTraits256Avx2.Statics;

    /// <summary>
    /// <see cref="Vector256{T}"/> traits - Avx2 abstract.
    /// </summary>
    public abstract class WVectorTraits256Avx2Abstract : WVectorTraits256Abstract {
        /// <inheritdoc cref="IBaseTraits.IsSupported"/>
        public override bool IsSupported {
            get {
                return Statics.IsSupported;
            }
        }

        /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
        public override bool GetIsSupported(bool noStrict = false) {
            return Statics.GetIsSupported(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
        public override string GetUnsupportedMessage(bool noStrict = false) {
            return Statics.GetUnsupportedMessage(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
        public override void ThrowForUnsupported(bool noStrict = false) {
            Statics.ThrowForUnsupported(noStrict);
        }

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


        /// <inheritdoc cref="IWVectorTraits256.Ceiling_AcceleratedTypes"/>
        public override TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
                return Statics.Ceiling_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Ceiling(Vector256<float> value) {
            return Statics.Ceiling(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Ceiling(Vector256<double> value) {
            return Statics.Ceiling(value);
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


        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToDouble_AcceleratedTypes {
            get {
                return Statics.ConvertToDouble_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> ConvertToDouble(Vector256<long> value) {
            return Statics.ConvertToDouble(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> ConvertToDouble(Vector256<ulong> value) {
            return Statics.ConvertToDouble(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt32_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToInt32_AcceleratedTypes {
            get {
                return Statics.ConvertToInt32_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt32(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ConvertToInt32(Vector256<float> value) {
            return Statics.ConvertToInt32(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToInt64_AcceleratedTypes {
            get {
                return Statics.ConvertToInt64_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ConvertToInt64(Vector256<double> value) {
            return Statics.ConvertToInt64(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToSingle_AcceleratedTypes {
            get {
                return Statics.ConvertToSingle_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> ConvertToSingle(Vector256<int> value) {
            return Statics.ConvertToSingle(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> ConvertToSingle(Vector256<uint> value) {
            return Statics.ConvertToSingle(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
            get {
                return Statics.ConvertToUInt32_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32(Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ConvertToUInt32(Vector256<float> value) {
            return Statics.ConvertToUInt32(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
            get {
                return Statics.ConvertToUInt64_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64(Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ConvertToUInt64(Vector256<double> value) {
            return Statics.ConvertToUInt64(value);
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


        /// <inheritdoc cref="IWVectorTraits256.Floor_AcceleratedTypes"/>
        public override TypeCodeFlags Floor_AcceleratedTypes {
            get {
                return Statics.Floor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Floor(Vector256<float> value) {
            return Statics.Floor(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Floor(Vector256<double> value) {
            return Statics.Floor(value);
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


        /// <inheritdoc cref="IWVectorTraits256.Narrow_AcceleratedTypes"/>
        public override TypeCodeFlags Narrow_AcceleratedTypes {
            get {
                return Statics.Narrow_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{double}, Vector256{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Narrow(Vector256<double> lower, Vector256<double> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{short}, Vector256{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> Narrow(Vector256<short> lower, Vector256<short> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ushort}, Vector256{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> Narrow(Vector256<ushort> lower, Vector256<ushort> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{int}, Vector256{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> Narrow(Vector256<int> lower, Vector256<int> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{uint}, Vector256{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> Narrow(Vector256<uint> lower, Vector256<uint> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{long}, Vector256{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> Narrow(Vector256<long> lower, Vector256<long> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ulong}, Vector256{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> Narrow(Vector256<ulong> lower, Vector256<ulong> upper) {
            return Statics.Narrow(lower, upper);
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


        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
                return Statics.ShiftLeft_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftLeft(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftLeft(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

         /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftLeft(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftLeftFast(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftLeftFast(Vector256<byte> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftLeftFast(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftLeftFast(Vector256<ushort> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftLeftFast(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftLeftFast(Vector256<uint> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftLeftFast(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftLeftFast(Vector256<ulong> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
                return Statics.ShiftRightArithmetic_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightArithmetic(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightArithmetic(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightArithmeticFast(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightArithmeticFast(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightArithmeticFast(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightArithmeticFast(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
                return Statics.ShiftRightLogical_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightLogical(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftRightLogical(Vector256<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightLogical(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightLogical(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftRightLogical(Vector256<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightLogical(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightLogicalFast(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftRightLogicalFast(Vector256<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightLogicalFast(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftRightLogicalFast(Vector256<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightLogicalFast(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftRightLogicalFast(Vector256<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightLogicalFast(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftRightLogicalFast(Vector256<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
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


        /// <inheritdoc cref="IWVectorTraits256.Sum_AcceleratedTypes"/>
        public override TypeCodeFlags Sum_AcceleratedTypes {
            get {
                return Statics.Sum_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override float Sum(Vector256<float> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override double Sum(Vector256<double> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override sbyte Sum(Vector256<sbyte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override byte Sum(Vector256<byte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override short Sum(Vector256<short> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ushort Sum(Vector256<ushort> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int Sum(Vector256<int> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint Sum(Vector256<uint> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override long Sum(Vector256<long> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong Sum(Vector256<ulong> value) {
            return Statics.Sum(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.Widen_AcceleratedTypes"/>
        public override TypeCodeFlags Widen_AcceleratedTypes {
            get {
                return Statics.Widen_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector256<float> source, out Vector256<double> lower, out Vector256<double> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{sbyte}, out Vector256{short}, out Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector256<sbyte> source, out Vector256<short> lower, out Vector256<short> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{byte}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector256<byte> source, out Vector256<ushort> lower, out Vector256<ushort> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{short}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector256<short> source, out Vector256<int> lower, out Vector256<int> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{ushort}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector256<ushort> source, out Vector256<uint> lower, out Vector256<uint> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{int}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector256<int> source, out Vector256<long> lower, out Vector256<long> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{uint}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector256<uint> source, out Vector256<ulong> lower, out Vector256<ulong> upper) {
            Statics.Widen(source, out lower, out upper);
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


        /// <inheritdoc cref="IWVectorTraits256.YClamp_AcceleratedTypes"/>
        public override TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return Statics.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{float}, Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> YClamp(Vector256<float> value, Vector256<float> amin, Vector256<float> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{double}, Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> YClamp(Vector256<double> value, Vector256<double> amin, Vector256<double> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> YClamp(Vector256<sbyte> value, Vector256<sbyte> amin, Vector256<sbyte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> YClamp(Vector256<byte> value, Vector256<byte> amin, Vector256<byte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> YClamp(Vector256<short> value, Vector256<short> amin, Vector256<short> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> YClamp(Vector256<ushort> value, Vector256<ushort> amin, Vector256<ushort> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> YClamp(Vector256<int> value, Vector256<int> amin, Vector256<int> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> YClamp(Vector256<uint> value, Vector256<uint> amin, Vector256<uint> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> YClamp(Vector256<long> value, Vector256<long> amin, Vector256<long> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> YClamp(Vector256<ulong> value, Vector256<ulong> amin, Vector256<ulong> amax) {
            return Statics.YClamp(value, amin, amax);
        }


        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate_AcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate_FullAcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{short}, Vector256{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> YNarrowSaturate(Vector256<short> lower, Vector256<short> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{ushort}, Vector256{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> YNarrowSaturate(Vector256<ushort> lower, Vector256<ushort> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{int}, Vector256{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> YNarrowSaturate(Vector256<int> lower, Vector256<int> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{uint}, Vector256{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> YNarrowSaturate(Vector256<uint> lower, Vector256<uint> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{long}, Vector256{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> YNarrowSaturate(Vector256<long> lower, Vector256<long> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{ulong}, Vector256{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> YNarrowSaturate(Vector256<ulong> lower, Vector256<ulong> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public override TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{short}, Vector256{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> YNarrowSaturateUnsigned(Vector256<short> lower, Vector256<short> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{int}, Vector256{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> YNarrowSaturateUnsigned(Vector256<int> lower, Vector256<int> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{long}, Vector256{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> YNarrowSaturateUnsigned(Vector256<long> lower, Vector256<long> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }


#endif
    }
}
