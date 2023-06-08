using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Impl.AVector {
    using Statics = VectorTraits128Base.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - abstract.
    /// </summary>
    public abstract class VectorTraits128Abstract : VectorTraitsAbstract {

        /// <summary>
        /// Get best instance.
        /// </summary>
        /// <returns>Returns best instance.</returns>
        [CLSCompliant(false)]
        public new static IVectorTraits GetBestInstance() {
            if (VectorTraits128AdvSimdB64.Instance.IsSupported) return VectorTraits128AdvSimdB64.Instance;
            if (VectorTraits128AdvSimd.Instance.IsSupported) return VectorTraits128AdvSimd.Instance;
            return VectorTraits128Base.Instance;
        }

        /// <summary>ByteCount value</summary>
        public const int ByteCountValue = 16;

        /// <summary>
        /// <see cref="GetUnsupportedMessage"/> - Fill by <see cref="Vector{T}.Count"/> .
        /// </summary>
        /// <param name="rt">The in/out string.</param>
        public static void GetUnsupportedMessage_VectorCount(ref string rt) {
            if (Vector<byte>.Count != ByteCountValue) {
                rt += string.Format(" Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, ByteCountValue);
            }
        }

        /// <inheritdoc cref="IBaseTraits.ByteCount"/>
        public override int ByteCount {
            get {
                return Statics.ByteCount;
            }
        }

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


        /// <inheritdoc cref="IVectorTraits.Ceiling_AcceleratedTypes"/>
        public override TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
                return Statics.Ceiling_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Ceiling(Vector<float> value) {
            return Statics.Ceiling(value);
        }

        /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Ceiling(Vector<double> value) {
            return Statics.Ceiling(value);
        }


        /// <inheritdoc cref="IVectorTraits.Floor_AcceleratedTypes"/>
        public override TypeCodeFlags Floor_AcceleratedTypes {
            get {
                return Statics.Floor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Floor(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Floor(Vector<float> value) {
            return Statics.Floor(value);
        }

        /// <inheritdoc cref="IVectorTraits.Floor(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<double> Floor(Vector<double> value) {
            return Statics.Floor(value);
        }


        /// <inheritdoc cref="IVectorTraits.Narrow_AcceleratedTypes"/>
        public override TypeCodeFlags Narrow_AcceleratedTypes {
            get {
                return Statics.Narrow_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{double}, Vector{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<float> Narrow(Vector<double> lower, Vector<double> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{short}, Vector{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> Narrow(Vector<short> lower, Vector<short> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ushort}, Vector{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> Narrow(Vector<ushort> lower, Vector<ushort> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{int}, Vector{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> Narrow(Vector<int> lower, Vector<int> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{uint}, Vector{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> Narrow(Vector<uint> lower, Vector<uint> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{long}, Vector{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> Narrow(Vector<long> lower, Vector<long> upper) {
            return Statics.Narrow(lower, upper);
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ulong}, Vector{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> Narrow(Vector<ulong> lower, Vector<ulong> upper) {
            return Statics.Narrow(lower, upper);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
                return Statics.ShiftLeft_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftLeft(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeft(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeft(Vector<short> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftLeft(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeft(Vector<int> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftLeft(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftLeft(Vector<long> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftLeft(value, shiftAmount);
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

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{short}, int, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeft_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
            return Statics.ShiftLeft_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{ushort}, int, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftLeft_Args(Vector<ushort> dummy, int shiftAmount, out Vector<ushort> args1) {
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

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeft_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1) {
            return Statics.ShiftLeft_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftLeft_Core(Vector<ushort> value, int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
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

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftLeft_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeft_Const(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeft_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftLeft_Const(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeft_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftLeft_Const(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftLeft_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftLeft_Const(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftLeft_Const(value, shiftAmount);
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

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeft_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1) {
            return Statics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftLeft_ConstCore(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
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

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftLeft_Fast(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftLeft_Fast(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftLeft_Fast(Vector<short> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftLeft_Fast(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftLeft_Fast(Vector<int> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftLeft_Fast(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftLeft_Fast(Vector<long> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftLeft_Fast(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftLeft_Fast(value, shiftAmount);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
                return Statics.ShiftRightArithmetic_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightArithmetic(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmetic_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
            return Statics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{short}, int, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightArithmetic_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
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

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightArithmetic_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1) {
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

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmetic_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftRightArithmetic_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightArithmetic_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftRightArithmetic_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightArithmetic_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftRightArithmetic_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightArithmetic_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftRightArithmetic_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmetic_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
            return Statics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightArithmetic_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1) {
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

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightArithmetic_Fast(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightArithmetic_Fast(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightArithmetic_Fast(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightArithmetic_Fast(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightArithmetic_Fast(value, shiftAmount);
        }


        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        public override TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
                return Statics.ShiftRightLogical_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightLogical(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftRightLogical(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightLogical(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftRightLogical(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightLogical(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftRightLogical(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightLogical(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftRightLogical(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogical(value, shiftAmount);
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

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{short}, int, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightLogical_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
            return Statics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{ushort}, int, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftRightLogical_Args(Vector<ushort> dummy, int shiftAmount, out Vector<ushort> args1) {
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

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightLogical_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1) {
            return Statics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftRightLogical_Core(Vector<ushort> value, int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
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

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightLogical_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftRightLogical_Const(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightLogical_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftRightLogical_Const(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightLogical_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftRightLogical_Const(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightLogical_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftRightLogical_Const(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
            return Statics.ShiftRightLogical_Const(value, shiftAmount);
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

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightLogical_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1) {
            return Statics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftRightLogical_ConstCore(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
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

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<sbyte> ShiftRightLogical_Fast(Vector<sbyte> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<byte> ShiftRightLogical_Fast(Vector<byte> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<short> ShiftRightLogical_Fast(Vector<short> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ushort> ShiftRightLogical_Fast(Vector<ushort> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<int> ShiftRightLogical_Fast(Vector<int> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<uint> ShiftRightLogical_Fast(Vector<uint> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<long> ShiftRightLogical_Fast(Vector<long> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<ulong> ShiftRightLogical_Fast(Vector<ulong> value, int shiftAmount) {
            return Statics.ShiftRightLogical_Fast(value, shiftAmount);
        }


        /// <inheritdoc cref="IVectorTraits.Widen_AcceleratedTypes"/>
        public override TypeCodeFlags Widen_AcceleratedTypes {
            get {
                return Statics.Widen_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<float> source, out Vector<double> lower, out Vector<double> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<short> source, out Vector<int> lower, out Vector<int> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
            Statics.Widen(source, out lower, out upper);
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper) {
            Statics.Widen(source, out lower, out upper);
        }

    }
}
