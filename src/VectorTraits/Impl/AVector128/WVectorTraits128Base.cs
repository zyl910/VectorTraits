using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
using Zyl.VectorTraits.Impl.Util;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl.AVector128 {
    /// <summary>
    /// <see cref="Vector128{T}"/> traits - Base.
    /// </summary>
    public sealed partial class WVectorTraits128Base : WVectorTraits128Abstract {
        private static readonly WVectorTraits128Base _instance = new WVectorTraits128Base(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits128Base Instance {
            get { return _instance; }
        }

#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector128{T}"/> traits.Statics - Base.
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
                rt = true;
#else
#endif // NETCOREAPP3_0_OR_GREATER
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Vector128 type is not supported!";
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Ceiling(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Ceiling(value);
#else
                return Ceiling_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Ceiling(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Ceiling(value);
#else
                return Ceiling_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<float> Ceiling_Base(Vector128<float> value) {
                Vector128<float> rt = value;
                float* p = (float*)&rt;
                p[0] = MathF.Ceiling(p[0]);
                p[1] = MathF.Ceiling(p[1]);
                p[2] = MathF.Ceiling(p[2]);
                p[3] = MathF.Ceiling(p[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<double> Ceiling_Base(Vector128<double> value) {
                Vector128<double> rt = value;
                double* p = (double*)&rt;
                p[0] = Math.Ceiling(p[0]);
                p[1] = Math.Ceiling(p[1]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble(Vector128<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ConvertToDouble(value);
#else
                return ConvertToDouble_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble(Vector128<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ConvertToDouble(value);
#else
                return ConvertToDouble_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Base(Vector128<long> value) {
                UnsafeEx.SkipInit(out Vector128<double> rt);
                ref double prt = ref Unsafe.As<Vector128<double>, double>(ref rt);
                ref long p = ref Unsafe.As<Vector128<long>, long>(ref value);
                prt = (Double)p;
                Unsafe.Add(ref prt, 1) = (Double)Unsafe.Add(ref p, 1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble_Base(Vector128<ulong> value) {
                UnsafeEx.SkipInit(out Vector128<double> rt);
                ref double prt = ref Unsafe.As<Vector128<double>, double>(ref rt);
                ref ulong p = ref Unsafe.As<Vector128<ulong>, ulong>(ref value);
                prt = (Double)p;
                Unsafe.Add(ref prt, 1) = (Double)Unsafe.Add(ref p, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt32_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt32(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ConvertToInt32(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ConvertToInt32(value);
#else
                return ConvertToInt32_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt32(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ConvertToInt32_Base(Vector128<float> value) {
                UnsafeEx.SkipInit(out Vector128<int> rt);
                ref int prt = ref Unsafe.As<Vector128<int>, int>(ref rt);
                ref float p = ref Unsafe.As<Vector128<float>, float>(ref value);
                prt = (Int32)p;
                Unsafe.Add(ref prt, 1) = (Int32)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Int32)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Int32)Unsafe.Add(ref p, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        //rt |= TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ConvertToInt64(value);
#else
                return ConvertToInt64_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64_Base(Vector128<double> value) {
                UnsafeEx.SkipInit(out Vector128<long> rt);
                ref long prt = ref Unsafe.As<Vector128<long>, long>(ref rt);
                ref double p = ref Unsafe.As<Vector128<double>, double>(ref value);
                prt = (Int64)p;
                Unsafe.Add(ref prt, 1) = (Int64)Unsafe.Add(ref p, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToSingle_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> ConvertToSingle(Vector128<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ConvertToSingle(value);
#else
                return ConvertToSingle_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> ConvertToSingle(Vector128<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ConvertToSingle(value);
#else
                return ConvertToSingle_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> ConvertToSingle_Base(Vector128<int> value) {
                UnsafeEx.SkipInit(out Vector128<float> rt);
                ref float prt = ref Unsafe.As<Vector128<float>, float>(ref rt);
                ref int p = ref Unsafe.As<Vector128<int>, int>(ref value);
                prt = (Single)p;
                Unsafe.Add(ref prt, 1) = (Single)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Single)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Single)Unsafe.Add(ref p, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToSingle(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> ConvertToSingle_Base(Vector128<uint> value) {
                UnsafeEx.SkipInit(out Vector128<float> rt);
                ref float prt = ref Unsafe.As<Vector128<float>, float>(ref rt);
                ref uint p = ref Unsafe.As<Vector128<uint>, uint>(ref value);
                prt = (Single)p;
                Unsafe.Add(ref prt, 1) = (Single)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (Single)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (Single)Unsafe.Add(ref p, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ConvertToUInt32(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ConvertToUInt32(value);
#else
                return ConvertToUInt32_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt32(Vector128{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ConvertToUInt32_Base(Vector128<float> value) {
                UnsafeEx.SkipInit(out Vector128<uint> rt);
                ref uint prt = ref Unsafe.As<Vector128<uint>, uint>(ref rt);
                ref float p = ref Unsafe.As<Vector128<float>, float>(ref value);
                prt = (UInt32)p;
                Unsafe.Add(ref prt, 1) = (UInt32)Unsafe.Add(ref p, 1);
                Unsafe.Add(ref prt, 2) = (UInt32)Unsafe.Add(ref p, 2);
                Unsafe.Add(ref prt, 3) = (UInt32)Unsafe.Add(ref p, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ConvertToUInt64(value);
#else
                return ConvertToUInt64_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64_Base(Vector128<double> value) {
                UnsafeEx.SkipInit(out Vector128<ulong> rt);
                ref ulong prt = ref Unsafe.As<Vector128<ulong>, ulong>(ref rt);
                ref double p = ref Unsafe.As<Vector128<double>, double>(ref value);
                prt = (UInt64)p;
                Unsafe.Add(ref prt, 1) = (UInt64)Unsafe.Add(ref p, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits_AcceleratedTypes"/>
            public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<float> vector) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<double> vector) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<sbyte> vector) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<byte> vector) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<short> vector) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<ushort> vector) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<int> vector) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<uint> vector) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<long> vector) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<ulong> vector) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ExtractMostSignificantBits(vector);
#else
                return ExtractMostSignificantBits_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{float})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Base(Vector128<float> vector) {
                return ExtractMostSignificantBits_Base(vector.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Base(Vector128<double> vector) {
                return ExtractMostSignificantBits_Base(vector.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Base(Vector128<sbyte> vector) {
                return Statics.ExtractMostSignificantBits_Base(vector.AsByte());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Base(Vector128<byte> vector) {
                ref byte p = ref Unsafe.As<Vector128<byte>, byte>(ref vector);
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

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Base(Vector128<short> vector) {
                return ExtractMostSignificantBits_Base(vector.AsUInt16());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Base(Vector128<ushort> vector) {
                ref ushort p = ref Unsafe.As<Vector128<ushort>, ushort>(ref vector);
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

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Base(Vector128<int> vector) {
                return ExtractMostSignificantBits_Base(vector.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Base(Vector128<uint> vector) {
                ref uint p = ref Unsafe.As<Vector128<uint>, uint>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 1)) << 1)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 2)) << 2)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 3)) << 3)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Base(Vector128<long> vector) {
                return ExtractMostSignificantBits_Base(vector.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits_Base(Vector128<ulong> vector) {
                ref ulong p = ref Unsafe.As<Vector128<ulong>, ulong>(ref vector);
                uint rt = BitMath.GetMostSignificantBit(p)
                    | (BitMath.GetMostSignificantBit(Unsafe.Add(ref p, 1)) << 1)
                ;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Floor(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Floor(value);
#else
                return Floor_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Floor(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Floor(value);
#else
                return Floor_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<float> Floor_Base(Vector128<float> value) {
                Vector128<float> rt = value;
                float* p = (float*)&rt;
                p[0] = MathF.Floor(p[0]);
                p[1] = MathF.Floor(p[1]);
                p[2] = MathF.Floor(p[2]);
                p[3] = MathF.Floor(p[3]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector128<double> Floor_Base(Vector128<double> value) {
                Vector128<double> rt = value;
                double* p = (double*)&rt;
                p[0] = Math.Floor(p[0]);
                p[1] = Math.Floor(p[1]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{double}, Vector128{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Narrow(Vector128<double> lower, Vector128<double> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{short}, Vector128{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Narrow(Vector128<short> lower, Vector128<short> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{ushort}, Vector128{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Narrow(Vector128<ushort> lower, Vector128<ushort> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{int}, Vector128{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Narrow(Vector128<int> lower, Vector128<int> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{uint}, Vector128{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Narrow(Vector128<uint> lower, Vector128<uint> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{long}, Vector128{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Narrow(Vector128<long> lower, Vector128<long> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{ulong}, Vector128{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Narrow(Vector128<ulong> lower, Vector128<ulong> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Narrow(lower, upper);
#else
                return Narrow_Base(lower, upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{double}, Vector128{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Narrow_Base(Vector128<double> lower, Vector128<double> upper) {
                nint cnt = Vector128<double>.Count;
                UnsafeEx.SkipInit(out Vector128<float> rt);
                ref float p = ref Unsafe.As<Vector128<float>, float>(ref rt);
                ref double plower = ref Unsafe.As<Vector128<double>, double>(ref lower);
                ref double pupper = ref Unsafe.As<Vector128<double>, double>(ref upper);
                p = (float)plower;
                Unsafe.Add(ref p, 1) = (float)Unsafe.Add(ref plower, 1);
                p = ref Unsafe.Add(ref p, cnt);
                p = (float)pupper;
                Unsafe.Add(ref p, 1) = (float)Unsafe.Add(ref pupper, 1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{short}, Vector128{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Narrow_Base(Vector128<short> lower, Vector128<short> upper) {
                nint cnt = Vector128<short>.Count;
                UnsafeEx.SkipInit(out Vector128<sbyte> rt);
                ref sbyte p = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref rt);
                ref short plower = ref Unsafe.As<Vector128<short>, short>(ref lower);
                ref short pupper = ref Unsafe.As<Vector128<short>, short>(ref upper);
                p = (sbyte)plower;
                Unsafe.Add(ref p, 1) = (sbyte)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (sbyte)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (sbyte)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (sbyte)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (sbyte)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (sbyte)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (sbyte)Unsafe.Add(ref plower, 7);
                p = ref Unsafe.Add(ref p, cnt);
                p = (sbyte)pupper;
                Unsafe.Add(ref p, 1) = (sbyte)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (sbyte)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (sbyte)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (sbyte)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (sbyte)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (sbyte)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (sbyte)Unsafe.Add(ref pupper, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{ushort}, Vector128{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Narrow_Base(Vector128<ushort> lower, Vector128<ushort> upper) {
                nint cnt = Vector128<ushort>.Count;
                UnsafeEx.SkipInit(out Vector128<byte> rt);
                ref byte p = ref Unsafe.As<Vector128<byte>, byte>(ref rt);
                ref ushort plower = ref Unsafe.As<Vector128<ushort>, ushort>(ref lower);
                ref ushort pupper = ref Unsafe.As<Vector128<ushort>, ushort>(ref upper);
                p = (byte)plower;
                Unsafe.Add(ref p, 1) = (byte)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (byte)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (byte)Unsafe.Add(ref plower, 3);
                Unsafe.Add(ref p, 4) = (byte)Unsafe.Add(ref plower, 4);
                Unsafe.Add(ref p, 5) = (byte)Unsafe.Add(ref plower, 5);
                Unsafe.Add(ref p, 6) = (byte)Unsafe.Add(ref plower, 6);
                Unsafe.Add(ref p, 7) = (byte)Unsafe.Add(ref plower, 7);
                p = ref Unsafe.Add(ref p, cnt);
                p = (byte)pupper;
                Unsafe.Add(ref p, 1) = (byte)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (byte)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (byte)Unsafe.Add(ref pupper, 3);
                Unsafe.Add(ref p, 4) = (byte)Unsafe.Add(ref pupper, 4);
                Unsafe.Add(ref p, 5) = (byte)Unsafe.Add(ref pupper, 5);
                Unsafe.Add(ref p, 6) = (byte)Unsafe.Add(ref pupper, 6);
                Unsafe.Add(ref p, 7) = (byte)Unsafe.Add(ref pupper, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{int}, Vector128{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Narrow_Base(Vector128<int> lower, Vector128<int> upper) {
                nint cnt = Vector128<int>.Count;
                UnsafeEx.SkipInit(out Vector128<short> rt);
                ref short p = ref Unsafe.As<Vector128<short>, short>(ref rt);
                ref int plower = ref Unsafe.As<Vector128<int>, int>(ref lower);
                ref int pupper = ref Unsafe.As<Vector128<int>, int>(ref upper);
                p = (short)plower;
                Unsafe.Add(ref p, 1) = (short)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (short)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (short)Unsafe.Add(ref plower, 3);
                p = ref Unsafe.Add(ref p, cnt);
                p = (short)pupper;
                Unsafe.Add(ref p, 1) = (short)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (short)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (short)Unsafe.Add(ref pupper, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{uint}, Vector128{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Narrow_Base(Vector128<uint> lower, Vector128<uint> upper) {
                nint cnt = Vector128<uint>.Count;
                UnsafeEx.SkipInit(out Vector128<ushort> rt);
                ref ushort p = ref Unsafe.As<Vector128<ushort>, ushort>(ref rt);
                ref uint plower = ref Unsafe.As<Vector128<uint>, uint>(ref lower);
                ref uint pupper = ref Unsafe.As<Vector128<uint>, uint>(ref upper);
                p = (ushort)plower;
                Unsafe.Add(ref p, 1) = (ushort)Unsafe.Add(ref plower, 1);
                Unsafe.Add(ref p, 2) = (ushort)Unsafe.Add(ref plower, 2);
                Unsafe.Add(ref p, 3) = (ushort)Unsafe.Add(ref plower, 3);
                p = ref Unsafe.Add(ref p, cnt);
                p = (ushort)pupper;
                Unsafe.Add(ref p, 1) = (ushort)Unsafe.Add(ref pupper, 1);
                Unsafe.Add(ref p, 2) = (ushort)Unsafe.Add(ref pupper, 2);
                Unsafe.Add(ref p, 3) = (ushort)Unsafe.Add(ref pupper, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{long}, Vector128{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Narrow_Base(Vector128<long> lower, Vector128<long> upper) {
                nint cnt = Vector128<long>.Count;
                UnsafeEx.SkipInit(out Vector128<int> rt);
                ref int p = ref Unsafe.As<Vector128<int>, int>(ref rt);
                ref long plower = ref Unsafe.As<Vector128<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector128<long>, long>(ref upper);
                p = (int)plower;
                Unsafe.Add(ref p, 1) = (int)Unsafe.Add(ref plower, 1);
                p = ref Unsafe.Add(ref p, cnt);
                p = (int)pupper;
                Unsafe.Add(ref p, 1) = (int)Unsafe.Add(ref pupper, 1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{ulong}, Vector128{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Narrow_Base(Vector128<ulong> lower, Vector128<ulong> upper) {
                nint cnt = Vector128<ulong>.Count;
                UnsafeEx.SkipInit(out Vector128<uint> rt);
                ref uint p = ref Unsafe.As<Vector128<uint>, uint>(ref rt);
                ref ulong plower = ref Unsafe.As<Vector128<ulong>, ulong>(ref lower);
                ref ulong pupper = ref Unsafe.As<Vector128<ulong>, ulong>(ref upper);
                p = (uint)plower;
                Unsafe.Add(ref p, 1) = (uint)Unsafe.Add(ref plower, 1);
                p = ref Unsafe.Add(ref p, cnt);
                p = (uint)pupper;
                Unsafe.Add(ref p, 1) = (uint)Unsafe.Add(ref pupper, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft(Vector128<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft(Vector128<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft(Vector128<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft(Vector128<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft(Vector128<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft(Vector128<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft(Vector128<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Base(Vector128<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Base(Vector128<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Base(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Base(Vector128<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Base(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Base(Vector128<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Base(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Base(Vector128<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeft_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Args(Vector128<sbyte> dummy, int shiftAmount, out Vector128<sbyte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{byte}, int, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Args(Vector128<byte> dummy, int shiftAmount, out Vector128<byte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{short}, int, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{ushort}, int, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Args(Vector128<ushort> dummy, int shiftAmount, out Vector128<ushort> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{int}, int, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{uint}, int, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Args(Vector128<uint> dummy, int shiftAmount, out Vector128<uint> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{long}, int, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Args(Vector128<ulong> dummy, int shiftAmount, out Vector128<ulong> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Core(Vector128<byte> value, int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Core(Vector128<ushort> value, int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Core(Vector128<uint> value, int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Core(Vector128<ulong> value, int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Const(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Const(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Const(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Const(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Const(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Const(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_ConstCore(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_ConstCore(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_ConstCore(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_ConstCore(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_ConstCore(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_ConstCore(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_ConstCore(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftLeft_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Fast(Vector128<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Fast(Vector128<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Fast(Vector128<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Fast(Vector128<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Fast(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Fast(Vector128<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Fast(Vector128<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Fast(Vector128<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft_Fast_Base(Vector128<sbyte> value, int shiftAmount) {
                return ShiftLeft_Fast_Base(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft_Fast_Base(Vector128<byte> value, int shiftAmount) {
                Vector128<byte> rt = value;
                ref byte p = ref Unsafe.As<Vector128<byte>, byte>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft_Fast_Base(Vector128<short> value, int shiftAmount) {
                Vector128<short> rt = value;
                ref short p = ref Unsafe.As<Vector128<short>, short>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft_Fast_Base(Vector128<ushort> value, int shiftAmount) {
                return ShiftLeft_Fast_Base(value.AsInt16(), shiftAmount).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft_Fast_Base(Vector128<int> value, int shiftAmount) {
                Vector128<int> rt = value;
                ref int p = ref Unsafe.As<Vector128<int>, int>(ref rt);
                p <<= shiftAmount;
                Unsafe.Add(ref p, 1) <<= shiftAmount;
                Unsafe.Add(ref p, 2) <<= shiftAmount;
                Unsafe.Add(ref p, 3) <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft_Fast_Base(Vector128<uint> value, int shiftAmount) {
                return ShiftLeft_Fast_Base(value.AsInt32(), shiftAmount).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft_Fast_Base(Vector128<long> value, int shiftAmount) {
                Vector128<long> rt = value;
                ref long p = ref Unsafe.As<Vector128<long>, long>(ref rt);
                p <<= shiftAmount;
                Unsafe.Add(ref p, 1) <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_Fast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft_Fast_Base(Vector128<ulong> value, int shiftAmount) {
                return ShiftLeft_Fast_Base(value.AsInt64(), shiftAmount).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector128.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector128.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Base(Vector128<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Base(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Base(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Base(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
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
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Const(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Const(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightArithmetic_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Fast(Vector128<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector128.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Fast(Vector128<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Fast(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Fast(Vector128<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic_Fast_Base(Vector128<sbyte> value, int shiftAmount) {
                Vector128<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic_Fast_Base(Vector128<short> value, int shiftAmount) {
                Vector128<short> rt = value;
                ref short p = ref Unsafe.As<Vector128<short>, short>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic_Fast_Base(Vector128<int> value, int shiftAmount) {
                Vector128<int> rt = value;
                ref int p = ref Unsafe.As<Vector128<int>, int>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic_Fast_Base(Vector128<long> value, int shiftAmount) {
                Vector128<long> rt = value;
                ref long p = ref Unsafe.As<Vector128<long>, long>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical(Vector128<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical(Vector128<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical(Vector128<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical(Vector128<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Base(Vector128<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Base(Vector128<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Base(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Base(Vector128<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Base(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Base(Vector128<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Base(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Base(Vector128<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{sbyte}, int, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Args(Vector128<sbyte> dummy, int shiftAmount, out Vector128<sbyte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{byte}, int, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Args(Vector128<byte> dummy, int shiftAmount, out Vector128<byte> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{short}, int, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Args(Vector128<short> dummy, int shiftAmount, out Vector128<short> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{ushort}, int, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Args(Vector128<ushort> dummy, int shiftAmount, out Vector128<ushort> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{int}, int, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Args(Vector128<int> dummy, int shiftAmount, out Vector128<int> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{uint}, int, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Args(Vector128<uint> dummy, int shiftAmount, out Vector128<uint> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{long}, int, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Args(Vector128<long> dummy, int shiftAmount, out Vector128<long> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Args(Vector128{ulong}, int, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Args(Vector128<ulong> dummy, int shiftAmount, out Vector128<ulong> args1) {
                _ = dummy;
                _ = shiftAmount;
                args1 = default;
                return args1;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Core(Vector128<sbyte> value, int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Core(Vector128<byte> value, int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Core(Vector128<short> value, int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Core(Vector128<ushort> value, int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Core(Vector128<int> value, int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Core(Vector128<uint> value, int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Core(Vector128<long> value, int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Core(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Core(Vector128<ulong> value, int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Const(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Const(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Const(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Const(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Const(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Const(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Const(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Const(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Const(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{sbyte}, int, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_ConstCore(Vector128<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{byte}, int, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_ConstCore(Vector128<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector128<byte> args0, Vector128<byte> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{short}, int, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_ConstCore(Vector128<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<short> args0, Vector128<short> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{ushort}, int, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_ConstCore(Vector128<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector128<ushort> args0, Vector128<ushort> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{int}, int, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_ConstCore(Vector128<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<int> args0, Vector128<int> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{uint}, int, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_ConstCore(Vector128<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector128<uint> args0, Vector128<uint> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{long}, int, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_ConstCore(Vector128<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<long> args0, Vector128<long> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_ConstCore(Vector128{ulong}, int, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_ConstCore(Vector128<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector128<ulong> args0, Vector128<ulong> args1) {
                _ = args0;
                _ = args1;
                return ShiftRightLogical_Fast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Fast(Vector128<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Fast(Vector128<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Fast(Vector128<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Fast(Vector128<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Fast(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Fast(Vector128<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Fast(Vector128<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Fast(Vector128<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Fast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical_Fast_Base(Vector128<sbyte> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Base(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical_Fast_Base(Vector128<byte> value, int shiftAmount) {
                Vector128<byte> rt = value;
                ref byte p = ref Unsafe.As<Vector128<byte>, byte>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical_Fast_Base(Vector128<short> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Base(value.AsUInt16(), shiftAmount).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical_Fast_Base(Vector128<ushort> value, int shiftAmount) {
                Vector128<ushort> rt = value;
                ref ushort p = ref Unsafe.As<Vector128<ushort>, ushort>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical_Fast_Base(Vector128<int> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Base(value.AsUInt32(), shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical_Fast_Base(Vector128<uint> value, int shiftAmount) {
                Vector128<uint> rt = value;
                ref uint p = ref Unsafe.As<Vector128<uint>, uint>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                Unsafe.Add(ref p, 2) >>= shiftAmount;
                Unsafe.Add(ref p, 3) >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical_Fast_Base(Vector128<long> value, int shiftAmount) {
                return ShiftRightLogical_Fast_Base(value.AsUInt64(), shiftAmount).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_Fast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical_Fast_Base(Vector128<ulong> value, int shiftAmount) {
                Vector128<ulong> rt = value;
                ref ulong p = ref Unsafe.As<Vector128<ulong>, ulong>(ref rt);
                p >>= shiftAmount;
                Unsafe.Add(ref p, 1) >>= shiftAmount;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Shuffle_AcceleratedTypes"/>
            public static TypeCodeFlags Shuffle_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.None; // `.NET 7.0` doesn't have hardware acceleration yet .
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Shuffle(Vector128<float> vector, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Shuffle(Vector128<double> vector, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Shuffle(Vector128<sbyte> vector, Vector128<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Shuffle(Vector128<byte> vector, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Shuffle(Vector128<short> vector, Vector128<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Shuffle(Vector128<ushort> vector, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Shuffle(Vector128<int> vector, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Shuffle(Vector128<uint> vector, Vector128<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Shuffle(Vector128<long> vector, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Shuffle(Vector128<ulong> vector, Vector128<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Shuffle(vector, indices);
#else
                return Shuffle_Base(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Shuffle_Base(Vector128<float> vector, Vector128<int> indices) {
                return Shuffle_Base(vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Shuffle_Base(Vector128<double> vector, Vector128<long> indices) {
                return Shuffle_Base(vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Shuffle_Base(Vector128<sbyte> vector, Vector128<sbyte> indices) {
                return Shuffle_Base(vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Shuffle_Base(Vector128<byte> vector, Vector128<byte> indices) {
                UnsafeEx.SkipInit(out Vector128<byte> rt);
                byte cnt = (byte)Vector128<byte>.Count;
                ref byte q = ref Unsafe.As<Vector128<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector128<byte>, byte>(ref vector);
                ref byte pindices = ref Unsafe.As<Vector128<byte>, byte>(ref indices);
                for (nint i = 0; i < Vector128<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Shuffle_Base(Vector128<short> vector, Vector128<short> indices) {
                return Shuffle_Base(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Shuffle_Base(Vector128<ushort> vector, Vector128<ushort> indices) {
                UnsafeEx.SkipInit(out Vector128<ushort> rt);
                ushort cnt = (ushort)Vector128<ushort>.Count;
                ref ushort q = ref Unsafe.As<Vector128<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector128<ushort>, ushort>(ref vector);
                ref ushort pindices = ref Unsafe.As<Vector128<ushort>, ushort>(ref indices);
                for (nint i = 0; i < Vector128<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Shuffle_Base(Vector128<int> vector, Vector128<int> indices) {
                return Shuffle_Base(vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Shuffle_Base(Vector128<uint> vector, Vector128<uint> indices) {
                UnsafeEx.SkipInit(out Vector128<uint> rt);
                uint cnt = (uint)Vector128<uint>.Count;
                ref uint q = ref Unsafe.As<Vector128<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector128<uint>, uint>(ref vector);
                ref uint pindices = ref Unsafe.As<Vector128<uint>, uint>(ref indices);
                for (nint i = 0; i < Vector128<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Shuffle_Base(Vector128<long> vector, Vector128<long> indices) {
                return Shuffle_Base(vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Shuffle_Base(Vector128<ulong> vector, Vector128<ulong> indices) {
                UnsafeEx.SkipInit(out Vector128<ulong> rt);
                ulong cnt = (ulong)Vector128<ulong>.Count;
                ref ulong q = ref Unsafe.As<Vector128<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector128<ulong>, ulong>(ref vector);
                ref ulong pindices = ref Unsafe.As<Vector128<ulong>, ulong>(ref indices);
                for (nint i = 0; i < Vector128<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = default;
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Shuffle_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
                args0 = indices;
                args1 = default;
            }


            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Shuffle_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Shuffle_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Shuffle_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Shuffle_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Shuffle_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Shuffle_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Shuffle_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Shuffle_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Shuffle_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Shuffle_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Shuffle_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
                _ = args1;
                return Shuffle(vector, args0);
            }


            /// <inheritdoc cref="IWVectorTraits128.Sum_AcceleratedTypes"/>
            public static TypeCodeFlags Sum_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum(Vector128<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum(Vector128<byte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum(Vector128<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum(Vector128<ushort> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum(Vector128<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum(Vector128<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum(Vector128<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum(Vector128<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Sum(value);
#else
                return Sum_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Sum_Base(Vector128<float> value) {
                ref float p = ref Unsafe.As<Vector128<float>, float>(ref value);
                float rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum_Base(Vector128<double> value) {
                ref double p = ref Unsafe.As<Vector128<double>, double>(ref value);
                double rt = p
                    + Unsafe.Add(ref p, 1)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum_Base(Vector128<sbyte> value) {
                ref sbyte p = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref value);
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
                );
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum_Base(Vector128<byte> value) {
                ref byte p = ref Unsafe.As<Vector128<byte>, byte>(ref value);
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
                );
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum_Base(Vector128<short> value) {
                ref short p = ref Unsafe.As<Vector128<short>, short>(ref value);
                short rt = (short)(p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                );
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum_Base(Vector128<ushort> value) {
                ref ushort p = ref Unsafe.As<Vector128<ushort>, ushort>(ref value);
                ushort rt = (ushort)(p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                    + Unsafe.Add(ref p, 4)
                    + Unsafe.Add(ref p, 5)
                    + Unsafe.Add(ref p, 6)
                    + Unsafe.Add(ref p, 7)
                );
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum_Base(Vector128<int> value) {
                ref int p = ref Unsafe.As<Vector128<int>, int>(ref value);
                int rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum_Base(Vector128<uint> value) {
                ref uint p = ref Unsafe.As<Vector128<uint>, uint>(ref value);
                uint rt = p
                    + Unsafe.Add(ref p, 1)
                    + Unsafe.Add(ref p, 2)
                    + Unsafe.Add(ref p, 3)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum_Base(Vector128<long> value) {
                ref long p = ref Unsafe.As<Vector128<long>, long>(ref value);
                long rt = p
                    + Unsafe.Add(ref p, 1)
                ;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum_Base(Vector128<ulong> value) {
                ref ulong p = ref Unsafe.As<Vector128<ulong>, ulong>(ref value);
                ulong rt = p
                    + Unsafe.Add(ref p, 1)
                ;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{float}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<float> source, out Vector128<double> lower, out Vector128<double> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector128.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{sbyte}, out Vector128{short}, out Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<sbyte> source, out Vector128<short> lower, out Vector128<short> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector128.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{byte}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<byte> source, out Vector128<ushort> lower, out Vector128<ushort> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector128.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{short}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<short> source, out Vector128<int> lower, out Vector128<int> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector128.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<ushort> source, out Vector128<uint> lower, out Vector128<uint> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector128.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector128.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<uint> source, out Vector128<ulong> lower, out Vector128<ulong> upper) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                (lower, upper) = Vector128.Widen(source);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{float}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector128<float> source, out Vector128<double> lower, out Vector128<double> upper) {
                nint cnt = Vector128<double>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref float p = ref Unsafe.As<Vector128<float>, float>(ref source);
                ref double plower = ref Unsafe.As<Vector128<double>, double>(ref lower);
                ref double pupper = ref Unsafe.As<Vector128<double>, double>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{sbyte}, out Vector128{short}, out Vector128{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector128<sbyte> source, out Vector128<short> lower, out Vector128<short> upper) {
                nint cnt = Vector128<short>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref sbyte p = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref source);
                ref short plower = ref Unsafe.As<Vector128<short>, short>(ref lower);
                ref short pupper = ref Unsafe.As<Vector128<short>, short>(ref upper);
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

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{byte}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector128<byte> source, out Vector128<ushort> lower, out Vector128<ushort> upper) {
                nint cnt = Vector128<ushort>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref byte p = ref Unsafe.As<Vector128<byte>, byte>(ref source);
                ref ushort plower = ref Unsafe.As<Vector128<ushort>, ushort>(ref lower);
                ref ushort pupper = ref Unsafe.As<Vector128<ushort>, ushort>(ref upper);
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

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{short}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector128<short> source, out Vector128<int> lower, out Vector128<int> upper) {
                nint cnt = Vector128<int>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref short p = ref Unsafe.As<Vector128<short>, short>(ref source);
                ref int plower = ref Unsafe.As<Vector128<int>, int>(ref lower);
                ref int pupper = ref Unsafe.As<Vector128<int>, int>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{ushort}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector128<ushort> source, out Vector128<uint> lower, out Vector128<uint> upper) {
                nint cnt = Vector128<uint>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref ushort p = ref Unsafe.As<Vector128<ushort>, ushort>(ref source);
                ref uint plower = ref Unsafe.As<Vector128<uint>, uint>(ref lower);
                ref uint pupper = ref Unsafe.As<Vector128<uint>, uint>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref plower, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref plower, 3) = Unsafe.Add(ref p, 3);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
                Unsafe.Add(ref pupper, 2) = Unsafe.Add(ref p, 2);
                Unsafe.Add(ref pupper, 3) = Unsafe.Add(ref p, 3);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
#if UNSAFE
                Widen_Base_Ptr(source, out lower, out upper);
#else
                Widen_Base_Ref(source, out lower, out upper);
#endif // UNSAFE
            }

#if UNSAFE
            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe void Widen_Base_Ptr(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
                int* p = (int*)&source;
                fixed (void* plower0 = &lower, pupper0 = &upper) {
                    long* plower = (long*)plower0;
                    long* pupper = (long*)pupper0;
                    plower[0] = p[0];
                    plower[1] = p[1];
                    pupper[0] = p[2];
                    pupper[1] = p[3];
                }
            }
#endif // UNSAFE

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_Ref(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
                nint cnt = Vector128<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector128<int>, int>(ref source);
                ref long plower = ref Unsafe.As<Vector128<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector128<long>, long>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{int}, out Vector128{long}, out Vector128{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_Ref2(Vector128<int> source, out Vector128<long> lower, out Vector128<long> upper) {
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector128<int>, int>(ref source);
                ref int q = ref Unsafe.Add(ref p, 2);
                ref long plower = ref Unsafe.As<Vector128<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector128<long>, long>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                pupper = q;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref q, 1);
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{uint}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector128<uint> source, out Vector128<ulong> lower, out Vector128<ulong> upper) {
                nint cnt = Vector128<ulong>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref uint p = ref Unsafe.As<Vector128<uint>, uint>(ref source);
                ref ulong plower = ref Unsafe.As<Vector128<ulong>, ulong>(ref lower);
                ref ulong pupper = ref Unsafe.As<Vector128<ulong>, ulong>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                p = ref Unsafe.Add(ref p, cnt);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
