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
    using WStatics = WVectorTraits128Sse.Statics;
    using BaseStatics = VectorTraitsBase.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - Sse .
    /// </summary>
    public sealed partial class VectorTraits128Sse : VectorTraits128SseAbstract {
        private static readonly VectorTraits128Sse _instance = new VectorTraits128Sse(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraits128Sse Instance {
            get { return _instance; }
        }

#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector128{T}"/> traits.Statics - Sse.
        /// </summary>
        public static partial class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
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

            /// <inheritdoc cref="IVectorTraits.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    return WStatics.Ceiling_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Ceiling(Vector<float> value) {
                return WStatics.Ceiling(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Ceiling(Vector<double> value) {
                return WStatics.Ceiling(value.AsVector128()).AsVector();
            }


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

            /// <inheritdoc cref="IVectorTraits.ConvertToDouble_Range52(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> ConvertToDouble_Range52(Vector<long> value) {
                return WStatics.ConvertToDouble_Range52(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToDouble_Range52(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> ConvertToDouble_Range52(Vector<ulong> value) {
                return WStatics.ConvertToDouble_Range52(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ConvertToInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt32_AcceleratedTypes {
                get {
                    return WStatics.ConvertToInt32_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToInt32(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ConvertToInt32(Vector<float> value) {
                return WStatics.ConvertToInt32(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.ConvertToInt64_Range52(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ConvertToInt64_Range52(Vector<double> value) {
                return WStatics.ConvertToInt64_Range52(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToInt64_Range52RoundToEven(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ConvertToInt64_Range52RoundToEven(Vector<double> value) {
                return WStatics.ConvertToInt64_Range52RoundToEven(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ConvertToSingle_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToSingle_AcceleratedTypes {
                get {
                    return WStatics.ConvertToSingle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToSingle(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> ConvertToSingle(Vector<int> value) {
                return WStatics.ConvertToSingle(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToSingle(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> ConvertToSingle(Vector<uint> value) {
                return WStatics.ConvertToSingle(value.AsVector128()).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.ConvertToUInt64_Range52(Vector{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ConvertToUInt64_Range52(Vector<double> value) {
                return WStatics.ConvertToUInt64_Range52(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ConvertToUInt64_Range52RoundToEven(Vector{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ConvertToUInt64_Range52RoundToEven(Vector<double> value) {
                return WStatics.ConvertToUInt64_Range52RoundToEven(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits_AcceleratedTypes"/>
            public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
                get {
                    return WStatics.ExtractMostSignificantBits_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<float> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<double> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<sbyte> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<byte> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<short> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<ushort> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<int> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<uint> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<long> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector<ulong> vector) {
                return WStatics.ExtractMostSignificantBits(vector.AsVector128());
            }


            /// <inheritdoc cref="IVectorTraits.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    return WStatics.Floor_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Floor(Vector<float> value) {
                return WStatics.Floor(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Floor(Vector<double> value) {
                return WStatics.Floor(value.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    return WStatics.Narrow_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{double}, Vector{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Narrow(Vector<double> lower, Vector<double> upper) {
                return WStatics.Narrow(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{short}, Vector{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Narrow(Vector<short> lower, Vector<short> upper) {
                return WStatics.Narrow(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ushort}, Vector{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Narrow(Vector<ushort> lower, Vector<ushort> upper) {
                return WStatics.Narrow(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{int}, Vector{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Narrow(Vector<int> lower, Vector<int> upper) {
                return WStatics.Narrow(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{uint}, Vector{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Narrow(Vector<uint> lower, Vector<uint> upper) {
                return WStatics.Narrow(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{long}, Vector{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Narrow(Vector<long> lower, Vector<long> upper) {
                return WStatics.Narrow(lower.AsVector128(), upper.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ulong}, Vector{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Narrow(Vector<ulong> lower, Vector<ulong> upper) {
                return WStatics.Narrow(lower.AsVector128(), upper.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    return WStatics.ShiftLeft_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft(Vector<ushort> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft(Vector<uint> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftAmount) {
                return WStatics.ShiftLeft(value.AsVector128(), shiftAmount).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{short}, int, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
                var args0 = WStatics.ShiftLeft_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{ushort}, int, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Args(Vector<ushort> dummy, int shiftAmount, out Vector<ushort> args1) {
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

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1) {
                return WStatics.ShiftLeft_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Core(Vector<ushort> value, int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
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

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return WStatics.ShiftLeft_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Const(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return WStatics.ShiftLeft_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return WStatics.ShiftLeft_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Const(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return WStatics.ShiftLeft_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return WStatics.ShiftLeft_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Const(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return WStatics.ShiftLeft_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return WStatics.ShiftLeft_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Const(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return WStatics.ShiftLeft_Const(value.AsVector128(), shiftAmount).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{short}, int, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1) {
                return WStatics.ShiftLeft_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_ConstCore(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
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

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Fast(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftLeft_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Fast(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftLeft_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Fast(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftLeft_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Fast(Vector<ushort> value, int shiftAmount) {
                return WStatics.ShiftLeft_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Fast(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftLeft_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Fast(Vector<uint> value, int shiftAmount) {
                return WStatics.ShiftLeft_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft_Fast(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftLeft_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft_Fast(Vector<ulong> value, int shiftAmount) {
                return WStatics.ShiftLeft_Fast(value.AsVector128(), shiftAmount).AsVector();
            }



            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    return WStatics.ShiftRightArithmetic_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
                var args0 = WStatics.ShiftRightArithmetic_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Args(Vector{short}, int, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
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

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1) {
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

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return WStatics.ShiftRightArithmetic_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return WStatics.ShiftRightArithmetic_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return WStatics.ShiftRightArithmetic_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return WStatics.ShiftRightArithmetic_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
                return WStatics.ShiftRightArithmetic_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_ConstCore(Vector{short}, int, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1) {
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

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Fast(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Fast(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Fast(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Fast(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Fast_Widen(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic_Fast_Widen(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Fast_Negative(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic_Fast_Negative(value.AsVector128(), shiftAmount).AsVector();
            }

#if !REDUCE_MEMORY_USAGE
            ///// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{long}, int)"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector<long> ShiftRightArithmetic_Fast_Narrow(Vector<long> value, int shiftAmount) {
            //    return WStatics.ShiftRightArithmetic_Fast_Narrow(value.AsVector128(), shiftAmount).AsVector();
            //}

            ///// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{long}, int)"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector<long> ShiftRightArithmetic_Fast_NarrowIfLess(Vector<long> value, int shiftAmount) {
            //    return WStatics.ShiftRightArithmetic_Fast_NarrowIfLess(value.AsVector128(), shiftAmount).AsVector();
            //}
#endif // !REDUCE_MEMORY_USAGE

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Fast_Negative(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightArithmetic_Fast_Negative(value.AsVector128(), shiftAmount).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    return WStatics.ShiftRightLogical_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical(Vector<ushort> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical(Vector<uint> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical(Vector<ulong> value, int shiftAmount) {
                return WStatics.ShiftRightLogical(value.AsVector128(), shiftAmount).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{short}, int, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
                var args0 = WStatics.ShiftRightLogical_Args(dummy.AsVector128(), shiftAmount, out var a1).AsVector();
                args1 = a1.AsVector();
                return args0;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{ushort}, int, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Args(Vector<ushort> dummy, int shiftAmount, out Vector<ushort> args1) {
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

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1) {
                return WStatics.ShiftRightLogical_Core(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Core(Vector<ushort> value, int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
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

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return WStatics.ShiftRightLogical_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Const(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return WStatics.ShiftRightLogical_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return WStatics.ShiftRightLogical_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Const(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return WStatics.ShiftRightLogical_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return WStatics.ShiftRightLogical_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Const(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return WStatics.ShiftRightLogical_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return WStatics.ShiftRightLogical_Const(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_Const(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return WStatics.ShiftRightLogical_Const(value.AsVector128(), shiftAmount).AsVector();
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

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{short}, int, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1) {
                return WStatics.ShiftRightLogical_ConstCore(value.AsVector128(), shiftAmount, args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_ConstCore(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
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

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Fast(Vector<sbyte> value, int shiftAmount) {
                return WStatics.ShiftRightLogical_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{byte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Fast(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftRightLogical_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{byte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Fast_FirstAnd(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftRightLogical_Fast_FirstAnd(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{byte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Fast_FirstShift(Vector<byte> value, int shiftAmount) {
                return WStatics.ShiftRightLogical_Fast_FirstShift(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Fast(Vector<short> value, int shiftAmount) {
                return WStatics.ShiftRightLogical_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Fast(Vector<ushort> value, int shiftAmount) {
                return WStatics.ShiftRightLogical_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Fast(Vector<int> value, int shiftAmount) {
                return WStatics.ShiftRightLogical_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Fast(Vector<uint> value, int shiftAmount) {
                return WStatics.ShiftRightLogical_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical_Fast(Vector<long> value, int shiftAmount) {
                return WStatics.ShiftRightLogical_Fast(value.AsVector128(), shiftAmount).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical_Fast(Vector<ulong> value, int shiftAmount) {
                return WStatics.ShiftRightLogical_Fast(value.AsVector128(), shiftAmount).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
            public static TypeCodeFlags Shuffle_AcceleratedTypes {
                get {
                    return WStatics.Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Shuffle(Vector<float> vector, Vector<int> indices) {
                return WStatics.Shuffle(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Shuffle(Vector<double> vector, Vector<long> indices) {
                return WStatics.Shuffle(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Shuffle(Vector<sbyte> vector, Vector<sbyte> indices) {
                return WStatics.Shuffle(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Shuffle(Vector<byte> vector, Vector<byte> indices) {
                return WStatics.Shuffle(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Shuffle(Vector<short> vector, Vector<short> indices) {
                return WStatics.Shuffle(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Shuffle(Vector<ushort> vector, Vector<ushort> indices) {
                return WStatics.Shuffle(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Shuffle(Vector<int> vector, Vector<int> indices) {
                return WStatics.Shuffle(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Shuffle(Vector<uint> vector, Vector<uint> indices) {
                return WStatics.Shuffle(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Shuffle(Vector<long> vector, Vector<long> indices) {
                return WStatics.Shuffle(vector.AsVector128(), indices.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Shuffle(Vector<ulong> vector, Vector<ulong> indices) {
                return WStatics.Shuffle(vector.AsVector128(), indices.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1) {
                WStatics.Shuffle_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1) {
                WStatics.Shuffle_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1) {
                WStatics.Shuffle_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1) {
                WStatics.Shuffle_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1) {
                WStatics.Shuffle_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1) {
                WStatics.Shuffle_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1) {
                WStatics.Shuffle_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1) {
                WStatics.Shuffle_Args(indices.AsVector128(), out var a0, out var a1);
                args0 = a0.AsVector();
                args1 = a1.AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{float}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Shuffle_Core(Vector<float> vector, Vector<int> args0, Vector<int> args1) {
                return WStatics.Shuffle_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{double}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Shuffle_Core(Vector<double> vector, Vector<long> args0, Vector<long> args1) {
                return WStatics.Shuffle_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Shuffle_Core(Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1) {
                return WStatics.Shuffle_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Shuffle_Core(Vector<byte> vector, Vector<byte> args0, Vector<byte> args1) {
                return WStatics.Shuffle_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Shuffle_Core(Vector<short> vector, Vector<short> args0, Vector<short> args1) {
                return WStatics.Shuffle_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Shuffle_Core(Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1) {
                return WStatics.Shuffle_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Shuffle_Core(Vector<int> vector, Vector<int> args0, Vector<int> args1) {
                return WStatics.Shuffle_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Shuffle_Core(Vector<uint> vector, Vector<uint> args0, Vector<uint> args1) {
                return WStatics.Shuffle_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Shuffle_Core(Vector<long> vector, Vector<long> args0, Vector<long> args1) {
                return WStatics.Shuffle_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Shuffle_Core(Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1) {
                return WStatics.Shuffle_Core(vector.AsVector128(), args0.AsVector128(), args1.AsVector128()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.Sum_AcceleratedTypes"/>
            public static TypeCodeFlags Sum_AcceleratedTypes {
                get {
                    return WStatics.Sum_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum(Vector<float> value) {
                return WStatics.Sum(value.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum(Vector<double> value) {
                return WStatics.Sum(value.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum(Vector<sbyte> value) {
                return WStatics.Sum(value.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum(Vector<byte> value) {
                return WStatics.Sum(value.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum(Vector<short> value) {
                return WStatics.Sum(value.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum(Vector<ushort> value) {
                return WStatics.Sum(value.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum(Vector<int> value) {
                return WStatics.Sum(value.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum(Vector<uint> value) {
                return WStatics.Sum(value.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum(Vector<long> value) {
                return WStatics.Sum(value.AsVector128());
            }

            /// <inheritdoc cref="IVectorTraits.Sum(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum(Vector<ulong> value) {
                return WStatics.Sum(value.AsVector128());
            }


            /// <inheritdoc cref="IVectorTraits.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    return WStatics.Widen_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<float> source, out Vector<double> lower, out Vector<double> upper) {
                WStatics.Widen(source.AsVector128(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper) {
                WStatics.Widen(source.AsVector128(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper) {
                WStatics.Widen(source.AsVector128(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<short> source, out Vector<int> lower, out Vector<int> upper) {
                WStatics.Widen(source.AsVector128(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper) {
                WStatics.Widen(source.AsVector128(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                WStatics.Widen(source.AsVector128(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper) {
                WStatics.Widen(source.AsVector128(), out var a, out var b);
                lower = a.AsVector();
                upper = b.AsVector();
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
