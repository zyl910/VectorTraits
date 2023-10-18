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

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    /// <summary>
    /// <see cref="Vector128{T}"/> traits - Sse .
    /// </summary>
    public sealed partial class WVectorTraits128Sse : WVectorTraits128SseAbstract {
        private static readonly WVectorTraits128Sse _instance = new WVectorTraits128Sse(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits128Sse Instance {
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
                rt = "Vector128 type is not supported! " + rt;
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
                if (System.Runtime.Intrinsics.X86.Sse.IsSupported) rt += separator + "Sse";
                if (System.Runtime.Intrinsics.X86.Sse2.IsSupported) rt += separator + "Sse2";
                if (System.Runtime.Intrinsics.X86.Sse3.IsSupported) rt += separator + "Sse3";
                if (System.Runtime.Intrinsics.X86.Ssse3.IsSupported) rt += separator + "Ssse3";
                if (System.Runtime.Intrinsics.X86.Sse41.IsSupported) rt += separator + "Sse41";
                if (System.Runtime.Intrinsics.X86.Sse42.IsSupported) rt += separator + "Sse42";
                if (System.Runtime.Intrinsics.X86.Avx.IsSupported) rt += separator + "Avx";
                if (System.Runtime.Intrinsics.X86.Avx2.IsSupported) rt += separator + "Avx2";
                // done.
                if (!string.IsNullOrEmpty(rt)) {
                    rt = rt.Substring(separator.Length);
                }
#endif // NETCOREAPP3_0_OR_GREATER
                return rt;
            }

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Ceiling(Vector128<float> value) {
                return Avx.Ceiling(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Ceiling(Vector128<double> value) {
                return Avx.Ceiling(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble(Vector128<long> value) {
                return ConvertToDouble_Bcl(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Bcl(Vector128<long> value) {
                // From: src/libraries/System.Private.CoreLib/src/System/Runtime/Intrinsics/Vector128.cs
                // Based on __m128d int64_to_double_fast_precise(const __m128i v)
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                Vector128<int> lowerBits;
                lowerBits = value.AsInt32();
                lowerBits = Avx2.Blend(lowerBits, Vector128.Create(ScalarConstants.DoubleVal_2Pow52).AsInt32(), 0b10101010); // Blend the 32 lowest significant bits of vector with the bit representation of double(2^52)
                Vector128<long> upperBits = Avx2.ShiftRightLogical(value, 32);                                               // Extract the 32 most significant bits of vector
                upperBits = Avx2.Xor(upperBits, Vector128.Create(ScalarConstants.DoubleVal_2Pow84_2Pow63).AsInt64());        // Flip the msb of upperBits and blend with the bit representation of double(2^84 + 2^63)
                Vector128<double> result = Avx.Subtract(upperBits.AsDouble(), Vector128.Create(ScalarConstants.DoubleVal_2Pow84_2Pow63_2Pow52)); // Compute in double precision: (upper - (2^84 + 2^63 + 2^52)) + lower
                return Avx.Add(result, lowerBits.AsDouble());
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Bcl_Wim(Vector128<long> value) {
                // Same ConvertToDouble_Bcl.
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 19, 2016 at 12:51 wim
                //__m128d int64_to_double_fast_precise(const __m128i v) {
                //    __m128i magic_i_lo   = _mm128_set1_epi64x(0x4330000000000000);                /* 2^52               encoded as floating-point  */
                //    __m128i magic_i_hi32 = _mm128_set1_epi64x(0x4530000080000000);                /* 2^84 + 2^63        encoded as floating-point  */
                //    __m128i magic_i_all  = _mm128_set1_epi64x(0x4530000080100000);                /* 2^84 + 2^63 + 2^52 encoded as floating-point  */
                //    __m128d magic_d_all  = _mm128_castsi128_pd(magic_i_all);
                //    __m128i v_lo         = _mm128_blend_epi32(magic_i_lo, v, 0b01010101);         /* Blend the 32 lowest significant bits of v with magic_int_lo                                                   */
                //    __m128i v_hi         = _mm128_srli_epi64(v, 32);                              /* Extract the 32 most significant bits of v                                                                     */
                //            v_hi         = _mm128_xor_si128(v_hi, magic_i_hi32);                  /* Flip the msb of v_hi and blend with 0x45300000                                                                */
                //    __m128d v_hi_dbl     = _mm128_sub_pd(_mm128_castsi128_pd(v_hi), magic_d_all); /* Compute in double precision:                                                                                  */
                //    __m128d result       = _mm128_add_pd(v_hi_dbl, _mm128_castsi128_pd(v_lo));    /* (v_hi - magic_d_all) + v_lo  Do not assume associativity of floating point addition !!                        */
                //            return result;                                                        /* With gcc use -O3, then -fno-associative-math is default. Do not use -Ofast, which enables -fassociative-math! */
                //}
                Vector128<long> magic_i_lo = Vector128.Create(0x43300000_00000000);   // 2^52               encoded as floating-point
                Vector128<long> magic_i_hi32 = Vector128.Create(0x45300000_80000000); // 2^84 + 2^63        encoded as floating-point
                Vector128<long> magic_i_all = Vector128.Create(0x45300000_80100000);  // 2^84 + 2^63 + 2^52 encoded as floating-point
                Vector128<double> magic_d_all = magic_i_all.AsDouble();
                Vector128<int> v_lo = Avx2.Blend(value.AsInt32(), magic_i_lo.AsInt32(), 0b10101010); // Blend the 32 lowest significant bits of v with magic_int_lo (double(2^52))
                Vector128<long> v_hi = Avx2.ShiftRightLogical(value, 32);                            // Extract the 32 most significant bits of v
                v_hi = Avx2.Xor(v_hi, magic_i_hi32);                                                 // Flip the msb of v_hi and blend with magic_i_hi32 (double(2^84 + 2^63))
                Vector128<double> v_hi_dbl = Avx.Subtract(v_hi.AsDouble(), magic_d_all);             // Compute in double precision:
                Vector128<double> result = Avx.Add(v_hi_dbl, v_lo.AsDouble());                       // (v_hi - (2^84 + 2^63 + 2^52)) + v_lo  Do not assume associativity of floating point addition !!
                return result;
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_HwScalar(Vector128<long> value) {
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 19, 2016 at 12:51 wim
                // __m128d int64_to_double_based_on_cvtsi2sd(const __m128i v){
                //     __m128d zero         = _mm_setzero_pd();                            /* to avoid uninitialized variables in_mm_cvtsi64_sd                       */
                //     __m128i v_lo         = _mm128_castsi128_si128(v);
                //     __m128i v_hi         = _mm128_extracti128_si128(v,1);
                //     __m128d v_0          = _mm_cvtsi64_sd(zero,_mm_cvtsi128_si64(v_lo));
                //     __m128d v_2          = _mm_cvtsi64_sd(zero,_mm_cvtsi128_si64(v_hi));
                //     __m128d v_1          = _mm_cvtsi64_sd(zero,_mm_extract_epi64(v_lo,1));
                //     __m128d v_3          = _mm_cvtsi64_sd(zero,_mm_extract_epi64(v_hi,1));
                //     __m128d v_01         = _mm_unpacklo_pd(v_0,v_1);
                //     __m128d v_23         = _mm_unpacklo_pd(v_2,v_3);
                //     __m128d v_dbl        = _mm128_castpd128_pd128(v_01);
                //             v_dbl        = _mm128_insertf128_pd(v_dbl,v_23,1);
                //     return v_dbl;
                // }
                if (Sse2.X64.IsSupported && Sse41.X64.IsSupported) {
                    Vector128<double> zero = Vector128<double>.Zero;
                    Vector128<double> v_0 = Sse2.X64.ConvertScalarToVector128Double(zero, Sse2.X64.ConvertToInt64(value));
                    Vector128<double> v_1 = Sse2.X64.ConvertScalarToVector128Double(zero, Sse41.X64.Extract(value, 1));
                    Vector128<double> result = Sse2.UnpackLow(v_0, v_1);
                    return result;
                } else {
                    return SuperStatics.ConvertToDouble(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble_Range52(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Range52(Vector128<long> value) {
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 14, 2016 at 17:23 Mysticial
                // inline __m128d int64_to_double128(__m128i x){
                //     /*  Mysticial's fast int64_to_double. Works for inputs in the range: (-2^51, 2^51)  */
                //     x = _mm128_add_epi64(x, _mm128_castpd_si128(_mm128_set1_pd(0x0018000000000000)));
                //     return _mm128_sub_pd(_mm128_castsi128_pd(x), _mm128_set1_pd(0x0018000000000000));
                // }
                // BitConverter.DoubleToInt64Bits((double)0x0018000000000000).ToString("X") = "4338000000000000"
                Vector128<long> magicNumber = Vector128.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51).AsInt64(); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector128<long> x = Avx2.Add(value, magicNumber);
                Vector128<double> result = Avx.Subtract(x.AsDouble(), magicNumber.AsDouble());
                return result;
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble(Vector128<ulong> value) {
                return ConvertToDouble_Bcl(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Bcl(Vector128<ulong> value) {
                // From: src/libraries/System.Private.CoreLib/src/System/Runtime/Intrinsics/Vector128.cs
                // Based on __m128d uint64_to_double_fast_precise(const __m128i v)
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                Vector128<uint> lowerBits;
                lowerBits = value.AsUInt32();
                lowerBits = Avx2.Blend(lowerBits, Vector128.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt32(), 0b10101010); // Blend the 32 lowest significant bits of vector with the bit representation of double(2^52)                                                 */
                Vector128<ulong> upperBits = Avx2.ShiftRightLogical(value, 32);                                               // Extract the 32 most significant bits of vector
                upperBits = Avx2.Xor(upperBits, Vector128.Create(ScalarConstants.DoubleVal_2Pow84).AsUInt64());               // Blend upperBits with the bit representation of double(2^84)
                Vector128<double> result = Avx.Subtract(upperBits.AsDouble(), Vector128.Create(ScalarConstants.DoubleVal_2Pow84_2Pow52)); // Compute in double precision: (upper - (2^84 + 2^52)) + lower
                return Avx.Add(result, lowerBits.AsDouble());
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Bcl_Wim(Vector128<ulong> value) {
                // Same ConvertToDouble_Bcl.
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 19, 2016 at 12:51 wim
                //__m128d uint64_to_double_fast_precise(const __m128i v) {
                //    __m128i magic_i_lo   = _mm128_set1_epi64x(0x4330000000000000);                /* 2^52        encoded as floating-point  */
                //    __m128i magic_i_hi32 = _mm128_set1_epi64x(0x4530000000000000);                /* 2^84        encoded as floating-point  */
                //    __m128i magic_i_all  = _mm128_set1_epi64x(0x4530000000100000);                /* 2^84 + 2^52 encoded as floating-point  */
                //    __m128d magic_d_all  = _mm128_castsi128_pd(magic_i_all);
                //    __m128i v_lo         = _mm128_blend_epi32(magic_i_lo, v, 0b01010101);         /* Blend the 32 lowest significant bits of v with magic_int_lo                                                   */
                //    __m128i v_hi         = _mm128_srli_epi64(v, 32);                              /* Extract the 32 most significant bits of v                                                                     */
                //            v_hi         = _mm128_xor_si128(v_hi, magic_i_hi32);                  /* Blend v_hi with 0x45300000                                                                                    */
                //    __m128d v_hi_dbl     = _mm128_sub_pd(_mm128_castsi128_pd(v_hi), magic_d_all); /* Compute in double precision:                                                                                  */
                //    __m128d result       = _mm128_add_pd(v_hi_dbl, _mm128_castsi128_pd(v_lo));    /* (v_hi - magic_d_all) + v_lo  Do not assume associativity of floating point addition !!                        */
                //            return result;                                                        /* With gcc use -O3, then -fno-associative-math is default. Do not use -Ofast, which enables -fassociative-math! */
                //}
                Vector128<long> magic_i_lo = Vector128.Create(0x43300000_00000000);   // 2^52        encoded as floating-point
                Vector128<long> magic_i_hi32 = Vector128.Create(0x45300000_00000000); // 2^84        encoded as floating-point
                Vector128<long> magic_i_all = Vector128.Create(0x45300000_00100000);  // 2^84 + 2^52 encoded as floating-point
                Vector128<double> magic_d_all = magic_i_all.AsDouble();
                Vector128<int> v_lo = Avx2.Blend(value.AsInt32(), magic_i_lo.AsInt32(), 0b10101010); // Blend the 32 lowest significant bits of v with magic_int_lo (double(2^52))
                Vector128<long> v_hi = Avx2.ShiftRightLogical(value, 32).AsInt64();                  // Extract the 32 most significant bits of v
                v_hi = Avx2.Xor(v_hi, magic_i_hi32);                                                 // Blend v_hi with magic_i_hi32 (double(2^84))
                Vector128<double> v_hi_dbl = Avx.Subtract(v_hi.AsDouble(), magic_d_all);             // Compute in double precision:
                Vector128<double> result = Avx.Add(v_hi_dbl, v_lo.AsDouble());                       // (v_hi - magic_d_all) + v_lo  Do not assume associativity of floating point addition !!
                return result;
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble_Range52(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Range52(Vector128<ulong> value) {
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 14, 2016 at 17:23 Mysticial
                // inline __m128d uint64_to_double128(__m128i x){
                //     /*  Mysticial's fast uint64_to_double. Works for inputs in the range: [0, 2^52)     */
                //     x = _mm128_or_si128(x, _mm128_castpd_si128(_mm128_set1_pd(0x0010000000000000)));
                //     return _mm128_sub_pd(_mm128_castsi128_pd(x), _mm128_set1_pd(0x0010000000000000));
                // }
                // BitConverter.DoubleToInt64Bits((double)0x0010000000000000).ToString("X") = "4330000000000000"
                Vector128<ulong> magicNumber = Vector128.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt64(); // Double value: pow(2, 52)
                Vector128<ulong> x = Avx2.Or(value, magicNumber);
                Vector128<double> result = Avx.Subtract(x.AsDouble(), magicNumber.AsDouble());
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
                return Avx.ConvertToVector128Int32WithTruncation(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    //TypeCodeFlags rt = SuperStatics.ConvertToInt64_AcceleratedTypes;
                    TypeCodeFlags rt = TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64(Vector128<double> value) {
                // return SuperStatics.ConvertToInt64(value);
                // return ConvertToInt64_HwScalar(value);
                return ConvertToInt64_ShiftVarFix(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_HwScalar(Vector128<double> value) {
                if (Sse2.X64.IsSupported) {
                    // Same 256bit: Vector256<double> valueOdd = Avx2.Permute4x64(value, (byte)ShuffleControlG4.YYWW);
                    Vector128<double> valueOdd = Sse2.Shuffle(value, value, (byte)ShuffleControlG2.YY);
                    long v_0 = Sse2.X64.ConvertToInt64WithTruncation(value);
                    long v_1 = Sse2.X64.ConvertToInt64WithTruncation(valueOdd);
                    Vector128<long> result = Vector128.Create(v_0, v_1);
                    return result;
                } else {
                    return SuperStatics.ConvertToInt64(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
            /// <remarks>Input range is `[-pow(2,63), pow(2,63))`. Out of range results in `0`.</remarks>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_ShiftVar(Vector128<double> value) {
                // From Veloctor . MIT
                // https://github.com/Veloctor/Int128/blob/main/include/AVX2Ext.h
                // inline __m128i double_to_int64_fast(const __m128d v) //13 instructions
                // {
                // 	//constants
                // 	__m128i mat_mask = _mm128_set1_epi64x(0x0FFFFFFFFFFFFF);	//0_00000000000_1111111111111111111111111111111111111111111111111111
                // 	__m128i hidden_1 = _mm128_set1_epi64x(0x10000000000000);	//0_00000000001_0000000000000000000000000000000000000000000000000000
                // 	__m128i exp_bias = _mm128_set1_epi64x(1023LL + 52);			//0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                // 	#define zero128 _mm128_setzero_si128()
                // 	//majik operations										  //Latency, Throughput(references IceLake)
                // 	__m128i bin = _mm128_castpd_si128(v);
                // 	__m128i negative = _mm128_cmpgt_epi64(zero128, bin);			//3,1
                // 	__m128i mat = _mm128_and_si128(bin, mat_mask);					//1,1/3
                // 	mat = _mm128_or_si128(mat, hidden_1);							//1,1/3
                // 	__m128i exp_enc = _mm128_slli_epi64(bin, 1);					//1,1/2
                // 	exp_enc = _mm128_srli_epi64(exp_enc, 53);						//1,1/2
                // 	__m128i exp_frac = _mm128_sub_epi64(exp_enc, exp_bias);			//1,1/3
                // 	__m128i msl = _mm128_sllv_epi64(mat, exp_frac);					//1,1/2
                // 	__m128i exp_frac_n = _mm128_sub_epi64(zero128, exp_frac);		//1,1/3
                // 	__m128i msr = _mm128_srlv_epi64(mat, exp_frac_n);				//1,1/2
                // 	__m128i exp_is_pos = _mm128_cmpgt_epi64(exp_frac, zero128);		//3,1
                // 	__m128i result_abs = _mm128_blendv_epi8(msr, msl, exp_is_pos);	//2,1
                // 	__m128i result = _mm128_xor_si128(result_abs, negative);		//1,1/3
                // 	result = _mm128_sub_epi64(result, negative);					//1,1/3
                // 	return result;	//total latency: 18, total throughput CPI: 7
                // }
                //constants
                Vector128<long> mat_mask = Vector128.Create(ScalarConstants.DoubleVal_MantissaMask).AsInt64();  //0_00000000000_1111111111111111111111111111111111111111111111111111
                Vector128<long> hidden_1 = Vector128.Create(ScalarConstants.IntDbl_2Pow52).AsInt64();  //0_00000000001_0000000000000000000000000000000000000000000000000000 // Int64: 2^52
                Vector128<long> exp_bias = Vector128.Create(ScalarConstants.IntDbl_DoubleBias52).AsInt64(); //0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                Vector128<long> zero = Vector128<long>.Zero;
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector128<long> bin = value.AsInt64();
                Vector128<long> negative = Avx2.CompareGreaterThan(zero, bin);                    //3,1
                Vector128<long> mat = Avx2.And(bin, mat_mask);                                    //1,1/3
                mat = Avx2.Or(mat, hidden_1);                                                     //1,1/3
                Vector128<long> exp_enc = Avx2.ShiftLeftLogical(bin, 1);                          //1,1/2
                exp_enc = Avx2.ShiftRightLogical(exp_enc, 53);                                    //1,1/2
                Vector128<long> exp_frac = Avx2.Subtract(exp_enc, exp_bias);                      //1,1/3
                Vector128<long> msl = Avx2.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt64());    //1,1/2
                Vector128<long> exp_frac_n = Avx2.Subtract(zero, exp_frac);                       //1,1/3
                Vector128<long> msr = Avx2.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt64()); //1,1/2
                Vector128<long> exp_is_pos = Avx2.CompareGreaterThan(exp_frac, zero);             //3,1
                Vector128<long> result_abs = Avx2.BlendVariable(msr, msl, exp_is_pos);            //2,1
                Vector128<long> result = Avx2.Xor(result_abs, negative);                          //1,1/3
                result = Avx2.Subtract(result, negative);                                         //1,1/3
                return result;  //total latency: 18, total throughput CPI: 7
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
            /// <remarks>Input range is all number. Out of range results is `-pow(2,63)`.</remarks>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_ShiftVarFix(Vector128<double> value) {
                Vector128<long> mat_mask = Vector128.Create(ScalarConstants.DoubleVal_MantissaMask).AsInt64(); // Element: 0x000FFFFF_FFFFFFFF
                Vector128<long> hidden_1 = Vector128.Create(ScalarConstants.IntDbl_2Pow52).AsInt64(); // Element: 0x00100000_00000000
                Vector128<long> exp_bias = Vector128.Create(ScalarConstants.IntDbl_DoubleBias52).AsInt64(); // Element: ScalarConstants.Double_ExponentBias + ScalarConstants.Double_MantissaBits =  = 1023 + 52 = 1075 = 0x433
                Vector128<long> zero = Vector128<long>.Zero;
                Vector128<long> exp_max = Vector128.Create(ScalarConstants.IntDbl_DoubleBias62).AsInt64(); // Element: ScalarConstants.Double_ExponentBias + 63-1 = 1023 + 62 = 1085 = 0x43D. Because `long.MaxValue` is `pow(2,63)-1`.
                Vector128<long> defValue = Vector128Constants.Double_SignMask.AsInt64(); // Out of range results is `-pow(2,63)`
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector128<long> bin = value.AsInt64();
                Vector128<long> negative = Avx2.CompareGreaterThan(zero, bin);                     //3,1. negative[i] = (0 < bin[i])
                Vector128<long> mat = Avx2.And(bin, mat_mask);                                     //1,1/3. Get mantissa field.
                mat = Avx2.Or(mat, hidden_1);                                                      //1,1/3. Convert mantissa field to integer.
                Vector128<long> exp_enc = Avx2.ShiftLeftLogical(bin, 1);                           //1,1/2. Remove sign bit.
                exp_enc = Avx2.ShiftRightLogical(exp_enc, 1 + ScalarConstants.Double_MantissaBits);//1,1/2. (bin[i]<<1)>>(1+52) = abs_double(bin[i])>>52
                Vector128<long> exp_frac = Avx2.Subtract(exp_enc, exp_bias);                       //1,1/3. Convert exponent field to shift amount .
                Vector128<long> exp_frac_n = Avx2.Subtract(zero, exp_frac);                        //1,1/3. exp_frac_n[i] = -exp_frac[i]
                Vector128<long> exp_is_end = Avx2.CompareGreaterThan(exp_enc, exp_max);            //3,1.  exp_is_end[i] = (exp_enc[i] > exp_max[i]) .
                Vector128<long> msl = Avx2.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt64());     //1,1/2. msl[i] = mat << exp_frac[i]
                Vector128<long> msr = Avx2.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt64());  //1,1/2. msr[i] = mat >> exp_frac_n[i] = mat >> (-exp_frac[i])
                Vector128<long> exp_is_pos = Avx2.CompareGreaterThan(exp_frac, zero);              //3,1. The mask of exp_frac is a positive
                Vector128<long> result_abs = Avx2.BlendVariable(msr, msl, exp_is_pos);             //2,1. result_abs[i] = (exp_is_pos[i])?msl[i]:msl[i]
                result_abs = Avx2.BlendVariable(result_abs, defValue, exp_is_end);                 //2,1.  result_abs[i] = (exp_is_end[i])?defValue[i]:result_abs[i]
                Vector128<long> result = Avx2.Xor(result_abs, negative);                           //1,1/3. ~x = xor(x, -1)
                result = Avx2.Subtract(result, negative);                                          //1,1/3 -(x) = (~x)+1 = (~x) - (-1)
                return result;  //total latency: 23, total throughput CPI: 9
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_Range52(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_Range52(Vector128<double> value) {
                return ConvertToInt64_Range52_Impl(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_Range52(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_Range52_Impl(Vector128<double> value) {
                value = Avx.RoundToZero(value); // Truncate.
                return ConvertToInt64_Range52RoundToEven(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_Range52RoundToEven(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_Range52RoundToEven(Vector128<double> value) {
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
                Vector128<double> magicNumber = Vector128.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector128<double> x = Avx.Add(value, magicNumber);
                Vector128<long> result = Avx2.Subtract(x.AsInt64(), magicNumber.AsInt64());
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
                return Avx.ConvertToVector128Single(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> ConvertToSingle(Vector128<uint> value) {
                return ConvertToSingle_Multiply(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> ConvertToSingle_Multiply(Vector128<uint> value) {
                // Reference: System.Private.CoreLib/src/System/Runtime/Intrinsics/Vector128.cs
                // This first bit of magic works because float can exactly represent integers up to 2^24
                //
                // This means everything between 0 and 2^16 (ushort.MaxValue + 1) are exact and so
                // converting each of the upper and lower halves will give an exact result
                Vector128<int> lowerBits = Avx2.And(value, Vector128.Create(0x0000FFFFU)).AsInt32();
                Vector128<int> upperBits = Avx2.ShiftRightLogical(value, 16).AsInt32();
                Vector128<float> lower = Avx.ConvertToVector128Single(lowerBits);
                Vector128<float> upper = Avx.ConvertToVector128Single(upperBits);
                // This next bit of magic works because all multiples of 65536, at least up to 65535
                // are likewise exactly representable
                //
                // This means that scaling upper by 65536 gives us the exactly representable base value
                // and then the remaining lower value, which is likewise up to 65535 can be added on
                // giving us a result that will correctly round to the nearest representable value
                if (Fma.IsSupported) {
                    return Fma.MultiplyAdd(upper, Vector128.Create(65536.0f), lower);
                } else {
                    Vector128<float> result = Avx.Multiply(upper, Vector128.Create(65536.0f));
                    return Avx.Add(result, lower);
                }
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
                get {
#if NET5_0_OR_GREATER
                    return TypeCodeFlags.Single;
#else
                    return SuperStatics.ConvertToUInt32_AcceleratedTypes;
#endif
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ConvertToUInt32(Vector128<float> value) {
                //return SuperStatics.ConvertToUInt32(value);
                //return ConvertToUInt32_Mapping(value);
                //return ConvertToUInt32_MappingFix(value);
                return ConvertToUInt32_ShiftVar(value);
            }

            ///// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
            ///// <remarks>Input range is `[-pow(2,31), pow(2,31))`. Out of range results in `2147483648`(pow(2,31)).</remarks>
            //[Obsolete("It has a different valid range.")]
            //[CLSCompliant(false)]
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector128<uint> ConvertToUInt32_As(Vector128<float> value) {
            //    return Avx.ConvertToVector128Int32WithTruncation(value).AsUInt32();
            //}

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
            /// <remarks>Input range is `[0, pow(2,32))`. Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ConvertToUInt32_ShiftVar(Vector128<float> value) {
                //constants
                Vector128<int> mat_mask = Vector128.Create(ScalarConstants.SingleVal_MantissaMask).AsInt32(); // 0x007FFFFF
                Vector128<int> hidden_1 = Vector128.Create(ScalarConstants.Int_2Pow23).AsInt32();             // 0x00800000 // Int32: 2^23
                Vector128<int> exp_bias = Vector128.Create(ScalarConstants.Int_SingleBias23).AsInt32(); // Single_ExponentBias + Single_MantissaBits = 127 + 23 = 150 = 0x96
                Vector128<int> zero = Vector128<int>.Zero;
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector128<int> bin = value.AsInt32();
                Vector128<int> mat = Avx2.And(bin, mat_mask);                                    //1,1/3
                mat = Avx2.Or(mat, hidden_1);                                                    //1,1/3
                Vector128<int> exp_enc = Avx2.ShiftRightLogical(bin, 23);                        //1,1/2
                Vector128<int> exp_frac = Avx2.Subtract(exp_enc, exp_bias);                      //1,1/3
                Vector128<int> msl = Avx2.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt32());    //1,1/2
                Vector128<int> exp_frac_n = Avx2.Subtract(zero, exp_frac);                       //1,1/3
                Vector128<int> msr = Avx2.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt32()); //1,1/2
                Vector128<int> exp_is_pos = Avx2.CompareGreaterThan(exp_frac, zero);             //3,1
                Vector128<int> result_abs = Avx2.BlendVariable(msr, msl, exp_is_pos);            //2,1
                return result_abs.AsUInt32();	//total latency: 12, total throughput CPI: 4.8
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
            /// <remarks>Input range is `[-pow(2,31), pow(2,32))`. Out of range results in `2147483648`(pow(2,31)).</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ConvertToUInt32_Mapping(Vector128<float> value) {
#if NET5_0_OR_GREATER
                // [pow(2,31), pow(2,32)-1] mapping to [-pow(2,31), -1]. Subtract `pow(2,32)`.
                Vector128<float> highEnd = Vector128.Create(ScalarConstants.SingleBit_2Pow32).AsSingle();
                Vector128<float> highBegin = Vector128.Create(ScalarConstants.SingleBit_2Pow31).AsSingle();
                Vector128<float> highMapped = Avx.Subtract(value, highEnd);
                Vector128<float> highMask = Avx.And(Avx.CompareLessThanOrEqual(highBegin, value), Avx.CompareLessThan(value, highEnd)); // highBegin <= value < highEnd .
                //Vector128<float> value2 = ConditionalSelect(highMask, highMapped, value);
                Vector128<float> value2 = Avx2.BlendVariable(value, highMapped, highMask);
                Vector128<uint> rt = Avx.ConvertToVector128Int32WithTruncation(value2).AsUInt32();
                return rt;
#else
                // Because CompareLessThanOrEqual has Exception: Error	CS1503	Argument 1: cannot convert from 'System.Runtime.Intrinsics.Vector128<float>' to 'System.Runtime.Intrinsics.Vector128<double>'	VectorTraits (netcoreapp3.0)
                return SuperStatics.ConvertToUInt32(value);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
            /// <remarks>Input range is `[-pow(2,31), pow(2,32))`. Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ConvertToUInt32_MappingFix(Vector128<float> value) {
#if NET5_0_OR_GREATER
                // [pow(2,31), pow(2,32)-1] mapping to [-pow(2,31), -1]. Subtract `pow(2,32)`.
                Vector128<float> highEnd = Vector128.Create(ScalarConstants.SingleBit_2Pow32).AsSingle();
                Vector128<float> lowBegin = Vector128.Create(ScalarConstants.SingleBit_Negative2Pow31).AsSingle();
                Vector128<float> highBegin = Vector128.Create(ScalarConstants.SingleBit_2Pow31).AsSingle();
                Vector128<float> lessHighEnd = Avx.CompareLessThan(value, highEnd); // value < highEnd .
                Vector128<float> highMapped = Avx.Subtract(value, highEnd);
                Vector128<float> lowMask = Avx.And(Avx.CompareLessThanOrEqual(lowBegin, value), lessHighEnd); // lowBegin <= value < highEnd .
                Vector128<float> value0 = Avx.And(value, lowMask); // If out of range, set to 0.
                Vector128<float> highMask = Avx.And(Avx.CompareLessThanOrEqual(highBegin, value), lessHighEnd); // highBegin <= value < highEnd .
                //Vector128<float> value2 = ConditionalSelect(highMask, highMapped, value0);
                Vector128<float> value2 = Avx2.BlendVariable(value0, highMapped, highMask);
                Vector128<uint> rt = Avx.ConvertToVector128Int32WithTruncation(value2).AsUInt32();
                return rt;
#else
                // Because CompareLessThanOrEqual has Exception: Error	CS1503	Argument 1: cannot convert from 'System.Runtime.Intrinsics.Vector128<float>' to 'System.Runtime.Intrinsics.Vector128<double>'	VectorTraits (netcoreapp3.0)
                return SuperStatics.ConvertToUInt32(value);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
            /// <remarks>Input range is all number (Use mod function). Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ConvertToUInt32_Mod(Vector128<float> value) {
#if NET5_0_OR_GREATER
                // remainder = mod(value, highEnd) = value - floor(value/highEnd)*highEnd
                Vector128<float> highEndDiv = Vector128.Create(ScalarConstants.SingleBit_2PowNegative32).AsSingle();
                Vector128<float> highEnd = Vector128.Create(ScalarConstants.SingleBit_2Pow32).AsSingle();
                Vector128<float> lowBegin = Vector128.Create(ScalarConstants.SingleBit_Negative2Pow31).AsSingle();
                Vector128<float> highBegin = Vector128.Create(ScalarConstants.SingleBit_2Pow31).AsSingle();
                Vector128<float> quotientFloor = Avx.Multiply(value, highEndDiv); // Avx.Divide(value, highEnd);
                quotientFloor = Avx.Floor(quotientFloor);
                Vector128<float> intRangeMask = Avx.And(Avx.CompareLessThanOrEqual(lowBegin, value), Avx.CompareLessThan(value, highBegin)); // lowBegin <= value < highBegin .
                Vector128<float> remainder = Avx.Subtract(value, Avx.Multiply(quotientFloor, highEnd));
                // [pow(2,31), pow(2,32)-1] mapping to [-pow(2,31), -1]. Subtract `pow(2,32)`.
                Vector128<float> uintRangeMask = Avx.And(Avx.CompareLessThanOrEqual(Vector128<float>.Zero, remainder), Avx.CompareLessThan(remainder, highEnd)); // lowBegin <= remainder < highEnd .
                Vector128<float> highMask = Avx.CompareLessThanOrEqual(highBegin, remainder); // highBegin <= value .
                Vector128<float> remainder0 = Avx.And(remainder, uintRangeMask); // If out of range, set to 0.
                Vector128<float> highMapped = Avx.Subtract(remainder0, highEnd);
                //Vector128<float> value2 = ConditionalSelect(highMask, highMapped, remainder0);
                Vector128<float> value2 = Avx2.BlendVariable(remainder0, highMapped, highMask);
                // If within the signed integer range, return value, otherwise return value2 .
                Vector128<float> value3 = Avx2.BlendVariable(value2, value, intRangeMask);
                Vector128<uint> rt = Avx.ConvertToVector128Int32WithTruncation(value3).AsUInt32();
                return rt;
#else
                // Because CompareLessThanOrEqual has Exception: Error	CS1503	Argument 1: cannot convert from 'System.Runtime.Intrinsics.Vector128<float>' to 'System.Runtime.Intrinsics.Vector128<double>'	VectorTraits (netcoreapp3.0)
                return SuperStatics.ConvertToUInt32(value);
#endif
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
                get {
                    //return SuperStatics.ConvertToUInt64_AcceleratedTypes;
                    return TypeCodeFlags.Double;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64(Vector128<double> value) {
                //return SuperStatics.ConvertToUInt64(value);
                return ConvertToUInt64_ShiftVar(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64(Vector128{double})"/>
            /// <remarks>Input range is `[0, pow(2,64))`. Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64_ShiftVar(Vector128<double> value) {
                // From Veloctor . MIT
                // https://github.com/Veloctor/Int128/blob/main/include/AVX2Ext.h
                // //  Only works for inputs in full uint64 range, otherwise result undefined
                // inline __m128i double_to_uint64_fast(const __m128d v) //9 instructions
                // {
                // 	//constants
                // 	__m128i mat_mask = _mm128_set1_epi64x(0x0FFFFFFFFFFFFF);	//0_00000000000_1111111111111111111111111111111111111111111111111111
                // 	__m128i hidden_1 = _mm128_set1_epi64x(0x10000000000000);	//0_00000000001_0000000000000000000000000000000000000000000000000000
                // 	__m128i exp_bias = _mm128_set1_epi64x(1023LL + 52);			//0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                // 	#define zero128 _mm128_setzero_si128()
                // 	//majik operations
                // 	__m128i bin = _mm128_castpd_si128(v);
                // 	__m128i mat = _mm128_and_si128(bin, mat_mask);					//1,1/3
                // 	mat = _mm128_or_si128(mat, hidden_1);							//1,1/3
                // 	__m128i exp_enc = _mm128_srli_epi64(bin, 52);					//1,1/2
                // 	__m128i exp_frac = _mm128_sub_epi64(exp_enc, exp_bias);			//1,1/3
                // 	__m128i msl = _mm128_sllv_epi64(mat, exp_frac);					//1,1/2
                // 	__m128i exp_frac_n = _mm128_sub_epi64(zero128, exp_frac);		//1,1/3
                // 	__m128i msr = _mm128_srlv_epi64(mat, exp_frac_n);				//1,1/2
                // 	__m128i exp_is_pos = _mm128_cmpgt_epi64(exp_frac, zero128);		//3,1
                // 	__m128i result_abs = _mm128_blendv_epi8(msr, msl, exp_is_pos);	//2,1
                // 	return result_abs;	//total latency: 12, total throughput CPI: 4.8
                // }
                //constants
                Vector128<long> mat_mask = Vector128.Create(ScalarConstants.DoubleVal_MantissaMask).AsInt64();  //0_00000000000_1111111111111111111111111111111111111111111111111111
                Vector128<long> hidden_1 = Vector128.Create(ScalarConstants.IntDbl_2Pow52).AsInt64();  //0_00000000001_0000000000000000000000000000000000000000000000000000 // Int64: 2^52
                Vector128<long> exp_bias = Vector128.Create(ScalarConstants.IntDbl_DoubleBias52).AsInt64(); //0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                Vector128<long> zero = Vector128<long>.Zero;
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector128<long> bin = value.AsInt64();
                Vector128<long> mat = Avx2.And(bin, mat_mask);                                    //1,1/3
                mat = Avx2.Or(mat, hidden_1);                                                     //1,1/3
                Vector128<long> exp_enc = Avx2.ShiftRightLogical(bin, 52);                        //1,1/2
                Vector128<long> exp_frac = Avx2.Subtract(exp_enc, exp_bias);                      //1,1/3
                Vector128<long> msl = Avx2.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt64());    //1,1/2
                Vector128<long> exp_frac_n = Avx2.Subtract(zero, exp_frac);                       //1,1/3
                Vector128<long> msr = Avx2.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt64()); //1,1/2
                Vector128<long> exp_is_pos = Avx2.CompareGreaterThan(exp_frac, zero);             //3,1
                Vector128<long> result_abs = Avx2.BlendVariable(msr, msl, exp_is_pos);            //2,1
                return result_abs.AsUInt64();	//total latency: 12, total throughput CPI: 4.8
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
                value = Avx.RoundToZero(value); // Truncate.
                return ConvertToUInt64_Range52RoundToEven(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64_Range52RoundToEven(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64_Range52RoundToEven(Vector128<double> value) {
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
                Vector128<double> magicNumber = Vector128.Create(ScalarConstants.DoubleVal_2Pow52); // Double value: pow(2, 52)
                Vector128<double> x = Avx.Add(value, magicNumber);
                Vector128<ulong> result = Avx2.Xor(x.AsUInt64(), magicNumber.AsUInt64());
                return result;
            }


            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits_AcceleratedTypes"/>
            public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<float> vector) {
                return (uint)Avx.MoveMask(vector);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<double> vector) {
                return (uint)Avx.MoveMask(vector);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<sbyte> vector) {
                return ExtractMostSignificantBits(vector.AsByte());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<byte> vector) {
                return (uint)Avx2.MoveMask(vector);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<short> vector) {
                return ExtractMostSignificantBits(vector.AsUInt16());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<ushort> vector) {
                Vector128<byte> m = Ssse3.Shuffle(vector.AsByte(), Vector128Constants.ExtractMostSignificantBits_Shuffle_HiByteOf16); // Packed the high byte.
                return (uint)Sse2.MoveMask(m);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<int> vector) {
                return ExtractMostSignificantBits(vector.AsSingle());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<uint> vector) {
                return ExtractMostSignificantBits(vector.AsSingle());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<long> vector) {
                return ExtractMostSignificantBits(vector.AsDouble());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<ulong> vector) {
                return ExtractMostSignificantBits(vector.AsDouble());
            }


            /// <inheritdoc cref="IWVectorTraits128.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Floor(Vector128<float> value) {
                return Avx.Floor(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Floor(Vector128<double> value) {
                return Avx.Floor(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{double}, Vector128{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Narrow(Vector128<double> lower, Vector128<double> upper) {
                Vector128<float> rt0 = Sse2.ConvertToVector128Single(lower); // double(a, b) -> float(a, b, 0, 0)
                Vector128<float> rt1 = Sse2.ConvertToVector128Single(upper); // double(c, d) -> float(c, d, 0, 0)
                Vector128<float> rt = Sse.Shuffle(rt0, rt1, (byte)ShuffleControlG4.XYXY); // control = 0 + (1 << 2) + (0 << 4) + (1 << 6)
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
                Vector128<byte> rt = Avx2.PackUnsignedSaturate(Avx2.And(lower, mask).AsInt16(), Avx2.And(upper, mask).AsInt16());
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
                Vector128<uint> mask = Vector128.Create((uint)0x0FFFFU); // .NET5+ has better performance .
                Vector128<ushort> rt = Avx2.PackUnsignedSaturate(Avx2.And(lower, mask).AsInt32(), Avx2.And(upper, mask).AsInt32());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{long}, Vector128{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Narrow(Vector128<long> lower, Vector128<long> upper) {
                return Narrow(lower.AsUInt64(), upper.AsUInt64()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{ulong}, Vector128{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Narrow(Vector128<ulong> lower, Vector128<ulong> upper) {
                Vector128<uint> l = Avx2.UnpackLow(lower.AsUInt32(), upper.AsUInt32()); // bit32(a0.L, b0.L, a0.H, b0.H)
                Vector128<uint> h = Avx2.UnpackHigh(lower.AsUInt32(), upper.AsUInt32()); // bit32(a1.L, b1.L, a1.H, b1.H)
                Vector128<uint> rt = Avx2.UnpackLow(l, h); // bit32(a0.L, a1.L, b0.L, b1.L).
                return rt;
            }


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
                var args0 = ShiftLeft_Args(dummy.AsByte(), shiftAmount, out var a1).AsSByte();
                args1 = a1.AsSByte();
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{byte}, int, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Args(Vector128<byte> dummy, int shiftAmount, out Vector128<byte> args1) {
                _ = dummy;
                shiftAmount &= 7;
                var args0 = Vector128.Create((uint)shiftAmount).AsByte();
                args1 = Vector128Constants.GetResidueMaskBits_Byte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{short}, int, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1) {
                _ = dummy;
                //Vector128<short> args0 = Sse2.ConvertScalarToVector128Int32(shiftAmount & 0x0F).AsInt16();
                Vector128<short> args0 = Vector128.CreateScalarUnsafe((int)(shiftAmount & 0x0F)).AsInt16();
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{ushort}, int, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Args(Vector128<ushort> dummy, int shiftAmount, out Vector128<ushort> args1) {
                var args0 = ShiftLeft_Args(dummy.AsInt16(), shiftAmount, out var a1).AsUInt16();
                args1 = a1.AsUInt16();
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{int}, int, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1) {
                _ = dummy;
                var args0 = Vector128.Create((int)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{uint}, int, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Args(Vector128<uint> dummy, int shiftAmount, out Vector128<uint> args1) {
                _ = dummy;
                var args0 = Vector128.Create((uint)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{long}, int, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
                _ = dummy;
                var args0 = Vector128.Create((long)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Args(Vector128<ulong> dummy, int shiftAmount, out Vector128<ulong> args1) {
                _ = dummy;
                var args0 = Vector128.Create((ulong)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                return ShiftLeft_Core(value.AsByte(), shiftAmount, args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Core(Vector128<byte> value, int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
                _ = shiftAmount;
                var t = Avx2.And(value, args1).AsUInt32();
                return Avx2.ShiftLeftLogicalVariable(t, args0.AsUInt32()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftLeftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Core(Vector128<ushort> value, int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftLeftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftLeftLogicalVariable(value, args0.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Core(Vector128<uint> value, int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftLeftLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftLeftLogicalVariable(value, args0.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Core(Vector128<ulong> value, int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftLeftLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Const(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftLeft_Const(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Const(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                Vector128<byte> t = Avx2.And(value, Vector128Constants.GetResidueMaskBits_Byte(shiftAmount));
                return Avx2.ShiftLeftLogical(t.AsUInt32(), (byte)shiftAmount).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Const(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Const(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Const(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_ConstCore(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_ConstCore(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
#if NET6_0_OR_GREATER
                // The net6 JIT can compile constants to immediate numbers
                _ = args0;
                _ = args1;
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
#else
                return ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Fast(Vector128<sbyte> value, int shiftAmount) {
                return ShiftLeft_Fast(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Fast(Vector128<byte> value, int shiftAmount) {
                Vector128<byte> t = Avx2.And(value, Vector128Constants.GetResidueMaskBits_Byte(shiftAmount));
                return Avx2.ShiftLeftLogical(t.AsUInt32(), (byte)shiftAmount).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Fast(Vector128<short> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount); // For non-constant parameters, JIT will automatically use the Vector128 version (对于非常量参数, JIT会自动使用Vector128的版本). e.g. Avx2.ShiftLeftLogical(Vector128{ushort}, Vector128{ushort})
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Fast(Vector128<ushort> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Fast(Vector128<int> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Fast(Vector128<uint> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Fast(Vector128<long> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Fast(Vector128<ulong> value, int shiftAmount) {
                return Avx2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Args(Vector128<sbyte> dummy, int shiftAmount, out Vector128<sbyte> args1) {
                _ = dummy;
                shiftAmount &= 7;
                var args0 = Vector128.Create((int)shiftAmount).AsSByte();
                args1 = Vector128Constants.GetResidueMaskBits_SByte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{short}, int, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1) {
                _ = dummy;
                Vector128<short> args0 = Vector128.CreateScalarUnsafe((int)(shiftAmount & 0x0F)).AsInt16();
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{int}, int, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1) {
                _ = dummy;
                var args0 = Vector128.Create((int)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{long}, int, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
                _ = dummy;
                shiftAmount &= 0x3F;
                var args0 = Vector128.Create((long)shiftAmount);
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                _ = shiftAmount;
                Vector128<sbyte> sign = Avx2.CompareGreaterThan(Vector128<sbyte>.Zero, value);
                Vector128<sbyte> shifted = Avx2.ShiftRightLogicalVariable(value.AsUInt32(), args0.AsUInt32()).AsSByte();
                Vector128<sbyte> rt = ConditionalSelect(args1, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightArithmetic(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightArithmeticVariable(value, args0.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = shiftAmount;
                _ = args1;
                Vector128<long> sign = Avx2.CompareGreaterThan(Vector128<long>.Zero, value);
                Vector128<long> rt = Avx2.Xor(value, sign);
                rt = Avx2.ShiftRightLogicalVariable(rt, args0.AsUInt64());
                rt = Avx2.Xor(rt, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Const(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Const(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Const(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Const(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Const(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_ConstCore(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_ConstCore(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
#if NET6_0_OR_GREATER
                _ = args0;
                _ = args1;
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Fast(Vector128<sbyte> value, int shiftAmount) {
                //return ShiftRightArithmetic_Fast_Widen(value, shiftAmount);
                return ShiftRightArithmetic_Fast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Fast_Widen(Vector128<sbyte> value, int shiftAmount) {
                Vector128<short> lowerToHigh = Avx2.ShiftLeftLogical(value.AsInt16(), 8);
                Vector128<short> lowerShifted = Avx2.ShiftRightArithmetic(lowerToHigh, (byte)shiftAmount);
                Vector128<sbyte> upper = Avx2.ShiftRightArithmetic(value.AsInt16(), (byte)shiftAmount).AsSByte();
                Vector128<sbyte> lower = Avx2.ShiftRightLogical(lowerShifted, 8).AsSByte();
                Vector128<sbyte> rt = Avx2.Or(Avx2.And(Vector128s<sbyte>.XyYMask, upper), lower);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Fast_Negative(Vector128<sbyte> value, int shiftAmount) {
                Vector128<sbyte> mask = Vector128Constants.GetResidueMaskBits_SByte(shiftAmount);
                Vector128<sbyte> shifted = Avx2.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsSByte();
                Vector128<sbyte> sign = Avx2.CompareGreaterThan(Vector128<sbyte>.Zero, value);
                Vector128<sbyte> rt = ConditionalSelect(mask, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Fast(Vector128<short> value, int shiftAmount) {
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Fast(Vector128<int> value, int shiftAmount) {
                return Avx2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Fast(Vector128<long> value, int shiftAmount) {
                return ShiftRightArithmetic_Fast_Xor(value, shiftAmount);
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Fast_Narrow(Vector128<long> value, int shiftAmount) {
                if (0 == shiftAmount) {
                    return value;
                }
                Vector128<long> rt;
                Vector128<int> lower, upper;
                Vector128<int> XyXMask = Vector128s<int>.XyXMask;
                const byte controlInputUpper = (byte)ShuffleControlG4.YYWW; // BitMath._MM_SHUFFLE(3, 3, 1, 1) = 0xF5 = 0b11_11_01_01;
                Vector128<int> upperAtLower = Avx2.Shuffle(value.AsInt32(), controlInputUpper); // f({ v0.lower, v0.upper, v1.lower, v1.upper, ... }) = { v0.upper, v0.upper, v1.upper, v1.upper, ... }
                upperAtLower = Avx2.And(XyXMask, upperAtLower); // = { v0.upper, 0, v1.upper, 0, ... }
                Vector128<int> upperOld = Avx2.AndNot(XyXMask, value.AsInt32()); // = { 0, v0.upper, 0, v1.upper, ... }
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
                    Vector128<int> lowerOld = Avx2.And(XyXMask, value.AsInt32());
                    lower = Avx2.Or(Avx2.ShiftRightLogical(lowerOld, (byte)shiftAmount), Avx2.ShiftLeftLogical(upperAtLower, (byte)(32 - shiftAmount)));
                    upper = Avx2.ShiftRightArithmetic(upperOld, (byte)shiftAmount);
                    rt = Avx2.Or(lower, upper).AsInt64();
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Fast_NarrowIfLess(Vector128<long> value, int shiftAmount) {
                if (0 == shiftAmount) {
                    return value;
                }
                Vector128<int> XyXMask = Vector128s<int>.XyXMask;
                const byte controlInputUpper = (byte)ShuffleControlG4.YYWW; // BitMath._MM_SHUFFLE(3, 3, 1, 1) = 0xF5 = 0b11_11_01_01;
                Vector128<int> upperAtLower = Avx2.Shuffle(value.AsInt32(), controlInputUpper); // f({ v0.lower, v0.upper, v1.lower, v1.upper, ... }) = { v0.upper, v0.upper, v1.upper, v1.upper, ... }
                byte shiftAmountUpper = (byte)BitMath.Min(31, shiftAmount);
                byte shiftAmountLeft = (byte)BitMath.Max(0, 32 - shiftAmount);
                Vector128<int> lowerUse1Mask = Vector128.Create(BitMath.ToInt32Mask(32 <= shiftAmount));
                upperAtLower = Avx2.And(XyXMask, upperAtLower); // = { v0.upper, 0, v1.upper, 0, ... }
                Vector128<int> lowerOld = Avx2.And(XyXMask, value.AsInt32());
                Vector128<int> upperOld = Avx2.AndNot(XyXMask, value.AsInt32()); // = { 0, v0.upper, 0, v1.upper, ... }
                Vector128<int> lower2 = Avx2.Or(Avx2.ShiftRightLogical(lowerOld, (byte)shiftAmount), Avx2.ShiftLeftLogical(upperAtLower, shiftAmountLeft));
                Vector128<int> upper = Avx2.ShiftRightArithmetic(upperOld, shiftAmountUpper);
                Vector128<int> lower1 = Avx2.ShiftRightArithmetic(upperAtLower, (byte)(shiftAmount & 31));
                Vector128<int> lower = ConditionalSelect(lowerUse1Mask, lower1, lower2);
                Vector128<long> rt = Avx2.Or(lower, upper).AsInt64();
                return rt;
            }
#endif // !REDUCE_MEMORY_USAGE

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Fast_Negative(Vector128<long> value, int shiftAmount) {
                Vector128<long> sign = Avx2.CompareGreaterThan(Vector128<long>.Zero, value);
                byte shiftAmountLeft = (byte)(64 - shiftAmount);
                Vector128<long> rt = Avx2.Or(Avx2.ShiftRightLogical(value, (byte)shiftAmount), Avx2.ShiftLeftLogical(sign, shiftAmountLeft));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Fast_Xor(Vector128<long> value, int shiftAmount) {
                // t = -(x>>>31); return ((x^t)>>>n)^t; // From "Hacker's Delight", Page 18.
                Vector128<long> sign = Avx2.CompareGreaterThan(Vector128<long>.Zero, value); // Mask `0>x` is `-(x>>>31)`.
                Vector128<long> rt = Avx2.Xor(value, sign);
                rt = Avx2.ShiftRightLogical(rt, (byte)shiftAmount);
                rt = Avx2.Xor(rt, sign);
                return rt;
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
                var args0 = ShiftRightLogical_Args(dummy.AsByte(), shiftAmount, out var a1).AsSByte();
                args1 = a1.AsSByte();
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{byte}, int, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Args(Vector128<byte> dummy, int shiftAmount, out Vector128<byte> args1) {
                _ = dummy;
                shiftAmount &= 7;
                var args0 = Vector128.Create((uint)shiftAmount).AsByte();
                args1 = Vector128Constants.GetResidueMaskBits_Byte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{short}, int, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1) {
                _ = dummy;
                Vector128<short> args0 = Vector128.CreateScalarUnsafe((int)(shiftAmount & 0x0F)).AsInt16();
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{ushort}, int, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Args(Vector128<ushort> dummy, int shiftAmount, out Vector128<ushort> args1) {
                var args0 = ShiftRightLogical_Args(dummy.AsInt16(), shiftAmount, out var a1).AsUInt16();
                args1 = a1.AsUInt16();
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{int}, int, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1) {
                _ = dummy;
                var args0 = Vector128.Create((int)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{uint}, int, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Args(Vector128<uint> dummy, int shiftAmount, out Vector128<uint> args1) {
                _ = dummy;
                var args0 = Vector128.Create((uint)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{long}, int, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
                _ = dummy;
                var args0 = Vector128.Create((long)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Args(Vector128<ulong> dummy, int shiftAmount, out Vector128<ulong> args1) {
                _ = dummy;
                var args0 = Vector128.Create((ulong)(shiftAmount & 0x3F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                return ShiftRightLogical_Core(value.AsByte(), shiftAmount, args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Core(Vector128<byte> value, int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
                _ = shiftAmount;
                var rt = Avx2.ShiftRightLogicalVariable(value.AsUInt32(), args0.AsUInt32()).AsByte();
                rt = Avx2.And(rt, args1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Core(Vector128<ushort> value, int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightLogicalVariable(value, args0.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Core(Vector128<uint> value, int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightLogicalVariable(value, args0.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Core(Vector128<ulong> value, int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
                _ = shiftAmount;
                _ = args1;
                return Avx2.ShiftRightLogicalVariable(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Const(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightLogical_Const(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Const(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                Vector128<byte> mask = Vector128Constants.GetResidueMaskBits_Byte(shiftAmount);
                Vector128<byte> t = Avx2.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsByte();
                Vector128<byte> rt = Avx2.And(t, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Const(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Const(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Const(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_ConstCore(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_ConstCore(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
#if NET6_0_OR_GREATER
                // The net6 JIT can compile constants to immediate numbers
                _ = args0;
                _ = args1;
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
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
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
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
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
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
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
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
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
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
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
#else
                return ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Fast(Vector128<sbyte> value, int shiftAmount) {
                return ShiftRightLogical_Fast(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Fast(Vector128<byte> value, int shiftAmount) {
                return ShiftRightLogical_Fast_FirstShift(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Fast_FirstAnd(Vector128<byte> value, int shiftAmount) {
                Vector128<byte> mask = Vector128Constants.GetMaskBits_Byte(shiftAmount);
                Vector128<byte> t = Avx2.AndNot(mask, value);
                Vector128<byte> rt = Avx2.ShiftRightLogical(t.AsUInt16(), (byte)shiftAmount).AsByte();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Fast_FirstShift(Vector128<byte> value, int shiftAmount) {
                Vector128<byte> mask = Vector128Constants.GetResidueMaskBits_Byte(shiftAmount);
                Vector128<byte> t = Avx2.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsByte();
                Vector128<byte> rt = Avx2.And(t, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Fast(Vector128<short> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Fast(Vector128<ushort> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Fast(Vector128<int> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Fast(Vector128<uint> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Fast(Vector128<long> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Fast(Vector128<ulong> value, int shiftAmount) {
                return Avx2.ShiftRightLogical(value, (byte)shiftAmount);
            }


            /// <inheritdoc cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
            public static TypeCodeFlags Shuffle_AcceleratedTypes {
                get {
                    return YShuffleInsert_AcceleratedTypes;
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
                var indicesAdded = Avx2.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue));
                Vector128<byte> mask = Avx2.CompareGreaterThan(
                    Vector128.Create((sbyte)(32 + sbyte.MinValue)),
                    indicesAdded
                ).AsByte(); // Unsigned compare: (i < 32)
                Vector128<byte> raw = YShuffleKernel(vector, indices);
                Vector128<byte> rt = Avx2.And(raw, mask);
                return rt;
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
                var indicesAdded = Avx2.Add(indices.AsInt16(), Vector128.Create(short.MinValue));
                Vector128<ushort> mask = Avx2.CompareGreaterThan(
                    Vector128.Create((short)(16 + short.MinValue)),
                    indicesAdded
                ).AsUInt16(); // Unsigned compare: (i < 16)
                Vector128<ushort> raw = YShuffleKernel(vector, indices);
                Vector128<ushort> rt = Avx2.And(raw, mask);
                return rt;
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
                var indicesAdded = Avx2.Add(indices.AsInt32(), Vector128.Create(int.MinValue));
                Vector128<uint> mask = Avx2.CompareGreaterThan(
                    Vector128.Create((int)(8 + int.MinValue)),
                    indicesAdded
                ).AsUInt32(); // Unsigned compare: (i < 8)
                Vector128<uint> raw = YShuffleKernel(vector, indices);
                Vector128<uint> rt = Avx2.And(raw, mask);
                return rt;
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
                var indicesAdded = Avx2.Add(indices.AsInt64(), Vector128Constants.Int64_MinValue);
                Vector128<ulong> mask = Avx2.CompareGreaterThan(
                    Vector128Constants.Int64_MinValue_4,
                    indicesAdded
                ).AsUInt64(); // Unsigned compare: (i < 4)
                Vector128<ulong> raw = YShuffleKernel(vector, indices);
                Vector128<ulong> rt = Avx2.And(raw, mask);
                return rt;
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
                var indicesAdded = Avx2.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue));
                Vector128<byte> mask = Avx2.CompareGreaterThan(
                    Vector128.Create((sbyte)(32 + sbyte.MinValue)),
                    indicesAdded
                ).AsByte(); // Unsigned compare: (i < 32)
                mask = OnesComplement(mask); // Used for _mm128_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = Avx2.Or(args0, mask);
                args1 = Avx2.Or(args1, mask);
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
                YShuffleKernel_Args(indices, out args0, out args1);
                var indicesAdded = Avx2.Add(indices.AsInt16(), Vector128.Create(short.MinValue));
                Vector128<ushort> mask = Avx2.CompareGreaterThan(
                    Vector128.Create((short)(16 + short.MinValue)),
                    indicesAdded
                ).AsUInt16(); // Unsigned compare: (i < 16)
                mask = OnesComplement(mask); // Used for _mm128_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = Avx2.Or(args0, mask);
                args1 = Avx2.Or(args1, mask);
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
                args0 = indices;
                var indicesAdded = Avx2.Add(indices.AsInt32(), Vector128.Create(int.MinValue));
                args1 = Avx2.CompareGreaterThan(
                    Vector128.Create((int)(8 + int.MinValue)),
                    indicesAdded
                ).AsUInt32(); // Unsigned compare: (i < 8)
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
                YShuffleKernel_Args(indices, out args0, out _);
                var indicesAdded = Avx2.Add(indices.AsInt64(), Vector128Constants.Int64_MinValue);
                args1 = Avx2.CompareGreaterThan(
                    Vector128Constants.Int64_MinValue_4,
                    indicesAdded
                ).AsUInt64(); // Unsigned compare: (i < 4)
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
                return Ssse3.Shuffle(vector, args0);
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
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum(Vector128<float> value) {
                Vector128<float> m;
                Vector128<float> n;
                // 0 1 2 3
                if (Sse3.IsSupported) {
                    m = Sse3.HorizontalAdd(value, value); // 01 23 01 23
                    n = Sse3.HorizontalAdd(m, m); // 0123 0123 0123 0123
                } else {
                    m = Sse2.UnpackHigh(value.AsInt64(), value.AsInt64()).AsSingle(); // 2 3 2 3
                    n = Sse.Add(m, value); // 02 13 22 33
                    m = Sse2.Shuffle(n.AsInt32(), (byte)ShuffleControlG4.YXZW).AsSingle(); // 13 02 22 33
                    n = Sse.Add(m, n); // 0123 0123 2222 3333
                }
                return n.GetElement(0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum(Vector128<double> value) {
                Vector128<double> m;
                // 0 1
                if (Sse3.IsSupported) {
                    m = Sse3.HorizontalAdd(value, value); // 01 01
                } else {
                    m = Sse2.UnpackHigh(value, value); // 1 1
                    m = Sse2.Add(m, value); // 01 01
                }
                return m.GetElement(0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum(Vector128<sbyte> value) {
                return (sbyte)Sum(value.AsByte());
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum(Vector128<byte> value) {
                Widen_Unpack(value, out Vector128<ushort> l, out Vector128<ushort> h);
                Vector128<ushort> t = Sse2.Add(l, h);
                return (byte)Sum(t);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum(Vector128<short> value) {
                Vector128<short> m;
                Vector128<short> n;
                // 0 1 2 3 4 5 6 7
                if (Ssse3.IsSupported) {
                    m = Ssse3.HorizontalAdd(value, value); // 01 23 45 67 01 23 45 67
                    m = Ssse3.HorizontalAdd(m, m); // 0123 4567 0123 4567
                    n = Ssse3.HorizontalAdd(m, m); // 01234567 01234567 01234567 01234567
                } else {
                    m = Sse2.UnpackHigh(value.AsInt64(), value.AsInt64()).AsInt16(); // 4 5 6 7 4 5 6 7
                    n = Sse2.Add(m, value); // 04 15 26 37 44 55 66 77
                    m = Sse2.Shuffle(n.AsInt32(), (byte)ShuffleControlG4.YXZW).AsInt16(); // 26 37 04 15 26 44 55 66 77
                    n = Sse2.Add(m, n); // 0246 1357 0246 1357 4444 5555 6666 7777
                    m = Sse2.ShuffleLow(n, (byte)ShuffleControlG4.YXWZ).AsInt16(); // 1357 0246 1357 0246 4444 5555 6666 7777
                    n = Sse2.Add(m, n); // 01234567 01234567 01234567 01234567 44444444 5555555 6666666 77777777
                }
                return (short)Sse2.ConvertToInt32(n.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum(Vector128<ushort> value) {
                return (ushort)Sum(value.AsInt16());
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum(Vector128<int> value) {
                Vector128<int> m;
                Vector128<int> n;
                // 0 1 2 3
                if (Ssse3.IsSupported) {
                    m = Ssse3.HorizontalAdd(value, value); // 01 23 01 23
                    n = Ssse3.HorizontalAdd(m, m); // 0123 0123 0123 0123
                } else {
                    m = Sse2.UnpackHigh(value.AsInt64(), value.AsInt64()).AsInt32(); // 2 3 2 3
                    n = Sse2.Add(m, value); // 02 13 22 33
                    m = Sse2.Shuffle(n, (byte)ShuffleControlG4.YXZW); // 13 02 22 33
                    n = Sse2.Add(m, n); // 0123 0123 2222 3333
                }
                return Sse2.ConvertToInt32(n);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum(Vector128<uint> value) {
                return (uint)Sum(value.AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum(Vector128<long> value) {
                // 0 1
                Vector128<long> m = Sse2.UnpackHigh(value, value); // upper
                Vector128<long> n = Sse2.Add(value, m);
                // 01 01
                return n.GetElement(0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum(Vector128<ulong> value) {
                return (ulong)Sum(value.AsInt64());
            }


            /// <inheritdoc cref="IWVectorTraits128.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{float}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<float> source, out Vector128<double> lower, out Vector128<double> upper) {
                lower = Sse2.ConvertToVector128Double(source);
                Vector128<float> sourceUpper = Sse2.UnpackHigh(source.AsDouble(), source.AsDouble()).AsSingle();
                upper = Sse2.ConvertToVector128Double(sourceUpper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{sbyte}, out Vector128{short}, out Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<sbyte> source, out Vector128<short> lower, out Vector128<short> upper) {
                Widen_ConvertTo(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{byte}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<byte> source, out Vector128<ushort> lower, out Vector128<ushort> upper) {
                Widen_ConvertTo(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{short}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<short> source, out Vector128<int> lower, out Vector128<int> upper) {
                Widen_ConvertTo(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<ushort> source, out Vector128<uint> lower, out Vector128<uint> upper) {
                Widen_ConvertTo(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
                Widen_ConvertTo(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<uint> source, out Vector128<ulong> lower, out Vector128<ulong> upper) {
                Widen_ConvertTo(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{sbyte}, out Vector128{short}, out Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector128<sbyte> source, out Vector128<short> lower, out Vector128<short> upper) {
                lower = Avx2.ConvertToVector128Int16(source);
                Vector128<sbyte> sourceUpper = Sse2.UnpackHigh(source.AsInt16(), source.AsInt16()).AsSByte();
                upper = Avx2.ConvertToVector128Int16(sourceUpper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{byte}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector128<byte> source, out Vector128<ushort> lower, out Vector128<ushort> upper) {
                lower = Sse41.ConvertToVector128Int16(source).AsUInt16();
                Vector128<byte> sourceUpper = Sse2.UnpackHigh(source.AsUInt64(), source.AsUInt64()).AsByte();
                upper = Sse41.ConvertToVector128Int16(sourceUpper).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{short}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector128<short> source, out Vector128<int> lower, out Vector128<int> upper) {
                lower = Avx2.ConvertToVector128Int32(source);
                Vector128<short> sourceUpper = Sse2.UnpackHigh(source.AsUInt64(), source.AsUInt64()).AsInt16();
                upper = Avx2.ConvertToVector128Int32(sourceUpper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector128<ushort> source, out Vector128<uint> lower, out Vector128<uint> upper) {
                lower = Avx2.ConvertToVector128Int32(source).AsUInt32();
                Vector128<ushort> sourceUpper = Sse2.UnpackHigh(source.AsUInt64(), source.AsUInt64()).AsUInt16();
                upper = Avx2.ConvertToVector128Int32(sourceUpper).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
                lower = Avx2.ConvertToVector128Int64(source);
                Vector128<int> sourceUpper = Sse2.UnpackHigh(source.AsInt64(), source.AsInt64()).AsInt32();
                upper = Avx2.ConvertToVector128Int64(sourceUpper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector128<uint> source, out Vector128<ulong> lower, out Vector128<ulong> upper) {
                lower = Avx2.ConvertToVector128Int64(source).AsUInt64();
                Vector128<uint> sourceUpper = Sse2.UnpackHigh(source.AsUInt64(), source.AsUInt64()).AsUInt32();
                upper = Avx2.ConvertToVector128Int64(sourceUpper).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{sbyte}, out Vector128{short}, out Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector128<sbyte> source, out Vector128<short> lower, out Vector128<short> upper) {
                Vector128<sbyte> zero = Vector128<sbyte>.Zero;
                Vector128<sbyte> mask = Avx2.CompareGreaterThan(zero, source);
                lower = Avx2.UnpackLow(source, mask).AsInt16();
                upper = Avx2.UnpackHigh(source, mask).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{byte}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector128<byte> source, out Vector128<ushort> lower, out Vector128<ushort> upper) {
                Vector128<byte> zero = Vector128<byte>.Zero;
                lower = Avx2.UnpackLow(source.AsByte(), zero).AsUInt16();
                upper = Avx2.UnpackHigh(source.AsByte(), zero).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{short}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector128<short> source, out Vector128<int> lower, out Vector128<int> upper) {
                Vector128<short> zero = Vector128<short>.Zero;
                Vector128<short> mask = Avx2.CompareGreaterThan(zero, source);
                lower = Avx2.UnpackLow(source, mask).AsInt32();
                upper = Avx2.UnpackHigh(source, mask).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector128<ushort> source, out Vector128<uint> lower, out Vector128<uint> upper) {
                Vector128<ushort> zero = Vector128<ushort>.Zero;
                lower = Avx2.UnpackLow(source.AsUInt16(), zero).AsUInt32();
                upper = Avx2.UnpackHigh(source.AsUInt16(), zero).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
                Vector128<int> zero = Vector128<int>.Zero;
                Vector128<int> mask = Avx2.CompareGreaterThan(zero, source);
                lower = Avx2.UnpackLow(source, mask).AsInt64();
                upper = Avx2.UnpackHigh(source, mask).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector128<uint> source, out Vector128<ulong> lower, out Vector128<ulong> upper) {
                Vector128<uint> zero = Vector128<uint>.Zero;
                lower = Avx2.UnpackLow(source.AsUInt32(), zero).AsUInt64();
                upper = Avx2.UnpackHigh(source.AsUInt32(), zero).AsUInt64();
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
