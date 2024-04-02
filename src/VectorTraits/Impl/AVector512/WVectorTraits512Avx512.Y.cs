using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector512 {
    using SuperStatics = WVectorTraits512Base.Statics;

    partial class WVectorTraits512Avx512 {

        partial class Statics {

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits512.YBitToByte_IsAccelerated"/>
            public static bool YBitToByte_IsAccelerated {
                get {
                    bool rt = true;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YBitToByte"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YBitToByte(ulong value) {
                Vector512<byte> a = Vector512.Create(value).AsByte();
                Vector512<byte> indices = Vector512Constants.YBitToByte_Shuffle_Indices;
                Vector512<byte> bitPosMask = Vector512Constants.MaskBitPosSerialRotate8;
                // Duplicate 8bit value to 64bit
                Vector512<byte> f = Avx512BW.Shuffle(a, indices);
                // Check bit.
                Vector512<byte> hit = BitwiseAnd(f, bitPosMask);
                Vector512<byte> rt = OnesComplement(Equals(hit, Vector512<byte>.Zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YBitToInt16_IsAccelerated"/>
            public static bool YBitToInt16_IsAccelerated {
                get {
                    bool rt = true;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YBitToInt16"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YBitToInt16(ulong value) {
                Vector512<short> bitPosMask = Vector512Constants.MaskBitPosSerialRotate16;
                // Duplicate 16bit value
                Vector512<short> a = Vector512.Create((ushort)value).AsInt16();
                // Check bit.
                Vector512<short> hit = BitwiseAnd(a, bitPosMask);
                Vector512<short> rt = OnesComplement(Equals(hit, Vector512<short>.Zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YBitToInt32_IsAccelerated"/>
            public static bool YBitToInt32_IsAccelerated {
                get {
                    bool rt = true;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YBitToInt32"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YBitToInt32(ulong value) {
                Vector512<int> bitPosMask = Vector512Constants.MaskBitPosSerialRotate32;
                // Duplicate 32bit value
                Vector512<int> a = Vector512.Create((uint)value).AsInt32();
                // Check bit.
                Vector512<int> hit = BitwiseAnd(a, bitPosMask);
                Vector512<int> rt = OnesComplement(Equals(hit, Vector512<int>.Zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YBitToInt64_IsAccelerated"/>
            public static bool YBitToInt64_IsAccelerated {
                get {
                    bool rt = true;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YBitToInt64"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YBitToInt64(ulong value) {
                Vector512<long> bitPosMask = Vector512Constants.MaskBitPosSerialRotate64;
                // Duplicate 64bit value
                Vector512<long> a = Vector512.Create((ulong)value).AsInt64();
                // Check bit.
                Vector512<long> hit = BitwiseAnd(a, bitPosMask);
                Vector512<long> rt = OnesComplement(Equals(hit, Vector512<long>.Zero));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YClamp_AcceleratedTypes"/>
            public static TypeCodeFlags YClamp_AcceleratedTypes {
                get {
                    return Max_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{float}, Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YClamp(Vector512<float> value, Vector512<float> amin, Vector512<float> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{double}, Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YClamp(Vector512<double> value, Vector512<double> amin, Vector512<double> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YClamp(Vector512<sbyte> value, Vector512<sbyte> amin, Vector512<sbyte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YClamp(Vector512<byte> value, Vector512<byte> amin, Vector512<byte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YClamp(Vector512<short> value, Vector512<short> amin, Vector512<short> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YClamp(Vector512<ushort> value, Vector512<ushort> amin, Vector512<ushort> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YClamp(Vector512<int> value, Vector512<int> amin, Vector512<int> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YClamp(Vector512<uint> value, Vector512<uint> amin, Vector512<uint> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YClamp(Vector512<long> value, Vector512<long> amin, Vector512<long> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits512.YClamp(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YClamp(Vector512<ulong> value, Vector512<ulong> amin, Vector512<ulong> amax) {
                return Min(Max(amin, value), amax);
            }


            /// <inheritdoc cref="IWVectorTraits512.YCopySign_AcceleratedTypes"/>
            public static TypeCodeFlags YCopySign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    rt |= (TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64); // & ShiftRightArithmetic_AcceleratedTypes
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YCopySign(Vector512<float> value, Vector512<float> sign) {
                Vector512<float> signMask = Vector512Constants.Single_SignMask;
                Vector512<float> rt = ConditionalSelect(signMask, sign, value);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YCopySign(Vector512<double> value, Vector512<double> sign) {
                Vector512<double> signMask = Vector512Constants.Double_SignMask;
                Vector512<double> rt = ConditionalSelect(signMask, sign, value);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YCopySign(Vector512<sbyte> value, Vector512<sbyte> sign) {
                //Vector512<sbyte> t = ShiftRightArithmetic_Const(Avx512.Xor(value, sign), 7);
                Vector512<sbyte> t = Avx512BW.CompareGreaterThan(Vector512<sbyte>.Zero, Avx512F.Xor(value, sign));
                Vector512<sbyte> rt = Avx512BW.Subtract(Avx512F.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YCopySign(Vector512<short> value, Vector512<short> sign) {
                Vector512<short> t = Avx512BW.ShiftRightArithmetic(Avx512F.Xor(value, sign), 15);
                Vector512<short> rt = Avx512BW.Subtract(Avx512F.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YCopySign(Vector512<int> value, Vector512<int> sign) {
                Vector512<int> t = Avx512F.ShiftRightArithmetic(Avx512F.Xor(value, sign), 31);
                Vector512<int> rt = Avx512F.Subtract(Avx512F.Xor(value, t), t);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YCopySign(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YCopySign(Vector512<long> value, Vector512<long> sign) {
                //Vector512<long> t = ShiftRightArithmetic_Const(Avx512.Xor(value, sign), 63);
                Vector512<long> t = Avx512F.CompareGreaterThan(Vector512<long>.Zero, Avx512F.Xor(value, sign));
                Vector512<long> rt = Avx512F.Subtract(Avx512F.Xor(value, t), t);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YMaxNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMaxNumber_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = YIsNaN_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YMaxNumber(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YMaxNumber(Vector512<float> left, Vector512<float> right) {
                Vector512<float> mask = BitwiseOr(GreaterThan(left, right), YIsNaN(right).AsSingle());
                mask = BitwiseOr(mask, BitwiseAnd(Equals(left, right), YIsNegative(right).AsSingle()));
                Vector512<float> rt = ConditionalSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YMaxNumber(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YMaxNumber(Vector512<double> left, Vector512<double> right) {
                Vector512<double> mask = BitwiseOr(GreaterThan(left, right), YIsNaN(right).AsDouble());
                mask = BitwiseOr(mask, BitwiseAnd(Equals(left, right), YIsNegative(right).AsDouble()));
                Vector512<double> rt = ConditionalSelect(mask, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YMinNumber_AcceleratedTypes"/>
            public static TypeCodeFlags YMinNumber_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = YIsNaN_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YMinNumber(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YMinNumber(Vector512<float> left, Vector512<float> right) {
                Vector512<float> mask = BitwiseOr(LessThan(left, right), YIsNaN(right).AsSingle());
                mask = BitwiseOr(mask, BitwiseAnd(Equals(left, right), YIsNegative(left).AsSingle()));
                Vector512<float> rt = ConditionalSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YMinNumber(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YMinNumber(Vector512<double> left, Vector512<double> right) {
                Vector512<double> mask = BitwiseOr(LessThan(left, right), YIsNaN(right).AsDouble());
                mask = BitwiseOr(mask, BitwiseAnd(Equals(left, right), YIsNegative(left).AsDouble()));
                Vector512<double> rt =  ConditionalSelect(mask, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{short}, Vector512{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YNarrowSaturate(Vector512<short> lower, Vector512<short> upper) {
                return YNarrowSaturate_Pack(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{short}, Vector512{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YNarrowSaturate_Convert(Vector512<short> lower, Vector512<short> upper) {
                return Vector512.Create(Avx512BW.ConvertToVector256SByteWithSaturation(lower), Avx512BW.ConvertToVector256SByteWithSaturation(upper));
                // total latency: 11(4*2+3), total throughput CPI: 5(2*2+1)
                //
                //__m256i _mm512_cvtsepi16_epi8 (__m512i a)
                //#include <immintrin.h>
                //Instruction: vpmovswb ymm, zmm
                //CPUID Flags: AVX512BW
                //Latency and Throughput
                //Architecture	Latency	Throughput (CPI)
                //Icelake Intel Core	-	2
                //Icelake Xeon	4	2
                //Sapphire Rapids	4	2
                //Skylake	4	2
                //
                //__m512i _mm512_inserti64x4 (__m512i a, __m256i b, int imm8)
                //#include <immintrin.h>
                //Instruction: vinserti64x4 zmm, zmm, ymm, imm8
                //CPUID Flags: AVX512F
                //Latency and Throughput
                //Architecture	Latency	Throughput (CPI)
                //Icelake Intel Core	3	1
                //Icelake Xeon	3	1
                //Sapphire Rapids	3	1
                //Skylake	3	1
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{short}, Vector512{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YNarrowSaturate_Pack(Vector512<short> lower, Vector512<short> upper) {
                Vector512<long> index = Vector512Constants.NarrowSaturate_Permute_Index64; // _mm512_load_si512
                Vector512<sbyte> raw = Avx512BW.PackSignedSaturate(lower, upper); // _mm512_packs_epi16
                Vector512<sbyte> rt = Avx512F.PermuteVar8x64(raw.AsInt64(), index.AsInt64()).AsSByte(); // _mm512_permutexvar_epi64
                return rt;
                // total latency without load: 4~8, total throughput CPI: 2
                // total latency with load: 11~16, total throughput CPI: 2.5
                //
                //__m512i _mm512_packs_epi16 (__m512i a, __m512i b)
                //#include <immintrin.h>
                //Instruction: vpacksswb zmm, zmm, zmm
                //CPUID Flags: AVX512BW
                //Latency and Throughput
                //Architecture	Latency	Throughput (CPI)
                //Icelake Intel Core	-	1
                //Icelake Xeon	3	1
                //Sapphire Rapids	5	1
                //Skylake	1	1
                //
                //__m512i _mm512_permutexvar_epi64 (__m512i idx, __m512i a)
                //#include <immintrin.h>
                //Instruction: vpermq zmm, zmm, zmm
                //CPUID Flags: AVX512F
                //Latency and Throughput
                //Architecture	Latency	Throughput (CPI)
                //Icelake Intel Core	3	1
                //Icelake Xeon	3	1
                //Sapphire Rapids	3	1
                //Skylake	3	1
                // ===
                //__m512i _mm512_load_si512 (void const* mem_addr)
                //#include <immintrin.h>
                //Instruction: vmovdqa32 zmm, m512
                //CPUID Flags: AVX512F
                //Latency and Throughput
                //Architecture	Latency	Throughput (CPI)
                //Icelake Intel Core	8	0.5
                //Icelake Xeon	7	0.58
                //Sapphire Rapids	8	0.5
                //Skylake	8	0.5
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{ushort}, Vector512{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YNarrowSaturate(Vector512<ushort> lower, Vector512<ushort> upper) {
                return YNarrowSaturate_Convert(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{ushort}, Vector512{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YNarrowSaturate_Convert(Vector512<ushort> lower, Vector512<ushort> upper) {
                return Vector512.Create(Avx512BW.ConvertToVector256ByteWithSaturation(lower), Avx512BW.ConvertToVector256ByteWithSaturation(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{ushort}, Vector512{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YNarrowSaturate_Pack(Vector512<ushort> lower, Vector512<ushort> upper) {
                // Vector512<ushort> amax = Vector512s<ushort>.VMaxByte;
                Vector512<ushort> amax = Vector512.Create((ushort)byte.MaxValue);
                Vector512<long> index = Vector512Constants.NarrowSaturate_Permute_Index64;
                Vector512<byte> raw = Avx512BW.PackUnsignedSaturate(Avx512BW.Min(lower, amax).AsInt16(), Avx512BW.Min(upper, amax).AsInt16());
                Vector512<byte> rt = Avx512F.PermuteVar8x64(raw.AsInt64(), index.AsInt64()).AsByte();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{int}, Vector512{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YNarrowSaturate(Vector512<int> lower, Vector512<int> upper) {
                return YNarrowSaturate_Pack(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{int}, Vector512{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YNarrowSaturate_Convert(Vector512<int> lower, Vector512<int> upper) {
                return Vector512.Create(Avx512F.ConvertToVector256Int16WithSaturation(lower), Avx512F.ConvertToVector256Int16WithSaturation(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{int}, Vector512{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YNarrowSaturate_Pack(Vector512<int> lower, Vector512<int> upper) {
                Vector512<long> index = Vector512Constants.NarrowSaturate_Permute_Index64; // _mm512_load_si512
                Vector512<short> raw = Avx512BW.PackSignedSaturate(lower, upper);
                Vector512<short> rt = Avx512F.PermuteVar8x64(raw.AsInt64(), index.AsInt64()).AsInt16();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{uint}, Vector512{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YNarrowSaturate(Vector512<uint> lower, Vector512<uint> upper) {
                return YNarrowSaturate_Convert(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{uint}, Vector512{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YNarrowSaturate_Convert(Vector512<uint> lower, Vector512<uint> upper) {
                return Vector512.Create(Avx512F.ConvertToVector256UInt16WithSaturation(lower), Avx512F.ConvertToVector256UInt16WithSaturation(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{uint}, Vector512{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YNarrowSaturate_Pack(Vector512<uint> lower, Vector512<uint> upper) {
                //Vector512<uint> amax = Vector512s<uint>.VMaxUInt16;
                Vector512<uint> amax = Vector512.Create((uint)ushort.MaxValue);
                Vector512<long> index = Vector512Constants.NarrowSaturate_Permute_Index64;
                Vector512<ushort> raw = Avx512BW.PackUnsignedSaturate(Avx512F.Min(lower, amax).AsInt32(), Avx512F.Min(upper, amax).AsInt32());
                Vector512<ushort> rt = Avx512F.PermuteVar8x64(raw.AsInt64(), index.AsInt64()).AsUInt16();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{long}, Vector512{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YNarrowSaturate(Vector512<long> lower, Vector512<long> upper) {
                return YNarrowSaturate_Convert(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{long}, Vector512{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YNarrowSaturate_Clamp(Vector512<long> lower, Vector512<long> upper) {
                //Vector512<long> amin = Vector512s<long>.VMinInt32;
                //Vector512<long> amax = Vector512s<long>.VMaxInt32;
                Vector512<long> amin = Vector512Constants.Int64_VMinInt32;
                Vector512<long> amax = Vector512Constants.Int64_VMaxInt32;
                Vector512<long> l = YClamp(lower, amin, amax);
                Vector512<long> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{long}, Vector512{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YNarrowSaturate_Convert(Vector512<long> lower, Vector512<long> upper) {
                return Vector512.Create(Avx512F.ConvertToVector256Int32WithSaturation(lower), Avx512F.ConvertToVector256Int32WithSaturation(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{ulong}, Vector512{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YNarrowSaturate(Vector512<ulong> lower, Vector512<ulong> upper) {
                return YNarrowSaturate_Convert(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{ulong}, Vector512{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YNarrowSaturate_Clamp(Vector512<ulong> lower, Vector512<ulong> upper) {
                //Vector512<ulong> amax = Vector512s<ulong>.VMaxUInt32;
                Vector512<ulong> amax = Vector512Constants.Int64_VMaxUInt32.AsUInt64();
                Vector512<ulong> l = Min(lower, amax);
                Vector512<ulong> u = Min(upper, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturate(Vector512{ulong}, Vector512{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YNarrowSaturate_Convert(Vector512<ulong> lower, Vector512<ulong> upper) {
                return Vector512.Create(Avx512F.ConvertToVector256UInt32WithSaturation(lower), Avx512F.ConvertToVector256UInt32WithSaturation(upper));
            }


            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{short}, Vector512{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YNarrowSaturateUnsigned(Vector512<short> lower, Vector512<short> upper) {
                return YNarrowSaturateUnsigned_Pack(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{short}, Vector512{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YNarrowSaturateUnsigned_Convert(Vector512<short> lower, Vector512<short> upper) {
                Vector512<short> zero = Vector512<short>.Zero;
                Vector512<ushort> l = Avx512BW.Max(lower, zero).AsUInt16();
                Vector512<ushort> u = Avx512BW.Max(upper, zero).AsUInt16();
                return YNarrowSaturate_Convert(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{short}, Vector512{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YNarrowSaturateUnsigned_Pack(Vector512<short> lower, Vector512<short> upper) {
                Vector512<long> index = Vector512Constants.NarrowSaturate_Permute_Index64;
                Vector512<byte> raw = Avx512BW.PackUnsignedSaturate(lower, upper);
                Vector512<byte> rt = Avx512F.PermuteVar8x64(raw.AsInt64(), index.AsInt64()).AsByte();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{int}, Vector512{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YNarrowSaturateUnsigned(Vector512<int> lower, Vector512<int> upper) {
                return YNarrowSaturateUnsigned_Pack(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{int}, Vector512{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YNarrowSaturateUnsigned_Convert(Vector512<int> lower, Vector512<int> upper) {
                Vector512<int> zero = Vector512<int>.Zero;
                Vector512<uint> l = Avx512F.Max(lower, zero).AsUInt32();
                Vector512<uint> u = Avx512F.Max(upper, zero).AsUInt32();
                return YNarrowSaturate_Convert(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{int}, Vector512{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YNarrowSaturateUnsigned_Pack(Vector512<int> lower, Vector512<int> upper) {
                Vector512<long> index = Vector512Constants.NarrowSaturate_Permute_Index64;
                Vector512<ushort> raw = Avx512BW.PackUnsignedSaturate(lower, upper);
                Vector512<ushort> rt = Avx512F.PermuteVar8x64(raw.AsInt64(), index.AsInt64()).AsUInt16();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{long}, Vector512{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YNarrowSaturateUnsigned(Vector512<long> lower, Vector512<long> upper) {
                return YNarrowSaturateUnsigned_Convert(lower, upper);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{long}, Vector512{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YNarrowSaturateUnsigned_Clamp(Vector512<long> lower, Vector512<long> upper) {
                Vector512<long> amin = Vector512<long>.Zero;
                //Vector512<long> amax = Vector512s<long>.VMaxUInt32;
                Vector512<long> amax = Vector512Constants.Int64_VMaxUInt32;
                Vector512<ulong> l = YClamp(lower, amin, amax).AsUInt64();
                Vector512<ulong> u = YClamp(upper, amin, amax).AsUInt64();
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits512.YNarrowSaturateUnsigned(Vector512{long}, Vector512{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YNarrowSaturateUnsigned_Convert(Vector512<long> lower, Vector512<long> upper) {
                Vector512<long> zero = Vector512<long>.Zero;
                Vector512<ulong> l = Avx512F.Max(lower, zero).AsUInt64();
                Vector512<ulong> u = Avx512F.Max(upper, zero).AsUInt64();
                return YNarrowSaturate_Convert(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits512.YOrNot_AcceleratedTypes"/>
            public static TypeCodeFlags YOrNot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YOrNot{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> YOrNot<T>(Vector512<T> left, Vector512<T> right) where T : struct {
                return Avx512F.TernaryLogic(left.AsInt64(), right.AsInt64(), right.AsInt64(), TernaryLogicControl.Or_A_NotB).As<long, T>();
                //Vector512<T> right2 = OnesComplement(right);
                //Vector512<T> rt = BitwiseOr(left, right2);
                //return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YRoundToEven_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToEven(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YRoundToEven(Vector512<float> value) {
                return Avx512F.RoundScale(value, (byte)FloatRoundMode.ToEven);
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToEven(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YRoundToEven(Vector512<double> value) {
                return Avx512F.RoundScale(value, (byte)FloatRoundMode.ToEven);
            }


            /// <inheritdoc cref="IWVectorTraits512.YRoundToZero_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToZero(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YRoundToZero(Vector512<float> value) {
                return Avx512F.RoundScale(value, (byte)FloatRoundMode.ToZero);
            }

            /// <inheritdoc cref="IWVectorTraits512.YRoundToZero(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YRoundToZero(Vector512<double> value) {
                return Avx512F.RoundScale(value, (byte)FloatRoundMode.ToZero);
            }


#endif // NET8_0_OR_GREATER
        }
    }
}
