using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Impl.AVector {
    using Statics = VectorTraits128Avx2.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - Avx2 abstract.
    /// </summary>
    public abstract partial class VectorTraits128Avx2Abstract : VectorTraits128SseAbstract {
        
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

        /// <inheritdoc cref="IVectorTraits.ConvertToDouble_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToDouble_AcceleratedTypes {
            get {
                return Statics.ConvertToDouble_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> ConvertToDouble(Vector<long> value) {
            return Statics.ConvertToDouble(value);
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> ConvertToDouble(Vector<ulong> value) {
            return Statics.ConvertToDouble(value);
        }


        /// <inheritdoc cref="IVectorTraits.ConvertToInt64_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToInt64_AcceleratedTypes {
            get {
                return Statics.ConvertToInt64_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToInt64(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ConvertToInt64(Vector<double> value) {
            return Statics.ConvertToInt64(value);
        }


        /// <inheritdoc cref="IVectorTraits.ConvertToUInt32_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
            get {
                return Statics.ConvertToUInt32_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToUInt32(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ConvertToUInt32(Vector<float> value) {
            return Statics.ConvertToUInt32(value);
        }


        /// <inheritdoc cref="IVectorTraits.ConvertToUInt64_AcceleratedTypes"/>
        public override TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
            get {
                return Statics.ConvertToUInt64_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToUInt64(Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ConvertToUInt64(Vector<double> value) {
            return Statics.ConvertToUInt64(value);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftLeft_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{byte}, int, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeft_Args(Vector<byte> dummy, int shiftAmount, out Vector<byte> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{int}, int, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeft_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{uint}, int, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftLeft_Args(Vector<uint> dummy, int shiftAmount, out Vector<uint> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{long}, int, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftLeft_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{ulong}, int, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftLeft_Args(Vector<ulong> dummy, int shiftAmount, out Vector<ulong> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftLeft_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeft_Core(Vector<byte> value, int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeft_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftLeft_Core(Vector<uint> value, int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftLeft_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftLeft_Core(Vector<ulong> value, int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftLeft_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeft_ConstCore(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeft_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftLeft_ConstCore(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftLeft_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftLeft_ConstCore(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmetic_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{int}, int, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightArithmetic_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{long}, int, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightArithmetic_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmetic_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightArithmetic_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightArithmetic_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1) {
            return Statics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmetic_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightArithmetic_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightArithmetic_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightLogical_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{byte}, int, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftRightLogical_Args(Vector<byte> dummy, int shiftAmount, out Vector<byte> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{int}, int, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightLogical_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{uint}, int, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftRightLogical_Args(Vector<uint> dummy, int shiftAmount, out Vector<uint> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{long}, int, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightLogical_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{ulong}, int, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftRightLogical_Args(Vector<ulong> dummy, int shiftAmount, out Vector<ulong> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightLogical_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftRightLogical_Core(Vector<byte> value, int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightLogical_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftRightLogical_Core(Vector<uint> value, int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightLogical_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftRightLogical_Core(Vector<ulong> value, int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightLogical_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftRightLogical_ConstCore(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightLogical_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftRightLogical_ConstCore(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightLogical_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftRightLogical_ConstCore(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
