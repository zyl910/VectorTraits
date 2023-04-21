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
    using Statics = WVectorTraits128AdvSimdB64.Statics;

    /// <summary>
    /// <see cref="Vector128{T}"/> traits - AdvSimd 64bit abstract.
    /// </summary>
    public abstract class WVectorTraits128AdvSimdB64Abstract : WVectorTraits128AdvSimdAbstract {
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

#if NET5_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.Abs_AcceleratedTypes"/>
        public override TypeCodeFlags Abs_AcceleratedTypes {
            get {
                return Statics.Abs_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Abs(Vector128<double> value) {
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

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Add(Vector128<double> left, Vector128<double> right) {
            return Statics.Add(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Ceiling_AcceleratedTypes"/>
        public override TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
                return Statics.Ceiling_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Ceiling(Vector128<double> value) {
            return Statics.Ceiling(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToDouble_AcceleratedTypes {
            get {
                return Statics.ConvertToDouble_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> ConvertToDouble(Vector128<long> value) {
            return Statics.ConvertToDouble(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> ConvertToDouble(Vector128<ulong> value) {
            return Statics.ConvertToDouble(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToInt64_AcceleratedTypes {
            get {
                return Statics.ConvertToInt64_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> ConvertToInt64(Vector128<double> value) {
            return Statics.ConvertToInt64(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
            get {
                return Statics.ConvertToUInt64_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64(Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> ConvertToUInt64(Vector128<double> value) {
            return Statics.ConvertToUInt64(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.Divide_AcceleratedTypes"/>
        public override TypeCodeFlags Divide_AcceleratedTypes {
            get {
                return Statics.Divide_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Divide(Vector128<float> left, Vector128<float> right) {
            return Statics.Divide(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Divide(Vector128<double> left, Vector128<double> right) {
            return Statics.Divide(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits_AcceleratedTypes"/>
        public override TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
            get {
                return Statics.ExtractMostSignificantBits_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector128<float> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector128<double> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector128<sbyte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector128<byte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector128<short> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector128<ushort> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector128<int> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector128<uint> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector128<long> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector128<ulong> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }


        /// <inheritdoc cref="IWVectorTraits128.Floor_AcceleratedTypes"/>
        public override TypeCodeFlags Floor_AcceleratedTypes {
            get {
                return Statics.Floor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Floor(Vector128<double> value) {
            return Statics.Floor(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.GreaterThan_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThan_AcceleratedTypes {
            get {
                return Statics.GreaterThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
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


        /// <inheritdoc cref="IWVectorTraits128.LessThan_AcceleratedTypes"/>
        public override TypeCodeFlags LessThan_AcceleratedTypes {
            get {
                return Statics.LessThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
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


        /// <inheritdoc cref="IWVectorTraits128.Max_AcceleratedTypes"/>
        public override TypeCodeFlags Max_AcceleratedTypes {
            get {
                return Statics.Max_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
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

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
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

        /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Multiply(Vector128<double> left, Vector128<double> right) {
            return Statics.Multiply(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Narrow_AcceleratedTypes"/>
        public override TypeCodeFlags Narrow_AcceleratedTypes {
            get {
                return Statics.Narrow_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{double}, Vector128{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Narrow(Vector128<double> lower, Vector128<double> upper) {
            return Statics.Narrow(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
        public override TypeCodeFlags Shuffle_AcceleratedTypes {
            get {
                return Statics.Shuffle_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Shuffle(Vector128<float> vector, Vector128<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Shuffle(Vector128<double> vector, Vector128<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> Shuffle(Vector128<sbyte> vector, Vector128<sbyte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> Shuffle(Vector128<byte> vector, Vector128<byte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> Shuffle(Vector128<short> vector, Vector128<short> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> Shuffle(Vector128<ushort> vector, Vector128<ushort> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> Shuffle(Vector128<int> vector, Vector128<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> Shuffle(Vector128<uint> vector, Vector128<uint> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Shuffle(Vector128<long> vector, Vector128<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> Shuffle(Vector128<ulong> vector, Vector128<ulong> indices) {
            return Statics.Shuffle(vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Shuffle_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Shuffle_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> Shuffle_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> Shuffle_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> Shuffle_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> Shuffle_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> Shuffle_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> Shuffle_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Shuffle_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> Shuffle_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }


        /// <inheritdoc cref="IWVectorTraits128.Subtract_AcceleratedTypes"/>
        public override TypeCodeFlags Subtract_AcceleratedTypes {
            get {
                return Statics.Subtract_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Subtract(Vector128<double> left, Vector128<double> right) {
            return Statics.Subtract(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Sum_AcceleratedTypes"/>
        public override TypeCodeFlags Sum_AcceleratedTypes {
            get {
                return Statics.Sum_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override float Sum(Vector128<float> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override double Sum(Vector128<double> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override sbyte Sum(Vector128<sbyte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override byte Sum(Vector128<byte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override short Sum(Vector128<short> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ushort Sum(Vector128<ushort> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int Sum(Vector128<int> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint Sum(Vector128<uint> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override long Sum(Vector128<long> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong Sum(Vector128<ulong> value) {
            return Statics.Sum(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.Widen_AcceleratedTypes"/>
        public override TypeCodeFlags Widen_AcceleratedTypes {
            get {
                return Statics.Widen_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{float}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector128<float> source, out Vector128<double> lower, out Vector128<double> upper) {
            Statics.Widen(source, out lower, out upper);
        }


        /// <inheritdoc cref="IWVectorTraits128.YClamp_AcceleratedTypes"/>
        public override TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return Statics.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{double}, Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YClamp(Vector128<long> value, Vector128<long> amin, Vector128<long> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YClamp(Vector128<ulong> value, Vector128<ulong> amin, Vector128<ulong> amax) {
            return Statics.YClamp(value, amin, amax);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleG2_AcceleratedTypes {
            get {
                return Statics.YShuffleG2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG2(Vector128<float> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleG2(Vector128<double> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG2(Vector128<sbyte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG2(Vector128<byte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG2(Vector128<short> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG2(Vector128<ushort> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG2(Vector128<int> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG2(Vector128<uint> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleG2(Vector128<long> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleG2(Vector128<ulong> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleG2_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleG2_Const(Vector128<double> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleG2_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleG2_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleG2_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleG2_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleG2_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleG2_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleG2_Const(Vector128<long> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleG2_Const(Vector128<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
                return Statics.YShuffleInsert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{float}, Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleInsert(Vector128<float> back, Vector128<float> vector, Vector128<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{double}, Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleInsert(Vector128<double> back, Vector128<double> vector, Vector128<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleInsert(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleInsert(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleInsert(Vector128<short> back, Vector128<short> vector, Vector128<short> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleInsert(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleInsert(Vector128<int> back, Vector128<int> vector, Vector128<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleInsert(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleInsert(Vector128<long> back, Vector128<long> vector, Vector128<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleInsert(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}))"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}))"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleInsert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleInsert_Core(Vector128<float> back, Vector128<float> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleInsert_Core(Vector128<double> back, Vector128<double> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleInsert_Core(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleInsert_Core(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleInsert_Core(Vector128<short> back, Vector128<short> vector, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleInsert_Core(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleInsert_Core(Vector128<int> back, Vector128<int> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleInsert_Core(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleInsert_Core(Vector128<long> back, Vector128<long> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleInsert_Core(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
        public override TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
                return Statics.YShuffleKernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{float}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleKernel(Vector128<float> vector, Vector128<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{double}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleKernel(Vector128<double> vector, Vector128<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleKernel(Vector128<int> vector, Vector128<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleKernel(Vector128<uint> vector, Vector128<uint> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleKernel(Vector128<long> vector, Vector128<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleKernel(Vector128<ulong> vector, Vector128<ulong> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void YShuffleKernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> YShuffleKernel_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YShuffleKernel_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> YShuffleKernel_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> YShuffleKernel_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<short> YShuffleKernel_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ushort> YShuffleKernel_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> YShuffleKernel_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> YShuffleKernel_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YShuffleKernel_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YShuffleKernel_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }


#endif // NET5_0_OR_GREATER
    }
}

