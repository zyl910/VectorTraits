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
    using SuperStatics = WVectorTraits128Sse.Statics;

    /// <summary>
    /// <see cref="Vector128{T}"/> traits - Avx2 .
    /// </summary>
    public sealed partial class WVectorTraits128Avx2 : WVectorTraits128Avx2Abstract {
        private static readonly WVectorTraits128Avx2 _instance = new WVectorTraits128Avx2(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits128Avx2 Instance {
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
                lowerBits = value.AsInt32();
                lowerBits = Avx2.Blend(lowerBits, Vector128.Create(ScalarConstants.DoubleVal_2Pow52).AsInt32(), 0b1010); // Blend the 32 lowest significant bits of vector with the bit representation of double(2^52)
                Vector128<long> upperBits = Sse2.ShiftRightLogical(value, 32);                                               // Extract the 32 most significant bits of vector
                upperBits = Sse2.Xor(upperBits, Vector128.Create(ScalarConstants.DoubleVal_2Pow84_2Pow63).AsInt64());        // Flip the msb of upperBits and blend with the bit representation of double(2^84 + 2^63)
                Vector128<double> result = Sse2.Subtract(upperBits.AsDouble(), Vector128.Create(ScalarConstants.DoubleVal_2Pow84_2Pow63_2Pow52)); // Compute in double precision: (upper - (2^84 + 2^63 + 2^52)) + lower
                return Sse2.Add(result, lowerBits.AsDouble());
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
                lowerBits = value.AsInt32();
                lowerBits = Avx2.Blend(lowerBits, Vector128.Create(ScalarConstants.DoubleVal_2Pow52).AsInt32(), 0b1010); // Blend the 32 lowest significant bits of vector with the bit representation of double(2^52)
                Vector128<ulong> upperBits = Sse2.ShiftRightLogical(value, 32);                                               // Extract the 32 most significant bits of vector
                upperBits = Sse2.Xor(upperBits, Vector128.Create(ScalarConstants.DoubleVal_2Pow84).AsUInt64());               // Blend upperBits with the bit representation of double(2^84)
                Vector128<double> result = Sse2.Subtract(upperBits.AsDouble(), Vector128.Create(ScalarConstants.DoubleVal_2Pow84_2Pow52)); // Compute in double precision: (upper - (2^84 + 2^52)) + lower
                return Sse2.Add(result, lowerBits.AsDouble());
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = SuperStatics.ConvertToInt64_AcceleratedTypes;
                    if (Sse41.IsSupported && Sse42.IsSupported) {
                        rt |= TypeCodeFlags.Double;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64(Vector128<double> value) {
                if (Sse41.IsSupported && Sse42.IsSupported) {
                    return ConvertToInt64_ShiftVarFix(value);
                } else {
                    return SuperStatics.ConvertToInt64(value);
                }
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
                Vector128<long> negative = Sse42.CompareGreaterThan(zero, bin);                     //3,1. negative[i] = (0 < bin[i])
                Vector128<long> mat = Sse2.And(bin, mat_mask);                                     //1,1/3. Get mantissa field.
                mat = Sse2.Or(mat, hidden_1);                                                      //1,1/3. Convert mantissa field to integer.
                Vector128<long> exp_enc = Sse2.ShiftLeftLogical(bin, 1);                           //1,1/2. Remove sign bit.
                exp_enc = Sse2.ShiftRightLogical(exp_enc, 1 + ScalarConstants.Double_MantissaBits);//1,1/2. (bin[i]<<1)>>(1+52) = abs_double(bin[i])>>52
                Vector128<long> exp_frac = Sse2.Subtract(exp_enc, exp_bias);                       //1,1/3. Convert exponent field to shift amount .
                Vector128<long> exp_frac_n = Sse2.Subtract(zero, exp_frac);                        //1,1/3. exp_frac_n[i] = -exp_frac[i]
                Vector128<long> exp_is_end = Sse42.CompareGreaterThan(exp_enc, exp_max);            //3,1.  exp_is_end[i] = (exp_enc[i] > exp_max[i]) .
                Vector128<long> msl = Avx2.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt64());     //1,1/2. msl[i] = mat << exp_frac[i]
                Vector128<long> msr = Avx2.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt64());  //1,1/2. msr[i] = mat >> exp_frac_n[i] = mat >> (-exp_frac[i])
                Vector128<long> exp_is_pos = Sse42.CompareGreaterThan(exp_frac, zero);              //3,1. The mask of exp_frac is a positive
                Vector128<long> result_abs = Sse41.BlendVariable(msr, msl, exp_is_pos);             //2,1. result_abs[i] = (exp_is_pos[i])?msl[i]:msl[i]
                result_abs = Sse41.BlendVariable(result_abs, defValue, exp_is_end);                 //2,1.  result_abs[i] = (exp_is_end[i])?defValue[i]:result_abs[i]
                Vector128<long> result = Sse2.Xor(result_abs, negative);                           //1,1/3. ~x = xor(x, -1)
                result = Sse2.Subtract(result, negative);                                          //1,1/3 -(x) = (~x)+1 = (~x) - (-1)
                return result;  //total latency: 23, total throughput CPI: 9
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
