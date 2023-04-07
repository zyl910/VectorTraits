using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.CompilerServices;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128AdvSimd.Statics;

    /// <summary>
    /// <see cref="Vector128{T}"/> traits - AdvSimd 64bit .
    /// </summary>
    public sealed partial class WVectorTraits128AdvSimdB64 : WVectorTraits128AdvSimdB64Abstract {
        private static readonly WVectorTraits128AdvSimdB64 _instance = new WVectorTraits128AdvSimdB64(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits128AdvSimdB64 Instance {
            get { return _instance; }
        }

#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector128{T}"/> traits.Statics - AdvSimd architecture-64bit.
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
#if NET5_0_OR_GREATER
                rt = AdvSimd.Arm64.IsSupported;
#else
#endif // NET5_0_OR_GREATER
                //if (!noStrict) {
                if (true) {
                    // Must be 64-bit to work
                    rt = rt && (sizeof(long) == IntPtr.Size);
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Requires hardware support AdvSimd!";
#if NETCOREAPP3_0_OR_GREATER
#else
                rt = "Vector128 type is not supported! " + rt;
#endif // NETCOREAPP3_0_OR_GREATER
                //if (!noStrict) {
                if (true) {
                    // Must be 64-bit to work
                    if (!(sizeof(long) == IntPtr.Size)) {
                        rt += string.Format("This process({0}bit) is not 64-bit!", IntPtr.Size * 8);
                    }
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

#if NET5_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Ceiling(Vector128<double> value) {
                return AdvSimd.Arm64.Ceiling(value);
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
                return AdvSimd.Arm64.ConvertToDouble(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToDouble(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> ConvertToDouble(Vector128<ulong> value) {
                return AdvSimd.Arm64.ConvertToDouble(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToInt64(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ConvertToInt64(Vector128<double> value) {
                return AdvSimd.Arm64.ConvertToInt64RoundToEven(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64_AcceleratedTypes"/>
            public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConvertToUInt64(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ConvertToUInt64(Vector128<double> value) {
                return AdvSimd.Arm64.ConvertToUInt64RoundToEven(value);
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
                return ExtractMostSignificantBits(vector.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{double})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<double> vector) {
                return ExtractMostSignificantBits(vector.AsUInt64());
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
                Vector128<byte> m = AdvSimd.ShiftRightLogical(vector, 7); // Get MostSignificantBit .
                m = AdvSimd.ShiftLogical(m, Vector128Constants.SerialRotate8.AsSByte());
                SuperStatics.Widen(m, out Vector128<ushort> l, out Vector128<ushort> h);
                h = AdvSimd.ShiftLeftLogical(h, 8);
                l = AdvSimd.Or(l, h);
                uint rt = Sum(l);
                return rt;
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
                Vector128<ushort> m = AdvSimd.ShiftRightLogical(vector, 15); // Get MostSignificantBit .
                m = AdvSimd.ShiftLogical(m, Vector128s<short>.Serial);
                uint rt = Sum(m);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<int> vector) {
                return ExtractMostSignificantBits(vector.AsUInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<uint> vector) {
                Vector128<uint> m = AdvSimd.ShiftRightLogical(vector, 31); // Get MostSignificantBit .
                m = AdvSimd.ShiftLogical(m, Vector128s<int>.Serial);
                uint rt = Sum(m);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<long> vector) {
                return ExtractMostSignificantBits(vector.AsUInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.ExtractMostSignificantBits(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint ExtractMostSignificantBits(Vector128<ulong> vector) {
                Vector128<ulong> m = AdvSimd.ShiftRightLogical(vector, 63); // Get MostSignificantBit .
                m = AdvSimd.ShiftLogical(m, Vector128s<long>.Serial);
                uint rt = (uint)Sum(m);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Floor(Vector128<double> value) {
                return AdvSimd.Arm64.Floor(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.Narrow_AcceleratedTypes"/>
            public static TypeCodeFlags Narrow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Double
                        | SuperStatics.Narrow_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Narrow(Vector128{double}, Vector128{double})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Narrow(Vector128<double> lower, Vector128<double> upper) {
                return AdvSimd.Arm64.ConvertToSingleUpper(AdvSimd.Arm64.ConvertToSingleLower(lower), upper);
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
                return SuperStatics.Sum(value); // Only need 64-bit ALU.
                //Vector128<float> m = AdvSimd.Arm64.AddPairwise(value, value); // 4 -> 2
                //m = AdvSimd.Arm64.AddPairwise(m, m); // 2 -> 1
                //return AdvSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Sum(Vector128<double> value) {
                Vector128<double> m = AdvSimd.Arm64.AddPairwise(value, value); // 2 -> 1
                return AdvSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Sum(Vector128<sbyte> value) {
                Vector64<sbyte> m = AdvSimd.Arm64.AddAcross(value);
                return AdvSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Sum(Vector128<byte> value) {
                Vector64<byte> m = AdvSimd.Arm64.AddAcross(value);
                return AdvSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Sum(Vector128<short> value) {
                Vector64<short> m = AdvSimd.Arm64.AddAcross(value);
                return AdvSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Sum(Vector128<ushort> value) {
                Vector64<ushort> m = AdvSimd.Arm64.AddAcross(value);
                return AdvSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Sum(Vector128<int> value) {
                Vector64<int> m = AdvSimd.Arm64.AddAcross(value);
                return AdvSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Sum(Vector128<uint> value) {
                Vector64<uint> m = AdvSimd.Arm64.AddAcross(value);
                return AdvSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Sum(Vector128<long> value) {
                Vector128<long> m = AdvSimd.Arm64.AddPairwise(value, value); // 2 -> 1
                return AdvSimd.Extract(m, 0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sum(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Sum(Vector128<ulong> value) {
                Vector128<ulong> m = AdvSimd.Arm64.AddPairwise(value, value); // 2 -> 1
                return AdvSimd.Extract(m, 0);
            }


            /// <inheritdoc cref="IWVectorTraits128.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single
                        | SuperStatics.Widen_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{float}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector128<float> source, out Vector128<double> lower, out Vector128<double> upper) {
                lower = AdvSimd.Arm64.ConvertToDouble(source.GetLower());
                upper = AdvSimd.Arm64.ConvertToDoubleUpper(source);
            }


#endif // NET5_0_OR_GREATER
        }

    }
}
