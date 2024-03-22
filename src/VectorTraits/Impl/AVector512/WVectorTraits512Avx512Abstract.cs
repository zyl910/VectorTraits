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

    /// <summary>
    /// <see cref="Vector512{T}"/> traits - Avx512 abstract.
    /// </summary>
    public abstract partial class WVectorTraits512Avx512Abstract : WVectorTraits512Abstract {
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

        /// <inheritdoc cref="IBaseTraits.UsedInstructionSets"/>
        public override string UsedInstructionSets {
            get {
                return Statics.UsedInstructionSets;
            }
        }

#if NET8_0_OR_GREATER
/*
        /// <inheritdoc cref="IWVectorTraits512.Ceiling_AcceleratedTypes"/>
        public override TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
                return Statics.Ceiling_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Ceiling(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Ceiling(Vector512<float> value) {
            return Statics.Ceiling(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Ceiling(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Ceiling(Vector512<double> value) {
            return Statics.Ceiling(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToDouble_AcceleratedTypes {
            get {
                return Statics.ConvertToDouble_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> ConvertToDouble(Vector512<long> value) {
            return Statics.ConvertToDouble(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> ConvertToDouble(Vector512<ulong> value) {
            return Statics.ConvertToDouble(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_Range52(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> ConvertToDouble_Range52(Vector512<long> value) {
            return Statics.ConvertToDouble_Range52(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_Range52(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> ConvertToDouble_Range52(Vector512<ulong> value) {
            return Statics.ConvertToDouble_Range52(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.ConvertToInt32_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToInt32_AcceleratedTypes {
            get {
                return Statics.ConvertToInt32_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToInt32(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ConvertToInt32(Vector512<float> value) {
            return Statics.ConvertToInt32(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToInt64_AcceleratedTypes {
            get {
                return Statics.ConvertToInt64_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ConvertToInt64(Vector512<double> value) {
            return Statics.ConvertToInt64(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ConvertToInt64_Range52(Vector512<double> value) {
            return Statics.ConvertToInt64_Range52(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52RoundToEven(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ConvertToInt64_Range52RoundToEven(Vector512<double> value) {
            return Statics.ConvertToInt64_Range52RoundToEven(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToSingle_AcceleratedTypes {
            get {
                return Statics.ConvertToSingle_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> ConvertToSingle(Vector512<int> value) {
            return Statics.ConvertToSingle(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> ConvertToSingle(Vector512<uint> value) {
            return Statics.ConvertToSingle(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
            get {
                return Statics.ConvertToUInt32_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32(Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ConvertToUInt32(Vector512<float> value) {
            return Statics.ConvertToUInt32(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
            get {
                return Statics.ConvertToUInt64_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64(Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ConvertToUInt64(Vector512<double> value) {
            return Statics.ConvertToUInt64(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_Range52(Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ConvertToUInt64_Range52(Vector512<double> value) {
            return Statics.ConvertToUInt64_Range52(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_Range52RoundToEven(Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ConvertToUInt64_Range52RoundToEven(Vector512<double> value) {
            return Statics.ConvertToUInt64_Range52RoundToEven(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits_AcceleratedTypes"/>
        public override TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
            get {
                return Statics.ExtractMostSignificantBits_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector512<float> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector512<double> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector512<sbyte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector512<byte> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector512<short> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector512<ushort> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector512<int> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector512<uint> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector512<long> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint ExtractMostSignificantBits(Vector512<ulong> vector) {
            return Statics.ExtractMostSignificantBits(vector);
        }


        /// <inheritdoc cref="IWVectorTraits512.Floor_AcceleratedTypes"/>
        public override TypeCodeFlags Floor_AcceleratedTypes {
            get {
                return Statics.Floor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Floor(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Floor(Vector512<float> value) {
            return Statics.Floor(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Floor(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Floor(Vector512<double> value) {
            return Statics.Floor(value);
        }


        /// <inheritdoc cref="IWVectorTraits512.Narrow_AcceleratedTypes"/>
        public override TypeCodeFlags Narrow_AcceleratedTypes {
            get {
                return Statics.Narrow_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{double}, Vector512{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Narrow(Vector512<double> lower, Vector512<double> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{short}, Vector512{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> Narrow(Vector512<short> lower, Vector512<short> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{ushort}, Vector512{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> Narrow(Vector512<ushort> lower, Vector512<ushort> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{int}, Vector512{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> Narrow(Vector512<int> lower, Vector512<int> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{uint}, Vector512{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> Narrow(Vector512<uint> lower, Vector512<uint> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{long}, Vector512{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> Narrow(Vector512<long> lower, Vector512<long> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{ulong}, Vector512{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> Narrow(Vector512<ulong> lower, Vector512<ulong> upper) {
            return Statics.Narrow(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
                return Statics.ShiftLeft_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftLeft(Vector512<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> ShiftLeft(Vector512<byte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftLeft(Vector512<short> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> ShiftLeft(Vector512<ushort> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftLeft(Vector512<int> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ShiftLeft(Vector512<uint> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftLeft(Vector512<long> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ShiftLeft(Vector512<ulong> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftLeft_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{byte}, int, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> ShiftLeft_Args(Vector512<byte> dummy, int shiftAmount, out Vector512<byte> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{short}, int, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftLeft_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> ShiftLeft_Args(Vector512<ushort> dummy, int shiftAmount, out Vector512<ushort> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{int}, int, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftLeft_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{uint}, int, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ShiftLeft_Args(Vector512<uint> dummy, int shiftAmount, out Vector512<uint> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{long}, int, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftLeft_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{ulong}, int, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ShiftLeft_Args(Vector512<ulong> dummy, int shiftAmount, out Vector512<ulong> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftLeft_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> ShiftLeft_Core(Vector512<byte> value, int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftLeft_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> ShiftLeft_Core(Vector512<ushort> value, int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftLeft_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ShiftLeft_Core(Vector512<uint> value, int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftLeft_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ShiftLeft_Core(Vector512<ulong> value, int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftLeft_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> ShiftLeft_Const(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftLeft_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> ShiftLeft_Const(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftLeft_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ShiftLeft_Const(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftLeft_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ShiftLeft_Const(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftLeft_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> ShiftLeft_ConstCore(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftLeft_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> ShiftLeft_ConstCore(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftLeft_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ShiftLeft_ConstCore(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftLeft_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ShiftLeft_ConstCore(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftLeft_Fast(Vector512<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> ShiftLeft_Fast(Vector512<byte> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftLeft_Fast(Vector512<short> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> ShiftLeft_Fast(Vector512<ushort> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftLeft_Fast(Vector512<int> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ShiftLeft_Fast(Vector512<uint> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftLeft_Fast(Vector512<long> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ShiftLeft_Fast(Vector512<ulong> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
                return Statics.ShiftRightArithmetic_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftRightArithmetic(Vector512<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftRightArithmetic(Vector512<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftRightArithmetic(Vector512<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftRightArithmetic(Vector512<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftRightArithmetic_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{short}, int, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftRightArithmetic_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{int}, int, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftRightArithmetic_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{long}, int, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftRightArithmetic_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftRightArithmetic_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftRightArithmetic_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftRightArithmetic_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftRightArithmetic_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftRightArithmetic_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftRightArithmetic_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftRightArithmetic_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftRightArithmetic_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftRightArithmetic_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftRightArithmetic_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftRightArithmetic_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftRightArithmetic_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftRightArithmetic_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftRightArithmetic_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }


        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftRightArithmetic_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftRightArithmetic_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftRightArithmetic_Fast(Vector512<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftRightArithmetic_Fast(Vector512<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftRightArithmetic_Fast(Vector512<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftRightArithmetic_Fast(Vector512<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
                return Statics.ShiftRightLogical_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftRightLogical(Vector512<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> ShiftRightLogical(Vector512<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftRightLogical(Vector512<short> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> ShiftRightLogical(Vector512<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftRightLogical(Vector512<int> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ShiftRightLogical(Vector512<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftRightLogical(Vector512<long> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ShiftRightLogical(Vector512<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftRightLogical_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{byte}, int, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> ShiftRightLogical_Args(Vector512<byte> dummy, int shiftAmount, out Vector512<byte> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{short}, int, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftRightLogical_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> ShiftRightLogical_Args(Vector512<ushort> dummy, int shiftAmount, out Vector512<ushort> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{int}, int, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftRightLogical_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{uint}, int, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ShiftRightLogical_Args(Vector512<uint> dummy, int shiftAmount, out Vector512<uint> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{long}, int, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftRightLogical_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{ulong}, int, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ShiftRightLogical_Args(Vector512<ulong> dummy, int shiftAmount, out Vector512<ulong> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftRightLogical_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> ShiftRightLogical_Core(Vector512<byte> value, int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftRightLogical_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> ShiftRightLogical_Core(Vector512<ushort> value, int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftRightLogical_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ShiftRightLogical_Core(Vector512<uint> value, int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftRightLogical_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ShiftRightLogical_Core(Vector512<ulong> value, int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftRightLogical_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> ShiftRightLogical_Const(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftRightLogical_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> ShiftRightLogical_Const(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftRightLogical_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ShiftRightLogical_Const(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftRightLogical_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ShiftRightLogical_Const(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftRightLogical_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> ShiftRightLogical_ConstCore(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftRightLogical_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> ShiftRightLogical_ConstCore(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftRightLogical_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ShiftRightLogical_ConstCore(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftRightLogical_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ShiftRightLogical_ConstCore(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> ShiftRightLogical_Fast(Vector512<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> ShiftRightLogical_Fast(Vector512<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> ShiftRightLogical_Fast(Vector512<short> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> ShiftRightLogical_Fast(Vector512<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> ShiftRightLogical_Fast(Vector512<int> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> ShiftRightLogical_Fast(Vector512<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> ShiftRightLogical_Fast(Vector512<long> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> ShiftRightLogical_Fast(Vector512<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }


        /// <inheritdoc cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        public override TypeCodeFlags Shuffle_AcceleratedTypes {
            get {
                return Statics.Shuffle_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Shuffle(Vector512<float> vector, Vector512<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Shuffle(Vector512<double> vector, Vector512<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> Shuffle(Vector512<sbyte> vector, Vector512<sbyte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> Shuffle(Vector512<byte> vector, Vector512<byte> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> Shuffle(Vector512<short> vector, Vector512<short> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> Shuffle(Vector512<ushort> vector, Vector512<ushort> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> Shuffle(Vector512<int> vector, Vector512<int> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> Shuffle(Vector512<uint> vector, Vector512<uint> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> Shuffle(Vector512<long> vector, Vector512<long> indices) {
            return Statics.Shuffle(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> Shuffle(Vector512<ulong> vector, Vector512<ulong> indices) {
            return Statics.Shuffle(vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Shuffle_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1) {
            Statics.Shuffle_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{float}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<float> Shuffle_Core(Vector512<float> vector, Vector512<int> args0, Vector512<int> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{double}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<double> Shuffle_Core(Vector512<double> vector, Vector512<long> args0, Vector512<long> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<sbyte> Shuffle_Core(Vector512<sbyte> vector, Vector512<sbyte> args0, Vector512<sbyte> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<byte> Shuffle_Core(Vector512<byte> vector, Vector512<byte> args0, Vector512<byte> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<short> Shuffle_Core(Vector512<short> vector, Vector512<short> args0, Vector512<short> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ushort> Shuffle_Core(Vector512<ushort> vector, Vector512<ushort> args0, Vector512<ushort> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<int> Shuffle_Core(Vector512<int> vector, Vector512<int> args0, Vector512<int> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<uint> Shuffle_Core(Vector512<uint> vector, Vector512<uint> args0, Vector512<uint> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<long> Shuffle_Core(Vector512<long> vector, Vector512<long> args0, Vector512<long> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector512<ulong> Shuffle_Core(Vector512<ulong> vector, Vector512<ulong> args0, Vector512<ulong> args1) {
            return Statics.Shuffle_Core(vector, args0, args1);
        }
*/

        /// <inheritdoc cref="IWVectorTraits512.Sum_AcceleratedTypes"/>
        public override TypeCodeFlags Sum_AcceleratedTypes {
            get {
                return Statics.Sum_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override float Sum(Vector512<float> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override double Sum(Vector512<double> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override sbyte Sum(Vector512<sbyte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override byte Sum(Vector512<byte> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override short Sum(Vector512<short> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ushort Sum(Vector512<ushort> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int Sum(Vector512<int> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override uint Sum(Vector512<uint> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override long Sum(Vector512<long> value) {
            return Statics.Sum(value);
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override ulong Sum(Vector512<ulong> value) {
            return Statics.Sum(value);
        }

/*
        /// <inheritdoc cref="IWVectorTraits512.Widen_AcceleratedTypes"/>
        public override TypeCodeFlags Widen_AcceleratedTypes {
            get {
                return Statics.Widen_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{float}, out Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector512<float> source, out Vector512<double> lower, out Vector512<double> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{sbyte}, out Vector512{short}, out Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector512<sbyte> source, out Vector512<short> lower, out Vector512<short> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{byte}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector512<byte> source, out Vector512<ushort> lower, out Vector512<ushort> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{short}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector512<short> source, out Vector512<int> lower, out Vector512<int> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{ushort}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector512<ushort> source, out Vector512<uint> lower, out Vector512<uint> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{int}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector512<int> source, out Vector512<long> lower, out Vector512<long> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{uint}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector512<uint> source, out Vector512<ulong> lower, out Vector512<ulong> upper) {
            Statics.Widen(source, out lower, out upper);
        }
*/
#endif
    }
}
