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

#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
