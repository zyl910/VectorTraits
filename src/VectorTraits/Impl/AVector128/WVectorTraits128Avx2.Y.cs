using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128Avx2 {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YClamp_AcceleratedTypes"/>
            public static TypeCodeFlags YClamp_AcceleratedTypes {
                get {
                    return Max_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{float}, Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YClamp(Vector128<float> value, Vector128<float> amin, Vector128<float> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{double}, Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YClamp(Vector128<sbyte> value, Vector128<sbyte> amin, Vector128<sbyte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YClamp(Vector128<byte> value, Vector128<byte> amin, Vector128<byte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YClamp(Vector128<short> value, Vector128<short> amin, Vector128<short> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YClamp(Vector128<ushort> value, Vector128<ushort> amin, Vector128<ushort> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YClamp(Vector128<int> value, Vector128<int> amin, Vector128<int> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YClamp(Vector128<uint> value, Vector128<uint> amin, Vector128<uint> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YClamp(Vector128<long> value, Vector128<long> amin, Vector128<long> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YClamp(Vector128<ulong> value, Vector128<ulong> amin, Vector128<ulong> amax) {
                return Min(Max(amin, value), amax);
            }


            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{short}, Vector128{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YNarrowSaturate(Vector128<short> lower, Vector128<short> upper) {
                Vector128<sbyte> rt = Avx2.PackSignedSaturate(lower, upper);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ushort}, Vector128{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YNarrowSaturate(Vector128<ushort> lower, Vector128<ushort> upper) {
                // Vector128<ushort> amax = Vector128s<ushort>.VMaxByte;
                Vector128<ushort> amax = Vector128.Create((ushort)byte.MaxValue); // .NET5+ has better performance .
                Vector128<byte> rt = Avx2.PackUnsignedSaturate(Avx2.Min(lower, amax).AsInt16(), Avx2.Min(upper, amax).AsInt16());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{int}, Vector128{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YNarrowSaturate(Vector128<int> lower, Vector128<int> upper) {
                Vector128<short> rt = Avx2.PackSignedSaturate(lower, upper);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{uint}, Vector128{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YNarrowSaturate(Vector128<uint> lower, Vector128<uint> upper) {
                //Vector128<uint> amax = Vector128s<uint>.VMaxUInt16;
                Vector128<uint> amax = Vector128.Create((uint)ushort.MaxValue); // .NET5+ has better performance .
                Vector128<ushort> rt = Avx2.PackUnsignedSaturate(Avx2.Min(lower, amax).AsInt32(), Avx2.Min(upper, amax).AsInt32());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{long}, Vector128{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YNarrowSaturate(Vector128<long> lower, Vector128<long> upper) {
                Vector128<long> amin = Vector128Constants.Int64_VMinInt32;
                Vector128<long> amax = Vector128Constants.Int64_VMaxInt32;
                Vector128<long> l = YClamp(lower, amin, amax);
                Vector128<long> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturate(Vector128{ulong}, Vector128{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YNarrowSaturate(Vector128<ulong> lower, Vector128<ulong> upper) {
                //Vector128<ulong> amax = Vector128s<ulong>.VMaxUInt32;
                Vector128<ulong> amax = Vector128Constants.Int64_VMaxUInt32.AsUInt64();
                Vector128<ulong> l = Min(lower, amax);
                Vector128<ulong> u = Min(upper, amax);
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{short}, Vector128{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YNarrowSaturateUnsigned(Vector128<short> lower, Vector128<short> upper) {
                Vector128<byte> rt = Avx2.PackUnsignedSaturate(lower, upper);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{int}, Vector128{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YNarrowSaturateUnsigned(Vector128<int> lower, Vector128<int> upper) {
                Vector128<ushort> rt = Avx2.PackUnsignedSaturate(lower, upper);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YNarrowSaturateUnsigned(Vector128{long}, Vector128{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YNarrowSaturateUnsigned(Vector128<long> lower, Vector128<long> upper) {
                Vector128<long> amin = Vector128<long>.Zero;
                Vector128<long> amax = Vector128Constants.Int64_VMaxUInt32;
                Vector128<ulong> l = YClamp(lower, amin, amax).AsUInt64();
                Vector128<ulong> u = YClamp(upper, amin, amax).AsUInt64();
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YRoundToEven(Vector128<float> value) {
                return Avx.RoundToNearestInteger(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToEven(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToEven(Vector128<double> value) {
                return Avx.RoundToNearestInteger(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YRoundToZero(Vector128<float> value) {
                return Avx.RoundToZero(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YRoundToZero(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YRoundToZero(Vector128<double> value) {
                return Avx.RoundToZero(value);
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
