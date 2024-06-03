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
        /// <see cref="Vector128{T}"/> traits.Statics - Sse.
        /// </summary>
        public static partial class Statics {

#if NET8_0_OR_GREATER
#if NET9_0_OR_GREATER
            private const bool Avx512_Compare_Used = true;
#else
            private const bool Avx512_Compare_Used = false;
            // Bug on .NET8.0:
#endif // NET9_0_OR_GREATER
#endif // NET8_0_OR_GREATER

#if NETCOREAPP3_0_OR_GREATER
            private const bool Shuffle_Use_Longer = true;
#else
            private const bool Shuffle_Use_Longer = false;
#endif // NETCOREAPP3_0_OR_GREATER

            private const bool Shuffle_Use_Longer_Avx2 = false;

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
                rt = Sse.IsSupported && Sse2.IsSupported;
#else
#endif // NETCOREAPP3_0_OR_GREATER
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Requires hardware support Sse, Sse2!";
#if NETCOREAPP3_0_OR_GREATER
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
                if (Sse41.IsSupported) {
                    return Sse41.Ceiling(value);
                } else {
                    return Ceiling_ClearBit(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Ceiling(Vector128<double> value) {
                if (Sse41.IsSupported) {
                    return Sse41.Ceiling(value);
                } else {
                    return Ceiling_ClearBit(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Ceiling_ClearBit(Vector128<float> value) {
                Vector128<float> fixMask = Sse.CompareGreaterThan(value, Vector128<float>.Zero);
                Vector128<float> valueTrun = YRoundToZero_ClearBit(value);
                Vector128<float> equalsMask = Sse.CompareEqual(value, valueTrun);
                fixMask = Sse.AndNot(equalsMask, fixMask); // It mean `Vector128.AndNot(fixMask, equalsMask)`
                Vector128<float> valueTrunFix = Sse.Add(valueTrun, Vector128.Create(1.0f));
                Vector128<float> rt = ConditionalSelect(fixMask, valueTrunFix, valueTrun);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Ceiling_ClearBit(Vector128<double> value) {
                Vector128<double> fixMask = Sse2.CompareGreaterThan(value, Vector128<double>.Zero);
                Vector128<double> valueTrun = YRoundToZero_ClearBit(value);
                Vector128<double> equalsMask = Sse2.CompareEqual(value, valueTrun);
                fixMask = Sse2.AndNot(equalsMask, fixMask); // It mean `Vector128.AndNot(fixMask, equalsMask)`
                Vector128<double> valueTrunFix = Sse2.Add(valueTrun, Vector128.Create(1.0d));
                Vector128<double> rt = ConditionalSelect(fixMask, valueTrunFix, valueTrun);
                return rt;
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
                // Based on __m256d int64_to_double_fast_precise(const __m256i v)
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                Vector128<int> lowerBits;
                lowerBits = Sse2.And(value, Vector128.Create(ScalarConstants.DoubleVal_MaskLow32).AsInt64()).AsInt32();
                lowerBits = Sse2.Or(lowerBits, Vector128.Create(ScalarConstants.DoubleVal_2Pow52).AsInt32());
                Vector128<long> upperBits = Sse2.ShiftRightLogical(value, 32);                                               // Extract the 32 most significant bits of vector
                upperBits = Sse2.Xor(upperBits, Vector128.Create(ScalarConstants.DoubleVal_2Pow84_2Pow63).AsInt64());        // Flip the msb of upperBits and blend with the bit representation of double(2^84 + 2^63)
                Vector128<double> result = Sse2.Subtract(upperBits.AsDouble(), Vector128.Create(ScalarConstants.DoubleVal_2Pow84_2Pow63_2Pow52)); // Compute in double precision: (upper - (2^84 + 2^63 + 2^52)) + lower
                return Sse2.Add(result, lowerBits.AsDouble());
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
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector128Double(value);
                }
#endif // NET8_0_OR_GREATER
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 14, 2016 at 17:23 Mysticial
                // inline __m128d int64_to_double128(__m128i x){
                //     /*  Mysticial's fast int64_to_double. Works for inputs in the range: (-2^51, 2^51)  */
                //     x = _mm128_add_epi64(x, _mm128_castpd_si128(_mm128_set1_pd(0x0018000000000000)));
                //     return _mm128_sub_pd(_mm128_castsi128_pd(x), _mm128_set1_pd(0x0018000000000000));
                // }
                // BitConverter.DoubleToInt64Bits((double)0x0018000000000000).ToString("X") = "4338000000000000"
                Vector128<long> magicNumber = Vector128.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51).AsInt64(); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector128<long> x = Sse2.Add(value, magicNumber);
                Vector128<double> result = Sse2.Subtract(x.AsDouble(), magicNumber.AsDouble());
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
                // Based on __m256d int64_to_double_fast_precise(const __m256i v)
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                Vector128<int> lowerBits;
                lowerBits = Sse2.And(value, Vector128.Create(ScalarConstants.DoubleVal_MaskLow32).AsUInt64()).AsInt32();
                lowerBits = Sse2.Or(lowerBits, Vector128.Create(ScalarConstants.DoubleVal_2Pow52).AsInt32());
                Vector128<ulong> upperBits = Sse2.ShiftRightLogical(value, 32);                                               // Extract the 32 most significant bits of vector
                upperBits = Sse2.Xor(upperBits, Vector128.Create(ScalarConstants.DoubleVal_2Pow84).AsUInt64());               // Blend upperBits with the bit representation of double(2^84)
                Vector128<double> result = Sse2.Subtract(upperBits.AsDouble(), Vector128.Create(ScalarConstants.DoubleVal_2Pow84_2Pow52)); // Compute in double precision: (upper - (2^84 + 2^52)) + lower
                return Sse2.Add(result, lowerBits.AsDouble());
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble_Range52(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Range52(Vector128<ulong> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector128Double(value);
                }
#endif // NET8_0_OR_GREATER
                // from https://stackoverflow.com/a/41223013/12860347. CC BY-SA 4.0
                // answered Dec 14, 2016 at 17:23 Mysticial
                // inline __m128d uint64_to_double128(__m128i x){
                //     /*  Mysticial's fast uint64_to_double. Works for inputs in the range: [0, 2^52)     */
                //     x = _mm128_or_si128(x, _mm128_castpd_si128(_mm128_set1_pd(0x0010000000000000)));
                //     return _mm128_sub_pd(_mm128_castsi128_pd(x), _mm128_set1_pd(0x0010000000000000));
                // }
                // BitConverter.DoubleToInt64Bits((double)0x0010000000000000).ToString("X") = "4330000000000000"
                Vector128<ulong> magicNumber = Vector128.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt64(); // Double value: pow(2, 52)
                Vector128<ulong> x = Sse2.Or(value, magicNumber);
                Vector128<double> result = Sse2.Subtract(x.AsDouble(), magicNumber.AsDouble());
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
                return Sse2.ConvertToVector128Int32WithTruncation(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    //TypeCodeFlags rt = SuperStatics.ConvertToInt64_AcceleratedTypes;
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64(Vector128<double> value) {
                // return SuperStatics.ConvertToInt64(value);
                return ConvertToInt64_HwScalar(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_HwScalar(Vector128<double> value) {
                if (Sse2.X64.IsSupported) {
                    Vector128<double> valueOdd = Sse2.Shuffle(value, value, (byte)ShuffleControlG2.YY);
                    long v_0 = Sse2.X64.ConvertToInt64WithTruncation(value);
                    long v_1 = Sse2.X64.ConvertToInt64WithTruncation(valueOdd);
                    Vector128<long> result = Vector128.Create(v_0, v_1);
                    return result;
                } else {
                    return SuperStatics.ConvertToInt64(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_Range52(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_Range52(Vector128<double> value) {
                return ConvertToInt64_Range52_Impl(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_Range52(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_Range52_Impl(Vector128<double> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector128Int64WithTruncation(value);
                }
#endif // NET8_0_OR_GREATER
                value = YRoundToZero(value); // Truncate.
                return ConvertToInt64_Range52RoundToEven(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_Range52RoundToEven(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_Range52RoundToEven(Vector128<double> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector128Int64(value);
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
                Vector128<double> magicNumber = Vector128.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector128<double> x = Sse2.Add(value, magicNumber);
                Vector128<long> result = Sse2.Subtract(x.AsInt64(), magicNumber.AsInt64());
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
                return Sse2.ConvertToVector128Single(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> ConvertToSingle(Vector128<uint> value) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ConvertToVector128Single(value);
                }
#endif // NET8_0_OR_GREATER
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
                Vector128<int> lowerBits = Sse2.And(value, Vector128.Create(0x0000FFFFU)).AsInt32();
                Vector128<int> upperBits = Sse2.ShiftRightLogical(value, 16).AsInt32();
                Vector128<float> lower = Sse2.ConvertToVector128Single(lowerBits);
                Vector128<float> upper = Sse2.ConvertToVector128Single(upperBits);
                // This next bit of magic works because all multiples of 65536, at least up to 65535
                // are likewise exactly representable
                //
                // This means that scaling upper by 65536 gives us the exactly representable base value
                // and then the remaining lower value, which is likewise up to 65535 can be added on
                // giving us a result that will correctly round to the nearest representable value
                if (Fma.IsSupported) {
                    return Fma.MultiplyAdd(upper, Vector128.Create(65536.0f), lower);
                } else {
                    Vector128<float> result = Sse2.Multiply(upper, Vector128.Create(65536.0f));
                    return Sse2.Add(result, lower);
                }
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
                //return SuperStatics.ConvertToUInt32(value);
                //return ConvertToUInt32_Mapping(value);
                return ConvertToUInt32_MappingFix(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
            /// <remarks>Input range is `[-pow(2,31), pow(2,32))`. Out of range results in `2147483648`(pow(2,31)).</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ConvertToUInt32_Mapping(Vector128<float> value) {
                // [pow(2,31), pow(2,32)-1] mapping to [-pow(2,31), -1]. Subtract `pow(2,32)`.
                Vector128<float> highEnd = Vector128.Create(ScalarConstants.SingleBit_2Pow32).AsSingle();
                Vector128<float> highBegin = Vector128.Create(ScalarConstants.SingleBit_2Pow31).AsSingle();
                Vector128<float> highMapped = Sse.Subtract(value, highEnd);
                Vector128<float> highMask = Sse.And(Sse.CompareLessThanOrEqual(highBegin, value), Sse.CompareLessThan(value, highEnd)); // highBegin <= value < highEnd .
                Vector128<float> value2 = ConditionalSelect_Relaxed(highMask, highMapped, value);
                Vector128<uint> rt = Sse2.ConvertToVector128Int32WithTruncation(value2).AsUInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
            /// <remarks>Input range is `[-pow(2,31), pow(2,32))`. Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ConvertToUInt32_MappingFix(Vector128<float> value) {
                // [pow(2,31), pow(2,32)-1] mapping to [-pow(2,31), -1]. Subtract `pow(2,32)`.
                Vector128<float> highEnd = Vector128.Create(ScalarConstants.SingleBit_2Pow32).AsSingle();
                Vector128<float> lowBegin = Vector128.Create(ScalarConstants.SingleBit_Negative2Pow31).AsSingle();
                Vector128<float> highBegin = Vector128.Create(ScalarConstants.SingleBit_2Pow31).AsSingle();
                Vector128<float> lessHighEnd = Sse.CompareLessThan(value, highEnd); // value < highEnd .
                Vector128<float> highMapped = Sse.Subtract(value, highEnd);
                Vector128<float> lowMask = Sse.And(Sse.CompareLessThanOrEqual(lowBegin, value), lessHighEnd); // lowBegin <= value < highEnd .
                Vector128<float> value0 = Sse.And(value, lowMask); // If out of range, set to 0.
                Vector128<float> highMask = Sse.And(Sse.CompareLessThanOrEqual(highBegin, value), lessHighEnd); // highBegin <= value < highEnd .
                Vector128<float> value2 = ConditionalSelect_Relaxed(highMask, highMapped, value0);
                Vector128<uint> rt = Sse2.ConvertToVector128Int32WithTruncation(value2).AsUInt32();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
            /// <remarks>Input range is all number (Use mod function). Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ConvertToUInt32_Mod(Vector128<float> value) {
                // remainder = mod(value, highEnd) = value - floor(value/highEnd)*highEnd
                Vector128<float> highEndDiv = Vector128.Create(ScalarConstants.SingleBit_2PowNegative32).AsSingle();
                Vector128<float> highEnd = Vector128.Create(ScalarConstants.SingleBit_2Pow32).AsSingle();
                Vector128<float> lowBegin = Vector128.Create(ScalarConstants.SingleBit_Negative2Pow31).AsSingle();
                Vector128<float> highBegin = Vector128.Create(ScalarConstants.SingleBit_2Pow31).AsSingle();
                Vector128<float> quotientFloor = Sse.Multiply(value, highEndDiv); // Sse.Divide(value, highEnd);
                quotientFloor = Sse41.Floor(quotientFloor);
                Vector128<float> intRangeMask = Sse.And(Sse.CompareLessThanOrEqual(lowBegin, value), Sse.CompareLessThan(value, highBegin)); // lowBegin <= value < highBegin .
                Vector128<float> remainder = Sse.Subtract(value, Sse.Multiply(quotientFloor, highEnd));
                // [pow(2,31), pow(2,32)-1] mapping to [-pow(2,31), -1]. Subtract `pow(2,32)`.
                Vector128<float> uintRangeMask = Sse.And(Sse.CompareLessThanOrEqual(Vector128<float>.Zero, remainder), Sse.CompareLessThan(remainder, highEnd)); // lowBegin <= remainder < highEnd .
                Vector128<float> highMask = Sse.CompareLessThanOrEqual(highBegin, remainder); // highBegin <= value .
                Vector128<float> remainder0 = Sse.And(remainder, uintRangeMask); // If out of range, set to 0.
                Vector128<float> highMapped = Sse.Subtract(remainder0, highEnd);
                Vector128<float> value2 = ConditionalSelect_Relaxed(highMask, highMapped, remainder0);
                // If within the signed integer range, return value, otherwise return value2 .
                Vector128<float> value3 = ConditionalSelect_Relaxed(intRangeMask, value, value2);
                Vector128<uint> rt = Sse2.ConvertToVector128Int32WithTruncation(value3).AsUInt32();
                return rt;
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
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector128UInt64WithTruncation(value);
                }
#endif // NET8_0_OR_GREATER
                value = YRoundToZero(value); // Truncate.
                return ConvertToUInt64_Range52RoundToEven(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64_Range52RoundToEven(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64_Range52RoundToEven(Vector128<double> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector128UInt64(value);
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
                Vector128<double> magicNumber = Vector128.Create(ScalarConstants.DoubleVal_2Pow52); // Double value: pow(2, 52)
                Vector128<double> x = Sse2.Add(value, magicNumber);
                Vector128<ulong> result = Sse2.Xor(x.AsUInt64(), magicNumber.AsUInt64());
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
                return (uint)Sse.MoveMask(vector);
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<double> vector) {
                return (uint)Sse2.MoveMask(vector);
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
                return (uint)Sse2.MoveMask(vector);
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
                Vector128<byte> m;
                if (Ssse3.IsSupported) {
                    m = Ssse3.Shuffle(vector.AsByte(), Vector128Constants.ExtractMostSignificantBits_Shuffle_HiByteOf16); // Packed the high byte.
                } else {
                    Vector128<short> t = Sse2.ShiftRightLogical(vector, 8).AsInt16();
                    m = Sse2.PackUnsignedSaturate(t, Vector128<short>.Zero);
                }
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
                if (Sse41.IsSupported) {
                    return Sse41.Floor(value);
                } else {
                    return Floor_ClearBit(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Floor(Vector128<double> value) {
                if (Sse41.IsSupported) {
                    return Sse41.Floor(value);
                } else {
                    return Floor_ClearBit(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Floor_ClearBit(Vector128<float> value) {
                Vector128<float> fixMask = Sse.CompareLessThan(value, Vector128<float>.Zero);
                Vector128<float> valueTrun = YRoundToZero_ClearBit(value);
                Vector128<float> equalsMask = Sse.CompareEqual(value, valueTrun);
                fixMask = Sse.AndNot(equalsMask, fixMask); // It mean `Vector128.AndNot(fixMask, equalsMask)`
                Vector128<float> valueTrunFix = Sse.Subtract(valueTrun, Vector128.Create(1.0f));
                Vector128<float> rt = ConditionalSelect(fixMask, valueTrunFix, valueTrun);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Floor_ClearBit(Vector128<double> value) {
                Vector128<double> fixMask = Sse2.CompareLessThan(value, Vector128<double>.Zero);
                Vector128<double> valueTrun = YRoundToZero_ClearBit(value);
                Vector128<double> equalsMask = Sse2.CompareEqual(value, valueTrun);
                fixMask = Sse2.AndNot(equalsMask, fixMask); // It mean `Vector128.AndNot(fixMask, equalsMask)`
                Vector128<double> valueTrunFix = Sse2.Subtract(valueTrun, Vector128.Create(1.0d));
                Vector128<double> rt = ConditionalSelect(fixMask, valueTrunFix, valueTrun);
                return rt;
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
                if (Avx.IsSupported) {
                    return Avx.ConvertToVector128Single(lower.ToVector256Unsafe().WithUpper(upper));
                }
                Vector128<float> rt0 = Sse2.ConvertToVector128Single(lower); // double(a, b) -> float(a, b, 0, 0)
                Vector128<float> rt1 = Sse2.ConvertToVector128Single(upper); // double(c, d) -> float(c, d, 0, 0)
                Vector128<float> rt = Sse.Shuffle(rt0, rt1, (byte)ShuffleControlG4.XYXY); // control = 0 + (1 << 2) + (0 << 4) + (1 << 6)
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{short}, Vector128{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Narrow(Vector128<short> lower, Vector128<short> upper) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported && Avx.IsSupported) {
                    return Avx512BW.VL.ConvertToVector128SByte(lower.ToVector256Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                return Narrow(lower.AsUInt16(), upper.AsUInt16()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{ushort}, Vector128{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Narrow(Vector128<ushort> lower, Vector128<ushort> upper) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported && Avx.IsSupported) {
                    return Avx512BW.VL.ConvertToVector128Byte(lower.ToVector256Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                Vector128<ushort> mask = Vector128Constants.UInt16_VMaxByte;
                Vector128<byte> rt = Sse2.PackUnsignedSaturate(Sse2.And(lower, mask).AsInt16(), Sse2.And(upper, mask).AsInt16());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{int}, Vector128{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Narrow(Vector128<int> lower, Vector128<int> upper) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported && Avx.IsSupported) {
                    return Avx512F.VL.ConvertToVector128Int16(lower.ToVector256Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                return Narrow(lower.AsUInt32(), upper.AsUInt32()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{uint}, Vector128{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Narrow(Vector128<uint> lower, Vector128<uint> upper) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported && Avx.IsSupported) {
                    return Avx512F.VL.ConvertToVector128UInt16(lower.ToVector256Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                if (Sse41.IsSupported) {
                    // Need: Sse41
                    Vector128<uint> mask = Vector128Constants.UInt32_VMaxUInt16;
                    Vector128<ushort> rt = Sse41.PackUnsignedSaturate(Sse2.And(lower, mask).AsInt32(), Sse2.And(upper, mask).AsInt32());
                    return rt;
                } else {
                    Vector128<ushort> l = Sse2.UnpackLow(lower.AsUInt16(), upper.AsUInt16()); // bit16(a0.L, b0.L, a0.H, b0.H, a1.L, b1.L, a1.H, b1.H)
                    Vector128<ushort> h = Sse2.UnpackHigh(lower.AsUInt16(), upper.AsUInt16()); // bit16(a2.L, b2.L, a2.H, b2.H, a3.L, b3.L, a3.H, b3.H)
                    Vector128<ushort> l2 = Sse2.UnpackLow(l, h); // bit16(a0.L, a2.L, b0.L, b2.L, a0.H, a2.H, b0.H, b2.H)
                    Vector128<ushort> h2 = Sse2.UnpackHigh(l, h); // bit16(a1.L, a3.L, b1.L, b3.L, a1.H, a3.H, b1.H, b3.H)
                    Vector128<ushort> rt = Sse2.UnpackLow(l2, h2); // bit16(a0.L, a1.L, a2.L, a3.L, b0.L, b1.L, b2.L, b3.L)
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{long}, Vector128{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Narrow(Vector128<long> lower, Vector128<long> upper) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ConvertToVector128Int32(lower.ToVector256Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                return Narrow(lower.AsUInt64(), upper.AsUInt64()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{ulong}, Vector128{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Narrow(Vector128<ulong> lower, Vector128<ulong> upper) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ConvertToVector128UInt32(lower.ToVector256Unsafe().WithUpper(upper));
                }
#endif // NET8_0_OR_GREATER
                Vector128<uint> l = Sse2.UnpackLow(lower.AsUInt32(), upper.AsUInt32()); // bit32(a0.L, b0.L, a0.H, b0.H)
                Vector128<uint> h = Sse2.UnpackHigh(lower.AsUInt32(), upper.AsUInt32()); // bit32(a1.L, b1.L, a1.H, b1.H)
                Vector128<uint> rt = Sse2.UnpackLow(l, h); // bit32(a0.L, a1.L, b0.L, b1.L).
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
                var args0 = Vector128.CreateScalar((int)shiftAmount).AsByte();
                args1 = Vector128Constants.GetResidueMaskBits_Byte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{short}, int, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1) {
                _ = dummy;
                //Vector128<short> args0 = Sse2.ConvertScalarToVector128Int32(shiftAmount & 0x0F).AsInt16();
                Vector128<short> args0 = Vector128.CreateScalar((int)(shiftAmount & 0x0F)).AsInt16();
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
                Vector128<int> args0 = Vector128.CreateScalar((int)(shiftAmount & 0x1F)).AsInt32();
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{uint}, int, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Args(Vector128<uint> dummy, int shiftAmount, out Vector128<uint> args1) {
                _ = dummy;
                var args0 = Vector128.CreateScalar((uint)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{long}, int, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
                _ = dummy;
                Vector128<long> args0 = Vector128.CreateScalar((int)(shiftAmount & 0x3F)).AsInt64();
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
                //Console.WriteLine("Sse: args0={0}, args1={1}", args0, args1);
                var t = Sse2.And(value, args1).AsUInt32();
                return Sse2.ShiftLeftLogical(t, args0.AsUInt32()).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftLeftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Core(Vector128<ushort> value, int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftLeftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftLeftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Core(Vector128<uint> value, int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
                _ = shiftAmount;
                _ = args1;
                //Console.WriteLine("Sse: args0={0}, args1={1}", args0, args1);
                return Sse2.ShiftLeftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftLeftLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Core(Vector128<ulong> value, int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftLeftLogical(value, args0);
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
                Vector128<byte> t = Sse2.And(value, Vector128Constants.GetResidueMaskBits_Byte(shiftAmount));
                return Sse2.ShiftLeftLogical(t.AsUInt32(), (byte)shiftAmount).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Const(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Const(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Const(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                Vector128<byte> t = Sse2.And(value, Vector128Constants.GetResidueMaskBits_Byte(shiftAmount));
                return Sse2.ShiftLeftLogical(t.AsUInt32(), (byte)shiftAmount).AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Fast(Vector128<short> value, int shiftAmount) {
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount); // For non-constant parameters, JIT will automatically use the Vector128 version (对于非常量参数, JIT会自动使用Vector128的版本). e.g. Sse2.ShiftLeftLogical(Vector128{ushort}, Vector128{ushort})
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Fast(Vector128<ushort> value, int shiftAmount) {
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Fast(Vector128<int> value, int shiftAmount) {
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Fast(Vector128<uint> value, int shiftAmount) {
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Fast(Vector128<long> value, int shiftAmount) {
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Fast(Vector128<ulong> value, int shiftAmount) {
                return Sse2.ShiftLeftLogical(value, (byte)shiftAmount);
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
                var args0 = Vector128.CreateScalar((int)shiftAmount).AsSByte();
                args1 = Vector128Constants.GetResidueMaskBits_SByte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{short}, int, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1) {
                _ = dummy;
                Vector128<short> args0 = Vector128.CreateScalar((int)(shiftAmount & 0x0F)).AsInt16();
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{int}, int, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1) {
                _ = dummy;
                var args0 = Vector128.CreateScalar((int)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Args(Vector128{long}, int, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
                _ = dummy;
                shiftAmount &= 0x3F;
                var args0 = Vector128.CreateScalar((int)shiftAmount).AsInt64();
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                _ = shiftAmount;
                Vector128<sbyte> sign = Sse2.CompareGreaterThan(Vector128<sbyte>.Zero, value);
                Vector128<sbyte> shifted = Sse2.ShiftRightLogical(value.AsUInt32(), args0.AsUInt32()).AsSByte();
                Vector128<sbyte> rt = ConditionalSelect(args1, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftRightArithmetic(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftRightArithmetic(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = shiftAmount;
                _ = args1;
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ShiftRightArithmetic(value, args0);
                }
#endif // NET8_0_OR_GREATER
                Vector128<long> sign;
                if (Sse42.IsSupported) {
                    sign = Sse42.CompareGreaterThan(Vector128<long>.Zero, value);
                } else {
                    Vector128<int> valueHigh = Sse2.Shuffle(value.AsInt32(), (byte)ShuffleControlG4.YYWW);
                    sign = Sse2.CompareGreaterThan(Vector128<int>.Zero, valueHigh).AsInt64();
                }
                Vector128<long> rt = Sse2.Xor(value, sign);
                rt = Sse2.ShiftRightLogical(rt, args0);
                rt = Sse2.Xor(rt, sign);
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
                return Sse2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Const(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Sse2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Const(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ShiftRightArithmetic(value, (byte)shiftAmount);
                }
#endif // NET8_0_OR_GREATER
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
                return Sse2.ShiftRightArithmetic(value, (byte)shiftAmount);
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
                return Sse2.ShiftRightArithmetic(value, (byte)shiftAmount);
#else
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ShiftRightArithmetic(value, (byte)shiftAmount);
                }
#endif // NET8_0_OR_GREATER
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
                Vector128<short> lowerToHigh = Sse2.ShiftLeftLogical(value.AsInt16(), 8);
                Vector128<short> lowerShifted = Sse2.ShiftRightArithmetic(lowerToHigh, (byte)shiftAmount);
                Vector128<sbyte> upper = Sse2.ShiftRightArithmetic(value.AsInt16(), (byte)shiftAmount).AsSByte();
                Vector128<sbyte> lower = Sse2.ShiftRightLogical(lowerShifted, 8).AsSByte();
                Vector128<sbyte> rt = Sse2.Or(Sse2.And(Vector128s<sbyte>.XyYMask, upper), lower);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Fast_Negative(Vector128<sbyte> value, int shiftAmount) {
                Vector128<sbyte> mask = Vector128Constants.GetResidueMaskBits_SByte(shiftAmount);
                Vector128<sbyte> shifted = Sse2.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsSByte();
                Vector128<sbyte> sign = Sse2.CompareGreaterThan(Vector128<sbyte>.Zero, value);
                Vector128<sbyte> rt = ConditionalSelect(mask, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Fast(Vector128<short> value, int shiftAmount) {
                return Sse2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Fast(Vector128<int> value, int shiftAmount) {
                return Sse2.ShiftRightArithmetic(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Fast(Vector128<long> value, int shiftAmount) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ShiftRightArithmetic(value, (byte)shiftAmount);
                }
#endif // NET8_0_OR_GREATER
                return ShiftRightArithmetic_Fast_Xor(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Fast_Negative(Vector128<long> value, int shiftAmount) {
                byte shiftAmountLeft = (byte)(64 - shiftAmount);
                Vector128<long> sign;
                if (Sse42.IsSupported) {
                    sign = Sse42.CompareGreaterThan(Vector128<long>.Zero, value);
                } else {
                    Vector128<int> valueHigh = Sse2.Shuffle(value.AsInt32(), (byte)ShuffleControlG4.YYWW);
                    sign = Sse2.CompareGreaterThan(Vector128<int>.Zero, valueHigh).AsInt64();
                }
                Vector128<long> rt = Sse2.Or(Sse2.ShiftRightLogical(value, (byte)shiftAmount), Sse2.ShiftLeftLogical(sign, shiftAmountLeft));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Fast_Xor(Vector128<long> value, int shiftAmount) {
                // t = -(x>>>31); return ((x^t)>>>n)^t; // From "Hacker's Delight", Page 18.
                Vector128<long> sign;// Mask `0>x` is `-(x>>>31)`.
                if (Sse42.IsSupported) {
                    sign = Sse42.CompareGreaterThan(Vector128<long>.Zero, value);
                } else {
                    Vector128<int> valueHigh = Sse2.Shuffle(value.AsInt32(), (byte)ShuffleControlG4.YYWW);
                    sign = Sse2.CompareGreaterThan(Vector128<int>.Zero, valueHigh).AsInt64();
                }
                Vector128<long> rt = Sse2.Xor(value, sign);
                rt = Sse2.ShiftRightLogical(rt, (byte)shiftAmount);
                rt = Sse2.Xor(rt, sign);
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
                var args0 = Vector128.CreateScalar((uint)shiftAmount).AsByte();
                args1 = Vector128Constants.GetResidueMaskBits_Byte(shiftAmount);
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{short}, int, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1) {
                _ = dummy;
                Vector128<short> args0 = Vector128.CreateScalar((int)(shiftAmount & 0x0F)).AsInt16();
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
                var args0 = Vector128.CreateScalar((int)(shiftAmount & 0x1F));
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{uint}, int, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Args(Vector128<uint> dummy, int shiftAmount, out Vector128<uint> args1) {
                var args0 = ShiftRightLogical_Args(dummy.AsInt32(), shiftAmount, out var a1).AsUInt32();
                args1 = a1.AsUInt32();
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{long}, int, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
                _ = dummy;
                var args0 = Vector128.CreateScalar((int)(shiftAmount & 0x3F)).AsInt64();
                args1 = default;
                return args0;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Args(Vector128<ulong> dummy, int shiftAmount, out Vector128<ulong> args1) {
                var args0 = ShiftRightLogical_Args(dummy.AsInt64(), shiftAmount, out var a1).AsUInt64();
                args1 = a1.AsUInt64();
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
                var rt = Sse2.ShiftRightLogical(value.AsUInt32(), args0.AsUInt32()).AsByte();
                rt = Sse2.And(rt, args1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftRightLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Core(Vector128<ushort> value, int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftRightLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftRightLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Core(Vector128<uint> value, int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftRightLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftRightLogical(value, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Core(Vector128<ulong> value, int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
                _ = shiftAmount;
                _ = args1;
                return Sse2.ShiftRightLogical(value, args0);
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
                Vector128<byte> t = Sse2.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsByte();
                Vector128<byte> rt = Sse2.And(t, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Const(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Const(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Const(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
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
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
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
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
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
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
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
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
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
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
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
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
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
                Vector128<byte> t = Sse2.AndNot(mask, value);
                Vector128<byte> rt = Sse2.ShiftRightLogical(t.AsUInt16(), (byte)shiftAmount).AsByte();
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Fast_FirstShift(Vector128<byte> value, int shiftAmount) {
                Vector128<byte> mask = Vector128Constants.GetResidueMaskBits_Byte(shiftAmount);
                Vector128<byte> t = Sse2.ShiftRightLogical(value.AsUInt16(), (byte)shiftAmount).AsByte();
                Vector128<byte> rt = Sse2.And(t, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Fast(Vector128<short> value, int shiftAmount) {
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Fast(Vector128<ushort> value, int shiftAmount) {
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Fast(Vector128<int> value, int shiftAmount) {
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Fast(Vector128<uint> value, int shiftAmount) {
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Fast(Vector128<long> value, int shiftAmount) {
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Fast(Vector128<ulong> value, int shiftAmount) {
                return Sse2.ShiftRightLogical(value, (byte)shiftAmount);
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
                if (Ssse3.IsSupported) {
                    Vector128<sbyte> indicesAdded;
                    Vector128<byte> mask, raw, rt;
#if NET8_0_OR_GREATER
                    if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                        mask = Avx512BW.VL.CompareGreaterThan(Vector128.Create((byte)16), indices);
                        raw = YShuffleKernel(vector, indices);
                        rt = Sse2.And(raw, mask);
                        return rt;
                    }
#endif // NET8_0_OR_GREATER
                    indicesAdded = Sse2.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue));
                    mask = Sse2.CompareGreaterThan(
                        Vector128.Create((sbyte)(16 + sbyte.MinValue)),
                        indicesAdded
                    ).AsByte(); // Unsigned compare: (i < 16)
                    raw = YShuffleKernel(vector, indices);
                    rt = Sse2.And(raw, mask);
                    return rt;
                } else {
                    return SuperStatics.Shuffle(vector, indices);
                }
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
                if (Ssse3.IsSupported) {
                    Vector128<ushort> mask, raw, rt;
                    mask = Sse2.CompareEqual(Sse2.ShiftRightLogical(indices, 3), Vector128<ushort>.Zero); // Unsigned compare: (i < 8)
                    raw = YShuffleKernel(vector, indices);
                    rt = Sse2.And(raw, mask);
                    return rt;
                } else {
                    return SuperStatics.Shuffle(vector, indices);
                }
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
                if (Ssse3.IsSupported) {
                    Vector128<uint> mask, raw, rt;
                    mask = Sse2.CompareEqual(Sse2.ShiftRightLogical(indices, 2), Vector128<uint>.Zero); // Unsigned compare: (i < 4)
                    raw = YShuffleKernel(vector, indices);
                    rt = Sse2.And(raw, mask);
                    return rt;
                } else {
                    return SuperStatics.Shuffle(vector, indices);
                }
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
                if (Ssse3.IsSupported) {
                    Vector128<ulong> mask, raw, rt;
                    mask = Equals(Sse2.ShiftRightLogical(indices, 1), Vector128<ulong>.Zero); // Unsigned compare: (i < 2)
                    raw = YShuffleKernel(vector, indices);
                    rt = Sse2.And(raw, mask);
                    return rt;
                } else {
                    return SuperStatics.Shuffle(vector, indices);
                }
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
                if (Ssse3.IsSupported) {
                    Vector128<sbyte> indicesAdded;
                    YShuffleKernel_Args(indices, out args0, out args1);
#if NET8_0_OR_GREATER
                    if (Avx512Vbmi.VL.IsSupported) {
                        if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                            args1 = Avx512BW.VL.CompareGreaterThanOrEqual(indices, Vector128.Create((byte)16)); // Unsigned compare: (i >= 16)
                            args0 = Sse2.Or(args0, args1);
                        } else {
                            indicesAdded = Sse2.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue));
                            args1 = Sse2.CompareGreaterThan(
                                Vector128.Create((sbyte)(16 + sbyte.MinValue)),
                                indicesAdded
                            ).AsByte(); // Unsigned compare: (i < 16)
                            args0 = YOrNot(args0, args1);
                        }
                        return;
                    }
#endif // NET8_0_OR_GREATER
                    indicesAdded = Sse2.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue));
                    Vector128<byte> mask = Sse2.CompareGreaterThan(
                        Vector128.Create((sbyte)(16 + sbyte.MinValue)),
                        indicesAdded
                    ).AsByte(); // Unsigned compare: (i < 16)
                    mask = OnesComplement(mask); // Used for _mm128_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                    args0 = Sse2.Or(args0, mask);
                } else {
                    SuperStatics.Shuffle_Args(indices, out args0, out args1);
                }
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
                if (Ssse3.IsSupported) {
#if NET8_0_OR_GREATER
                    if (Avx512BW.VL.IsSupported) {
                        YShuffleKernel_Args_Multiply(indices, out args0, out args1);
                        args1 = Sse2.CompareEqual(Sse2.ShiftRightLogical(indices, 3), Vector128<ushort>.Zero); // Unsigned compare: (i < 8)
                        args0 = YOrNot(args0, args1);
                        return;
                    }
#endif // NET8_0_OR_GREATER
                    YShuffleKernel_Args(indices, out args0, out args1);
                    Vector128<ushort> mask = Sse2.CompareEqual(Sse2.ShiftRightLogical(indices, 3), Vector128<ushort>.Zero); // Unsigned compare: (i < 8)
                    mask = OnesComplement(mask); // Used for _mm128_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                    args0 = Sse2.Or(args0, mask);
                } else {
                    SuperStatics.Shuffle_Args(indices, out args0, out args1);
                }
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
                if (Ssse3.IsSupported) {
                    YShuffleKernel_Args(indices, out args0, out args1);
#if NET8_0_OR_GREATER
                    if (Avx512F.VL.IsSupported) {
                        args1 = Sse2.CompareEqual(Sse2.ShiftRightLogical(indices, 2), Vector128<uint>.Zero); // Unsigned compare: (i < 4)
                        args0 = YOrNot(args0, args1);
                        return;
                    }
#endif // NET8_0_OR_GREATER
                    Vector128<int> indicesAdded = Sse2.Add(indices.AsInt32(), Vector128.Create(int.MinValue));
                    Vector128<uint> mask = Sse2.CompareEqual(Sse2.ShiftRightLogical(indices, 2), Vector128<uint>.Zero); // Unsigned compare: (i < 4)
                    mask = OnesComplement(mask); // Used for _mm128_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                    args0 = Sse2.Or(args0, mask);
                } else {
                    SuperStatics.Shuffle_Args(indices, out args0, out args1);
                }
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
                if (Ssse3.IsSupported) {
                    YShuffleKernel_Args(indices, out args0, out args1);
#if NET8_0_OR_GREATER
                    if (Avx512F.VL.IsSupported) {
                        args1 = Equals(Sse2.ShiftRightLogical(indices, 1), Vector128<ulong>.Zero); // Unsigned compare: (i < 2)
                        args0 = YOrNot(args0, args1);
                        return;
                    }
#endif // NET8_0_OR_GREATER
                    Vector128<long> indicesAdded = Sse2.Add(indices.AsInt64(), Vector128Constants.Int64_MinValue);
                    Vector128<ulong> mask = Equals(Sse2.ShiftRightLogical(indices, 1), Vector128<ulong>.Zero); // Unsigned compare: (i < 2)
                    mask = OnesComplement(mask); // Used for _mm128_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                    args0 = Sse2.Or(args0, mask);
                } else {
                    SuperStatics.Shuffle_Args(indices, out args0, out args1);
                }
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
                if (Ssse3.IsSupported) {
                    _ = args1;
                    return Ssse3.Shuffle(vector, args0);
                } else {
                    return SuperStatics.Shuffle_Core(vector, args0, args1);
                }
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
                Widen_Unpack(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{byte}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<byte> source, out Vector128<ushort> lower, out Vector128<ushort> upper) {
                Widen_Unpack(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{short}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<short> source, out Vector128<int> lower, out Vector128<int> upper) {
                Widen_Unpack(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<ushort> source, out Vector128<uint> lower, out Vector128<uint> upper) {
                Widen_Unpack(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
                Widen_Unpack(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<uint> source, out Vector128<ulong> lower, out Vector128<ulong> upper) {
                Widen_Unpack(source, out lower, out upper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{sbyte}, out Vector128{short}, out Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector128<sbyte> source, out Vector128<short> lower, out Vector128<short> upper) {
                lower = Sse41.ConvertToVector128Int16(source);
                Vector128<sbyte> sourceUpper = Sse2.UnpackHigh(source.AsInt64(), source.AsInt64()).AsSByte();
                upper = Sse41.ConvertToVector128Int16(sourceUpper);
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
                lower = Sse41.ConvertToVector128Int32(source);
                Vector128<short> sourceUpper = Sse2.UnpackHigh(source.AsUInt64(), source.AsUInt64()).AsInt16();
                upper = Sse41.ConvertToVector128Int32(sourceUpper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector128<ushort> source, out Vector128<uint> lower, out Vector128<uint> upper) {
                lower = Sse41.ConvertToVector128Int32(source).AsUInt32();
                Vector128<ushort> sourceUpper = Sse2.UnpackHigh(source.AsUInt64(), source.AsUInt64()).AsUInt16();
                upper = Sse41.ConvertToVector128Int32(sourceUpper).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
                lower = Sse41.ConvertToVector128Int64(source);
                Vector128<int> sourceUpper = Sse2.UnpackHigh(source.AsInt64(), source.AsInt64()).AsInt32();
                upper = Sse41.ConvertToVector128Int64(sourceUpper);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_ConvertTo(Vector128<uint> source, out Vector128<ulong> lower, out Vector128<ulong> upper) {
                lower = Sse41.ConvertToVector128Int64(source).AsUInt64();
                Vector128<uint> sourceUpper = Sse2.UnpackHigh(source.AsUInt64(), source.AsUInt64()).AsUInt32();
                upper = Sse41.ConvertToVector128Int64(sourceUpper).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{sbyte}, out Vector128{short}, out Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector128<sbyte> source, out Vector128<short> lower, out Vector128<short> upper) {
                Vector128<sbyte> zero = Vector128<sbyte>.Zero;
                Vector128<sbyte> mask = Sse2.CompareGreaterThan(zero, source);
                lower = Sse2.UnpackLow(source, mask).AsInt16();
                upper = Sse2.UnpackHigh(source, mask).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{byte}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector128<byte> source, out Vector128<ushort> lower, out Vector128<ushort> upper) {
                Vector128<byte> zero = Vector128<byte>.Zero;
                lower = Sse2.UnpackLow(source.AsByte(), zero).AsUInt16();
                upper = Sse2.UnpackHigh(source.AsByte(), zero).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{short}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector128<short> source, out Vector128<int> lower, out Vector128<int> upper) {
                Vector128<short> zero = Vector128<short>.Zero;
                Vector128<short> mask = Sse2.CompareGreaterThan(zero, source);
                lower = Sse2.UnpackLow(source, mask).AsInt32();
                upper = Sse2.UnpackHigh(source, mask).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector128<ushort> source, out Vector128<uint> lower, out Vector128<uint> upper) {
                Vector128<ushort> zero = Vector128<ushort>.Zero;
                lower = Sse2.UnpackLow(source.AsUInt16(), zero).AsUInt32();
                upper = Sse2.UnpackHigh(source.AsUInt16(), zero).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
                Vector128<int> zero = Vector128<int>.Zero;
                Vector128<int> mask = Sse2.CompareGreaterThan(zero, source);
                lower = Sse2.UnpackLow(source, mask).AsInt64();
                upper = Sse2.UnpackHigh(source, mask).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Unpack(Vector128<uint> source, out Vector128<ulong> lower, out Vector128<ulong> upper) {
                Vector128<uint> zero = Vector128<uint>.Zero;
                lower = Sse2.UnpackLow(source.AsUInt32(), zero).AsUInt64();
                upper = Sse2.UnpackHigh(source.AsUInt32(), zero).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.WidenLower_AcceleratedTypes"/>
            public static TypeCodeFlags WidenLower_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> WidenLower(Vector128<float> source) {
                return Sse2.ConvertToVector128Double(source);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> WidenLower(Vector128<sbyte> source) {
                Vector128<sbyte> zero = Vector128<sbyte>.Zero;
                Vector128<sbyte> mask = Sse2.CompareGreaterThan(zero, source);
                return Sse2.UnpackLow(source, mask).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> WidenLower(Vector128<byte> source) {
                Vector128<byte> zero = Vector128<byte>.Zero;
                return Sse2.UnpackLow(source.AsByte(), zero).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> WidenLower(Vector128<short> source) {
                Vector128<short> zero = Vector128<short>.Zero;
                Vector128<short> mask = Sse2.CompareGreaterThan(zero, source);
                return Sse2.UnpackLow(source, mask).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> WidenLower(Vector128<ushort> source) {
                Vector128<ushort> zero = Vector128<ushort>.Zero;
                return Sse2.UnpackLow(source.AsUInt16(), zero).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> WidenLower(Vector128<int> source) {
                Vector128<int> zero = Vector128<int>.Zero;
                Vector128<int> mask = Sse2.CompareGreaterThan(zero, source);
                return Sse2.UnpackLow(source, mask).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenLower(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> WidenLower(Vector128<uint> source) {
                Vector128<uint> zero = Vector128<uint>.Zero;
                return Sse2.UnpackLow(source.AsUInt32(), zero).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.WidenUpper_AcceleratedTypes"/>
            public static TypeCodeFlags WidenUpper_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> WidenUpper(Vector128<float> source) {
                Vector128<float> sourceUpper = Sse2.UnpackHigh(source.AsDouble(), source.AsDouble()).AsSingle();
                return Sse2.ConvertToVector128Double(sourceUpper);
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> WidenUpper(Vector128<sbyte> source) {
                Vector128<sbyte> zero = Vector128<sbyte>.Zero;
                Vector128<sbyte> mask = Sse2.CompareGreaterThan(zero, source);
                return Sse2.UnpackHigh(source, mask).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> WidenUpper(Vector128<byte> source) {
                Vector128<byte> zero = Vector128<byte>.Zero;
                return Sse2.UnpackHigh(source.AsByte(), zero).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> WidenUpper(Vector128<short> source) {
                Vector128<short> zero = Vector128<short>.Zero;
                Vector128<short> mask = Sse2.CompareGreaterThan(zero, source);
                return Sse2.UnpackHigh(source, mask).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> WidenUpper(Vector128<ushort> source) {
                Vector128<ushort> zero = Vector128<ushort>.Zero;
                return Sse2.UnpackHigh(source.AsUInt16(), zero).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> WidenUpper(Vector128<int> source) {
                Vector128<int> zero = Vector128<int>.Zero;
                Vector128<int> mask = Sse2.CompareGreaterThan(zero, source);
                return Sse2.UnpackHigh(source, mask).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.WidenUpper(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> WidenUpper(Vector128<uint> source) {
                Vector128<uint> zero = Vector128<uint>.Zero;
                return Sse2.UnpackHigh(source.AsUInt32(), zero).AsUInt64();
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
