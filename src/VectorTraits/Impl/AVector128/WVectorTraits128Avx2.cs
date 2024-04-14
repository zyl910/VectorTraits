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
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector128Double(value);
                }
#endif // NET8_0_OR_GREATER
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
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector128Double(value);
                }
#endif // NET8_0_OR_GREATER
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
#if NET8_0_OR_GREATER
                    if (Avx512DQ.VL.IsSupported) {
                        rt |= TypeCodeFlags.Double;
                    }
#endif // NET8_0_OR_GREATER
                    if (Sse41.IsSupported && Sse42.IsSupported) {
                        rt |= TypeCodeFlags.Double;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64(Vector128<double> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector128Int64WithTruncation(value);
                }
#endif // NET8_0_OR_GREATER
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
                Vector128<long> result_abs = ConditionalSelect_Relaxed(exp_is_pos, msl, msr); // ConditionalSelect_Relaxed(exp_is_pos, msl, msr); // Sse41.BlendVariable(msr, msl, exp_is_pos);             //2,1. result_abs[i] = (exp_is_pos[i])?msl[i]:msl[i]
                result_abs = ConditionalSelect_Relaxed(exp_is_end, defValue, result_abs); // Sse41.BlendVariable(result_abs, defValue, exp_is_end);                 //2,1.  result_abs[i] = (exp_is_end[i])?defValue[i]:result_abs[i]
                Vector128<long> result = Sse2.Xor(result_abs, negative);                           //1,1/3. ~x = xor(x, -1)
                result = Sse2.Subtract(result, negative);                                          //1,1/3 -(x) = (~x)+1 = (~x) - (-1)
                return result;  //total latency: 23, total throughput CPI: 9
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
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ConvertToVector128UInt32WithTruncation(value);
                }
#endif // NET8_0_OR_GREATER
                if (Sse41.IsSupported) {
                    return ConvertToUInt32_ShiftVar(value);
                } else {
                    return SuperStatics.ConvertToUInt32(value);
                }
            }

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
                Vector128<int> mat = Sse2.And(bin, mat_mask);                                    //1,1/3
                mat = Sse2.Or(mat, hidden_1);                                                    //1,1/3
                Vector128<int> exp_enc = Sse2.ShiftRightLogical(bin, 23);                        //1,1/2
                Vector128<int> exp_frac = Sse2.Subtract(exp_enc, exp_bias);                      //1,1/3
                Vector128<int> msl = Avx2.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt32());    //1,1/2
                Vector128<int> exp_frac_n = Sse2.Subtract(zero, exp_frac);                       //1,1/3
                Vector128<int> msr = Avx2.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt32()); //1,1/2
                Vector128<int> exp_is_pos = Sse2.CompareGreaterThan(exp_frac, zero);             //3,1
                Vector128<int> result_abs = ConditionalSelect_Relaxed(exp_is_pos, msl, msr); // Sse41.BlendVariable(msr, msl, exp_is_pos);            //2,1
                return result_abs.AsUInt32();	//total latency: 12, total throughput CPI: 4.8
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
                get {
                    //return SuperStatics.ConvertToUInt64_AcceleratedTypes;
                    TypeCodeFlags rt = SuperStatics.ConvertToUInt64_AcceleratedTypes;
                    if (Sse41.IsSupported && Sse42.IsSupported) {
                        rt |= TypeCodeFlags.Double;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64(Vector128<double> value) {
#if NET8_0_OR_GREATER
                if (Avx512DQ.VL.IsSupported) {
                    return Avx512DQ.VL.ConvertToVector128UInt64WithTruncation(value);
                }
#endif // NET8_0_OR_GREATER
                if (Sse41.IsSupported && Sse42.IsSupported) {
                    return ConvertToUInt64_ShiftVar(value);
                } else {
                    return SuperStatics.ConvertToUInt64(value);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64(Vector128{double})"/>
            /// <remarks>Input range is `[0, pow(2,64))`. Out of range results in `0`.</remarks>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64_ShiftVar(Vector128<double> value) {
                // See Avx2 ConvertToUInt64_ShiftVar.
                //constants
                Vector128<long> mat_mask = Vector128.Create(ScalarConstants.DoubleVal_MantissaMask).AsInt64();  //0_00000000000_1111111111111111111111111111111111111111111111111111
                Vector128<long> hidden_1 = Vector128.Create(ScalarConstants.IntDbl_2Pow52).AsInt64();  //0_00000000001_0000000000000000000000000000000000000000000000000000 // Int64: 2^52
                Vector128<long> exp_bias = Vector128.Create(ScalarConstants.IntDbl_DoubleBias52).AsInt64(); //0_10001010011_0000000000000000000000000000000100000000000000000000    //2^84 + 2^52
                Vector128<long> zero = Vector128<long>.Zero;
                //majik operations										  //Latency, Throughput(references IceLake)
                Vector128<long> bin = value.AsInt64();
                Vector128<long> mat = Sse2.And(bin, mat_mask);                                    //1,1/3
                mat = Sse2.Or(mat, hidden_1);                                                     //1,1/3
                Vector128<long> exp_enc = Sse2.ShiftRightLogical(bin, 52);                        //1,1/2
                Vector128<long> exp_frac = Sse2.Subtract(exp_enc, exp_bias);                      //1,1/3
                Vector128<long> msl = Avx2.ShiftLeftLogicalVariable(mat, exp_frac.AsUInt64());    //1,1/2
                Vector128<long> exp_frac_n = Sse2.Subtract(zero, exp_frac);                       //1,1/3
                Vector128<long> msr = Avx2.ShiftRightLogicalVariable(mat, exp_frac_n.AsUInt64()); //1,1/2
                Vector128<long> exp_is_pos = Sse42.CompareGreaterThan(exp_frac, zero);             //3,1
                Vector128<long> result_abs = ConditionalSelect_Relaxed(exp_is_pos, msl, msr); // Sse41.BlendVariable(msr, msl, exp_is_pos);            //2,1
                return result_abs.AsUInt64();	//total latency: 12, total throughput CPI: 4.8
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
                //Console.WriteLine("Avx2 Args: args0={0}, args1={1}", args0, args1);
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
                //Console.WriteLine("Avx2: args0={0}, args1={1}", args0, args1);
                var t = Sse2.And(value, args1).AsUInt32();
                return Avx2.ShiftLeftLogicalVariable(t, args0.AsUInt32()).AsByte();
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
                Vector128<sbyte> sign = Sse2.CompareGreaterThan(Vector128<sbyte>.Zero, value);
                Vector128<sbyte> shifted = Avx2.ShiftRightLogicalVariable(value.AsUInt32(), args0.AsUInt32()).AsSByte();
                Vector128<sbyte> rt = SuperStatics.ConditionalSelect(args1, shifted, sign);
                return rt;
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
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.ShiftRightArithmeticVariable(value, args0.AsUInt64());
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
                rt = Avx2.ShiftRightLogicalVariable(rt, args0.AsUInt64());
                rt = Sse2.Xor(rt, sign);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_ConstCore(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                return ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
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
                rt = Sse2.And(rt, args1);
                return rt;
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

#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
