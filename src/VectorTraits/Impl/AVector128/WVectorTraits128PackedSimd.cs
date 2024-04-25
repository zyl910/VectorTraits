using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading;
#endif
#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Wasm;
#endif // NET8_0_OR_GREATER
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    /// <summary>
    /// <see cref="Vector128{T}"/> traits - PackedSimd .
    /// </summary>
    public sealed partial class WVectorTraits128PackedSimd : WVectorTraits128PackedSimdAbstract {
        private static readonly WVectorTraits128PackedSimd _instance = new WVectorTraits128PackedSimd(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits128PackedSimd Instance {
            get { return _instance; }
        }

#if NET8_0_OR_GREATER


#endif // NET8_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector128{T}"/> traits.Statics - PackedSimd.
        /// </summary>
        public static partial class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsHardwareAccelerated"/>
            public static bool IsHardwareAccelerated {
                get {
                    return IsSupported;
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
                bool rt = false;
#if NET8_0_OR_GREATER
                rt = PackedSimd.IsSupported;
#else
#endif // NET8_0_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Requires hardware support PackedSimd!";
#if NETCOREAPP3_0_OR_GREATER
#else
                rt = "Vector128 type is not supported! " + rt;
#endif // NETCOREAPP3_0_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

            /// <inheritdoc cref="IBaseTraits.UsedInstructionSets"/>
            public static string UsedInstructionSets { get; } = MakeUsedInstructionSets();

            /// <inheritdoc cref="Zyl.VectorTraits.Impl.AVector.VectorTraitsBase.Statics.MakeUsedInstructionSets"/>
            internal static string MakeUsedInstructionSets() {
                string rt = "";
#if NETCOREAPP3_0_OR_GREATER
                string separator = VectorEnvironment.InstructionSetsSeparator;
#if NET8_0_OR_GREATER
                if (System.Runtime.Intrinsics.Wasm.PackedSimd.IsSupported) rt += separator + "PackedSimd";
#endif // NET8_0_OR_GREATER
                // done.
                if (!string.IsNullOrEmpty(rt)) {
                    rt = rt.Substring(separator.Length);
                }
#endif // NETCOREAPP3_0_OR_GREATER
                return rt;
            }

#if NET8_0_OR_GREATER

            /// <summary>
            /// Debug test.
            /// </summary>
            public static void DebugTest() {
                Vector128<sbyte> src = Vector128<sbyte>.AllBitsSet;
                byte shiftAmount = 0;
                try {
                    Vector128<sbyte> dst = PackedSimd.ShiftLeft(src, shiftAmount);
                    Trace.WriteLine($"ShiftLeft:\tOK. {dst}");
                } catch(Exception ex) {
                    Trace.WriteLine($"ShiftLeft:\tFail!. {ex}");
                }
                try {
                    Vector128<sbyte> dst = PackedSimd.ShiftRightArithmetic(src, shiftAmount);
                    Trace.WriteLine($"ShiftRightArithmetic:\tOK. {dst}");
                } catch (Exception ex) {
                    Trace.WriteLine($"ShiftRightArithmetic:\tFail!. {ex}");
                }
                try {
                    Vector128<sbyte> dst = PackedSimd.ShiftRightLogical(src, shiftAmount);
                    Trace.WriteLine($"ShiftRightLogical:\tOK. {dst}");
                } catch (Exception ex) {
                    Trace.WriteLine($"ShiftRightLogical:\tFail!. {ex}");
                }
                // Output:
                // ShiftLeftLogical:	OK. <-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1>
            }


            /// <inheritdoc cref="IWVectorTraits128.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Ceiling(Vector128<float> value) {
                return PackedSimd.Ceiling(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Ceiling(Vector128<double> value) {
                return PackedSimd.Ceiling(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble(Vector128<long> value) {
                return SuperStatics.ConvertToDouble(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble(Vector128<ulong> value) {
                return SuperStatics.ConvertToDouble(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble_Range52(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Range52(Vector128<long> value) {
                return ConvertToDouble_Range52_Impl(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble_Range52(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Range52(Vector128<ulong> value) {
                return ConvertToDouble_Range52_Impl(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble_Range52(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Range52_Impl(Vector128<long> value) {
                // See more: WVectorTraits256Avx2.ConvertToDouble_Range52
                Vector128<long> magicNumber = Vector128.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51).AsInt64(); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector128<long> x = PackedSimd.Add(value, magicNumber);
                Vector128<double> result = Subtract(x.AsDouble(), magicNumber.AsDouble());
                return result;
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble_Range52(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Range52_Impl(Vector128<ulong> value) {
                // See more: WVectorTraits256Avx2.ConvertToDouble_Range52
                Vector128<ulong> magicNumber = Vector128.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt64(); // Double value: pow(2, 52)
                Vector128<ulong> x = PackedSimd.Or(value, magicNumber);
                Vector128<double> result = Subtract(x.AsDouble(), magicNumber.AsDouble());
                return result;
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt32_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt32(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ConvertToInt32(Vector128<float> value) {
                return PackedSimd.ConvertToInt32Saturate(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    return SuperStatics.ConvertToInt64_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64(Vector128<double> value) {
                return SuperStatics.ConvertToInt64(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_Range52(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_Range52(Vector128<double> value) {
                return ConvertToInt64_Range52_Impl(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_Range52(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_Range52_Impl(Vector128<double> value) {
                value = YRoundToZero(value); // Truncate.
                return ConvertToInt64_Range52RoundToEven(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_Range52RoundToEven(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_Range52RoundToEven(Vector128<double> value) {
                // See more: WVectorTraits256Avx2.ConvertToInt64_Range52RoundToEven
                Vector128<long> magicNumber = Vector128.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51).AsInt64(); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector128<double> x = Add(value, magicNumber.AsDouble());
                Vector128<long> result = PackedSimd.Subtract(x.AsInt64(), magicNumber);
                return result;
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToSingle_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> ConvertToSingle(Vector128<int> value) {
                return PackedSimd.ConvertToSingle(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> ConvertToSingle(Vector128<uint> value) {
                return PackedSimd.ConvertToSingle(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ConvertToUInt32(Vector128<float> value) {
                return PackedSimd.ConvertToUInt32Saturate(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
                get {
                    return SuperStatics.ConvertToUInt64_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64(Vector128<double> value) {
                return SuperStatics.ConvertToUInt64(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64_Range52(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64_Range52(Vector128<double> value) {
                return ConvertToUInt64_Range52_Impl(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64_Range52(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64_Range52_Impl(Vector128<double> value) {
                value = YRoundToZero(value); // Truncate.
                return ConvertToUInt64_Range52RoundToEven(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64_Range52RoundToEven(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64_Range52RoundToEven(Vector128<double> value) {
                // See more: WVectorTraits256Avx2.ConvertToInt64_Range52RoundToEven
                Vector128<ulong> magicNumber = Vector128.Create((ulong)ScalarConstants.DoubleVal_2Pow52); // Double value: pow(2, 52)
                Vector128<double> x = Add(value, magicNumber.AsDouble());
                Vector128<ulong> result = PackedSimd.Xor(x.AsUInt64(), magicNumber);
                return result;
            }

/*
            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits_AcceleratedTypes"/>
            public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<float> vector) {
                return ExtractMostSignificantBits(vector.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<double> vector) {
                return ExtractMostSignificantBits(vector.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<sbyte> vector) {
                return ExtractMostSignificantBits_ShiftVar(vector);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<byte> vector) {
                return ExtractMostSignificantBits_ShiftVar(vector);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<short> vector) {
                return ExtractMostSignificantBits_ShiftAnd(vector);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<ushort> vector) {
                return ExtractMostSignificantBits_ShiftAnd(vector);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<int> vector) {
                return ExtractMostSignificantBits_ShiftAnd(vector);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<uint> vector) {
                return ExtractMostSignificantBits_ShiftAnd(vector);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<long> vector) {
                return ExtractMostSignificantBits_ShiftAnd(vector);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<ulong> vector) {
                return ExtractMostSignificantBits_ShiftAnd(vector);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftAnd(Vector128<short> vector) {
                return ExtractMostSignificantBits_ShiftAnd(vector.AsUInt16());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftAnd(Vector128<ushort> vector) {
                Vector128<short> mask = Vector128Constants.MaskBitPosSerialRotate16;
                Vector128<ushort> temp = PackedSimd.And(mask, PackedSimd.ShiftRightArithmetic(vector.AsInt16(), 15)).AsUInt16();
                uint rt = Sum(temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftAnd(Vector128<int> vector) {
                return ExtractMostSignificantBits_ShiftAnd(vector.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftAnd(Vector128<uint> vector) {
                Vector128<int> mask = Vector128Constants.MaskBitPosSerialRotate32;
                Vector128<uint> temp = PackedSimd.And(mask, PackedSimd.ShiftRightArithmetic(vector.AsInt32(), 31)).AsUInt32();
                uint rt = Sum(temp);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftAnd(Vector128<long> vector) {
                return ExtractMostSignificantBits_ShiftAnd(vector.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftAnd(Vector128<ulong> vector) {
                Vector128<ulong> m = PackedSimd.ShiftRightLogical(vector, 63); // Get MostSignificantBit .
                Vector64<uint> h = PackedSimd.ShiftLeftLogical(m.GetUpper().AsUInt32(), 1);
                Vector64<uint> l = m.GetLower().AsUInt32();
                l = PackedSimd.Or(l, h);
                return PackedSimd.Extract(l, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftVar(Vector128<sbyte> vector) {
                return ExtractMostSignificantBits_ShiftVar(vector.AsByte());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftVar(Vector128<byte> vector) {
                Vector128<byte> m = PackedSimd.ShiftRightLogical(vector, 7); // Get MostSignificantBit .
                m = PackedSimd.ShiftLogical(m, Vector128Constants.SerialRotate8.AsSByte());
                Widen(m, out Vector128<ushort> l, out Vector128<ushort> h);
                h = PackedSimd.ShiftLeftLogical(h, 8);
                l = PackedSimd.Or(l, h);
                uint rt = Sum(l);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftVar(Vector128<short> vector) {
                return ExtractMostSignificantBits_ShiftVar(vector.AsUInt16());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftVar(Vector128<ushort> vector) {
                Vector128<ushort> m = PackedSimd.ShiftRightLogical(vector, 15); // Get MostSignificantBit .
                m = PackedSimd.ShiftLogical(m, Vector128s<short>.Serial);
                uint rt = Sum(m);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftVar(Vector128<int> vector) {
                return ExtractMostSignificantBits_ShiftVar(vector.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftVar(Vector128<uint> vector) {
                Vector128<uint> m = PackedSimd.ShiftRightLogical(vector, 31); // Get MostSignificantBit .
                m = PackedSimd.ShiftLogical(m, Vector128s<int>.Serial);
                uint rt = Sum(m);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftVar(Vector128<long> vector) {
                return ExtractMostSignificantBits_ShiftVar(vector.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_ShiftVar(Vector128<ulong> vector) {
                Vector128<ulong> m = PackedSimd.ShiftRightLogical(vector, 63); // Get MostSignificantBit .
                m = PackedSimd.ShiftLogical(m, Vector128s<long>.Serial);
                uint rt = (uint)Sum(m);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Floor(Vector128<float> value) {
                return PackedSimd.Floor(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Floor(Vector128<double> value) {
                Vector64<double> lower = PackedSimd.FloorScalar(Vector128.GetLower(value));
                Vector64<double> upper = PackedSimd.FloorScalar(Vector128.GetUpper(value));
                Vector128<double> rt = lower.ToVector128Unsafe().WithUpper(upper); //Vector128.Create(lower, upper);
                return rt;
            }
*/

            /// <inheritdoc cref="IWVectorTraits128.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{double}, Vector128{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Narrow(Vector128<double> lower, Vector128<double> upper) {
                Vector128<float> l = PackedSimd.ConvertToSingle(lower);
                Vector128<float> u = PackedSimd.ConvertToSingle(upper);
                Vector128<float> rt = l.WithUpper(u.GetLower());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{short}, Vector128{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Narrow(Vector128<short> lower, Vector128<short> upper) {
                return Narrow(lower.AsUInt16(), upper.AsUInt16()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{ushort}, Vector128{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Narrow(Vector128<ushort> lower, Vector128<ushort> upper) {
                Vector128<ushort> mask = Vector128Constants.UInt16_VMaxByte;
                Vector128<ushort> l = PackedSimd.And(lower, mask);
                Vector128<ushort> u = PackedSimd.And(upper, mask);
                Vector128<byte> rt = PackedSimd.ConvertNarrowingSaturateUnsigned(l.AsInt16(), u.AsInt16());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{int}, Vector128{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Narrow(Vector128<int> lower, Vector128<int> upper) {
                return Narrow(lower.AsUInt32(), upper.AsUInt32()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{uint}, Vector128{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Narrow(Vector128<uint> lower, Vector128<uint> upper) {
                Vector128<uint> mask = Vector128Constants.UInt32_VMaxUInt16;
                Vector128<uint> l = PackedSimd.And(lower, mask);
                Vector128<uint> u = PackedSimd.And(upper, mask);
                Vector128<ushort> rt = PackedSimd.ConvertNarrowingSaturateUnsigned(l.AsInt32(), u.AsInt32());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{long}, Vector128{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Narrow(Vector128<long> lower, Vector128<long> upper) {
                return SuperStatics.Narrow(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{ulong}, Vector128{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Narrow(Vector128<ulong> lower, Vector128<ulong> upper) {
                return SuperStatics.Narrow(lower, upper);
            }

/*
            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft(Vector128<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft(Vector128<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft(Vector128<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft(Vector128<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft(Vector128<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Args(Vector128<sbyte> dummy, int shiftAmount, out Vector128<sbyte> args1) {
                _ = dummy;
                _ = shiftAmount;
                var args0 = Vector128.Create((sbyte)(shiftAmount & 7));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{byte}, int, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Args(Vector128<byte> dummy, int shiftAmount, out Vector128<byte> args1) {
                _ = dummy;
                _ = shiftAmount;
                var args0 = Vector128.Create((byte)(shiftAmount & 7));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{short}, int, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1) {
                _ = dummy;
                _ = shiftAmount;
                var args0 = Vector128.Create((short)(shiftAmount & 0x0F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{ushort}, int, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Args(Vector128<ushort> dummy, int shiftAmount, out Vector128<ushort> args1) {
                _ = dummy;
                _ = shiftAmount;
                var args0 = Vector128.Create((ushort)(shiftAmount & 0x0F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{int}, int, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1) {
                _ = dummy;
                _ = shiftAmount;
                var args0 = Vector128.Create((int)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{uint}, int, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Args(Vector128<uint> dummy, int shiftAmount, out Vector128<uint> args1) {
                _ = dummy;
                _ = shiftAmount;
                var args0 = Vector128.Create((uint)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{long}, int, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
                _ = dummy;
                _ = shiftAmount;
                var args0 = Vector128.Create((long)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Args(Vector128<ulong> dummy, int shiftAmount, out Vector128<ulong> args1) {
                _ = dummy;
                _ = shiftAmount;
                var args0 = Vector128.Create((ulong)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Core(Vector128<byte> value, int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0.AsSByte());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Core(Vector128<ushort> value, int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0.AsInt16());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Core(Vector128<uint> value, int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Core(Vector128<ulong> value, int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Const(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Const(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Const(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return PackedSimd.ShiftLeftLogical(value.AsUInt32(), (byte)shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Const(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Const(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_ConstCore(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_ConstCore(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_ConstCore(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_ConstCore(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftLeftLogical(value.AsUInt32(), (byte)shiftAmount).AsInt32();
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_ConstCore(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_ConstCore(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Fast(Vector128<sbyte> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((sbyte)(shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Fast(Vector128<byte> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((sbyte)(shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Fast(Vector128<short> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((short)(shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Fast(Vector128<ushort> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((short)(shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Fast(Vector128<int> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((int)(shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Fast(Vector128<uint> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((int)(shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Fast(Vector128<long> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((long)(shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Fast(Vector128<ulong> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((long)(shiftAmount)));
            }


            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                if (0 == shiftAmount) {
                    // PackedSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                if (0 == shiftAmount) {
                    // PackedSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                if (0 == shiftAmount) {
                    // PackedSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                if (0 == shiftAmount) {
                    // PackedSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Args(Vector128<sbyte> dummy, int shiftAmount, out Vector128<sbyte> args1) {
                _ = dummy;
                var args0 = Vector128.Create((sbyte)-(shiftAmount & 7));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{short}, int, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1) {
                _ = dummy;
#if NET6_0_OR_GREATER
#else
                shiftAmount = Volatile.Read(ref shiftAmount); // Fixed a bug when it runs on net5 arm. If shiftAmount is constant byte 1, the element of args0 should be -1(0xFFFF), but it is -256(0xFF00) .
#endif
                var args0 = Vector128.Create((short)-(shiftAmount & 0x0F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{int}, int, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1) {
                _ = dummy;
                var args0 = Vector128.Create((int)-(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{long}, int, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
                _ = dummy;
                var args0 = Vector128.Create((long)-(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftArithmetic(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftArithmetic(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftArithmetic(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftArithmetic(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Const(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Const(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if NET6_0_OR_GREATER
                return PackedSimd.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Fast(value, shiftAmount);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Const(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if NET6_0_OR_GREATER
                return PackedSimd.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Fast(value, shiftAmount);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Const(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if NET6_0_OR_GREATER
                return PackedSimd.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Fast(value, shiftAmount);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Const(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if NET6_0_OR_GREATER
                return PackedSimd.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Fast(value, shiftAmount);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
#if NET6_0_OR_GREATER
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_ConstCore(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
#if NET6_0_OR_GREATER
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_ConstCore(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
#if NET6_0_OR_GREATER
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
#if NET6_0_OR_GREATER
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Fast(Vector128<sbyte> value, int shiftAmount) {
                return PackedSimd.ShiftArithmetic(value, Vector128.Create((sbyte)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Fast(Vector128<short> value, int shiftAmount) {
                return PackedSimd.ShiftArithmetic(value, Vector128.Create((short)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Fast(Vector128<int> value, int shiftAmount) {
                return PackedSimd.ShiftArithmetic(value, Vector128.Create((int)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Fast(Vector128<long> value, int shiftAmount) {
                return PackedSimd.ShiftArithmetic(value, Vector128.Create((long)(-shiftAmount)));
            }


            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical(Vector128<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical(Vector128<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Args(Vector128<sbyte> dummy, int shiftAmount, out Vector128<sbyte> args1) {
                _ = dummy;
                var args0 = Vector128.Create((sbyte)-(shiftAmount & 7));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{byte}, int, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Args(Vector128<byte> dummy, int shiftAmount, out Vector128<byte> args1) {
                var a0 = ShiftRightLogical_Args(dummy.AsSByte(), shiftAmount, out var a1);
                args1 = a1.AsByte();
                return a0.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{short}, int, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1) {
                _ = dummy;
#if NET6_0_OR_GREATER
#else
                shiftAmount = Volatile.Read(ref shiftAmount); // Fixed a bug when it runs on net5 arm. If shiftAmount is constant byte 1, the element of args0 should be -1(0xFFFF), but it is -256(0xFF00) .
#endif
                var args0 = Vector128.Create((short)-(shiftAmount & 0x0F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{ushort}, int, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Args(Vector128<ushort> dummy, int shiftAmount, out Vector128<ushort> args1) {
                var a0 = ShiftRightLogical_Args(dummy.AsInt16(), shiftAmount, out var a1);
                args1 = a1.AsUInt16();
                return a0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{int}, int, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1) {
                _ = dummy;
                var args0 = Vector128.Create((int)-(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{uint}, int, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Args(Vector128<uint> dummy, int shiftAmount, out Vector128<uint> args1) {
                var a0 = ShiftRightLogical_Args(dummy.AsInt32(), shiftAmount, out var a1);
                args1 = a1.AsUInt32();
                return a0.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{long}, int, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
                _ = dummy;
                var args0 = Vector128.Create((long)-(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Args(Vector128<ulong> dummy, int shiftAmount, out Vector128<ulong> args1) {
                var a0 = ShiftRightLogical_Args(dummy.AsInt64(), shiftAmount, out var a1);
                args1 = a1.AsUInt64();
                return a0.AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Core(Vector128<byte> value, int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0.AsSByte());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Core(Vector128<ushort> value, int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0.AsInt16());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Core(Vector128<uint> value, int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Core(Vector128<ulong> value, int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
                _ = shiftAmount;
                _ = args1;
                return PackedSimd.ShiftLogical(value, args0.AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Const(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if NET6_0_OR_GREATER
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Fast(value, shiftAmount);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Const(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if NET6_0_OR_GREATER
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Fast(value, shiftAmount);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if NET6_0_OR_GREATER
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                shiftAmount = Volatile.Read(ref shiftAmount); // Fixed a bug when it runs on net5 arm. If shiftAmount is constant byte 1, the element of args0 should be -1(0xFFFF), but it is -256(0xFF00) .
                return ShiftRightLogical_Fast(value, shiftAmount);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Const(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftRightLogical_Const(value.AsInt16(), shiftAmount).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if NET6_0_OR_GREATER
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Fast(value, shiftAmount);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Const(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if NET6_0_OR_GREATER
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Fast(value, shiftAmount);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if NET6_0_OR_GREATER
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Fast(value, shiftAmount);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Const(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if NET6_0_OR_GREATER
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Fast(value, shiftAmount);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_ConstCore(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_ConstCore(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_ConstCore(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_ConstCore(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_ConstCore(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_ConstCore(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Fast(Vector128<sbyte> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((sbyte)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Fast(Vector128<byte> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((sbyte)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Fast(Vector128<short> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((short)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Fast(Vector128<ushort> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((short)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Fast(Vector128<int> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((int)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Fast(Vector128<uint> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((int)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Fast(Vector128<long> value, int shiftAmount) {
                return PackedSimd.ShiftLogical(value, Vector128.Create((long)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Fast(Vector128<ulong> value, int shiftAmount) {
                return ShiftRightLogical_Fast_HwVar(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Fast_HwVar(Vector128<ulong> value, int shiftAmount) {
                Vector128<long> vshift = Vector128.Create((long)(-shiftAmount));
                // NEON intrinsics for shifts by signed variable
                // uint64x2_t vshlq_u64(uint64x2_t a, int64x2_t b);  // VSHL.U64 q0,q0,q0
                return PackedSimd.ShiftLogical(value, vshift);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Fast_HwImm(Vector128<ulong> value, int shiftAmount) {
                Debug.Assert(1 <= shiftAmount && shiftAmount <= 63, "The shiftAmount parameter must be in the range [1,63]."); // PackedSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                return PackedSimd.ShiftRightLogical(value, (byte)shiftAmount);
            }


            /// <inheritdoc cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
            public static TypeCodeFlags Shuffle_AcceleratedTypes {
                get {
                    return YShuffleKernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Shuffle(Vector128<float> vector, Vector128<int> indices) {
                return Shuffle(vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Shuffle(Vector128<double> vector, Vector128<long> indices) {
                return Shuffle(vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Shuffle(Vector128<sbyte> vector, Vector128<sbyte> indices) {
                return Shuffle(vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Shuffle(Vector128<byte> vector, Vector128<byte> indices) {
                return YShuffleKernel(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Shuffle(Vector128<short> vector, Vector128<short> indices) {
                return Shuffle(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Shuffle(Vector128<ushort> vector, Vector128<ushort> indices) {
                Vector128<ushort> mask = PackedSimd.CompareGreaterThan(Vector128.Create((ushort)8), indices); // (0<=i && i<8)
                Vector128<byte> indices2 = PackedSimd.MultiplyAdd(Vector128Constants.Shuffle_UInt16_ByteOffset.AsUInt16(), indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte();
                indices2 = PackedSimd.OrNot(indices2, mask.AsByte());
                return Shuffle(vector.AsByte(), indices2).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Shuffle(Vector128<int> vector, Vector128<int> indices) {
                return Shuffle(vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Shuffle(Vector128<uint> vector, Vector128<uint> indices) {
                Vector128<uint> mask = PackedSimd.CompareGreaterThan(Vector128.Create((uint)4), indices); // (0<=i && i<4)
                Vector128<byte> indices2 = PackedSimd.MultiplyAdd(Vector128Constants.Shuffle_UInt32_ByteOffset.AsUInt32(), indices, Vector128Constants.Shuffle_UInt32_Multiplier).AsByte();
                indices2 = PackedSimd.OrNot(indices2, mask.AsByte());
                return Shuffle(vector.AsByte(), indices2).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Shuffle(Vector128<long> vector, Vector128<long> indices) {
                return Shuffle(vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Shuffle(Vector128<ulong> vector, Vector128<ulong> indices) {
                Vector128<ulong> mask = GreaterThan(Vector128.Create((ulong)2), indices); // (0<=i && i<2)
                Vector128<uint> indices1 = PackedSimd.Or(PackedSimd.ShiftLeftLogical(indices, 32), indices).AsUInt32();
                Vector128<byte> indices2 = PackedSimd.MultiplyAdd(Vector128Constants.Shuffle_UInt64_ByteOffset.AsUInt32(), indices1, Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsByte();
                indices2 = PackedSimd.OrNot(indices2, mask.AsByte());
                return Shuffle(vector.AsByte(), indices2).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
                Shuffle_Args(indices.AsByte(), out var a0, out var a1);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
                YShuffleKernel_Args(indices, out args0, out args1);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
                Shuffle_Args(indices.AsUInt16(), out var a0, out var a1);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
                Vector128<ushort> mask = PackedSimd.CompareGreaterThan(Vector128.Create((ushort)8), indices); // (0<=i && i<8)
                YShuffleKernel_Args(indices, out args0, out args1);
                args0 = PackedSimd.OrNot(args0, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
                Shuffle_Args(indices.AsUInt32(), out var a0, out var a1);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
                Vector128<uint> mask = PackedSimd.CompareGreaterThan(Vector128.Create((uint)4), indices); // (0<=i && i<4)
                YShuffleKernel_Args(indices, out args0, out args1);
                args0 = PackedSimd.OrNot(args0, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
                Shuffle_Args(indices.AsUInt64(), out var a0, out var a1);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
                Vector128<ulong> mask = GreaterThan(Vector128.Create((ulong)2), indices); // (0<=i && i<2)
                YShuffleKernel_Args(indices, out args0, out args1);
                args0 = PackedSimd.OrNot(args0, mask);
            }


            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Shuffle_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
                return Shuffle_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Shuffle_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
                return Shuffle_Core(vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Shuffle_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                return Shuffle_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Shuffle_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
                return YShuffleKernel_Core(vector, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Shuffle_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
                return Shuffle_Core(vector.AsUInt16(), args0.AsUInt16(), args1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Shuffle_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
                return Shuffle_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Shuffle_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
                return Shuffle_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Shuffle_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
                return Shuffle_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Shuffle_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
                return Shuffle_Core(vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Shuffle_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
                return Shuffle_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.Sum_AcceleratedTypes"/>
            public static TypeCodeFlags Sum_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum(Vector128<float> value) {
                Vector64<float> m = PackedSimd.Add(value.GetLower(), value.GetUpper()); // 4 -> 2
                m = PackedSimd.AddPairwise(m, m); // 2 -> 1
                return PackedSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum(Vector128<double> value) {
                double rt = PackedSimd.Extract(value, 0) + PackedSimd.Extract(value, 1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum(Vector128<sbyte> value) {
                Vector64<sbyte> m = PackedSimd.Add(value.GetLower(), value.GetUpper()); // 16 -> 8
                m = PackedSimd.AddPairwise(m, m); // 8 -> 4
                m = PackedSimd.AddPairwise(m, m); // 4 -> 2
                m = PackedSimd.AddPairwise(m, m); // 2 -> 1
                return PackedSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum(Vector128<byte> value) {
                Vector64<byte> m = PackedSimd.Add(value.GetLower(), value.GetUpper()); // 16 -> 8
                m = PackedSimd.AddPairwise(m, m); // 8 -> 4
                m = PackedSimd.AddPairwise(m, m); // 4 -> 2
                m = PackedSimd.AddPairwise(m, m); // 2 -> 1
                return PackedSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum(Vector128<short> value) {
                Vector64<short> m = PackedSimd.Add(value.GetLower(), value.GetUpper()); // 8 -> 4
                m = PackedSimd.AddPairwise(m, m); // 4 -> 2
                m = PackedSimd.AddPairwise(m, m); // 2 -> 1
                return PackedSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum(Vector128<ushort> value) {
                Vector64<ushort> m = PackedSimd.Add(value.GetLower(), value.GetUpper()); // 8 -> 4
                m = PackedSimd.AddPairwise(m, m); // 4 -> 2
                m = PackedSimd.AddPairwise(m, m); // 2 -> 1
                return PackedSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum(Vector128<int> value) {
                Vector64<int> m = PackedSimd.Add(value.GetLower(), value.GetUpper()); // 4 -> 2
                m = PackedSimd.AddPairwise(m, m); // 2 -> 1
                return PackedSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum(Vector128<uint> value) {
                Vector64<uint> m = PackedSimd.Add(value.GetLower(), value.GetUpper()); // 4 -> 2
                m = PackedSimd.AddPairwise(m, m); // 2 -> 1
                return PackedSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum(Vector128<long> value) {
                long rt = PackedSimd.Extract(value, 0) + PackedSimd.Extract(value, 1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum(Vector128<ulong> value) {
                ulong rt = PackedSimd.Extract(value, 0) + PackedSimd.Extract(value, 1);
                return rt;
            }
*/

            /// <inheritdoc cref="IWVectorTraits128.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{float}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<float> source, out Vector128<double> lower, out Vector128<double> upper) {
                SuperStatics.Widen(source, out lower, out upper);
                // Bug on .NET 8.0
                //MONO interpreter: NIY encountered in method Widen
                //logging.ts:119 Error: [MONO] * Assertion: should not be reached at /__w/1/s/src/mono/mono/mini/interp/interp.c
                //lower = PackedSimd.ConvertToDoubleLower(source);
                //upper = PackedSimd.ConvertToDoubleLower(source.GetUpper().ToVector128Unsafe());
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{sbyte}, out Vector128{short}, out Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<sbyte> source, out Vector128<short> lower, out Vector128<short> upper) {
                lower = PackedSimd.SignExtendWideningLower(source);
                upper = PackedSimd.SignExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{byte}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<byte> source, out Vector128<ushort> lower, out Vector128<ushort> upper) {
                lower = PackedSimd.ZeroExtendWideningLower(source);
                upper = PackedSimd.ZeroExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{short}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<short> source, out Vector128<int> lower, out Vector128<int> upper) {
                lower = PackedSimd.SignExtendWideningLower(source);
                upper = PackedSimd.SignExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<ushort> source, out Vector128<uint> lower, out Vector128<uint> upper) {
                lower = PackedSimd.ZeroExtendWideningLower(source);
                upper = PackedSimd.ZeroExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
                lower = PackedSimd.SignExtendWideningLower(source);
                upper = PackedSimd.SignExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<uint> source, out Vector128<ulong> lower, out Vector128<ulong> upper) {
                lower = PackedSimd.ZeroExtendWideningLower(source);
                upper = PackedSimd.ZeroExtendWideningUpper(source);
            }


            /// <inheritdoc cref="IWVectorTraits128.WidenLower_AcceleratedTypes"/>
            public static TypeCodeFlags WidenLower_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> WidenLower(Vector128<float> source) {
                return SuperStatics.WidenLower(source);
                //return PackedSimd.ConvertToDoubleLower(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> WidenLower(Vector128<sbyte> source) {
                return PackedSimd.SignExtendWideningLower(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> WidenLower(Vector128<byte> source) {
                return PackedSimd.ZeroExtendWideningLower(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> WidenLower(Vector128<short> source) {
                return PackedSimd.SignExtendWideningLower(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> WidenLower(Vector128<ushort> source) {
                return PackedSimd.ZeroExtendWideningLower(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> WidenLower(Vector128<int> source) {
                return PackedSimd.SignExtendWideningLower(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> WidenLower(Vector128<uint> source) {
                return PackedSimd.ZeroExtendWideningLower(source);
            }


            /// <inheritdoc cref="IWVectorTraits128.WidenUpper_AcceleratedTypes"/>
            public static TypeCodeFlags WidenUpper_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> WidenUpper(Vector128<float> source) {
                return SuperStatics.WidenUpper(source);
                //return PackedSimd.ConvertToDoubleLower(source.GetUpper().ToVector128Unsafe());
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> WidenUpper(Vector128<sbyte> source) {
                return PackedSimd.SignExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> WidenUpper(Vector128<byte> source) {
                return PackedSimd.ZeroExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> WidenUpper(Vector128<short> source) {
                return PackedSimd.SignExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> WidenUpper(Vector128<ushort> source) {
                return PackedSimd.ZeroExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> WidenUpper(Vector128<int> source) {
                return PackedSimd.SignExtendWideningUpper(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> WidenUpper(Vector128<uint> source) {
                return PackedSimd.ZeroExtendWideningUpper(source);
            }


#endif // NET8_0_OR_GREATER
        }

    }
}
