using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;

#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits.Impl.AVector512 {
    using SuperStatics = WVectorTraits512Base.Statics;

    /// <summary>
    /// <see cref="Vector512{T}"/> traits - Avx512 .
    /// </summary>
    public sealed partial class WVectorTraits512Avx512 : WVectorTraits512Avx512Abstract {
        private static readonly WVectorTraits512Avx512 _instance = new WVectorTraits512Avx512(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits512Avx512 Instance {
            get { return _instance; }
        }

#if NET8_0_OR_GREATER


#endif // NET8_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector512{T}"/> traits.Statics - Avx512.
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
                // 2019, Intel Ice Lake (10th Core) - avx512_bitalg, avx512_vbmi2, avx512_vnni, avx512_vpopcntdq, avx512bw, avx512cd, avx512dq, avx512f, avx512ifma, avx512vbmi, avx512vl.
                // 2022, AMD Zen 4 (Ryzen 7000 series) - avx512_bf16, avx512_bitalg, avx512_vbmi2, avx512_vnni, avx512_vpopcntdq, avx512bw, avx512cd, avx512dq, avx512f, avx512ifma, avx512vbmi, avx512vl.
                rt = Avx512BW.IsSupported && Avx512DQ.IsSupported & Avx512F.IsSupported && Avx512Vbmi.IsSupported && Avx512F.VL.IsSupported
                    & Avx.IsSupported && Avx2.IsSupported && Sse.IsSupported && Sse2.IsSupported;
#else
#endif // NET8_0_OR_GREATER
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Requires hardware support Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi, Avx512VL!";
#if NET8_0_OR_GREATER
                if (Avx512BW.IsSupported && Avx512DQ.IsSupported & Avx512F.IsSupported && Avx512Vbmi.IsSupported && Avx512F.VL.IsSupported) {
                    if (Avx.IsSupported && Avx2.IsSupported && Sse.IsSupported && Sse2.IsSupported) {
                        // done.
                    } else {
                        // Details.
                        rt = "";
                        if (!Avx.IsSupported) rt += ", Avx";
                        if (!Avx2.IsSupported) rt += ", Avx2";
                        if (!Sse.IsSupported) rt += ", Sse";
                        if (!Sse2.IsSupported) rt += ", Sse2";
                        if (!string.IsNullOrEmpty(rt)) {
                            rt = "Requires hardware support " + rt.Substring(2) + "!";
                        }
                    }
                }
#else
                rt = "Vector512 type is not supported! " + rt;
#endif // NET8_0_OR_GREATER
                if (!noStrict) {
                }
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
#if NET8_0_OR_GREATER
                // Avx512BW.IsSupported && Avx512DQ.IsSupported & Avx512F.IsSupported && Avx512Vbmi.IsSupported && Avx512F.VL.IsSupported
                string separator = VectorEnvironment.InstructionSetsSeparator;
                if (System.Runtime.Intrinsics.X86.Avx512BW.IsSupported) rt += separator + "Avx512BW";
                if (System.Runtime.Intrinsics.X86.Avx512DQ.IsSupported) rt += separator + "Avx512DQ";
                if (System.Runtime.Intrinsics.X86.Avx512F.IsSupported) rt += separator + "Avx512F";
                if (System.Runtime.Intrinsics.X86.Avx512Vbmi.IsSupported) rt += separator + "Avx512Vbmi";
                if (System.Runtime.Intrinsics.X86.Avx512F.VL.IsSupported) rt += separator + "Avx512VL";
                if (System.Runtime.Intrinsics.X86.Avx.IsSupported) rt += separator + "Avx";
                if (System.Runtime.Intrinsics.X86.Avx2.IsSupported) rt += separator + "Avx2";
                if (System.Runtime.Intrinsics.X86.Sse.IsSupported) rt += separator + "Sse";
                if (System.Runtime.Intrinsics.X86.Sse2.IsSupported) rt += separator + "Sse2";
                // done.
                if (!string.IsNullOrEmpty(rt)) {
                    rt = rt.Substring(separator.Length);
                }
#endif // NET8_0_OR_GREATER
                return rt;
            }

#if NET8_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits512.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Ceiling(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Ceiling(Vector512<float> value) {
                return Avx512F.RoundScale(value, (byte)FloatRoundMode.ToPositiveInfinity);
            }

            /// <inheritdoc cref="IWVectorTraits512.Ceiling(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Ceiling(Vector512<double> value) {
                return Avx512F.RoundScale(value, (byte)FloatRoundMode.ToPositiveInfinity);
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble(Vector512<long> value) {
                return Avx512DQ.ConvertToVector512Double(value);
                //__m512d _mm512_cvtepi64_pd (__m512i a)
                //#include <immintrin.h>
                //Instruction: vcvtqq2pd zmm, zmm
                //CPUID Flags: AVX512DQ
                //Latency and Throughput
                //Architecture	Latency	Throughput (CPI)
                //Icelake Intel Core	4	1
                //Icelake Xeon	4	0.5
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_Range52(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Range52(Vector512<long> value) {
                return Avx512DQ.ConvertToVector512Double(value);
                // BitConverter.DoubleToInt64Bits((double)0x0018000000000000).ToString("X") = "4338000000000000"
                //Vector512<long> magicNumber = Vector512.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51).AsInt64(); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                //// Format: Code; //Latency, Throughput(references IceLake)
                //Vector512<long> x = Avx512F.Add(value, magicNumber); // 1,0.5
                //Vector512<double> result = Avx512F.Subtract(x.AsDouble(), magicNumber.AsDouble()); // 4,0.5
                //return result; //total latency: 5, total throughput CPI: 1
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble(Vector512<ulong> value) {
                return Avx512DQ.ConvertToVector512Double(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_Range52(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Range52(Vector512<ulong> value) {
                return Avx512DQ.ConvertToVector512Double(value);
                // BitConverter.DoubleToInt64Bits((double)0x0010000000000000).ToString("X") = "4330000000000000"
                //Vector512<ulong> magicNumber = Vector512.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt64(); // Double value: pow(2, 52)
                //Vector512<ulong> x = Avx512F.Or(value, magicNumber);
                //Vector512<double> result = Avx512F.Subtract(x.AsDouble(), magicNumber.AsDouble());
                //return result;
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt32_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt32(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ConvertToInt32(Vector512<float> value) {
                return Avx512F.ConvertToVector512Int32WithTruncation(value);
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64(Vector512<double> value) {
                return Avx512DQ.ConvertToVector512Int64WithTruncation(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_Range52(Vector512<double> value) {
                return ConvertToInt64_Range52_Impl(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_Range52_Impl(Vector512<double> value) {
                return Avx512DQ.ConvertToVector512Int64WithTruncation(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52RoundToEven(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_Range52RoundToEven(Vector512<double> value) {
                return Avx512DQ.ConvertToVector512Int64(value);
                //Vector512<double> magicNumber = Vector512.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                //Vector512<double> x = Avx512F.Add(value, magicNumber);
                //Vector512<long> result = Avx512F.Subtract(x.AsInt64(), magicNumber.AsInt64());
                //return result;
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToSingle_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> ConvertToSingle(Vector512<int> value) {
                return Avx512F.ConvertToVector512Single(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> ConvertToSingle(Vector512<uint> value) {
                return Avx512F.ConvertToVector512Single(value);
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32(Vector512{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ConvertToUInt32(Vector512<float> value) {
                return Avx512F.ConvertToVector512UInt32WithTruncation(value);
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
                get {
                    //return SuperStatics.ConvertToUInt64_AcceleratedTypes;
                    return TypeCodeFlags.Double;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ConvertToUInt64(Vector512<double> value) {
                return Avx512DQ.ConvertToVector512UInt64WithTruncation(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_Range52(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ConvertToUInt64_Range52(Vector512<double> value) {
                return ConvertToUInt64_Range52_Impl(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_Range52(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ConvertToUInt64_Range52_Impl(Vector512<double> value) {
                return Avx512DQ.ConvertToVector512UInt64WithTruncation(value);
                //__m512i _mm512_cvttpd_epi64 (__m512d a)
                //#include <immintrin.h>
                //Instruction: vcvttpd2qq zmm, zmm
                //CPUID Flags: AVX512DQ
                //Latency and Throughput
                //Architecture	Latency	Throughput (CPI)
                //Icelake Intel Core	4	1
                //Icelake Xeon	4	0.5
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_Range52RoundToEven(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ConvertToUInt64_Range52RoundToEven(Vector512<double> value) {
                return Avx512DQ.ConvertToVector512UInt64(value);
                //Vector512<double> magicNumber = Vector512.Create(ScalarConstants.DoubleVal_2Pow52); // Double value: pow(2, 52)
                //// Format: Code; //Latency, Throughput(references IceLake)
                //Vector512<double> x = Avx512F.Add(value, magicNumber); // 4,0.5
                //Vector512<ulong> result = Avx512F.Xor(x.AsUInt64(), magicNumber.AsUInt64()); // 1,0.5
                //return result; //total latency: 5, total throughput CPI: 1
            }


            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits_AcceleratedTypes"/>
            public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<float> vector) {
                // .NET8 methods have hardware-accelerated. .NET8 does not provide vpmovd2m instructions.
                return SuperStatics.ExtractMostSignificantBits(vector);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<double> vector) {
                // .NET8 methods have hardware-accelerated. .NET8 does not provide vpmovq2m instructions.
                return SuperStatics.ExtractMostSignificantBits(vector);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<sbyte> vector) {
                // .NET8 methods have hardware-accelerated. .NET8 does not provide vpmovb2m instructions.
                return SuperStatics.ExtractMostSignificantBits(vector);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<byte> vector) {
                // .NET8 methods have hardware-accelerated. .NET8 does not provide vpmovb2m instructions.
                return SuperStatics.ExtractMostSignificantBits(vector);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<short> vector) {
                // .NET8 methods have hardware-accelerated. .NET8 does not provide vpmovw2m instructions.
                return SuperStatics.ExtractMostSignificantBits(vector);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<ushort> vector) {
                // .NET8 methods have hardware-accelerated. .NET8 does not provide vpmovw2m instructions.
                return SuperStatics.ExtractMostSignificantBits(vector);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<int> vector) {
                // .NET8 methods have hardware-accelerated. .NET8 does not provide vpmovd2m instructions.
                return SuperStatics.ExtractMostSignificantBits(vector);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<uint> vector) {
                // .NET8 methods have hardware-accelerated. .NET8 does not provide vpmovd2m instructions.
                return SuperStatics.ExtractMostSignificantBits(vector);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<long> vector) {
                // .NET8 methods have hardware-accelerated. .NET8 does not provide vpmovq2m instructions.
                return SuperStatics.ExtractMostSignificantBits(vector);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<ulong> vector) {
                // .NET8 methods have hardware-accelerated. .NET8 does not provide vpmovq2m instructions.
                return SuperStatics.ExtractMostSignificantBits(vector);
            }


            /// <inheritdoc cref="IWVectorTraits512.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Floor(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Floor(Vector512<float> value) {
                return Avx512F.RoundScale(value, (byte)FloatRoundMode.ToNegativeInfinity);
            }

            /// <inheritdoc cref="IWVectorTraits512.Floor(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Floor(Vector512<double> value) {
                return Avx512F.RoundScale(value, (byte)FloatRoundMode.ToNegativeInfinity);
            }


            /// <inheritdoc cref="IWVectorTraits512.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{double}, Vector512{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Narrow(Vector512<double> lower, Vector512<double> upper) {
                return Avx512F.ConvertToVector256Single(lower).ToVector512Unsafe().WithUpper(Avx512F.ConvertToVector256Single(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{short}, Vector512{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Narrow(Vector512<short> lower, Vector512<short> upper) {
                return Avx512BW.ConvertToVector256SByte(lower).ToVector512Unsafe().WithUpper(Avx512BW.ConvertToVector256SByte(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{ushort}, Vector512{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Narrow(Vector512<ushort> lower, Vector512<ushort> upper) {
                return Avx512BW.ConvertToVector256Byte(lower).ToVector512Unsafe().WithUpper(Avx512BW.ConvertToVector256Byte(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{int}, Vector512{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Narrow(Vector512<int> lower, Vector512<int> upper) {
                return Avx512F.ConvertToVector256Int16(lower).ToVector512Unsafe().WithUpper(Avx512F.ConvertToVector256Int16(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{uint}, Vector512{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Narrow(Vector512<uint> lower, Vector512<uint> upper) {
                return Avx512F.ConvertToVector256UInt16(lower).ToVector512Unsafe().WithUpper(Avx512F.ConvertToVector256UInt16(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{long}, Vector512{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Narrow(Vector512<long> lower, Vector512<long> upper) {
                // return Vector512.Create(Avx512F.ConvertToVector256Int32(lower), Avx512F.ConvertToVector256Int32(upper)); // 2*vpmovqd, 2*vinsertf64x4
                // return Vector512.Narrow(lower, upper); // 2*vpmovqd, 1*vinsertf64x4
                return Avx512F.ConvertToVector256Int32(lower).ToVector512Unsafe().WithUpper(Avx512F.ConvertToVector256Int32(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{ulong}, Vector512{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Narrow(Vector512<ulong> lower, Vector512<ulong> upper) {
                // return Vector512.Create(Avx512F.ConvertToVector256UInt32(lower), Avx512F.ConvertToVector256UInt32(upper)); // 2*vpmovqd, 2*vinsertf64x4
                // return Vector512.Narrow(lower, upper); // 2*vpmovqd, 1*vinsertf64x4
                return Avx512F.ConvertToVector256UInt32(lower).ToVector512Unsafe().WithUpper(Avx512F.ConvertToVector256UInt32(upper));
            }


            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft(Vector512<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft(Vector512<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft(Vector512<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft(Vector512<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft(Vector512<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft(Vector512<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft(Vector512<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft(Vector512<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1) {
                var args0 = ShiftLeft_Args(dummy.AsByte(), shiftAmount, out var a1).AsSByte();
                args1 = a1.AsSByte();
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{byte}, int, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft_Args(Vector512<byte> dummy, int shiftAmount, out Vector512<byte> args1) {
                _ = dummy;
                shiftAmount &= 7;
                var args0 = Vector512.Create((uint)shiftAmount).AsByte();
                args1 = Vector512Constants.GetResidueMaskBits_Byte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{short}, int, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1) {
                _ = dummy;
                var args0 = Vector512.Create((short)(shiftAmount & 0x0F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Args(Vector512<ushort> dummy, int shiftAmount, out Vector512<ushort> args1) {
                _ = dummy;
                var args0 = Vector512.Create((ushort)(shiftAmount & 0x0F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{int}, int, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1) {
                _ = dummy;
                var args0 = Vector512.Create((int)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{uint}, int, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Args(Vector512<uint> dummy, int shiftAmount, out Vector512<uint> args1) {
                _ = dummy;
                var args0 = Vector512.Create((uint)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{long}, int, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1) {
                _ = dummy;
                var args0 = Vector512.Create((long)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{ulong}, int, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Args(Vector512<ulong> dummy, int shiftAmount, out Vector512<ulong> args1) {
                _ = dummy;
                var args0 = Vector512.Create((ulong)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                return ShiftLeft_Core(value.AsByte(), shiftAmount, args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft_Core(Vector512<byte> value, int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
                _ = shiftAmount;
                var t = Avx512F.And(value, args1).AsUInt32();
                return Avx512F.ShiftLeftLogicalVariable(t, args0.AsUInt32()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512BW.ShiftLeftLogicalVariable(value, args0.AsUInt16());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Core(Vector512<ushort> value, int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512BW.ShiftLeftLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512F.ShiftLeftLogicalVariable(value, args0.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Core(Vector512<uint> value, int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512F.ShiftLeftLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512F.ShiftLeftLogicalVariable(value, args0.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Core(Vector512<ulong> value, int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512F.ShiftLeftLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftLeft_Const(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft_Const(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                Vector512<byte> t = Avx512F.And(value, Vector512Constants.GetResidueMaskBits_Byte(shiftAmount));
                return Avx512F.ShiftLeftLogical(t.AsUInt32(), (byte)shiftAmount).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx512BW.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Const(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx512BW.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx512F.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Const(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx512F.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx512F.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Const(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx512F.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft_ConstCore(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = args0;
                _ = args1;
                return Avx512BW.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_ConstCore(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = args0;
                _ = args1;
                return Avx512BW.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = args0;
                _ = args1;
                return Avx512F.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_ConstCore(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
                _ = args0;
                _ = args1;
                return Avx512F.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = args0;
                _ = args1;
                return Avx512F.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_ConstCore(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = args0;
                _ = args1;
                return Avx512F.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft_Fast(Vector512<sbyte> value, int shiftAmount) {
                return ShiftLeft_Fast(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft_Fast(Vector512<byte> value, int shiftAmount) {
                Vector512<byte> t = Avx512F.And(value, Vector512Constants.GetResidueMaskBits_Byte(shiftAmount));
                return Avx512F.ShiftLeftLogical(t.AsUInt32(), (byte)shiftAmount).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Fast(Vector512<short> value, int shiftAmount) {
                return Avx512BW.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Fast(Vector512<ushort> value, int shiftAmount) {
                return Avx512BW.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Fast(Vector512<int> value, int shiftAmount) {
                return Avx512F.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Fast(Vector512<uint> value, int shiftAmount) {
                return Avx512F.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Fast(Vector512<long> value, int shiftAmount) {
                return Avx512F.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Fast(Vector512<ulong> value, int shiftAmount) {
                return Avx512F.ShiftLeftLogical(value, (byte)shiftAmount);
            }


            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic(Vector512<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic(Vector512<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic(Vector512<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic(Vector512<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1) {
                _ = dummy;
                shiftAmount &= 7;
                var args0 = Vector512.Create((int)shiftAmount).AsSByte();
                args1 = Vector512Constants.GetResidueMaskBits_SByte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{short}, int, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1) {
                _ = dummy;
                var args0 = Vector512.Create((short)(shiftAmount & 0x0F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{int}, int, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1) {
                _ = dummy;
                var args0 = Vector512.Create((int)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{long}, int, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1) {
                _ = dummy;
                var args0 = Vector512.Create((long)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                _ = shiftAmount;
                Vector512<sbyte> sign = Avx512BW.CompareGreaterThan(Vector512<sbyte>.Zero, value);
                Vector512<sbyte> shifted = Avx512F.ShiftRightLogicalVariable(value.AsUInt32(), args0.AsUInt32()).AsSByte();
                Vector512<sbyte> rt = ConditionalSelect(args1, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512BW.ShiftRightArithmeticVariable(value, args0.AsUInt16());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512F.ShiftRightArithmeticVariable(value, args0.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512F.ShiftRightArithmeticVariable(value, args0.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx512BW.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx512F.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx512F.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = args0;
                _ = args1;
                return Avx512BW.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = args0;
                _ = args1;
                return Avx512F.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = args0;
                _ = args1;
                return Avx512F.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Fast(Vector512<sbyte> value, int shiftAmount) {
                //return ShiftRightArithmetic_Fast_Widen(value, shiftAmount);
                return ShiftRightArithmetic_Fast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Fast_Widen(Vector512<sbyte> value, int shiftAmount) {
                Vector512<short> lowerToHigh = Avx512BW.ShiftLeftLogical(value.AsInt16(), 8);
                Vector512<short> lowerShifted = Avx512BW.ShiftRightArithmetic(lowerToHigh, (byte)shiftAmount);
                Vector512<sbyte> upper = Avx512BW.ShiftRightArithmetic(value.AsInt16(), (byte)shiftAmount).AsSByte();
                Vector512<sbyte> lower = Avx512BW.ShiftRightLogical(lowerShifted, 8).AsSByte();
                Vector512<sbyte> rt = Avx512F.Or(Avx512F.And(Vector512s<sbyte>.XyYMask, upper), lower);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Fast_Negative(Vector512<sbyte> value, int shiftAmount) {
                Vector512<sbyte> mask = Vector512Constants.GetResidueMaskBits_SByte(shiftAmount);
                Vector512<sbyte> shifted = Avx512BW.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsSByte();
                Vector512<sbyte> sign = Avx512BW.CompareGreaterThan(Vector512<sbyte>.Zero, value);
                Vector512<sbyte> rt = ConditionalSelect(mask, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_Fast(Vector512<short> value, int shiftAmount) {
                return Avx512BW.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Fast(Vector512<int> value, int shiftAmount) {
                return Avx512F.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Fast(Vector512<long> value, int shiftAmount) {
                return Avx512F.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Fast_Negative(Vector512<long> value, int shiftAmount) {
                Vector512<long> sign = Avx512F.CompareGreaterThan(Vector512<long>.Zero, value);
                byte shiftAmountLeft = (byte)(64 - shiftAmount);
                Vector512<long> rt = Avx512F.Or(Avx512F.ShiftRightLogical(value, (byte)shiftAmount), Avx512F.ShiftLeftLogical(sign, shiftAmountLeft));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical(Vector512<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical(Vector512<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical(Vector512<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical(Vector512<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical(Vector512<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical(Vector512<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical(Vector512<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical(Vector512<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1) {
                var args0 = ShiftRightLogical_Args(dummy.AsByte(), shiftAmount, out var a1).AsSByte();
                args1 = a1.AsSByte();
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{byte}, int, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Args(Vector512<byte> dummy, int shiftAmount, out Vector512<byte> args1) {
                _ = dummy;
                shiftAmount &= 7;
                var args0 = Vector512.Create((uint)shiftAmount).AsByte();
                args1 = Vector512Constants.GetResidueMaskBits_Byte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{short}, int, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1) {
                _ = dummy;
                var args0 = Vector512.Create((short)(shiftAmount & 0x0F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Args(Vector512<ushort> dummy, int shiftAmount, out Vector512<ushort> args1) {
                _ = dummy;
                var args0 = Vector512.Create((ushort)(shiftAmount & 0x0F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{int}, int, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1) {
                _ = dummy;
                var args0 = Vector512.Create((int)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{uint}, int, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Args(Vector512<uint> dummy, int shiftAmount, out Vector512<uint> args1) {
                _ = dummy;
                var args0 = Vector512.Create((uint)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{long}, int, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1) {
                _ = dummy;
                var args0 = Vector512.Create((long)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{ulong}, int, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Args(Vector512<ulong> dummy, int shiftAmount, out Vector512<ulong> args1) {
                _ = dummy;
                var args0 = Vector512.Create((ulong)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                return ShiftRightLogical_Core(value.AsByte(), shiftAmount, args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Core(Vector512<byte> value, int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
                _ = shiftAmount;
                var rt = Avx512BW.ShiftRightLogicalVariable(value.AsUInt32(), args0.AsUInt32()).AsByte();
                rt = Avx512F.And(rt, args1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512BW.ShiftRightLogicalVariable(value, args0.AsUInt16());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Core(Vector512<ushort> value, int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512BW.ShiftRightLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512F.ShiftRightLogicalVariable(value, args0.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Core(Vector512<uint> value, int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512F.ShiftRightLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512F.ShiftRightLogicalVariable(value, args0.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Core(Vector512<ulong> value, int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512F.ShiftRightLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightLogical_Const(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Const(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                Vector512<byte> mask = Vector512Constants.GetResidueMaskBits_Byte(shiftAmount);
                Vector512<byte> t = Avx512BW.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsByte();
                Vector512<byte> rt = Avx512F.And(t, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx512BW.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Const(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx512BW.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx512F.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Const(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx512F.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx512F.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Const(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx512F.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_ConstCore(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = args0;
                _ = args1;
                return Avx512BW.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_ConstCore(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = args0;
                _ = args1;
                return Avx512BW.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = args0;
                _ = args1;
                return Avx512F.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_ConstCore(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
                _ = args0;
                _ = args1;
                return Avx512F.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = args0;
                _ = args1;
                return Avx512F.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_ConstCore(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = args0;
                _ = args1;
                return Avx512F.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical_Fast(Vector512<sbyte> value, int shiftAmount) {
                return ShiftRightLogical_Fast(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Fast(Vector512<byte> value, int shiftAmount) {
                return ShiftRightLogical_Fast_FirstShift(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Fast_FirstAnd(Vector512<byte> value, int shiftAmount) {
                Vector512<byte> mask = Vector512Constants.GetMaskBits_Byte(shiftAmount);
                Vector512<byte> t = Avx512F.AndNot(mask, value);
                Vector512<byte> rt = Avx512BW.ShiftRightLogical(t.AsUInt16(), (byte)shiftAmount).AsByte();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Fast_FirstShift(Vector512<byte> value, int shiftAmount) {
                Vector512<byte> mask = Vector512Constants.GetResidueMaskBits_Byte(shiftAmount);
                Vector512<byte> t = Avx512BW.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsByte();
                Vector512<byte> rt = Avx512BW.And(t, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Fast(Vector512<short> value, int shiftAmount) {
                return Avx512BW.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Fast(Vector512<ushort> value, int shiftAmount) {
                return Avx512BW.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Fast(Vector512<int> value, int shiftAmount) {
                return Avx512F.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Fast(Vector512<uint> value, int shiftAmount) {
                return Avx512F.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Fast(Vector512<long> value, int shiftAmount) {
                return Avx512F.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Fast(Vector512<ulong> value, int shiftAmount) {
                return Avx512F.ShiftRightLogical(value, (byte)shiftAmount);
            }


            /// <inheritdoc cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
            public static TypeCodeFlags Shuffle_AcceleratedTypes {
                get {
                    return YShuffleInsert_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Shuffle(Vector512<float> vector, Vector512<int> indices) {
                return Shuffle(vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Shuffle(Vector512<double> vector, Vector512<long> indices) {
                return Shuffle(vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Shuffle(Vector512<sbyte> vector, Vector512<sbyte> indices) {
                return Shuffle(vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Shuffle(Vector512<byte> vector, Vector512<byte> indices) {
                Vector512<byte> mask = Avx512BW.CompareGreaterThan(Vector512.Create((byte)64), indices); // Unsigned compare: (i < 64)
                Vector512<byte> raw = YShuffleKernel(vector, indices);
                Vector512<byte> rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Shuffle(Vector512<short> vector, Vector512<short> indices) {
                return Shuffle(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Shuffle(Vector512<ushort> vector, Vector512<ushort> indices) {
                Vector512<ushort> mask = Avx512BW.CompareEqual(Avx512BW.ShiftRightLogical(indices, 5), Vector512<ushort>.Zero); // Unsigned compare: (i < 32)
                Vector512<ushort> raw = YShuffleKernel(vector, indices);
                Vector512<ushort> rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Shuffle(Vector512<int> vector, Vector512<int> indices) {
                return Shuffle(vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Shuffle(Vector512<uint> vector, Vector512<uint> indices) {
                Vector512<uint> mask = Avx512F.CompareEqual(Avx512F.ShiftRightLogical(indices, 4), Vector512<uint>.Zero); // Unsigned compare: (i < 16)
                Vector512<uint> raw = YShuffleKernel(vector, indices);
                Vector512<uint> rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Shuffle(Vector512<long> vector, Vector512<long> indices) {
                return Shuffle(vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Shuffle(Vector512<ulong> vector, Vector512<ulong> indices) {
                Vector512<ulong> mask = Avx512F.CompareEqual(Avx512F.ShiftRightLogical(indices, 3), Vector512<ulong>.Zero); // Unsigned compare: (i < 8)
                Vector512<ulong> raw = YShuffleKernel(vector, indices);
                Vector512<ulong> rt = Avx512F.And(raw, mask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1) {
                YShuffleInsert_Args(indices, out args0, out _, out args1);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1) {
                YShuffleInsert_Args(indices, out args0, out _, out args1);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1) {
                YShuffleInsert_Args(indices, out args0, out _, out args1);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1) {
                YShuffleInsert_Args(indices, out args0, out _, out args1);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1) {
                YShuffleInsert_Args(indices, out args0, out _, out args1);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1) {
                YShuffleInsert_Args(indices, out args0, out _, out args1);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1) {
                YShuffleInsert_Args(indices, out args0, out _, out args1);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1) {
                YShuffleInsert_Args(indices, out args0, out _, out args1);
            }


            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{float}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Shuffle_Core(Vector512<float> vector, Vector512<int> args0, Vector512<int> args1) {
                return Shuffle_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{double}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Shuffle_Core(Vector512<double> vector, Vector512<long> args0, Vector512<long> args1) {
                return Shuffle_Core(vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Shuffle_Core(Vector512<sbyte> vector, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                return Shuffle_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Shuffle_Core(Vector512<byte> vector, Vector512<byte> args0, Vector512<byte> args1) {
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = Avx512F.And(raw, args1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Shuffle_Core(Vector512<short> vector, Vector512<short> args0, Vector512<short> args1) {
                return Shuffle_Core(vector.AsUInt16(), args0.AsUInt16(), args1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Shuffle_Core(Vector512<ushort> vector, Vector512<ushort> args0, Vector512<ushort> args1) {
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = Avx512F.And(raw, args1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Shuffle_Core(Vector512<int> vector, Vector512<int> args0, Vector512<int> args1) {
                return Shuffle_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Shuffle_Core(Vector512<uint> vector, Vector512<uint> args0, Vector512<uint> args1) {
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = Avx512F.And(raw, args1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Shuffle_Core(Vector512<long> vector, Vector512<long> args0, Vector512<long> args1) {
                return Shuffle_Core(vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Shuffle_Core(Vector512<ulong> vector, Vector512<ulong> args0, Vector512<ulong> args1) {
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = Avx512F.And(raw, args1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Sum_AcceleratedTypes"/>
            public static TypeCodeFlags Sum_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum(Vector512<float> value) {
                Vector256<float> temp = Avx.Add(value.GetLower(), value.GetUpper());
                return WVectorTraits256Avx2.Statics.Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum(Vector512<double> value) {
                Vector256<double> temp = Avx.Add(value.GetLower(), value.GetUpper());
                return WVectorTraits256Avx2.Statics.Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum(Vector512<sbyte> value) {
                Vector256<sbyte> temp = Avx2.Add(value.GetLower(), value.GetUpper());
                return WVectorTraits256Avx2.Statics.Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum(Vector512<byte> value) {
                return (byte)Sum(value.AsSByte());
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum(Vector512<short> value) {
                Vector256<short> temp = Avx2.Add(value.GetLower(), value.GetUpper());
                return WVectorTraits256Avx2.Statics.Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum(Vector512<ushort> value) {
                return (ushort)Sum(value.AsInt16());
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum(Vector512<int> value) {
                Vector256<int> temp = Avx2.Add(value.GetLower(), value.GetUpper());
                return WVectorTraits256Avx2.Statics.Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum(Vector512<uint> value) {
                return (uint)Sum(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum(Vector512<long> value) {
                Vector256<long> temp = Avx2.Add(value.GetLower(), value.GetUpper());
                return WVectorTraits256Avx2.Statics.Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum(Vector512<ulong> value) {
                return (ulong)Sum(value.AsInt64());
            }


            /// <inheritdoc cref="IWVectorTraits512.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{float}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<float> source, out Vector512<double> lower, out Vector512<double> upper) {
                lower = Avx512F.ConvertToVector512Double(source.GetLower());
                upper = Avx512F.ConvertToVector512Double(source.GetUpper());
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{sbyte}, out Vector512{short}, out Vector512{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<sbyte> source, out Vector512<short> lower, out Vector512<short> upper) {
                lower = Avx512BW.ConvertToVector512Int16(source.GetLower());
                upper = Avx512BW.ConvertToVector512Int16(source.GetUpper());
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{byte}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<byte> source, out Vector512<ushort> lower, out Vector512<ushort> upper) {
                lower = Avx512BW.ConvertToVector512UInt16(source.GetLower());
                upper = Avx512BW.ConvertToVector512UInt16(source.GetUpper());
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{short}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<short> source, out Vector512<int> lower, out Vector512<int> upper) {
                lower = Avx512F.ConvertToVector512Int32(source.GetLower());
                upper = Avx512F.ConvertToVector512Int32(source.GetUpper());
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{ushort}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<ushort> source, out Vector512<uint> lower, out Vector512<uint> upper) {
                lower = Avx512F.ConvertToVector512UInt32(source.GetLower());
                upper = Avx512F.ConvertToVector512UInt32(source.GetUpper());
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{int}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<int> source, out Vector512<long> lower, out Vector512<long> upper) {
                lower = Avx512F.ConvertToVector512Int64(source.GetLower());
                upper = Avx512F.ConvertToVector512Int64(source.GetUpper());
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{uint}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<uint> source, out Vector512<ulong> lower, out Vector512<ulong> upper) {
                lower = Avx512F.ConvertToVector512UInt64(source.GetLower());
                upper = Avx512F.ConvertToVector512UInt64(source.GetUpper());
            }

#endif // NET8_0_OR_GREATER
        }

    }
}
