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

namespace Zyl.VectorTraits.Impl.AVector256 {
    using SuperStatics = WVectorTraits256Base.Statics;

    /// <summary>
    /// <see cref="Vector256{T}"/> traits - Avx2 .
    /// </summary>
    public sealed partial class WVectorTraits256Avx2 : WVectorTraits256Avx2Abstract {
        private static readonly WVectorTraits256Avx2 _instance = new WVectorTraits256Avx2(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits256Avx2 Instance {
            get { return _instance; }
        }

#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector256{T}"/> traits.Statics - Avx2.
        /// </summary>
        public static partial class Statics {

#if NET8_0_OR_GREATER
#if NET9_0_OR_GREATER
            private const bool Avx512_Compare_Used = true;
#else
            private const bool Avx512_Compare_Used = false;
            // Bug of Shuffle<byte> on .NET8.0:
            //00007FFE68EA2B10  vmovups     ymm1,ymmword ptr [r8]  
            //00007FFE68EA2B15  vmovups     ymm2,ymmword ptr [Zyl.VectorTraits.Benchmarks.AVector.S.ShuffleBenchmark_SByte.StaticSumTraits(SByte[], Int32, System.Numerics.Vector`1<SByte>)+0E0h (07FFE68EA2BA0h)]  
            //00007FFE68EA2B1D  vpcmpub     k1,ymm2,ymm1,6  ; Avx512BW.VL.CompareGreaterThan
            //00007FFE68EA2B24  kmovq       qword ptr [rsp+50h],k1    ; Redundant!
            //   157:                 vrt += vtemp; // Add.
            //00007FFE68EA2B2B  vpermb      ymm2,ymm1,ymmword ptr [rcx]  
            //00007FFE68EA2B31  kmovq       k1,qword ptr [rsp+50h]    ; Redundant!
            //00007FFE68EA2B38  vpmovm2b    ymm3,k1  
            //00007FFE68EA2B3E  vpand       ymm2,ymm2,ymm3  
            //00007FFE68EA2B42  vpaddb      ymm0,ymm0,ymm2  
#endif // NET9_0_OR_GREATER
#endif // NET8_0_OR_GREATER

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
#if NETCOREAPP3_0_OR_GREATER
                rt = Avx.IsSupported && Avx2.IsSupported && Sse.IsSupported && Sse2.IsSupported;
#else
#endif // NETCOREAPP3_0_OR_GREATER
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Requires hardware support Avx, Avx2!";
#if NETCOREAPP3_0_OR_GREATER
                if (Avx.IsSupported && Avx2.IsSupported) {
                    if (Sse.IsSupported && Sse2.IsSupported) {
                        // done.
                    } else {
                        // Details.
                        rt = "";
                        if (!Sse.IsSupported) rt += ", Sse";
                        if (!Sse2.IsSupported) rt += ", Sse2";
                        if (!String.IsNullOrEmpty(rt)) {
                            rt = "Requires hardware support " + rt.Substring(2) + "!";
                        }
                    }
                }
#else
                rt = "Vector256 type is not supported! " + rt;
#endif // NETCOREAPP3_0_OR_GREATER
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
#if NETCOREAPP3_0_OR_GREATER
                string separator = VectorEnvironment.InstructionSetsSeparator;
                if (System.Runtime.Intrinsics.X86.Avx.IsSupported) rt += separator + "Avx";
                if (System.Runtime.Intrinsics.X86.Avx2.IsSupported) rt += separator + "Avx2";
                if (System.Runtime.Intrinsics.X86.Sse.IsSupported) rt += separator + "Sse";
                if (System.Runtime.Intrinsics.X86.Sse2.IsSupported) rt += separator + "Sse2";
#if NET8_0_OR_GREATER
                if (System.Runtime.Intrinsics.X86.Avx512F.VL.IsSupported) rt += separator + "Avx512VL";
#endif // NET8_0_OR_GREATER
                // done.
                if (!string.IsNullOrEmpty(rt)) {
                    rt = rt.Substring(separator.Length);
                }
#endif // NETCOREAPP3_0_OR_GREATER
                return rt;
            }

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Ceiling(Vector256<float> value) {
                return Avx.Ceiling(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Ceiling(Vector256<double> value) {
                return Avx.Ceiling(value);
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble(Vector256<long> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector256Double(value);
                }
#endif // NET8_0_OR_GREATER
                return ConvertToDouble_Bcl(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Bcl(Vector256<long> value) {
                // From: src/libraries/System.Private.CoreLib/src/System/Runtime/Intrinsics/Vector256.cs
                // Based on __m256d int64_to_double_fast_precise(const __m256i v)
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                Vector256<int> lowerBits;
                lowerBits = value.AsInt32();
                lowerBits = Avx2.Blend(lowerBits, Vector256.Create(ScalarConstants.DoubleVal_2Pow52).AsInt32(), 0b10101010); // Blend the 32 lowest significant bits of vector with the bit representation of double(2^52)
                Vector256<long> upperBits = Avx2.ShiftRightLogical(value, 32);                                               // Extract the 32 most significant bits of vector
                upperBits = Avx2.Xor(upperBits, Vector256.Create(ScalarConstants.DoubleVal_2Pow84_2Pow63).AsInt64());        // Flip the msb of upperBits and blend with the bit representation of double(2^84 + 2^63)
                Vector256<double> result = Avx.Subtract(upperBits.AsDouble(), Vector256.Create(ScalarConstants.DoubleVal_2Pow84_2Pow63_2Pow52)); // Compute in double precision: (upper - (2^84 + 2^63 + 2^52)) + lower
                return Avx.Add(result, lowerBits.AsDouble());
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Bcl_Wim(Vector256<long> value) {
                // Same ConvertToDouble_Bcl.
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 19, 2016 at 12:51 wim
                //__m256d int64_to_double_fast_precise(const __m256i v) {
                //    __m256i magic_i_lo   = _mm256_set1_epi64x(0x4330000000000000);                /* 2^52               encoded as floating-point  */
                //    __m256i magic_i_hi32 = _mm256_set1_epi64x(0x4530000080000000);                /* 2^84 + 2^63        encoded as floating-point  */
                //    __m256i magic_i_all  = _mm256_set1_epi64x(0x4530000080100000);                /* 2^84 + 2^63 + 2^52 encoded as floating-point  */
                //    __m256d magic_d_all  = _mm256_castsi256_pd(magic_i_all);
                //    __m256i v_lo         = _mm256_blend_epi32(magic_i_lo, v, 0b01010101);         /* Blend the 32 lowest significant bits of v with magic_int_lo                                                   */
                //    __m256i v_hi         = _mm256_srli_epi64(v, 32);                              /* Extract the 32 most significant bits of v                                                                     */
                //            v_hi         = _mm256_xor_si256(v_hi, magic_i_hi32);                  /* Flip the msb of v_hi and blend with 0x45300000                                                                */
                //    __m256d v_hi_dbl     = _mm256_sub_pd(_mm256_castsi256_pd(v_hi), magic_d_all); /* Compute in double precision:                                                                                  */
                //    __m256d result       = _mm256_add_pd(v_hi_dbl, _mm256_castsi256_pd(v_lo));    /* (v_hi - magic_d_all) + v_lo  Do not assume associativity of floating point addition !!                        */
                //            return result;                                                        /* With gcc use -O3, then -fno-associative-math is default. Do not use -Ofast, which enables -fassociative-math! */
                //}
                Vector256<long> magic_i_lo = Vector256.Create(0x43300000_00000000);   // 2^52               encoded as floating-point
                Vector256<long> magic_i_hi32 = Vector256.Create(0x45300000_80000000); // 2^84 + 2^63        encoded as floating-point
                Vector256<long> magic_i_all = Vector256.Create(0x45300000_80100000);  // 2^84 + 2^63 + 2^52 encoded as floating-point
                Vector256<double> magic_d_all = magic_i_all.AsDouble();
                Vector256<int> v_lo = Avx2.Blend(value.AsInt32(), magic_i_lo.AsInt32(), 0b10101010); // Blend the 32 lowest significant bits of v with magic_int_lo (double(2^52))
                Vector256<long> v_hi = Avx2.ShiftRightLogical(value, 32);                            // Extract the 32 most significant bits of v
                v_hi = Avx2.Xor(v_hi, magic_i_hi32);                                                 // Flip the msb of v_hi and blend with magic_i_hi32 (double(2^84 + 2^63))
                Vector256<double> v_hi_dbl = Avx.Subtract(v_hi.AsDouble(), magic_d_all);             // Compute in double precision:
                Vector256<double> result = Avx.Add(v_hi_dbl, v_lo.AsDouble());                       // (v_hi - (2^84 + 2^63 + 2^52)) + v_lo  Do not assume associativity of floating point addition !!
                return result;
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_HwScalar(Vector256<long> value) {
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 19, 2016 at 12:51 wim
                // __m256d int64_to_double_based_on_cvtsi2sd(const __m256i v){
                //     __m128d zero         = _mm_setzero_pd();                            /* to avoid uninitialized variables in_mm_cvtsi64_sd                       */
                //     __m128i v_lo         = _mm256_castsi256_si128(v);
                //     __m128i v_hi         = _mm256_extracti128_si256(v,1);
                //     __m128d v_0          = _mm_cvtsi64_sd(zero,_mm_cvtsi128_si64(v_lo));
                //     __m128d v_2          = _mm_cvtsi64_sd(zero,_mm_cvtsi128_si64(v_hi));
                //     __m128d v_1          = _mm_cvtsi64_sd(zero,_mm_extract_epi64(v_lo,1));
                //     __m128d v_3          = _mm_cvtsi64_sd(zero,_mm_extract_epi64(v_hi,1));
                //     __m128d v_01         = _mm_unpacklo_pd(v_0,v_1);
                //     __m128d v_23         = _mm_unpacklo_pd(v_2,v_3);
                //     __m256d v_dbl        = _mm256_castpd128_pd256(v_01);
                //             v_dbl        = _mm256_insertf128_pd(v_dbl,v_23,1);
                //     return v_dbl;
                // }
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
                    Vector256<double> result = v_01.ToVector256Unsafe().WithUpper(v_23); //Vector256.Create(v_01, v_23);
                    return result;
                } else {
                    return SuperStatics.ConvertToDouble(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_Range52(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Range52(Vector256<long> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector256Double(value);
                }
#endif // NET8_0_OR_GREATER
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 14, 2016 at 17:23 Mysticial
                // inline __m256d int64_to_double256(__m256i x){
                //     /*  Mysticial's fast int64_to_double. Works for inputs in the range: (-2^51, 2^51)  */
                //     x = _mm256_add_epi64(x, _mm256_castpd_si256(_mm256_set1_pd(0x0018000000000000)));
                //     return _mm256_sub_pd(_mm256_castsi256_pd(x), _mm256_set1_pd(0x0018000000000000));
                // }
                // BitConverter.DoubleToInt64Bits((double)0x0018000000000000).ToString("X") = "4338000000000000"
                Vector256<long> magicNumber = Vector256.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51).AsInt64(); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector256<long> x = Avx2.Add(value, magicNumber);
                Vector256<double> result = Avx.Subtract(x.AsDouble(), magicNumber.AsDouble());
                return result;
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble(Vector256<ulong> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector256Double(value);
                }
#endif // NET8_0_OR_GREATER
                return ConvertToDouble_Bcl(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Bcl(Vector256<ulong> value) {
                // From: src/libraries/System.Private.CoreLib/src/System/Runtime/Intrinsics/Vector256.cs
                // Based on __m256d uint64_to_double_fast_precise(const __m256i v)
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                Vector256<uint> lowerBits;
                lowerBits = value.AsUInt32();
                lowerBits = Avx2.Blend(lowerBits, Vector256.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt32(), 0b10101010); // Blend the 32 lowest significant bits of vector with the bit representation of double(2^52)                                                 */
                Vector256<ulong> upperBits = Avx2.ShiftRightLogical(value, 32);                                               // Extract the 32 most significant bits of vector
                upperBits = Avx2.Xor(upperBits, Vector256.Create(ScalarConstants.DoubleVal_2Pow84).AsUInt64());               // Blend upperBits with the bit representation of double(2^84)
                Vector256<double> result = Avx.Subtract(upperBits.AsDouble(), Vector256.Create(ScalarConstants.DoubleVal_2Pow84_2Pow52)); // Compute in double precision: (upper - (2^84 + 2^52)) + lower
                return Avx.Add(result, lowerBits.AsDouble());
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Bcl_Wim(Vector256<ulong> value) {
                // Same ConvertToDouble_Bcl.
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 19, 2016 at 12:51 wim
                //__m256d uint64_to_double_fast_precise(const __m256i v) {
                //    __m256i magic_i_lo   = _mm256_set1_epi64x(0x4330000000000000);                /* 2^52        encoded as floating-point  */
                //    __m256i magic_i_hi32 = _mm256_set1_epi64x(0x4530000000000000);                /* 2^84        encoded as floating-point  */
                //    __m256i magic_i_all  = _mm256_set1_epi64x(0x4530000000100000);                /* 2^84 + 2^52 encoded as floating-point  */
                //    __m256d magic_d_all  = _mm256_castsi256_pd(magic_i_all);
                //    __m256i v_lo         = _mm256_blend_epi32(magic_i_lo, v, 0b01010101);         /* Blend the 32 lowest significant bits of v with magic_int_lo                                                   */
                //    __m256i v_hi         = _mm256_srli_epi64(v, 32);                              /* Extract the 32 most significant bits of v                                                                     */
                //            v_hi         = _mm256_xor_si256(v_hi, magic_i_hi32);                  /* Blend v_hi with 0x45300000                                                                                    */
                //    __m256d v_hi_dbl     = _mm256_sub_pd(_mm256_castsi256_pd(v_hi), magic_d_all); /* Compute in double precision:                                                                                  */
                //    __m256d result       = _mm256_add_pd(v_hi_dbl, _mm256_castsi256_pd(v_lo));    /* (v_hi - magic_d_all) + v_lo  Do not assume associativity of floating point addition !!                        */
                //            return result;                                                        /* With gcc use -O3, then -fno-associative-math is default. Do not use -Ofast, which enables -fassociative-math! */
                //}
                Vector256<long> magic_i_lo = Vector256.Create(0x43300000_00000000);   // 2^52        encoded as floating-point
                Vector256<long> magic_i_hi32 = Vector256.Create(0x45300000_00000000); // 2^84        encoded as floating-point
                Vector256<long> magic_i_all = Vector256.Create(0x45300000_00100000);  // 2^84 + 2^52 encoded as floating-point
                Vector256<double> magic_d_all = magic_i_all.AsDouble();
                Vector256<int> v_lo = Avx2.Blend(value.AsInt32(), magic_i_lo.AsInt32(), 0b10101010); // Blend the 32 lowest significant bits of v with magic_int_lo (double(2^52))
                Vector256<long> v_hi = Avx2.ShiftRightLogical(value, 32).AsInt64();                  // Extract the 32 most significant bits of v
                v_hi = Avx2.Xor(v_hi, magic_i_hi32);                                                 // Blend v_hi with magic_i_hi32 (double(2^84))
                Vector256<double> v_hi_dbl = Avx.Subtract(v_hi.AsDouble(), magic_d_all);             // Compute in double precision:
                Vector256<double> result = Avx.Add(v_hi_dbl, v_lo.AsDouble());                       // (v_hi - magic_d_all) + v_lo  Do not assume associativity of floating point addition !!
                return result;
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_Range52(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> ConvertToDouble_Range52(Vector256<ulong> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector256Double(value);
                }
#endif // NET8_0_OR_GREATER
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 14, 2016 at 17:23 Mysticial
                // inline __m256d uint64_to_double256(__m256i x){
                //     /*  Mysticial's fast uint64_to_double. Works for inputs in the range: [0, 2^52)     */
                //     x = _mm256_or_si256(x, _mm256_castpd_si256(_mm256_set1_pd(0x0010000000000000)));
                //     return _mm256_sub_pd(_mm256_castsi256_pd(x), _mm256_set1_pd(0x0010000000000000));
                // }
                // BitConverter.DoubleToInt64Bits((double)0x0010000000000000).ToString("X") = "4330000000000000"
                Vector256<ulong> magicNumber = Vector256.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt64(); // Double value: pow(2, 52)
                Vector256<ulong> x = Avx2.Or(value, magicNumber);
                Vector256<double> result = Avx.Subtract(x.AsDouble(), magicNumber.AsDouble());
                return result;
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt32_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt32(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ConvertToInt32(Vector256<float> value) {
                return Avx.ConvertToVector256Int32WithTruncation(value);
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    //TypeCodeFlags rt = SuperStatics.ConvertToInt64_AcceleratedTypes;
                    TypeCodeFlags rt = TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ConvertToInt64(Vector256<double> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector256Int64WithTruncation(value);
                }
#endif // NET8_0_OR_GREATER
                // return SuperStatics.ConvertToInt64(value);
                // return ConvertToInt64_HwScalar(value);
                return ConvertToInt64_ShiftVarFix(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ConvertToInt64_HwScalar(Vector256<double> value) {
                if (Sse2.X64.IsSupported) {
                    Vector256<double> valueOdd = Avx2.Permute4x64(value, (byte)ShuffleControlG4.YYWW);
                    long v_0 = Sse2.X64.ConvertToInt64WithTruncation(value.GetLower());
                    long v_2 = Sse2.X64.ConvertToInt64WithTruncation(value.GetUpper());
                    long v_1 = Sse2.X64.ConvertToInt64WithTruncation(valueOdd.GetLower());
                    long v_3 = Sse2.X64.ConvertToInt64WithTruncation(valueOdd.GetUpper());
                    Vector256<long> result = Vector256.Create(v_0, v_1, v_2, v_3);
                    return result;
                } else {
                    return SuperStatics.ConvertToInt64(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64(Vector256{double})"/>
            /// <remarks>Input range is `[-pow(2,63), pow(2,63))`. Out of range results in `0`.</remarks>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ConvertToInt64_ShiftVar(Vector256<double> value) {
                // From Veloctor . MIT
                // https://github.com/Veloctor/Int128/blob/main/include/AVX2Ext.h
                // inline __m256i double_to_int64_fast(const __m256d v) //13 instructions
                // {
                // 	//constants
                // 	__m256i mat_mask = _mm256_set1_epi64x(0x0FFFFFFFFFFFFF);	//0_00000000000_1111111111111111111111111111111111111111111111111111
                // 	__m256i hidden_1 = _mm256_set1_epi64x(0x10000000000000);	//0_00000000001_0000000000000000000000000000000000000000000000000000
                // 	__m256i exp_bias = _mm256_set1_epi64x(1023LL + 52);			//0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                // 	#define zero256 _mm256_setzero_si256()
                // 	//majik operations										  //Latency, Throughput(references IceLake)
                // 	__m256i bin = _mm256_castpd_si256(v);
                // 	__m256i negative = _mm256_cmpgt_epi64(zero256, bin);			//3,1
                // 	__m256i mat = _mm256_and_si256(bin, mat_mask);					//1,1/3
                // 	mat = _mm256_or_si256(mat, hidden_1);							//1,1/3
                // 	__m256i exp_enc = _mm256_slli_epi64(bin, 1);					//1,1/2
                // 	exp_enc = _mm256_srli_epi64(exp_enc, 53);						//1,1/2
                // 	__m256i exp_frac = _mm256_sub_epi64(exp_enc, exp_bias);			//1,1/3
                // 	__m256i msl = _mm256_sllv_epi64(mat, exp_frac);					//1,1/2
                // 	__m256i exp_frac_n = _mm256_sub_epi64(zero256, exp_frac);		//1,1/3
                // 	__m256i msr = _mm256_srlv_epi64(mat, exp_frac_n);				//1,1/2
                // 	__m256i exp_is_pos = _mm256_cmpgt_epi64(exp_frac, zero256);		//3,1
                // 	__m256i result_abs = _mm256_blendv_epi8(msr, msl, exp_is_pos);	//2,1
                // 	__m256i result = _mm256_xor_si256(result_abs, negative);		//1,1/3
                // 	result = _mm256_sub_epi64(result, negative);					//1,1/3
                // 	return result;	//total latency: 18, total throughput CPI: 7
                // }
                //constants
                Vector256<long> mat_mask = Vector256.Create(ScalarConstants.DoubleVal_MantissaMask).AsInt64();  //0_00000000000_1111111111111111111111111111111111111111111111111111
                Vector256<long> hidden_1 = Vector256.Create(ScalarConstants.IntDbl_2Pow52).AsInt64();  //0_00000000001_0000000000000000000000000000000000000000000000000000 // Int64: 2^52
                Vector256<long> exp_bias = Vector256.Create(ScalarConstants.IntDbl_DoubleBias52).AsInt64(); //0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                Vector256<long> zero = Vector256<long>.Zero;
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector256<long> bin = value.AsInt64();
                Vector256<long> negative = Avx2.CompareGreaterThan(zero, bin);                    //3,1
                Vector256<long> mat = Avx2.And(bin, mat_mask);                                    //1,1/3
                mat = Avx2.Or(mat, hidden_1);                                                     //1,1/3
                Vector256<long> exp_enc = Avx2.ShiftLeftLogical(bin, 1);                          //1,1/2
                exp_enc = Avx2.ShiftRightLogical(exp_enc, 53);                                    //1,1/2
                Vector256<long> exp_frac = Avx2.Subtract(exp_enc, exp_bias);                      //1,1/3
                Vector256<long> msl = Avx2.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt64());    //1,1/2
                Vector256<long> exp_frac_n = Avx2.Subtract(zero, exp_frac);                       //1,1/3
                Vector256<long> msr = Avx2.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt64()); //1,1/2
                Vector256<long> exp_is_pos = Avx2.CompareGreaterThan(exp_frac, zero);             //3,1
                Vector256<long> result_abs = ConditionalSelect_Relaxed(exp_is_pos, msl, msr); // ConditionalSelect_Relaxed(exp_is_pos, msl, msr); // Avx2.BlendVariable(msr, msl, exp_is_pos);            //2,1
                Vector256<long> result = Avx2.Xor(result_abs, negative);                          //1,1/3
                result = Avx2.Subtract(result, negative);                                         //1,1/3
                return result;  //total latency: 18, total throughput CPI: 7
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64(Vector256{double})"/>
            /// <remarks>Input range is all number. Out of range results is `-pow(2,63)`.</remarks>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ConvertToInt64_ShiftVarFix(Vector256<double> value) {
                Vector256<long> mat_mask = Vector256.Create(ScalarConstants.DoubleVal_MantissaMask).AsInt64(); // Element: 0x000FFFFF_FFFFFFFF
                Vector256<long> hidden_1 = Vector256.Create(ScalarConstants.IntDbl_2Pow52).AsInt64(); // Element: 0x00100000_00000000
                Vector256<long> exp_bias = Vector256.Create(ScalarConstants.IntDbl_DoubleBias52).AsInt64(); // Element: ScalarConstants.Double_ExponentBias + ScalarConstants.Double_MantissaBits =  = 1023 + 52 = 1075 = 0x433
                Vector256<long> zero = Vector256<long>.Zero;
                Vector256<long> exp_max = Vector256.Create(ScalarConstants.IntDbl_DoubleBias62).AsInt64(); // Element: ScalarConstants.Double_ExponentBias + 63-1 = 1023 + 62 = 1085 = 0x43D. Because `long.MaxValue` is `pow(2,63)-1`.
                Vector256<long> defValue = Vector256Constants.Double_SignMask.AsInt64(); // Out of range results is `-pow(2,63)`
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector256<long> bin = value.AsInt64();
                Vector256<long> negative = Avx2.CompareGreaterThan(zero, bin);                     //3,1. negative[i] = (0 < bin[i])
                Vector256<long> mat = Avx2.And(bin, mat_mask);                                     //1,1/3. Get mantissa field.
                mat = Avx2.Or(mat, hidden_1);                                                      //1,1/3. Convert mantissa field to integer.
                Vector256<long> exp_enc = Avx2.ShiftLeftLogical(bin, 1);                           //1,1/2. Remove sign bit.
                exp_enc = Avx2.ShiftRightLogical(exp_enc, 1 + ScalarConstants.Double_MantissaBits);//1,1/2. (bin[i]<<1)>>(1+52) = abs_double(bin[i])>>52
                Vector256<long> exp_frac = Avx2.Subtract(exp_enc, exp_bias);                       //1,1/3. Convert exponent field to shift amount .
                Vector256<long> exp_frac_n = Avx2.Subtract(zero, exp_frac);                        //1,1/3. exp_frac_n[i] = -exp_frac[i]
                Vector256<long> exp_is_end = Avx2.CompareGreaterThan(exp_enc, exp_max);            //3,1.  exp_is_end[i] = (exp_enc[i] > exp_max[i]) .
                Vector256<long> msl = Avx2.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt64());     //1,1/2. msl[i] = mat << exp_frac[i]
                Vector256<long> msr = Avx2.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt64());  //1,1/2. msr[i] = mat >> exp_frac_n[i] = mat >> (-exp_frac[i])
                Vector256<long> exp_is_pos = Avx2.CompareGreaterThan(exp_frac, zero);              //3,1. The mask of exp_frac is a positive
                Vector256<long> result_abs = ConditionalSelect_Relaxed(exp_is_pos, msl, msr); // Avx2.BlendVariable(msr, msl, exp_is_pos);             //2,1. result_abs[i] = (exp_is_pos[i])?msl[i]:msl[i]
                result_abs = ConditionalSelect_Relaxed(exp_is_end, defValue, result_abs); // Avx2.BlendVariable();                 //2,1.  result_abs[i] = (exp_is_end[i])?defValue[i]:result_abs[i]
                Vector256<long> result = Avx2.Xor(result_abs, negative);                           //1,1/3. ~x = xor(x, -1)
                result = Avx2.Subtract(result, negative);                                          //1,1/3 -(x) = (~x)+1 = (~x) - (-1)
                return result;  //total latency: 23, total throughput CPI: 9
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_Range52(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ConvertToInt64_Range52(Vector256<double> value) {
                return ConvertToInt64_Range52_Impl(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_Range52(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ConvertToInt64_Range52_Impl(Vector256<double> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector256Int64WithTruncation(value);
                }
#endif // NET8_0_OR_GREATER
                value = Avx.RoundToZero(value); // Truncate.
                return ConvertToInt64_Range52RoundToEven(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_Range52RoundToEven(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ConvertToInt64_Range52RoundToEven(Vector256<double> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector256Int64(value);
                }
#endif // NET8_0_OR_GREATER
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
                Vector256<double> magicNumber = Vector256.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector256<double> x = Avx.Add(value, magicNumber);
                Vector256<long> result = Avx2.Subtract(x.AsInt64(), magicNumber.AsInt64());
                return result;
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToSingle_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> ConvertToSingle(Vector256<int> value) {
                return Avx.ConvertToVector256Single(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> ConvertToSingle(Vector256<uint> value) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ConvertToVector256Single(value);
                }
#endif // NET8_0_OR_GREATER
                return ConvertToSingle_Multiply(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> ConvertToSingle_Multiply(Vector256<uint> value) {
                // Reference: System.Private.CoreLib/src/System/Runtime/Intrinsics/Vector256.cs
                // This first bit of magic works because float can exactly represent integers up to 2^24
                //
                // This means everything between 0 and 2^16 (ushort.MaxValue + 1) are exact and so
                // converting each of the upper and lower halves will give an exact result
                Vector256<int> lowerBits = Avx2.And(value, Vector256.Create(0x0000FFFFU)).AsInt32();
                Vector256<int> upperBits = Avx2.ShiftRightLogical(value, 16).AsInt32();
                Vector256<float> lower = Avx.ConvertToVector256Single(lowerBits);
                Vector256<float> upper = Avx.ConvertToVector256Single(upperBits);
                // This next bit of magic works because all multiples of 65536, at least up to 65535
                // are likewise exactly representable
                //
                // This means that scaling upper by 65536 gives us the exactly representable base value
                // and then the remaining lower value, which is likewise up to 65535 can be added on
                // giving us a result that will correctly round to the nearest representable value
                if (Fma.IsSupported) {
                    return Fma.MultiplyAdd(upper, Vector256.Create(65536.0f), lower);
                } else {
                    Vector256<float> result = Avx.Multiply(upper, Vector256.Create(65536.0f));
                    return Avx.Add(result, lower);
                }
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
                get {
#if NET5_0_OR_GREATER
                    return TypeCodeFlags.Single;
#else
                    return SuperStatics.ConvertToUInt32_AcceleratedTypes;
#endif
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32(Vector256{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ConvertToUInt32(Vector256<float> value) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ConvertToVector256UInt32WithTruncation(value);
                }
#endif // NET8_0_OR_GREATER
                //return SuperStatics.ConvertToUInt32(value);
                //return ConvertToUInt32_Mapping(value);
                //return ConvertToUInt32_MappingFix(value);
                return ConvertToUInt32_ShiftVar(value);
            }

            ///// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32(Vector256{float})"/>
            ///// <remarks>Input range is `[-pow(2,31), pow(2,31))`. Out of range results in `2147483648`(pow(2,31)).</remarks>
            //[Obsolete("It has a different valid range.")]
            //[CLSCompliant(false)]
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector256<uint> ConvertToUInt32_As(Vector256<float> value) {
            //    return Avx.ConvertToVector256Int32WithTruncation(value).AsUInt32();
            //}

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32(Vector256{float})"/>
            /// <remarks>Input range is `[0, pow(2,32))`. Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ConvertToUInt32_ShiftVar(Vector256<float> value) {
                //constants
                Vector256<int> mat_mask = Vector256.Create(ScalarConstants.SingleVal_MantissaMask).AsInt32(); // 0x007FFFFF
                Vector256<int> hidden_1 = Vector256.Create(ScalarConstants.Int_2Pow23).AsInt32();             // 0x00800000 // Int32: 2^23
                Vector256<int> exp_bias = Vector256.Create(ScalarConstants.Int_SingleBias23).AsInt32(); // Single_ExponentBias + Single_MantissaBits = 127 + 23 = 150 = 0x96
                Vector256<int> zero = Vector256<int>.Zero;
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector256<int> bin = value.AsInt32();
                Vector256<int> mat = Avx2.And(bin, mat_mask);                                    //1,1/3
                mat = Avx2.Or(mat, hidden_1);                                                    //1,1/3
                Vector256<int> exp_enc = Avx2.ShiftRightLogical(bin, 23);                        //1,1/2
                Vector256<int> exp_frac = Avx2.Subtract(exp_enc, exp_bias);                      //1,1/3
                Vector256<int> msl = Avx2.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt32());    //1,1/2
                Vector256<int> exp_frac_n = Avx2.Subtract(zero, exp_frac);                       //1,1/3
                Vector256<int> msr = Avx2.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt32()); //1,1/2
                Vector256<int> exp_is_pos = Avx2.CompareGreaterThan(exp_frac, zero);             //3,1
                Vector256<int> result_abs = ConditionalSelect_Relaxed(exp_is_pos, msl, msr); // Avx2.BlendVariable(msr, msl, exp_is_pos);            //2,1
                return result_abs.AsUInt32();	//total latency: 12, total throughput CPI: 4.8
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32(Vector256{float})"/>
            /// <remarks>Input range is `[-pow(2,31), pow(2,32))`. Out of range results in `2147483648`(pow(2,31)).</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ConvertToUInt32_Mapping(Vector256<float> value) {
#if NET5_0_OR_GREATER
                // [pow(2,31), pow(2,32)-1] mapping to [-pow(2,31), -1]. Subtract `pow(2,32)`.
                Vector256<float> highEnd = Vector256.Create(ScalarConstants.SingleBit_2Pow32).AsSingle();
                Vector256<float> highBegin = Vector256.Create(ScalarConstants.SingleBit_2Pow31).AsSingle();
                Vector256<float> highMapped = Avx.Subtract(value, highEnd);
                Vector256<float> highMask = Avx.And(Avx.CompareLessThanOrEqual(highBegin, value), Avx.CompareLessThan(value, highEnd)); // highBegin <= value < highEnd .
                //Vector256<float> value2 = ConditionalSelect(highMask, highMapped, value);
                Vector256<float> value2 = ConditionalSelect_Relaxed(highMask, highMapped, value); // Avx.BlendVariable(value, highMapped, highMask);
                Vector256<uint> rt = Avx.ConvertToVector256Int32WithTruncation(value2).AsUInt32();
                return rt;
#else
                // Because CompareLessThanOrEqual has Exception: Error	CS1503	Argument 1: cannot convert from 'System.Runtime.Intrinsics.Vector256<float>' to 'System.Runtime.Intrinsics.Vector128<double>'	VectorTraits (netcoreapp3.0)
                return SuperStatics.ConvertToUInt32(value);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32(Vector256{float})"/>
            /// <remarks>Input range is `[-pow(2,31), pow(2,32))`. Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ConvertToUInt32_MappingFix(Vector256<float> value) {
#if NET5_0_OR_GREATER
                // [pow(2,31), pow(2,32)-1] mapping to [-pow(2,31), -1]. Subtract `pow(2,32)`.
                Vector256<float> highEnd = Vector256.Create(ScalarConstants.SingleBit_2Pow32).AsSingle();
                Vector256<float> lowBegin = Vector256.Create(ScalarConstants.SingleBit_Negative2Pow31).AsSingle();
                Vector256<float> highBegin = Vector256.Create(ScalarConstants.SingleBit_2Pow31).AsSingle();
                Vector256<float> lessHighEnd = Avx.CompareLessThan(value, highEnd); // value < highEnd .
                Vector256<float> highMapped = Avx.Subtract(value, highEnd);
                Vector256<float> lowMask = Avx.And(Avx.CompareLessThanOrEqual(lowBegin, value), lessHighEnd); // lowBegin <= value < highEnd .
                Vector256<float> value0 = Avx.And(value, lowMask); // If out of range, set to 0.
                Vector256<float> highMask = Avx.And(Avx.CompareLessThanOrEqual(highBegin, value), lessHighEnd); // highBegin <= value < highEnd .
                //Vector256<float> value2 = ConditionalSelect(highMask, highMapped, value0);
                Vector256<float> value2 = ConditionalSelect_Relaxed(highMask, highMapped, value); // Avx.BlendVariable(value0, highMapped, highMask);
                Vector256<uint> rt = Avx.ConvertToVector256Int32WithTruncation(value2).AsUInt32();
                return rt;
#else
                // Because CompareLessThanOrEqual has Exception: Error	CS1503	Argument 1: cannot convert from 'System.Runtime.Intrinsics.Vector256<float>' to 'System.Runtime.Intrinsics.Vector128<double>'	VectorTraits (netcoreapp3.0)
                return SuperStatics.ConvertToUInt32(value);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32(Vector256{float})"/>
            /// <remarks>Input range is all number (Use mod function). Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ConvertToUInt32_Mod(Vector256<float> value) {
#if NET5_0_OR_GREATER
                // remainder = mod(value, highEnd) = value - floor(value/highEnd)*highEnd
                Vector256<float> highEndDiv = Vector256.Create(ScalarConstants.SingleBit_2PowNegative32).AsSingle();
                Vector256<float> highEnd = Vector256.Create(ScalarConstants.SingleBit_2Pow32).AsSingle();
                Vector256<float> lowBegin = Vector256.Create(ScalarConstants.SingleBit_Negative2Pow31).AsSingle();
                Vector256<float> highBegin = Vector256.Create(ScalarConstants.SingleBit_2Pow31).AsSingle();
                Vector256<float> quotientFloor = Avx.Multiply(value, highEndDiv); // Avx.Divide(value, highEnd);
                quotientFloor = Avx.Floor(quotientFloor);
                Vector256<float> intRangeMask = Avx.And(Avx.CompareLessThanOrEqual(lowBegin, value), Avx.CompareLessThan(value, highBegin)); // lowBegin <= value < highBegin .
                Vector256<float> remainder = Avx.Subtract(value, Avx.Multiply(quotientFloor, highEnd));
                // [pow(2,31), pow(2,32)-1] mapping to [-pow(2,31), -1]. Subtract `pow(2,32)`.
                Vector256<float> uintRangeMask = Avx.And(Avx.CompareLessThanOrEqual(Vector256<float>.Zero, remainder), Avx.CompareLessThan(remainder, highEnd)); // lowBegin <= remainder < highEnd .
                Vector256<float> highMask = Avx.CompareLessThanOrEqual(highBegin, remainder); // highBegin <= value .
                Vector256<float> remainder0 = Avx.And(remainder, uintRangeMask); // If out of range, set to 0.
                Vector256<float> highMapped = Avx.Subtract(remainder0, highEnd);
                //Vector256<float> value2 = ConditionalSelect(highMask, highMapped, remainder0);
                Vector256<float> value2 = ConditionalSelect_Relaxed(highMask, highMapped, remainder0); // Avx.BlendVariable(remainder0, highMapped, highMask);
                // If within the signed integer range, return value, otherwise return value2 .
                Vector256<float> value3 = ConditionalSelect_Relaxed(intRangeMask, value, value2); // Avx.BlendVariable(value2, value, intRangeMask);
                Vector256<uint> rt = Avx.ConvertToVector256Int32WithTruncation(value3).AsUInt32();
                return rt;
#else
                // Because CompareLessThanOrEqual has Exception: Error	CS1503	Argument 1: cannot convert from 'System.Runtime.Intrinsics.Vector256<float>' to 'System.Runtime.Intrinsics.Vector128<double>'	VectorTraits (netcoreapp3.0)
                return SuperStatics.ConvertToUInt32(value);
#endif
            }


            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
                get {
                    //return SuperStatics.ConvertToUInt64_AcceleratedTypes;
                    return TypeCodeFlags.Double;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64(Vector256{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ConvertToUInt64(Vector256<double> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector256UInt64WithTruncation(value);
                }
#endif // NET8_0_OR_GREATER
                //return SuperStatics.ConvertToUInt64(value);
                return ConvertToUInt64_ShiftVar(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64(Vector256{double})"/>
            /// <remarks>Input range is `[0, pow(2,64))`. Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ConvertToUInt64_ShiftVar(Vector256<double> value) {
                // From Veloctor . MIT
                // https://github.com/Veloctor/Int128/blob/main/include/AVX2Ext.h
                // //  Only works for inputs in full uint64 range, otherwise result undefined
                // inline __m256i double_to_uint64_fast(const __m256d v) //9 instructions
                // {
                // 	//constants
                // 	__m256i mat_mask = _mm256_set1_epi64x(0x0FFFFFFFFFFFFF);	//0_00000000000_1111111111111111111111111111111111111111111111111111
                // 	__m256i hidden_1 = _mm256_set1_epi64x(0x10000000000000);	//0_00000000001_0000000000000000000000000000000000000000000000000000
                // 	__m256i exp_bias = _mm256_set1_epi64x(1023LL + 52);			//0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                // 	#define zero256 _mm256_setzero_si256()
                // 	//majik operations
                // 	__m256i bin = _mm256_castpd_si256(v);
                // 	__m256i mat = _mm256_and_si256(bin, mat_mask);					//1,1/3
                // 	mat = _mm256_or_si256(mat, hidden_1);							//1,1/3
                // 	__m256i exp_enc = _mm256_srli_epi64(bin, 52);					//1,1/2
                // 	__m256i exp_frac = _mm256_sub_epi64(exp_enc, exp_bias);			//1,1/3
                // 	__m256i msl = _mm256_sllv_epi64(mat, exp_frac);					//1,1/2
                // 	__m256i exp_frac_n = _mm256_sub_epi64(zero256, exp_frac);		//1,1/3
                // 	__m256i msr = _mm256_srlv_epi64(mat, exp_frac_n);				//1,1/2
                // 	__m256i exp_is_pos = _mm256_cmpgt_epi64(exp_frac, zero256);		//3,1
                // 	__m256i result_abs = _mm256_blendv_epi8(msr, msl, exp_is_pos);	//2,1
                // 	return result_abs;	//total latency: 12, total throughput CPI: 4.8
                // }
                //constants
                Vector256<long> mat_mask = Vector256.Create(ScalarConstants.DoubleVal_MantissaMask).AsInt64();  //0_00000000000_1111111111111111111111111111111111111111111111111111
                Vector256<long> hidden_1 = Vector256.Create(ScalarConstants.IntDbl_2Pow52).AsInt64();  //0_00000000001_0000000000000000000000000000000000000000000000000000 // Int64: 2^52
                Vector256<long> exp_bias = Vector256.Create(ScalarConstants.IntDbl_DoubleBias52).AsInt64(); //0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                Vector256<long> zero = Vector256<long>.Zero;
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector256<long> bin = value.AsInt64();
                Vector256<long> mat = Avx2.And(bin, mat_mask);                                    //1,1/3
                mat = Avx2.Or(mat, hidden_1);                                                     //1,1/3
                Vector256<long> exp_enc = Avx2.ShiftRightLogical(bin, 52);                        //1,1/2
                Vector256<long> exp_frac = Avx2.Subtract(exp_enc, exp_bias);                      //1,1/3
                Vector256<long> msl = Avx2.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt64());    //1,1/2
                Vector256<long> exp_frac_n = Avx2.Subtract(zero, exp_frac);                       //1,1/3
                Vector256<long> msr = Avx2.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt64()); //1,1/2
                Vector256<long> exp_is_pos = Avx2.CompareGreaterThan(exp_frac, zero);             //3,1
                Vector256<long> result_abs = ConditionalSelect_Relaxed(exp_is_pos, msl, msr); // Avx2.BlendVariable(msr, msl, exp_is_pos);            //2,1
                return result_abs.AsUInt64();	//total latency: 12, total throughput CPI: 4.8
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_Range52(Vector256{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ConvertToUInt64_Range52(Vector256<double> value) {
                return ConvertToUInt64_Range52_Impl(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_Range52(Vector256{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ConvertToUInt64_Range52_Impl(Vector256<double> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector256UInt64WithTruncation(value);
                }
#endif // NET8_0_OR_GREATER
                value = Avx.RoundToZero(value); // Truncate.
                return ConvertToUInt64_Range52RoundToEven(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_Range52RoundToEven(Vector256{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ConvertToUInt64_Range52RoundToEven(Vector256<double> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector256UInt64(value);
                }
#endif // NET8_0_OR_GREATER
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
                Vector256<double> magicNumber = Vector256.Create(ScalarConstants.DoubleVal_2Pow52); // Double value: pow(2, 52)
                Vector256<double> x = Avx.Add(value, magicNumber);
                Vector256<ulong> result = Avx2.Xor(x.AsUInt64(), magicNumber.AsUInt64());
                return result;
            }


            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits_AcceleratedTypes"/>
            public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<float> vector) {
                return (uint)Avx.MoveMask(vector);
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<double> vector) {
                return (uint)Avx.MoveMask(vector);
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<sbyte> vector) {
                return ExtractMostSignificantBits(vector.AsByte());
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<byte> vector) {
                return (uint)Avx2.MoveMask(vector);
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<short> vector) {
                return ExtractMostSignificantBits(vector.AsUInt16());
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<ushort> vector) {
                Vector256<byte> m = Avx2.Shuffle(vector.AsByte(), Vector256Constants.ExtractMostSignificantBits_Shuffle_HiByteOf16); // Packed the high byte. 0~7 is the source 0~7, 16~23 is the source 8~15, and the rest is cleared.
                m = Avx2.Permute4x64(m.AsUInt64(), (byte)ShuffleControlG4.XZYW).AsByte(); // Swap 16~23 bytes, to 8~15 .
                return (uint)Avx2.MoveMask(m);
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<int> vector) {
                return ExtractMostSignificantBits(vector.AsSingle());
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<uint> vector) {
                return ExtractMostSignificantBits(vector.AsSingle());
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<long> vector) {
                return ExtractMostSignificantBits(vector.AsDouble());
            }

            /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector256<ulong> vector) {
                return ExtractMostSignificantBits(vector.AsDouble());
            }


            /// <inheritdoc cref="IWVectorTraits256.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Floor(Vector256<float> value) {
                return Avx.Floor(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Floor(Vector256<double> value) {
                return Avx.Floor(value);
            }


            /// <inheritdoc cref="IWVectorTraits256.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{double}, Vector256{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Narrow(Vector256<double> lower, Vector256<double> upper) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return Avx512F.ConvertToVector256Single(lower.ToVector512Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                return Avx.ConvertToVector128Single(lower).ToVector256Unsafe().WithUpper(Avx.ConvertToVector128Single(upper));
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{short}, Vector256{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Narrow(Vector256<short> lower, Vector256<short> upper) {
#if NET8_0_OR_GREATER
                if (Avx512BW.IsSupported) {
                    return Avx512BW.ConvertToVector256SByte(lower.ToVector512Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                return Narrow(lower.AsUInt16(), upper.AsUInt16()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ushort}, Vector256{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Narrow(Vector256<ushort> lower, Vector256<ushort> upper) {
#if NET8_0_OR_GREATER
                if (Avx512BW.IsSupported) {
                    return Avx512BW.ConvertToVector256Byte(lower.ToVector512Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                //Vector256<ushort> mask = Vector256s<ushort>.VMaxByte;
                //Vector256<ushort> mask = Vector256.Create((ushort)byte.MaxValue); // .NET5+ has better performance .
                Vector256<ushort> mask = Vector256Constants.UInt16_VMaxByte;
                Vector256<byte> raw = Avx2.PackUnsignedSaturate(Avx2.And(lower, mask).AsInt16(), Avx2.And(upper, mask).AsInt16()); // bit64(x, z, y, w)
                Vector256<byte> rt = Avx2.Permute4x64(raw.AsUInt64(), (byte)ShuffleControlG4.XZYW).AsByte(); // Shuffle(bit64(x, z, y, w), XZYW) := bit64(x, y, z, w)
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{int}, Vector256{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Narrow(Vector256<int> lower, Vector256<int> upper) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return Avx512F.ConvertToVector256Int16(lower.ToVector512Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                return Narrow(lower.AsUInt32(), upper.AsUInt32()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{uint}, Vector256{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Narrow(Vector256<uint> lower, Vector256<uint> upper) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return Avx512F.ConvertToVector256UInt16(lower.ToVector512Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                Vector256<uint> mask = Vector256Constants.UInt32_VMaxUInt16;
                Vector256<ushort> raw = Avx2.PackUnsignedSaturate(Avx2.And(lower, mask).AsInt32(), Avx2.And(upper, mask).AsInt32()); // bit64(x, z, y, w)
                Vector256<ushort> rt = Avx2.Permute4x64(raw.AsUInt64(), (byte)ShuffleControlG4.XZYW).AsUInt16(); // ShuffleG4(bit64(x, z, y, w), XZYW) := bit64(x, y, z, w)
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{long}, Vector256{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Narrow(Vector256<long> lower, Vector256<long> upper) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return Avx512F.ConvertToVector256Int32(lower.ToVector512Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                return Narrow(lower.AsUInt64(), upper.AsUInt64()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ulong}, Vector256{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Narrow(Vector256<ulong> lower, Vector256<ulong> upper) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return Avx512F.ConvertToVector256UInt32(lower.ToVector512Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                //  vmovupd     ymm0,ymmword ptr [rbp-2B70h]  
                //  vpunpckldq  ymm0,ymm0,ymmword ptr [rbp-2B90h]  
                //  vmovupd     ymm1,ymmword ptr [rbp-2B70h]  
                //  vpunpckhdq  ymm1,ymm1,ymmword ptr [rbp-2B90h]  
                //  vpunpckldq  ymm0,ymm0,ymm1  
                //  vpermq      ymm0,ymm0,0D8h  
                //  vmovupd     ymmword ptr [rbp-2BB0h],ymm0
                Vector256<uint> l = Avx2.UnpackLow(lower.AsUInt32(), upper.AsUInt32()); // bit32(a0.L, b0.L, a0.H, b0.H, a2.L, b2.L, a2.H, b2.H)
                Vector256<uint> h = Avx2.UnpackHigh(lower.AsUInt32(), upper.AsUInt32()); // bit32(a1.L, b1.L, a1.H, b1.H, a3.L, b3.L, a3.H, b3.H)
                Vector256<uint> raw = Avx2.UnpackLow(l, h); // bit32(a0.L, a1.L, b0.L, b1.L, a2.L, a3.L, b2.L, b3.L). Need Permute4x64 to swap `b0.L, b1.L` and `a2.L, a3.L`.
                Vector256<uint> rt = Avx2.Permute4x64(raw.AsUInt64(), (byte)ShuffleControlG4.XZYW).AsUInt32(); // ShuffleG4(bit64(x, z, y, w), XZYW) := bit64(x, y, z, w)
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{sbyte}, int, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_Args(Vector256<sbyte> dummy, int shiftAmount, out Vector256<sbyte> args1) {
                var args0 = ShiftLeft_Args(dummy.AsByte(), shiftAmount, out var a1).AsSByte();
                args1 = a1.AsSByte();
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{byte}, int, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_Args(Vector256<byte> dummy, int shiftAmount, out Vector256<byte> args1) {
                _ = dummy;
                shiftAmount &= 7;
                var args0 = Vector256.Create((uint)shiftAmount).AsByte();
                args1 = Vector256Constants.GetResidueMaskBits_Byte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{short}, int, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_Args(Vector256<short> dummy, int shiftAmount, out Vector256<short> args1) {
                _ = dummy;
                //Vector128<short> xmm = Sse2.ConvertScalarToVector128Int32(shiftAmount & 0x0F).AsInt16();
                //Vector256<short> args0 = Vector256.Create(xmm, xmm);
                Vector256<short> args0 = Vector256.CreateScalarUnsafe((int)(shiftAmount & 0x0F)).AsInt16();
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{ushort}, int, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_Args(Vector256<ushort> dummy, int shiftAmount, out Vector256<ushort> args1) {
                var args0 = ShiftLeft_Args(dummy.AsInt16(), shiftAmount, out var a1).AsUInt16();
                args1 = a1.AsUInt16();
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{int}, int, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_Args(Vector256<int> dummy, int shiftAmount, out Vector256<int> args1) {
                _ = dummy;
                var args0 = Vector256.Create((int)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{uint}, int, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_Args(Vector256<uint> dummy, int shiftAmount, out Vector256<uint> args1) {
                _ = dummy;
                var args0 = Vector256.Create((uint)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{long}, int, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_Args(Vector256<long> dummy, int shiftAmount, out Vector256<long> args1) {
                _ = dummy;
                var args0 = Vector256.Create((long)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{ulong}, int, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_Args(Vector256<ulong> dummy, int shiftAmount, out Vector256<ulong> args1) {
                _ = dummy;
                var args0 = Vector256.Create((ulong)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_Core(Vector256<sbyte> value, int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                return ShiftLeft_Core(value.AsByte(), shiftAmount, args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_Core(Vector256<byte> value, int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
                _ = shiftAmount;
                var t = Avx2.And(value, args1).AsUInt32();
                return Avx2.ShiftLeftLogicalVariable(t, args0.AsUInt32()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_Core(Vector256<short> value, int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftLeftLogical(value, args0.GetLower());
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_Core(Vector256<ushort> value, int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftLeftLogical(value, args0.GetLower());
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_Core(Vector256<int> value, int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftLeftLogicalVariable(value, args0.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_Core(Vector256<uint> value, int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftLeftLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_Core(Vector256<long> value, int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftLeftLogicalVariable(value, args0.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_Core(Vector256<ulong> value, int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftLeftLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_Const(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftLeft_Const(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_Const(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                Vector256<byte> t = Avx2.And(value, Vector256Constants.GetResidueMaskBits_Byte(shiftAmount));
                return Avx2.ShiftLeftLogical(t.AsUInt32(), (byte)shiftAmount).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_Const(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_Const(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_Const(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_Const(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_Const(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_Const(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_ConstCore(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_ConstCore(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_ConstCore(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
#if NET6_0_OR_GREATER
                // The net6 JIT can compile constants to immediate numbers
                _ = args0;
                _ = args1;
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_ConstCore(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_ConstCore(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_ConstCore(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_ConstCore(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_ConstCore(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft_Fast(Vector256<sbyte> value, int shiftAmount) {
                return ShiftLeft_Fast(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft_Fast(Vector256<byte> value, int shiftAmount) {
                Vector256<byte> t = Avx2.And(value, Vector256Constants.GetResidueMaskBits_Byte(shiftAmount));
                return Avx2.ShiftLeftLogical(t.AsUInt32(), (byte)shiftAmount).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft_Fast(Vector256<short> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount); // For non-constant parameters, JIT will automatically use the Vector128 version (对于非常量参数, JIT会自动使用Vector128的版本). e.g. Avx2.ShiftLeftLogical(Vector256{ushort}, Vector128{ushort})
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft_Fast(Vector256<ushort> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft_Fast(Vector256<int> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft_Fast(Vector256<uint> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft_Fast(Vector256<long> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft_Fast(Vector256<ulong> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{sbyte}, int, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_Args(Vector256<sbyte> dummy, int shiftAmount, out Vector256<sbyte> args1) {
                _ = dummy;
                shiftAmount &= 7;
                var args0 = Vector256.Create((int)shiftAmount).AsSByte();
                args1 = Vector256Constants.GetResidueMaskBits_SByte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{short}, int, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic_Args(Vector256<short> dummy, int shiftAmount, out Vector256<short> args1) {
                _ = dummy;
                Vector256<short> args0 = Vector256.CreateScalarUnsafe((int)(shiftAmount & 0x0F)).AsInt16();
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{int}, int, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic_Args(Vector256<int> dummy, int shiftAmount, out Vector256<int> args1) {
                _ = dummy;
                var args0 = Vector256.Create((int)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{long}, int, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Args(Vector256<long> dummy, int shiftAmount, out Vector256<long> args1) {
                _ = dummy;
                shiftAmount &= 0x3F;
                var args0 = Vector256.Create((long)shiftAmount);
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_Core(Vector256<sbyte> value, int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                _ = shiftAmount;
                Vector256<sbyte> sign = Avx2.CompareGreaterThan(Vector256<sbyte>.Zero, value);
                Vector256<sbyte> shifted = Avx2.ShiftRightLogicalVariable(value.AsUInt32(), args0.AsUInt32()).AsSByte();
                Vector256<sbyte> rt = ConditionalSelect(args1, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic_Core(Vector256<short> value, int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightArithmetic(value, args0.GetLower());
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic_Core(Vector256<int> value, int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightArithmeticVariable(value, args0.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Core(Vector256<long> value, int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
                _ = shiftAmount;
                _ = args1;
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ShiftRightArithmeticVariable(value, args0.AsUInt64());
                }
#endif // NET8_0_OR_GREATER
                Vector256<long> sign = Avx2.CompareGreaterThan(Vector256<long>.Zero, value);
                Vector256<long> rt = Avx2.Xor(value, sign);
                rt = Avx2.ShiftRightLogicalVariable(rt, args0.AsUInt64());
                rt = Avx2.Xor(rt, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_Const(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic_Const(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic_Const(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Const(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ShiftRightArithmetic(value, (byte)shiftAmount);
                }
#endif // NET8_0_OR_GREATER
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_ConstCore(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic_ConstCore(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic_ConstCore(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_ConstCore(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ShiftRightArithmetic(value, (byte)shiftAmount);
                }
#endif // NET8_0_OR_GREATER
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_Fast(Vector256<sbyte> value, int shiftAmount) {
                //return ShiftRightArithmetic_Fast_Widen(value, shiftAmount);
                return ShiftRightArithmetic_Fast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_Fast_Widen(Vector256<sbyte> value, int shiftAmount) {
                Vector256<short> lowerToHigh = Avx2.ShiftLeftLogical(value.AsInt16(), 8);
                Vector256<short> lowerShifted = Avx2.ShiftRightArithmetic(lowerToHigh, (byte)shiftAmount);
                Vector256<sbyte> upper = Avx2.ShiftRightArithmetic(value.AsInt16(), (byte)shiftAmount).AsSByte();
                Vector256<sbyte> lower = Avx2.ShiftRightLogical(lowerShifted, 8).AsSByte();
                Vector256<sbyte> rt = Avx2.Or(Avx2.And(Vector256s<sbyte>.XyYMask, upper), lower);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic_Fast_Negative(Vector256<sbyte> value, int shiftAmount) {
                Vector256<sbyte> mask = Vector256Constants.GetResidueMaskBits_SByte(shiftAmount);
                Vector256<sbyte> shifted = Avx2.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsSByte();
                Vector256<sbyte> sign = Avx2.CompareGreaterThan(Vector256<sbyte>.Zero, value);
                Vector256<sbyte> rt = ConditionalSelect(mask, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic_Fast(Vector256<short> value, int shiftAmount) {
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic_Fast(Vector256<int> value, int shiftAmount) {
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Fast(Vector256<long> value, int shiftAmount) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ShiftRightArithmetic(value, (byte)shiftAmount);
                }
#endif // NET8_0_OR_GREATER
                return ShiftRightArithmetic_Fast_Xor(value, shiftAmount);
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Fast_Narrow(Vector256<long> value, int shiftAmount) {
                if (0 == shiftAmount) {
                    return value;
                }
                Vector256<long> rt;
                Vector256<int> lower, upper;
                Vector256<int> XyXMask = Vector256s<int>.XyXMask;
                const byte controlInputUpper = (byte)ShuffleControlG4.YYWW; // BitMath._MM_SHUFFLE(3, 3, 1, 1) = 0xF5 = 0b11_11_01_01;
                Vector256<int> upperAtLower = Avx2.Shuffle(value.AsInt32(), controlInputUpper); // f({ v0.lower, v0.upper, v1.lower, v1.upper, ... }) = { v0.upper, v0.upper, v1.upper, v1.upper, ... }
                upperAtLower = Avx2.And(XyXMask, upperAtLower); // = { v0.upper, 0, v1.upper, 0, ... }
                Vector256<int> upperOld = Avx2.AndNot(XyXMask, value.AsInt32()); // = { 0, v0.upper, 0, v1.upper, ... }
                if (32 <= shiftAmount) {
                    // Scalar algorithm:
                    //    uint lower = (uint)((int)value._upper >> (shiftAmount & 31));
                    //    uint upper = (uint)((int)value._upper >> 31);
                    lower = Avx2.ShiftRightArithmetic(upperAtLower, (byte)(shiftAmount & 31));
                    upper = Avx2.ShiftRightArithmetic(upperOld, 31);
                    rt = Avx2.Or(lower, upper).AsInt64();
                } else {
                    // Scalar algorithm:
                    //    uint lower = (value._lower >> shiftAmount) | (value._upper << (32 - shiftAmount));
                    //    uint upper = (uint)((int)value._upper >> shiftAmount);
                    Vector256<int> lowerOld = Avx2.And(XyXMask, value.AsInt32());
                    lower = Avx2.Or(Avx2.ShiftRightLogical(lowerOld, (byte)shiftAmount), Avx2.ShiftLeftLogical(upperAtLower, (byte)(32 - shiftAmount)));
                    upper = Avx2.ShiftRightArithmetic(upperOld, (byte)shiftAmount);
                    rt = Avx2.Or(lower, upper).AsInt64();
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Fast_NarrowIfLess(Vector256<long> value, int shiftAmount) {
                if (0 == shiftAmount) {
                    return value;
                }
                Vector256<int> XyXMask = Vector256s<int>.XyXMask;
                const byte controlInputUpper = (byte)ShuffleControlG4.YYWW; // BitMath._MM_SHUFFLE(3, 3, 1, 1) = 0xF5 = 0b11_11_01_01;
                Vector256<int> upperAtLower = Avx2.Shuffle(value.AsInt32(), controlInputUpper); // f({ v0.lower, v0.upper, v1.lower, v1.upper, ... }) = { v0.upper, v0.upper, v1.upper, v1.upper, ... }
                byte shiftAmountUpper = (byte)BitMath.Min(31, shiftAmount);
                byte shiftAmountLeft = (byte)BitMath.Max(0, 32 - shiftAmount);
                Vector256<int> lowerUse1Mask = Vector256.Create(BitMath.ToInt32Mask(32 <= shiftAmount));
                upperAtLower = Avx2.And(XyXMask, upperAtLower); // = { v0.upper, 0, v1.upper, 0, ... }
                Vector256<int> lowerOld = Avx2.And(XyXMask, value.AsInt32());
                Vector256<int> upperOld = Avx2.AndNot(XyXMask, value.AsInt32()); // = { 0, v0.upper, 0, v1.upper, ... }
                Vector256<int> lower2 = Avx2.Or(Avx2.ShiftRightLogical(lowerOld, (byte)shiftAmount), Avx2.ShiftLeftLogical(upperAtLower, shiftAmountLeft));
                Vector256<int> upper = Avx2.ShiftRightArithmetic(upperOld, shiftAmountUpper);
                Vector256<int> lower1 = Avx2.ShiftRightArithmetic(upperAtLower, (byte)(shiftAmount & 31));
                Vector256<int> lower = ConditionalSelect(lowerUse1Mask, lower1, lower2);
                Vector256<long> rt = Avx2.Or(lower, upper).AsInt64();
                return rt;
            }
#endif // !REDUCE_MEMORY_USAGE

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Fast_Negative(Vector256<long> value, int shiftAmount) {
                Vector256<long> sign = Avx2.CompareGreaterThan(Vector256<long>.Zero, value);
                byte shiftAmountLeft = (byte)(64 - shiftAmount);
                Vector256<long> rt = Avx2.Or(Avx2.ShiftRightLogical(value, (byte)shiftAmount), Avx2.ShiftLeftLogical(sign, shiftAmountLeft));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic_Fast_Xor(Vector256<long> value, int shiftAmount) {
                // t = -(x>>>31); return ((x^t)>>>n)^t; // From "Hacker's Delight", Page 18.
                Vector256<long> sign = Avx2.CompareGreaterThan(Vector256<long>.Zero, value); // Mask `0>x` is `-(x>>>31)`.
                Vector256<long> rt = Avx2.Xor(value, sign);
                rt = Avx2.ShiftRightLogical(rt, (byte)shiftAmount);
                rt = Avx2.Xor(rt, sign);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical(Vector256<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical(Vector256<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{sbyte}, int, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical_Args(Vector256<sbyte> dummy, int shiftAmount, out Vector256<sbyte> args1) {
                var args0 = ShiftRightLogical_Args(dummy.AsByte(), shiftAmount, out var a1).AsSByte();
                args1 = a1.AsSByte();
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{byte}, int, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_Args(Vector256<byte> dummy, int shiftAmount, out Vector256<byte> args1) {
                _ = dummy;
                shiftAmount &= 7;
                var args0 = Vector256.Create((uint)shiftAmount).AsByte();
                args1 = Vector256Constants.GetResidueMaskBits_Byte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{short}, int, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical_Args(Vector256<short> dummy, int shiftAmount, out Vector256<short> args1) {
                _ = dummy;
                Vector256<short> args0 = Vector256.CreateScalarUnsafe((int)(shiftAmount & 0x0F)).AsInt16();
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{ushort}, int, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical_Args(Vector256<ushort> dummy, int shiftAmount, out Vector256<ushort> args1) {
                var args0 = ShiftRightLogical_Args(dummy.AsInt16(), shiftAmount, out var a1).AsUInt16();
                args1 = a1.AsUInt16();
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{int}, int, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical_Args(Vector256<int> dummy, int shiftAmount, out Vector256<int> args1) {
                _ = dummy;
                var args0 = Vector256.Create((int)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{uint}, int, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical_Args(Vector256<uint> dummy, int shiftAmount, out Vector256<uint> args1) {
                _ = dummy;
                var args0 = Vector256.Create((uint)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{long}, int, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical_Args(Vector256<long> dummy, int shiftAmount, out Vector256<long> args1) {
                _ = dummy;
                var args0 = Vector256.Create((long)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{ulong}, int, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical_Args(Vector256<ulong> dummy, int shiftAmount, out Vector256<ulong> args1) {
                _ = dummy;
                var args0 = Vector256.Create((ulong)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical_Core(Vector256<sbyte> value, int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                return ShiftRightLogical_Core(value.AsByte(), shiftAmount, args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_Core(Vector256<byte> value, int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
                _ = shiftAmount;
                var rt = Avx2.ShiftRightLogicalVariable(value.AsUInt32(), args0.AsUInt32()).AsByte();
                rt = Avx2.And(rt, args1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical_Core(Vector256<short> value, int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightLogical(value, args0.GetLower());
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical_Core(Vector256<ushort> value, int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightLogical(value, args0.GetLower());
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical_Core(Vector256<int> value, int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightLogicalVariable(value, args0.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical_Core(Vector256<uint> value, int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical_Core(Vector256<long> value, int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightLogicalVariable(value, args0.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical_Core(Vector256<ulong> value, int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical_Const(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightLogical_Const(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_Const(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                Vector256<byte> mask = Vector256Constants.GetResidueMaskBits_Byte(shiftAmount);
                Vector256<byte> t = Avx2.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsByte();
                Vector256<byte> rt = Avx2.And(t, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical_Const(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical_Const(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical_Const(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical_Const(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical_Const(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical_Const(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical_ConstCore(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_ConstCore(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical_ConstCore(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
#if NET6_0_OR_GREATER
                // The net6 JIT can compile constants to immediate numbers
                _ = args0;
                _ = args1;
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical_ConstCore(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical_ConstCore(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical_ConstCore(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical_ConstCore(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical_ConstCore(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical_Fast(Vector256<sbyte> value, int shiftAmount) {
                return ShiftRightLogical_Fast(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_Fast(Vector256<byte> value, int shiftAmount) {
                return ShiftRightLogical_Fast_FirstShift(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_Fast_FirstAnd(Vector256<byte> value, int shiftAmount) {
                Vector256<byte> mask = Vector256Constants.GetMaskBits_Byte(shiftAmount);
                Vector256<byte> t = Avx2.AndNot(mask, value);
                Vector256<byte> rt = Avx2.ShiftRightLogical(t.AsUInt16(), (byte)shiftAmount).AsByte();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical_Fast_FirstShift(Vector256<byte> value, int shiftAmount) {
                Vector256<byte> mask = Vector256Constants.GetResidueMaskBits_Byte(shiftAmount);
                Vector256<byte> t = Avx2.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsByte();
                Vector256<byte> rt = Avx2.And(t, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical_Fast(Vector256<short> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical_Fast(Vector256<ushort> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical_Fast(Vector256<int> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical_Fast(Vector256<uint> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical_Fast(Vector256<long> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical_Fast(Vector256<ulong> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }


            /// <inheritdoc cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
            public static TypeCodeFlags Shuffle_AcceleratedTypes {
                get {
                    return YShuffleInsert_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Shuffle(Vector256<float> vector, Vector256<int> indices) {
                return Shuffle(vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Shuffle(Vector256<double> vector, Vector256<long> indices) {
                return Shuffle(vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Shuffle(Vector256<sbyte> vector, Vector256<sbyte> indices) {
                return Shuffle(vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Shuffle(Vector256<byte> vector, Vector256<byte> indices) {
                Vector256<sbyte> indicesAdded;
                Vector256<byte> mask, raw, rt;
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                        mask = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)32), indices);
                    } else {
                        indicesAdded = Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue));
                        mask = Avx2.CompareGreaterThan(
                            Vector256.Create((sbyte)(32 + sbyte.MinValue)),
                            indicesAdded
                        ).AsByte(); // Unsigned compare: (i < 32)
                    }
                    raw = YShuffleKernel(vector, indices);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                indicesAdded = Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue));
                mask = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(32 + sbyte.MinValue)),
                    indicesAdded
                ).AsByte(); // Unsigned compare: (i < 32)
                raw = YShuffleKernel(vector, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Shuffle(Vector256<short> vector, Vector256<short> indices) {
                return Shuffle(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Shuffle(Vector256<ushort> vector, Vector256<ushort> indices) {
                Vector256<ushort> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<ushort>.Zero); // Unsigned compare: (i < 16)
                raw = YShuffleKernel(vector, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Shuffle(Vector256<int> vector, Vector256<int> indices) {
                return Shuffle(vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Shuffle_Add1(Vector256<int> vector, Vector256<int> indices) {
                return Shuffle_Add1(vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Shuffle(Vector256<uint> vector, Vector256<uint> indices) {
                return Shuffle_EqualsShift(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Shuffle_Add1(Vector256<uint> vector, Vector256<uint> indices) {
                Vector256<int> indicesAdded;
                Vector256<uint> mask, raw, rt;
                indicesAdded = Avx2.Add(indices.AsInt32(), Vector256.Create(int.MinValue));
                mask = Avx2.CompareGreaterThan(
                    Vector256.Create((int)(8 + int.MinValue)),
                    indicesAdded
                ).AsUInt32(); // Unsigned compare: (i < 8)
                raw = YShuffleKernel(vector, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Shuffle_EqualsShift(Vector256<uint> vector, Vector256<uint> indices) {
                Vector256<uint> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<uint>.Zero); // Unsigned compare: (i < 8)
                raw = YShuffleKernel(vector, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Shuffle(Vector256<long> vector, Vector256<long> indices) {
                return Shuffle(vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Shuffle(Vector256<ulong> vector, Vector256<ulong> indices) {
                Vector256<ulong> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 2), Vector256<ulong>.Zero); // Unsigned compare: (i < 4)
                raw = YShuffleKernel(vector, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1) {
                Shuffle_Args(indices.AsByte(), out var a0, out var a1);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1) {
                YShuffleKernel_Args(indices, out args0, out args1);
#if NET8_0_OR_GREATER
                if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                    args1 = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)32), indices);
                    return;
                }
#endif // NET8_0_OR_GREATER
                var indicesAdded = Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue));
                Vector256<byte> mask = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(32 + sbyte.MinValue)),
                    indicesAdded
                ).AsByte(); // Unsigned compare: (i < 32)
                mask = OnesComplement(mask); // Used for _mm256_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = Avx2.Or(args0, mask);
                args1 = Avx2.Or(args1, mask);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1) {
                Shuffle_Args(indices.AsUInt16(), out var a0, out var a1);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1) {
                YShuffleKernel_Args(indices, out args0, out args1);
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    args1 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<ushort>.Zero); // Unsigned compare: (i < 16)
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<ushort> mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<ushort>.Zero); // Unsigned compare: (i < 16)
                mask = OnesComplement(mask); // Used for _mm256_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = Avx2.Or(args0, mask);
                args1 = Avx2.Or(args1, mask);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1) {
                Shuffle_Args(indices.AsUInt32(), out var a0, out var a1);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1) {
                args0 = indices;
                args1 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<uint>.Zero); // Unsigned compare: (i < 8)
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1) {
                Shuffle_Args(indices.AsUInt64(), out var a0, out var a1);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1) {
                YShuffleKernel_Args(indices, out args0, out _);
                args1 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 2), Vector256<ulong>.Zero); // Unsigned compare: (i < 4)
            }


            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Shuffle_Core(Vector256<float> vector, Vector256<int> args0, Vector256<int> args1) {
                return Shuffle_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Shuffle_Core(Vector256<double> vector, Vector256<long> args0, Vector256<long> args1) {
                return Shuffle_Core(vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Shuffle_Core(Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                return Shuffle_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Shuffle_Core(Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1) {
                var rt = YShuffleKernel_Core(vector, args0, args1);
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    rt = Avx2.And(rt, args1);
                }
#endif // NET8_0_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Shuffle_Core(Vector256<short> vector, Vector256<short> args0, Vector256<short> args1) {
                return Shuffle_Core(vector.AsUInt16(), args0.AsUInt16(), args1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Shuffle_Core(Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1) {
                var rt = YShuffleKernel_Core(vector, args0, args1);
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    rt = Avx2.And(rt, args1);
                }
#endif // NET8_0_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Shuffle_Core(Vector256<int> vector, Vector256<int> args0, Vector256<int> args1) {
                return Shuffle_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Shuffle_Core(Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1) {
                return Avx2.And(Avx2.PermuteVar8x32(vector, args0), args1);
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Shuffle_Core(Vector256<long> vector, Vector256<long> args0, Vector256<long> args1) {
                return Shuffle_Core(vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Shuffle_Core(Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1) {
                var rt = YShuffleKernel_Core(vector, args0, args1);
                rt = Avx2.And(rt, args1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Sum_AcceleratedTypes"/>
            public static TypeCodeFlags Sum_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum(Vector256<float> value) {
                // 0 1 2 3 4 5 6 7
                Vector256<float> m = Avx.HorizontalAdd(value, value); // Each 128-bit lane.
                // 01 23 01 23 45 67 45 67
                m = Avx.HorizontalAdd(m, m);
                // 0123 0123 0123 0123 4567 4567 4567 4567
                Vector128<float> n = Sse.Add(m.GetLower(), m.GetUpper());
                return n.GetElement(0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum(Vector256<double> value) {
                // 0 1 2 3
                Vector256<double> m = Avx.HorizontalAdd(value, value); // Each 128-bit lane.
                // 01 01 23 23
                Vector128<double> n = Sse2.Add(m.GetLower(), m.GetUpper());
                return n.GetElement(0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum(Vector256<sbyte> value) {
                Widen(value, out Vector256<short> l, out Vector256<short> h);
                Vector256<short> t = Avx2.Add(l, h);
                return (sbyte)Sum(t);
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum(Vector256<byte> value) {
                return (byte)Sum(value.AsSByte());
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum(Vector256<short> value) {
                Vector256<short> m = Avx2.HorizontalAdd(value, value); // Each 128-bit lane.
                m = Avx2.HorizontalAdd(m, m);
                m = Avx2.HorizontalAdd(m, m);
                Vector128<short> n = Sse2.Add(m.GetLower(), m.GetUpper());
                return (short)Sse2.ConvertToInt32(n.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum(Vector256<ushort> value) {
                return (ushort)Sum(value.AsInt16());
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum(Vector256<int> value) {
                // 0 1 2 3 4 5 6 7
                Vector256<int> m = Avx2.HorizontalAdd(value, value); // Each 128-bit lane.
                // 01 23 01 23 45 67 45 67
                m = Avx2.HorizontalAdd(m, m);
                // 0123 0123 0123 0123 4567 4567 4567 4567
                Vector128<int> n = Sse2.Add(m.GetLower(), m.GetUpper());
                return Sse2.ConvertToInt32(n);
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum(Vector256<uint> value) {
                return (uint)Sum(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum(Vector256<long> value) {
                // 0 1 2 3
                Vector256<long> m = Avx2.Permute4x64(value, (byte)ShuffleControlG4.WZYX);
                Vector256<long> n = Avx2.Add(value, m);
                // 03 12 12 03
                m = Avx2.Permute4x64(n, (byte)ShuffleControlG4.YXWZ);
                n = Avx2.Add(n, m);
                // 0123 0123 0123 0123
                return n.GetElement(0);
            }

            /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum(Vector256<ulong> value) {
                return (ulong)Sum(value.AsInt64());
            }


            /// <inheritdoc cref="IWVectorTraits256.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<float> source, out Vector256<double> lower, out Vector256<double> upper) {
                lower = Avx.ConvertToVector256Double(source.GetLower());
                upper = Avx.ConvertToVector256Double(source.GetUpper());
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{sbyte}, out Vector256{short}, out Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<sbyte> source, out Vector256<short> lower, out Vector256<short> upper) {
                Widen_ConvertTo(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{byte}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<byte> source, out Vector256<ushort> lower, out Vector256<ushort> upper) {
                Widen_ConvertTo(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{short}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<short> source, out Vector256<int> lower, out Vector256<int> upper) {
                Widen_ConvertTo(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{ushort}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<ushort> source, out Vector256<uint> lower, out Vector256<uint> upper) {
                Widen_ConvertTo(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{int}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<int> source, out Vector256<long> lower, out Vector256<long> upper) {
                Widen_ConvertTo(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{uint}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector256<uint> source, out Vector256<ulong> lower, out Vector256<ulong> upper) {
                Widen_ConvertTo(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{sbyte}, out Vector256{short}, out Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector256<sbyte> source, out Vector256<short> lower, out Vector256<short> upper) {
                lower = Avx2.ConvertToVector256Int16(source.GetLower());
                upper = Avx2.ConvertToVector256Int16(source.GetUpper());
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{byte}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector256<byte> source, out Vector256<ushort> lower, out Vector256<ushort> upper) {
                lower = Avx2.ConvertToVector256Int16(source.GetLower()).AsUInt16();
                upper = Avx2.ConvertToVector256Int16(source.GetUpper()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{short}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector256<short> source, out Vector256<int> lower, out Vector256<int> upper) {
                lower = Avx2.ConvertToVector256Int32(source.GetLower());
                upper = Avx2.ConvertToVector256Int32(source.GetUpper());
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{ushort}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector256<ushort> source, out Vector256<uint> lower, out Vector256<uint> upper) {
                lower = Avx2.ConvertToVector256Int32(source.GetLower()).AsUInt32();
                upper = Avx2.ConvertToVector256Int32(source.GetUpper()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{int}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector256<int> source, out Vector256<long> lower, out Vector256<long> upper) {
                lower = Avx2.ConvertToVector256Int64(source.GetLower());
                upper = Avx2.ConvertToVector256Int64(source.GetUpper());
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{uint}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector256<uint> source, out Vector256<ulong> lower, out Vector256<ulong> upper) {
                lower = Avx2.ConvertToVector256Int64(source.GetLower()).AsUInt64();
                upper = Avx2.ConvertToVector256Int64(source.GetUpper()).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{sbyte}, out Vector256{short}, out Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector256<sbyte> source, out Vector256<short> lower, out Vector256<short> upper) {
                // vmovupd     ymm0,ymmword ptr [rbp-790h]  
                // vpermq      ymm0,ymm0,0D4h  
                // vxorps      ymm1,ymm1,ymm1  
                // vpcmpgtb    ymm1,ymm1,ymm0  
                // vpunpcklbw  ymm0,ymm0,ymm1  
                // vmovupd     ymmword ptr [rbp-70h],ymm0  
                // vmovupd     ymm0,ymmword ptr [rbp-790h]  
                // vpermq      ymm0,ymm0,0E8h  
                // vxorps      ymm1,ymm1,ymm1  
                // vpcmpgtb    ymm1,ymm1,ymm0  
                // vpunpckhbw  ymm0,ymm0,ymm1  
                // vmovupd     ymmword ptr [rbp-90h],ymm0  
                Vector256<sbyte> zero = Vector256<sbyte>.Zero;
                Vector256<sbyte> lower0 = Avx2.Permute4x64(source.AsUInt64(), (byte)ShuffleControlG4.XYYW).AsSByte(); // UnpackLow uses only `X_Y_`.
                Vector256<sbyte> upper0 = Avx2.Permute4x64(source.AsUInt64(), (byte)ShuffleControlG4.XZZW).AsSByte(); // UnpackHigh uses only `_Z_W`.
                Vector256<sbyte> lowerMask = Avx2.CompareGreaterThan(zero, lower0); // sign[i] = (lower0[i]<0)?-1:0
                Vector256<sbyte> upperMask = Avx2.CompareGreaterThan(zero, upper0); // sign[i] = (source1[i]<0)?-1:0
                lower = Avx2.UnpackLow(lower0, lowerMask).AsInt16();
                upper = Avx2.UnpackLow(upper0, upperMask).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{byte}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector256<byte> source, out Vector256<ushort> lower, out Vector256<ushort> upper) {
                // vmovupd     ymm0,ymmword ptr [rbp-7D0h]  
                // vpermq      ymm0,ymm0,0D4h  
                // vxorps      ymm1,ymm1,ymm1  
                // vpunpcklbw  ymm0,ymm0,ymm1  
                // vmovupd     ymmword ptr [rbp-0B0h],ymm0  
                // vmovupd     ymm0,ymmword ptr [rbp-7D0h]  
                // vpermq      ymm0,ymm0,0E8h  
                // vxorps      ymm1,ymm1,ymm1  
                // vpunpckhbw  ymm0,ymm0,ymm1  
                // vmovupd     ymmword ptr [rbp-0D0h],ymm0  
                Vector256<byte> zero = Vector256<byte>.Zero;
                Vector256<byte> lower0 = Avx2.Permute4x64(source.AsUInt64(), (byte)ShuffleControlG4.XYYW).AsByte(); // UnpackLow uses only `X_Y_`.
                Vector256<byte> upper0 = Avx2.Permute4x64(source.AsUInt64(), (byte)ShuffleControlG4.XZZW).AsByte(); // UnpackHigh uses only `_Z_W`.
                lower = Avx2.UnpackLow(lower0, zero).AsUInt16();
                upper = Avx2.UnpackHigh(upper0, zero).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{short}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector256<short> source, out Vector256<int> lower, out Vector256<int> upper) {
                Vector256<short> zero = Vector256<short>.Zero;
                Vector256<short> lower0 = Avx2.Permute4x64(source.AsUInt64(), (byte)ShuffleControlG4.XYYW).AsInt16();
                Vector256<short> upper0 = Avx2.Permute4x64(source.AsUInt64(), (byte)ShuffleControlG4.XZZW).AsInt16();
                Vector256<short> lowerMask = Avx2.CompareGreaterThan(zero, lower0);
                Vector256<short> upperMask = Avx2.CompareGreaterThan(zero, upper0);
                lower = Avx2.UnpackLow(lower0, lowerMask).AsInt32();
                upper = Avx2.UnpackHigh(upper0, upperMask).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{ushort}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector256<ushort> source, out Vector256<uint> lower, out Vector256<uint> upper) {
                Vector256<ushort> zero = Vector256<ushort>.Zero;
                Vector256<ushort> lower0 = Avx2.Permute4x64(source.AsUInt64(), (byte)ShuffleControlG4.XYYW).AsUInt16();
                Vector256<ushort> upper0 = Avx2.Permute4x64(source.AsUInt64(), (byte)ShuffleControlG4.XZZW).AsUInt16();
                lower = Avx2.UnpackLow(lower0, zero).AsUInt32();
                upper = Avx2.UnpackHigh(upper0, zero).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{int}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector256<int> source, out Vector256<long> lower, out Vector256<long> upper) {
                Vector256<int> zero = Vector256<int>.Zero;
                Vector256<int> lower0 = Avx2.Permute4x64(source.AsUInt64(), (byte)ShuffleControlG4.XYYW).AsInt32();
                Vector256<int> upper0 = Avx2.Permute4x64(source.AsUInt64(), (byte)ShuffleControlG4.XZZW).AsInt32();
                Vector256<int> lowerMask = Avx2.CompareGreaterThan(zero, lower0);
                Vector256<int> upperMask = Avx2.CompareGreaterThan(zero, upper0);
                lower = Avx2.UnpackLow(lower0, lowerMask).AsInt64();
                upper = Avx2.UnpackHigh(upper0, upperMask).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{uint}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector256<uint> source, out Vector256<ulong> lower, out Vector256<ulong> upper) {
                Vector256<uint> zero = Vector256<uint>.Zero;
                Vector256<uint> lower0 = Avx2.Permute4x64(source.AsUInt64(), (byte)ShuffleControlG4.XYYW).AsUInt32();
                Vector256<uint> upper0 = Avx2.Permute4x64(source.AsUInt64(), (byte)ShuffleControlG4.XZZW).AsUInt32();
                lower = Avx2.UnpackLow(lower0, zero).AsUInt64();
                upper = Avx2.UnpackHigh(upper0, zero).AsUInt64();
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
