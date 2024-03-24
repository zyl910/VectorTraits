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
                        if (!String.IsNullOrEmpty(rt)) {
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
/*

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
                return Avx.Ceiling(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.Ceiling(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Ceiling(Vector512<double> value) {
                return Avx.Ceiling(value);
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
                return ConvertToDouble_Bcl(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Bcl(Vector512<long> value) {
                // From: src/libraries/System.Private.CoreLib/src/System/Runtime/Intrinsics/Vector512.cs
                // Based on __m512d int64_to_double_fast_precise(const __m512i v)
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                Vector512<int> lowerBits;
                lowerBits = value.AsInt32();
                lowerBits = Avx512.Blend(lowerBits, Vector512.Create(ScalarConstants.DoubleVal_2Pow52).AsInt32(), 0b10101010); // Blend the 32 lowest significant bits of vector with the bit representation of double(2^52)
                Vector512<long> upperBits = Avx512.ShiftRightLogical(value, 32);                                               // Extract the 32 most significant bits of vector
                upperBits = Avx512.Xor(upperBits, Vector512.Create(ScalarConstants.DoubleVal_2Pow84_2Pow63).AsInt64());        // Flip the msb of upperBits and blend with the bit representation of double(2^84 + 2^63)
                Vector512<double> result = Avx.Subtract(upperBits.AsDouble(), Vector512.Create(ScalarConstants.DoubleVal_2Pow84_2Pow63_2Pow52)); // Compute in double precision: (upper - (2^84 + 2^63 + 2^52)) + lower
                return Avx.Add(result, lowerBits.AsDouble());
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Bcl_Wim(Vector512<long> value) {
                // Same ConvertToDouble_Bcl.
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 19, 2016 at 12:51 wim
                //__m512d int64_to_double_fast_precise(const __m512i v) {
                //    __m512i magic_i_lo   = _mm512_set1_epi64x(0x4330000000000000);                /* 2^52               encoded as floating-point  */
                //    __m512i magic_i_hi32 = _mm512_set1_epi64x(0x4530000080000000);                /* 2^84 + 2^63        encoded as floating-point  */
                //    __m512i magic_i_all  = _mm512_set1_epi64x(0x4530000080100000);                /* 2^84 + 2^63 + 2^52 encoded as floating-point  */
                //    __m512d magic_d_all  = _mm512_castsi512_pd(magic_i_all);
                //    __m512i v_lo         = _mm512_blend_epi32(magic_i_lo, v, 0b01010101);         /* Blend the 32 lowest significant bits of v with magic_int_lo                                                   */
                //    __m512i v_hi         = _mm512_srli_epi64(v, 32);                              /* Extract the 32 most significant bits of v                                                                     */
                //            v_hi         = _mm512_xor_si512(v_hi, magic_i_hi32);                  /* Flip the msb of v_hi and blend with 0x45300000                                                                */
                //    __m512d v_hi_dbl     = _mm512_sub_pd(_mm512_castsi512_pd(v_hi), magic_d_all); /* Compute in double precision:                                                                                  */
                //    __m512d result       = _mm512_add_pd(v_hi_dbl, _mm512_castsi512_pd(v_lo));    /* (v_hi - magic_d_all) + v_lo  Do not assume associativity of floating point addition !!                        */
                //            return result;                                                        /* With gcc use -O3, then -fno-associative-math is default. Do not use -Ofast, which enables -fassociative-math! */
                //}
/*
                Vector512<long> magic_i_lo = Vector512.Create(0x43300000_00000000);   // 2^52               encoded as floating-point
                Vector512<long> magic_i_hi32 = Vector512.Create(0x45300000_80000000); // 2^84 + 2^63        encoded as floating-point
                Vector512<long> magic_i_all = Vector512.Create(0x45300000_80100000);  // 2^84 + 2^63 + 2^52 encoded as floating-point
                Vector512<double> magic_d_all = magic_i_all.AsDouble();
                Vector512<int> v_lo = Avx512.Blend(value.AsInt32(), magic_i_lo.AsInt32(), 0b10101010); // Blend the 32 lowest significant bits of v with magic_int_lo (double(2^52))
                Vector512<long> v_hi = Avx512.ShiftRightLogical(value, 32);                            // Extract the 32 most significant bits of v
                v_hi = Avx512.Xor(v_hi, magic_i_hi32);                                                 // Flip the msb of v_hi and blend with magic_i_hi32 (double(2^84 + 2^63))
                Vector512<double> v_hi_dbl = Avx.Subtract(v_hi.AsDouble(), magic_d_all);             // Compute in double precision:
                Vector512<double> result = Avx.Add(v_hi_dbl, v_lo.AsDouble());                       // (v_hi - (2^84 + 2^63 + 2^52)) + v_lo  Do not assume associativity of floating point addition !!
                return result;
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_HwScalar(Vector512<long> value) {
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 19, 2016 at 12:51 wim
                // __m512d int64_to_double_based_on_cvtsi2sd(const __m512i v){
                //     __m128d zero         = _mm_setzero_pd();                            /* to avoid uninitialized variables in_mm_cvtsi64_sd                       */
                //     __m128i v_lo         = _mm512_castsi512_si128(v);
                //     __m128i v_hi         = _mm512_extracti128_si512(v,1);
                //     __m128d v_0          = _mm_cvtsi64_sd(zero,_mm_cvtsi128_si64(v_lo));
                //     __m128d v_2          = _mm_cvtsi64_sd(zero,_mm_cvtsi128_si64(v_hi));
                //     __m128d v_1          = _mm_cvtsi64_sd(zero,_mm_extract_epi64(v_lo,1));
                //     __m128d v_3          = _mm_cvtsi64_sd(zero,_mm_extract_epi64(v_hi,1));
                //     __m128d v_01         = _mm_unpacklo_pd(v_0,v_1);
                //     __m128d v_23         = _mm_unpacklo_pd(v_2,v_3);
                //     __m512d v_dbl        = _mm512_castpd128_pd512(v_01);
                //             v_dbl        = _mm512_insertf128_pd(v_dbl,v_23,1);
                //     return v_dbl;
                // }
/*
                if (Sse2.X64.IsSupported && Sse41.X64.IsSupported) {
                    Vector128<double> zero = Vector128<double>.Zero;
                    Vector128<long> v_lo = value.GetLower();
                    Vector128<long> v_hi = value.GetUpper();
                    Vector128<double> v_0 = Sse2.X64.ConvertScalarToVector128Double(zero, Sse2.X64.ConvertToInt64(v_lo));
                    Vector128<double> v_2 = Sse2.X64.ConvertScalarToVector128Double(zero, Sse2.X64.ConvertToInt64(v_hi));
                    Vector128<double> v_1 = Sse2.X64.ConvertScalarToVector128Double(zero, Sse41.X64.Extract(v_lo, 1));
                    Vector128<double> v_3 = Sse2.X64.ConvertScalarToVector128Double(zero, Sse41.X64.Extract(v_hi, 1));
                    Vector128<double> v_01 = Sse2.UnpackLow(v_0, v_1);
                    Vector128<double> v_23 = Sse2.UnpackLow(v_2, v_3);
                    Vector512<double> result = Vector512.Create(v_01, v_23);
                    return result;
                } else {
                    return SuperStatics.ConvertToDouble(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_Range52(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Range52(Vector512<long> value) {
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 14, 2016 at 17:23 Mysticial
                // inline __m512d int64_to_double512(__m512i x){
                //     /*  Mysticial's fast int64_to_double. Works for inputs in the range: (-2^51, 2^51)  */
                //     x = _mm512_add_epi64(x, _mm512_castpd_si512(_mm512_set1_pd(0x0018000000000000)));
                //     return _mm512_sub_pd(_mm512_castsi512_pd(x), _mm512_set1_pd(0x0018000000000000));
                // }
                // BitConverter.DoubleToInt64Bits((double)0x0018000000000000).ToString("X") = "4338000000000000"
/*
                Vector512<long> magicNumber = Vector512.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51).AsInt64(); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector512<long> x = Avx512.Add(value, magicNumber);
                Vector512<double> result = Avx.Subtract(x.AsDouble(), magicNumber.AsDouble());
                return result;
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble(Vector512<ulong> value) {
                return ConvertToDouble_Bcl(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Bcl(Vector512<ulong> value) {
                // From: src/libraries/System.Private.CoreLib/src/System/Runtime/Intrinsics/Vector512.cs
                // Based on __m512d uint64_to_double_fast_precise(const __m512i v)
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                Vector512<uint> lowerBits;
                lowerBits = value.AsUInt32();
                lowerBits = Avx512.Blend(lowerBits, Vector512.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt32(), 0b10101010); // Blend the 32 lowest significant bits of vector with the bit representation of double(2^52)                                                 */
/*
                Vector512<ulong> upperBits = Avx512.ShiftRightLogical(value, 32);                                               // Extract the 32 most significant bits of vector
                upperBits = Avx512.Xor(upperBits, Vector512.Create(ScalarConstants.DoubleVal_2Pow84).AsUInt64());               // Blend upperBits with the bit representation of double(2^84)
                Vector512<double> result = Avx.Subtract(upperBits.AsDouble(), Vector512.Create(ScalarConstants.DoubleVal_2Pow84_2Pow52)); // Compute in double precision: (upper - (2^84 + 2^52)) + lower
                return Avx.Add(result, lowerBits.AsDouble());
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Bcl_Wim(Vector512<ulong> value) {
                // Same ConvertToDouble_Bcl.
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 19, 2016 at 12:51 wim
                //__m512d uint64_to_double_fast_precise(const __m512i v) {
                //    __m512i magic_i_lo   = _mm512_set1_epi64x(0x4330000000000000);                /* 2^52        encoded as floating-point  */
                //    __m512i magic_i_hi32 = _mm512_set1_epi64x(0x4530000000000000);                /* 2^84        encoded as floating-point  */
                //    __m512i magic_i_all  = _mm512_set1_epi64x(0x4530000000100000);                /* 2^84 + 2^52 encoded as floating-point  */
                //    __m512d magic_d_all  = _mm512_castsi512_pd(magic_i_all);
                //    __m512i v_lo         = _mm512_blend_epi32(magic_i_lo, v, 0b01010101);         /* Blend the 32 lowest significant bits of v with magic_int_lo                                                   */
                //    __m512i v_hi         = _mm512_srli_epi64(v, 32);                              /* Extract the 32 most significant bits of v                                                                     */
                //            v_hi         = _mm512_xor_si512(v_hi, magic_i_hi32);                  /* Blend v_hi with 0x45300000                                                                                    */
                //    __m512d v_hi_dbl     = _mm512_sub_pd(_mm512_castsi512_pd(v_hi), magic_d_all); /* Compute in double precision:                                                                                  */
                //    __m512d result       = _mm512_add_pd(v_hi_dbl, _mm512_castsi512_pd(v_lo));    /* (v_hi - magic_d_all) + v_lo  Do not assume associativity of floating point addition !!                        */
                //            return result;                                                        /* With gcc use -O3, then -fno-associative-math is default. Do not use -Ofast, which enables -fassociative-math! */
                //}
/*                Vector512<long> magic_i_lo = Vector512.Create(0x43300000_00000000);   // 2^52        encoded as floating-point
                Vector512<long> magic_i_hi32 = Vector512.Create(0x45300000_00000000); // 2^84        encoded as floating-point
                Vector512<long> magic_i_all = Vector512.Create(0x45300000_00100000);  // 2^84 + 2^52 encoded as floating-point
                Vector512<double> magic_d_all = magic_i_all.AsDouble();
                Vector512<int> v_lo = Avx512.Blend(value.AsInt32(), magic_i_lo.AsInt32(), 0b10101010); // Blend the 32 lowest significant bits of v with magic_int_lo (double(2^52))
                Vector512<long> v_hi = Avx512.ShiftRightLogical(value, 32).AsInt64();                  // Extract the 32 most significant bits of v
                v_hi = Avx512.Xor(v_hi, magic_i_hi32);                                                 // Blend v_hi with magic_i_hi32 (double(2^84))
                Vector512<double> v_hi_dbl = Avx.Subtract(v_hi.AsDouble(), magic_d_all);             // Compute in double precision:
                Vector512<double> result = Avx.Add(v_hi_dbl, v_lo.AsDouble());                       // (v_hi - magic_d_all) + v_lo  Do not assume associativity of floating point addition !!
                return result;
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_Range52(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Range52(Vector512<ulong> value) {
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 14, 2016 at 17:23 Mysticial
                // inline __m512d uint64_to_double512(__m512i x){
                //     /*  Mysticial's fast uint64_to_double. Works for inputs in the range: [0, 2^52)     */
                //     x = _mm512_or_si512(x, _mm512_castpd_si512(_mm512_set1_pd(0x0010000000000000)));
                //     return _mm512_sub_pd(_mm512_castsi512_pd(x), _mm512_set1_pd(0x0010000000000000));
                // }
                // BitConverter.DoubleToInt64Bits((double)0x0010000000000000).ToString("X") = "4330000000000000"
/*                Vector512<ulong> magicNumber = Vector512.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt64(); // Double value: pow(2, 52)
                Vector512<ulong> x = Avx512.Or(value, magicNumber);
                Vector512<double> result = Avx.Subtract(x.AsDouble(), magicNumber.AsDouble());
                return result;
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
                return Avx.ConvertToVector512Int32WithTruncation(value);
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    //TypeCodeFlags rt = SuperStatics.ConvertToInt64_AcceleratedTypes;
                    TypeCodeFlags rt = TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64(Vector512<double> value) {
                // return SuperStatics.ConvertToInt64(value);
                // return ConvertToInt64_HwScalar(value);
                return ConvertToInt64_ShiftVarFix(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_HwScalar(Vector512<double> value) {
                if (Sse2.X64.IsSupported) {
                    Vector512<double> valueOdd = Avx512.Permute4x64(value, (byte)ShuffleControlG4.YYWW);
                    long v_0 = Sse2.X64.ConvertToInt64WithTruncation(value.GetLower());
                    long v_2 = Sse2.X64.ConvertToInt64WithTruncation(value.GetUpper());
                    long v_1 = Sse2.X64.ConvertToInt64WithTruncation(valueOdd.GetLower());
                    long v_3 = Sse2.X64.ConvertToInt64WithTruncation(valueOdd.GetUpper());
                    Vector512<long> result = Vector512.Create(v_0, v_1, v_2, v_3);
                    return result;
                } else {
                    return SuperStatics.ConvertToInt64(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64(Vector512{double})"/>
            /// <remarks>Input range is `[-pow(2,63), pow(2,63))`. Out of range results in `0`.</remarks>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_ShiftVar(Vector512<double> value) {
                // From Veloctor . MIT
                // https://github.com/Veloctor/Int128/blob/main/include/AVX2Ext.h
                // inline __m512i double_to_int64_fast(const __m512d v) //13 instructions
                // {
                // 	//constants
                // 	__m512i mat_mask = _mm512_set1_epi64x(0x0FFFFFFFFFFFFF);	//0_00000000000_1111111111111111111111111111111111111111111111111111
                // 	__m512i hidden_1 = _mm512_set1_epi64x(0x10000000000000);	//0_00000000001_0000000000000000000000000000000000000000000000000000
                // 	__m512i exp_bias = _mm512_set1_epi64x(1023LL + 52);			//0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                // 	#define zero512 _mm512_setzero_si512()
                // 	//majik operations										  //Latency, Throughput(references IceLake)
                // 	__m512i bin = _mm512_castpd_si512(v);
                // 	__m512i negative = _mm512_cmpgt_epi64(zero512, bin);			//3,1
                // 	__m512i mat = _mm512_and_si512(bin, mat_mask);					//1,1/3
                // 	mat = _mm512_or_si512(mat, hidden_1);							//1,1/3
                // 	__m512i exp_enc = _mm512_slli_epi64(bin, 1);					//1,1/2
                // 	exp_enc = _mm512_srli_epi64(exp_enc, 53);						//1,1/2
                // 	__m512i exp_frac = _mm512_sub_epi64(exp_enc, exp_bias);			//1,1/3
                // 	__m512i msl = _mm512_sllv_epi64(mat, exp_frac);					//1,1/2
                // 	__m512i exp_frac_n = _mm512_sub_epi64(zero512, exp_frac);		//1,1/3
                // 	__m512i msr = _mm512_srlv_epi64(mat, exp_frac_n);				//1,1/2
                // 	__m512i exp_is_pos = _mm512_cmpgt_epi64(exp_frac, zero512);		//3,1
                // 	__m512i result_abs = _mm512_blendv_epi8(msr, msl, exp_is_pos);	//2,1
                // 	__m512i result = _mm512_xor_si512(result_abs, negative);		//1,1/3
                // 	result = _mm512_sub_epi64(result, negative);					//1,1/3
                // 	return result;	//total latency: 18, total throughput CPI: 7
                // }
                //constants
                Vector512<long> mat_mask = Vector512.Create(ScalarConstants.DoubleVal_MantissaMask).AsInt64();  //0_00000000000_1111111111111111111111111111111111111111111111111111
                Vector512<long> hidden_1 = Vector512.Create(ScalarConstants.IntDbl_2Pow52).AsInt64();  //0_00000000001_0000000000000000000000000000000000000000000000000000 // Int64: 2^52
                Vector512<long> exp_bias = Vector512.Create(ScalarConstants.IntDbl_DoubleBias52).AsInt64(); //0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                Vector512<long> zero = Vector512<long>.Zero;
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector512<long> bin = value.AsInt64();
                Vector512<long> negative = Avx512.CompareGreaterThan(zero, bin);                    //3,1
                Vector512<long> mat = Avx512.And(bin, mat_mask);                                    //1,1/3
                mat = Avx512.Or(mat, hidden_1);                                                     //1,1/3
                Vector512<long> exp_enc = Avx512.ShiftLeftLogical(bin, 1);                          //1,1/2
                exp_enc = Avx512.ShiftRightLogical(exp_enc, 53);                                    //1,1/2
                Vector512<long> exp_frac = Avx512.Subtract(exp_enc, exp_bias);                      //1,1/3
                Vector512<long> msl = Avx512.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt64());    //1,1/2
                Vector512<long> exp_frac_n = Avx512.Subtract(zero, exp_frac);                       //1,1/3
                Vector512<long> msr = Avx512.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt64()); //1,1/2
                Vector512<long> exp_is_pos = Avx512.CompareGreaterThan(exp_frac, zero);             //3,1
                Vector512<long> result_abs = Avx512.BlendVariable(msr, msl, exp_is_pos);            //2,1
                Vector512<long> result = Avx512.Xor(result_abs, negative);                          //1,1/3
                result = Avx512.Subtract(result, negative);                                         //1,1/3
                return result;  //total latency: 18, total throughput CPI: 7
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64(Vector512{double})"/>
            /// <remarks>Input range is all number. Out of range results is `-pow(2,63)`.</remarks>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_ShiftVarFix(Vector512<double> value) {
                Vector512<long> mat_mask = Vector512.Create(ScalarConstants.DoubleVal_MantissaMask).AsInt64(); // Element: 0x000FFFFF_FFFFFFFF
                Vector512<long> hidden_1 = Vector512.Create(ScalarConstants.IntDbl_2Pow52).AsInt64(); // Element: 0x00100000_00000000
                Vector512<long> exp_bias = Vector512.Create(ScalarConstants.IntDbl_DoubleBias52).AsInt64(); // Element: ScalarConstants.Double_ExponentBias + ScalarConstants.Double_MantissaBits =  = 1023 + 52 = 1075 = 0x433
                Vector512<long> zero = Vector512<long>.Zero;
                Vector512<long> exp_max = Vector512.Create(ScalarConstants.IntDbl_DoubleBias62).AsInt64(); // Element: ScalarConstants.Double_ExponentBias + 63-1 = 1023 + 62 = 1085 = 0x43D. Because `long.MaxValue` is `pow(2,63)-1`.
                Vector512<long> defValue = Vector512Constants.Double_SignMask.AsInt64(); // Out of range results is `-pow(2,63)`
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector512<long> bin = value.AsInt64();
                Vector512<long> negative = Avx512.CompareGreaterThan(zero, bin);                     //3,1. negative[i] = (0 < bin[i])
                Vector512<long> mat = Avx512.And(bin, mat_mask);                                     //1,1/3. Get mantissa field.
                mat = Avx512.Or(mat, hidden_1);                                                      //1,1/3. Convert mantissa field to integer.
                Vector512<long> exp_enc = Avx512.ShiftLeftLogical(bin, 1);                           //1,1/2. Remove sign bit.
                exp_enc = Avx512.ShiftRightLogical(exp_enc, 1 + ScalarConstants.Double_MantissaBits);//1,1/2. (bin[i]<<1)>>(1+52) = abs_double(bin[i])>>52
                Vector512<long> exp_frac = Avx512.Subtract(exp_enc, exp_bias);                       //1,1/3. Convert exponent field to shift amount .
                Vector512<long> exp_frac_n = Avx512.Subtract(zero, exp_frac);                        //1,1/3. exp_frac_n[i] = -exp_frac[i]
                Vector512<long> exp_is_end = Avx512.CompareGreaterThan(exp_enc, exp_max);            //3,1.  exp_is_end[i] = (exp_enc[i] > exp_max[i]) .
                Vector512<long> msl = Avx512.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt64());     //1,1/2. msl[i] = mat << exp_frac[i]
                Vector512<long> msr = Avx512.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt64());  //1,1/2. msr[i] = mat >> exp_frac_n[i] = mat >> (-exp_frac[i])
                Vector512<long> exp_is_pos = Avx512.CompareGreaterThan(exp_frac, zero);              //3,1. The mask of exp_frac is a positive
                Vector512<long> result_abs = Avx512.BlendVariable(msr, msl, exp_is_pos);             //2,1. result_abs[i] = (exp_is_pos[i])?msl[i]:msl[i]
                result_abs = Avx512.BlendVariable(result_abs, defValue, exp_is_end);                 //2,1.  result_abs[i] = (exp_is_end[i])?defValue[i]:result_abs[i]
                Vector512<long> result = Avx512.Xor(result_abs, negative);                           //1,1/3. ~x = xor(x, -1)
                result = Avx512.Subtract(result, negative);                                          //1,1/3 -(x) = (~x)+1 = (~x) - (-1)
                return result;  //total latency: 23, total throughput CPI: 9
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_Range52(Vector512<double> value) {
                return ConvertToInt64_Range52_Impl(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_Range52_Impl(Vector512<double> value) {
                value = Avx.RoundToZero(value); // Truncate.
                return ConvertToInt64_Range52RoundToEven(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52RoundToEven(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_Range52RoundToEven(Vector512<double> value) {
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 14, 2016 at 17:23 Mysticial
                // //  Only works for inputs in the range: [-2^51, 2^51]
                // __m128i double_to_int64(__m128d x){
                //     x = _mm_add_pd(x, _mm_set1_pd(0x0018000000000000));
                //     return _mm_sub_epi64(
                //         _mm_castpd_si128(x),
                //         _mm_castpd_si128(_mm_set1_pd(0x0018000000000000))
                //     );
                // }
                Vector512<double> magicNumber = Vector512.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector512<double> x = Avx.Add(value, magicNumber);
                Vector512<long> result = Avx512.Subtract(x.AsInt64(), magicNumber.AsInt64());
                return result;
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
                return Avx.ConvertToVector512Single(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> ConvertToSingle(Vector512<uint> value) {
                return ConvertToSingle_Multiply(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> ConvertToSingle_Multiply(Vector512<uint> value) {
                // Reference: System.Private.CoreLib/src/System/Runtime/Intrinsics/Vector512.cs
                // This first bit of magic works because float can exactly represent integers up to 2^24
                //
                // This means everything between 0 and 2^16 (ushort.MaxValue + 1) are exact and so
                // converting each of the upper and lower halves will give an exact result
                Vector512<int> lowerBits = Avx512.And(value, Vector512.Create(0x0000FFFFU)).AsInt32();
                Vector512<int> upperBits = Avx512.ShiftRightLogical(value, 16).AsInt32();
                Vector512<float> lower = Avx.ConvertToVector512Single(lowerBits);
                Vector512<float> upper = Avx.ConvertToVector512Single(upperBits);
                // This next bit of magic works because all multiples of 65536, at least up to 65535
                // are likewise exactly representable
                //
                // This means that scaling upper by 65536 gives us the exactly representable base value
                // and then the remaining lower value, which is likewise up to 65535 can be added on
                // giving us a result that will correctly round to the nearest representable value
                if (Fma.IsSupported) {
                    return Fma.MultiplyAdd(upper, Vector512.Create(65536.0f), lower);
                } else {
                    Vector512<float> result = Avx.Multiply(upper, Vector512.Create(65536.0f));
                    return Avx.Add(result, lower);
                }
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
                get {
#if NET5_0_OR_GREATER
                    return TypeCodeFlags.Single;
#else
                    return SuperStatics.ConvertToUInt32_AcceleratedTypes;
#endif
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32(Vector512{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ConvertToUInt32(Vector512<float> value) {
                //return SuperStatics.ConvertToUInt32(value);
                //return ConvertToUInt32_Mapping(value);
                //return ConvertToUInt32_MappingFix(value);
                return ConvertToUInt32_ShiftVar(value);
            }

            ///// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32(Vector512{float})"/>
            ///// <remarks>Input range is `[-pow(2,31), pow(2,31))`. Out of range results in `2147483648`(pow(2,31)).</remarks>
            //[Obsolete("It has a different valid range.")]
            //[CLSCompliant(false)]
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector512<uint> ConvertToUInt32_As(Vector512<float> value) {
            //    return Avx.ConvertToVector512Int32WithTruncation(value).AsUInt32();
            //}

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32(Vector512{float})"/>
            /// <remarks>Input range is `[0, pow(2,32))`. Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ConvertToUInt32_ShiftVar(Vector512<float> value) {
                //constants
                Vector512<int> mat_mask = Vector512.Create(ScalarConstants.SingleVal_MantissaMask).AsInt32(); // 0x007FFFFF
                Vector512<int> hidden_1 = Vector512.Create(ScalarConstants.Int_2Pow23).AsInt32();             // 0x00800000 // Int32: 2^23
                Vector512<int> exp_bias = Vector512.Create(ScalarConstants.Int_SingleBias23).AsInt32(); // Single_ExponentBias + Single_MantissaBits = 127 + 23 = 150 = 0x96
                Vector512<int> zero = Vector512<int>.Zero;
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector512<int> bin = value.AsInt32();
                Vector512<int> mat = Avx512.And(bin, mat_mask);                                    //1,1/3
                mat = Avx512.Or(mat, hidden_1);                                                    //1,1/3
                Vector512<int> exp_enc = Avx512.ShiftRightLogical(bin, 23);                        //1,1/2
                Vector512<int> exp_frac = Avx512.Subtract(exp_enc, exp_bias);                      //1,1/3
                Vector512<int> msl = Avx512.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt32());    //1,1/2
                Vector512<int> exp_frac_n = Avx512.Subtract(zero, exp_frac);                       //1,1/3
                Vector512<int> msr = Avx512.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt32()); //1,1/2
                Vector512<int> exp_is_pos = Avx512.CompareGreaterThan(exp_frac, zero);             //3,1
                Vector512<int> result_abs = Avx512.BlendVariable(msr, msl, exp_is_pos);            //2,1
                return result_abs.AsUInt32();	//total latency: 12, total throughput CPI: 4.8
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32(Vector512{float})"/>
            /// <remarks>Input range is `[-pow(2,31), pow(2,32))`. Out of range results in `2147483648`(pow(2,31)).</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ConvertToUInt32_Mapping(Vector512<float> value) {
#if NET5_0_OR_GREATER
                // [pow(2,31), pow(2,32)-1] mapping to [-pow(2,31), -1]. Subtract `pow(2,32)`.
                Vector512<float> highEnd = Vector512.Create(ScalarConstants.SingleBit_2Pow32).AsSingle();
                Vector512<float> highBegin = Vector512.Create(ScalarConstants.SingleBit_2Pow31).AsSingle();
                Vector512<float> highMapped = Avx.Subtract(value, highEnd);
                Vector512<float> highMask = Avx.And(Avx.CompareLessThanOrEqual(highBegin, value), Avx.CompareLessThan(value, highEnd)); // highBegin <= value < highEnd .
                //Vector512<float> value2 = ConditionalSelect(highMask, highMapped, value);
                Vector512<float> value2 = Avx512.BlendVariable(value, highMapped, highMask);
                Vector512<uint> rt = Avx.ConvertToVector512Int32WithTruncation(value2).AsUInt32();
                return rt;
#else
                // Because CompareLessThanOrEqual has Exception: Error	CS1503	Argument 1: cannot convert from 'System.Runtime.Intrinsics.Vector512<float>' to 'System.Runtime.Intrinsics.Vector128<double>'	VectorTraits (netcoreapp3.0)
                return SuperStatics.ConvertToUInt32(value);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32(Vector512{float})"/>
            /// <remarks>Input range is `[-pow(2,31), pow(2,32))`. Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ConvertToUInt32_MappingFix(Vector512<float> value) {
#if NET5_0_OR_GREATER
                // [pow(2,31), pow(2,32)-1] mapping to [-pow(2,31), -1]. Subtract `pow(2,32)`.
                Vector512<float> highEnd = Vector512.Create(ScalarConstants.SingleBit_2Pow32).AsSingle();
                Vector512<float> lowBegin = Vector512.Create(ScalarConstants.SingleBit_Negative2Pow31).AsSingle();
                Vector512<float> highBegin = Vector512.Create(ScalarConstants.SingleBit_2Pow31).AsSingle();
                Vector512<float> lessHighEnd = Avx.CompareLessThan(value, highEnd); // value < highEnd .
                Vector512<float> highMapped = Avx.Subtract(value, highEnd);
                Vector512<float> lowMask = Avx.And(Avx.CompareLessThanOrEqual(lowBegin, value), lessHighEnd); // lowBegin <= value < highEnd .
                Vector512<float> value0 = Avx.And(value, lowMask); // If out of range, set to 0.
                Vector512<float> highMask = Avx.And(Avx.CompareLessThanOrEqual(highBegin, value), lessHighEnd); // highBegin <= value < highEnd .
                //Vector512<float> value2 = ConditionalSelect(highMask, highMapped, value0);
                Vector512<float> value2 = Avx512.BlendVariable(value0, highMapped, highMask);
                Vector512<uint> rt = Avx.ConvertToVector512Int32WithTruncation(value2).AsUInt32();
                return rt;
#else
                // Because CompareLessThanOrEqual has Exception: Error	CS1503	Argument 1: cannot convert from 'System.Runtime.Intrinsics.Vector512<float>' to 'System.Runtime.Intrinsics.Vector128<double>'	VectorTraits (netcoreapp3.0)
                return SuperStatics.ConvertToUInt32(value);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32(Vector512{float})"/>
            /// <remarks>Input range is all number (Use mod function). Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ConvertToUInt32_Mod(Vector512<float> value) {
#if NET5_0_OR_GREATER
                // remainder = mod(value, highEnd) = value - floor(value/highEnd)*highEnd
                Vector512<float> highEndDiv = Vector512.Create(ScalarConstants.SingleBit_2PowNegative32).AsSingle();
                Vector512<float> highEnd = Vector512.Create(ScalarConstants.SingleBit_2Pow32).AsSingle();
                Vector512<float> lowBegin = Vector512.Create(ScalarConstants.SingleBit_Negative2Pow31).AsSingle();
                Vector512<float> highBegin = Vector512.Create(ScalarConstants.SingleBit_2Pow31).AsSingle();
                Vector512<float> quotientFloor = Avx.Multiply(value, highEndDiv); // Avx.Divide(value, highEnd);
                quotientFloor = Avx.Floor(quotientFloor);
                Vector512<float> intRangeMask = Avx.And(Avx.CompareLessThanOrEqual(lowBegin, value), Avx.CompareLessThan(value, highBegin)); // lowBegin <= value < highBegin .
                Vector512<float> remainder = Avx.Subtract(value, Avx.Multiply(quotientFloor, highEnd));
                // [pow(2,31), pow(2,32)-1] mapping to [-pow(2,31), -1]. Subtract `pow(2,32)`.
                Vector512<float> uintRangeMask = Avx.And(Avx.CompareLessThanOrEqual(Vector512<float>.Zero, remainder), Avx.CompareLessThan(remainder, highEnd)); // lowBegin <= remainder < highEnd .
                Vector512<float> highMask = Avx.CompareLessThanOrEqual(highBegin, remainder); // highBegin <= value .
                Vector512<float> remainder0 = Avx.And(remainder, uintRangeMask); // If out of range, set to 0.
                Vector512<float> highMapped = Avx.Subtract(remainder0, highEnd);
                //Vector512<float> value2 = ConditionalSelect(highMask, highMapped, remainder0);
                Vector512<float> value2 = Avx512.BlendVariable(remainder0, highMapped, highMask);
                // If within the signed integer range, return value, otherwise return value2 .
                Vector512<float> value3 = Avx512.BlendVariable(value2, value, intRangeMask);
                Vector512<uint> rt = Avx.ConvertToVector512Int32WithTruncation(value3).AsUInt32();
                return rt;
#else
                // Because CompareLessThanOrEqual has Exception: Error	CS1503	Argument 1: cannot convert from 'System.Runtime.Intrinsics.Vector512<float>' to 'System.Runtime.Intrinsics.Vector128<double>'	VectorTraits (netcoreapp3.0)
                return SuperStatics.ConvertToUInt32(value);
#endif
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
                //return SuperStatics.ConvertToUInt64(value);
                return ConvertToUInt64_ShiftVar(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64(Vector512{double})"/>
            /// <remarks>Input range is `[0, pow(2,64))`. Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ConvertToUInt64_ShiftVar(Vector512<double> value) {
                // From Veloctor . MIT
                // https://github.com/Veloctor/Int128/blob/main/include/AVX2Ext.h
                // //  Only works for inputs in full uint64 range, otherwise result undefined
                // inline __m512i double_to_uint64_fast(const __m512d v) //9 instructions
                // {
                // 	//constants
                // 	__m512i mat_mask = _mm512_set1_epi64x(0x0FFFFFFFFFFFFF);	//0_00000000000_1111111111111111111111111111111111111111111111111111
                // 	__m512i hidden_1 = _mm512_set1_epi64x(0x10000000000000);	//0_00000000001_0000000000000000000000000000000000000000000000000000
                // 	__m512i exp_bias = _mm512_set1_epi64x(1023LL + 52);			//0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                // 	#define zero512 _mm512_setzero_si512()
                // 	//majik operations
                // 	__m512i bin = _mm512_castpd_si512(v);
                // 	__m512i mat = _mm512_and_si512(bin, mat_mask);					//1,1/3
                // 	mat = _mm512_or_si512(mat, hidden_1);							//1,1/3
                // 	__m512i exp_enc = _mm512_srli_epi64(bin, 52);					//1,1/2
                // 	__m512i exp_frac = _mm512_sub_epi64(exp_enc, exp_bias);			//1,1/3
                // 	__m512i msl = _mm512_sllv_epi64(mat, exp_frac);					//1,1/2
                // 	__m512i exp_frac_n = _mm512_sub_epi64(zero512, exp_frac);		//1,1/3
                // 	__m512i msr = _mm512_srlv_epi64(mat, exp_frac_n);				//1,1/2
                // 	__m512i exp_is_pos = _mm512_cmpgt_epi64(exp_frac, zero512);		//3,1
                // 	__m512i result_abs = _mm512_blendv_epi8(msr, msl, exp_is_pos);	//2,1
                // 	return result_abs;	//total latency: 12, total throughput CPI: 4.8
                // }
                //constants
                Vector512<long> mat_mask = Vector512.Create(ScalarConstants.DoubleVal_MantissaMask).AsInt64();  //0_00000000000_1111111111111111111111111111111111111111111111111111
                Vector512<long> hidden_1 = Vector512.Create(ScalarConstants.IntDbl_2Pow52).AsInt64();  //0_00000000001_0000000000000000000000000000000000000000000000000000 // Int64: 2^52
                Vector512<long> exp_bias = Vector512.Create(ScalarConstants.IntDbl_DoubleBias52).AsInt64(); //0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                Vector512<long> zero = Vector512<long>.Zero;
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector512<long> bin = value.AsInt64();
                Vector512<long> mat = Avx512.And(bin, mat_mask);                                    //1,1/3
                mat = Avx512.Or(mat, hidden_1);                                                     //1,1/3
                Vector512<long> exp_enc = Avx512.ShiftRightLogical(bin, 52);                        //1,1/2
                Vector512<long> exp_frac = Avx512.Subtract(exp_enc, exp_bias);                      //1,1/3
                Vector512<long> msl = Avx512.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt64());    //1,1/2
                Vector512<long> exp_frac_n = Avx512.Subtract(zero, exp_frac);                       //1,1/3
                Vector512<long> msr = Avx512.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt64()); //1,1/2
                Vector512<long> exp_is_pos = Avx512.CompareGreaterThan(exp_frac, zero);             //3,1
                Vector512<long> result_abs = Avx512.BlendVariable(msr, msl, exp_is_pos);            //2,1
                return result_abs.AsUInt64();	//total latency: 12, total throughput CPI: 4.8
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
                value = Avx.RoundToZero(value); // Truncate.
                return ConvertToUInt64_Range52RoundToEven(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_Range52RoundToEven(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ConvertToUInt64_Range52RoundToEven(Vector512<double> value) {
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 14, 2016 at 17:23 Mysticial
                // //  Only works for inputs in the range: [0, 2^52)
                // __m128i double_to_uint64(__m128d x){
                //     x = _mm_add_pd(x, _mm_set1_pd(0x0010000000000000));
                //     return _mm_xor_si128(
                //         _mm_castpd_si128(x),
                //         _mm_castpd_si128(_mm_set1_pd(0x0010000000000000))
                //     );
                // }
                Vector512<double> magicNumber = Vector512.Create(ScalarConstants.DoubleVal_2Pow52); // Double value: pow(2, 52)
                Vector512<double> x = Avx.Add(value, magicNumber);
                Vector512<ulong> result = Avx512.Xor(x.AsUInt64(), magicNumber.AsUInt64());
                return result;
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
            public static uint ExtractMostSignificantBits(Vector512<float> vector) {
                return (uint)Avx.MoveMask(vector);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector512<double> vector) {
                return (uint)Avx.MoveMask(vector);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector512<sbyte> vector) {
                return ExtractMostSignificantBits(vector.AsByte());
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector512<byte> vector) {
                return (uint)Avx512.MoveMask(vector);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector512<short> vector) {
                return ExtractMostSignificantBits(vector.AsUInt16());
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector512<ushort> vector) {
                Vector512<byte> m = Avx512.Shuffle(vector.AsByte(), Vector512Constants.ExtractMostSignificantBits_Shuffle_HiByteOf16); // Packed the high byte. 0~7 is the source 0~7, 16~23 is the source 8~15, and the rest is cleared.
                m = Avx512.Permute4x64(m.AsUInt64(), (byte)ShuffleControlG4.XZYW).AsByte(); // Swap 16~23 bytes, to 8~15 .
                return (uint)Avx512.MoveMask(m);
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector512<int> vector) {
                return ExtractMostSignificantBits(vector.AsSingle());
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector512<uint> vector) {
                return ExtractMostSignificantBits(vector.AsSingle());
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector512<long> vector) {
                return ExtractMostSignificantBits(vector.AsDouble());
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector512<ulong> vector) {
                return ExtractMostSignificantBits(vector.AsDouble());
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
                return Avx.Floor(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.Floor(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Floor(Vector512<double> value) {
                return Avx.Floor(value);
            }
*/

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
                return Vector512.Create(Avx512F.ConvertToVector256Single(lower), Avx512F.ConvertToVector256Single(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{short}, Vector512{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Narrow(Vector512<short> lower, Vector512<short> upper) {
                return Vector512.Create(Avx512BW.ConvertToVector256SByte(lower), Avx512BW.ConvertToVector256SByte(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{ushort}, Vector512{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Narrow(Vector512<ushort> lower, Vector512<ushort> upper) {
                return Vector512.Create(Avx512BW.ConvertToVector256Byte(lower), Avx512BW.ConvertToVector256Byte(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{int}, Vector512{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Narrow(Vector512<int> lower, Vector512<int> upper) {
                return Vector512.Create(Avx512F.ConvertToVector256Int16(lower), Avx512F.ConvertToVector256Int16(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{uint}, Vector512{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Narrow(Vector512<uint> lower, Vector512<uint> upper) {
                return Vector512.Create(Avx512F.ConvertToVector256UInt16(lower), Avx512F.ConvertToVector256UInt16(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{long}, Vector512{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Narrow(Vector512<long> lower, Vector512<long> upper) {
                return Vector512.Create(Avx512F.ConvertToVector256Int32(lower), Avx512F.ConvertToVector256Int32(upper));
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{ulong}, Vector512{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Narrow(Vector512<ulong> lower, Vector512<ulong> upper) {
                return Vector512.Create(Avx512F.ConvertToVector256UInt32(lower), Avx512F.ConvertToVector256UInt32(upper));
            }

/*
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
                //Vector128<short> xmm = Sse2.ConvertScalarToVector128Int32(shiftAmount & 0x0F).AsInt16();
                //Vector512<short> args0 = Vector512.Create(xmm, xmm);
                Vector512<short> args0 = Vector512.CreateScalarUnsafe((int)(shiftAmount & 0x0F)).AsInt16();
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Args(Vector512<ushort> dummy, int shiftAmount, out Vector512<ushort> args1) {
                var args0 = ShiftLeft_Args(dummy.AsInt16(), shiftAmount, out var a1).AsUInt16();
                args1 = a1.AsUInt16();
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
                var t = Avx512.And(value, args1).AsUInt32();
                return Avx512.ShiftLeftLogicalVariable(t, args0.AsUInt32()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftLeftLogical(value, args0.GetLower());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Core(Vector512<ushort> value, int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftLeftLogical(value, args0.GetLower());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftLeftLogicalVariable(value, args0.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Core(Vector512<uint> value, int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftLeftLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftLeftLogicalVariable(value, args0.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Core(Vector512<ulong> value, int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftLeftLogicalVariable(value, args0);
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
                Vector512<byte> t = Avx512.And(value, Vector512Constants.GetResidueMaskBits_Byte(shiftAmount));
                return Avx512.ShiftLeftLogical(t.AsUInt32(), (byte)shiftAmount).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Const(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Const(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Const(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
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
#if NET6_0_OR_GREATER
                // The net6 JIT can compile constants to immediate numbers
                _ = args0;
                _ = args1;
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_ConstCore(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_ConstCore(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_ConstCore(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
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
                Vector512<byte> t = Avx512.And(value, Vector512Constants.GetResidueMaskBits_Byte(shiftAmount));
                return Avx512.ShiftLeftLogical(t.AsUInt32(), (byte)shiftAmount).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Fast(Vector512<short> value, int shiftAmount) {
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount); // For non-constant parameters, JIT will automatically use the Vector128 version (对于非常量参数, JIT会自动使用Vector128的版本). e.g. Avx512.ShiftLeftLogical(Vector512{ushort}, Vector128{ushort})
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Fast(Vector512<ushort> value, int shiftAmount) {
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Fast(Vector512<int> value, int shiftAmount) {
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Fast(Vector512<uint> value, int shiftAmount) {
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Fast(Vector512<long> value, int shiftAmount) {
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Fast(Vector512<ulong> value, int shiftAmount) {
                return Avx512.ShiftLeftLogical(value, (byte)shiftAmount);
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
                Vector512<short> args0 = Vector512.CreateScalarUnsafe((int)(shiftAmount & 0x0F)).AsInt16();
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
                shiftAmount &= 0x3F;
                var args0 = Vector512.Create((long)shiftAmount);
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                _ = shiftAmount;
                Vector512<sbyte> sign = Avx512.CompareGreaterThan(Vector512<sbyte>.Zero, value);
                Vector512<sbyte> shifted = Avx512.ShiftRightLogicalVariable(value.AsUInt32(), args0.AsUInt32()).AsSByte();
                Vector512<sbyte> rt = ConditionalSelect(args1, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftRightArithmetic(value, args0.GetLower());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftRightArithmeticVariable(value, args0.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = shiftAmount;
                _ = args1;
                Vector512<long> sign = Avx512.CompareGreaterThan(Vector512<long>.Zero, value);
                Vector512<long> rt = Avx512.Xor(value, sign);
                rt = Avx512.ShiftRightLogicalVariable(rt, args0.AsUInt64());
                rt = Avx512.Xor(rt, sign);
                return rt;
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
                return Avx512.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx512.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
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
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx512.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx512.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
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
                Vector512<short> lowerToHigh = Avx512.ShiftLeftLogical(value.AsInt16(), 8);
                Vector512<short> lowerShifted = Avx512.ShiftRightArithmetic(lowerToHigh, (byte)shiftAmount);
                Vector512<sbyte> upper = Avx512.ShiftRightArithmetic(value.AsInt16(), (byte)shiftAmount).AsSByte();
                Vector512<sbyte> lower = Avx512.ShiftRightLogical(lowerShifted, 8).AsSByte();
                Vector512<sbyte> rt = Avx512.Or(Avx512.And(Vector512s<sbyte>.XyYMask, upper), lower);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Fast_Negative(Vector512<sbyte> value, int shiftAmount) {
                Vector512<sbyte> mask = Vector512Constants.GetResidueMaskBits_SByte(shiftAmount);
                Vector512<sbyte> shifted = Avx512.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsSByte();
                Vector512<sbyte> sign = Avx512.CompareGreaterThan(Vector512<sbyte>.Zero, value);
                Vector512<sbyte> rt = ConditionalSelect(mask, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_Fast(Vector512<short> value, int shiftAmount) {
                return Avx512.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Fast(Vector512<int> value, int shiftAmount) {
                return Avx512.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Fast(Vector512<long> value, int shiftAmount) {
                return ShiftRightArithmetic_Fast_Xor(value, shiftAmount);
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Fast_Narrow(Vector512<long> value, int shiftAmount) {
                if (0 == shiftAmount) {
                    return value;
                }
                Vector512<long> rt;
                Vector512<int> lower, upper;
                Vector512<int> XyXMask = Vector512s<int>.XyXMask;
                const byte controlInputUpper = (byte)ShuffleControlG4.YYWW; // BitMath._MM_SHUFFLE(3, 3, 1, 1) = 0xF5 = 0b11_11_01_01;
                Vector512<int> upperAtLower = Avx512.Shuffle(value.AsInt32(), controlInputUpper); // f({ v0.lower, v0.upper, v1.lower, v1.upper, ... }) = { v0.upper, v0.upper, v1.upper, v1.upper, ... }
                upperAtLower = Avx512.And(XyXMask, upperAtLower); // = { v0.upper, 0, v1.upper, 0, ... }
                Vector512<int> upperOld = Avx512.AndNot(XyXMask, value.AsInt32()); // = { 0, v0.upper, 0, v1.upper, ... }
                if (32 <= shiftAmount) {
                    // Scalar algorithm:
                    //    uint lower = (uint)((int)value._upper >> (shiftAmount & 31));
                    //    uint upper = (uint)((int)value._upper >> 31);
                    lower = Avx512.ShiftRightArithmetic(upperAtLower, (byte)(shiftAmount & 31));
                    upper = Avx512.ShiftRightArithmetic(upperOld, 31);
                    rt = Avx512.Or(lower, upper).AsInt64();
                } else {
                    // Scalar algorithm:
                    //    uint lower = (value._lower >> shiftAmount) | (value._upper << (32 - shiftAmount));
                    //    uint upper = (uint)((int)value._upper >> shiftAmount);
                    Vector512<int> lowerOld = Avx512.And(XyXMask, value.AsInt32());
                    lower = Avx512.Or(Avx512.ShiftRightLogical(lowerOld, (byte)shiftAmount), Avx512.ShiftLeftLogical(upperAtLower, (byte)(32 - shiftAmount)));
                    upper = Avx512.ShiftRightArithmetic(upperOld, (byte)shiftAmount);
                    rt = Avx512.Or(lower, upper).AsInt64();
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Fast_NarrowIfLess(Vector512<long> value, int shiftAmount) {
                if (0 == shiftAmount) {
                    return value;
                }
                Vector512<int> XyXMask = Vector512s<int>.XyXMask;
                const byte controlInputUpper = (byte)ShuffleControlG4.YYWW; // BitMath._MM_SHUFFLE(3, 3, 1, 1) = 0xF5 = 0b11_11_01_01;
                Vector512<int> upperAtLower = Avx512.Shuffle(value.AsInt32(), controlInputUpper); // f({ v0.lower, v0.upper, v1.lower, v1.upper, ... }) = { v0.upper, v0.upper, v1.upper, v1.upper, ... }
                byte shiftAmountUpper = (byte)BitMath.Min(31, shiftAmount);
                byte shiftAmountLeft = (byte)BitMath.Max(0, 32 - shiftAmount);
                Vector512<int> lowerUse1Mask = Vector512.Create(BitMath.ToInt32Mask(32 <= shiftAmount));
                upperAtLower = Avx512.And(XyXMask, upperAtLower); // = { v0.upper, 0, v1.upper, 0, ... }
                Vector512<int> lowerOld = Avx512.And(XyXMask, value.AsInt32());
                Vector512<int> upperOld = Avx512.AndNot(XyXMask, value.AsInt32()); // = { 0, v0.upper, 0, v1.upper, ... }
                Vector512<int> lower2 = Avx512.Or(Avx512.ShiftRightLogical(lowerOld, (byte)shiftAmount), Avx512.ShiftLeftLogical(upperAtLower, shiftAmountLeft));
                Vector512<int> upper = Avx512.ShiftRightArithmetic(upperOld, shiftAmountUpper);
                Vector512<int> lower1 = Avx512.ShiftRightArithmetic(upperAtLower, (byte)(shiftAmount & 31));
                Vector512<int> lower = ConditionalSelect(lowerUse1Mask, lower1, lower2);
                Vector512<long> rt = Avx512.Or(lower, upper).AsInt64();
                return rt;
            }
#endif // !REDUCE_MEMORY_USAGE

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Fast_Negative(Vector512<long> value, int shiftAmount) {
                Vector512<long> sign = Avx512.CompareGreaterThan(Vector512<long>.Zero, value);
                byte shiftAmountLeft = (byte)(64 - shiftAmount);
                Vector512<long> rt = Avx512.Or(Avx512.ShiftRightLogical(value, (byte)shiftAmount), Avx512.ShiftLeftLogical(sign, shiftAmountLeft));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Fast_Xor(Vector512<long> value, int shiftAmount) {
                // t = -(x>>>31); return ((x^t)>>>n)^t; // From "Hacker's Delight", Page 18.
                Vector512<long> sign = Avx512.CompareGreaterThan(Vector512<long>.Zero, value); // Mask `0>x` is `-(x>>>31)`.
                Vector512<long> rt = Avx512.Xor(value, sign);
                rt = Avx512.ShiftRightLogical(rt, (byte)shiftAmount);
                rt = Avx512.Xor(rt, sign);
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
                Vector512<short> args0 = Vector512.CreateScalarUnsafe((int)(shiftAmount & 0x0F)).AsInt16();
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Args(Vector512<ushort> dummy, int shiftAmount, out Vector512<ushort> args1) {
                var args0 = ShiftRightLogical_Args(dummy.AsInt16(), shiftAmount, out var a1).AsUInt16();
                args1 = a1.AsUInt16();
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
                var rt = Avx512.ShiftRightLogicalVariable(value.AsUInt32(), args0.AsUInt32()).AsByte();
                rt = Avx512.And(rt, args1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftRightLogical(value, args0.GetLower());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Core(Vector512<ushort> value, int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftRightLogical(value, args0.GetLower());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftRightLogicalVariable(value, args0.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Core(Vector512<uint> value, int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftRightLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftRightLogicalVariable(value, args0.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Core(Vector512<ulong> value, int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx512.ShiftRightLogicalVariable(value, args0);
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
                Vector512<byte> t = Avx512.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsByte();
                Vector512<byte> rt = Avx512.And(t, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Const(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Const(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Const(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
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
#if NET6_0_OR_GREATER
                // The net6 JIT can compile constants to immediate numbers
                _ = args0;
                _ = args1;
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_ConstCore(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_ConstCore(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_ConstCore(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
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
                Vector512<byte> t = Avx512.AndNot(mask, value);
                Vector512<byte> rt = Avx512.ShiftRightLogical(t.AsUInt16(), (byte)shiftAmount).AsByte();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Fast_FirstShift(Vector512<byte> value, int shiftAmount) {
                Vector512<byte> mask = Vector512Constants.GetResidueMaskBits_Byte(shiftAmount);
                Vector512<byte> t = Avx512.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsByte();
                Vector512<byte> rt = Avx512.And(t, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Fast(Vector512<short> value, int shiftAmount) {
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Fast(Vector512<ushort> value, int shiftAmount) {
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Fast(Vector512<int> value, int shiftAmount) {
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Fast(Vector512<uint> value, int shiftAmount) {
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Fast(Vector512<long> value, int shiftAmount) {
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Fast(Vector512<ulong> value, int shiftAmount) {
                return Avx512.ShiftRightLogical(value, (byte)shiftAmount);
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
                var indicesAdded = Avx512.Add(indices.AsSByte(), Vector512.Create(sbyte.MinValue));
                Vector512<byte> mask = Avx512.CompareGreaterThan(
                    Vector512.Create((sbyte)(32 + sbyte.MinValue)),
                    indicesAdded
                ).AsByte(); // Unsigned compare: (i < 32)
                Vector512<byte> raw = YShuffleKernel(vector, indices);
                Vector512<byte> rt = Avx512.And(raw, mask);
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
                var indicesAdded = Avx512.Add(indices.AsInt16(), Vector512.Create(short.MinValue));
                Vector512<ushort> mask = Avx512.CompareGreaterThan(
                    Vector512.Create((short)(16 + short.MinValue)),
                    indicesAdded
                ).AsUInt16(); // Unsigned compare: (i < 16)
                Vector512<ushort> raw = YShuffleKernel(vector, indices);
                Vector512<ushort> rt = Avx512.And(raw, mask);
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
                var indicesAdded = Avx512.Add(indices.AsInt32(), Vector512.Create(int.MinValue));
                Vector512<uint> mask = Avx512.CompareGreaterThan(
                    Vector512.Create((int)(8 + int.MinValue)),
                    indicesAdded
                ).AsUInt32(); // Unsigned compare: (i < 8)
                Vector512<uint> raw = YShuffleKernel(vector, indices);
                Vector512<uint> rt = Avx512.And(raw, mask);
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
                var indicesAdded = Avx512.Add(indices.AsInt64(), Vector512Constants.Int64_MinValue);
                Vector512<ulong> mask = Avx512.CompareGreaterThan(
                    Vector512Constants.Int64_MinValue_4,
                    indicesAdded
                ).AsUInt64(); // Unsigned compare: (i < 4)
                Vector512<ulong> raw = YShuffleKernel(vector, indices);
                Vector512<ulong> rt = Avx512.And(raw, mask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1) {
                Shuffle_Args(indices.AsByte(), out var a0, out var a1);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1) {
                YShuffleKernel_Args(indices, out args0, out args1);
                var indicesAdded = Avx512.Add(indices.AsSByte(), Vector512.Create(sbyte.MinValue));
                Vector512<byte> mask = Avx512.CompareGreaterThan(
                    Vector512.Create((sbyte)(32 + sbyte.MinValue)),
                    indicesAdded
                ).AsByte(); // Unsigned compare: (i < 32)
                mask = OnesComplement(mask); // Used for _mm512_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = Avx512.Or(args0, mask);
                args1 = Avx512.Or(args1, mask);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1) {
                Shuffle_Args(indices.AsUInt16(), out var a0, out var a1);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1) {
                YShuffleKernel_Args(indices, out args0, out args1);
                var indicesAdded = Avx512.Add(indices.AsInt16(), Vector512.Create(short.MinValue));
                Vector512<ushort> mask = Avx512.CompareGreaterThan(
                    Vector512.Create((short)(16 + short.MinValue)),
                    indicesAdded
                ).AsUInt16(); // Unsigned compare: (i < 16)
                mask = OnesComplement(mask); // Used for _mm512_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = Avx512.Or(args0, mask);
                args1 = Avx512.Or(args1, mask);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1) {
                Shuffle_Args(indices.AsUInt32(), out var a0, out var a1);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1) {
                args0 = indices;
                var indicesAdded = Avx512.Add(indices.AsInt32(), Vector512.Create(int.MinValue));
                args1 = Avx512.CompareGreaterThan(
                    Vector512.Create((int)(8 + int.MinValue)),
                    indicesAdded
                ).AsUInt32(); // Unsigned compare: (i < 8)
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1) {
                Shuffle_Args(indices.AsUInt64(), out var a0, out var a1);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1) {
                YShuffleKernel_Args(indices, out args0, out _);
                var indicesAdded = Avx512.Add(indices.AsInt64(), Vector512Constants.Int64_MinValue);
                args1 = Avx512.CompareGreaterThan(
                    Vector512Constants.Int64_MinValue_4,
                    indicesAdded
                ).AsUInt64(); // Unsigned compare: (i < 4)
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
                return Avx512.Or(
                    Avx512.Shuffle(vector, args0),
                    Avx512.Shuffle(Avx512.Permute4x64(vector.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(), args1)
                );
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
                return Shuffle_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsUInt16();
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
                return Avx512.And(Avx512.PermuteVar8x32(vector, args0), args1);
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
                return Shuffle_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsUInt64();
            }
*/

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
