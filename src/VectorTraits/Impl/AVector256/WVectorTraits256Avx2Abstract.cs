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

    /// <summary>
    /// <see cref="Vector256{T}"/> traits - Avx2 abstract.
    /// </summary>
    public abstract partial class WVectorTraits256Avx2Abstract : WVectorTraits256Abstract {
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

        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_Range52(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> ConvertToDouble_Range52(Vector256<long> value) {
            return Statics.ConvertToDouble_Range52(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_Range52(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> ConvertToDouble_Range52(Vector256<ulong> value) {
            return Statics.ConvertToDouble_Range52(value);
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

        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_Range52(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ConvertToInt64_Range52(Vector256<double> value) {
            return Statics.ConvertToInt64_Range52(value);
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


        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits_AcceleratedTypes"/>
        public override TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
            get {
                return Statics.ExtractMostSignificantBits_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector256<float> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector256<double> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector256<sbyte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector256<byte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector256<short> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector256<ushort> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector256<int> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector256<uint> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector256<long> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector256<ulong> vector) {
            return Statics.ExtractMostSignificantBits(vector);
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

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{sbyte}, int, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftLeft_Args(Vector256<sbyte> dummy, int shiftAmount, out Vector256<sbyte> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{byte}, int, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftLeft_Args(Vector256<byte> dummy, int shiftAmount, out Vector256<byte> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{short}, int, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftLeft_Args(Vector256<short> dummy, int shiftAmount, out Vector256<short> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{ushort}, int, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftLeft_Args(Vector256<ushort> dummy, int shiftAmount, out Vector256<ushort> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{int}, int, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftLeft_Args(Vector256<int> dummy, int shiftAmount, out Vector256<int> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{uint}, int, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftLeft_Args(Vector256<uint> dummy, int shiftAmount, out Vector256<uint> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{long}, int, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftLeft_Args(Vector256<long> dummy, int shiftAmount, out Vector256<long> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{ulong}, int, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftLeft_Args(Vector256<ulong> dummy, int shiftAmount, out Vector256<ulong> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftLeft_Core(Vector256<sbyte> value, int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftLeft_Core(Vector256<byte> value, int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftLeft_Core(Vector256<short> value, int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftLeft_Core(Vector256<ushort> value, int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftLeft_Core(Vector256<int> value, int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftLeft_Core(Vector256<uint> value, int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftLeft_Core(Vector256<long> value, int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftLeft_Core(Vector256<ulong> value, int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftLeft_Const(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftLeft_Const(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftLeft_Const(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftLeft_Const(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftLeft_Const(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftLeft_Const(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftLeft_Const(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftLeft_Const(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftLeft_ConstCore(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftLeft_ConstCore(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftLeft_ConstCore(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftLeft_ConstCore(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftLeft_ConstCore(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftLeft_ConstCore(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftLeft_ConstCore(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftLeft_ConstCore(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftLeft_Fast(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftLeft_Fast(Vector256<byte> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftLeft_Fast(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftLeft_Fast(Vector256<ushort> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftLeft_Fast(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftLeft_Fast(Vector256<uint> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftLeft_Fast(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftLeft_Fast(Vector256<ulong> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
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

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{sbyte}, int, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightArithmetic_Args(Vector256<sbyte> dummy, int shiftAmount, out Vector256<sbyte> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{short}, int, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightArithmetic_Args(Vector256<short> dummy, int shiftAmount, out Vector256<short> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{int}, int, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightArithmetic_Args(Vector256<int> dummy, int shiftAmount, out Vector256<int> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{long}, int, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightArithmetic_Args(Vector256<long> dummy, int shiftAmount, out Vector256<long> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightArithmetic_Core(Vector256<sbyte> value, int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightArithmetic_Core(Vector256<short> value, int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightArithmetic_Core(Vector256<int> value, int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightArithmetic_Core(Vector256<long> value, int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightArithmetic_Const(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftRightArithmetic_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightArithmetic_Const(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftRightArithmetic_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightArithmetic_Const(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftRightArithmetic_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightArithmetic_Const(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftRightArithmetic_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightArithmetic_ConstCore(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightArithmetic_ConstCore(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightArithmetic_ConstCore(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightArithmetic_ConstCore(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightArithmetic_Fast(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightArithmetic_Fast(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightArithmetic_Fast(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightArithmetic_Fast(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
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

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{sbyte}, int, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightLogical_Args(Vector256<sbyte> dummy, int shiftAmount, out Vector256<sbyte> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{byte}, int, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftRightLogical_Args(Vector256<byte> dummy, int shiftAmount, out Vector256<byte> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{short}, int, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightLogical_Args(Vector256<short> dummy, int shiftAmount, out Vector256<short> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{ushort}, int, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftRightLogical_Args(Vector256<ushort> dummy, int shiftAmount, out Vector256<ushort> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{int}, int, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightLogical_Args(Vector256<int> dummy, int shiftAmount, out Vector256<int> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{uint}, int, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftRightLogical_Args(Vector256<uint> dummy, int shiftAmount, out Vector256<uint> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{long}, int, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightLogical_Args(Vector256<long> dummy, int shiftAmount, out Vector256<long> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{ulong}, int, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftRightLogical_Args(Vector256<ulong> dummy, int shiftAmount, out Vector256<ulong> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightLogical_Core(Vector256<sbyte> value, int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftRightLogical_Core(Vector256<byte> value, int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightLogical_Core(Vector256<short> value, int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftRightLogical_Core(Vector256<ushort> value, int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightLogical_Core(Vector256<int> value, int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftRightLogical_Core(Vector256<uint> value, int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightLogical_Core(Vector256<long> value, int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftRightLogical_Core(Vector256<ulong> value, int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightLogical_Const(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftRightLogical_Const(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightLogical_Const(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftRightLogical_Const(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightLogical_Const(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftRightLogical_Const(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightLogical_Const(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftRightLogical_Const(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightLogical_ConstCore(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftRightLogical_ConstCore(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightLogical_ConstCore(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftRightLogical_ConstCore(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightLogical_ConstCore(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftRightLogical_ConstCore(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightLogical_ConstCore(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftRightLogical_ConstCore(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> ShiftRightLogical_Fast(Vector256<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> ShiftRightLogical_Fast(Vector256<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> ShiftRightLogical_Fast(Vector256<short> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> ShiftRightLogical_Fast(Vector256<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> ShiftRightLogical_Fast(Vector256<int> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> ShiftRightLogical_Fast(Vector256<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> ShiftRightLogical_Fast(Vector256<long> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> ShiftRightLogical_Fast(Vector256<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        public override TypeCodeFlags Shuffle_AcceleratedTypes {
            get {
                return Statics.Shuffle_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Shuffle(Vector256<float> vector, Vector256<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Shuffle(Vector256<double> vector, Vector256<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> Shuffle(Vector256<sbyte> vector, Vector256<sbyte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> Shuffle(Vector256<byte> vector, Vector256<byte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> Shuffle(Vector256<short> vector, Vector256<short> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> Shuffle(Vector256<ushort> vector, Vector256<ushort> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> Shuffle(Vector256<int> vector, Vector256<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> Shuffle(Vector256<uint> vector, Vector256<uint> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> Shuffle(Vector256<long> vector, Vector256<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> Shuffle(Vector256<ulong> vector, Vector256<ulong> indices) {
            return Statics.Shuffle(vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<float> Shuffle_Core(Vector256<float> vector, Vector256<int> args0, Vector256<int> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<double> Shuffle_Core(Vector256<double> vector, Vector256<long> args0, Vector256<long> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<sbyte> Shuffle_Core(Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<byte> Shuffle_Core(Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<short> Shuffle_Core(Vector256<short> vector, Vector256<short> args0, Vector256<short> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ushort> Shuffle_Core(Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<int> Shuffle_Core(Vector256<int> vector, Vector256<int> args0, Vector256<int> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<uint> Shuffle_Core(Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<long> Shuffle_Core(Vector256<long> vector, Vector256<long> args0, Vector256<long> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector256<ulong> Shuffle_Core(Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
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

#endif
    }
}
