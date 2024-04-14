using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.AVector128;

namespace Zyl.VectorTraits.Impl.AVector {
    using WStatics = WVectorTraits128Avx2.Statics;
    using BaseStatics = VectorTraitsBase.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - Avx2 .
    /// </summary>
    public sealed partial class VectorTraits128Avx2 : VectorTraits128Avx2Abstract {
        private static readonly VectorTraits128Avx2 _instance = new VectorTraits128Avx2(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraits128Avx2 Instance {
            get { return _instance; }
        }

#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector128{T}"/> traits.Statics - Avx2.
        /// </summary>
        public static partial class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsHardwareAccelerated"/>
            public static bool IsHardwareAccelerated {
                get {
                    return WStatics.IsHardwareAccelerated;
                }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
                    return GetIsSupported();
                }
            }

            /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
            public static bool GetIsSupported(bool noStrict = false) {
                bool rt = (Vector<byte>.Count == ByteCountValue) && WStatics.GetIsSupported(noStrict);
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = WStatics.GetUnsupportedMessage(noStrict);
                VectorTraits128Abstract.GetUnsupportedMessage_VectorCount(ref rt);
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

            /// <inheritdoc cref="IBaseTraits.UsedInstructionSets"/>
            public static string UsedInstructionSets {
                get {
                    return WStatics.UsedInstructionSets;
                }
            }

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IVectorTraits.ConvertToDouble_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
                get {
                    return WStatics.ConvertToDouble_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> ConvertToDouble(Vector<long> value) {
                return WStatics.ConvertToDouble(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> ConvertToDouble(Vector<ulong> value) {
                return WStatics.ConvertToDouble(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    return WStatics.ConvertToInt64_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToInt64(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ConvertToInt64(Vector<double> value) {
                return WStatics.ConvertToInt64(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ConvertToUInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
                get {
                    return WStatics.ConvertToUInt32_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToUInt32(Vector{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ConvertToUInt32(Vector<float> value) {
                return WStatics.ConvertToUInt32(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ConvertToUInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
                get {
                    return WStatics.ConvertToUInt64_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToUInt64(Vector{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ConvertToUInt64(Vector<double> value) {
                return WStatics.ConvertToUInt64(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
                var args0 = WStatics.ShiftLeft_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{byte}, int, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Args(Vector<byte> dummy, int shiftAmount, out Vector<byte> args1) {
                var args0 = WStatics.ShiftLeft_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{int}, int, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1) {
                var args0 = WStatics.ShiftLeft_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{uint}, int, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Args(Vector<uint> dummy, int shiftAmount, out Vector<uint> args1) {
                var args0 = WStatics.ShiftLeft_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{long}, int, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1) {
                var args0 = WStatics.ShiftLeft_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{ulong}, int, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Args(Vector<ulong> dummy, int shiftAmount, out Vector<ulong> args1) {
                var args0 = WStatics.ShiftLeft_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
                return WStatics.ShiftLeft_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Core(Vector<byte> value, int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
                return WStatics.ShiftLeft_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1) {
                return WStatics.ShiftLeft_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Core(Vector<uint> value, int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
                return WStatics.ShiftLeft_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1) {
                return WStatics.ShiftLeft_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Core(Vector<ulong> value, int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
                return WStatics.ShiftLeft_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
                return WStatics.ShiftLeft_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_ConstCore(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
                return WStatics.ShiftLeft_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{int}, int, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1) {
                return WStatics.ShiftLeft_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_ConstCore(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
                return WStatics.ShiftLeft_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{long}, int, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1) {
                return WStatics.ShiftLeft_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_ConstCore(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
                return WStatics.ShiftLeft_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
                var args0 = WStatics.ShiftRightArithmetic_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{int}, int, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1) {
                var args0 = WStatics.ShiftRightArithmetic_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{long}, int, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1) {
                var args0 = WStatics.ShiftRightArithmetic_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
                return WStatics.ShiftRightArithmetic_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1) {
                return WStatics.ShiftRightArithmetic_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1) {
                return WStatics.ShiftRightArithmetic_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
                return WStatics.ShiftRightArithmetic_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{int}, int, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1) {
                return WStatics.ShiftRightArithmetic_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{long}, int, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1) {
                return WStatics.ShiftRightArithmetic_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
                var args0 = WStatics.ShiftRightLogical_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{byte}, int, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Args(Vector<byte> dummy, int shiftAmount, out Vector<byte> args1) {
                var args0 = WStatics.ShiftRightLogical_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{int}, int, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1) {
                var args0 = WStatics.ShiftRightLogical_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{uint}, int, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Args(Vector<uint> dummy, int shiftAmount, out Vector<uint> args1) {
                var args0 = WStatics.ShiftRightLogical_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{long}, int, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1) {
                var args0 = WStatics.ShiftRightLogical_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{ulong}, int, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_Args(Vector<ulong> dummy, int shiftAmount, out Vector<ulong> args1) {
                var args0 = WStatics.ShiftRightLogical_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
                return WStatics.ShiftRightLogical_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Core(Vector<byte> value, int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
                return WStatics.ShiftRightLogical_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1) {
                return WStatics.ShiftRightLogical_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Core(Vector<uint> value, int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
                return WStatics.ShiftRightLogical_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1) {
                return WStatics.ShiftRightLogical_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_Core(Vector<ulong> value, int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
                return WStatics.ShiftRightLogical_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
                return WStatics.ShiftRightLogical_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_ConstCore(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
                return WStatics.ShiftRightLogical_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{int}, int, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1) {
                return WStatics.ShiftRightLogical_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_ConstCore(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
                return WStatics.ShiftRightLogical_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{long}, int, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1) {
                return WStatics.ShiftRightLogical_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_ConstCore(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
                return WStatics.ShiftRightLogical_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
