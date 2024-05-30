#if NET7_0_OR_GREATER
#define BCL_SHUFFLE_HAS
#define VECTOR_HAS_METHOD
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Numerics;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector512 {
    /// <summary>
    /// <see cref="Vector512{T}"/> traits - Base.
    /// </summary>
    public sealed partial class WVectorTraits512Base : WVectorTraits512Abstract {
        private static readonly WVectorTraits512Base _instance = new WVectorTraits512Base(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits512Base Instance {
            get { return _instance; }
        }

#if NET8_0_OR_GREATER


#endif // NET8_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector512{T}"/> traits.Statics - Base.
        /// </summary>
        public static partial class Statics {

#if NETX_0_OR_GREATER
            private const bool Bcl_Shuffle_Used = true;
#else
            private const bool Bcl_Shuffle_Used = true;
#endif // NETX_0_OR_GREATER

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

            /// <inheritdoc cref="IBaseTraits.IsHardwareAccelerated"/>
            public static bool IsHardwareAccelerated {
                get {
#if NET8_0_OR_GREATER
                    return Vector512.IsHardwareAccelerated;
#else
                    return false;
#endif // NET8_0_OR_GREATER
                }
            }

            /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
            public static bool GetIsSupported(bool noStrict = false) {
                bool rt = false;
#if NET8_0_OR_GREATER
                rt = true;
#else
#endif // NET8_0_OR_GREATER
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Vector512 type is not supported!";
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
                return rt;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits512.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Ceiling(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Ceiling(Vector512<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Ceiling(value);
#else
                return Ceiling_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Ceiling(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Ceiling(Vector512<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Ceiling(value);
#else
                return Ceiling_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Ceiling(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Ceiling_Basic(Vector512<float> value) {
                Vector512<float> rt = value;
                ref float p = ref Unsafe.As<Vector512<float>, float>(ref rt);
                p = MathF.Ceiling(p);
                Unsafe.Add(ref p, 1) = MathF.Ceiling(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = MathF.Ceiling(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = MathF.Ceiling(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = MathF.Ceiling(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = MathF.Ceiling(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = MathF.Ceiling(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = MathF.Ceiling(Unsafe.Add(ref p, 7));
                Unsafe.Add(ref p, 8) = MathF.Ceiling(Unsafe.Add(ref p, 8));
                Unsafe.Add(ref p, 9) = MathF.Ceiling(Unsafe.Add(ref p, 9));
                Unsafe.Add(ref p, 10) = MathF.Ceiling(Unsafe.Add(ref p, 10));
                Unsafe.Add(ref p, 11) = MathF.Ceiling(Unsafe.Add(ref p, 11));
                Unsafe.Add(ref p, 12) = MathF.Ceiling(Unsafe.Add(ref p, 12));
                Unsafe.Add(ref p, 13) = MathF.Ceiling(Unsafe.Add(ref p, 13));
                Unsafe.Add(ref p, 14) = MathF.Ceiling(Unsafe.Add(ref p, 14));
                Unsafe.Add(ref p, 15) = MathF.Ceiling(Unsafe.Add(ref p, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Ceiling(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Ceiling_Basic(Vector512<double> value) {
                Vector512<double> rt = value;
                ref double p = ref Unsafe.As<Vector512<double>, double>(ref rt);
                p = Math.Ceiling(p);
                Unsafe.Add(ref p, 1) = Math.Ceiling(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = Math.Ceiling(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = Math.Ceiling(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = Math.Ceiling(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = Math.Ceiling(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = Math.Ceiling(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = Math.Ceiling(Unsafe.Add(ref p, 7));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble(Vector512<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ConvertToDouble(value);
#else
                return ConvertToDouble_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble(Vector512<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ConvertToDouble(value);
#else
                return ConvertToDouble_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Basic(Vector512<long> value) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref double prt = ref Unsafe.As<Vector512<double>, double>(ref rt);
                ref long p = ref Unsafe.As<Vector512<long>, long>(ref value);
                prt = (Double)p;
                Unsafe.Add(ref prt, 1) = (Double)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Double)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Double)Unsafe.Add(ref p, 3);
                Unsafe.Add(ref prt, 4) = (Double)Unsafe.Add(ref p, 4);
                Unsafe.Add(ref prt, 5) = (Double)Unsafe.Add(ref p, 5);
                Unsafe.Add(ref prt, 6) = (Double)Unsafe.Add(ref p, 6);
                Unsafe.Add(ref prt, 7) = (Double)Unsafe.Add(ref p, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Basic(Vector512<ulong> value) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref double prt = ref Unsafe.As<Vector512<double>, double>(ref rt);
                ref ulong p = ref Unsafe.As<Vector512<ulong>, ulong>(ref value);
                prt = (Double)p;
                Unsafe.Add(ref prt, 1) = (Double)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Double)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Double)Unsafe.Add(ref p, 3);
                Unsafe.Add(ref prt, 4) = (Double)Unsafe.Add(ref p, 4);
                Unsafe.Add(ref prt, 5) = (Double)Unsafe.Add(ref p, 5);
                Unsafe.Add(ref prt, 6) = (Double)Unsafe.Add(ref p, 6);
                Unsafe.Add(ref prt, 7) = (Double)Unsafe.Add(ref p, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_Range52(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Range52(Vector512<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (VectorEnvironment.ProcessIsX86Family && Vector<byte>.Count < BitOfByte.Bit512) {
                    return ConvertToDouble_Range52_Impl(value);
                } else {
                    return Vector512.ConvertToDouble(value);
                }
#elif VECTOR_HAS_METHOD
                return ConvertToDouble_Range52_Impl(value);
#else
                return ConvertToDouble_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_Range52(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Range52(Vector512<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (VectorEnvironment.ProcessIsX86Family && Vector<byte>.Count < BitOfByte.Bit512) {
                    return ConvertToDouble_Range52_Impl(value);
                } else {
                    return Vector512.ConvertToDouble(value);
                }
#elif VECTOR_HAS_METHOD
                return ConvertToDouble_Range52_Impl(value);
#else
                return ConvertToDouble_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_Range52(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Range52_Impl(Vector512<long> value) {
#if VECTOR_HAS_METHOD
                // See more: WVectorTraits512Avx2.ConvertToDouble_Range52
                Vector512<long> magicNumber = Vector512.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51).AsInt64(); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector512<long> x = Vector512.Add(value, magicNumber);
                Vector512<double> result = Vector512.Subtract(x.AsDouble(), magicNumber.AsDouble());
#else
                Vector512<double> result = ConvertToDouble_Basic(value);
#endif // VECTOR_HAS_METHOD
                return result;
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_Range52(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> ConvertToDouble_Range52_Impl(Vector512<ulong> value) {
#if VECTOR_HAS_METHOD
                // See more: WVectorTraits512Avx2.ConvertToDouble_Range52
                Vector512<ulong> magicNumber = Vector512.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt64(); // Double value: pow(2, 52)
                Vector512<ulong> x = Vector512.BitwiseOr(value, magicNumber);
                Vector512<double> result = Vector512.Subtract(x.AsDouble(), magicNumber.AsDouble());
#else
                Vector512<double> result = ConvertToDouble_Basic(value);
#endif // VECTOR_HAS_METHOD
                return result;
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt32_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt32(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ConvertToInt32(Vector512<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ConvertToInt32(value);
#else
                return ConvertToInt32_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt32(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ConvertToInt32_Basic(Vector512<float> value) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref int prt = ref Unsafe.As<Vector512<int>, int>(ref rt);
                ref float p = ref Unsafe.As<Vector512<float>, float>(ref value);
                prt = (Int32)p;
                Unsafe.Add(ref prt, 1) = (Int32)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Int32)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Int32)Unsafe.Add(ref p, 3);
                Unsafe.Add(ref prt, 4) = (Int32)Unsafe.Add(ref p, 4);
                Unsafe.Add(ref prt, 5) = (Int32)Unsafe.Add(ref p, 5);
                Unsafe.Add(ref prt, 6) = (Int32)Unsafe.Add(ref p, 6);
                Unsafe.Add(ref prt, 7) = (Int32)Unsafe.Add(ref p, 7);
                Unsafe.Add(ref prt, 8) = (Int32)Unsafe.Add(ref p, 8);
                Unsafe.Add(ref prt, 9) = (Int32)Unsafe.Add(ref p, 9);
                Unsafe.Add(ref prt, 10) = (Int32)Unsafe.Add(ref p, 10);
                Unsafe.Add(ref prt, 11) = (Int32)Unsafe.Add(ref p, 11);
                Unsafe.Add(ref prt, 12) = (Int32)Unsafe.Add(ref p, 12);
                Unsafe.Add(ref prt, 13) = (Int32)Unsafe.Add(ref p, 13);
                Unsafe.Add(ref prt, 14) = (Int32)Unsafe.Add(ref p, 14);
                Unsafe.Add(ref prt, 15) = (Int32)Unsafe.Add(ref p, 15);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        //rt |= TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64(Vector512<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ConvertToInt64(value);
#else
                return ConvertToInt64_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_Basic(Vector512<double> value) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref long prt = ref Unsafe.As<Vector512<long>, long>(ref rt);
                ref double p = ref Unsafe.As<Vector512<double>, double>(ref value);
                prt = (Int64)p;
                Unsafe.Add(ref prt, 1) = (Int64)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Int64)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Int64)Unsafe.Add(ref p, 3);
                Unsafe.Add(ref prt, 4) = (Int64)Unsafe.Add(ref p, 4);
                Unsafe.Add(ref prt, 5) = (Int64)Unsafe.Add(ref p, 5);
                Unsafe.Add(ref prt, 6) = (Int64)Unsafe.Add(ref p, 6);
                Unsafe.Add(ref prt, 7) = (Int64)Unsafe.Add(ref p, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_Range52(Vector512<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (VectorEnvironment.ProcessIsX86Family && Vector<byte>.Count < BitOfByte.Bit512) {
                    return ConvertToInt64_Range52_Impl(value);
                } else {
                    return Vector512.ConvertToInt64(value);
                }
#elif VECTOR_HAS_METHOD
                return ConvertToInt64_Range52_Impl(value);
#else
                return ConvertToInt64_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_Range52_Impl(Vector512<double> value) {
#if VECTOR_HAS_METHOD
                // See more: WVectorTraits512Avx2.ConvertToInt64_Range52_Impl
                value = YRoundToZero(value); // Truncate.
                return ConvertToInt64_Range52RoundToEven(value);
#else
                return ConvertToInt64_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52RoundToEven(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ConvertToInt64_Range52RoundToEven(Vector512<double> value) {
#if VECTOR_HAS_METHOD
                // See more: WVectorTraits256Avx2.ConvertToInt64_Range52RoundToEven
                Vector512<long> magicNumber = Vector512.Create(ScalarConstants.DoubleVal_2Pow52_2Pow51).AsInt64(); // Double value: 1.5*pow(2, 52) = pow(2, 52) + pow(2, 51)
                Vector512<double> x = Vector512.Add(value, magicNumber.AsDouble());
                Vector512<long> result = Vector512.Subtract(x.AsInt64(), magicNumber);
                return result;
#else
                return ConvertToInt64_Basic(value);
#endif // VECTOR_HAS_METHOD
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToSingle_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> ConvertToSingle(Vector512<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ConvertToSingle(value);
#else
                return ConvertToSingle_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> ConvertToSingle(Vector512<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ConvertToSingle(value);
#else
                return ConvertToSingle_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> ConvertToSingle_Basic(Vector512<int> value) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref float prt = ref Unsafe.As<Vector512<float>, float>(ref rt);
                ref int p = ref Unsafe.As<Vector512<int>, int>(ref value);
                prt = (Single)p;
                Unsafe.Add(ref prt, 1) = (Single)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Single)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Single)Unsafe.Add(ref p, 3);
                Unsafe.Add(ref prt, 4) = (Single)Unsafe.Add(ref p, 4);
                Unsafe.Add(ref prt, 5) = (Single)Unsafe.Add(ref p, 5);
                Unsafe.Add(ref prt, 6) = (Single)Unsafe.Add(ref p, 6);
                Unsafe.Add(ref prt, 7) = (Single)Unsafe.Add(ref p, 7);
                Unsafe.Add(ref prt, 8) = (Single)Unsafe.Add(ref p, 8);
                Unsafe.Add(ref prt, 9) = (Single)Unsafe.Add(ref p, 9);
                Unsafe.Add(ref prt, 10) = (Single)Unsafe.Add(ref p, 10);
                Unsafe.Add(ref prt, 11) = (Single)Unsafe.Add(ref p, 11);
                Unsafe.Add(ref prt, 12) = (Single)Unsafe.Add(ref p, 12);
                Unsafe.Add(ref prt, 13) = (Single)Unsafe.Add(ref p, 13);
                Unsafe.Add(ref prt, 14) = (Single)Unsafe.Add(ref p, 14);
                Unsafe.Add(ref prt, 15) = (Single)Unsafe.Add(ref p, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> ConvertToSingle_Basic(Vector512<uint> value) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref float prt = ref Unsafe.As<Vector512<float>, float>(ref rt);
                ref uint p = ref Unsafe.As<Vector512<uint>, uint>(ref value);
                prt = (Single)p;
                Unsafe.Add(ref prt, 1) = (Single)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Single)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Single)Unsafe.Add(ref p, 3);
                Unsafe.Add(ref prt, 4) = (Single)Unsafe.Add(ref p, 4);
                Unsafe.Add(ref prt, 5) = (Single)Unsafe.Add(ref p, 5);
                Unsafe.Add(ref prt, 6) = (Single)Unsafe.Add(ref p, 6);
                Unsafe.Add(ref prt, 7) = (Single)Unsafe.Add(ref p, 7);
                Unsafe.Add(ref prt, 8) = (Single)Unsafe.Add(ref p, 8);
                Unsafe.Add(ref prt, 9) = (Single)Unsafe.Add(ref p, 9);
                Unsafe.Add(ref prt, 10) = (Single)Unsafe.Add(ref p, 10);
                Unsafe.Add(ref prt, 11) = (Single)Unsafe.Add(ref p, 11);
                Unsafe.Add(ref prt, 12) = (Single)Unsafe.Add(ref p, 12);
                Unsafe.Add(ref prt, 13) = (Single)Unsafe.Add(ref p, 13);
                Unsafe.Add(ref prt, 14) = (Single)Unsafe.Add(ref p, 14);
                Unsafe.Add(ref prt, 15) = (Single)Unsafe.Add(ref p, 15);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32(Vector512{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ConvertToUInt32(Vector512<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ConvertToUInt32(value);
#else
                return ConvertToUInt32_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32(Vector512{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ConvertToUInt32_Basic(Vector512<float> value) {
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                ref uint prt = ref Unsafe.As<Vector512<uint>, uint>(ref rt);
                ref float p = ref Unsafe.As<Vector512<float>, float>(ref value);
                prt = (UInt32)p;
                Unsafe.Add(ref prt, 1) = (UInt32)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (UInt32)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (UInt32)Unsafe.Add(ref p, 3);
                Unsafe.Add(ref prt, 4) = (UInt32)Unsafe.Add(ref p, 4);
                Unsafe.Add(ref prt, 5) = (UInt32)Unsafe.Add(ref p, 5);
                Unsafe.Add(ref prt, 6) = (UInt32)Unsafe.Add(ref p, 6);
                Unsafe.Add(ref prt, 7) = (UInt32)Unsafe.Add(ref p, 7);
                Unsafe.Add(ref prt, 8) = (UInt32)Unsafe.Add(ref p, 8);
                Unsafe.Add(ref prt, 9) = (UInt32)Unsafe.Add(ref p, 9);
                Unsafe.Add(ref prt, 10) = (UInt32)Unsafe.Add(ref p, 10);
                Unsafe.Add(ref prt, 11) = (UInt32)Unsafe.Add(ref p, 11);
                Unsafe.Add(ref prt, 12) = (UInt32)Unsafe.Add(ref p, 12);
                Unsafe.Add(ref prt, 13) = (UInt32)Unsafe.Add(ref p, 13);
                Unsafe.Add(ref prt, 14) = (UInt32)Unsafe.Add(ref p, 14);
                Unsafe.Add(ref prt, 15) = (UInt32)Unsafe.Add(ref p, 15);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ConvertToUInt64(Vector512<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ConvertToUInt64(value);
#else
                return ConvertToUInt64_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ConvertToUInt64_Basic(Vector512<double> value) {
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
                ref ulong prt = ref Unsafe.As<Vector512<ulong>, ulong>(ref rt);
                ref double p = ref Unsafe.As<Vector512<double>, double>(ref value);
                prt = (UInt64)p;
                Unsafe.Add(ref prt, 1) = (UInt64)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (UInt64)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (UInt64)Unsafe.Add(ref p, 3);
                Unsafe.Add(ref prt, 4) = (UInt64)Unsafe.Add(ref p, 4);
                Unsafe.Add(ref prt, 5) = (UInt64)Unsafe.Add(ref p, 5);
                Unsafe.Add(ref prt, 6) = (UInt64)Unsafe.Add(ref p, 6);
                Unsafe.Add(ref prt, 7) = (UInt64)Unsafe.Add(ref p, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_Range52(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ConvertToUInt64_Range52(Vector512<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (VectorEnvironment.ProcessIsX86Family && Vector<byte>.Count < BitOfByte.Bit512) {
                    return ConvertToUInt64_Range52_Impl(value);
                } else {
                    return Vector512.ConvertToUInt64(value);
                }
#elif VECTOR_HAS_METHOD
                return ConvertToUInt64_Range52_Impl(value);
#else
                return ConvertToUInt64_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_Range52(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ConvertToUInt64_Range52_Impl(Vector512<double> value) {
#if VECTOR_HAS_METHOD
                // See more: WVectorTraits512Avx2.ConvertToUInt64_Range52_Impl
                value = YRoundToZero(value); // Truncate.
                return ConvertToUInt64_Range52RoundToEven(value);
#else
                return ConvertToUInt64_Basic(value);
#endif // VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_Range52RoundToEven(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ConvertToUInt64_Range52RoundToEven(Vector512<double> value) {
#if VECTOR_HAS_METHOD
                // See more: WVectorTraits256Avx2.ConvertToUInt64_Range52RoundToEven
                Vector512<ulong> magicNumber = Vector512.Create(ScalarConstants.DoubleVal_2Pow52).AsUInt64(); // Double value: pow(2, 52)
                Vector512<double> x = Vector512.Add(value, magicNumber.AsDouble());
                Vector512<ulong> result = Vector512.Xor(x.AsUInt64(), magicNumber);
                return result;
#else
                return ConvertToUInt64_Basic(value);
#endif // VECTOR_HAS_METHOD
            }


            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits_AcceleratedTypes"/>
            public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<float> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ExtractMostSignificantBits(vector);
                // .NET8 on Avx512: It has hardware-accelerated.
                //00007FFDAB5903AC  vmovups     zmm0,zmmword ptr [rcx]  
                //00007FFDAB5903B2  vpmovd2m    k1,zmm0  
                //00007FFDAB5903B8  kmovw       ecx,k1  
                //00007FFDAB5903BC  mov         qword ptr [rbp-4520h],rcx  
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<double> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ExtractMostSignificantBits(vector);
                // .NET8 on Avx512: It has hardware-accelerated.
                //00007FFDAB590491  vmovups     zmm0,zmmword ptr [rcx]  
                //00007FFDAB590497  vpmovq2m    k1,zmm0  
                //00007FFDAB59049D  kmovb       ecx,k1  
                //00007FFDAB5904A1  mov         qword ptr [rbp-4558h],rcx  
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<sbyte> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ExtractMostSignificantBits(vector);
                // .NET8 on Avx512: It has hardware-accelerated.
                //00007FFDAB590576  vmovups     zmm0,zmmword ptr [rcx]  
                //00007FFDAB59057C  vpmovb2m    k1,zmm0  
                //00007FFDAB590582  kmovq       rcx,k1  
                //00007FFDAB590587  mov         qword ptr [rbp-4590h],rcx  
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<byte> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<short> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ExtractMostSignificantBits(vector);
                // .NET8 on Avx512: It has hardware-accelerated.
                //00007FFDAB590742  vmovups     zmm0,zmmword ptr [rcx]  
                //00007FFDAB590748  vpmovw2m    k1,zmm0  
                //00007FFDAB59074E  kmovd       ecx,k1  
                //00007FFDAB590752  mov         qword ptr [rbp-4600h],rcx  
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<ushort> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<int> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<uint> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<long> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits(Vector512<ulong> vector) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Basic(Vector512<float> vector) {
                return ExtractMostSignificantBits_Basic(vector.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Basic(Vector512<double> vector) {
                return ExtractMostSignificantBits_Basic(vector.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Basic(Vector512<sbyte> vector) {
                return Statics.ExtractMostSignificantBits_Basic(vector.AsByte());
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Basic(Vector512<byte> vector) {
                ref byte p = ref Unsafe.As<Vector512<byte>, byte>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 1)) << 1)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 2)) << 2)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 3)) << 3)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 4)) << 4)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 5)) << 5)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 6)) << 6)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 7)) << 7)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 8)) << 8)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 9)) << 9)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 10)) << 10)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 11)) << 11)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 12)) << 12)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 13)) << 13)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 14)) << 14)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 15)) << 15)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 16)) << 16)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 17)) << 17)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 18)) << 18)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 19)) << 19)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 20)) << 20)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 21)) << 21)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 22)) << 22)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 23)) << 23)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 24)) << 24)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 25)) << 25)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 26)) << 26)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 27)) << 27)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 28)) << 28)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 29)) << 29)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 30)) << 30)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 31)) << 31)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 32)) << 32)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 33)) << 33)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 34)) << 34)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 35)) << 35)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 36)) << 36)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 37)) << 37)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 38)) << 38)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 39)) << 39)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 40)) << 40)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 41)) << 41)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 42)) << 42)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 43)) << 43)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 44)) << 44)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 45)) << 45)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 46)) << 46)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 47)) << 47)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 48)) << 48)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 49)) << 49)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 50)) << 50)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 51)) << 51)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 52)) << 52)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 53)) << 53)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 54)) << 54)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 55)) << 55)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 56)) << 56)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 57)) << 57)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 58)) << 58)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 59)) << 59)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 60)) << 60)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 61)) << 61)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 62)) << 62)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 63)) << 63)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Basic(Vector512<short> vector) {
                return ExtractMostSignificantBits_Basic(vector.AsUInt16());
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Basic(Vector512<ushort> vector) {
                ref ushort p = ref Unsafe.As<Vector512<ushort>, ushort>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 1)) << 1)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 2)) << 2)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 3)) << 3)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 4)) << 4)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 5)) << 5)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 6)) << 6)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 7)) << 7)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 8)) << 8)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 9)) << 9)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 10)) << 10)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 11)) << 11)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 12)) << 12)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 13)) << 13)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 14)) << 14)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 15)) << 15)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 16)) << 16)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 17)) << 17)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 18)) << 18)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 19)) << 19)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 20)) << 20)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 21)) << 21)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 22)) << 22)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 23)) << 23)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 24)) << 24)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 25)) << 25)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 26)) << 26)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 27)) << 27)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 28)) << 28)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 29)) << 29)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 30)) << 30)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 31)) << 31)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Basic(Vector512<int> vector) {
                return ExtractMostSignificantBits_Basic(vector.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Basic(Vector512<uint> vector) {
                ref uint p = ref Unsafe.As<Vector512<uint>, uint>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 1)) << 1)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 2)) << 2)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 3)) << 3)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 4)) << 4)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 5)) << 5)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 6)) << 6)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 7)) << 7)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 8)) << 8)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 9)) << 9)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 10)) << 10)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 11)) << 11)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 12)) << 12)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 13)) << 13)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 14)) << 14)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 15)) << 15)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Basic(Vector512<long> vector) {
                return ExtractMostSignificantBits_Basic(vector.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong ExtractMostSignificantBits_Basic(Vector512<ulong> vector) {
                ref ulong p = ref Unsafe.As<Vector512<ulong>, ulong>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 1)) << 1)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 2)) << 2)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 3)) << 3)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 4)) << 4)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 5)) << 5)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 6)) << 6)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 7)) << 7)
                ;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Floor(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Floor(Vector512<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Floor(value);
#else
                return Floor_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Floor(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Floor(Vector512<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Floor(value);
#else
                return Floor_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Floor(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Floor_Basic(Vector512<float> value) {
                Vector512<float> rt = value;
                ref float p = ref Unsafe.As<Vector512<float>, float>(ref rt);
                p = MathF.Floor(p);
                Unsafe.Add(ref p, 1) = MathF.Floor(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = MathF.Floor(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = MathF.Floor(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = MathF.Floor(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = MathF.Floor(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = MathF.Floor(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = MathF.Floor(Unsafe.Add(ref p, 7));
                Unsafe.Add(ref p, 8) = MathF.Floor(Unsafe.Add(ref p, 8));
                Unsafe.Add(ref p, 9) = MathF.Floor(Unsafe.Add(ref p, 9));
                Unsafe.Add(ref p, 10) = MathF.Floor(Unsafe.Add(ref p, 10));
                Unsafe.Add(ref p, 11) = MathF.Floor(Unsafe.Add(ref p, 11));
                Unsafe.Add(ref p, 12) = MathF.Floor(Unsafe.Add(ref p, 12));
                Unsafe.Add(ref p, 13) = MathF.Floor(Unsafe.Add(ref p, 13));
                Unsafe.Add(ref p, 14) = MathF.Floor(Unsafe.Add(ref p, 14));
                Unsafe.Add(ref p, 15) = MathF.Floor(Unsafe.Add(ref p, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Floor(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Floor_Basic(Vector512<double> value) {
                Vector512<double> rt = value;
                ref double p = ref Unsafe.As<Vector512<double>, double>(ref rt);
                p = Math.Floor(p);
                Unsafe.Add(ref p, 1) = Math.Floor(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = Math.Floor(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = Math.Floor(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = Math.Floor(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = Math.Floor(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = Math.Floor(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = Math.Floor(Unsafe.Add(ref p, 7));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{double}, Vector512{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Narrow(Vector512<double> lower, Vector512<double> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{short}, Vector512{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Narrow(Vector512<short> lower, Vector512<short> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{ushort}, Vector512{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Narrow(Vector512<ushort> lower, Vector512<ushort> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{int}, Vector512{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Narrow(Vector512<int> lower, Vector512<int> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{uint}, Vector512{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Narrow(Vector512<uint> lower, Vector512<uint> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{long}, Vector512{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Narrow(Vector512<long> lower, Vector512<long> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{ulong}, Vector512{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Narrow(Vector512<ulong> lower, Vector512<ulong> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Narrow(lower, upper);
#else
                return Narrow_Basic(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{double}, Vector512{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Narrow_Basic(Vector512<double> lower, Vector512<double> upper) {
                nint cnt = Vector512<double>.Count;
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref float p = ref Unsafe.As<Vector512<float>, float>(ref rt);
                ref double plower = ref Unsafe.As<Vector512<double>, double>(ref lower);
                ref double pupper = ref Unsafe.As<Vector512<double>, double>(ref upper);
                p = (float)plower;
                Unsafe.Add(ref p, 1) = (float)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (float)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (float)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (float)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (float)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (float)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (float)Unsafe.Add(ref plower, 7);
                p = ref Unsafe.Add(ref p, cnt);
                p = (float)pupper;
                Unsafe.Add(ref p, 1) = (float)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (float)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (float)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (float)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (float)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (float)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (float)Unsafe.Add(ref pupper, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{short}, Vector512{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Narrow_Basic(Vector512<short> lower, Vector512<short> upper) {
                nint cnt = Vector512<short>.Count;
                UnsafeUtil.SkipInit(out Vector512<sbyte> rt);
                ref sbyte p = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref rt);
                ref short plower = ref Unsafe.As<Vector512<short>, short>(ref lower);
                ref short pupper = ref Unsafe.As<Vector512<short>, short>(ref upper);
                p = (sbyte)plower;
                Unsafe.Add(ref p, 1) = (sbyte)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (sbyte)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (sbyte)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (sbyte)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (sbyte)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (sbyte)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (sbyte)Unsafe.Add(ref plower, 7);
                Unsafe.Add(ref p, 8) = (sbyte)Unsafe.Add(ref plower, 8);
                Unsafe.Add(ref p, 9) = (sbyte)Unsafe.Add(ref plower, 9);
                Unsafe.Add(ref p, 10) = (sbyte)Unsafe.Add(ref plower, 10);
                Unsafe.Add(ref p, 11) = (sbyte)Unsafe.Add(ref plower, 11);
                Unsafe.Add(ref p, 12) = (sbyte)Unsafe.Add(ref plower, 12);
                Unsafe.Add(ref p, 13) = (sbyte)Unsafe.Add(ref plower, 13);
                Unsafe.Add(ref p, 14) = (sbyte)Unsafe.Add(ref plower, 14);
                Unsafe.Add(ref p, 15) = (sbyte)Unsafe.Add(ref plower, 15);
                Unsafe.Add(ref p, 16) = (sbyte)Unsafe.Add(ref plower, 16);
                Unsafe.Add(ref p, 17) = (sbyte)Unsafe.Add(ref plower, 17);
                Unsafe.Add(ref p, 18) = (sbyte)Unsafe.Add(ref plower, 18);
                Unsafe.Add(ref p, 19) = (sbyte)Unsafe.Add(ref plower, 19);
                Unsafe.Add(ref p, 20) = (sbyte)Unsafe.Add(ref plower, 20);
                Unsafe.Add(ref p, 21) = (sbyte)Unsafe.Add(ref plower, 21);
                Unsafe.Add(ref p, 22) = (sbyte)Unsafe.Add(ref plower, 22);
                Unsafe.Add(ref p, 23) = (sbyte)Unsafe.Add(ref plower, 23);
                Unsafe.Add(ref p, 24) = (sbyte)Unsafe.Add(ref plower, 24);
                Unsafe.Add(ref p, 25) = (sbyte)Unsafe.Add(ref plower, 25);
                Unsafe.Add(ref p, 26) = (sbyte)Unsafe.Add(ref plower, 26);
                Unsafe.Add(ref p, 27) = (sbyte)Unsafe.Add(ref plower, 27);
                Unsafe.Add(ref p, 28) = (sbyte)Unsafe.Add(ref plower, 28);
                Unsafe.Add(ref p, 29) = (sbyte)Unsafe.Add(ref plower, 29);
                Unsafe.Add(ref p, 30) = (sbyte)Unsafe.Add(ref plower, 30);
                Unsafe.Add(ref p, 31) = (sbyte)Unsafe.Add(ref plower, 31);
                p = ref Unsafe.Add(ref p, cnt);
                p = (sbyte)pupper;
                Unsafe.Add(ref p, 1) = (sbyte)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (sbyte)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (sbyte)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (sbyte)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (sbyte)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (sbyte)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (sbyte)Unsafe.Add(ref pupper, 7);
                Unsafe.Add(ref p, 8) = (sbyte)Unsafe.Add(ref pupper, 8);
                Unsafe.Add(ref p, 9) = (sbyte)Unsafe.Add(ref pupper, 9);
                Unsafe.Add(ref p, 10) = (sbyte)Unsafe.Add(ref pupper, 10);
                Unsafe.Add(ref p, 11) = (sbyte)Unsafe.Add(ref pupper, 11);
                Unsafe.Add(ref p, 12) = (sbyte)Unsafe.Add(ref pupper, 12);
                Unsafe.Add(ref p, 13) = (sbyte)Unsafe.Add(ref pupper, 13);
                Unsafe.Add(ref p, 14) = (sbyte)Unsafe.Add(ref pupper, 14);
                Unsafe.Add(ref p, 15) = (sbyte)Unsafe.Add(ref pupper, 15);
                Unsafe.Add(ref p, 16) = (sbyte)Unsafe.Add(ref pupper, 16);
                Unsafe.Add(ref p, 17) = (sbyte)Unsafe.Add(ref pupper, 17);
                Unsafe.Add(ref p, 18) = (sbyte)Unsafe.Add(ref pupper, 18);
                Unsafe.Add(ref p, 19) = (sbyte)Unsafe.Add(ref pupper, 19);
                Unsafe.Add(ref p, 20) = (sbyte)Unsafe.Add(ref pupper, 20);
                Unsafe.Add(ref p, 21) = (sbyte)Unsafe.Add(ref pupper, 21);
                Unsafe.Add(ref p, 22) = (sbyte)Unsafe.Add(ref pupper, 22);
                Unsafe.Add(ref p, 23) = (sbyte)Unsafe.Add(ref pupper, 23);
                Unsafe.Add(ref p, 24) = (sbyte)Unsafe.Add(ref pupper, 24);
                Unsafe.Add(ref p, 25) = (sbyte)Unsafe.Add(ref pupper, 25);
                Unsafe.Add(ref p, 26) = (sbyte)Unsafe.Add(ref pupper, 26);
                Unsafe.Add(ref p, 27) = (sbyte)Unsafe.Add(ref pupper, 27);
                Unsafe.Add(ref p, 28) = (sbyte)Unsafe.Add(ref pupper, 28);
                Unsafe.Add(ref p, 29) = (sbyte)Unsafe.Add(ref pupper, 29);
                Unsafe.Add(ref p, 30) = (sbyte)Unsafe.Add(ref pupper, 30);
                Unsafe.Add(ref p, 31) = (sbyte)Unsafe.Add(ref pupper, 31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{ushort}, Vector512{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Narrow_Basic(Vector512<ushort> lower, Vector512<ushort> upper) {
                nint cnt = Vector512<ushort>.Count;
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
                ref byte p = ref Unsafe.As<Vector512<byte>, byte>(ref rt);
                ref ushort plower = ref Unsafe.As<Vector512<ushort>, ushort>(ref lower);
                ref ushort pupper = ref Unsafe.As<Vector512<ushort>, ushort>(ref upper);
                p = (byte)plower;
                Unsafe.Add(ref p, 1) = (byte)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (byte)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (byte)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (byte)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (byte)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (byte)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (byte)Unsafe.Add(ref plower, 7);
                Unsafe.Add(ref p, 8) = (byte)Unsafe.Add(ref plower, 8);
                Unsafe.Add(ref p, 9) = (byte)Unsafe.Add(ref plower, 9);
                Unsafe.Add(ref p, 10) = (byte)Unsafe.Add(ref plower, 10);
                Unsafe.Add(ref p, 11) = (byte)Unsafe.Add(ref plower, 11);
                Unsafe.Add(ref p, 12) = (byte)Unsafe.Add(ref plower, 12);
                Unsafe.Add(ref p, 13) = (byte)Unsafe.Add(ref plower, 13);
                Unsafe.Add(ref p, 14) = (byte)Unsafe.Add(ref plower, 14);
                Unsafe.Add(ref p, 15) = (byte)Unsafe.Add(ref plower, 15);
                Unsafe.Add(ref p, 16) = (byte)Unsafe.Add(ref plower, 16);
                Unsafe.Add(ref p, 17) = (byte)Unsafe.Add(ref plower, 17);
                Unsafe.Add(ref p, 18) = (byte)Unsafe.Add(ref plower, 18);
                Unsafe.Add(ref p, 19) = (byte)Unsafe.Add(ref plower, 19);
                Unsafe.Add(ref p, 20) = (byte)Unsafe.Add(ref plower, 20);
                Unsafe.Add(ref p, 21) = (byte)Unsafe.Add(ref plower, 21);
                Unsafe.Add(ref p, 22) = (byte)Unsafe.Add(ref plower, 22);
                Unsafe.Add(ref p, 23) = (byte)Unsafe.Add(ref plower, 23);
                Unsafe.Add(ref p, 24) = (byte)Unsafe.Add(ref plower, 24);
                Unsafe.Add(ref p, 25) = (byte)Unsafe.Add(ref plower, 25);
                Unsafe.Add(ref p, 26) = (byte)Unsafe.Add(ref plower, 26);
                Unsafe.Add(ref p, 27) = (byte)Unsafe.Add(ref plower, 27);
                Unsafe.Add(ref p, 28) = (byte)Unsafe.Add(ref plower, 28);
                Unsafe.Add(ref p, 29) = (byte)Unsafe.Add(ref plower, 29);
                Unsafe.Add(ref p, 30) = (byte)Unsafe.Add(ref plower, 30);
                Unsafe.Add(ref p, 31) = (byte)Unsafe.Add(ref plower, 31);
                p = ref Unsafe.Add(ref p, cnt);
                p = (byte)pupper;
                Unsafe.Add(ref p, 1) = (byte)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (byte)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (byte)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (byte)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (byte)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (byte)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (byte)Unsafe.Add(ref pupper, 7);
                Unsafe.Add(ref p, 8) = (byte)Unsafe.Add(ref pupper, 8);
                Unsafe.Add(ref p, 9) = (byte)Unsafe.Add(ref pupper, 9);
                Unsafe.Add(ref p, 10) = (byte)Unsafe.Add(ref pupper, 10);
                Unsafe.Add(ref p, 11) = (byte)Unsafe.Add(ref pupper, 11);
                Unsafe.Add(ref p, 12) = (byte)Unsafe.Add(ref pupper, 12);
                Unsafe.Add(ref p, 13) = (byte)Unsafe.Add(ref pupper, 13);
                Unsafe.Add(ref p, 14) = (byte)Unsafe.Add(ref pupper, 14);
                Unsafe.Add(ref p, 15) = (byte)Unsafe.Add(ref pupper, 15);
                Unsafe.Add(ref p, 16) = (byte)Unsafe.Add(ref pupper, 16);
                Unsafe.Add(ref p, 17) = (byte)Unsafe.Add(ref pupper, 17);
                Unsafe.Add(ref p, 18) = (byte)Unsafe.Add(ref pupper, 18);
                Unsafe.Add(ref p, 19) = (byte)Unsafe.Add(ref pupper, 19);
                Unsafe.Add(ref p, 20) = (byte)Unsafe.Add(ref pupper, 20);
                Unsafe.Add(ref p, 21) = (byte)Unsafe.Add(ref pupper, 21);
                Unsafe.Add(ref p, 22) = (byte)Unsafe.Add(ref pupper, 22);
                Unsafe.Add(ref p, 23) = (byte)Unsafe.Add(ref pupper, 23);
                Unsafe.Add(ref p, 24) = (byte)Unsafe.Add(ref pupper, 24);
                Unsafe.Add(ref p, 25) = (byte)Unsafe.Add(ref pupper, 25);
                Unsafe.Add(ref p, 26) = (byte)Unsafe.Add(ref pupper, 26);
                Unsafe.Add(ref p, 27) = (byte)Unsafe.Add(ref pupper, 27);
                Unsafe.Add(ref p, 28) = (byte)Unsafe.Add(ref pupper, 28);
                Unsafe.Add(ref p, 29) = (byte)Unsafe.Add(ref pupper, 29);
                Unsafe.Add(ref p, 30) = (byte)Unsafe.Add(ref pupper, 30);
                Unsafe.Add(ref p, 31) = (byte)Unsafe.Add(ref pupper, 31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{int}, Vector512{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Narrow_Basic(Vector512<int> lower, Vector512<int> upper) {
                nint cnt = Vector512<int>.Count;
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref short p = ref Unsafe.As<Vector512<short>, short>(ref rt);
                ref int plower = ref Unsafe.As<Vector512<int>, int>(ref lower);
                ref int pupper = ref Unsafe.As<Vector512<int>, int>(ref upper);
                p = (short)plower;
                Unsafe.Add(ref p, 1) = (short)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (short)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (short)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (short)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (short)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (short)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (short)Unsafe.Add(ref plower, 7);
                Unsafe.Add(ref p, 8) = (short)Unsafe.Add(ref plower, 8);
                Unsafe.Add(ref p, 9) = (short)Unsafe.Add(ref plower, 9);
                Unsafe.Add(ref p, 10) = (short)Unsafe.Add(ref plower, 10);
                Unsafe.Add(ref p, 11) = (short)Unsafe.Add(ref plower, 11);
                Unsafe.Add(ref p, 12) = (short)Unsafe.Add(ref plower, 12);
                Unsafe.Add(ref p, 13) = (short)Unsafe.Add(ref plower, 13);
                Unsafe.Add(ref p, 14) = (short)Unsafe.Add(ref plower, 14);
                Unsafe.Add(ref p, 15) = (short)Unsafe.Add(ref plower, 15);
                p = ref Unsafe.Add(ref p, cnt);
                p = (short)pupper;
                Unsafe.Add(ref p, 1) = (short)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (short)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (short)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (short)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (short)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (short)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (short)Unsafe.Add(ref pupper, 7);
                Unsafe.Add(ref p, 8) = (short)Unsafe.Add(ref pupper, 8);
                Unsafe.Add(ref p, 9) = (short)Unsafe.Add(ref pupper, 9);
                Unsafe.Add(ref p, 10) = (short)Unsafe.Add(ref pupper, 10);
                Unsafe.Add(ref p, 11) = (short)Unsafe.Add(ref pupper, 11);
                Unsafe.Add(ref p, 12) = (short)Unsafe.Add(ref pupper, 12);
                Unsafe.Add(ref p, 13) = (short)Unsafe.Add(ref pupper, 13);
                Unsafe.Add(ref p, 14) = (short)Unsafe.Add(ref pupper, 14);
                Unsafe.Add(ref p, 15) = (short)Unsafe.Add(ref pupper, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{uint}, Vector512{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Narrow_Basic(Vector512<uint> lower, Vector512<uint> upper) {
                nint cnt = Vector512<uint>.Count;
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
                ref ushort p = ref Unsafe.As<Vector512<ushort>, ushort>(ref rt);
                ref uint plower = ref Unsafe.As<Vector512<uint>, uint>(ref lower);
                ref uint pupper = ref Unsafe.As<Vector512<uint>, uint>(ref upper);
                p = (ushort)plower;
                Unsafe.Add(ref p, 1) = (ushort)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (ushort)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (ushort)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (ushort)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (ushort)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (ushort)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (ushort)Unsafe.Add(ref plower, 7);
                Unsafe.Add(ref p, 8) = (ushort)Unsafe.Add(ref plower, 8);
                Unsafe.Add(ref p, 9) = (ushort)Unsafe.Add(ref plower, 9);
                Unsafe.Add(ref p, 10) = (ushort)Unsafe.Add(ref plower, 10);
                Unsafe.Add(ref p, 11) = (ushort)Unsafe.Add(ref plower, 11);
                Unsafe.Add(ref p, 12) = (ushort)Unsafe.Add(ref plower, 12);
                Unsafe.Add(ref p, 13) = (ushort)Unsafe.Add(ref plower, 13);
                Unsafe.Add(ref p, 14) = (ushort)Unsafe.Add(ref plower, 14);
                Unsafe.Add(ref p, 15) = (ushort)Unsafe.Add(ref plower, 15);
                p = ref Unsafe.Add(ref p, cnt);
                p = (ushort)pupper;
                Unsafe.Add(ref p, 1) = (ushort)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (ushort)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (ushort)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (ushort)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (ushort)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (ushort)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (ushort)Unsafe.Add(ref pupper, 7);
                Unsafe.Add(ref p, 8) = (ushort)Unsafe.Add(ref pupper, 8);
                Unsafe.Add(ref p, 9) = (ushort)Unsafe.Add(ref pupper, 9);
                Unsafe.Add(ref p, 10) = (ushort)Unsafe.Add(ref pupper, 10);
                Unsafe.Add(ref p, 11) = (ushort)Unsafe.Add(ref pupper, 11);
                Unsafe.Add(ref p, 12) = (ushort)Unsafe.Add(ref pupper, 12);
                Unsafe.Add(ref p, 13) = (ushort)Unsafe.Add(ref pupper, 13);
                Unsafe.Add(ref p, 14) = (ushort)Unsafe.Add(ref pupper, 14);
                Unsafe.Add(ref p, 15) = (ushort)Unsafe.Add(ref pupper, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{long}, Vector512{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Narrow_Basic(Vector512<long> lower, Vector512<long> upper) {
                nint cnt = Vector512<long>.Count;
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref int p = ref Unsafe.As<Vector512<int>, int>(ref rt);
                ref long plower = ref Unsafe.As<Vector512<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector512<long>, long>(ref upper);
                p = (int)plower;
                Unsafe.Add(ref p, 1) = (int)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (int)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (int)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (int)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (int)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (int)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (int)Unsafe.Add(ref plower, 7);
                p = ref Unsafe.Add(ref p, cnt);
                p = (int)pupper;
                Unsafe.Add(ref p, 1) = (int)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (int)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (int)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (int)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (int)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (int)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (int)Unsafe.Add(ref pupper, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{ulong}, Vector512{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Narrow_Basic(Vector512<ulong> lower, Vector512<ulong> upper) {
                nint cnt = Vector512<ulong>.Count;
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                ref uint p = ref Unsafe.As<Vector512<uint>, uint>(ref rt);
                ref ulong plower = ref Unsafe.As<Vector512<ulong>, ulong>(ref lower);
                ref ulong pupper = ref Unsafe.As<Vector512<ulong>, ulong>(ref upper);
                p = (uint)plower;
                Unsafe.Add(ref p, 1) = (uint)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (uint)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (uint)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (uint)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (uint)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (uint)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (uint)Unsafe.Add(ref plower, 7);
                p = ref Unsafe.Add(ref p, cnt);
                p = (uint)pupper;
                Unsafe.Add(ref p, 1) = (uint)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (uint)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (uint)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (uint)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (uint)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (uint)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (uint)Unsafe.Add(ref pupper, 7);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft(Vector512<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector512.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft(Vector512<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector512.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft(Vector512<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft(Vector512<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft(Vector512<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft(Vector512<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft(Vector512<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft(Vector512<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft_Basic(Vector512<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft_Basic(Vector512<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Basic(Vector512<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Basic(Vector512<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Basic(Vector512<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Basic(Vector512<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Basic(Vector512<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Basic(Vector512<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{byte}, int, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft_Args(Vector512<byte> dummy, int shiftAmount, out Vector512<byte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{short}, int, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Args(Vector512<ushort> dummy, int shiftAmount, out Vector512<ushort> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{int}, int, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{uint}, int, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Args(Vector512<uint> dummy, int shiftAmount, out Vector512<uint> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{long}, int, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{ulong}, int, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Args(Vector512<ulong> dummy, int shiftAmount, out Vector512<ulong> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft_Core(Vector512<byte> value, int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Core(Vector512<ushort> value, int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Core(Vector512<uint> value, int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Core(Vector512<ulong> value, int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft_Const(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Const(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Const(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Const(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft_ConstCore(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_ConstCore(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_ConstCore(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_ConstCore(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft_Fast(Vector512<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft_Fast(Vector512<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Fast(Vector512<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Fast(Vector512<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Fast(Vector512<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Fast(Vector512<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Fast(Vector512<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Fast(Vector512<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftLeft_Fast_Basic(Vector512<sbyte> value, int shiftAmount) {
                return ShiftLeft_Fast_Basic(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftLeft_Fast_Basic(Vector512<byte> value, int shiftAmount) {
                Vector512<byte> rt = value;
                ref byte p = ref Unsafe.As<Vector512<byte>, byte>(ref rt);
                p <<= shiftAmount;
                Unsafe.Add(ref p, 1) <<= shiftAmount;
                Unsafe.Add(ref p, 2) <<= shiftAmount;
                Unsafe.Add(ref p, 3) <<= shiftAmount;
                Unsafe.Add(ref p, 4) <<= shiftAmount;
                Unsafe.Add(ref p, 5) <<= shiftAmount;
                Unsafe.Add(ref p, 6) <<= shiftAmount;
                Unsafe.Add(ref p, 7) <<= shiftAmount;
                Unsafe.Add(ref p, 8) <<= shiftAmount;
                Unsafe.Add(ref p, 9) <<= shiftAmount;
                Unsafe.Add(ref p, 10) <<= shiftAmount;
                Unsafe.Add(ref p, 11) <<= shiftAmount;
                Unsafe.Add(ref p, 12) <<= shiftAmount;
                Unsafe.Add(ref p, 13) <<= shiftAmount;
                Unsafe.Add(ref p, 14) <<= shiftAmount;
                Unsafe.Add(ref p, 15) <<= shiftAmount;
                Unsafe.Add(ref p, 16) <<= shiftAmount;
                Unsafe.Add(ref p, 17) <<= shiftAmount;
                Unsafe.Add(ref p, 18) <<= shiftAmount;
                Unsafe.Add(ref p, 19) <<= shiftAmount;
                Unsafe.Add(ref p, 20) <<= shiftAmount;
                Unsafe.Add(ref p, 21) <<= shiftAmount;
                Unsafe.Add(ref p, 22) <<= shiftAmount;
                Unsafe.Add(ref p, 23) <<= shiftAmount;
                Unsafe.Add(ref p, 24) <<= shiftAmount;
                Unsafe.Add(ref p, 25) <<= shiftAmount;
                Unsafe.Add(ref p, 26) <<= shiftAmount;
                Unsafe.Add(ref p, 27) <<= shiftAmount;
                Unsafe.Add(ref p, 28) <<= shiftAmount;
                Unsafe.Add(ref p, 29) <<= shiftAmount;
                Unsafe.Add(ref p, 30) <<= shiftAmount;
                Unsafe.Add(ref p, 31) <<= shiftAmount;
                Unsafe.Add(ref p, 32) <<= shiftAmount;
                Unsafe.Add(ref p, 33) <<= shiftAmount;
                Unsafe.Add(ref p, 34) <<= shiftAmount;
                Unsafe.Add(ref p, 35) <<= shiftAmount;
                Unsafe.Add(ref p, 36) <<= shiftAmount;
                Unsafe.Add(ref p, 37) <<= shiftAmount;
                Unsafe.Add(ref p, 38) <<= shiftAmount;
                Unsafe.Add(ref p, 39) <<= shiftAmount;
                Unsafe.Add(ref p, 40) <<= shiftAmount;
                Unsafe.Add(ref p, 41) <<= shiftAmount;
                Unsafe.Add(ref p, 42) <<= shiftAmount;
                Unsafe.Add(ref p, 43) <<= shiftAmount;
                Unsafe.Add(ref p, 44) <<= shiftAmount;
                Unsafe.Add(ref p, 45) <<= shiftAmount;
                Unsafe.Add(ref p, 46) <<= shiftAmount;
                Unsafe.Add(ref p, 47) <<= shiftAmount;
                Unsafe.Add(ref p, 48) <<= shiftAmount;
                Unsafe.Add(ref p, 49) <<= shiftAmount;
                Unsafe.Add(ref p, 50) <<= shiftAmount;
                Unsafe.Add(ref p, 51) <<= shiftAmount;
                Unsafe.Add(ref p, 52) <<= shiftAmount;
                Unsafe.Add(ref p, 53) <<= shiftAmount;
                Unsafe.Add(ref p, 54) <<= shiftAmount;
                Unsafe.Add(ref p, 55) <<= shiftAmount;
                Unsafe.Add(ref p, 56) <<= shiftAmount;
                Unsafe.Add(ref p, 57) <<= shiftAmount;
                Unsafe.Add(ref p, 58) <<= shiftAmount;
                Unsafe.Add(ref p, 59) <<= shiftAmount;
                Unsafe.Add(ref p, 60) <<= shiftAmount;
                Unsafe.Add(ref p, 61) <<= shiftAmount;
                Unsafe.Add(ref p, 62) <<= shiftAmount;
                Unsafe.Add(ref p, 63) <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftLeft_Fast_Basic(Vector512<short> value, int shiftAmount) {
                Vector512<short> rt = value;
                ref short p = ref Unsafe.As<Vector512<short>, short>(ref rt);
                p <<= shiftAmount;
                Unsafe.Add(ref p, 1) <<= shiftAmount;
                Unsafe.Add(ref p, 2) <<= shiftAmount;
                Unsafe.Add(ref p, 3) <<= shiftAmount;
                Unsafe.Add(ref p, 4) <<= shiftAmount;
                Unsafe.Add(ref p, 5) <<= shiftAmount;
                Unsafe.Add(ref p, 6) <<= shiftAmount;
                Unsafe.Add(ref p, 7) <<= shiftAmount;
                Unsafe.Add(ref p, 8) <<= shiftAmount;
                Unsafe.Add(ref p, 9) <<= shiftAmount;
                Unsafe.Add(ref p, 10) <<= shiftAmount;
                Unsafe.Add(ref p, 11) <<= shiftAmount;
                Unsafe.Add(ref p, 12) <<= shiftAmount;
                Unsafe.Add(ref p, 13) <<= shiftAmount;
                Unsafe.Add(ref p, 14) <<= shiftAmount;
                Unsafe.Add(ref p, 15) <<= shiftAmount;
                Unsafe.Add(ref p, 16) <<= shiftAmount;
                Unsafe.Add(ref p, 17) <<= shiftAmount;
                Unsafe.Add(ref p, 18) <<= shiftAmount;
                Unsafe.Add(ref p, 19) <<= shiftAmount;
                Unsafe.Add(ref p, 20) <<= shiftAmount;
                Unsafe.Add(ref p, 21) <<= shiftAmount;
                Unsafe.Add(ref p, 22) <<= shiftAmount;
                Unsafe.Add(ref p, 23) <<= shiftAmount;
                Unsafe.Add(ref p, 24) <<= shiftAmount;
                Unsafe.Add(ref p, 25) <<= shiftAmount;
                Unsafe.Add(ref p, 26) <<= shiftAmount;
                Unsafe.Add(ref p, 27) <<= shiftAmount;
                Unsafe.Add(ref p, 28) <<= shiftAmount;
                Unsafe.Add(ref p, 29) <<= shiftAmount;
                Unsafe.Add(ref p, 30) <<= shiftAmount;
                Unsafe.Add(ref p, 31) <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftLeft_Fast_Basic(Vector512<ushort> value, int shiftAmount) {
                return ShiftLeft_Fast_Basic(value.AsInt16(), shiftAmount).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftLeft_Fast_Basic(Vector512<int> value, int shiftAmount) {
                Vector512<int> rt = value;
                ref int p = ref Unsafe.As<Vector512<int>, int>(ref rt);
                p <<= shiftAmount;
                Unsafe.Add(ref p, 1) <<= shiftAmount;
                Unsafe.Add(ref p, 2) <<= shiftAmount;
                Unsafe.Add(ref p, 3) <<= shiftAmount;
                Unsafe.Add(ref p, 4) <<= shiftAmount;
                Unsafe.Add(ref p, 5) <<= shiftAmount;
                Unsafe.Add(ref p, 6) <<= shiftAmount;
                Unsafe.Add(ref p, 7) <<= shiftAmount;
                Unsafe.Add(ref p, 8) <<= shiftAmount;
                Unsafe.Add(ref p, 9) <<= shiftAmount;
                Unsafe.Add(ref p, 10) <<= shiftAmount;
                Unsafe.Add(ref p, 11) <<= shiftAmount;
                Unsafe.Add(ref p, 12) <<= shiftAmount;
                Unsafe.Add(ref p, 13) <<= shiftAmount;
                Unsafe.Add(ref p, 14) <<= shiftAmount;
                Unsafe.Add(ref p, 15) <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftLeft_Fast_Basic(Vector512<uint> value, int shiftAmount) {
                return ShiftLeft_Fast_Basic(value.AsInt32(), shiftAmount).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftLeft_Fast_Basic(Vector512<long> value, int shiftAmount) {
                Vector512<long> rt = value;
                ref long p = ref Unsafe.As<Vector512<long>, long>(ref rt);
                p <<= shiftAmount;
                Unsafe.Add(ref p, 1) <<= shiftAmount;
                Unsafe.Add(ref p, 2) <<= shiftAmount;
                Unsafe.Add(ref p, 3) <<= shiftAmount;
                Unsafe.Add(ref p, 4) <<= shiftAmount;
                Unsafe.Add(ref p, 5) <<= shiftAmount;
                Unsafe.Add(ref p, 6) <<= shiftAmount;
                Unsafe.Add(ref p, 7) <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftLeft_Fast_Basic(Vector512<ulong> value, int shiftAmount) {
                return ShiftLeft_Fast_Basic(value.AsInt64(), shiftAmount).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic(Vector512<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic(Vector512<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic(Vector512<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic(Vector512<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Basic(Vector512<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_Basic(Vector512<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Basic(Vector512<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Basic(Vector512<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{short}, int, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{int}, int, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{long}, int, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic(value, shiftAmount);
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
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
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
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Fast(Vector512<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_Fast(Vector512<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Fast(Vector512<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Fast(Vector512<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightArithmetic_Fast_Basic(Vector512<sbyte> value, int shiftAmount) {
                Vector512<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                Unsafe.Add(ref p, 4) >>= shiftAmount;
                Unsafe.Add(ref p, 5) >>= shiftAmount;
                Unsafe.Add(ref p, 6) >>= shiftAmount;
                Unsafe.Add(ref p, 7) >>= shiftAmount;
                Unsafe.Add(ref p, 8) >>= shiftAmount;
                Unsafe.Add(ref p, 9) >>= shiftAmount;
                Unsafe.Add(ref p, 10) >>= shiftAmount;
                Unsafe.Add(ref p, 11) >>= shiftAmount;
                Unsafe.Add(ref p, 12) >>= shiftAmount;
                Unsafe.Add(ref p, 13) >>= shiftAmount;
                Unsafe.Add(ref p, 14) >>= shiftAmount;
                Unsafe.Add(ref p, 15) >>= shiftAmount;
                Unsafe.Add(ref p, 16) >>= shiftAmount;
                Unsafe.Add(ref p, 17) >>= shiftAmount;
                Unsafe.Add(ref p, 18) >>= shiftAmount;
                Unsafe.Add(ref p, 19) >>= shiftAmount;
                Unsafe.Add(ref p, 20) >>= shiftAmount;
                Unsafe.Add(ref p, 21) >>= shiftAmount;
                Unsafe.Add(ref p, 22) >>= shiftAmount;
                Unsafe.Add(ref p, 23) >>= shiftAmount;
                Unsafe.Add(ref p, 24) >>= shiftAmount;
                Unsafe.Add(ref p, 25) >>= shiftAmount;
                Unsafe.Add(ref p, 26) >>= shiftAmount;
                Unsafe.Add(ref p, 27) >>= shiftAmount;
                Unsafe.Add(ref p, 28) >>= shiftAmount;
                Unsafe.Add(ref p, 29) >>= shiftAmount;
                Unsafe.Add(ref p, 30) >>= shiftAmount;
                Unsafe.Add(ref p, 31) >>= shiftAmount;
                Unsafe.Add(ref p, 32) >>= shiftAmount;
                Unsafe.Add(ref p, 33) >>= shiftAmount;
                Unsafe.Add(ref p, 34) >>= shiftAmount;
                Unsafe.Add(ref p, 35) >>= shiftAmount;
                Unsafe.Add(ref p, 36) >>= shiftAmount;
                Unsafe.Add(ref p, 37) >>= shiftAmount;
                Unsafe.Add(ref p, 38) >>= shiftAmount;
                Unsafe.Add(ref p, 39) >>= shiftAmount;
                Unsafe.Add(ref p, 40) >>= shiftAmount;
                Unsafe.Add(ref p, 41) >>= shiftAmount;
                Unsafe.Add(ref p, 42) >>= shiftAmount;
                Unsafe.Add(ref p, 43) >>= shiftAmount;
                Unsafe.Add(ref p, 44) >>= shiftAmount;
                Unsafe.Add(ref p, 45) >>= shiftAmount;
                Unsafe.Add(ref p, 46) >>= shiftAmount;
                Unsafe.Add(ref p, 47) >>= shiftAmount;
                Unsafe.Add(ref p, 48) >>= shiftAmount;
                Unsafe.Add(ref p, 49) >>= shiftAmount;
                Unsafe.Add(ref p, 50) >>= shiftAmount;
                Unsafe.Add(ref p, 51) >>= shiftAmount;
                Unsafe.Add(ref p, 52) >>= shiftAmount;
                Unsafe.Add(ref p, 53) >>= shiftAmount;
                Unsafe.Add(ref p, 54) >>= shiftAmount;
                Unsafe.Add(ref p, 55) >>= shiftAmount;
                Unsafe.Add(ref p, 56) >>= shiftAmount;
                Unsafe.Add(ref p, 57) >>= shiftAmount;
                Unsafe.Add(ref p, 58) >>= shiftAmount;
                Unsafe.Add(ref p, 59) >>= shiftAmount;
                Unsafe.Add(ref p, 60) >>= shiftAmount;
                Unsafe.Add(ref p, 61) >>= shiftAmount;
                Unsafe.Add(ref p, 62) >>= shiftAmount;
                Unsafe.Add(ref p, 63) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightArithmetic_Fast_Basic(Vector512<short> value, int shiftAmount) {
                Vector512<short> rt = value;
                ref short p = ref Unsafe.As<Vector512<short>, short>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                Unsafe.Add(ref p, 4) >>= shiftAmount;
                Unsafe.Add(ref p, 5) >>= shiftAmount;
                Unsafe.Add(ref p, 6) >>= shiftAmount;
                Unsafe.Add(ref p, 7) >>= shiftAmount;
                Unsafe.Add(ref p, 8) >>= shiftAmount;
                Unsafe.Add(ref p, 9) >>= shiftAmount;
                Unsafe.Add(ref p, 10) >>= shiftAmount;
                Unsafe.Add(ref p, 11) >>= shiftAmount;
                Unsafe.Add(ref p, 12) >>= shiftAmount;
                Unsafe.Add(ref p, 13) >>= shiftAmount;
                Unsafe.Add(ref p, 14) >>= shiftAmount;
                Unsafe.Add(ref p, 15) >>= shiftAmount;
                Unsafe.Add(ref p, 16) >>= shiftAmount;
                Unsafe.Add(ref p, 17) >>= shiftAmount;
                Unsafe.Add(ref p, 18) >>= shiftAmount;
                Unsafe.Add(ref p, 19) >>= shiftAmount;
                Unsafe.Add(ref p, 20) >>= shiftAmount;
                Unsafe.Add(ref p, 21) >>= shiftAmount;
                Unsafe.Add(ref p, 22) >>= shiftAmount;
                Unsafe.Add(ref p, 23) >>= shiftAmount;
                Unsafe.Add(ref p, 24) >>= shiftAmount;
                Unsafe.Add(ref p, 25) >>= shiftAmount;
                Unsafe.Add(ref p, 26) >>= shiftAmount;
                Unsafe.Add(ref p, 27) >>= shiftAmount;
                Unsafe.Add(ref p, 28) >>= shiftAmount;
                Unsafe.Add(ref p, 29) >>= shiftAmount;
                Unsafe.Add(ref p, 30) >>= shiftAmount;
                Unsafe.Add(ref p, 31) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightArithmetic_Fast_Basic(Vector512<int> value, int shiftAmount) {
                Vector512<int> rt = value;
                ref int p = ref Unsafe.As<Vector512<int>, int>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                Unsafe.Add(ref p, 4) >>= shiftAmount;
                Unsafe.Add(ref p, 5) >>= shiftAmount;
                Unsafe.Add(ref p, 6) >>= shiftAmount;
                Unsafe.Add(ref p, 7) >>= shiftAmount;
                Unsafe.Add(ref p, 8) >>= shiftAmount;
                Unsafe.Add(ref p, 9) >>= shiftAmount;
                Unsafe.Add(ref p, 10) >>= shiftAmount;
                Unsafe.Add(ref p, 11) >>= shiftAmount;
                Unsafe.Add(ref p, 12) >>= shiftAmount;
                Unsafe.Add(ref p, 13) >>= shiftAmount;
                Unsafe.Add(ref p, 14) >>= shiftAmount;
                Unsafe.Add(ref p, 15) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightArithmetic_Fast_Basic(Vector512<long> value, int shiftAmount) {
                Vector512<long> rt = value;
                ref long p = ref Unsafe.As<Vector512<long>, long>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                Unsafe.Add(ref p, 4) >>= shiftAmount;
                Unsafe.Add(ref p, 5) >>= shiftAmount;
                Unsafe.Add(ref p, 6) >>= shiftAmount;
                Unsafe.Add(ref p, 7) >>= shiftAmount;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical(Vector512<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical(Vector512<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical(Vector512<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical(Vector512<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical(Vector512<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical(Vector512<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical(Vector512<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical(Vector512<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical_Basic(Vector512<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Basic(Vector512<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Basic(Vector512<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Basic(Vector512<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Basic(Vector512<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Basic(Vector512<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Basic(Vector512<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Basic(Vector512<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{byte}, int, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Args(Vector512<byte> dummy, int shiftAmount, out Vector512<byte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{short}, int, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Args(Vector512<ushort> dummy, int shiftAmount, out Vector512<ushort> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{int}, int, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{uint}, int, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Args(Vector512<uint> dummy, int shiftAmount, out Vector512<uint> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{long}, int, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{ulong}, int, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Args(Vector512<ulong> dummy, int shiftAmount, out Vector512<ulong> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Core(Vector512<byte> value, int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Core(Vector512<ushort> value, int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Core(Vector512<uint> value, int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Core(Vector512<ulong> value, int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Const(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Const(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Const(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Const(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_ConstCore(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_ConstCore(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_ConstCore(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_ConstCore(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical_Fast(Vector512<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector512.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Fast(Vector512<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector512.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Fast(Vector512<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Fast(Vector512<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Fast(Vector512<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Fast(Vector512<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Fast(Vector512<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Fast(Vector512<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Basic(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> ShiftRightLogical_Fast_Basic(Vector512<sbyte> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Basic(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> ShiftRightLogical_Fast_Basic(Vector512<byte> value, int shiftAmount) {
                Vector512<byte> rt = value;
                ref byte p = ref Unsafe.As<Vector512<byte>, byte>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                Unsafe.Add(ref p, 4) >>= shiftAmount;
                Unsafe.Add(ref p, 5) >>= shiftAmount;
                Unsafe.Add(ref p, 6) >>= shiftAmount;
                Unsafe.Add(ref p, 7) >>= shiftAmount;
                Unsafe.Add(ref p, 8) >>= shiftAmount;
                Unsafe.Add(ref p, 9) >>= shiftAmount;
                Unsafe.Add(ref p, 10) >>= shiftAmount;
                Unsafe.Add(ref p, 11) >>= shiftAmount;
                Unsafe.Add(ref p, 12) >>= shiftAmount;
                Unsafe.Add(ref p, 13) >>= shiftAmount;
                Unsafe.Add(ref p, 14) >>= shiftAmount;
                Unsafe.Add(ref p, 15) >>= shiftAmount;
                Unsafe.Add(ref p, 16) >>= shiftAmount;
                Unsafe.Add(ref p, 17) >>= shiftAmount;
                Unsafe.Add(ref p, 18) >>= shiftAmount;
                Unsafe.Add(ref p, 19) >>= shiftAmount;
                Unsafe.Add(ref p, 20) >>= shiftAmount;
                Unsafe.Add(ref p, 21) >>= shiftAmount;
                Unsafe.Add(ref p, 22) >>= shiftAmount;
                Unsafe.Add(ref p, 23) >>= shiftAmount;
                Unsafe.Add(ref p, 24) >>= shiftAmount;
                Unsafe.Add(ref p, 25) >>= shiftAmount;
                Unsafe.Add(ref p, 26) >>= shiftAmount;
                Unsafe.Add(ref p, 27) >>= shiftAmount;
                Unsafe.Add(ref p, 28) >>= shiftAmount;
                Unsafe.Add(ref p, 29) >>= shiftAmount;
                Unsafe.Add(ref p, 30) >>= shiftAmount;
                Unsafe.Add(ref p, 31) >>= shiftAmount;
                Unsafe.Add(ref p, 32) >>= shiftAmount;
                Unsafe.Add(ref p, 33) >>= shiftAmount;
                Unsafe.Add(ref p, 34) >>= shiftAmount;
                Unsafe.Add(ref p, 35) >>= shiftAmount;
                Unsafe.Add(ref p, 36) >>= shiftAmount;
                Unsafe.Add(ref p, 37) >>= shiftAmount;
                Unsafe.Add(ref p, 38) >>= shiftAmount;
                Unsafe.Add(ref p, 39) >>= shiftAmount;
                Unsafe.Add(ref p, 40) >>= shiftAmount;
                Unsafe.Add(ref p, 41) >>= shiftAmount;
                Unsafe.Add(ref p, 42) >>= shiftAmount;
                Unsafe.Add(ref p, 43) >>= shiftAmount;
                Unsafe.Add(ref p, 44) >>= shiftAmount;
                Unsafe.Add(ref p, 45) >>= shiftAmount;
                Unsafe.Add(ref p, 46) >>= shiftAmount;
                Unsafe.Add(ref p, 47) >>= shiftAmount;
                Unsafe.Add(ref p, 48) >>= shiftAmount;
                Unsafe.Add(ref p, 49) >>= shiftAmount;
                Unsafe.Add(ref p, 50) >>= shiftAmount;
                Unsafe.Add(ref p, 51) >>= shiftAmount;
                Unsafe.Add(ref p, 52) >>= shiftAmount;
                Unsafe.Add(ref p, 53) >>= shiftAmount;
                Unsafe.Add(ref p, 54) >>= shiftAmount;
                Unsafe.Add(ref p, 55) >>= shiftAmount;
                Unsafe.Add(ref p, 56) >>= shiftAmount;
                Unsafe.Add(ref p, 57) >>= shiftAmount;
                Unsafe.Add(ref p, 58) >>= shiftAmount;
                Unsafe.Add(ref p, 59) >>= shiftAmount;
                Unsafe.Add(ref p, 60) >>= shiftAmount;
                Unsafe.Add(ref p, 61) >>= shiftAmount;
                Unsafe.Add(ref p, 62) >>= shiftAmount;
                Unsafe.Add(ref p, 63) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> ShiftRightLogical_Fast_Basic(Vector512<short> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Basic(value.AsUInt16(), shiftAmount).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> ShiftRightLogical_Fast_Basic(Vector512<ushort> value, int shiftAmount) {
                Vector512<ushort> rt = value;
                ref ushort p = ref Unsafe.As<Vector512<ushort>, ushort>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                Unsafe.Add(ref p, 4) >>= shiftAmount;
                Unsafe.Add(ref p, 5) >>= shiftAmount;
                Unsafe.Add(ref p, 6) >>= shiftAmount;
                Unsafe.Add(ref p, 7) >>= shiftAmount;
                Unsafe.Add(ref p, 8) >>= shiftAmount;
                Unsafe.Add(ref p, 9) >>= shiftAmount;
                Unsafe.Add(ref p, 10) >>= shiftAmount;
                Unsafe.Add(ref p, 11) >>= shiftAmount;
                Unsafe.Add(ref p, 12) >>= shiftAmount;
                Unsafe.Add(ref p, 13) >>= shiftAmount;
                Unsafe.Add(ref p, 14) >>= shiftAmount;
                Unsafe.Add(ref p, 15) >>= shiftAmount;
                Unsafe.Add(ref p, 16) >>= shiftAmount;
                Unsafe.Add(ref p, 17) >>= shiftAmount;
                Unsafe.Add(ref p, 18) >>= shiftAmount;
                Unsafe.Add(ref p, 19) >>= shiftAmount;
                Unsafe.Add(ref p, 20) >>= shiftAmount;
                Unsafe.Add(ref p, 21) >>= shiftAmount;
                Unsafe.Add(ref p, 22) >>= shiftAmount;
                Unsafe.Add(ref p, 23) >>= shiftAmount;
                Unsafe.Add(ref p, 24) >>= shiftAmount;
                Unsafe.Add(ref p, 25) >>= shiftAmount;
                Unsafe.Add(ref p, 26) >>= shiftAmount;
                Unsafe.Add(ref p, 27) >>= shiftAmount;
                Unsafe.Add(ref p, 28) >>= shiftAmount;
                Unsafe.Add(ref p, 29) >>= shiftAmount;
                Unsafe.Add(ref p, 30) >>= shiftAmount;
                Unsafe.Add(ref p, 31) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> ShiftRightLogical_Fast_Basic(Vector512<int> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Basic(value.AsUInt32(), shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> ShiftRightLogical_Fast_Basic(Vector512<uint> value, int shiftAmount) {
                Vector512<uint> rt = value;
                ref uint p = ref Unsafe.As<Vector512<uint>, uint>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                Unsafe.Add(ref p, 4) >>= shiftAmount;
                Unsafe.Add(ref p, 5) >>= shiftAmount;
                Unsafe.Add(ref p, 6) >>= shiftAmount;
                Unsafe.Add(ref p, 7) >>= shiftAmount;
                Unsafe.Add(ref p, 8) >>= shiftAmount;
                Unsafe.Add(ref p, 9) >>= shiftAmount;
                Unsafe.Add(ref p, 10) >>= shiftAmount;
                Unsafe.Add(ref p, 11) >>= shiftAmount;
                Unsafe.Add(ref p, 12) >>= shiftAmount;
                Unsafe.Add(ref p, 13) >>= shiftAmount;
                Unsafe.Add(ref p, 14) >>= shiftAmount;
                Unsafe.Add(ref p, 15) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> ShiftRightLogical_Fast_Basic(Vector512<long> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Basic(value.AsUInt64(), shiftAmount).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> ShiftRightLogical_Fast_Basic(Vector512<ulong> value, int shiftAmount) {
                Vector512<ulong> rt = value;
                ref ulong p = ref Unsafe.As<Vector512<ulong>, ulong>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                Unsafe.Add(ref p, 4) >>= shiftAmount;
                Unsafe.Add(ref p, 5) >>= shiftAmount;
                Unsafe.Add(ref p, 6) >>= shiftAmount;
                Unsafe.Add(ref p, 7) >>= shiftAmount;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
            public static TypeCodeFlags Shuffle_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.None; // `.NET 7.0` doesn't have hardware acceleration yet .
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Shuffle(Vector512<float> vector, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Shuffle(Vector512<double> vector, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Shuffle(Vector512<sbyte> vector, Vector512<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Shuffle(Vector512<byte> vector, Vector512<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Shuffle(vector, indices);
                // .NET8: No hardware accelerated.
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Shuffle(Vector512<short> vector, Vector512<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Shuffle(Vector512<ushort> vector, Vector512<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Shuffle(Vector512<int> vector, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Shuffle(Vector512<uint> vector, Vector512<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Shuffle(Vector512<long> vector, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Shuffle(Vector512<ulong> vector, Vector512<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Shuffle(vector, indices);
#else
                return Shuffle_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Shuffle_Basic(Vector512<float> vector, Vector512<int> indices) {
                return Shuffle_Basic(vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Shuffle_Basic(Vector512<double> vector, Vector512<long> indices) {
                return Shuffle_Basic(vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Shuffle_Basic(Vector512<sbyte> vector, Vector512<sbyte> indices) {
                return Shuffle_Basic(vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Shuffle_Basic(Vector512<byte> vector, Vector512<byte> indices) {
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
                byte cnt = (byte)Vector512<byte>.Count;
                ref byte q = ref Unsafe.As<Vector512<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector512<byte>, byte>(ref vector);
                ref byte pindices = ref Unsafe.As<Vector512<byte>, byte>(ref indices);
                for (nint i = 0; i < Vector512<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Shuffle_Basic(Vector512<short> vector, Vector512<short> indices) {
                return Shuffle_Basic(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Shuffle_Basic(Vector512<ushort> vector, Vector512<ushort> indices) {
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
                ushort cnt = (ushort)Vector512<ushort>.Count;
                ref ushort q = ref Unsafe.As<Vector512<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector512<ushort>, ushort>(ref vector);
                ref ushort pindices = ref Unsafe.As<Vector512<ushort>, ushort>(ref indices);
                for (nint i = 0; i < Vector512<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Shuffle_Basic(Vector512<int> vector, Vector512<int> indices) {
                return Shuffle_Basic(vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Shuffle_Basic(Vector512<uint> vector, Vector512<uint> indices) {
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                uint cnt = (uint)Vector512<uint>.Count;
                ref uint q = ref Unsafe.As<Vector512<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector512<uint>, uint>(ref vector);
                ref uint pindices = ref Unsafe.As<Vector512<uint>, uint>(ref indices);
                for (nint i = 0; i < Vector512<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Shuffle_Basic(Vector512<long> vector, Vector512<long> indices) {
                return Shuffle_Basic(vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Shuffle_Basic(Vector512<ulong> vector, Vector512<ulong> indices) {
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
                ulong cnt = (ulong)Vector512<ulong>.Count;
                ref ulong q = ref Unsafe.As<Vector512<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector512<ulong>, ulong>(ref vector);
                ref ulong pindices = ref Unsafe.As<Vector512<ulong>, ulong>(ref indices);
                for (nint i = 0; i < Vector512<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1) {
                args0 = indices;
                args1 = default;
            }


            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{float}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Shuffle_Core(Vector512<float> vector, Vector512<int> args0, Vector512<int> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{double}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Shuffle_Core(Vector512<double> vector, Vector512<long> args0, Vector512<long> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Shuffle_Core(Vector512<sbyte> vector, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Shuffle_Core(Vector512<byte> vector, Vector512<byte> args0, Vector512<byte> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Shuffle_Core(Vector512<short> vector, Vector512<short> args0, Vector512<short> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Shuffle_Core(Vector512<ushort> vector, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Shuffle_Core(Vector512<int> vector, Vector512<int> args0, Vector512<int> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Shuffle_Core(Vector512<uint> vector, Vector512<uint> args0, Vector512<uint> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Shuffle_Core(Vector512<long> vector, Vector512<long> args0, Vector512<long> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Shuffle_Core(Vector512<ulong> vector, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }


            /// <inheritdoc cref="IWVectorTraits512.Sum_AcceleratedTypes"/>
            public static TypeCodeFlags Sum_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum(Vector512<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Sum(value);
                // .NET8 on Avx512: Poor performance!
                //  1545: 		T left = Vector256.Sum(vector._lower);
                //00007FFDAB70F264  vmovups     ymm0,ymmword ptr [rbp-30h]  
                //00007FFDAB70F269  vhaddps     ymm0,ymm0,ymmword ptr [rbp-30h]  
                //00007FFDAB70F26E  vmovups     ymmword ptr [rbp-50h],ymm0  
                //00007FFDAB70F273  vmovups     ymm0,ymmword ptr [rbp-50h]  
                //00007FFDAB70F278  vhaddps     ymm0,ymm0,ymmword ptr [rbp-50h]  
                //00007FFDAB70F27D  vmovups     ymmword ptr [rbp-70h],ymm0  
                //00007FFDAB70F282  vmovups     ymm0,ymmword ptr [rbp-70h]  
                //00007FFDAB70F287  vextractf128 xmm0,ymm0,1  
                //00007FFDAB70F28D  vmovups     xmm1,xmmword ptr [rbp-70h]  
                //00007FFDAB70F292  vaddps      xmm0,xmm0,xmm1  
                //00007FFDAB70F296  vmovss      dword ptr [rbp-4],xmm0  
                //  1546: 		return Scalar<T>.Add(left, Vector256.Sum(vector._upper));
                //00007FFDAB70F29B  vmovss      xmm0,dword ptr [rbp-4]  
                //00007FFDAB70F2A0  vmovss      dword ptr [rbp-0D4h],xmm0  
                //00007FFDAB70F2A8  mov         rax,qword ptr [rbp+10h]  
                //00007FFDAB70F2AC  vmovups     ymm0,ymmword ptr [rax+20h]  
                //00007FFDAB70F2B1  vmovups     ymmword ptr [rbp-90h],ymm0  
                //00007FFDAB70F2B9  vmovups     ymm0,ymmword ptr [rbp-90h]  
                //00007FFDAB70F2C1  vhaddps     ymm0,ymm0,ymmword ptr [rbp-90h]  
                //00007FFDAB70F2C9  vmovups     ymmword ptr [rbp-0B0h],ymm0  
                //00007FFDAB70F2D1  vmovups     ymm0,ymmword ptr [rbp-0B0h]  
                //00007FFDAB70F2D9  vhaddps     ymm0,ymm0,ymmword ptr [rbp-0B0h]  
                //00007FFDAB70F2E1  vmovups     ymmword ptr [rbp-0D0h],ymm0  
                //00007FFDAB70F2E9  vmovups     ymm0,ymmword ptr [rbp-0D0h]  
                //00007FFDAB70F2F1  vextractf128 xmm0,ymm0,1  
                //00007FFDAB70F2F7  vmovups     xmm1,xmmword ptr [rbp-0D0h]  
                //00007FFDAB70F2FF  vaddps      xmm0,xmm0,xmm1  
                //00007FFDAB70F303  vmovss      dword ptr [rbp-0D8h],xmm0  
                //00007FFDAB70F30B  vmovss      xmm0,dword ptr [rbp-0D4h]  
                //00007FFDAB70F313  vmovss      xmm1,dword ptr [rbp-0D8h]  
                //00007FFDAB70F31B  call        qword ptr [CLRStub[MethodDescPrestub]@00007FFDAB7FCBE8 (07FFDAB7FCBE8h)]  
                //00007FFDAB70F321  vmovss      dword ptr [rbp-4],xmm0  
                //00007FFDAB70F326  vmovss      xmm0,dword ptr [rbp-4]  
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum(Vector512<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Sum(value);
                // .NET8 on Avx512: Poor performance!
                //  1545: 		T left = Vector256.Sum(vector._lower);
                //00007FFDAB711F34  vmovups     ymm0,ymmword ptr [rbp-30h]  
                //00007FFDAB711F39  vhaddpd     ymm0,ymm0,ymmword ptr [rbp-30h]  
                //00007FFDAB711F3E  vmovups     ymmword ptr [rbp-50h],ymm0  
                //00007FFDAB711F43  vmovups     ymm0,ymmword ptr [rbp-50h]  
                //00007FFDAB711F48  vextractf128 xmm0,ymm0,1  
                //00007FFDAB711F4E  vmovupd     xmm1,xmmword ptr [rbp-50h]  
                //00007FFDAB711F53  vaddpd      xmm0,xmm0,xmm1  
                //00007FFDAB711F57  vmovsd      qword ptr [rbp-8],xmm0  
                //  1546: 		return Scalar<T>.Add(left, Vector256.Sum(vector._upper));
                //00007FFDAB711F5C  vmovsd      xmm0,qword ptr [rbp-8]  
                //00007FFDAB711F61  vmovsd      qword ptr [rbp-98h],xmm0  
                //00007FFDAB711F69  mov         rax,qword ptr [rbp+10h]  
                //00007FFDAB711F6D  vmovups     ymm0,ymmword ptr [rax+20h]  
                //00007FFDAB711F72  vmovups     ymmword ptr [rbp-70h],ymm0  
                //00007FFDAB711F77  vmovups     ymm0,ymmword ptr [rbp-70h]  
                //00007FFDAB711F7C  vhaddpd     ymm0,ymm0,ymmword ptr [rbp-70h]  
                //00007FFDAB711F81  vmovups     ymmword ptr [rbp-90h],ymm0  
                //00007FFDAB711F89  vmovups     ymm0,ymmword ptr [rbp-90h]  
                //00007FFDAB711F91  vextractf128 xmm0,ymm0,1  
                //00007FFDAB711F97  vmovupd     xmm1,xmmword ptr [rbp-90h]  
                //00007FFDAB711F9F  vaddpd      xmm0,xmm0,xmm1  
                //00007FFDAB711FA3  vmovsd      qword ptr [rbp-0A0h],xmm0  
                //00007FFDAB711FAB  vmovsd      xmm0,qword ptr [rbp-98h]  
                //00007FFDAB711FB3  vmovsd      xmm1,qword ptr [rbp-0A0h]  
                //00007FFDAB711FBB  call        qword ptr [CLRStub[MethodDescPrestub]@00007FFDAB7FCDC8 (07FFDAB7FCDC8h)]  
                //00007FFDAB711FC1  vmovsd      qword ptr [rbp-8],xmm0  
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum(Vector512<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Sum(value);
                // .NET8 on Avx512: Poor performance!
                //1545: 		T left = Vector256.Sum(vector._lower);
                //1546: 		return Scalar<T>.Add(left, Vector256.Sum(vector._upper));
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum(Vector512<byte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum(Vector512<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum(Vector512<ushort> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum(Vector512<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum(Vector512<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum(Vector512<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum(Vector512<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Sum(value);
#else
                return Sum_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum_Basic(Vector512<float> value) {
                ref float p = ref Unsafe.As<Vector512<float>, float>(ref value);
                float rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                    + Unsafe.Add(ref p, 8)
                    + Unsafe.Add(ref p, 9)
                    + Unsafe.Add(ref p, 10)
                    + Unsafe.Add(ref p, 11)
                    + Unsafe.Add(ref p, 12)
                    + Unsafe.Add(ref p, 13)
                    + Unsafe.Add(ref p, 14)
                    + Unsafe.Add(ref p, 15)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum_Basic(Vector512<double> value) {
                ref double p = ref Unsafe.As<Vector512<double>, double>(ref value);
                double rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum_Basic(Vector512<sbyte> value) {
                ref sbyte p = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref value);
                sbyte rt = (sbyte)(p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                    + Unsafe.Add(ref p, 8)
                    + Unsafe.Add(ref p, 9)
                    + Unsafe.Add(ref p, 10)
                    + Unsafe.Add(ref p, 11)
                    + Unsafe.Add(ref p, 12)
                    + Unsafe.Add(ref p, 13)
                    + Unsafe.Add(ref p, 14)
                    + Unsafe.Add(ref p, 15)
                    + Unsafe.Add(ref p, 16)
                    + Unsafe.Add(ref p, 17)
                    + Unsafe.Add(ref p, 18)
                    + Unsafe.Add(ref p, 19)
                    + Unsafe.Add(ref p, 20)
                    + Unsafe.Add(ref p, 21)
                    + Unsafe.Add(ref p, 22)
                    + Unsafe.Add(ref p, 23)
                    + Unsafe.Add(ref p, 24)
                    + Unsafe.Add(ref p, 25)
                    + Unsafe.Add(ref p, 26)
                    + Unsafe.Add(ref p, 27)
                    + Unsafe.Add(ref p, 28)
                    + Unsafe.Add(ref p, 29)
                    + Unsafe.Add(ref p, 30)
                    + Unsafe.Add(ref p, 31)
                    + Unsafe.Add(ref p, 32)
                    + Unsafe.Add(ref p, 33)
                    + Unsafe.Add(ref p, 34)
                    + Unsafe.Add(ref p, 35)
                    + Unsafe.Add(ref p, 36)
                    + Unsafe.Add(ref p, 37)
                    + Unsafe.Add(ref p, 38)
                    + Unsafe.Add(ref p, 39)
                    + Unsafe.Add(ref p, 40)
                    + Unsafe.Add(ref p, 41)
                    + Unsafe.Add(ref p, 42)
                    + Unsafe.Add(ref p, 43)
                    + Unsafe.Add(ref p, 44)
                    + Unsafe.Add(ref p, 45)
                    + Unsafe.Add(ref p, 46)
                    + Unsafe.Add(ref p, 47)
                    + Unsafe.Add(ref p, 48)
                    + Unsafe.Add(ref p, 49)
                    + Unsafe.Add(ref p, 50)
                    + Unsafe.Add(ref p, 51)
                    + Unsafe.Add(ref p, 52)
                    + Unsafe.Add(ref p, 53)
                    + Unsafe.Add(ref p, 54)
                    + Unsafe.Add(ref p, 55)
                    + Unsafe.Add(ref p, 56)
                    + Unsafe.Add(ref p, 57)
                    + Unsafe.Add(ref p, 58)
                    + Unsafe.Add(ref p, 59)
                    + Unsafe.Add(ref p, 60)
                    + Unsafe.Add(ref p, 61)
                    + Unsafe.Add(ref p, 62)
                    + Unsafe.Add(ref p, 63)
                );
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum_Basic(Vector512<byte> value) {
                ref byte p = ref Unsafe.As<Vector512<byte>, byte>(ref value);
                byte rt = (byte)(p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                    + Unsafe.Add(ref p, 8)
                    + Unsafe.Add(ref p, 9)
                    + Unsafe.Add(ref p, 10)
                    + Unsafe.Add(ref p, 11)
                    + Unsafe.Add(ref p, 12)
                    + Unsafe.Add(ref p, 13)
                    + Unsafe.Add(ref p, 14)
                    + Unsafe.Add(ref p, 15)
                    + Unsafe.Add(ref p, 16)
                    + Unsafe.Add(ref p, 17)
                    + Unsafe.Add(ref p, 18)
                    + Unsafe.Add(ref p, 19)
                    + Unsafe.Add(ref p, 20)
                    + Unsafe.Add(ref p, 21)
                    + Unsafe.Add(ref p, 22)
                    + Unsafe.Add(ref p, 23)
                    + Unsafe.Add(ref p, 24)
                    + Unsafe.Add(ref p, 25)
                    + Unsafe.Add(ref p, 26)
                    + Unsafe.Add(ref p, 27)
                    + Unsafe.Add(ref p, 28)
                    + Unsafe.Add(ref p, 29)
                    + Unsafe.Add(ref p, 30)
                    + Unsafe.Add(ref p, 31)
                    + Unsafe.Add(ref p, 32)
                    + Unsafe.Add(ref p, 33)
                    + Unsafe.Add(ref p, 34)
                    + Unsafe.Add(ref p, 35)
                    + Unsafe.Add(ref p, 36)
                    + Unsafe.Add(ref p, 37)
                    + Unsafe.Add(ref p, 38)
                    + Unsafe.Add(ref p, 39)
                    + Unsafe.Add(ref p, 40)
                    + Unsafe.Add(ref p, 41)
                    + Unsafe.Add(ref p, 42)
                    + Unsafe.Add(ref p, 43)
                    + Unsafe.Add(ref p, 44)
                    + Unsafe.Add(ref p, 45)
                    + Unsafe.Add(ref p, 46)
                    + Unsafe.Add(ref p, 47)
                    + Unsafe.Add(ref p, 48)
                    + Unsafe.Add(ref p, 49)
                    + Unsafe.Add(ref p, 50)
                    + Unsafe.Add(ref p, 51)
                    + Unsafe.Add(ref p, 52)
                    + Unsafe.Add(ref p, 53)
                    + Unsafe.Add(ref p, 54)
                    + Unsafe.Add(ref p, 55)
                    + Unsafe.Add(ref p, 56)
                    + Unsafe.Add(ref p, 57)
                    + Unsafe.Add(ref p, 58)
                    + Unsafe.Add(ref p, 59)
                    + Unsafe.Add(ref p, 60)
                    + Unsafe.Add(ref p, 61)
                    + Unsafe.Add(ref p, 62)
                    + Unsafe.Add(ref p, 63)
                );
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum_Basic(Vector512<short> value) {
                ref short p = ref Unsafe.As<Vector512<short>, short>(ref value);
                short rt = (short)(p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                    + Unsafe.Add(ref p, 8)
                    + Unsafe.Add(ref p, 9)
                    + Unsafe.Add(ref p, 10)
                    + Unsafe.Add(ref p, 11)
                    + Unsafe.Add(ref p, 12)
                    + Unsafe.Add(ref p, 13)
                    + Unsafe.Add(ref p, 14)
                    + Unsafe.Add(ref p, 15)
                    + Unsafe.Add(ref p, 16)
                    + Unsafe.Add(ref p, 17)
                    + Unsafe.Add(ref p, 18)
                    + Unsafe.Add(ref p, 19)
                    + Unsafe.Add(ref p, 20)
                    + Unsafe.Add(ref p, 21)
                    + Unsafe.Add(ref p, 22)
                    + Unsafe.Add(ref p, 23)
                    + Unsafe.Add(ref p, 24)
                    + Unsafe.Add(ref p, 25)
                    + Unsafe.Add(ref p, 26)
                    + Unsafe.Add(ref p, 27)
                    + Unsafe.Add(ref p, 28)
                    + Unsafe.Add(ref p, 29)
                    + Unsafe.Add(ref p, 30)
                    + Unsafe.Add(ref p, 31)
                );
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum_Basic(Vector512<ushort> value) {
                ref ushort p = ref Unsafe.As<Vector512<ushort>, ushort>(ref value);
                ushort rt = (ushort)(p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                    + Unsafe.Add(ref p, 8)
                    + Unsafe.Add(ref p, 9)
                    + Unsafe.Add(ref p, 10)
                    + Unsafe.Add(ref p, 11)
                    + Unsafe.Add(ref p, 12)
                    + Unsafe.Add(ref p, 13)
                    + Unsafe.Add(ref p, 14)
                    + Unsafe.Add(ref p, 15)
                    + Unsafe.Add(ref p, 16)
                    + Unsafe.Add(ref p, 17)
                    + Unsafe.Add(ref p, 18)
                    + Unsafe.Add(ref p, 19)
                    + Unsafe.Add(ref p, 20)
                    + Unsafe.Add(ref p, 21)
                    + Unsafe.Add(ref p, 22)
                    + Unsafe.Add(ref p, 23)
                    + Unsafe.Add(ref p, 24)
                    + Unsafe.Add(ref p, 25)
                    + Unsafe.Add(ref p, 26)
                    + Unsafe.Add(ref p, 27)
                    + Unsafe.Add(ref p, 28)
                    + Unsafe.Add(ref p, 29)
                    + Unsafe.Add(ref p, 30)
                    + Unsafe.Add(ref p, 31)
                );
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum_Basic(Vector512<int> value) {
                ref int p = ref Unsafe.As<Vector512<int>, int>(ref value);
                int rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                    + Unsafe.Add(ref p, 8)
                    + Unsafe.Add(ref p, 9)
                    + Unsafe.Add(ref p, 10)
                    + Unsafe.Add(ref p, 11)
                    + Unsafe.Add(ref p, 12)
                    + Unsafe.Add(ref p, 13)
                    + Unsafe.Add(ref p, 14)
                    + Unsafe.Add(ref p, 15)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum_Basic(Vector512<uint> value) {
                ref uint p = ref Unsafe.As<Vector512<uint>, uint>(ref value);
                uint rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                    + Unsafe.Add(ref p, 8)
                    + Unsafe.Add(ref p, 9)
                    + Unsafe.Add(ref p, 10)
                    + Unsafe.Add(ref p, 11)
                    + Unsafe.Add(ref p, 12)
                    + Unsafe.Add(ref p, 13)
                    + Unsafe.Add(ref p, 14)
                    + Unsafe.Add(ref p, 15)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum_Basic(Vector512<long> value) {
                ref long p = ref Unsafe.As<Vector512<long>, long>(ref value);
                long rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum_Basic(Vector512<ulong> value) {
                ref ulong p = ref Unsafe.As<Vector512<ulong>, ulong>(ref value);
                ulong rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                ;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{float}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<float> source, out Vector512<double> lower, out Vector512<double> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector512.Widen(source);
                // .NET8 on Avx512: Poor performance!
                //  1596: 		return (WidenLower(source), WidenUpper(source));
                //00007FFE09D30DD0  sub         rsp,28h  
                //00007FFE09D30DD4  movaps      xmmword ptr [rsp+10h],xmm6  
                //00007FFE09D30DD9  movaps      xmmword ptr [rsp],xmm7  
                //00007FFE09D30DDD  movups      xmm0,xmmword ptr [rdx]  
                //00007FFE09D30DE0  movups      xmm1,xmmword ptr [rdx+10h]  
                //00007FFE09D30DE4  cvtps2pd    xmm2,xmm0  
                //00007FFE09D30DE7  movhlps     xmm0,xmm0  
                //00007FFE09D30DEA  cvtps2pd    xmm0,xmm0  
                //00007FFE09D30DED  cvtps2pd    xmm3,xmm1  
                //00007FFE09D30DF0  movhlps     xmm1,xmm1  
                //00007FFE09D30DF3  cvtps2pd    xmm1,xmm1  
                //00007FFE09D30DF6  movups      xmm4,xmmword ptr [rdx+20h]  
                //00007FFE09D30DFA  movups      xmm5,xmmword ptr [rdx+30h]  
                //00007FFE09D30DFE  cvtps2pd    xmm6,xmm4  
                //00007FFE09D30E01  movhlps     xmm4,xmm4  
                //00007FFE09D30E04  cvtps2pd    xmm4,xmm4  
                //00007FFE09D30E07  cvtps2pd    xmm7,xmm5  
                //00007FFE09D30E0A  movhlps     xmm5,xmm5  
                //00007FFE09D30E0D  cvtps2pd    xmm5,xmm5  
                //00007FFE09D30E10  movups      xmmword ptr [rcx],xmm2  
                //00007FFE09D30E13  movups      xmmword ptr [rcx+10h],xmm0  
                //00007FFE09D30E17  movups      xmmword ptr [rcx+20h],xmm3  
                //00007FFE09D30E1B  movups      xmmword ptr [rcx+30h],xmm1  
                //00007FFE09D30E1F  movups      xmmword ptr [rcx+40h],xmm6  
                //00007FFE09D30E23  movups      xmmword ptr [rcx+50h],xmm4  
                //00007FFE09D30E27  movups      xmmword ptr [rcx+60h],xmm7  
                //00007FFE09D30E2B  movups      xmmword ptr [rcx+70h],xmm5  
                //00007FFE09D30E2F  mov         rax,rcx  
                //00007FFE09D30E32  movaps      xmm6,xmmword ptr [rsp+10h]  
                //00007FFE09D30E37  movaps      xmm7,xmmword ptr [rsp]  
                //00007FFE09D30E3B  add         rsp,28h  
                //00007FFE09D30E3F  ret  
                //00007FFE09D30E40  sub         rsp,28h  
                //00007FFE09D30E44  movaps      xmmword ptr [rsp+10h],xmm6  
                //00007FFE09D30E49  movaps      xmmword ptr [rsp],xmm7  
                //00007FFE09D30E4D  movups      xmm0,xmmword ptr [rdx]  
                //00007FFE09D30E50  movups      xmm1,xmmword ptr [rdx+10h]  
                //00007FFE09D30E54  pmovzxwd    xmm2,xmm0  
                //00007FFE09D30E59  psrldq      xmm0,8  
                //00007FFE09D30E5E  pmovzxwd    xmm0,xmm0  
                //00007FFE09D30E63  pmovzxwd    xmm3,xmm1  
                //00007FFE09D30E68  psrldq      xmm1,8  
                //00007FFE09D30E6D  pmovzxwd    xmm1,xmm1  
                //00007FFE09D30E72  movups      xmm4,xmmword ptr [rdx+20h]  
                //00007FFE09D30E76  movups      xmm5,xmmword ptr [rdx+30h]  
                //00007FFE09D30E7A  pmovzxwd    xmm6,xmm4  
                //00007FFE09D30E7F  psrldq      xmm4,8  
                //00007FFE09D30E84  pmovzxwd    xmm4,xmm4  
                //00007FFE09D30E89  pmovzxwd    xmm7,xmm5  
                //00007FFE09D30E8E  psrldq      xmm5,8  
                //00007FFE09D30E93  pmovzxwd    xmm5,xmm5  
                //00007FFE09D30E98  movups      xmmword ptr [rcx],xmm2  
                //00007FFE09D30E9B  movups      xmmword ptr [rcx+10h],xmm0  
                //00007FFE09D30E9F  movups      xmmword ptr [rcx+20h],xmm3  
                //00007FFE09D30EA3  movups      xmmword ptr [rcx+30h],xmm1  
                //00007FFE09D30EA7  movups      xmmword ptr [rcx+40h],xmm6  
                //00007FFE09D30EAB  movups      xmmword ptr [rcx+50h],xmm4  
                //00007FFE09D30EAF  movups      xmmword ptr [rcx+60h],xmm7  
                //00007FFE09D30EB3  movups      xmmword ptr [rcx+70h],xmm5  
                //00007FFE09D30EB7  mov         rax,rcx  
                //00007FFE09D30EBA  movaps      xmm6,xmmword ptr [rsp+10h]  
                //00007FFE09D30EBF  movaps      xmm7,xmmword ptr [rsp]  
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{sbyte}, out Vector512{short}, out Vector512{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<sbyte> source, out Vector512<short> lower, out Vector512<short> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector512.Widen(source);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{byte}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<byte> source, out Vector512<ushort> lower, out Vector512<ushort> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector512.Widen(source);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{short}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<short> source, out Vector512<int> lower, out Vector512<int> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector512.Widen(source);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{ushort}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<ushort> source, out Vector512<uint> lower, out Vector512<uint> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector512.Widen(source);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{int}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<int> source, out Vector512<long> lower, out Vector512<long> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector512.Widen(source);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{uint}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector512<uint> source, out Vector512<ulong> lower, out Vector512<ulong> upper) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                (lower, upper) = Vector512.Widen(source);
#else
                Widen_Basic(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{float}, out Vector512{double}, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector512<float> source, out Vector512<double> lower, out Vector512<double> upper) {
                nint cnt = Vector512<double>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
                ref float p = ref Unsafe.As<Vector512<float>, float>(ref source);
                ref double plower = ref Unsafe.As<Vector512<double>, double>(ref lower);
                ref double pupper = ref Unsafe.As<Vector512<double>, double>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref plower, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref plower, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref plower, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref plower, 7) = Unsafe.Add(ref p, 7);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref pupper, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref pupper, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref pupper, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref pupper, 7) = Unsafe.Add(ref p, 7);
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{sbyte}, out Vector512{short}, out Vector512{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector512<sbyte> source, out Vector512<short> lower, out Vector512<short> upper) {
                nint cnt = Vector512<short>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
                ref sbyte p = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref source);
                ref short plower = ref Unsafe.As<Vector512<short>, short>(ref lower);
                ref short pupper = ref Unsafe.As<Vector512<short>, short>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref plower, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref plower, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref plower, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref plower, 7) = Unsafe.Add(ref p, 7);
                Unsafe.Add(ref plower, 8) = Unsafe.Add(ref p, 8);
                Unsafe.Add(ref plower, 9) = Unsafe.Add(ref p, 9);
                Unsafe.Add(ref plower, 10) = Unsafe.Add(ref p, 10);
                Unsafe.Add(ref plower, 11) = Unsafe.Add(ref p, 11);
                Unsafe.Add(ref plower, 12) = Unsafe.Add(ref p, 12);
                Unsafe.Add(ref plower, 13) = Unsafe.Add(ref p, 13);
                Unsafe.Add(ref plower, 14) = Unsafe.Add(ref p, 14);
                Unsafe.Add(ref plower, 15) = Unsafe.Add(ref p, 15);
                Unsafe.Add(ref plower, 16) = Unsafe.Add(ref p, 16);
                Unsafe.Add(ref plower, 17) = Unsafe.Add(ref p, 17);
                Unsafe.Add(ref plower, 18) = Unsafe.Add(ref p, 18);
                Unsafe.Add(ref plower, 19) = Unsafe.Add(ref p, 19);
                Unsafe.Add(ref plower, 20) = Unsafe.Add(ref p, 20);
                Unsafe.Add(ref plower, 21) = Unsafe.Add(ref p, 21);
                Unsafe.Add(ref plower, 22) = Unsafe.Add(ref p, 22);
                Unsafe.Add(ref plower, 23) = Unsafe.Add(ref p, 23);
                Unsafe.Add(ref plower, 24) = Unsafe.Add(ref p, 24);
                Unsafe.Add(ref plower, 25) = Unsafe.Add(ref p, 25);
                Unsafe.Add(ref plower, 26) = Unsafe.Add(ref p, 26);
                Unsafe.Add(ref plower, 27) = Unsafe.Add(ref p, 27);
                Unsafe.Add(ref plower, 28) = Unsafe.Add(ref p, 28);
                Unsafe.Add(ref plower, 29) = Unsafe.Add(ref p, 29);
                Unsafe.Add(ref plower, 30) = Unsafe.Add(ref p, 30);
                Unsafe.Add(ref plower, 31) = Unsafe.Add(ref p, 31);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref pupper, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref pupper, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref pupper, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref pupper, 7) = Unsafe.Add(ref p, 7);
                Unsafe.Add(ref pupper, 8) = Unsafe.Add(ref p, 8);
                Unsafe.Add(ref pupper, 9) = Unsafe.Add(ref p, 9);
                Unsafe.Add(ref pupper, 10) = Unsafe.Add(ref p, 10);
                Unsafe.Add(ref pupper, 11) = Unsafe.Add(ref p, 11);
                Unsafe.Add(ref pupper, 12) = Unsafe.Add(ref p, 12);
                Unsafe.Add(ref pupper, 13) = Unsafe.Add(ref p, 13);
                Unsafe.Add(ref pupper, 14) = Unsafe.Add(ref p, 14);
                Unsafe.Add(ref pupper, 15) = Unsafe.Add(ref p, 15);
                Unsafe.Add(ref pupper, 16) = Unsafe.Add(ref p, 16);
                Unsafe.Add(ref pupper, 17) = Unsafe.Add(ref p, 17);
                Unsafe.Add(ref pupper, 18) = Unsafe.Add(ref p, 18);
                Unsafe.Add(ref pupper, 19) = Unsafe.Add(ref p, 19);
                Unsafe.Add(ref pupper, 20) = Unsafe.Add(ref p, 20);
                Unsafe.Add(ref pupper, 21) = Unsafe.Add(ref p, 21);
                Unsafe.Add(ref pupper, 22) = Unsafe.Add(ref p, 22);
                Unsafe.Add(ref pupper, 23) = Unsafe.Add(ref p, 23);
                Unsafe.Add(ref pupper, 24) = Unsafe.Add(ref p, 24);
                Unsafe.Add(ref pupper, 25) = Unsafe.Add(ref p, 25);
                Unsafe.Add(ref pupper, 26) = Unsafe.Add(ref p, 26);
                Unsafe.Add(ref pupper, 27) = Unsafe.Add(ref p, 27);
                Unsafe.Add(ref pupper, 28) = Unsafe.Add(ref p, 28);
                Unsafe.Add(ref pupper, 29) = Unsafe.Add(ref p, 29);
                Unsafe.Add(ref pupper, 30) = Unsafe.Add(ref p, 30);
                Unsafe.Add(ref pupper, 31) = Unsafe.Add(ref p, 31);
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{byte}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector512<byte> source, out Vector512<ushort> lower, out Vector512<ushort> upper) {
                nint cnt = Vector512<ushort>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
                ref byte p = ref Unsafe.As<Vector512<byte>, byte>(ref source);
                ref ushort plower = ref Unsafe.As<Vector512<ushort>, ushort>(ref lower);
                ref ushort pupper = ref Unsafe.As<Vector512<ushort>, ushort>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref plower, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref plower, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref plower, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref plower, 7) = Unsafe.Add(ref p, 7);
                Unsafe.Add(ref plower, 8) = Unsafe.Add(ref p, 8);
                Unsafe.Add(ref plower, 9) = Unsafe.Add(ref p, 9);
                Unsafe.Add(ref plower, 10) = Unsafe.Add(ref p, 10);
                Unsafe.Add(ref plower, 11) = Unsafe.Add(ref p, 11);
                Unsafe.Add(ref plower, 12) = Unsafe.Add(ref p, 12);
                Unsafe.Add(ref plower, 13) = Unsafe.Add(ref p, 13);
                Unsafe.Add(ref plower, 14) = Unsafe.Add(ref p, 14);
                Unsafe.Add(ref plower, 15) = Unsafe.Add(ref p, 15);
                Unsafe.Add(ref plower, 16) = Unsafe.Add(ref p, 16);
                Unsafe.Add(ref plower, 17) = Unsafe.Add(ref p, 17);
                Unsafe.Add(ref plower, 18) = Unsafe.Add(ref p, 18);
                Unsafe.Add(ref plower, 19) = Unsafe.Add(ref p, 19);
                Unsafe.Add(ref plower, 20) = Unsafe.Add(ref p, 20);
                Unsafe.Add(ref plower, 21) = Unsafe.Add(ref p, 21);
                Unsafe.Add(ref plower, 22) = Unsafe.Add(ref p, 22);
                Unsafe.Add(ref plower, 23) = Unsafe.Add(ref p, 23);
                Unsafe.Add(ref plower, 24) = Unsafe.Add(ref p, 24);
                Unsafe.Add(ref plower, 25) = Unsafe.Add(ref p, 25);
                Unsafe.Add(ref plower, 26) = Unsafe.Add(ref p, 26);
                Unsafe.Add(ref plower, 27) = Unsafe.Add(ref p, 27);
                Unsafe.Add(ref plower, 28) = Unsafe.Add(ref p, 28);
                Unsafe.Add(ref plower, 29) = Unsafe.Add(ref p, 29);
                Unsafe.Add(ref plower, 30) = Unsafe.Add(ref p, 30);
                Unsafe.Add(ref plower, 31) = Unsafe.Add(ref p, 31);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref pupper, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref pupper, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref pupper, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref pupper, 7) = Unsafe.Add(ref p, 7);
                Unsafe.Add(ref pupper, 8) = Unsafe.Add(ref p, 8);
                Unsafe.Add(ref pupper, 9) = Unsafe.Add(ref p, 9);
                Unsafe.Add(ref pupper, 10) = Unsafe.Add(ref p, 10);
                Unsafe.Add(ref pupper, 11) = Unsafe.Add(ref p, 11);
                Unsafe.Add(ref pupper, 12) = Unsafe.Add(ref p, 12);
                Unsafe.Add(ref pupper, 13) = Unsafe.Add(ref p, 13);
                Unsafe.Add(ref pupper, 14) = Unsafe.Add(ref p, 14);
                Unsafe.Add(ref pupper, 15) = Unsafe.Add(ref p, 15);
                Unsafe.Add(ref pupper, 16) = Unsafe.Add(ref p, 16);
                Unsafe.Add(ref pupper, 17) = Unsafe.Add(ref p, 17);
                Unsafe.Add(ref pupper, 18) = Unsafe.Add(ref p, 18);
                Unsafe.Add(ref pupper, 19) = Unsafe.Add(ref p, 19);
                Unsafe.Add(ref pupper, 20) = Unsafe.Add(ref p, 20);
                Unsafe.Add(ref pupper, 21) = Unsafe.Add(ref p, 21);
                Unsafe.Add(ref pupper, 22) = Unsafe.Add(ref p, 22);
                Unsafe.Add(ref pupper, 23) = Unsafe.Add(ref p, 23);
                Unsafe.Add(ref pupper, 24) = Unsafe.Add(ref p, 24);
                Unsafe.Add(ref pupper, 25) = Unsafe.Add(ref p, 25);
                Unsafe.Add(ref pupper, 26) = Unsafe.Add(ref p, 26);
                Unsafe.Add(ref pupper, 27) = Unsafe.Add(ref p, 27);
                Unsafe.Add(ref pupper, 28) = Unsafe.Add(ref p, 28);
                Unsafe.Add(ref pupper, 29) = Unsafe.Add(ref p, 29);
                Unsafe.Add(ref pupper, 30) = Unsafe.Add(ref p, 30);
                Unsafe.Add(ref pupper, 31) = Unsafe.Add(ref p, 31);
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{short}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector512<short> source, out Vector512<int> lower, out Vector512<int> upper) {
                nint cnt = Vector512<int>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
                ref short p = ref Unsafe.As<Vector512<short>, short>(ref source);
                ref int plower = ref Unsafe.As<Vector512<int>, int>(ref lower);
                ref int pupper = ref Unsafe.As<Vector512<int>, int>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref plower, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref plower, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref plower, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref plower, 7) = Unsafe.Add(ref p, 7);
                Unsafe.Add(ref plower, 8) = Unsafe.Add(ref p, 8);
                Unsafe.Add(ref plower, 9) = Unsafe.Add(ref p, 9);
                Unsafe.Add(ref plower, 10) = Unsafe.Add(ref p, 10);
                Unsafe.Add(ref plower, 11) = Unsafe.Add(ref p, 11);
                Unsafe.Add(ref plower, 12) = Unsafe.Add(ref p, 12);
                Unsafe.Add(ref plower, 13) = Unsafe.Add(ref p, 13);
                Unsafe.Add(ref plower, 14) = Unsafe.Add(ref p, 14);
                Unsafe.Add(ref plower, 15) = Unsafe.Add(ref p, 15);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref pupper, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref pupper, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref pupper, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref pupper, 7) = Unsafe.Add(ref p, 7);
                Unsafe.Add(ref pupper, 8) = Unsafe.Add(ref p, 8);
                Unsafe.Add(ref pupper, 9) = Unsafe.Add(ref p, 9);
                Unsafe.Add(ref pupper, 10) = Unsafe.Add(ref p, 10);
                Unsafe.Add(ref pupper, 11) = Unsafe.Add(ref p, 11);
                Unsafe.Add(ref pupper, 12) = Unsafe.Add(ref p, 12);
                Unsafe.Add(ref pupper, 13) = Unsafe.Add(ref p, 13);
                Unsafe.Add(ref pupper, 14) = Unsafe.Add(ref p, 14);
                Unsafe.Add(ref pupper, 15) = Unsafe.Add(ref p, 15);
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{ushort}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector512<ushort> source, out Vector512<uint> lower, out Vector512<uint> upper) {
                nint cnt = Vector512<uint>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
                ref ushort p = ref Unsafe.As<Vector512<ushort>, ushort>(ref source);
                ref uint plower = ref Unsafe.As<Vector512<uint>, uint>(ref lower);
                ref uint pupper = ref Unsafe.As<Vector512<uint>, uint>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref plower, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref plower, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref plower, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref plower, 7) = Unsafe.Add(ref p, 7);
                Unsafe.Add(ref plower, 8) = Unsafe.Add(ref p, 8);
                Unsafe.Add(ref plower, 9) = Unsafe.Add(ref p, 9);
                Unsafe.Add(ref plower, 10) = Unsafe.Add(ref p, 10);
                Unsafe.Add(ref plower, 11) = Unsafe.Add(ref p, 11);
                Unsafe.Add(ref plower, 12) = Unsafe.Add(ref p, 12);
                Unsafe.Add(ref plower, 13) = Unsafe.Add(ref p, 13);
                Unsafe.Add(ref plower, 14) = Unsafe.Add(ref p, 14);
                Unsafe.Add(ref plower, 15) = Unsafe.Add(ref p, 15);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref pupper, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref pupper, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref pupper, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref pupper, 7) = Unsafe.Add(ref p, 7);
                Unsafe.Add(ref pupper, 8) = Unsafe.Add(ref p, 8);
                Unsafe.Add(ref pupper, 9) = Unsafe.Add(ref p, 9);
                Unsafe.Add(ref pupper, 10) = Unsafe.Add(ref p, 10);
                Unsafe.Add(ref pupper, 11) = Unsafe.Add(ref p, 11);
                Unsafe.Add(ref pupper, 12) = Unsafe.Add(ref p, 12);
                Unsafe.Add(ref pupper, 13) = Unsafe.Add(ref p, 13);
                Unsafe.Add(ref pupper, 14) = Unsafe.Add(ref p, 14);
                Unsafe.Add(ref pupper, 15) = Unsafe.Add(ref p, 15);
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{int}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector512<int> source, out Vector512<long> lower, out Vector512<long> upper) {
                nint cnt = Vector512<long>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector512<int>, int>(ref source);
                ref long plower = ref Unsafe.As<Vector512<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector512<long>, long>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref plower, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref plower, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref plower, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref plower, 7) = Unsafe.Add(ref p, 7);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref pupper, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref pupper, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref pupper, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref pupper, 7) = Unsafe.Add(ref p, 7);
            }

            /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{uint}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Basic(Vector512<uint> source, out Vector512<ulong> lower, out Vector512<ulong> upper) {
                nint cnt = Vector512<ulong>.Count;
                UnsafeUtil.SkipInit(out lower);
                UnsafeUtil.SkipInit(out upper);
                ref uint p = ref Unsafe.As<Vector512<uint>, uint>(ref source);
                ref ulong plower = ref Unsafe.As<Vector512<ulong>, ulong>(ref lower);
                ref ulong pupper = ref Unsafe.As<Vector512<ulong>, ulong>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref plower, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref plower, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref plower, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref plower, 7) = Unsafe.Add(ref p, 7);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
                Unsafe.Add(ref pupper, 4) = Unsafe.Add(ref p, 4);
                Unsafe.Add(ref pupper, 5) = Unsafe.Add(ref p, 5);
                Unsafe.Add(ref pupper, 6) = Unsafe.Add(ref p, 6);
                Unsafe.Add(ref pupper, 7) = Unsafe.Add(ref p, 7);
            }


            /// <inheritdoc cref="IWVectorTraits512.WidenLower_AcceleratedTypes"/>
            public static TypeCodeFlags WidenLower_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> WidenLower(Vector512<float> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenLower(source);
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> WidenLower(Vector512<sbyte> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenLower(source);
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> WidenLower(Vector512<byte> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenLower(source);
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> WidenLower(Vector512<short> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenLower(source);
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> WidenLower(Vector512<ushort> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenLower(source);
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> WidenLower(Vector512<int> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenLower(source);
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> WidenLower(Vector512<uint> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenLower(source);
#else
                return WidenLower_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> WidenLower_Basic(Vector512<float> source) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref FixedArray8<double> p = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref rt);
                ref FixedArray16<float> psource = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> WidenLower_Basic(Vector512<sbyte> source) {
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref rt);
                ref FixedArray64<sbyte> psource = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                p.I8 = psource.I8;
                p.I9 = psource.I9;
                p.I10 = psource.I10;
                p.I11 = psource.I11;
                p.I12 = psource.I12;
                p.I13 = psource.I13;
                p.I14 = psource.I14;
                p.I15 = psource.I15;
                p.I16 = psource.I16;
                p.I17 = psource.I17;
                p.I18 = psource.I18;
                p.I19 = psource.I19;
                p.I20 = psource.I20;
                p.I21 = psource.I21;
                p.I22 = psource.I22;
                p.I23 = psource.I23;
                p.I24 = psource.I24;
                p.I25 = psource.I25;
                p.I26 = psource.I26;
                p.I27 = psource.I27;
                p.I28 = psource.I28;
                p.I29 = psource.I29;
                p.I30 = psource.I30;
                p.I31 = psource.I31;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> WidenLower_Basic(Vector512<byte> source) {
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
                ref FixedArray32<ushort> p = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref rt);
                ref FixedArray64<byte> psource = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                p.I8 = psource.I8;
                p.I9 = psource.I9;
                p.I10 = psource.I10;
                p.I11 = psource.I11;
                p.I12 = psource.I12;
                p.I13 = psource.I13;
                p.I14 = psource.I14;
                p.I15 = psource.I15;
                p.I16 = psource.I16;
                p.I17 = psource.I17;
                p.I18 = psource.I18;
                p.I19 = psource.I19;
                p.I20 = psource.I20;
                p.I21 = psource.I21;
                p.I22 = psource.I22;
                p.I23 = psource.I23;
                p.I24 = psource.I24;
                p.I25 = psource.I25;
                p.I26 = psource.I26;
                p.I27 = psource.I27;
                p.I28 = psource.I28;
                p.I29 = psource.I29;
                p.I30 = psource.I30;
                p.I31 = psource.I31;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> WidenLower_Basic(Vector512<short> source) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref rt);
                ref FixedArray32<short> psource = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                p.I8 = psource.I8;
                p.I9 = psource.I9;
                p.I10 = psource.I10;
                p.I11 = psource.I11;
                p.I12 = psource.I12;
                p.I13 = psource.I13;
                p.I14 = psource.I14;
                p.I15 = psource.I15;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> WidenLower_Basic(Vector512<ushort> source) {
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                ref FixedArray16<uint> p = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref rt);
                ref FixedArray32<ushort> psource = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                p.I8 = psource.I8;
                p.I9 = psource.I9;
                p.I10 = psource.I10;
                p.I11 = psource.I11;
                p.I12 = psource.I12;
                p.I13 = psource.I13;
                p.I14 = psource.I14;
                p.I15 = psource.I15;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> WidenLower_Basic(Vector512<int> source) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref rt);
                ref FixedArray16<int> psource = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> WidenLower_Basic(Vector512<uint> source) {
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
                ref FixedArray8<ulong> p = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref rt);
                ref FixedArray16<uint> psource = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref source);
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.WidenUpper_AcceleratedTypes"/>
            public static TypeCodeFlags WidenUpper_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> WidenUpper(Vector512<float> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenUpper(source);
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> WidenUpper(Vector512<sbyte> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenUpper(source);
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> WidenUpper(Vector512<byte> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenUpper(source);
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> WidenUpper(Vector512<short> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenUpper(source);
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> WidenUpper(Vector512<ushort> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenUpper(source);
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> WidenUpper(Vector512<int> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenUpper(source);
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> WidenUpper(Vector512<uint> source) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.WidenUpper(source);
#else
                return WidenUpper_Basic(source);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> WidenUpper_Basic(Vector512<float> source) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref FixedArray8<double> p = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref rt);
                ref FixedArray16<float> psource = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref Unsafe.AddByteOffset(ref source, Vector512<byte>.Count / 2));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> WidenUpper_Basic(Vector512<sbyte> source) {
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref rt);
                ref FixedArray64<sbyte> psource = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref Unsafe.AddByteOffset(ref source, Vector512<byte>.Count / 2));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                p.I8 = psource.I8;
                p.I9 = psource.I9;
                p.I10 = psource.I10;
                p.I11 = psource.I11;
                p.I12 = psource.I12;
                p.I13 = psource.I13;
                p.I14 = psource.I14;
                p.I15 = psource.I15;
                p.I16 = psource.I16;
                p.I17 = psource.I17;
                p.I18 = psource.I18;
                p.I19 = psource.I19;
                p.I20 = psource.I20;
                p.I21 = psource.I21;
                p.I22 = psource.I22;
                p.I23 = psource.I23;
                p.I24 = psource.I24;
                p.I25 = psource.I25;
                p.I26 = psource.I26;
                p.I27 = psource.I27;
                p.I28 = psource.I28;
                p.I29 = psource.I29;
                p.I30 = psource.I30;
                p.I31 = psource.I31;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> WidenUpper_Basic(Vector512<byte> source) {
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
                ref FixedArray32<ushort> p = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref rt);
                ref FixedArray64<byte> psource = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref Unsafe.AddByteOffset(ref source, Vector512<byte>.Count / 2));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                p.I8 = psource.I8;
                p.I9 = psource.I9;
                p.I10 = psource.I10;
                p.I11 = psource.I11;
                p.I12 = psource.I12;
                p.I13 = psource.I13;
                p.I14 = psource.I14;
                p.I15 = psource.I15;
                p.I16 = psource.I16;
                p.I17 = psource.I17;
                p.I18 = psource.I18;
                p.I19 = psource.I19;
                p.I20 = psource.I20;
                p.I21 = psource.I21;
                p.I22 = psource.I22;
                p.I23 = psource.I23;
                p.I24 = psource.I24;
                p.I25 = psource.I25;
                p.I26 = psource.I26;
                p.I27 = psource.I27;
                p.I28 = psource.I28;
                p.I29 = psource.I29;
                p.I30 = psource.I30;
                p.I31 = psource.I31;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> WidenUpper_Basic(Vector512<short> source) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref rt);
                ref FixedArray32<short> psource = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref Unsafe.AddByteOffset(ref source, Vector512<byte>.Count / 2));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                p.I8 = psource.I8;
                p.I9 = psource.I9;
                p.I10 = psource.I10;
                p.I11 = psource.I11;
                p.I12 = psource.I12;
                p.I13 = psource.I13;
                p.I14 = psource.I14;
                p.I15 = psource.I15;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> WidenUpper_Basic(Vector512<ushort> source) {
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                ref FixedArray16<uint> p = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref rt);
                ref FixedArray32<ushort> psource = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref Unsafe.AddByteOffset(ref source, Vector512<byte>.Count / 2));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                p.I8 = psource.I8;
                p.I9 = psource.I9;
                p.I10 = psource.I10;
                p.I11 = psource.I11;
                p.I12 = psource.I12;
                p.I13 = psource.I13;
                p.I14 = psource.I14;
                p.I15 = psource.I15;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> WidenUpper_Basic(Vector512<int> source) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref rt);
                ref FixedArray16<int> psource = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref Unsafe.AddByteOffset(ref source, Vector512<byte>.Count / 2));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.WidenUpper(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> WidenUpper_Basic(Vector512<uint> source) {
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
                ref FixedArray8<ulong> p = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref rt);
                ref FixedArray16<uint> psource = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref Unsafe.AddByteOffset(ref source, Vector512<byte>.Count / 2));
                p.I0 = psource.I0;
                p.I1 = psource.I1;
                p.I2 = psource.I2;
                p.I3 = psource.I3;
                p.I4 = psource.I4;
                p.I5 = psource.I5;
                p.I6 = psource.I6;
                p.I7 = psource.I7;
                return rt;
            }

#endif // NET8_0_OR_GREATER
        }
    }
}
