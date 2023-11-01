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
    using Statics = WVectorTraits128Avx2.Statics;

    /// <summary>
    /// <see cref="Vector128{T}"/> traits - Avx2 abstract.
    /// </summary>
    public abstract partial class WVectorTraits128Avx2Abstract : WVectorTraits128SseAbstract {
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

#if NETCOREAPP3_0_OR_GREATER

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


        /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
            get {
                return Statics.ConvertToUInt32_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> ConvertToUInt32(Vector128<float> value) {
            return Statics.ConvertToUInt32(value);
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


        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> ShiftLeft_Args(Vector128<sbyte> dummy, int shiftAmount, out Vector128<sbyte> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{byte}, int, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> ShiftLeft_Args(Vector128<byte> dummy, int shiftAmount, out Vector128<byte> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{int}, int, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> ShiftLeft_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{uint}, int, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> ShiftLeft_Args(Vector128<uint> dummy, int shiftAmount, out Vector128<uint> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{long}, int, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> ShiftLeft_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> ShiftLeft_Args(Vector128<ulong> dummy, int shiftAmount, out Vector128<ulong> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> ShiftLeft_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> ShiftLeft_Core(Vector128<byte> value, int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> ShiftLeft_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> ShiftLeft_Core(Vector128<uint> value, int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> ShiftLeft_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> ShiftLeft_Core(Vector128<ulong> value, int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> ShiftLeft_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> ShiftLeft_ConstCore(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> ShiftLeft_ConstCore(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> ShiftLeft_ConstCore(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> ShiftLeft_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> ShiftLeft_ConstCore(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }


        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> ShiftRightArithmetic_Args(Vector128<sbyte> dummy, int shiftAmount, out Vector128<sbyte> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{int}, int, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> ShiftRightArithmetic_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{long}, int, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> ShiftRightArithmetic_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> ShiftRightArithmetic_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> ShiftRightArithmetic_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> ShiftRightArithmetic_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> ShiftRightArithmetic_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> ShiftRightArithmetic_ConstCore(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> ShiftRightArithmetic_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }


        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> ShiftRightLogical_Args(Vector128<sbyte> dummy, int shiftAmount, out Vector128<sbyte> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{byte}, int, out Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> ShiftRightLogical_Args(Vector128<byte> dummy, int shiftAmount, out Vector128<byte> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{int}, int, out Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> ShiftRightLogical_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{uint}, int, out Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> ShiftRightLogical_Args(Vector128<uint> dummy, int shiftAmount, out Vector128<uint> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{long}, int, out Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> ShiftRightLogical_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> ShiftRightLogical_Args(Vector128<ulong> dummy, int shiftAmount, out Vector128<ulong> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> ShiftRightLogical_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> ShiftRightLogical_Core(Vector128<byte> value, int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> ShiftRightLogical_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> ShiftRightLogical_Core(Vector128<uint> value, int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> ShiftRightLogical_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> ShiftRightLogical_Core(Vector128<ulong> value, int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<sbyte> ShiftRightLogical_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<byte> ShiftRightLogical_ConstCore(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<int> ShiftRightLogical_ConstCore(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<uint> ShiftRightLogical_ConstCore(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> ShiftRightLogical_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> ShiftRightLogical_ConstCore(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }


#endif
    }
}
