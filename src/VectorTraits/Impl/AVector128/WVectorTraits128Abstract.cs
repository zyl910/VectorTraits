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

namespace Zyl.VectorTraits.Impl.AVector128 {
    using Statics = WVectorTraits128Base.Statics;

    /// <summary>
    /// <see cref="Vector128{T}"/> traits - abstract.
    /// </summary>
    public abstract class WVectorTraits128Abstract : IWVectorTraits128, IBaseTraits {

        /// <summary>
        /// Get best instance.
        /// </summary>
        /// <returns>Returns best instance.</returns>
        [CLSCompliant(false)]
        public static IWVectorTraits128 GetBestInstance() {
            if (WVectorTraits128AdvSimdB64.Instance.IsSupported) return WVectorTraits128AdvSimdB64.Instance;
            if (WVectorTraits128AdvSimd.Instance.IsSupported) return WVectorTraits128AdvSimd.Instance;
            return WVectorTraits128Base.Instance;
        }

        /// <summary>ByteCount value</summary>
        public const int ByteCountValue = 32;

        /// <inheritdoc cref="IBaseTraits.ByteCount"/>
        public int ByteCount {
            get {
                return Statics.ByteCount;
            }
        }

        /// <inheritdoc cref="IBaseTraits.IsSupported"/>
        public virtual bool IsSupported {
            get {
                return Statics.IsSupported;
            }
        }

        /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
        public virtual bool GetIsSupported(bool noStrict = false) {
            return Statics.GetIsSupported(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
        public virtual string GetUnsupportedMessage(bool noStrict = false) {
            return Statics.GetUnsupportedMessage(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
        public virtual void ThrowForUnsupported(bool noStrict = false) {
            Statics.ThrowForUnsupported(noStrict);
        }

#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.Abs_AcceleratedTypes"/>
        public virtual TypeCodeFlags Abs_AcceleratedTypes {
            get {
                return Statics.Abs_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Abs(Vector128<float> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Abs(Vector128<double> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Abs(Vector128<sbyte> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Abs(Vector128<short> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Abs(Vector128<int> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Abs(Vector128<long> value) {
            return Statics.Abs(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.Add_AcceleratedTypes"/>
        public virtual TypeCodeFlags Add_AcceleratedTypes {
            get {
                return Statics.Add_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Add(Vector128<float> left, Vector128<float> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Add(Vector128<double> left, Vector128<double> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Add(Vector128<short> left, Vector128<short> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Add(Vector128<int> left, Vector128<int> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Add(Vector128<long> left, Vector128<long> right) {
            return Statics.Add(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Add(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.AndNot_AcceleratedTypes"/>
        public virtual TypeCodeFlags AndNot_AcceleratedTypes {
            get {
                return Statics.AndNot_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.AndNot{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<T> AndNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.AndNot(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd_AcceleratedTypes"/>
        public virtual TypeCodeFlags BitwiseAnd_AcceleratedTypes {
            get {
                return Statics.BitwiseAnd_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<T> BitwiseAnd<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.BitwiseAnd(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.BitwiseOr_AcceleratedTypes"/>
        public virtual TypeCodeFlags BitwiseOr_AcceleratedTypes {
            get {
                return Statics.BitwiseOr_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<T> BitwiseOr<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.BitwiseOr(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Ceiling_AcceleratedTypes"/>
        public virtual TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
                return Statics.Ceiling_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Ceiling(Vector128<float> value) {
            return Statics.Ceiling(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Ceiling(Vector128<double> value) {
            return Statics.Ceiling(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConditionalSelect_AcceleratedTypes {
            get {
                return Statics.ConditionalSelect_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<T> ConditionalSelect<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.ConditionalSelect(condition, left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect(Vector128{int}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> ConditionalSelect(Vector128<int> condition, Vector128<float> left, Vector128<float> right) {
            return ConditionalSelect<float>(condition.AsSingle(), left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect(Vector128{long}, Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> ConditionalSelect(Vector128<long> condition, Vector128<double> left, Vector128<double> right) {
            return ConditionalSelect<double>(condition.AsDouble(), left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConvertToDouble_AcceleratedTypes {
            get {
                return Statics.ConvertToDouble_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> ConvertToDouble(Vector128<long> value) {
            return Statics.ConvertToDouble(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> ConvertToDouble(Vector128<ulong> value) {
            return Statics.ConvertToDouble(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.ConvertToInt32_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConvertToInt32_AcceleratedTypes {
            get {
                return Statics.ConvertToInt32_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToInt32(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ConvertToInt32(Vector128<float> value) {
            return Statics.ConvertToInt32(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConvertToInt64_AcceleratedTypes {
            get {
                return Statics.ConvertToInt64_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ConvertToInt64(Vector128<double> value) {
            return Statics.ConvertToInt64(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConvertToSingle_AcceleratedTypes {
            get {
                return Statics.ConvertToSingle_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> ConvertToSingle(Vector128<int> value) {
            return Statics.ConvertToSingle(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> ConvertToSingle(Vector128<uint> value) {
            return Statics.ConvertToSingle(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
            get {
                return Statics.ConvertToUInt32_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> ConvertToUInt32(Vector128<float> value) {
            return Statics.ConvertToUInt32(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64_AcceleratedTypes"/>
        public virtual TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
            get {
                return Statics.ConvertToUInt64_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64(Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> ConvertToUInt64(Vector128<double> value) {
            return Statics.ConvertToUInt64(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.Divide_AcceleratedTypes"/>
        public virtual TypeCodeFlags Divide_AcceleratedTypes {
            get {
                return Statics.Divide_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Divide(Vector128<float> left, Vector128<float> right) {
            return Statics.Divide(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Divide(Vector128<double> left, Vector128<double> right) {
            return Statics.Divide(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits_AcceleratedTypes"/>
        public virtual TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
            get {
                return Statics.ExtractMostSignificantBits_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector128<float> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector128<double> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector128<sbyte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector128<byte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector128<short> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector128<ushort> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector128<int> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector128<uint> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector128<long> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint ExtractMostSignificantBits(Vector128<ulong> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }


        /// <inheritdoc cref="IWVectorTraits128.Floor_AcceleratedTypes"/>
        public virtual TypeCodeFlags Floor_AcceleratedTypes {
            get {
                return Statics.Floor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Floor(Vector128<float> value) {
            return Statics.Floor(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Floor(Vector128<double> value) {
            return Statics.Floor(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.GreaterThan_AcceleratedTypes"/>
        public virtual TypeCodeFlags GreaterThan_AcceleratedTypes {
            get {
                return Statics.GreaterThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> GreaterThan(Vector128<float> left, Vector128<float> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> GreaterThan(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> GreaterThan(Vector128<byte> left, Vector128<byte> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> GreaterThan(Vector128<short> left, Vector128<short> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> GreaterThan(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> GreaterThan(Vector128<int> left, Vector128<int> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> GreaterThan(Vector128<uint> left, Vector128<uint> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.GreaterThan(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.LessThan_AcceleratedTypes"/>
        public virtual TypeCodeFlags LessThan_AcceleratedTypes {
            get {
                return Statics.LessThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> LessThan(Vector128<float> left, Vector128<float> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> LessThan(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> LessThan(Vector128<byte> left, Vector128<byte> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> LessThan(Vector128<short> left, Vector128<short> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> LessThan(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> LessThan(Vector128<int> left, Vector128<int> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> LessThan(Vector128<uint> left, Vector128<uint> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> LessThan(Vector128<long> left, Vector128<long> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.LessThan(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Max_AcceleratedTypes"/>
        public virtual TypeCodeFlags Max_AcceleratedTypes {
            get {
                return Statics.Max_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Max(Vector128<float> left, Vector128<float> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Max(Vector128<short> left, Vector128<short> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Max(Vector128<int> left, Vector128<int> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Max(Vector128<long> left, Vector128<long> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Max(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Min_AcceleratedTypes"/>
        public virtual TypeCodeFlags Min_AcceleratedTypes {
            get {
                return Statics.Min_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Min(Vector128<float> left, Vector128<float> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Min(Vector128<short> left, Vector128<short> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Min(Vector128<int> left, Vector128<int> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Min(Vector128<long> left, Vector128<long> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Min(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Multiply_AcceleratedTypes"/>
        public virtual TypeCodeFlags Multiply_AcceleratedTypes {
            get {
                return Statics.Multiply_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply_FullAcceleratedTypes"/>
        public virtual TypeCodeFlags Multiply_FullAcceleratedTypes {
            get {
                return Statics.Multiply_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Multiply(Vector128<float> left, Vector128<float> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Multiply(Vector128<double> left, Vector128<double> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Multiply(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> Multiply(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Multiply(Vector128<short> left, Vector128<short> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> Multiply(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Multiply(Vector128<int> left, Vector128<int> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> Multiply(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Multiply(Vector128<long> left, Vector128<long> right) {
            return Statics.Multiply(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> Multiply(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Multiply(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Narrow_AcceleratedTypes"/>
        public virtual TypeCodeFlags Narrow_AcceleratedTypes {
            get {
                return Statics.Narrow_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{double}, Vector128{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Narrow(Vector128<double> lower, Vector128<double> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{short}, Vector128{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Narrow(Vector128<short> lower, Vector128<short> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{ushort}, Vector128{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> Narrow(Vector128<ushort> lower, Vector128<ushort> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{int}, Vector128{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Narrow(Vector128<int> lower, Vector128<int> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{uint}, Vector128{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> Narrow(Vector128<uint> lower, Vector128<uint> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{long}, Vector128{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Narrow(Vector128<long> lower, Vector128<long> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{ulong}, Vector128{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> Narrow(Vector128<ulong> lower, Vector128<ulong> upper) {
            return Statics.Narrow(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits128.Negate_AcceleratedTypes"/>
        public virtual TypeCodeFlags Negate_AcceleratedTypes {
            get {
                return Statics.Negate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Negate(Vector128<float> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Negate(Vector128<double> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Negate(Vector128<sbyte> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Negate(Vector128<short> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Negate(Vector128<int> value) {
            return Statics.Negate(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Negate(Vector128<long> value) {
            return Statics.Negate(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.OnesComplement_AcceleratedTypes"/>
        public virtual TypeCodeFlags OnesComplement_AcceleratedTypes {
            get {
                return Statics.OnesComplement_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.OnesComplement{T}(Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<T> OnesComplement<T>(Vector128<T> vector) where T : struct {
            return Statics.OnesComplement(vector);
        }


        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
        public virtual TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
                return Statics.ShiftLeft_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> ShiftLeft(Vector128<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> ShiftLeft(Vector128<byte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> ShiftLeft(Vector128<short> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> ShiftLeft(Vector128<ushort> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ShiftLeft(Vector128<int> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> ShiftLeft(Vector128<uint> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ShiftLeft(Vector128<long> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> ShiftLeft(Vector128<ulong> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> ShiftLeftFast(Vector128<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> ShiftLeftFast(Vector128<byte> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> ShiftLeftFast(Vector128<short> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> ShiftLeftFast(Vector128<ushort> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ShiftLeftFast(Vector128<int> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> ShiftLeftFast(Vector128<uint> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ShiftLeftFast(Vector128<long> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> ShiftLeftFast(Vector128<ulong> value, int shiftAmount) {
            return Statics.ShiftLeftFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_AcceleratedTypes"/>
        public virtual TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
                return Statics.ShiftRightArithmetic_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> ShiftRightArithmetic(Vector128<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ShiftRightArithmetic(Vector128<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> ShiftRightArithmeticFast(Vector128<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> ShiftRightArithmeticFast(Vector128<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ShiftRightArithmeticFast(Vector128<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ShiftRightArithmeticFast(Vector128<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmeticFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
        public virtual TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
                return Statics.ShiftRightLogical_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> ShiftRightLogical(Vector128<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> ShiftRightLogical(Vector128<short> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ShiftRightLogical(Vector128<int> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> ShiftRightLogical(Vector128<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ShiftRightLogical(Vector128<long> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> ShiftRightLogicalFast(Vector128<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> ShiftRightLogicalFast(Vector128<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> ShiftRightLogicalFast(Vector128<short> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> ShiftRightLogicalFast(Vector128<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> ShiftRightLogicalFast(Vector128<int> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> ShiftRightLogicalFast(Vector128<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> ShiftRightLogicalFast(Vector128<long> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> ShiftRightLogicalFast(Vector128<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogicalFast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        public virtual TypeCodeFlags Shuffle_AcceleratedTypes {
            get {
                return Statics.Shuffle_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Shuffle(Vector128<float> vector, Vector128<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Shuffle(Vector128<double> vector, Vector128<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Shuffle(Vector128<sbyte> vector, Vector128<sbyte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> Shuffle(Vector128<byte> vector, Vector128<byte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Shuffle(Vector128<short> vector, Vector128<short> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> Shuffle(Vector128<ushort> vector, Vector128<ushort> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Shuffle(Vector128<int> vector, Vector128<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> Shuffle(Vector128<uint> vector, Vector128<uint> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Shuffle(Vector128<long> vector, Vector128<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> Shuffle(Vector128<ulong> vector, Vector128<ulong> indices) {
            return Statics.Shuffle(vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Shuffle_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Shuffle_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Shuffle_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Shuffle_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> Shuffle_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Shuffle_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> Shuffle_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Shuffle_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> Shuffle_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Shuffle_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> Shuffle_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }


        /// <inheritdoc cref="IWVectorTraits128.Subtract_AcceleratedTypes"/>
        public virtual TypeCodeFlags Subtract_AcceleratedTypes {
            get {
                return Statics.Subtract_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> Subtract(Vector128<float> left, Vector128<float> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> Subtract(Vector128<double> left, Vector128<double> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> Subtract(Vector128<short> left, Vector128<short> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> Subtract(Vector128<int> left, Vector128<int> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> Subtract(Vector128<long> left, Vector128<long> right) {
            return Statics.Subtract(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Subtract(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Sum_AcceleratedTypes"/>
        public virtual TypeCodeFlags Sum_AcceleratedTypes {
            get {
                return Statics.Sum_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual float Sum(Vector128<float> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual double Sum(Vector128<double> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual sbyte Sum(Vector128<sbyte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual byte Sum(Vector128<byte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual short Sum(Vector128<short> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual ushort Sum(Vector128<ushort> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual int Sum(Vector128<int> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual uint Sum(Vector128<uint> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual long Sum(Vector128<long> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual ulong Sum(Vector128<ulong> value) {
            return Statics.Sum(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.Widen_AcceleratedTypes"/>
        public virtual TypeCodeFlags Widen_AcceleratedTypes {
            get {
                return Statics.Widen_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{float}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector128<float> source, out Vector128<double> lower, out Vector128<double> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{sbyte}, out Vector128{short}, out Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector128<sbyte> source, out Vector128<short> lower, out Vector128<short> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{byte}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector128<byte> source, out Vector128<ushort> lower, out Vector128<ushort> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{short}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector128<short> source, out Vector128<int> lower, out Vector128<int> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector128<ushort> source, out Vector128<uint> lower, out Vector128<uint> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void Widen(Vector128<uint> source, out Vector128<ulong> lower, out Vector128<ulong> upper) {
            Statics.Widen(source, out lower, out upper);
        }


        /// <inheritdoc cref="IWVectorTraits128.Xor_AcceleratedTypes"/>
        public virtual TypeCodeFlags Xor_AcceleratedTypes {
            get {
                return Statics.Xor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Xor{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right) where T : struct {
            return Statics.Xor(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.YClamp_AcceleratedTypes"/>
        public virtual TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return Statics.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{float}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> YClamp(Vector128<float> value, Vector128<float> amin, Vector128<float> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{double}, Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YClamp(Vector128<sbyte> value, Vector128<sbyte> amin, Vector128<sbyte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YClamp(Vector128<byte> value, Vector128<byte> amin, Vector128<byte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YClamp(Vector128<short> value, Vector128<short> amin, Vector128<short> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YClamp(Vector128<ushort> value, Vector128<ushort> amin, Vector128<ushort> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YClamp(Vector128<int> value, Vector128<int> amin, Vector128<int> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YClamp(Vector128<uint> value, Vector128<uint> amin, Vector128<uint> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> YClamp(Vector128<long> value, Vector128<long> amin, Vector128<long> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> YClamp(Vector128<ulong> value, Vector128<ulong> amin, Vector128<ulong> amax) {
            return Statics.YClamp(value, amin, amax);
        }


        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_AcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_FullAcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{short}, Vector128{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YNarrowSaturate(Vector128<short> lower, Vector128<short> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ushort}, Vector128{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YNarrowSaturate(Vector128<ushort> lower, Vector128<ushort> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{int}, Vector128{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YNarrowSaturate(Vector128<int> lower, Vector128<int> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{uint}, Vector128{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YNarrowSaturate(Vector128<uint> lower, Vector128<uint> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{long}, Vector128{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YNarrowSaturate(Vector128<long> lower, Vector128<long> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ulong}, Vector128{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YNarrowSaturate(Vector128<ulong> lower, Vector128<ulong> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{short}, Vector128{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YNarrowSaturateUnsigned(Vector128<short> lower, Vector128<short> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{int}, Vector128{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YNarrowSaturateUnsigned(Vector128<int> lower, Vector128<int> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{long}, Vector128{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YNarrowSaturateUnsigned(Vector128<long> lower, Vector128<long> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleG2_AcceleratedTypes {
            get {
                return Statics.YShuffleG2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> YShuffleG2(Vector128<float> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> YShuffleG2(Vector128<double> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YShuffleG2(Vector128<sbyte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YShuffleG2(Vector128<byte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YShuffleG2(Vector128<short> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YShuffleG2(Vector128<ushort> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YShuffleG2(Vector128<int> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YShuffleG2(Vector128<uint> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> YShuffleG2(Vector128<long> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> YShuffleG2(Vector128<ulong> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> YShuffleG2_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> YShuffleG2_Const(Vector128<double> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YShuffleG2_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YShuffleG2_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YShuffleG2_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YShuffleG2_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YShuffleG2_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YShuffleG2_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> YShuffleG2_Const(Vector128<long> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> YShuffleG2_Const(Vector128<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleG4_AcceleratedTypes {
            get {
                return Statics.YShuffleG4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> YShuffleG4(Vector128<float> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YShuffleG4(Vector128<sbyte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YShuffleG4(Vector128<byte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YShuffleG4(Vector128<short> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YShuffleG4(Vector128<ushort> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YShuffleG4(Vector128<int> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YShuffleG4(Vector128<uint> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> YShuffleG4_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YShuffleG4_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YShuffleG4_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YShuffleG4_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YShuffleG4_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YShuffleG4_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YShuffleG4_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
            get {
                return Statics.YShuffleG4X2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> YShuffleG4X2(Vector128<float> source0, Vector128<float> source1, ShuffleControlG4 control, out Vector128<float> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{double}, Vector128{double}, ShuffleControlG4, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> YShuffleG4X2(Vector128<double> source0, Vector128<double> source1, ShuffleControlG4 control, out Vector128<double> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YShuffleG4X2(Vector128<sbyte> source0, Vector128<sbyte> source1, ShuffleControlG4 control, out Vector128<sbyte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YShuffleG4X2(Vector128<byte> source0, Vector128<byte> source1, ShuffleControlG4 control, out Vector128<byte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YShuffleG4X2(Vector128<short> source0, Vector128<short> source1, ShuffleControlG4 control, out Vector128<short> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YShuffleG4X2(Vector128<ushort> source0, Vector128<ushort> source1, ShuffleControlG4 control, out Vector128<ushort> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YShuffleG4X2(Vector128<int> source0, Vector128<int> source1, ShuffleControlG4 control, out Vector128<int> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YShuffleG4X2(Vector128<uint> source0, Vector128<uint> source1, ShuffleControlG4 control, out Vector128<uint> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> YShuffleG4X2(Vector128<long> source0, Vector128<long> source1, ShuffleControlG4 control, out Vector128<long> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> YShuffleG4X2(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control, out Vector128<ulong> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> YShuffleG4X2_Const(Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<float> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{double}, Vector128{double}, ShuffleControlG4, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> YShuffleG4X2_Const(Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<double> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YShuffleG4X2_Const(Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<sbyte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YShuffleG4X2_Const(Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<byte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YShuffleG4X2_Const(Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<short> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YShuffleG4X2_Const(Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ushort> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YShuffleG4X2_Const(Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<int> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YShuffleG4X2_Const(Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<uint> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> YShuffleG4X2_Const(Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<long> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> YShuffleG4X2_Const(Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ulong> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{float}, Vector128{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<float> Result0, Vector128<float> Result1) YShuffleG4X2(Vector128<float> source0, Vector128<float> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{double}, Vector128{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<double> Result0, Vector128<double> Result1) YShuffleG4X2(Vector128<double> source0, Vector128<double> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<sbyte> Result0, Vector128<sbyte> Result1) YShuffleG4X2(Vector128<sbyte> source0, Vector128<sbyte> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<byte> Result0, Vector128<byte> Result1) YShuffleG4X2(Vector128<byte> source0, Vector128<byte> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{short}, Vector128{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<short> Result0, Vector128<short> Result1) YShuffleG4X2(Vector128<short> source0, Vector128<short> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<ushort> Result0, Vector128<ushort> Result1) YShuffleG4X2(Vector128<ushort> source0, Vector128<ushort> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{int}, Vector128{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<int> Result0, Vector128<int> Result1) YShuffleG4X2(Vector128<int> source0, Vector128<int> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{uint}, Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<uint> Result0, Vector128<uint> Result1) YShuffleG4X2(Vector128<uint> source0, Vector128<uint> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{long}, Vector128{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<long> Result0, Vector128<long> Result1) YShuffleG4X2(Vector128<long> source0, Vector128<long> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<ulong> Result0, Vector128<ulong> Result1) YShuffleG4X2(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control) {
            return Statics.YShuffleG4X2(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{float}, Vector128{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<float> Result0, Vector128<float> Result1) YShuffleG4X2_Const(Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{double}, Vector128{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<double> Result0, Vector128<double> Result1) YShuffleG4X2_Const(Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<sbyte> Result0, Vector128<sbyte> Result1) YShuffleG4X2_Const(Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{byte}, Vector128{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<byte> Result0, Vector128<byte> Result1) YShuffleG4X2_Const(Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{short}, Vector128{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<short> Result0, Vector128<short> Result1) YShuffleG4X2_Const(Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<ushort> Result0, Vector128<ushort> Result1) YShuffleG4X2_Const(Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{int}, Vector128{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<int> Result0, Vector128<int> Result1) YShuffleG4X2_Const(Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{uint}, Vector128{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<uint> Result0, Vector128<uint> Result1) YShuffleG4X2_Const(Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{long}, Vector128{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<long> Result0, Vector128<long> Result1) YShuffleG4X2_Const(Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual (Vector128<ulong> Result0, Vector128<ulong> Result1) YShuffleG4X2_Const(Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4X2_Const(source0, source1, control);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
                return Statics.YShuffleInsert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> YShuffleInsert(Vector128<float> back, Vector128<float> vector, Vector128<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> YShuffleInsert(Vector128<double> back, Vector128<double> vector, Vector128<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YShuffleInsert(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YShuffleInsert(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YShuffleInsert(Vector128<short> back, Vector128<short> vector, Vector128<short> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YShuffleInsert(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YShuffleInsert(Vector128<int> back, Vector128<int> vector, Vector128<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YShuffleInsert(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> YShuffleInsert(Vector128<long> back, Vector128<long> vector, Vector128<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> YShuffleInsert(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> YShuffleInsert_Core(Vector128<float> back, Vector128<float> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> YShuffleInsert_Core(Vector128<double> back, Vector128<double> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YShuffleInsert_Core(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YShuffleInsert_Core(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YShuffleInsert_Core(Vector128<short> back, Vector128<short> vector, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YShuffleInsert_Core(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YShuffleInsert_Core(Vector128<int> back, Vector128<int> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YShuffleInsert_Core(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> YShuffleInsert_Core(Vector128<long> back, Vector128<long> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> YShuffleInsert_Core(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
                return Statics.YShuffleKernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> YShuffleKernel(Vector128<float> vector, Vector128<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> YShuffleKernel(Vector128<double> vector, Vector128<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YShuffleKernel(Vector128<int> vector, Vector128<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YShuffleKernel(Vector128<uint> vector, Vector128<uint> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> YShuffleKernel(Vector128<long> vector, Vector128<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> YShuffleKernel(Vector128<ulong> vector, Vector128<ulong> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<float> YShuffleKernel_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<double> YShuffleKernel_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<sbyte> YShuffleKernel_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<byte> YShuffleKernel_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<short> YShuffleKernel_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ushort> YShuffleKernel_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<int> YShuffleKernel_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<uint> YShuffleKernel_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<long> YShuffleKernel_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector128<ulong> YShuffleKernel_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
