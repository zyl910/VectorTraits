using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.ExTypes;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128Sse {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup1ToGroup3_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup1ToGroup3(Vector128<float> x, out Vector128<float> result1, out Vector128<float> result2) {
                //var d0 = YGroup1ToGroup3(x.AsUInt32(), out var d1, out var d2);
                //result1 = d1.AsSingle();
                //result2 = d2.AsSingle();
                //return d0.AsSingle();
                return YGroup1ToGroup3_ShuffleXImm(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup1ToGroup3(Vector128<double> x, out Vector128<double> result1, out Vector128<double> result2) {
                //var d0 = YGroup1ToGroup3(x.AsUInt64(), out var d1, out var d2);
                //result1 = d1.AsDouble();
                //result2 = d2.AsDouble();
                //return d0.AsDouble();
                return YGroup1ToGroup3_ShuffleXImm(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup1ToGroup3(Vector128<sbyte> x, out Vector128<sbyte> result1, out Vector128<sbyte> result2) {
                if (Ssse3.IsSupported) {
                    return YGroup1ToGroup3_Shuffle(x, out result1, out result2);
                }
                return YGroup1ToGroup3_Zip(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup1ToGroup3(Vector128<byte> x, out Vector128<byte> result1, out Vector128<byte> result2) {
                if (Ssse3.IsSupported) {
                    return YGroup1ToGroup3_Shuffle(x, out result1, out result2);
                }
                return YGroup1ToGroup3_Zip(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup1ToGroup3(Vector128<short> x, out Vector128<short> result1, out Vector128<short> result2) {
                if (Ssse3.IsSupported) {
                    return YGroup1ToGroup3_Shuffle(x, out result1, out result2);
                }
                return YGroup1ToGroup3_Zip(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup1ToGroup3(Vector128<ushort> x, out Vector128<ushort> result1, out Vector128<ushort> result2) {
                if (Ssse3.IsSupported) {
                    return YGroup1ToGroup3_Shuffle(x, out result1, out result2);
                }
                return YGroup1ToGroup3_Zip(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup1ToGroup3(Vector128<int> x, out Vector128<int> result1, out Vector128<int> result2) {
                return YGroup1ToGroup3_ShuffleXImm(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup1ToGroup3(Vector128<uint> x, out Vector128<uint> result1, out Vector128<uint> result2) {
                return YGroup1ToGroup3_ShuffleXImm(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup1ToGroup3(Vector128<long> x, out Vector128<long> result1, out Vector128<long> result2) {
                return YGroup1ToGroup3_ShuffleXImm(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup1ToGroup3(Vector128<ulong> x, out Vector128<ulong> result1, out Vector128<ulong> result2) {
                return YGroup1ToGroup3_ShuffleXImm(x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup1ToGroup3_Shuffle(Vector128<sbyte> x, out Vector128<sbyte> result1, out Vector128<sbyte> result2) {
                var d0 = YGroup1ToGroup3_Shuffle(x.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup1ToGroup3_Shuffle(Vector128<byte> x, out Vector128<byte> result1, out Vector128<byte> result2) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0 = Vector128Constants.YGroup1ToGroup3_Shuffle_Byte_0;
                var f1 = Vector128Constants.YGroup1ToGroup3_Shuffle_Byte_1;
                var f2 = Vector128Constants.YGroup1ToGroup3_Shuffle_Byte_2;
                var a_0 = Ssse3.Shuffle(x, f0);
                var a_1 = Ssse3.Shuffle(x, f1);
                var a_2 = Ssse3.Shuffle(x, f2);
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup1ToGroup3_Shuffle(Vector128<short> x, out Vector128<short> result1, out Vector128<short> result2) {
                var d0 = YGroup1ToGroup3_Shuffle(x.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup1ToGroup3_Shuffle(Vector128<ushort> x, out Vector128<ushort> result1, out Vector128<ushort> result2) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0 = Vector128Constants.YGroup1ToGroup3_ShuffleOnByte_UInt16_0;
                var f1 = Vector128Constants.YGroup1ToGroup3_ShuffleOnByte_UInt16_1;
                var f2 = Vector128Constants.YGroup1ToGroup3_ShuffleOnByte_UInt16_2;
                var s0 = x.AsByte();
                var a_0 = Ssse3.Shuffle(s0, f0).AsUInt16();
                var a_1 = Ssse3.Shuffle(s0, f1).AsUInt16();
                var a_2 = Ssse3.Shuffle(s0, f2).AsUInt16();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup1ToGroup3_Shuffle(Vector128<int> x, out Vector128<int> result1, out Vector128<int> result2) {
                var d0 = YGroup1ToGroup3_Shuffle(x.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup1ToGroup3_Shuffle(Vector128<uint> x, out Vector128<uint> result1, out Vector128<uint> result2) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0 = Vector128Constants.YGroup1ToGroup3_ShuffleOnByte_UInt32_0;
                var f1 = Vector128Constants.YGroup1ToGroup3_ShuffleOnByte_UInt32_1;
                var f2 = Vector128Constants.YGroup1ToGroup3_ShuffleOnByte_UInt32_2;
                var s0 = x.AsByte();
                var a_0 = Ssse3.Shuffle(s0, f0).AsUInt32();
                var a_1 = Ssse3.Shuffle(s0, f1).AsUInt32();
                var a_2 = Ssse3.Shuffle(s0, f2).AsUInt32();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup1ToGroup3_Shuffle(Vector128<long> x, out Vector128<long> result1, out Vector128<long> result2) {
                var d0 = YGroup1ToGroup3_Shuffle(x.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup1ToGroup3_Shuffle(Vector128<ulong> x, out Vector128<ulong> result1, out Vector128<ulong> result2) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0 = Vector128Constants.YGroup1ToGroup3_ShuffleOnByte_UInt64_0;
                var f2 = Vector128Constants.YGroup1ToGroup3_ShuffleOnByte_UInt64_2;
                var s0 = x.AsByte();
                var a_0 = Ssse3.Shuffle(s0, f0).AsUInt64();
                var a_1 = x;
                var a_2 = Ssse3.Shuffle(s0, f2).AsUInt64();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup1ToGroup3_ShuffleXImm(Vector128<float> x, out Vector128<float> result1, out Vector128<float> result2) {
                Vector128<float> a_0, a_1, a_2;
                // 0 _x_ x0 x1 x2 x3
                // 1 a_0 x0 x0 x0 x1 a_1 x1 x1 x2 x2 a_2 x2 x3 x3 x3
                a_0 = Sse.Shuffle(x, x, (byte)ShuffleControlG4.XXXY);
                a_1 = Sse.Shuffle(x, x, (byte)ShuffleControlG4.YYZZ);
                a_2 = Sse.Shuffle(x, x, (byte)ShuffleControlG4.ZWWW);
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup1ToGroup3_ShuffleXImm(Vector128<double> x, out Vector128<double> result1, out Vector128<double> result2) {
                Vector128<double> a_0, a_1, a_2;
                // 1 _x_ x0 x1
                // 2 a_0 x0 x0 a_1 x0 x1 a_2 x1 x1
                a_0 = Sse2.Shuffle(x, x, (byte)ShuffleControlG2.XX);
                a_1 = x;
                a_2 = Sse2.Shuffle(x, x, (byte)ShuffleControlG2.YY);
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup1ToGroup3_ShuffleXImm(Vector128<int> x, out Vector128<int> result1, out Vector128<int> result2) {
                var d0 = YGroup1ToGroup3_ShuffleXImm(x.AsSingle(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup1ToGroup3_ShuffleXImm(Vector128<uint> x, out Vector128<uint> result1, out Vector128<uint> result2) {
                var d0 = YGroup1ToGroup3_ShuffleXImm(x.AsSingle(), out var d1, out var d2);
                result1 = d1.AsUInt32();
                result2 = d2.AsUInt32();
                return d0.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup1ToGroup3_ShuffleXImm(Vector128<long> x, out Vector128<long> result1, out Vector128<long> result2) {
                var d0 = YGroup1ToGroup3_ShuffleXImm(x.AsDouble(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup1ToGroup3_ShuffleXImm(Vector128<ulong> x, out Vector128<ulong> result1, out Vector128<ulong> result2) {
                var d0 = YGroup1ToGroup3_ShuffleXImm(x.AsDouble(), out var d1, out var d2);
                result1 = d1.AsUInt64();
                result2 = d2.AsUInt64();
                return d0.AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup1ToGroup3_Zip(Vector128<sbyte> x, out Vector128<sbyte> result1, out Vector128<sbyte> result2) {
                var d0 = YGroup1ToGroup3_Zip(x.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup1ToGroup3_Zip(Vector128<byte> x, out Vector128<byte> result1, out Vector128<byte> result2) {
                return YGroup3Zip(x, x, x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup1ToGroup3_Zip(Vector128<short> x, out Vector128<short> result1, out Vector128<short> result2) {
                var d0 = YGroup1ToGroup3_Zip(x.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup1ToGroup3_Zip(Vector128<ushort> x, out Vector128<ushort> result1, out Vector128<ushort> result2) {
                return YGroup3Zip(x, x, x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup1ToGroup3_Zip(Vector128<int> x, out Vector128<int> result1, out Vector128<int> result2) {
                var d0 = YGroup1ToGroup3_Zip(x.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup1ToGroup3_Zip(Vector128<uint> x, out Vector128<uint> result1, out Vector128<uint> result2) {
                return YGroup3Zip(x, x, x, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup1ToGroup3_Zip(Vector128<long> x, out Vector128<long> result1, out Vector128<long> result2) {
                var d0 = YGroup1ToGroup3_Zip(x.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup3(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup1ToGroup3_Zip(Vector128<ulong> x, out Vector128<ulong> result1, out Vector128<ulong> result2) {
                return YGroup3Zip(x, x, x, out result1, out result2);
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup1ToGroup4_AcceleratedTypes {
                get {
                    return YGroup4Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup1ToGroup4(Vector128<float> x, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup1ToGroup4(Vector128<double> x, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup1ToGroup4(Vector128<sbyte> x, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup1ToGroup4(Vector128<byte> x, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup1ToGroup4(Vector128<short> x, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup1ToGroup4(Vector128<ushort> x, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup1ToGroup4(Vector128<int> x, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup1ToGroup4(Vector128<uint> x, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup1ToGroup4(Vector128<long> x, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup1ToGroup4(Vector128<ulong> x, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3) {
                return YGroup4Zip(x, x, x, x, out result1, out result2, out result3);
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup1ToGroup4WithW_AcceleratedTypes {
                get {
                    return YGroup4Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup1ToGroup4WithW(Vector128<float> x, Vector128<float> w, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup1ToGroup4WithW(Vector128<double> x, Vector128<double> w, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup1ToGroup4WithW(Vector128<sbyte> x, Vector128<sbyte> w, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup1ToGroup4WithW(Vector128<byte> x, Vector128<byte> w, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup1ToGroup4WithW(Vector128<short> x, Vector128<short> w, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup1ToGroup4WithW(Vector128<ushort> x, Vector128<ushort> w, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup1ToGroup4WithW(Vector128<int> x, Vector128<int> w, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup1ToGroup4WithW(Vector128<uint> x, Vector128<uint> w, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup1ToGroup4WithW(Vector128<long> x, Vector128<long> w, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup1ToGroup4WithW(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup1ToGroup4WithW(Vector128<ulong> x, Vector128<ulong> w, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3) {
                return YGroup4Zip(x, x, x, w, out result1, out result2, out result3);
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Transpose_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Transpose(Vector128<float> data0, Vector128<float> data1, out Vector128<float> result1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Transpose_ShuffleX(data0, data1, out result1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Transpose_ShuffleXImm(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Transpose(Vector128<double> data0, Vector128<double> data1, out Vector128<double> result1) {
                return YGroup2Transpose_ShuffleXImm(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Transpose(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> result1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2Transpose_ShuffleX(data0, data1, out result1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Transpose_Shift(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Transpose(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> result1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2Transpose_ShuffleX(data0, data1, out result1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Transpose_Shift(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Transpose(Vector128<short> data0, Vector128<short> data1, out Vector128<short> result1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2Transpose_ShuffleX(data0, data1, out result1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Transpose_ShuffleXImm(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Transpose(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> result1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2Transpose_ShuffleX(data0, data1, out result1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Transpose_ShuffleXImm(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Transpose(Vector128<int> data0, Vector128<int> data1, out Vector128<int> result1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Transpose_ShuffleX(data0, data1, out result1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Transpose_ShuffleXImm(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Transpose(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> result1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Transpose_ShuffleX(data0, data1, out result1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Transpose_ShuffleXImm(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Transpose(Vector128<long> data0, Vector128<long> data1, out Vector128<long> result1) {
                return YGroup2Transpose_ShuffleXImm(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Transpose(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> result1) {
                return YGroup2Transpose_ShuffleXImm(data0, data1, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Transpose_Shift(Vector128<float> data0, Vector128<float> data1, out Vector128<float> result1) {
                var d0 = YGroup2Transpose_Shift(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                result1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Transpose_Shift(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> result1) {
                var d0 = YGroup2Transpose_Shift(data0.AsByte(), data1.AsByte(), out var d1);
                result1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Transpose_Shift(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> result1) {
                const int L = 8;
                Vector128<ushort> a_0, a_1, b_0, b_1, c_0, c_1;
                Vector128<ushort> mask = Vector128.Create((ushort)0x00FFU);
                a_0 = data0.AsUInt16();
                a_1 = data1.AsUInt16();
                b_1 = Sse2.ShiftLeftLogical(a_1, L);
                b_0 = Sse2.ShiftRightLogical(a_0, L);
                c_0 = Sse2.Or(Sse2.And(mask, a_0), b_1);
                c_1 = Sse2.Or(Sse2.AndNot(mask, a_1), b_0);
                result1 = c_1.AsByte();
                return c_0.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Transpose_Shift(Vector128<short> data0, Vector128<short> data1, out Vector128<short> result1) {
                var d0 = YGroup2Transpose_Shift(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                result1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Transpose_Shift(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> result1) {
                const int L = 16;
                Vector128<uint> a_0, a_1, b_0, b_1, c_0, c_1;
                Vector128<uint> mask = Vector128.Create((uint)0x0000FFFFU);
                a_0 = data0.AsUInt32();
                a_1 = data1.AsUInt32();
                b_1 = Sse2.ShiftLeftLogical(a_1, L);
                b_0 = Sse2.ShiftRightLogical(a_0, L);
                c_0 = Sse2.Or(Sse2.And(mask, a_0), b_1);
                c_1 = Sse2.Or(Sse2.AndNot(mask, a_1), b_0);
                result1 = c_1.AsUInt16();
                return c_0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Transpose_Shift(Vector128<int> data0, Vector128<int> data1, out Vector128<int> result1) {
                var d0 = YGroup2Transpose_Shift(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                result1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Transpose_Shift(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> result1) {
                const int L = 32;
                Vector128<ulong> a_0, a_1, b_0, b_1, c_0, c_1;
                Vector128<ulong> mask = Vector128.Create((ulong)0x00000000FFFFFFFFUL);
                a_0 = data0.AsUInt64();
                a_1 = data1.AsUInt64();
                b_1 = Sse2.ShiftLeftLogical(a_1, L);
                b_0 = Sse2.ShiftRightLogical(a_0, L);
                c_0 = Sse2.Or(Sse2.And(mask, a_0), b_1);
                c_1 = Sse2.Or(Sse2.AndNot(mask, a_1), b_0);
                result1 = c_1.AsUInt32();
                return c_0.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Transpose_Shuffle(Vector128<float> data0, Vector128<float> data1, out Vector128<float> result1) {
                var d0 = YGroup2Transpose_Shuffle(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                result1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Transpose_Shuffle(Vector128<double> data0, Vector128<double> data1, out Vector128<double> result1) {
                var d0 = YGroup2Transpose_Shuffle(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                result1 = d1.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Transpose_Shuffle(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> result1) {
                var d0 = YGroup2Transpose_Shuffle(data0.AsByte(), data1.AsByte(), out var d1);
                result1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Transpose_Shuffle(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> result1) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup2Transpose_Shuffle_Byte_0A;
                var f0B = Vector128Constants.YGroup2Transpose_Shuffle_Byte_0B;
                var f1A = Vector128Constants.YGroup2Transpose_Shuffle_Byte_1A;
                var f1B = Vector128Constants.YGroup2Transpose_Shuffle_Byte_1B;
                var a_0 = Sse2.Or(Ssse3.Shuffle(data0, f0A), Ssse3.Shuffle(data1, f0B));
                var a_1 = Sse2.Or(Ssse3.Shuffle(data0, f1A), Ssse3.Shuffle(data1, f1B));
                result1 = a_1;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Transpose_Shuffle(Vector128<short> data0, Vector128<short> data1, out Vector128<short> result1) {
                var d0 = YGroup2Transpose_Shuffle(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                result1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Transpose_Shuffle(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> result1) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup2Transpose_ShuffleOnByte_UInt16_0A;
                var f0B = Vector128Constants.YGroup2Transpose_ShuffleOnByte_UInt16_0B;
                var f1A = Vector128Constants.YGroup2Transpose_ShuffleOnByte_UInt16_1A;
                var f1B = Vector128Constants.YGroup2Transpose_ShuffleOnByte_UInt16_1B;
                var a_0 = Sse2.Or(Ssse3.Shuffle(data0.AsByte(), f0A), Ssse3.Shuffle(data1.AsByte(), f0B)).AsUInt16();
                var a_1 = Sse2.Or(Ssse3.Shuffle(data0.AsByte(), f1A), Ssse3.Shuffle(data1.AsByte(), f1B)).AsUInt16();
                result1 = a_1;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Transpose_Shuffle(Vector128<int> data0, Vector128<int> data1, out Vector128<int> result1) {
                var d0 = YGroup2Transpose_Shuffle(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                result1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Transpose_Shuffle(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> result1) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup2Transpose_ShuffleOnByte_UInt32_0A;
                var f0B = Vector128Constants.YGroup2Transpose_ShuffleOnByte_UInt32_0B;
                var f1A = Vector128Constants.YGroup2Transpose_ShuffleOnByte_UInt32_1A;
                var f1B = Vector128Constants.YGroup2Transpose_ShuffleOnByte_UInt32_1B;
                var a_0 = Sse2.Or(Ssse3.Shuffle(data0.AsByte(), f0A), Ssse3.Shuffle(data1.AsByte(), f0B)).AsUInt32();
                var a_1 = Sse2.Or(Ssse3.Shuffle(data0.AsByte(), f1A), Ssse3.Shuffle(data1.AsByte(), f1B)).AsUInt32();
                result1 = a_1;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Transpose_Shuffle(Vector128<long> data0, Vector128<long> data1, out Vector128<long> result1) {
                var d0 = YGroup2Transpose_Shuffle(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                result1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Transpose_Shuffle(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> result1) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup2Transpose_ShuffleOnByte_UInt64_0A;
                var f0B = Vector128Constants.YGroup2Transpose_ShuffleOnByte_UInt64_0B;
                var f1A = Vector128Constants.YGroup2Transpose_ShuffleOnByte_UInt64_1A;
                var f1B = Vector128Constants.YGroup2Transpose_ShuffleOnByte_UInt64_1B;
                var a_0 = Sse2.Or(Ssse3.Shuffle(data0.AsByte(), f0A), Ssse3.Shuffle(data1.AsByte(), f0B)).AsUInt64();
                var a_1 = Sse2.Or(Ssse3.Shuffle(data0.AsByte(), f1A), Ssse3.Shuffle(data1.AsByte(), f1B)).AsUInt64();
                result1 = a_1;
                return a_0;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Transpose_ShuffleX(Vector128<float> data0, Vector128<float> data1, out Vector128<float> rt1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar4x32x2(data0, Vector128Constants.YGroup2Transpose_Shuffle_UInt32_0.AsInt32(), data1);
                rt1 = Avx512F.VL.PermuteVar4x32x2(data0, Vector128Constants.YGroup2Transpose_Shuffle_UInt32_1.AsInt32(), data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Transpose_ShuffleX(Vector128<double> data0, Vector128<double> data1, out Vector128<double> rt1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar2x64x2(data0, Vector128Constants.YGroup2Transpose_Shuffle_UInt64_0.AsInt64(), data1);
                rt1 = Avx512F.VL.PermuteVar2x64x2(data0, Vector128Constants.YGroup2Transpose_Shuffle_UInt64_1.AsInt64(), data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Transpose_ShuffleX(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> rt1) {
                var d0 = YGroup2Transpose_ShuffleX(data0.AsByte(), data1.AsByte(), out var d1);
                rt1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Transpose_ShuffleX(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> rt1) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                var rt0 = Avx512Vbmi.VL.PermuteVar16x8x2(data0, Vector128Constants.YGroup2Transpose_Shuffle_Byte_0, data1);
                rt1 = Avx512Vbmi.VL.PermuteVar16x8x2(data0, Vector128Constants.YGroup2Transpose_Shuffle_Byte_1, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Transpose_ShuffleX(Vector128<short> data0, Vector128<short> data1, out Vector128<short> rt1) {
                var d0 = YGroup2Transpose_ShuffleX(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                rt1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Transpose_ShuffleX(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> rt1) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                var rt0 = Avx512BW.VL.PermuteVar8x16x2(data0, Vector128Constants.YGroup2Transpose_Shuffle_UInt16_0, data1);
                rt1 = Avx512BW.VL.PermuteVar8x16x2(data0, Vector128Constants.YGroup2Transpose_Shuffle_UInt16_1, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Transpose_ShuffleX(Vector128<int> data0, Vector128<int> data1, out Vector128<int> rt1) {
                var d0 = YGroup2Transpose_ShuffleX(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                rt1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Transpose_ShuffleX(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> rt1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar4x32x2(data0, Vector128Constants.YGroup2Transpose_Shuffle_UInt32_0, data1);
                rt1 = Avx512F.VL.PermuteVar4x32x2(data0, Vector128Constants.YGroup2Transpose_Shuffle_UInt32_1, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Transpose_ShuffleX(Vector128<long> data0, Vector128<long> data1, out Vector128<long> rt1) {
                var d0 = YGroup2Transpose_ShuffleX(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                rt1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Transpose_ShuffleX(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> rt1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar2x64x2(data0, Vector128Constants.YGroup2Transpose_Shuffle_UInt64_0, data1);
                rt1 = Avx512F.VL.PermuteVar2x64x2(data0, Vector128Constants.YGroup2Transpose_Shuffle_UInt64_1, data1);
                return rt0;
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Transpose_ShuffleXImm(Vector128<float> data0, Vector128<float> data1, out Vector128<float> result1) {
                Vector128<float> a_0, a_1, b_0, b_1;
                // 0 data0 x0 x1 x2 x3 data1 y0 y1 y2 y3
                // 1 a_0 x0 x2 y0 y2 a_1 x1 x3 y1 y3
                a_0 = Sse.Shuffle(data0, data1, (byte)ShuffleControlG4.XZXZ);
                a_1 = Sse.Shuffle(data0, data1, (byte)ShuffleControlG4.YWYW);
                // 2 b_0 x0 y0 x2 y2 b_1 x1 y1 x3 y3
                b_0 = Sse.Shuffle(a_0, a_0, (byte)ShuffleControlG4.XZYW);
                b_1 = Sse.Shuffle(a_1, a_1, (byte)ShuffleControlG4.XZYW);
                result1 = b_1;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Transpose_ShuffleXImm(Vector128<double> data0, Vector128<double> data1, out Vector128<double> result1) {
                Vector128<double> a0, a1;
                a0 = Sse2.UnpackLow(data0, data1);
                a1 = Sse2.UnpackHigh(data0, data1);
                result1 = a1;
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Transpose_ShuffleXImm(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> result1) {
                var d0 = YGroup2Transpose_ShuffleXImm(data0.AsByte(), data1.AsByte(), out var d1);
                result1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Transpose_ShuffleXImm(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> result1) {
                Vector128<byte> a_0, a_1;
                Vector128<ushort> b_0, b_1;
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                // 0 data0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 data1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15
                // 1 a_0 x0 y0 x1 y1 x2 y2 x3 y3 x4 y4 x5 y5 x6 y6 x7 y7 a_1 x8 y8 x9 y9 x10 y10 x11 y11 x12 y12 x13 y13 x14 y14 x15 y15
                a_0 = Sse2.UnpackLow(data0, data1);
                a_1 = Sse2.UnpackHigh(data0, data1);
                // 2 b_0 x0 y0 x2 y2 x1 y1 x3 y3 x4 y4 x6 y6 x5 y5 x7 y7 b_1 x8 y8 x10 y10 x9 y9 x11 y11 x12 y12 x14 y14 x13 y13 x15 y15
                b_0 = Sse2.ShuffleLow(a_0.AsUInt16(), ctl);
                b_1 = Sse2.ShuffleLow(a_1.AsUInt16(), ctl);
                b_0 = Sse2.ShuffleHigh(b_0, ctl);
                b_1 = Sse2.ShuffleHigh(b_1, ctl);
                // 3 a_1 x0 y0 x2 y2 x4 y4 x6 y6 x8 y8 x10 y10 x12 y12 x14 y14 a_1 x1 y1 x3 y3 x5 y5 x7 y7 x9 y9 x11 y11 x13 y13 x15 y15
                a_0 = Sse.Shuffle(b_0.AsSingle(), b_1.AsSingle(), (byte)ShuffleControlG4.XZXZ).AsByte();
                a_1 = Sse.Shuffle(b_0.AsSingle(), b_1.AsSingle(), (byte)ShuffleControlG4.YWYW).AsByte();
                result1 = a_1;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Transpose_ShuffleXImm(Vector128<short> data0, Vector128<short> data1, out Vector128<short> result1) {
                var d0 = YGroup2Transpose_ShuffleXImm(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                result1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Transpose_ShuffleXImm(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> result1) {
                Vector128<ushort> a_0, a_1, b_0, b_1;
                // 0 data0 x0 x1 x2 x3 x4 x5 x6 x7 data1 y0 y1 y2 y3 y4 y5 y6 y7
                // 1 a_0 x0 y0 x1 y1 x2 y2 x3 y3 a_1 x4 y4 x5 y5 x6 y6 x7 y7
                a_0 = Sse2.UnpackLow(data0, data1);
                a_1 = Sse2.UnpackHigh(data0, data1);
                // 2 b_0 x0 y0 x2 y2 x4 y4 x6 y6 b_1 x1 y1 x3 y3 x5 y5 x7 y7
                b_0 = Sse.Shuffle(a_0.AsSingle(), a_1.AsSingle(), (byte)ShuffleControlG4.XZXZ).AsUInt16();
                b_1 = Sse.Shuffle(a_0.AsSingle(), a_1.AsSingle(), (byte)ShuffleControlG4.YWYW).AsUInt16();
                result1 = b_1;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Transpose_ShuffleXImm(Vector128<int> data0, Vector128<int> data1, out Vector128<int> result1) {
                var d0 = YGroup2Transpose_ShuffleXImm(data0.AsSingle(), data1.AsSingle(), out var d1);
                result1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Transpose_ShuffleXImm(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> result1) {
                var d0 = YGroup2Transpose_ShuffleXImm(data0.AsSingle(), data1.AsSingle(), out var d1);
                result1 = d1.AsUInt32();
                return d0.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Transpose_ShuffleXImm(Vector128<long> data0, Vector128<long> data1, out Vector128<long> result1) {
                var d0 = YGroup2Transpose_ShuffleXImm(data0.AsDouble(), data1.AsDouble(), out var d1);
                result1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Transpose(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Transpose_ShuffleXImm(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> result1) {
                var d0 = YGroup2Transpose_ShuffleXImm(data0.AsDouble(), data1.AsDouble(), out var d1);
                result1 = d1.AsUInt64();
                return d0.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Unzip(Vector128<float> data0, Vector128<float> data1, out Vector128<float> y) {
                return YGroup2Unzip_ShuffleXImm(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Unzip(Vector128<double> data0, Vector128<double> data1, out Vector128<double> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Unpack(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> y) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Narrow(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Unzip(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> y) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Narrow(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Unzip(Vector128<short> data0, Vector128<short> data1, out Vector128<short> y) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_ShuffleXImm(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Unzip(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> y) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2Unzip_Permute(data0, data1, out y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_ShuffleXImm(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Unzip(Vector128<int> data0, Vector128<int> data1, out Vector128<int> y) {
                return YGroup2Unzip_ShuffleXImm(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Unzip(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> y) {
                return YGroup2Unzip_ShuffleXImm(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Unzip(Vector128<long> data0, Vector128<long> data1, out Vector128<long> y) {
#if NET8_0_OR_GREATER
                // _Unpack > _Permute
                //if (Avx512F.VL.IsSupported) {
                //    return YGroup2Unzip_Permute(data0, data1, out y);
                //}
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Unpack(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Unzip(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> y) {
#if NET8_0_OR_GREATER
                //if (Avx512F.VL.IsSupported) {
                //    return YGroup2Unzip_Permute(data0, data1, out y);
                //}
#endif // NET8_0_OR_GREATER
                return YGroup2Unzip_Unpack(data0, data1, out y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Unzip_Narrow(Vector128<float> data0, Vector128<float> data1, out Vector128<float> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Unzip_Narrow(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Unzip_Narrow(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> y) {
                const int L = 8;
                Vector128<byte> rt0, rt1;
                Vector128<ushort> temp0 = data0.AsUInt16();
                Vector128<ushort> temp1 = data1.AsUInt16();
                rt0 = Narrow(temp0, temp1);
                temp0 = Sse2.ShiftRightLogical(temp0, L);
                temp1 = Sse2.ShiftRightLogical(temp1, L);
                rt1 = Narrow(temp0, temp1);
                y = rt1;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Unzip_Narrow(Vector128<short> data0, Vector128<short> data1, out Vector128<short> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Unzip_Narrow(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> y) {
                const int L = 16;
                Vector128<ushort> rt0, rt1;
                Vector128<uint> temp0 = data0.AsUInt32();
                Vector128<uint> temp1 = data1.AsUInt32();
                // Format: Code; //Latency, Throughput(references IceLake)
                rt0 = Narrow(temp0, temp1); // 8, 2.66
                temp0 = Sse2.ShiftRightLogical(temp0, L); // 1,0.5
                temp1 = Sse2.ShiftRightLogical(temp1, L); // 1,0.5
                rt1 = Narrow(temp0, temp1); // 8, 2.66
                y = rt1;
                return rt0; //total latency: 18, total throughput CPI: 6.33
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Unzip_Narrow(Vector128<int> data0, Vector128<int> data1, out Vector128<int> y) {
                var d0 = YGroup2Unzip_Narrow(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Unzip_Narrow(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> y) {
                const int L = 32;
                Vector128<uint> rt0, rt1;
                Vector128<ulong> temp0 = data0.AsUInt64();
                Vector128<ulong> temp1 = data1.AsUInt64();
                rt0 = Narrow(temp0, temp1);
                temp0 = Sse2.ShiftRightLogical(temp0, L);
                temp1 = Sse2.ShiftRightLogical(temp1, L);
                rt1 = Narrow(temp0, temp1);
                y = rt1;
                return rt0;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Unzip_Permute(Vector128<float> data0, Vector128<float> data1, out Vector128<float> rt1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar4x32x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt32_X.AsInt32(), data1);
                rt1 = Avx512F.VL.PermuteVar4x32x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt32_Y.AsInt32(), data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Unzip_Permute(Vector128<double> data0, Vector128<double> data1, out Vector128<double> rt1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar2x64x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt64_X.AsInt64(), data1);
                rt1 = Avx512F.VL.PermuteVar2x64x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt64_Y.AsInt64(), data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Unzip_Permute(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> rt1) {
                var d0 = YGroup2Unzip_Permute(data0.AsByte(), data1.AsByte(), out var d1);
                rt1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Unzip_Permute(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> rt1) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                var rt0 = Avx512Vbmi.VL.PermuteVar16x8x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_X, data1);
                rt1 = Avx512Vbmi.VL.PermuteVar16x8x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_Y, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Unzip_Permute(Vector128<short> data0, Vector128<short> data1, out Vector128<short> rt1) {
                var d0 = YGroup2Unzip_Permute(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                rt1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Unzip_Permute(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> rt1) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                var rt0 = Avx512BW.VL.PermuteVar8x16x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt16_X, data1);
                rt1 = Avx512BW.VL.PermuteVar8x16x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt16_Y, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Unzip_Permute(Vector128<int> data0, Vector128<int> data1, out Vector128<int> rt1) {
                var d0 = YGroup2Unzip_Permute(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                rt1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Unzip_Permute(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> rt1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar4x32x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt32_X, data1);
                rt1 = Avx512F.VL.PermuteVar4x32x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt32_Y, data1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Unzip_Permute(Vector128<long> data0, Vector128<long> data1, out Vector128<long> rt1) {
                var d0 = YGroup2Unzip_Permute(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                rt1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Unzip_Permute(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> rt1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var rt0 = Avx512F.VL.PermuteVar2x64x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt64_X, data1);
                rt1 = Avx512F.VL.PermuteVar2x64x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt64_Y, data1);
                return rt0;
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Unzip_ShuffleXImm(Vector128<float> data0, Vector128<float> data1, out Vector128<float> y) {
                Vector128<float> a0, a1;
                a0 = Sse.Shuffle(data0, data1, (byte)ShuffleControlG4.XZXZ);
                a1 = Sse.Shuffle(data0, data1, (byte)ShuffleControlG4.YWYW);
                y = a1;
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Unzip_ShuffleXImm(Vector128<short> data0, Vector128<short> data1, out Vector128<short> y) {
                var d0 = YGroup2Unzip_ShuffleXImm(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Unzip_ShuffleXImm(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> y) {
                Vector128<ushort> a0, a1, b0, b1;
                const byte ctl = (byte)ShuffleControlG4.XZYW;
                // Format: Code; //Latency, Throughput(references IceLake)
                // 0 data0 x0 y0 x1 y1 x2 y2 x3 y3 data1 x4 y4 x5 y5 x6 y6 x7 y7
                // 1 a_0 x0 x1 y0 y1 x2 x3 y2 y3 a_1 x4 x5 y4 y5 x6 x7 y6 y7
                a0 = Sse2.ShuffleLow(data0, ctl); // 1,0.5
                a1 = Sse2.ShuffleLow(data1, ctl); // 1,0.5
                a0 = Sse2.ShuffleHigh(a0, ctl); // 1,0.5
                a1 = Sse2.ShuffleHigh(a1, ctl); // 1,0.5
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 b_1 y0 y1 y2 y3 y4 y5 y6 y7
                b0 = Sse.Shuffle(a0.AsSingle(), a1.AsSingle(), (byte)ShuffleControlG4.XZXZ).AsUInt16(); // 1,0.5
                b1 = Sse.Shuffle(a0.AsSingle(), a1.AsSingle(), (byte)ShuffleControlG4.YWYW).AsUInt16(); // 1,0.5
                y = b1;
                return b0; //total latency: 6, total throughput CPI: 3
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Unzip_ShuffleXImm(Vector128<int> data0, Vector128<int> data1, out Vector128<int> y) {
                var d0 = YGroup2Unzip_ShuffleXImm(data0.AsSingle(), data1.AsSingle(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Unzip_ShuffleXImm(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> y) {
                var d0 = YGroup2Unzip_ShuffleXImm(data0.AsSingle(), data1.AsSingle(), out var d1);
                y = d1.AsUInt32();
                return d0.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Unzip_Unpack(Vector128<float> data0, Vector128<float> data1, out Vector128<float> y) {
                Vector128<float> a0, a1, b0, b1;
                a0 = Sse.UnpackLow(data0, data1);
                a1 = Sse.UnpackHigh(data0, data1);
                b0 = Sse.UnpackLow(a0, a1);
                b1 = Sse.UnpackHigh(a0, a1);
                y = b1;
                return b0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Unzip_Unpack(Vector128<double> data0, Vector128<double> data1, out Vector128<double> y) {
                Vector128<double> a0, a1;
                a0 = Sse2.UnpackLow(data0, data1);
                a1 = Sse2.UnpackHigh(data0, data1);
                y = a1;
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Unzip_Unpack(Vector128<sbyte> data0, Vector128<sbyte> data1, out Vector128<sbyte> y) {
                var d0 = YGroup2Unzip_Unpack(data0.AsByte(), data1.AsByte(), out var d1);
                y = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Unzip_Unpack(Vector128<byte> data0, Vector128<byte> data1, out Vector128<byte> y) {
                Vector128<byte> a0, a1, b0, b1;
                a0 = Sse2.UnpackLow(data0, data1);
                a1 = Sse2.UnpackHigh(data0, data1);
                b0 = Sse2.UnpackLow(a0, a1);
                b1 = Sse2.UnpackHigh(a0, a1);
                a0 = Sse2.UnpackLow(b0, b1);
                a1 = Sse2.UnpackHigh(b0, b1);
                b0 = Sse2.UnpackLow(a0, a1);
                b1 = Sse2.UnpackHigh(a0, a1);
                y = b1;
                return b0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Unzip_Unpack(Vector128<short> data0, Vector128<short> data1, out Vector128<short> y) {
                var d0 = YGroup2Unzip_Unpack(data0.AsUInt16(), data1.AsUInt16(), out var d1);
                y = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Unzip_Unpack(Vector128<ushort> data0, Vector128<ushort> data1, out Vector128<ushort> y) {
                Vector128<ushort> a0, a1, b0, b1;
                // Format: Code; //Latency, Throughput(references IceLake)
                a0 = Sse2.UnpackLow(data0, data1);  // 1,0.5
                a1 = Sse2.UnpackHigh(data0, data1); // 1,0.5
                b0 = Sse2.UnpackLow(a0, a1);  // 1,0.5
                b1 = Sse2.UnpackHigh(a0, a1); // 1,0.5
                a0 = Sse2.UnpackLow(b0, b1);  // 1,0.5
                a1 = Sse2.UnpackHigh(b0, b1); // 1,0.5
                y = a1;
                return a0; //total latency: 6, total throughput CPI: 3
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Unzip_Unpack(Vector128<int> data0, Vector128<int> data1, out Vector128<int> y) {
                var d0 = YGroup2Unzip_Unpack(data0.AsUInt32(), data1.AsUInt32(), out var d1);
                y = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Unzip_Unpack(Vector128<uint> data0, Vector128<uint> data1, out Vector128<uint> y) {
                Vector128<uint> a0, a1, b0, b1;
                a0 = Sse2.UnpackLow(data0, data1);
                a1 = Sse2.UnpackHigh(data0, data1);
                b0 = Sse2.UnpackLow(a0, a1);
                b1 = Sse2.UnpackHigh(a0, a1);
                y = b1;
                return b0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Unzip_Unpack(Vector128<long> data0, Vector128<long> data1, out Vector128<long> y) {
                var d0 = YGroup2Unzip_Unpack(data0.AsUInt64(), data1.AsUInt64(), out var d1);
                y = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Unzip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Unzip_Unpack(Vector128<ulong> data0, Vector128<ulong> data1, out Vector128<ulong> y) {
                Vector128<ulong> a0, a1;
                a0 = Sse2.UnpackLow(data0, data1);
                a1 = Sse2.UnpackHigh(data0, data1);
                y = a1;
                return a0;
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipEven(Vector128<float> data0, Vector128<float> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2UnzipEven(Vector128<double> data0, Vector128<double> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipEven(Vector128<sbyte> data0, Vector128<sbyte> data1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipEven(Vector128<byte> data0, Vector128<byte> data1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipEven(Vector128<short> data0, Vector128<short> data1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipEven(Vector128<ushort> data0, Vector128<ushort> data1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipEven(Vector128<int> data0, Vector128<int> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipEven(Vector128<uint> data0, Vector128<uint> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipEven_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipEven_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2UnzipEven(Vector128<long> data0, Vector128<long> data1) {
                return YGroup2UnzipEven_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2UnzipEven(Vector128<ulong> data0, Vector128<ulong> data1) {
                return YGroup2UnzipEven_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipEven_Narrow(Vector128<float> data0, Vector128<float> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipEven_Narrow(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipEven_Narrow(Vector128<byte> data0, Vector128<byte> data1) {
                Vector128<byte> rt0;
                Vector128<ushort> temp0 = data0.AsUInt16();
                Vector128<ushort> temp1 = data1.AsUInt16();
                rt0 = Narrow(temp0, temp1);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipEven_Narrow(Vector128<short> data0, Vector128<short> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipEven_Narrow(Vector128<ushort> data0, Vector128<ushort> data1) {
                Vector128<ushort> rt0;
                Vector128<uint> temp0 = data0.AsUInt32();
                Vector128<uint> temp1 = data1.AsUInt32();
                rt0 = Narrow(temp0, temp1); // 8, 2.66
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipEven_Narrow(Vector128<int> data0, Vector128<int> data1) {
                return YGroup2UnzipEven_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipEven_Narrow(Vector128<uint> data0, Vector128<uint> data1) {
                Vector128<uint> rt0;
                Vector128<ulong> temp0 = data0.AsUInt64();
                Vector128<ulong> temp1 = data1.AsUInt64();
                rt0 = Narrow(temp0, temp1);
                return rt0;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipEven_Permute(Vector128<float> data0, Vector128<float> data1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x32x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt32_X.AsInt32(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2UnzipEven_Permute(Vector128<double> data0, Vector128<double> data1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar2x64x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt64_X.AsInt64(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipEven_Permute(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                return YGroup2UnzipEven_Permute(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipEven_Permute(Vector128<byte> data0, Vector128<byte> data1) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                return Avx512Vbmi.VL.PermuteVar16x8x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_X, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipEven_Permute(Vector128<short> data0, Vector128<short> data1) {
                return YGroup2UnzipEven_Permute(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipEven_Permute(Vector128<ushort> data0, Vector128<ushort> data1) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                return Avx512BW.VL.PermuteVar8x16x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt16_X, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipEven_Permute(Vector128<int> data0, Vector128<int> data1) {
                return YGroup2UnzipEven_Permute(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipEven_Permute(Vector128<uint> data0, Vector128<uint> data1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x32x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt32_X, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2UnzipEven_Permute(Vector128<long> data0, Vector128<long> data1) {
                return YGroup2UnzipEven_Permute(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2UnzipEven_Permute(Vector128<ulong> data0, Vector128<ulong> data1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar2x64x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt64_X, data1);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipEven_Unpack(Vector128<float> data0, Vector128<float> data1) {
                Vector128<float> a0, a1, b0;
                a0 = Sse.UnpackLow(data0, data1);
                a1 = Sse.UnpackHigh(data0, data1);
                b0 = Sse.UnpackLow(a0, a1);
                return b0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2UnzipEven_Unpack(Vector128<double> data0, Vector128<double> data1) {
                Vector128<double> a0;
                a0 = Sse2.UnpackLow(data0, data1);
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipEven_Unpack(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                return YGroup2UnzipEven_Unpack(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipEven_Unpack(Vector128<byte> data0, Vector128<byte> data1) {
                Vector128<byte> a0, a1, b0, b1;
                a0 = Sse2.UnpackLow(data0, data1);
                a1 = Sse2.UnpackHigh(data0, data1);
                b0 = Sse2.UnpackLow(a0, a1);
                b1 = Sse2.UnpackHigh(a0, a1);
                a0 = Sse2.UnpackLow(b0, b1);
                a1 = Sse2.UnpackHigh(b0, b1);
                b0 = Sse2.UnpackLow(a0, a1);
                return b0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipEven_Unpack(Vector128<short> data0, Vector128<short> data1) {
                return YGroup2UnzipEven_Unpack(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipEven_Unpack(Vector128<ushort> data0, Vector128<ushort> data1) {
                Vector128<ushort> a0, a1, b0, b1;
                // Format: Code; //Latency, Throughput(references IceLake)
                a0 = Sse2.UnpackLow(data0, data1);  // 1,0.5
                a1 = Sse2.UnpackHigh(data0, data1); // 1,0.5
                b0 = Sse2.UnpackLow(a0, a1);  // 1,0.5
                b1 = Sse2.UnpackHigh(a0, a1); // 1,0.5
                a0 = Sse2.UnpackLow(b0, b1);  // 1,0.5
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipEven_Unpack(Vector128<int> data0, Vector128<int> data1) {
                return YGroup2UnzipEven_Unpack(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipEven_Unpack(Vector128<uint> data0, Vector128<uint> data1) {
                Vector128<uint> a0, a1, b0;
                a0 = Sse2.UnpackLow(data0, data1);
                a1 = Sse2.UnpackHigh(data0, data1);
                b0 = Sse2.UnpackLow(a0, a1);
                return b0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2UnzipEven_Unpack(Vector128<long> data0, Vector128<long> data1) {
                return YGroup2UnzipEven_Unpack(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipEven(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2UnzipEven_Unpack(Vector128<ulong> data0, Vector128<ulong> data1) {
                Vector128<ulong> a0;
                a0 = Sse2.UnpackLow(data0, data1);
                return a0;
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2UnzipOdd_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipOdd(Vector128<float> data0, Vector128<float> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2UnzipOdd(Vector128<double> data0, Vector128<double> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipOdd(Vector128<sbyte> data0, Vector128<sbyte> data1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipOdd(Vector128<byte> data0, Vector128<byte> data1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipOdd(Vector128<short> data0, Vector128<short> data1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipOdd(Vector128<ushort> data0, Vector128<ushort> data1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Narrow(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipOdd(Vector128<int> data0, Vector128<int> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipOdd(Vector128<uint> data0, Vector128<uint> data1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2UnzipOdd_Permute(data0, data1);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2UnzipOdd(Vector128<long> data0, Vector128<long> data1) {
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2UnzipOdd(Vector128<ulong> data0, Vector128<ulong> data1) {
                return YGroup2UnzipOdd_Unpack(data0, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipOdd_Narrow(Vector128<float> data0, Vector128<float> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipOdd_Narrow(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipOdd_Narrow(Vector128<byte> data0, Vector128<byte> data1) {
                const int L = 8;
                Vector128<byte> rt1;
                Vector128<ushort> temp0 = data0.AsUInt16();
                Vector128<ushort> temp1 = data1.AsUInt16();
                temp0 = Sse2.ShiftRightLogical(temp0, L);
                temp1 = Sse2.ShiftRightLogical(temp1, L);
                rt1 = Narrow(temp0, temp1);
                return rt1;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipOdd_Narrow(Vector128<short> data0, Vector128<short> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipOdd_Narrow(Vector128<ushort> data0, Vector128<ushort> data1) {
                const int L = 16;
                Vector128<ushort> rt1;
                Vector128<uint> temp0 = data0.AsUInt32();
                Vector128<uint> temp1 = data1.AsUInt32();
                temp0 = Sse2.ShiftRightLogical(temp0, L); // 1,0.5
                temp1 = Sse2.ShiftRightLogical(temp1, L); // 1,0.5
                rt1 = Narrow(temp0, temp1); // 8, 2.66
                return rt1;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipOdd_Narrow(Vector128<int> data0, Vector128<int> data1) {
                return YGroup2UnzipOdd_Narrow(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipOdd_Narrow(Vector128<uint> data0, Vector128<uint> data1) {
                const int L = 32;
                Vector128<uint> rt1;
                Vector128<ulong> temp0 = data0.AsUInt64();
                Vector128<ulong> temp1 = data1.AsUInt64();
                temp0 = Sse2.ShiftRightLogical(temp0, L);
                temp1 = Sse2.ShiftRightLogical(temp1, L);
                rt1 = Narrow(temp0, temp1);
                return rt1;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipOdd_Permute(Vector128<float> data0, Vector128<float> data1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x32x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt32_Y.AsInt32(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2UnzipOdd_Permute(Vector128<double> data0, Vector128<double> data1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar2x64x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt64_Y.AsInt64(), data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipOdd_Permute(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                return YGroup2UnzipOdd_Permute(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipOdd_Permute(Vector128<byte> data0, Vector128<byte> data1) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                return Avx512Vbmi.VL.PermuteVar16x8x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_Byte_Y, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipOdd_Permute(Vector128<short> data0, Vector128<short> data1) {
                return YGroup2UnzipOdd_Permute(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipOdd_Permute(Vector128<ushort> data0, Vector128<ushort> data1) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                return Avx512BW.VL.PermuteVar8x16x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt16_Y, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipOdd_Permute(Vector128<int> data0, Vector128<int> data1) {
                return YGroup2UnzipOdd_Permute(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipOdd_Permute(Vector128<uint> data0, Vector128<uint> data1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x32x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt32_Y, data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2UnzipOdd_Permute(Vector128<long> data0, Vector128<long> data1) {
                return YGroup2UnzipOdd_Permute(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2UnzipOdd_Permute(Vector128<ulong> data0, Vector128<ulong> data1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar2x64x2(data0, Vector128Constants.YGroup2Unzip_ShuffleX2_UInt64_Y, data1);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2UnzipOdd_Unpack(Vector128<float> data0, Vector128<float> data1) {
                Vector128<float> a0, a1, b1;
                a0 = Sse.UnpackLow(data0, data1);
                a1 = Sse.UnpackHigh(data0, data1);
                b1 = Sse.UnpackHigh(a0, a1);
                return b1;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2UnzipOdd_Unpack(Vector128<double> data0, Vector128<double> data1) {
                Vector128<double> a1;
                a1 = Sse2.UnpackHigh(data0, data1);
                return a1;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2UnzipOdd_Unpack(Vector128<sbyte> data0, Vector128<sbyte> data1) {
                return YGroup2UnzipOdd_Unpack(data0.AsByte(), data1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2UnzipOdd_Unpack(Vector128<byte> data0, Vector128<byte> data1) {
                Vector128<byte> a0, a1, b0, b1;
                a0 = Sse2.UnpackLow(data0, data1);
                a1 = Sse2.UnpackHigh(data0, data1);
                b0 = Sse2.UnpackLow(a0, a1);
                b1 = Sse2.UnpackHigh(a0, a1);
                a0 = Sse2.UnpackLow(b0, b1);
                a1 = Sse2.UnpackHigh(b0, b1);
                b1 = Sse2.UnpackHigh(a0, a1);
                return b1;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2UnzipOdd_Unpack(Vector128<short> data0, Vector128<short> data1) {
                return YGroup2UnzipOdd_Unpack(data0.AsUInt16(), data1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2UnzipOdd_Unpack(Vector128<ushort> data0, Vector128<ushort> data1) {
                Vector128<ushort> a0, a1, b0, b1;
                // Format: Code; //Latency, Throughput(references IceLake)
                a0 = Sse2.UnpackLow(data0, data1);  // 1,0.5
                a1 = Sse2.UnpackHigh(data0, data1); // 1,0.5
                b0 = Sse2.UnpackLow(a0, a1);  // 1,0.5
                b1 = Sse2.UnpackHigh(a0, a1); // 1,0.5
                a1 = Sse2.UnpackHigh(b0, b1); // 1,0.5
                return a1;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2UnzipOdd_Unpack(Vector128<int> data0, Vector128<int> data1) {
                return YGroup2UnzipOdd_Unpack(data0.AsUInt32(), data1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2UnzipOdd_Unpack(Vector128<uint> data0, Vector128<uint> data1) {
                Vector128<uint> a0, a1, b1;
                a0 = Sse2.UnpackLow(data0, data1);
                a1 = Sse2.UnpackHigh(data0, data1);
                b1 = Sse2.UnpackHigh(a0, a1);
                return b1;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2UnzipOdd_Unpack(Vector128<long> data0, Vector128<long> data1) {
                return YGroup2UnzipOdd_Unpack(data0.AsUInt64(), data1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2UnzipOdd(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2UnzipOdd_Unpack(Vector128<ulong> data0, Vector128<ulong> data1) {
                Vector128<ulong> a1;
                a1 = Sse2.UnpackHigh(data0, data1);
                return a1;
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Zip(Vector128<float> x, Vector128<float> y, out Vector128<float> data1) {
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Zip(Vector128<double> x, Vector128<double> y, out Vector128<double> data1) {
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Zip(Vector128<sbyte> x, Vector128<sbyte> y, out Vector128<sbyte> data1) {
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Zip(Vector128<byte> x, Vector128<byte> y, out Vector128<byte> data1) {
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Zip(Vector128<short> x, Vector128<short> y, out Vector128<short> data1) {
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Zip(Vector128<ushort> x, Vector128<ushort> y, out Vector128<ushort> data1) {
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Zip(Vector128<int> x, Vector128<int> y, out Vector128<int> data1) {
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Zip(Vector128<uint> x, Vector128<uint> y, out Vector128<uint> data1) {
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Zip(Vector128<long> x, Vector128<long> y, out Vector128<long> data1) {
                return YGroup2Zip_Unpack(x, y, out data1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Zip(Vector128<ulong> x, Vector128<ulong> y, out Vector128<ulong> data1) {
                return YGroup2Zip_Unpack(x, y, out data1);
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Zip_Permute(Vector128<float> x, Vector128<float> y, out Vector128<float> data1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var data0 = Avx512F.VL.PermuteVar4x32x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt32_Data0.AsInt32(), y);
                data1 = Avx512F.VL.PermuteVar4x32x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt32_Data1.AsInt32(), y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Zip_Permute(Vector128<double> x, Vector128<double> y, out Vector128<double> data1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var data0 = Avx512F.VL.PermuteVar2x64x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt64_Data0.AsInt64(), y);
                data1 = Avx512F.VL.PermuteVar2x64x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt64_Data1.AsInt64(), y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Zip_Permute(Vector128<sbyte> x, Vector128<sbyte> y, out Vector128<sbyte> data1) {
                var d0 = YGroup2Zip_Permute(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Zip_Permute(Vector128<byte> x, Vector128<byte> y, out Vector128<byte> data1) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                var data0 = Avx512Vbmi.VL.PermuteVar16x8x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_Byte_Data0, y);
                data1 = Avx512Vbmi.VL.PermuteVar16x8x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_Byte_Data1, y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Zip_Permute(Vector128<short> x, Vector128<short> y, out Vector128<short> data1) {
                var d0 = YGroup2Zip_Permute(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Zip_Permute(Vector128<ushort> x, Vector128<ushort> y, out Vector128<ushort> data1) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                var data0 = Avx512BW.VL.PermuteVar8x16x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt16_Data0, y);
                data1 = Avx512BW.VL.PermuteVar8x16x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt16_Data1, y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Zip_Permute(Vector128<int> x, Vector128<int> y, out Vector128<int> data1) {
                var d0 = YGroup2Zip_Permute(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Zip_Permute(Vector128<uint> x, Vector128<uint> y, out Vector128<uint> data1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var data0 = Avx512F.VL.PermuteVar4x32x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt32_Data0, y);
                data1 = Avx512F.VL.PermuteVar4x32x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt32_Data1, y);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Zip_Permute(Vector128<long> x, Vector128<long> y, out Vector128<long> data1) {
                var d0 = YGroup2Zip_Permute(x.AsUInt64(), y.AsUInt64(), out var d1);
                data1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Zip_Permute(Vector128<ulong> x, Vector128<ulong> y, out Vector128<ulong> data1) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var data0 = Avx512F.VL.PermuteVar2x64x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt64_Data0, y);
                data1 = Avx512F.VL.PermuteVar2x64x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt64_Data1, y);
                return data0;
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Zip_Unpack(Vector128<float> x, Vector128<float> y, out Vector128<float> data1) {
                Vector128<float> data0;
                // Format: Code; //Latency, Throughput(references IceLake)
                data0 = Sse.UnpackLow(x, y); // 1,0.5
                data1 = Sse.UnpackHigh(x, y); // 1,0.5
                return data0; //total latency: 2, total throughput CPI: 1
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{double}, Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2Zip_Unpack(Vector128<double> x, Vector128<double> y, out Vector128<double> data1) {
                Vector128<double> data0;
                // Format: Code; //Latency, Throughput(references IceLake)
                data0 = Sse2.UnpackLow(x, y); // 1,0.5
                data1 = Sse2.UnpackHigh(x, y); // 1,0.5
                return data0; //total latency: 2, total throughput CPI: 1
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Zip_Unpack(Vector128<sbyte> x, Vector128<sbyte> y, out Vector128<sbyte> data1) {
                var d0 = YGroup2Zip_Unpack(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Zip_Unpack(Vector128<byte> x, Vector128<byte> y, out Vector128<byte> data1) {
                Vector128<byte> data0;
                // Format: Code; //Latency, Throughput(references IceLake)
                data0 = Sse2.UnpackLow(x, y); // 1,0.5
                data1 = Sse2.UnpackHigh(x, y); // 1,0.5
                return data0; //total latency: 2, total throughput CPI: 1
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Zip_Unpack(Vector128<short> x, Vector128<short> y, out Vector128<short> data1) {
                var d0 = YGroup2Zip_Unpack(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Zip_Unpack(Vector128<ushort> x, Vector128<ushort> y, out Vector128<ushort> data1) {
                Vector128<ushort> data0;
                // Format: Code; //Latency, Throughput(references IceLake)
                data0 = Sse2.UnpackLow(x, y); // 1,0.5
                data1 = Sse2.UnpackHigh(x, y); // 1,0.5
                return data0; //total latency: 2, total throughput CPI: 1
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Zip_Unpack(Vector128<int> x, Vector128<int> y, out Vector128<int> data1) {
                var d0 = YGroup2Zip_Unpack(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Zip_Unpack(Vector128<uint> x, Vector128<uint> y, out Vector128<uint> data1) {
                Vector128<uint> data0;
                // Format: Code; //Latency, Throughput(references IceLake)
                data0 = Sse2.UnpackLow(x, y); // 1,0.5
                data1 = Sse2.UnpackHigh(x, y); // 1,0.5
                return data0; //total latency: 2, total throughput CPI: 1
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{long}, Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2Zip_Unpack(Vector128<long> x, Vector128<long> y, out Vector128<long> data1) {
                var d0 = YGroup2Zip_Unpack(x.AsUInt64(), y.AsUInt64(), out var d1);
                data1 = d1.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ulong}, Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2Zip_Unpack(Vector128<ulong> x, Vector128<ulong> y, out Vector128<ulong> data1) {
                Vector128<ulong> data0;
                // Format: Code; //Latency, Throughput(references IceLake)
                data0 = Sse2.UnpackLow(x, y); // 1,0.5
                data1 = Sse2.UnpackHigh(x, y); // 1,0.5
                return data0; //total latency: 2, total throughput CPI: 1
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{float}, Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2Zip_Widen(Vector128<float> x, Vector128<float> y, out Vector128<float> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2Zip_Widen(Vector128<sbyte> x, Vector128<sbyte> y, out Vector128<sbyte> data1) {
                var d0 = YGroup2Zip_Widen(x.AsByte(), y.AsByte(), out var d1);
                data1 = d1.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{byte}, Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2Zip_Widen(Vector128<byte> x, Vector128<byte> y, out Vector128<byte> data1) {
                const int L = 8;
                Vector128<ushort> a0, a1, b0, b1;
                Widen(y, out b0, out b1);
                Widen(x, out a0, out a1);
                b0 = Sse2.ShiftLeftLogical(b0, L);
                b1 = Sse2.ShiftLeftLogical(b1, L);
                a0 = Sse2.Or(a0, b0);
                a1 = Sse2.Or(a1, b1);
                data1 = a1.AsByte();
                return a0.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{short}, Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2Zip_Widen(Vector128<short> x, Vector128<short> y, out Vector128<short> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt16(), y.AsUInt16(), out var d1);
                data1 = d1.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{ushort}, Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2Zip_Widen(Vector128<ushort> x, Vector128<ushort> y, out Vector128<ushort> data1) {
                const int L = 16;
                Vector128<uint> a0, a1, b0, b1;
                Widen(y, out b0, out b1);
                Widen(x, out a0, out a1);
                b0 = Sse2.ShiftLeftLogical(b0, L);
                b1 = Sse2.ShiftLeftLogical(b1, L);
                a0 = Sse2.Or(a0, b0);
                a1 = Sse2.Or(a1, b1);
                data1 = a1.AsUInt16();
                return a0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{int}, Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2Zip_Widen(Vector128<int> x, Vector128<int> y, out Vector128<int> data1) {
                var d0 = YGroup2Zip_Widen(x.AsUInt32(), y.AsUInt32(), out var d1);
                data1 = d1.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2Zip(Vector128{uint}, Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2Zip_Widen(Vector128<uint> x, Vector128<uint> y, out Vector128<uint> data1) {
                const int L = 32;
                Vector128<ulong> a0, a1, b0, b1;
                Widen(y, out b0, out b1);
                Widen(x, out a0, out a1);
                b0 = Sse2.ShiftLeftLogical(b0, L);
                b1 = Sse2.ShiftLeftLogical(b1, L);
                a0 = Sse2.Or(a0, b0);
                a1 = Sse2.Or(a1, b1);
                data1 = a1.AsUInt32();
                return a0.AsUInt32();
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipHigh_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2ZipHigh(Vector128<float> x, Vector128<float> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2ZipHigh(Vector128<double> x, Vector128<double> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2ZipHigh(Vector128<sbyte> x, Vector128<sbyte> y) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2ZipHigh(Vector128<byte> x, Vector128<byte> y) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2ZipHigh(Vector128<short> x, Vector128<short> y) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2ZipHigh(Vector128<ushort> x, Vector128<ushort> y) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2ZipHigh(Vector128<int> x, Vector128<int> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2ZipHigh(Vector128<uint> x, Vector128<uint> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2ZipHigh(Vector128<long> x, Vector128<long> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2ZipHigh(Vector128<ulong> x, Vector128<ulong> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipHigh_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipHigh_Unpack(x, y);
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2ZipHigh_Permute(Vector128<float> x, Vector128<float> y) {
                //return YGroup2ZipHigh_Permute(x.AsUInt32(), y.AsUInt32()).AsSingle();
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x32x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt32_Data1.AsInt32(), y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2ZipHigh_Permute(Vector128<double> x, Vector128<double> y) {
                //return YGroup2ZipHigh_Permute(x.AsUInt64(), y.AsUInt64()).AsDouble();
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar2x64x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt64_Data1.AsInt64(), y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2ZipHigh_Permute(Vector128<sbyte> x, Vector128<sbyte> y) {
                return YGroup2ZipHigh_Permute(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2ZipHigh_Permute(Vector128<byte> x, Vector128<byte> y) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                return Avx512Vbmi.VL.PermuteVar16x8x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_Byte_Data1, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2ZipHigh_Permute(Vector128<short> x, Vector128<short> y) {
                return YGroup2ZipHigh_Permute(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2ZipHigh_Permute(Vector128<ushort> x, Vector128<ushort> y) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                return Avx512BW.VL.PermuteVar8x16x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt16_Data1, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2ZipHigh_Permute(Vector128<int> x, Vector128<int> y) {
                return YGroup2ZipHigh_Permute(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2ZipHigh_Permute(Vector128<uint> x, Vector128<uint> y) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x32x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt32_Data1, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2ZipHigh_Permute(Vector128<long> x, Vector128<long> y) {
                return YGroup2ZipHigh_Permute(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2ZipHigh_Permute(Vector128<ulong> x, Vector128<ulong> y) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar2x64x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt64_Data1, y);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2ZipHigh_Unpack(Vector128<float> x, Vector128<float> y) {
                return Sse.UnpackHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2ZipHigh_Unpack(Vector128<double> x, Vector128<double> y) {
                return Sse2.UnpackHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2ZipHigh_Unpack(Vector128<sbyte> x, Vector128<sbyte> y) {
                return YGroup2ZipHigh_Unpack(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2ZipHigh_Unpack(Vector128<byte> x, Vector128<byte> y) {
                return Sse2.UnpackHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2ZipHigh_Unpack(Vector128<short> x, Vector128<short> y) {
                return YGroup2ZipHigh_Unpack(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2ZipHigh_Unpack(Vector128<ushort> x, Vector128<ushort> y) {
                return Sse2.UnpackHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2ZipHigh_Unpack(Vector128<int> x, Vector128<int> y) {
                return YGroup2ZipHigh_Unpack(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2ZipHigh_Unpack(Vector128<uint> x, Vector128<uint> y) {
                return Sse2.UnpackHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2ZipHigh_Unpack(Vector128<long> x, Vector128<long> y) {
                return YGroup2ZipHigh_Unpack(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipHigh(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2ZipHigh_Unpack(Vector128<ulong> x, Vector128<ulong> y) {
                return Sse2.UnpackHigh(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup2ZipLow_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2ZipLow(Vector128<float> x, Vector128<float> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2ZipLow(Vector128<double> x, Vector128<double> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2ZipLow(Vector128<sbyte> x, Vector128<sbyte> y) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2ZipLow(Vector128<byte> x, Vector128<byte> y) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2ZipLow(Vector128<short> x, Vector128<short> y) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2ZipLow(Vector128<ushort> x, Vector128<ushort> y) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2ZipLow(Vector128<int> x, Vector128<int> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2ZipLow(Vector128<uint> x, Vector128<uint> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2ZipLow(Vector128<long> x, Vector128<long> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2ZipLow(Vector128<ulong> x, Vector128<ulong> y) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return YGroup2ZipLow_Permute(x, y);
                }
#endif // NET8_0_OR_GREATER
                return YGroup2ZipLow_Unpack(x, y);
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2ZipLow_Permute(Vector128<float> x, Vector128<float> y) {
                //return YGroup2ZipLow_Permute(x.AsUInt32(), y.AsUInt32()).AsSingle();
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x32x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt32_Data0.AsInt32(), y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2ZipLow_Permute(Vector128<double> x, Vector128<double> y) {
                //return YGroup2ZipLow_Permute(x.AsUInt64(), y.AsUInt64()).AsDouble();
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar2x64x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt64_Data0.AsInt64(), y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2ZipLow_Permute(Vector128<sbyte> x, Vector128<sbyte> y) {
                return YGroup2ZipLow_Permute(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2ZipLow_Permute(Vector128<byte> x, Vector128<byte> y) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                return Avx512Vbmi.VL.PermuteVar16x8x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_Byte_Data0, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2ZipLow_Permute(Vector128<short> x, Vector128<short> y) {
                return YGroup2ZipLow_Permute(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2ZipLow_Permute(Vector128<ushort> x, Vector128<ushort> y) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                return Avx512BW.VL.PermuteVar8x16x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt16_Data0, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2ZipLow_Permute(Vector128<int> x, Vector128<int> y) {
                return YGroup2ZipLow_Permute(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2ZipLow_Permute(Vector128<uint> x, Vector128<uint> y) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar4x32x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt32_Data0, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2ZipLow_Permute(Vector128<long> x, Vector128<long> y) {
                return YGroup2ZipLow_Permute(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2ZipLow_Permute(Vector128<ulong> x, Vector128<ulong> y) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                return Avx512F.VL.PermuteVar2x64x2(x, Vector128Constants.YGroup2Zip_ShuffleX2_UInt64_Data0, y);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup2ZipLow_Unpack(Vector128<float> x, Vector128<float> y) {
                return Sse.UnpackLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup2ZipLow_Unpack(Vector128<double> x, Vector128<double> y) {
                return Sse2.UnpackLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup2ZipLow_Unpack(Vector128<sbyte> x, Vector128<sbyte> y) {
                return YGroup2ZipLow_Unpack(x.AsByte(), y.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup2ZipLow_Unpack(Vector128<byte> x, Vector128<byte> y) {
                return Sse2.UnpackLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup2ZipLow_Unpack(Vector128<short> x, Vector128<short> y) {
                return YGroup2ZipLow_Unpack(x.AsUInt16(), y.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup2ZipLow_Unpack(Vector128<ushort> x, Vector128<ushort> y) {
                return Sse2.UnpackLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup2ZipLow_Unpack(Vector128<int> x, Vector128<int> y) {
                return YGroup2ZipLow_Unpack(x.AsUInt32(), y.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup2ZipLow_Unpack(Vector128<uint> x, Vector128<uint> y) {
                return Sse2.UnpackLow(x, y);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup2ZipLow_Unpack(Vector128<long> x, Vector128<long> y) {
                return YGroup2ZipLow_Unpack(x.AsUInt64(), y.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup2ZipLow(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup2ZipLow_Unpack(Vector128<ulong> x, Vector128<ulong> y) {
                return Sse2.UnpackLow(x, y);
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3ToGroup4_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3ToGroup4(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3) {
                //var d0 = YGroup3ToGroup4(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                //result1 = d1.AsSingle();
                //result2 = d2.AsSingle();
                //result3 = d3.AsSingle();
                //return d0.AsSingle();
                return YGroup3ToGroup4_ShuffleXImm(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3ToGroup4(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3) {
                //var d0 = YGroup3ToGroup4(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2, out var d3);
                //result1 = d1.AsDouble();
                //result2 = d2.AsDouble();
                //result3 = d3.AsDouble();
                //return d0.AsDouble();
                return YGroup3ToGroup4_ShuffleXImm(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3ToGroup4(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported && Ssse3.IsSupported) {
                    return YGroup3ToGroup4_ShuffleX(data0, data1, data2, out result1, out result2, out result3);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup3ToGroup4_Shuffle(data0, data1, data2, out result1, out result2, out result3);
                }
                return SuperStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3ToGroup4(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported && Ssse3.IsSupported) {
                    return YGroup3ToGroup4_ShuffleX(data0, data1, data2, out result1, out result2, out result3);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup3ToGroup4_Shuffle(data0, data1, data2, out result1, out result2, out result3);
                }
                return SuperStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3ToGroup4(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported && Ssse3.IsSupported) {
                    return YGroup3ToGroup4_ShuffleX(data0, data1, data2, out result1, out result2, out result3);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup3ToGroup4_Shuffle(data0, data1, data2, out result1, out result2, out result3);
                }
                return SuperStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3ToGroup4(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported && Ssse3.IsSupported) {
                    return YGroup3ToGroup4_ShuffleX(data0, data1, data2, out result1, out result2, out result3);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup3ToGroup4_Shuffle(data0, data1, data2, out result1, out result2, out result3);
                }
                return SuperStatics.YGroup3ToGroup4(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3ToGroup4(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3) {
                return YGroup3ToGroup4_ShuffleXImm(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3ToGroup4(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3) {
                return YGroup3ToGroup4_ShuffleXImm(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3ToGroup4(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3) {
                return YGroup3ToGroup4_ShuffleXImm(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3ToGroup4(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3) {
                return YGroup3ToGroup4_ShuffleXImm(data0, data1, data2, out result1, out result2, out result3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3ToGroup4_Shuffle(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3) {
                var d0 = YGroup3ToGroup4_Shuffle(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2, out var d3);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                result3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3ToGroup4_Shuffle(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var maskXYZ = Vector128Constants.YGroup4_MaskXYZ_Byte;
                var f0 = Vector128Constants.YGroup3ToGroup4_Shuffle_Byte_0;
                var f1A = Vector128Constants.YGroup3ToGroup4_Shuffle_Byte_1A;
                var f1B = Vector128Constants.YGroup3ToGroup4_Shuffle_Byte_1B;
                var f2A = Vector128Constants.YGroup3ToGroup4_Shuffle_Byte_2A;
                var f2B = Vector128Constants.YGroup3ToGroup4_Shuffle_Byte_2B;
                var f3 = Vector128Constants.YGroup3ToGroup4_Shuffle_Byte_3;
                var a_0 = Sse2.And(Ssse3.Shuffle(data0, f0), maskXYZ);
                var a_1 = Sse2.And(Sse2.Or(Ssse3.Shuffle(data0, f1A), Ssse3.Shuffle(data1, f1B)), maskXYZ);
                var a_2 = Sse2.And(Sse2.Or(Ssse3.Shuffle(data1, f2A), Ssse3.Shuffle(data2, f2B)), maskXYZ);
                var a_3 = Sse2.And(Ssse3.Shuffle(data2, f3), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3ToGroup4_Shuffle(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3) {
                var d0 = YGroup3ToGroup4_Shuffle(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                result3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3ToGroup4_Shuffle(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var maskXYZ = Vector128Constants.YGroup4_MaskXYZ_UInt16;
                var f0 = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_0;
                var f1A = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_1A;
                var f1B = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_1B;
                var f2A = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_2A;
                var f2B = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_2B;
                var f3 = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_3;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var a_0 = Sse2.And(Ssse3.Shuffle(s0, f0).AsUInt16(), maskXYZ);
                var a_1 = Sse2.And(Sse2.Or(Ssse3.Shuffle(s0, f1A), Ssse3.Shuffle(s1, f1B)).AsUInt16(), maskXYZ);
                var a_2 = Sse2.And(Sse2.Or(Ssse3.Shuffle(s1, f2A), Ssse3.Shuffle(s2, f2B)).AsUInt16(), maskXYZ);
                var a_3 = Sse2.And(Ssse3.Shuffle(s2, f3).AsUInt16(), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3ToGroup4_Shuffle(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3) {
                var d0 = YGroup3ToGroup4_Shuffle(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                result3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3ToGroup4_Shuffle(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var maskXYZ = Vector128Constants.YGroup4_MaskXYZ_UInt32;
                var f1A = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_1A;
                var f1B = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_1B;
                var f2A = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_2A;
                var f2B = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_2B;
                var f3 = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_3;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var a_0 = Sse2.And(data0, maskXYZ);
                var a_1 = Sse2.And(Sse2.Or(Ssse3.Shuffle(s0, f1A), Ssse3.Shuffle(s1, f1B)).AsUInt32(), maskXYZ);
                var a_2 = Sse2.And(Sse2.Or(Ssse3.Shuffle(s1, f2A), Ssse3.Shuffle(s2, f2B)).AsUInt32(), maskXYZ);
                var a_3 = Sse2.And(Ssse3.Shuffle(s2, f3).AsUInt32(), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3ToGroup4_Shuffle(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3) {
                var d0 = YGroup3ToGroup4_Shuffle(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                result3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3ToGroup4_Shuffle(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var maskXYZ = Vector128Constants.YGroup4_MaskXYZ_UInt64_1;
                var f2A = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_2A;
                var f2B = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_2B;
                var f3 = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_3;
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var a_0 = data0;
                var a_1 = Sse2.And(data1, maskXYZ);
                var a_2 = Sse2.Or(Ssse3.Shuffle(s1, f2A), Ssse3.Shuffle(s2, f2B)).AsUInt64();
                var a_3 = Sse2.And(Ssse3.Shuffle(s2, f3).AsUInt64(), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3ToGroup4_ShuffleX(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> result1, out Vector128<sbyte> result2, out Vector128<sbyte> result3) {
                var d0 = YGroup3ToGroup4_ShuffleX(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2, out var d3);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                result3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3ToGroup4_ShuffleX(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> result1, out Vector128<byte> result2, out Vector128<byte> result3) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                var maskXYZ = Vector128Constants.YGroup4_MaskXYZ_Byte;
                var f0 = Vector128Constants.YGroup3ToGroup4_Shuffle_Byte_0;
                var f1 = Vector128Constants.YGroup3ToGroup4_Shuffle_Byte_1;
                var f2 = Vector128Constants.YGroup3ToGroup4_Shuffle_Byte_2;
                var f3 = Vector128Constants.YGroup3ToGroup4_Shuffle_Byte_3;
                var a_0 = Sse2.And(Ssse3.Shuffle(data0, f0), maskXYZ);
                var a_1 = Sse2.And(Avx512Vbmi.VL.PermuteVar16x8x2(data0, f1, data1), maskXYZ);
                var a_2 = Sse2.And(Avx512Vbmi.VL.PermuteVar16x8x2(data1, f2, data2), maskXYZ);
                var a_3 = Sse2.And(Ssse3.Shuffle(data2, f3), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3ToGroup4_ShuffleX(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> result1, out Vector128<short> result2, out Vector128<short> result3) {
                var d0 = YGroup3ToGroup4_ShuffleX(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                result3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3ToGroup4_ShuffleX(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> result1, out Vector128<ushort> result2, out Vector128<ushort> result3) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                var maskXYZ = Vector128Constants.YGroup4_MaskXYZ_UInt16;
                var f0 = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_0;
                var f1 = Vector128Constants.YGroup3ToGroup4_Shuffle_UInt16_1;
                var f2 = Vector128Constants.YGroup3ToGroup4_Shuffle_UInt16_2;
                var f3 = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt16_3;
                var s0 = data0.AsByte();
                var s2 = data2.AsByte();
                var a_0 = Sse2.And(Ssse3.Shuffle(s0, f0).AsUInt16(), maskXYZ);
                var a_1 = Sse2.And(Avx512BW.VL.PermuteVar8x16x2(data0, f1, data1), maskXYZ);
                var a_2 = Sse2.And(Avx512BW.VL.PermuteVar8x16x2(data1, f2, data2), maskXYZ);
                var a_3 = Sse2.And(Ssse3.Shuffle(s2, f3).AsUInt16(), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3ToGroup4_ShuffleX(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3) {
                var d0 = YGroup3ToGroup4_ShuffleX(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                result3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3ToGroup4_ShuffleX(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var maskXYZ = Vector128Constants.YGroup4_MaskXYZ_UInt32;
                var f1 = Vector128Constants.YGroup3ToGroup4_Shuffle_UInt32_1;
                var f2 = Vector128Constants.YGroup3ToGroup4_Shuffle_UInt32_2;
                var f3 = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt32_3;
                var s2 = data2.AsByte();
                var a_0 = Sse2.And(data0, maskXYZ);
                var a_1 = Sse2.And(Avx512F.VL.PermuteVar4x32x2(data0, f1, data1), maskXYZ);
                var a_2 = Sse2.And(Avx512F.VL.PermuteVar4x32x2(data1, f2, data2), maskXYZ);
                var a_3 = Sse2.And(Ssse3.Shuffle(s2, f3).AsUInt32(), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3ToGroup4_ShuffleX(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3) {
                var d0 = YGroup3ToGroup4_ShuffleX(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                result3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3ToGroup4_ShuffleX(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var maskXYZ = Vector128Constants.YGroup4_MaskXYZ_UInt64_1;
                var f2 = Vector128Constants.YGroup3ToGroup4_Shuffle_UInt64_2;
                var f3 = Vector128Constants.YGroup3ToGroup4_ShuffleOnByte_UInt64_3;
                var s2 = data2.AsByte();
                var a_0 = data0;
                var a_1 = Sse2.And(data1, maskXYZ);
                var a_2 = Avx512F.VL.PermuteVar2x64x2(data1, f2, data2);
                var a_3 = Sse2.And(Ssse3.Shuffle(s2, f3).AsUInt64(), maskXYZ);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3ToGroup4_ShuffleXImm(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> result1, out Vector128<float> result2, out Vector128<float> result3) {
                var maskXYZ = Vector128Constants.YGroup4_MaskXYZ_UInt32.AsSingle();
                Vector128<float> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 x1 data1 y1 z1 x2 y2 data2 z2 x3 y3 z3
                // 1 a_0 x0 y0 z0 x1 a_1 x1 y1 z1 x2 a_2 x2 y2 z2 x3 a_3 x3 y3 z3 z2
                a_0 = data0;
                if (Ssse3.IsSupported) {
                    a_1 = Ssse3.AlignRight(data1.AsByte(), data0.AsByte(), 12).AsSingle(); // x1 y1 z1 x2
                } else {
                    b_1 = Sse.Shuffle(data0, data1, (byte)ShuffleControlG4.WWXY); // x1 x1 y1 z1
                    a_1 = Sse.Shuffle(b_1, b_1, (byte)ShuffleControlG4.YZWX); // x1 y1 z1 x1
                }
                a_2 = Sse.Shuffle(data1, data2, (byte)ShuffleControlG4.ZWXY);
                a_3 = Sse.Shuffle(data2, data2, (byte)ShuffleControlG4.YZWX);
                // 2 b_0 x0 y0 z0 _0 b_1 x1 y1 z1 _0 b_2 x2 y2 z2 _0 b_3 x3 y3 z3 _0
                b_0 = Sse.And(a_0, maskXYZ);
                b_1 = Sse.And(a_1, maskXYZ);
                b_2 = Sse.And(a_2, maskXYZ);
                b_3 = Sse.And(a_3, maskXYZ);
                result1 = b_1;
                result2 = b_2;
                result3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3ToGroup4_ShuffleXImm(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> result1, out Vector128<double> result2, out Vector128<double> result3) {
                var maskXYZ = Vector128Constants.YGroup4_MaskXYZ_UInt64_1.AsDouble();
                // 0 data0 x0 y0 data1 z0 x1 data2 y1 z1   
                // 1 a_0 x0 y0 a_1 z0 _0 a_2 x1 y1 a_3 z1 _0
                var a_0 = data0;
                var a_1 = Sse2.And(data1, maskXYZ);
                var a_2 = Sse2.Shuffle(data1, data2, (byte)ShuffleControlG2.YX);
                var a_3 = Sse2.Shuffle(data2, maskXYZ, (byte)ShuffleControlG2.YY);
                result1 = a_1;
                result2 = a_2;
                result3 = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3ToGroup4_ShuffleXImm(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> result1, out Vector128<int> result2, out Vector128<int> result3) {
                var d0 = YGroup3ToGroup4_ShuffleXImm(data0.AsSingle(), data1.AsSingle(), data2.AsSingle(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                result3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3ToGroup4_ShuffleXImm(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> result1, out Vector128<uint> result2, out Vector128<uint> result3) {
                var d0 = YGroup3ToGroup4_ShuffleXImm(data0.AsSingle(), data1.AsSingle(), data2.AsSingle(), out var d1, out var d2, out var d3);
                result1 = d1.AsUInt32();
                result2 = d2.AsUInt32();
                result3 = d3.AsUInt32();
                return d0.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3ToGroup4_ShuffleXImm(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> result1, out Vector128<long> result2, out Vector128<long> result3) {
                var d0 = YGroup3ToGroup4_ShuffleXImm(data0.AsDouble(), data1.AsDouble(), data2.AsDouble(), out var d1, out var d2, out var d3);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                result3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ToGroup4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3ToGroup4_ShuffleXImm(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> result1, out Vector128<ulong> result2, out Vector128<ulong> result3) {
                var d0 = YGroup3ToGroup4_ShuffleXImm(data0.AsDouble(), data1.AsDouble(), data2.AsDouble(), out var d1, out var d2, out var d3);
                result1 = d1.AsUInt64();
                result2 = d2.AsUInt64();
                result3 = d3.AsUInt64();
                return d0.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3Unzip_AcceleratedTypes {
                get {
                    return YGroup2Unzip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> y, out Vector128<float> z) {
                return YGroup3Unzip_ShuffleXImm(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> y, out Vector128<double> z) {
                return YGroup3Unzip_ShuffleXImm(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> y, out Vector128<sbyte> z) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup3Unzip_ShuffleX(data0, data1, data2, out y, out z);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup3Unzip_Shuffle(data0, data1, data2, out y, out z);
                }
                return YGroup3Unzip_ByX2Zip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> y, out Vector128<byte> z) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup3Unzip_ShuffleX(data0, data1, data2, out y, out z);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup3Unzip_Shuffle(data0, data1, data2, out y, out z);
                }
                return YGroup3Unzip_ByX2Zip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> y, out Vector128<short> z) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup3Unzip_ShuffleX(data0, data1, data2, out y, out z);
                }
#endif // NET8_0_OR_GREATER
#if NET5_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup3Unzip_Shuffle(data0, data1, data2, out y, out z);
                }
#endif // NET5_0_OR_GREATER
                return YGroup3Unzip_ByX2Zip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> y, out Vector128<ushort> z) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup3Unzip_ShuffleX(data0, data1, data2, out y, out z);
                }
#endif // NET8_0_OR_GREATER
#if NET5_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup3Unzip_Shuffle(data0, data1, data2, out y, out z);
                }
#endif // NET5_0_OR_GREATER
                return YGroup3Unzip_ByX2Zip(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> y, out Vector128<int> z) {
                return YGroup3Unzip_ShuffleXImm(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> y, out Vector128<uint> z) {
                return YGroup3Unzip_ShuffleXImm(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> y, out Vector128<long> z) {
                return YGroup3Unzip_ShuffleXImm(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> y, out Vector128<ulong> z) {
                return YGroup3Unzip_ShuffleXImm(data0, data1, data2, out y, out z);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3Unzip_ByX2Zip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> y, out Vector128<float> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3Unzip_ByX2Zip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> y, out Vector128<double> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3Unzip_ByX2Zip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> y, out Vector128<sbyte> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3Unzip_ByX2Zip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> y, out Vector128<byte> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3Unzip_ByX2Zip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> y, out Vector128<short> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3Unzip_ByX2Zip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> y, out Vector128<ushort> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3Unzip_ByX2Zip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> y, out Vector128<int> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3Unzip_ByX2Zip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> y, out Vector128<uint> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3Unzip_ByX2Zip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> y, out Vector128<long> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3Unzip_ByX2Zip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> y, out Vector128<ulong> z) {
                return YGroup3UnzipX2_Zip(data0, data1, data2, data0, data1, data2, out _, out y, out _, out z, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3Unzip_Shuffle(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> y, out Vector128<float> z) {
                var d0 = YGroup3Unzip_Shuffle(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2);
                y = d1.AsSingle();
                z = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3Unzip_Shuffle(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> y, out Vector128<double> z) {
                var d0 = YGroup3Unzip_Shuffle(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2);
                y = d1.AsDouble();
                z = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3Unzip_Shuffle(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> y, out Vector128<sbyte> z) {
                var d0 = YGroup3Unzip_Shuffle(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2);
                y = d1.AsSByte();
                z = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3Unzip_Shuffle(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> y, out Vector128<byte> z) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup3Unzip_Shuffle_Byte_X_Part0;
                var f0B = Vector128Constants.YGroup3Unzip_Shuffle_Byte_X_Part1;
                var f0C = Vector128Constants.YGroup3Unzip_Shuffle_Byte_X_Part2;
                var f1A = Vector128Constants.YGroup3Unzip_Shuffle_Byte_Y_Part0;
                var f1B = Vector128Constants.YGroup3Unzip_Shuffle_Byte_Y_Part1;
                var f1C = Vector128Constants.YGroup3Unzip_Shuffle_Byte_Y_Part2;
                var f2A = Vector128Constants.YGroup3Unzip_Shuffle_Byte_Z_Part0;
                var f2B = Vector128Constants.YGroup3Unzip_Shuffle_Byte_Z_Part1;
                var f2C = Vector128Constants.YGroup3Unzip_Shuffle_Byte_Z_Part2;
                var rt0 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(data0, f0A), Ssse3.Shuffle(data1, f0B)), Ssse3.Shuffle(data2, f0C));
                var rt1 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(data0, f1A), Ssse3.Shuffle(data1, f1B)), Ssse3.Shuffle(data2, f1C));
                var rt2 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(data0, f2A), Ssse3.Shuffle(data1, f2B)), Ssse3.Shuffle(data2, f2C));
                y = rt1;
                z = rt2;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3Unzip_Shuffle(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> y, out Vector128<short> z) {
                var d0 = YGroup3Unzip_Shuffle(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2);
                //Console.WriteLine(VectorTextUtil.Format("YGroup3Unzip_Shuffle<short>({0}, {1}, {2}) = {3}, {4}, {5}", data0, data1, data2, d0, d1, d2));
                y = d1.AsInt16();
                z = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3Unzip_Shuffle(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> y, out Vector128<ushort> z) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt16_X_Part0;
                var f0B = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt16_X_Part1;
                var f0C = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt16_X_Part2;
                var f1A = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt16_Y_Part0;
                var f1B = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt16_Y_Part1;
                var f1C = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt16_Y_Part2;
                var f2A = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt16_Z_Part0;
                var f2B = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt16_Z_Part1;
                var f2C = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt16_Z_Part2;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var rt0 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(s0, f0A), Ssse3.Shuffle(s1, f0B)), Ssse3.Shuffle(s2, f0C)).AsUInt16();
                var rt1 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(s0, f1A), Ssse3.Shuffle(s1, f1B)), Ssse3.Shuffle(s2, f1C)).AsUInt16();
                var rt2 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(s0, f2A), Ssse3.Shuffle(s1, f2B)), Ssse3.Shuffle(s2, f2C)).AsUInt16();
                //Console.WriteLine(VectorTextUtil.Format("YGroup3Unzip_Shuffle<ushort>({0}, {1}, {2}) = {3}, {4}, {5}", data0, data1, data2, rt0, rt1, rt2));
                y = rt1;
                z = rt2;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3Unzip_Shuffle(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> y, out Vector128<int> z) {
                var d0 = YGroup3Unzip_Shuffle(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2);
                y = d1.AsInt32();
                z = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3Unzip_Shuffle(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> y, out Vector128<uint> z) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt32_X_Part0;
                var f0B = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt32_X_Part1;
                var f0C = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt32_X_Part2;
                var f1A = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt32_Y_Part0;
                var f1B = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt32_Y_Part1;
                var f1C = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt32_Y_Part2;
                var f2A = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt32_Z_Part0;
                var f2B = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt32_Z_Part1;
                var f2C = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt32_Z_Part2;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var rt0 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(s0, f0A), Ssse3.Shuffle(s1, f0B)), Ssse3.Shuffle(s2, f0C)).AsUInt32();
                var rt1 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(s0, f1A), Ssse3.Shuffle(s1, f1B)), Ssse3.Shuffle(s2, f1C)).AsUInt32();
                var rt2 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(s0, f2A), Ssse3.Shuffle(s1, f2B)), Ssse3.Shuffle(s2, f2C)).AsUInt32();
                y = rt1;
                z = rt2;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3Unzip_Shuffle(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> y, out Vector128<long> z) {
                var d0 = YGroup3Unzip_Shuffle(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2);
                y = d1.AsInt64();
                z = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3Unzip_Shuffle(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> y, out Vector128<ulong> z) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt64_X_Part0;
                var f0B = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt64_X_Part1;
                var f1A = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt64_Y_Part0;
                var f1C = Vector128Constants.YGroup3Unzip_ShuffleOnByte_UInt64_Y_Part2;
                var f2B = f0A;
                var f2C = f0B;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var rt0 = Sse2.Or(Ssse3.Shuffle(s0, f0A), Ssse3.Shuffle(s1, f0B)).AsUInt64();
                var rt1 = Sse2.Or(Ssse3.Shuffle(s0, f1A), Ssse3.Shuffle(s2, f1C)).AsUInt64();
                var rt2 = Sse2.Or(Ssse3.Shuffle(s1, f2B), Ssse3.Shuffle(s2, f2C)).AsUInt64();
                y = rt1;
                z = rt2;
                return rt0;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3Unzip_ShuffleX(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> y, out Vector128<float> z) {
                var d0 = YGroup3Unzip_ShuffleX(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2);
                y = d1.AsSingle();
                z = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3Unzip_ShuffleX(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> y, out Vector128<double> z) {
                var d0 = YGroup3Unzip_ShuffleX(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2);
                y = d1.AsDouble();
                z = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3Unzip_ShuffleX(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, out Vector128<sbyte> y, out Vector128<sbyte> z) {
                var d0 = YGroup3Unzip_ShuffleX(data0.AsByte(), data1.AsByte(), data2.AsByte(), out var d1, out var d2);
                y = d1.AsSByte();
                z = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3Unzip_ShuffleX(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, out Vector128<byte> y, out Vector128<byte> z) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                var f0 = Vector128Constants.YGroup3Unzip_Shuffle_Byte_X;
                var f0C = Vector128Constants.YGroup3Unzip_Shuffle_Byte_X_Part2Combine;
                var f1 = Vector128Constants.YGroup3Unzip_Shuffle_Byte_Y;
                var f1C = Vector128Constants.YGroup3Unzip_Shuffle_Byte_Y_Part2Combine;
                var f2 = Vector128Constants.YGroup3Unzip_Shuffle_Byte_Z;
                var f2C = Vector128Constants.YGroup3Unzip_Shuffle_Byte_Z_Part2Combine;
                var rt0 = Avx512Vbmi.VL.PermuteVar16x8x2(data0, f0, data1);
                var rt1 = Avx512Vbmi.VL.PermuteVar16x8x2(data0, f1, data1);
                var rt2 = Avx512Vbmi.VL.PermuteVar16x8x2(data0, f2, data1);
                rt0 = Avx512Vbmi.VL.PermuteVar16x8x2(data2, f0C, rt0);
                rt1 = Avx512Vbmi.VL.PermuteVar16x8x2(data2, f1C, rt1);
                rt2 = Avx512Vbmi.VL.PermuteVar16x8x2(data2, f2C, rt2);
                y = rt1;
                z = rt2;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3Unzip_ShuffleX(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, out Vector128<short> y, out Vector128<short> z) {
                var d0 = YGroup3Unzip_ShuffleX(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), out var d1, out var d2);
                y = d1.AsInt16();
                z = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3Unzip_ShuffleX(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, out Vector128<ushort> y, out Vector128<ushort> z) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                var f0 = Vector128Constants.YGroup3Unzip_Shuffle_UInt16_X;
                var f0C = Vector128Constants.YGroup3Unzip_Shuffle_UInt16_X_Part2Combine;
                var f1 = Vector128Constants.YGroup3Unzip_Shuffle_UInt16_Y;
                var f1C = Vector128Constants.YGroup3Unzip_Shuffle_UInt16_Y_Part2Combine;
                var f2 = Vector128Constants.YGroup3Unzip_Shuffle_UInt16_Z;
                var f2C = Vector128Constants.YGroup3Unzip_Shuffle_UInt16_Z_Part2Combine;
                var rt0 = Avx512BW.VL.PermuteVar8x16x2(data0, f0, data1);
                var rt1 = Avx512BW.VL.PermuteVar8x16x2(data0, f1, data1);
                var rt2 = Avx512BW.VL.PermuteVar8x16x2(data0, f2, data1);
                rt0 = Avx512BW.VL.PermuteVar8x16x2(data2, f0C, rt0);
                rt1 = Avx512BW.VL.PermuteVar8x16x2(data2, f1C, rt1);
                rt2 = Avx512BW.VL.PermuteVar8x16x2(data2, f2C, rt2);
                y = rt1;
                z = rt2;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3Unzip_ShuffleX(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> y, out Vector128<int> z) {
                var d0 = YGroup3Unzip_ShuffleX(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), out var d1, out var d2);
                y = d1.AsInt32();
                z = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3Unzip_ShuffleX(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> y, out Vector128<uint> z) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var f0 = Vector128Constants.YGroup3Unzip_Shuffle_UInt32_X;
                var f0C = Vector128Constants.YGroup3Unzip_Shuffle_UInt32_X_Part2Combine;
                var f1 = Vector128Constants.YGroup3Unzip_Shuffle_UInt32_Y;
                var f1C = Vector128Constants.YGroup3Unzip_Shuffle_UInt32_Y_Part2Combine;
                var f2 = Vector128Constants.YGroup3Unzip_Shuffle_UInt32_Z;
                var f2C = Vector128Constants.YGroup3Unzip_Shuffle_UInt32_Z_Part2Combine;
                var rt0 = Avx512F.VL.PermuteVar4x32x2(data0, f0, data1);
                var rt1 = Avx512F.VL.PermuteVar4x32x2(data0, f1, data1);
                var rt2 = Avx512F.VL.PermuteVar4x32x2(data0, f2, data1);
                rt0 = Avx512F.VL.PermuteVar4x32x2(data2, f0C, rt0);
                rt1 = Avx512F.VL.PermuteVar4x32x2(data2, f1C, rt1);
                rt2 = Avx512F.VL.PermuteVar4x32x2(data2, f2C, rt2);
                y = rt1;
                z = rt2;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3Unzip_ShuffleX(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> y, out Vector128<long> z) {
                var d0 = YGroup3Unzip_ShuffleX(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), out var d1, out var d2);
                y = d1.AsInt64();
                z = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3Unzip_ShuffleX(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> y, out Vector128<ulong> z) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var f0 = Vector128Constants.YGroup3Unzip_Shuffle_UInt64_X;
                var f1 = Vector128Constants.YGroup3Unzip_Shuffle_UInt64_Y_On02;
                var f2 = f0; // YGroup3Unzip_Shuffle_UInt64_Z_On12
                var rt0 = Avx512F.VL.PermuteVar2x64x2(data0, f0, data1);
                var rt1 = Avx512F.VL.PermuteVar2x64x2(data0, f1, data2);
                var rt2 = Avx512F.VL.PermuteVar2x64x2(data1, f2, data2);
                y = rt1;
                z = rt2;
                return rt0;
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3Unzip_ShuffleXImm(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, out Vector128<float> y, out Vector128<float> z) {
                Vector128<float> a_0, a_1, b_0, b_1, b_2;
                // 0 data0 x0 y0 z0 x1 data1 y1 z1 x2 y2 data2 z2 x3 y3 z3
                // 1 a_0 x2 y2 x3 y3 a_1 y0 z0 y1 z1
                a_0 = Sse.Shuffle(data1, data2, (byte)ShuffleControlG4.ZWYZ);
                a_1 = Sse.Shuffle(data0, data1, (byte)ShuffleControlG4.YZXY);
                // 2 b_0 x0 x1 x2 x3 b_1 y0 y1 y2 y3 b_2 z0 z1 z2 z3
                b_0 = Sse.Shuffle(data0, a_0, (byte)ShuffleControlG4.XWXZ);
                b_1 = Sse.Shuffle(a_1, a_0, (byte)ShuffleControlG4.XZYW);
                b_2 = Sse.Shuffle(a_1, data2, (byte)ShuffleControlG4.YWXW);
                y = b_1;
                z = b_2;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3Unzip_ShuffleXImm(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, out Vector128<double> y, out Vector128<double> z) {
                // 0 data0 x0 y0 data1 z0 x1 data2 y1 z1
                // 1 a0 x0 x1 a1 y0 y1 a2 z0 z1
                var a0 = Sse2.Shuffle(data0, data1, (byte)ShuffleControlG2.XY);
                var a1 = Sse2.Shuffle(data0, data2, (byte)ShuffleControlG2.YX);
                var a2 = Sse2.Shuffle(data1, data2, (byte)ShuffleControlG2.XY);
                y = a1;
                z = a2;
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3Unzip_ShuffleXImm(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, out Vector128<int> y, out Vector128<int> z) {
                var d0 = YGroup3Unzip_ShuffleXImm(data0.AsSingle(), data1.AsSingle(), data2.AsSingle(), out var d1, out var d2);
                y = d1.AsInt32();
                z = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3Unzip_ShuffleXImm(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, out Vector128<uint> y, out Vector128<uint> z) {
                var d0 = YGroup3Unzip_ShuffleXImm(data0.AsSingle(), data1.AsSingle(), data2.AsSingle(), out var d1, out var d2);
                y = d1.AsUInt32();
                z = d2.AsUInt32();
                return d0.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3Unzip_ShuffleXImm(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, out Vector128<long> y, out Vector128<long> z) {
                var d0 = YGroup3Unzip_ShuffleXImm(data0.AsDouble(), data1.AsDouble(), data2.AsDouble(), out var d1, out var d2);
                y = d1.AsInt64();
                z = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3Unzip_ShuffleXImm(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, out Vector128<ulong> y, out Vector128<ulong> z) {
                var d0 = YGroup3Unzip_ShuffleXImm(data0.AsDouble(), data1.AsDouble(), data2.AsDouble(), out var d1, out var d2);
                y = d1.AsUInt64();
                z = d2.AsUInt64();
                return d0.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3UnzipX2_AcceleratedTypes {
                get {
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3UnzipX2(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, Vector128<float> data4, Vector128<float> data5, out Vector128<float> xB, out Vector128<float> y, out Vector128<float> yB, out Vector128<float> z, out Vector128<float> zB) {
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3UnzipX2(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, Vector128<double> data4, Vector128<double> data5, out Vector128<double> xB, out Vector128<double> y, out Vector128<double> yB, out Vector128<double> z, out Vector128<double> zB) {
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3UnzipX2(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, Vector128<sbyte> data4, Vector128<sbyte> data5, out Vector128<sbyte> xB, out Vector128<sbyte> y, out Vector128<sbyte> yB, out Vector128<sbyte> z, out Vector128<sbyte> zB) {
#if NET7_0_OR_GREATER
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3UnzipX2(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, Vector128<byte> data4, Vector128<byte> data5, out Vector128<byte> xB, out Vector128<byte> y, out Vector128<byte> yB, out Vector128<byte> z, out Vector128<byte> zB) {
#if NET7_0_OR_GREATER
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#else
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3UnzipX2(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, Vector128<short> data4, Vector128<short> data5, out Vector128<short> xB, out Vector128<short> y, out Vector128<short> yB, out Vector128<short> z, out Vector128<short> zB) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // NET8_0_OR_GREATER
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3UnzipX2(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, Vector128<ushort> data4, Vector128<ushort> data5, out Vector128<ushort> xB, out Vector128<ushort> y, out Vector128<ushort> yB, out Vector128<ushort> z, out Vector128<ushort> zB) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
                }
#endif // NET8_0_OR_GREATER
                return YGroup3UnzipX2_Zip(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3UnzipX2(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, Vector128<int> data4, Vector128<int> data5, out Vector128<int> xB, out Vector128<int> y, out Vector128<int> yB, out Vector128<int> z, out Vector128<int> zB) {
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3UnzipX2(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, Vector128<uint> data4, Vector128<uint> data5, out Vector128<uint> xB, out Vector128<uint> y, out Vector128<uint> yB, out Vector128<uint> z, out Vector128<uint> zB) {
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3UnzipX2(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, Vector128<long> data4, Vector128<long> data5, out Vector128<long> xB, out Vector128<long> y, out Vector128<long> yB, out Vector128<long> z, out Vector128<long> zB) {
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3UnzipX2(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, Vector128<ulong> data4, Vector128<ulong> data5, out Vector128<ulong> xB, out Vector128<ulong> y, out Vector128<ulong> yB, out Vector128<ulong> z, out Vector128<ulong> zB) {
                return YGroup3UnzipX2_X2(data0, data1, data2, data3, data4, data5, out xB, out y, out yB, out z, out zB);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3UnzipX2_X2(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, Vector128<float> data4, Vector128<float> data5, out Vector128<float> xB, out Vector128<float> y, out Vector128<float> yB, out Vector128<float> z, out Vector128<float> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3UnzipX2_X2(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, Vector128<double> data4, Vector128<double> data5, out Vector128<double> xB, out Vector128<double> y, out Vector128<double> yB, out Vector128<double> z, out Vector128<double> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3UnzipX2_X2(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, Vector128<sbyte> data4, Vector128<sbyte> data5, out Vector128<sbyte> xB, out Vector128<sbyte> y, out Vector128<sbyte> yB, out Vector128<sbyte> z, out Vector128<sbyte> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3UnzipX2_X2(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, Vector128<byte> data4, Vector128<byte> data5, out Vector128<byte> xB, out Vector128<byte> y, out Vector128<byte> yB, out Vector128<byte> z, out Vector128<byte> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3UnzipX2_X2(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, Vector128<short> data4, Vector128<short> data5, out Vector128<short> xB, out Vector128<short> y, out Vector128<short> yB, out Vector128<short> z, out Vector128<short> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3UnzipX2_X2(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, Vector128<ushort> data4, Vector128<ushort> data5, out Vector128<ushort> xB, out Vector128<ushort> y, out Vector128<ushort> yB, out Vector128<ushort> z, out Vector128<ushort> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3UnzipX2_X2(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, Vector128<int> data4, Vector128<int> data5, out Vector128<int> xB, out Vector128<int> y, out Vector128<int> yB, out Vector128<int> z, out Vector128<int> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3UnzipX2_X2(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, Vector128<uint> data4, Vector128<uint> data5, out Vector128<uint> xB, out Vector128<uint> y, out Vector128<uint> yB, out Vector128<uint> z, out Vector128<uint> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3UnzipX2_X2(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, Vector128<long> data4, Vector128<long> data5, out Vector128<long> xB, out Vector128<long> y, out Vector128<long> yB, out Vector128<long> z, out Vector128<long> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3UnzipX2_X2(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, Vector128<ulong> data4, Vector128<ulong> data5, out Vector128<ulong> xB, out Vector128<ulong> y, out Vector128<ulong> yB, out Vector128<ulong> z, out Vector128<ulong> zB) {
                var x = YGroup3Unzip(data0, data1, data2, out y, out z);
                xB = YGroup3Unzip(data3, data4, data5, out yB, out zB);
                return x;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3UnzipX2_Zip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, Vector128<float> data4, Vector128<float> data5, out Vector128<float> xB, out Vector128<float> y, out Vector128<float> yB, out Vector128<float> z, out Vector128<float> zB) {
                Vector128<float> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 z0 x1 data1 y1 z1 x2 y2 data2 z2 x3 y3 z3 data3 x4 y4 z4 x5 data4 y5 z5 x6 y6 data5 z6 x7 y7 z7
                // 1 a_0 x0 x4 y0 y4 a_1 z0 z4 x1 x5 a_2 y1 y5 z1 z5 a_3 x2 x6 y2 y6 a_4 z2 z6 x3 x7 a_5 y3 y7 z3 z7
                a_0 = YGroup2Zip(data0, data3, out a_1);
                a_2 = YGroup2Zip(data1, data4, out a_3);
                a_4 = YGroup2Zip(data2, data5, out a_5);
                // 2 b_0 x0 x2 x4 x6 b_1 y0 y2 y4 y6 b_2 z0 z2 z4 z6 b_3 x1 x3 x5 x7 b_4 y1 y3 y5 y7 b_5 z1 z3 z5 z7
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 3 a_0 x0 x1 x2 x3 a_1 x4 x5 x6 x7 a_2 y0 y1 y2 y3 a_3 y4 y5 y6 y7 a_4 z0 z1 z2 z3 a_5 z4 z5 z6 z7
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                xB = a_1;
                y = a_2;
                yB = a_3;
                z = a_4;
                zB = a_5;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3UnzipX2_Zip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, Vector128<double> data4, Vector128<double> data5, out Vector128<double> xB, out Vector128<double> y, out Vector128<double> yB, out Vector128<double> z, out Vector128<double> zB) {
                Vector128<double> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 data1 z0 x1 data2 y1 z1 data3 x2 y2 data4 z2 x3 data5 y3 z3
                // 1 a_0 x0 x2 a_1 y0 y2 a_2 z0 z2 a_3 x1 x3 a_4 y1 y3 a_5 z1 z3
                a_0 = YGroup2Zip(data0, data3, out a_1);
                a_2 = YGroup2Zip(data1, data4, out a_3);
                a_4 = YGroup2Zip(data2, data5, out a_5);
                // 2 b_0 x0 x1 b_1 x2 x3 b_2 y0 y1 b_3 y2 y3 b_4 z0 z1 b_5 z2 z3
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                xB = b_1;
                y = b_2;
                yB = b_3;
                z = b_4;
                zB = b_5;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3UnzipX2_Zip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, Vector128<sbyte> data4, Vector128<sbyte> data5, out Vector128<sbyte> xB, out Vector128<sbyte> y, out Vector128<sbyte> yB, out Vector128<sbyte> z, out Vector128<sbyte> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), data4.AsByte(), data5.AsByte(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsSByte();
                y = d2.AsSByte();
                yB = d3.AsSByte();
                z = d4.AsSByte();
                zB = d5.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3UnzipX2_Zip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, Vector128<byte> data4, Vector128<byte> data5, out Vector128<byte> xB, out Vector128<byte> y, out Vector128<byte> yB, out Vector128<byte> z, out Vector128<byte> zB) {
                Vector128<byte> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 z0 x1 y1 z1 x2 y2 z2 x3 y3 z3 x4 y4 z4 x5 data1 y5 z5 x6 y6 z6 x7 y7 z7 x8 y8 z8 x9 y9 z9 x10 y10 data2 z10 x11 y11 z11 x12 y12 z12 x13 y13 z13 x14 y14 z14 x15 y15 z15 data3 x16 y16 z16 x17 y17 z17 x18 y18 z18 x19 y19 z19 x20 y20 z20 x21 data4 y21 z21 x22 y22 z22 x23 y23 z23 x24 y24 z24 x25 y25 z25 x26 y26 data5 z26 x27 y27 z27 x28 y28 z28 x29 y29 z29 x30 y30 z30 x31 y31 z31
                // 1 a_0 x0 x16 y0 y16 z0 z16 x1 x17 y1 y17 z1 z17 x2 x18 y2 y18 a_1 z2 z18 x3 x19 y3 y19 z3 z19 x4 x20 y4 y20 z4 z20 x5 x21 a_2 y5 y21 z5 z21 x6 x22 y6 y22 z6 z22 x7 x23 y7 y23 z7 z23 a_3 x8 x24 y8 y24 z8 z24 x9 x25 y9 y25 z9 z25 x10 x26 y10 y26 a_4 z10 z26 x11 x27 y11 y27 z11 z27 x12 x28 y12 y28 z12 z28 x13 x29 a_5 y13 y29 z13 z29 x14 x30 y14 y30 z14 z30 x15 x31 y15 y31 z15 z31
                a_0 = YGroup2Zip(data0, data3, out a_1);
                a_2 = YGroup2Zip(data1, data4, out a_3);
                a_4 = YGroup2Zip(data2, data5, out a_5);
                // 2 b_0 x0 x8 x16 x24 y0 y8 y16 y24 z0 z8 z16 z24 x1 x9 x17 x25 b_1 y1 y9 y17 y25 z1 z9 z17 z25 x2 x10 x18 x26 y2 y10 y18 y26 b_2 z2 z10 z18 z26 x3 x11 x19 x27 y3 y11 y19 y27 z3 z11 z19 z27 b_3 x4 x12 x20 x28 y4 y12 y20 y28 z4 z12 z20 z28 x5 x13 x21 x29 b_4 y5 y13 y21 y29 z5 z13 z21 z29 x6 x14 x22 x30 y6 y14 y22 y30 b_5 z6 z14 z22 z30 x7 x15 x23 x31 y7 y15 y23 y31 z7 z15 z23 z31
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 3 a_0 x0 x4 x8 x12 x16 x20 x24 x28 y0 y4 y8 y12 y16 y20 y24 y28 a_1 z0 z4 z8 z12 z16 z20 z24 z28 x1 x5 x9 x13 x17 x21 x25 x29 a_2 y1 y5 y9 y13 y17 y21 y25 y29 z1 z5 z9 z13 z17 z21 z25 z29 a_3 x2 x6 x10 x14 x18 x22 x26 x30 y2 y6 y10 y14 y18 y22 y26 y30 a_4 z2 z6 z10 z14 z18 z22 z26 z30 x3 x7 x11 x15 x19 x23 x27 x31 a_5 y3 y7 y11 y15 y19 y23 y27 y31 z3 z7 z11 z15 z19 z23 z27 z31
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                // 4 b_0 x0 x2 x4 x6 x8 x10 x12 x14 x16 x18 x20 x22 x24 x26 x28 x30 b_1 y0 y2 y4 y6 y8 y10 y12 y14 y16 y18 y20 y22 y24 y26 y28 y30 b_2 z0 z2 z4 z6 z8 z10 z12 z14 z16 z18 z20 z22 z24 z26 z28 z30 b_3 x1 x3 x5 x7 x9 x11 x13 x15 x17 x19 x21 x23 x25 x27 x29 x31 b_4 y1 y3 y5 y7 y9 y11 y13 y15 y17 y19 y21 y23 y25 y27 y29 y31 b_5 z1 z3 z5 z7 z9 z11 z13 z15 z17 z19 z21 z23 z25 z27 z29 z31
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 5 a_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 a_1 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 a_2 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 a_3 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 a_4 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 a_5 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                xB = a_1;
                y = a_2;
                yB = a_3;
                z = a_4;
                zB = a_5;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3UnzipX2_Zip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, Vector128<short> data4, Vector128<short> data5, out Vector128<short> xB, out Vector128<short> y, out Vector128<short> yB, out Vector128<short> z, out Vector128<short> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), data4.AsUInt16(), data5.AsUInt16(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsInt16();
                y = d2.AsInt16();
                yB = d3.AsInt16();
                z = d4.AsInt16();
                zB = d5.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3UnzipX2_Zip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, Vector128<ushort> data4, Vector128<ushort> data5, out Vector128<ushort> xB, out Vector128<ushort> y, out Vector128<ushort> yB, out Vector128<ushort> z, out Vector128<ushort> zB) {
                Vector128<ushort> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 z0 x1 y1 z1 x2 y2 data1 z2 x3 y3 z3 x4 y4 z4 x5 data2 y5 z5 x6 y6 z6 x7 y7 z7 data3 x8 y8 z8 x9 y9 z9 x10 y10 data4 z10 x11 y11 z11 x12 y12 z12 x13 data5 y13 z13 x14 y14 z14 x15 y15 z15
                // 1 a_0 x0 x8 y0 y8 z0 z8 x1 x9 a_1 y1 y9 z1 z9 x2 x10 y2 y10 a_2 z2 z10 x3 x11 y3 y11 z3 z11 a_3 x4 x12 y4 y12 z4 z12 x5 x13 a_4 y5 y13 z5 z13 x6 x14 y6 y14 a_5 z6 z14 x7 x15 y7 y15 z7 z15
                a_0 = YGroup2Zip(data0, data3, out a_1);
                a_2 = YGroup2Zip(data1, data4, out a_3);
                a_4 = YGroup2Zip(data2, data5, out a_5);
                // 2 b_0 x0 x4 x8 x12 y0 y4 y8 y12 b_1 z0 z4 z8 z12 x1 x5 x9 x13 b_2 y1 y5 y9 y13 z1 z5 z9 z13 b_3 x2 x6 x10 x14 y2 y6 y10 y14 b_4 z2 z6 z10 z14 x3 x7 x11 x15 b_5 y3 y7 y11 y15 z3 z7 z11 z15
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 3 a_0 x0 x2 x4 x6 x8 x10 x12 x14 a_1 y0 y2 y4 y6 y8 y10 y12 y14 a_2 z0 z2 z4 z6 z8 z10 z12 z14 a_3 x1 x3 x5 x7 x9 x11 x13 x15 a_4 y1 y3 y5 y7 y9 y11 y13 y15 a_5 z1 z3 z5 z7 z9 z11 z13 z15
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                // 4 b_0 x0 x1 x2 x3 x4 x5 x6 x7 b_1 x8 x9 x10 x11 x12 x13 x14 x15 b_2 y0 y1 y2 y3 y4 y5 y6 y7 b_3 y8 y9 y10 y11 y12 y13 y14 y15 b_4 z0 z1 z2 z3 z4 z5 z6 z7 b_5 z8 z9 z10 z11 z12 z13 z14 z15
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                xB = b_1;
                y = b_2;
                yB = b_3;
                z = b_4;
                zB = b_5;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3UnzipX2_Zip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, Vector128<int> data4, Vector128<int> data5, out Vector128<int> xB, out Vector128<int> y, out Vector128<int> yB, out Vector128<int> z, out Vector128<int> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), data4.AsUInt32(), data5.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsInt32();
                y = d2.AsInt32();
                yB = d3.AsInt32();
                z = d4.AsInt32();
                zB = d5.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3UnzipX2_Zip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, Vector128<uint> data4, Vector128<uint> data5, out Vector128<uint> xB, out Vector128<uint> y, out Vector128<uint> yB, out Vector128<uint> z, out Vector128<uint> zB) {
                Vector128<uint> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 z0 x1 data1 y1 z1 x2 y2 data2 z2 x3 y3 z3 data3 x4 y4 z4 x5 data4 y5 z5 x6 y6 data5 z6 x7 y7 z7
                // 1 a_0 x0 x4 y0 y4 a_1 z0 z4 x1 x5 a_2 y1 y5 z1 z5 a_3 x2 x6 y2 y6 a_4 z2 z6 x3 x7 a_5 y3 y7 z3 z7
                a_0 = YGroup2Zip(data0, data3, out a_1);
                a_2 = YGroup2Zip(data1, data4, out a_3);
                a_4 = YGroup2Zip(data2, data5, out a_5);
                // 2 b_0 x0 x2 x4 x6 b_1 y0 y2 y4 y6 b_2 z0 z2 z4 z6 b_3 x1 x3 x5 x7 b_4 y1 y3 y5 y7 b_5 z1 z3 z5 z7
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                // 3 a_0 x0 x1 x2 x3 a_1 x4 x5 x6 x7 a_2 y0 y1 y2 y3 a_3 y4 y5 y6 y7 a_4 z0 z1 z2 z3 a_5 z4 z5 z6 z7
                a_0 = YGroup2Zip(b_0, b_3, out a_1);
                a_2 = YGroup2Zip(b_1, b_4, out a_3);
                a_4 = YGroup2Zip(b_2, b_5, out a_5);
                xB = a_1;
                y = a_2;
                yB = a_3;
                z = a_4;
                zB = a_5;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3UnzipX2_Zip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, Vector128<long> data4, Vector128<long> data5, out Vector128<long> xB, out Vector128<long> y, out Vector128<long> yB, out Vector128<long> z, out Vector128<long> zB) {
                var d0 = YGroup3UnzipX2_Zip(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), data4.AsUInt64(), data5.AsUInt64(), out var d1, out var d2, out var d3, out var d4, out var d5);
                xB = d1.AsInt64();
                y = d2.AsInt64();
                yB = d3.AsInt64();
                z = d4.AsInt64();
                zB = d5.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3UnzipX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3UnzipX2_Zip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, Vector128<ulong> data4, Vector128<ulong> data5, out Vector128<ulong> xB, out Vector128<ulong> y, out Vector128<ulong> yB, out Vector128<ulong> z, out Vector128<ulong> zB) {
                Vector128<ulong> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 data0 x0 y0 data1 z0 x1 data2 y1 z1 data3 x2 y2 data4 z2 x3 data5 y3 z3
                // 1 a_0 x0 x2 a_1 y0 y2 a_2 z0 z2 a_3 x1 x3 a_4 y1 y3 a_5 z1 z3
                a_0 = YGroup2Zip(data0, data3, out a_1);
                a_2 = YGroup2Zip(data1, data4, out a_3);
                a_4 = YGroup2Zip(data2, data5, out a_5);
                // 2 b_0 x0 x1 b_1 x2 x3 b_2 y0 y1 b_3 y2 y3 b_4 z0 z1 b_5 z2 z3
                b_0 = YGroup2Zip(a_0, a_3, out b_1);
                b_2 = YGroup2Zip(a_1, a_4, out b_3);
                b_4 = YGroup2Zip(a_2, a_5, out b_5);
                xB = b_1;
                y = b_2;
                yB = b_3;
                z = b_4;
                zB = b_5;
                return b_0;
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3Zip_AcceleratedTypes {
                get {
                    return YGroup2Unzip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z, out Vector128<float> data1, out Vector128<float> data2) {
                return YGroup3Zip_ShuffleXImm(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z, out Vector128<double> data1, out Vector128<double> data2) {
                return YGroup3Zip_ShuffleXImm(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, out Vector128<sbyte> data1, out Vector128<sbyte> data2) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup3Zip_ShuffleX(x, y, z, out data1, out data2);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup3Zip_Shuffle(x, y, z, out data1, out data2);
                }
                return YGroup3Zip_ByX2Unzip(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, out Vector128<byte> data1, out Vector128<byte> data2) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup3Zip_ShuffleX(x, y, z, out data1, out data2);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup3Zip_Shuffle(x, y, z, out data1, out data2);
                }
                return YGroup3Zip_ByX2Unzip(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z, out Vector128<short> data1, out Vector128<short> data2) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup3Zip_ShuffleX(x, y, z, out data1, out data2);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup3Zip_Shuffle(x, y, z, out data1, out data2);
                }
                return YGroup3Zip_ByX2Unzip(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, out Vector128<ushort> data1, out Vector128<ushort> data2) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup3Zip_ShuffleX(x, y, z, out data1, out data2);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup3Zip_Shuffle(x, y, z, out data1, out data2);
                }
                return YGroup3Zip_ByX2Unzip(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z, out Vector128<int> data1, out Vector128<int> data2) {
                return YGroup3Zip_ShuffleXImm(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, out Vector128<uint> data1, out Vector128<uint> data2) {
                return YGroup3Zip_ShuffleXImm(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z, out Vector128<long> data1, out Vector128<long> data2) {
                return YGroup3Zip_ShuffleXImm(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, out Vector128<ulong> data1, out Vector128<ulong> data2) {
                return YGroup3Zip_ShuffleXImm(x, y, z, out data1, out data2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3Zip_ByX2Unzip(Vector128<float> x, Vector128<float> y, Vector128<float> z, out Vector128<float> data1, out Vector128<float> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3Zip_ByX2Unzip(Vector128<double> x, Vector128<double> y, Vector128<double> z, out Vector128<double> data1, out Vector128<double> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3Zip_ByX2Unzip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, out Vector128<sbyte> data1, out Vector128<sbyte> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3Zip_ByX2Unzip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, out Vector128<byte> data1, out Vector128<byte> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3Zip_ByX2Unzip(Vector128<short> x, Vector128<short> y, Vector128<short> z, out Vector128<short> data1, out Vector128<short> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3Zip_ByX2Unzip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, out Vector128<ushort> data1, out Vector128<ushort> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3Zip_ByX2Unzip(Vector128<int> x, Vector128<int> y, Vector128<int> z, out Vector128<int> data1, out Vector128<int> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3Zip_ByX2Unzip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, out Vector128<uint> data1, out Vector128<uint> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3Zip_ByX2Unzip(Vector128<long> x, Vector128<long> y, Vector128<long> z, out Vector128<long> data1, out Vector128<long> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3Zip_ByX2Unzip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, out Vector128<ulong> data1, out Vector128<ulong> data2) {
                return YGroup3ZipX2_Unzip(x, x, y, y, z, z, out data1, out data2, out _, out _, out _);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3Zip_Shuffle(Vector128<float> x, Vector128<float> y, Vector128<float> z, out Vector128<float> data1, out Vector128<float> data2) {
                var d0 = YGroup3Zip_Shuffle(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), out var d1, out var d2);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3Zip_Shuffle(Vector128<double> x, Vector128<double> y, Vector128<double> z, out Vector128<double> data1, out Vector128<double> data2) {
                var d0 = YGroup3Zip_Shuffle(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), out var d1, out var d2);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3Zip_Shuffle(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, out Vector128<sbyte> data1, out Vector128<sbyte> data2) {
                var d0 = YGroup3Zip_Shuffle(x.AsByte(), y.AsByte(), z.AsByte(), out var d1, out var d2);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3Zip_Shuffle(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, out Vector128<byte> data1, out Vector128<byte> data2) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup3Zip_Shuffle_Byte_X_Part0;
                var f0B = Vector128Constants.YGroup3Zip_Shuffle_Byte_X_Part1;
                var f0C = Vector128Constants.YGroup3Zip_Shuffle_Byte_X_Part2;
                var f1A = Vector128Constants.YGroup3Zip_Shuffle_Byte_Y_Part0;
                var f1B = Vector128Constants.YGroup3Zip_Shuffle_Byte_Y_Part1;
                var f1C = Vector128Constants.YGroup3Zip_Shuffle_Byte_Y_Part2;
                var f2A = Vector128Constants.YGroup3Zip_Shuffle_Byte_Z_Part0;
                var f2B = Vector128Constants.YGroup3Zip_Shuffle_Byte_Z_Part1;
                var f2C = Vector128Constants.YGroup3Zip_Shuffle_Byte_Z_Part2;
                var rt0 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(x, f0A), Ssse3.Shuffle(y, f0B)), Ssse3.Shuffle(z, f0C));
                var rt1 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(x, f1A), Ssse3.Shuffle(y, f1B)), Ssse3.Shuffle(z, f1C));
                var rt2 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(x, f2A), Ssse3.Shuffle(y, f2B)), Ssse3.Shuffle(z, f2C));
                data1 = rt1;
                data2 = rt2;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3Zip_Shuffle(Vector128<short> x, Vector128<short> y, Vector128<short> z, out Vector128<short> data1, out Vector128<short> data2) {
                var d0 = YGroup3Zip_Shuffle(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), out var d1, out var d2);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3Zip_Shuffle(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, out Vector128<ushort> data1, out Vector128<ushort> data2) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt16_X_Part0;
                var f0B = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt16_X_Part1;
                var f0C = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt16_X_Part2;
                var f1A = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt16_Y_Part0;
                var f1B = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt16_Y_Part1;
                var f1C = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt16_Y_Part2;
                var f2A = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt16_Z_Part0;
                var f2B = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt16_Z_Part1;
                var f2C = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt16_Z_Part2;
                var s0 = x.AsByte();
                var s1 = y.AsByte();
                var s2 = z.AsByte();
                var rt0 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(s0, f0A), Ssse3.Shuffle(s1, f0B)), Ssse3.Shuffle(s2, f0C)).AsUInt16();
                var rt1 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(s0, f1A), Ssse3.Shuffle(s1, f1B)), Ssse3.Shuffle(s2, f1C)).AsUInt16();
                var rt2 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(s0, f2A), Ssse3.Shuffle(s1, f2B)), Ssse3.Shuffle(s2, f2C)).AsUInt16();
                data1 = rt1;
                data2 = rt2;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3Zip_Shuffle(Vector128<int> x, Vector128<int> y, Vector128<int> z, out Vector128<int> data1, out Vector128<int> data2) {
                var d0 = YGroup3Zip_Shuffle(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), out var d1, out var d2);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3Zip_Shuffle(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, out Vector128<uint> data1, out Vector128<uint> data2) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt32_X_Part0;
                var f0B = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt32_X_Part1;
                var f0C = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt32_X_Part2;
                var f1A = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt32_Y_Part0;
                var f1B = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt32_Y_Part1;
                var f1C = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt32_Y_Part2;
                var f2A = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt32_Z_Part0;
                var f2B = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt32_Z_Part1;
                var f2C = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt32_Z_Part2;
                var s0 = x.AsByte();
                var s1 = y.AsByte();
                var s2 = z.AsByte();
                var rt0 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(s0, f0A), Ssse3.Shuffle(s1, f0B)), Ssse3.Shuffle(s2, f0C)).AsUInt32();
                var rt1 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(s0, f1A), Ssse3.Shuffle(s1, f1B)), Ssse3.Shuffle(s2, f1C)).AsUInt32();
                var rt2 = Sse2.Or(Sse2.Or(Ssse3.Shuffle(s0, f2A), Ssse3.Shuffle(s1, f2B)), Ssse3.Shuffle(s2, f2C)).AsUInt32();
                data1 = rt1;
                data2 = rt2;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3Zip_Shuffle(Vector128<long> x, Vector128<long> y, Vector128<long> z, out Vector128<long> data1, out Vector128<long> data2) {
                var d0 = YGroup3Zip_Shuffle(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), out var d1, out var d2);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3Zip_Shuffle(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, out Vector128<ulong> data1, out Vector128<ulong> data2) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt64_X_Part0;
                var f0B = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt64_X_Part1;
                var f1A = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt64_Y_Part0;
                var f1C = f0A;
                var f2B = Vector128Constants.YGroup3Zip_ShuffleOnByte_UInt64_Z_Part1;
                var f2C = f1A;
                var s0 = x.AsByte();
                var s1 = y.AsByte();
                var s2 = z.AsByte();
                var rt0 = Sse2.Or(Ssse3.Shuffle(s0, f0A), Ssse3.Shuffle(s1, f0B)).AsUInt64();
                var rt1 = Sse2.Or(Ssse3.Shuffle(s0, f1A), Ssse3.Shuffle(s2, f1C)).AsUInt64();
                var rt2 = Sse2.Or(Ssse3.Shuffle(s1, f2B), Ssse3.Shuffle(s2, f2C)).AsUInt64();
                data1 = rt1;
                data2 = rt2;
                return rt0;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3Zip_ShuffleX(Vector128<float> x, Vector128<float> y, Vector128<float> z, out Vector128<float> data1, out Vector128<float> data2) {
                var d0 = YGroup3Zip_ShuffleX(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), out var d1, out var d2);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3Zip_ShuffleX(Vector128<double> x, Vector128<double> y, Vector128<double> z, out Vector128<double> data1, out Vector128<double> data2) {
                var d0 = YGroup3Zip_ShuffleX(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), out var d1, out var d2);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3Zip_ShuffleX(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, out Vector128<sbyte> data1, out Vector128<sbyte> data2) {
                var d0 = YGroup3Zip_ShuffleX(x.AsByte(), y.AsByte(), z.AsByte(), out var d1, out var d2);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3Zip_ShuffleX(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, out Vector128<byte> data1, out Vector128<byte> data2) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                var f0 = Vector128Constants.YGroup3Zip_Shuffle_Byte_X;
                var f0C = Vector128Constants.YGroup3Zip_Shuffle_Byte_X_Part2Combine;
                var f1 = Vector128Constants.YGroup3Zip_Shuffle_Byte_Y;
                var f1C = Vector128Constants.YGroup3Zip_Shuffle_Byte_Y_Part2Combine;
                var f2 = Vector128Constants.YGroup3Zip_Shuffle_Byte_Z;
                var f2C = Vector128Constants.YGroup3Zip_Shuffle_Byte_Z_Part2Combine;
                var rt0 = Avx512Vbmi.VL.PermuteVar16x8x2(x, f0, y);
                var rt1 = Avx512Vbmi.VL.PermuteVar16x8x2(x, f1, y);
                var rt2 = Avx512Vbmi.VL.PermuteVar16x8x2(x, f2, y);
                rt0 = Avx512Vbmi.VL.PermuteVar16x8x2(z, f0C, rt0);
                rt1 = Avx512Vbmi.VL.PermuteVar16x8x2(z, f1C, rt1);
                rt2 = Avx512Vbmi.VL.PermuteVar16x8x2(z, f2C, rt2);
                data1 = rt1;
                data2 = rt2;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3Zip_ShuffleX(Vector128<short> x, Vector128<short> y, Vector128<short> z, out Vector128<short> data1, out Vector128<short> data2) {
                var d0 = YGroup3Zip_ShuffleX(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), out var d1, out var d2);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3Zip_ShuffleX(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, out Vector128<ushort> data1, out Vector128<ushort> data2) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                var f0 = Vector128Constants.YGroup3Zip_Shuffle_UInt16_X;
                var f0C = Vector128Constants.YGroup3Zip_Shuffle_UInt16_X_Part2Combine;
                var f1 = Vector128Constants.YGroup3Zip_Shuffle_UInt16_Y;
                var f1C = Vector128Constants.YGroup3Zip_Shuffle_UInt16_Y_Part2Combine;
                var f2 = Vector128Constants.YGroup3Zip_Shuffle_UInt16_Z;
                var f2C = Vector128Constants.YGroup3Zip_Shuffle_UInt16_Z_Part2Combine;
                var rt0 = Avx512BW.VL.PermuteVar8x16x2(x, f0, y);
                var rt1 = Avx512BW.VL.PermuteVar8x16x2(x, f1, y);
                var rt2 = Avx512BW.VL.PermuteVar8x16x2(x, f2, y);
                rt0 = Avx512BW.VL.PermuteVar8x16x2(z, f0C, rt0);
                rt1 = Avx512BW.VL.PermuteVar8x16x2(z, f1C, rt1);
                rt2 = Avx512BW.VL.PermuteVar8x16x2(z, f2C, rt2);
                data1 = rt1;
                data2 = rt2;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3Zip_ShuffleX(Vector128<int> x, Vector128<int> y, Vector128<int> z, out Vector128<int> data1, out Vector128<int> data2) {
                var d0 = YGroup3Zip_ShuffleX(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), out var d1, out var d2);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3Zip_ShuffleX(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, out Vector128<uint> data1, out Vector128<uint> data2) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var f0 = Vector128Constants.YGroup3Zip_Shuffle_UInt32_X;
                var f0C = Vector128Constants.YGroup3Zip_Shuffle_UInt32_X_Part2Combine;
                var f1 = Vector128Constants.YGroup3Zip_Shuffle_UInt32_Y;
                var f1C = Vector128Constants.YGroup3Zip_Shuffle_UInt32_Y_Part2Combine;
                var f2 = Vector128Constants.YGroup3Zip_Shuffle_UInt32_Z;
                var f2C = Vector128Constants.YGroup3Zip_Shuffle_UInt32_Z_Part2Combine;
                var rt0 = Avx512F.VL.PermuteVar4x32x2(x, f0, y);
                var rt1 = Avx512F.VL.PermuteVar4x32x2(x, f1, y);
                var rt2 = Avx512F.VL.PermuteVar4x32x2(x, f2, y);
                rt0 = Avx512F.VL.PermuteVar4x32x2(z, f0C, rt0);
                rt1 = Avx512F.VL.PermuteVar4x32x2(z, f1C, rt1);
                rt2 = Avx512F.VL.PermuteVar4x32x2(z, f2C, rt2);
                data1 = rt1;
                data2 = rt2;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3Zip_ShuffleX(Vector128<long> x, Vector128<long> y, Vector128<long> z, out Vector128<long> data1, out Vector128<long> data2) {
                var d0 = YGroup3Zip_ShuffleX(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), out var d1, out var d2);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3Zip_ShuffleX(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, out Vector128<ulong> data1, out Vector128<ulong> data2) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var f0 = Vector128Constants.YGroup3Zip_Shuffle_UInt64_X;
                var f1 = Vector128Constants.YGroup3Zip_Shuffle_UInt64_Y_On20;
                var f2 = Vector128Constants.YGroup3Zip_Shuffle_UInt64_Z_On12;
                var rt0 = Avx512F.VL.PermuteVar2x64x2(x, f0, y);
                var rt1 = Avx512F.VL.PermuteVar2x64x2(z, f1, x);
                var rt2 = Avx512F.VL.PermuteVar2x64x2(y, f2, z);
                data1 = rt1;
                data2 = rt2;
                return rt0;
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3Zip_ShuffleXImm(Vector128<float> x, Vector128<float> y, Vector128<float> z, out Vector128<float> data1, out Vector128<float> data2) {
                Vector128<float> a_0, a_1, a_2, b_0, b_1, b_2;
                // 0 data0 x0 x1 x2 x3 data1 y0 y1 y2 y3 data2 z0 z1 z2 z3
                // 1 a_0 x0 x2 y0 y2 a_1 y1 y3 z1 z3 a_2 z0 z2 x1 x3
                a_0 = Sse.Shuffle(x, y, (byte)ShuffleControlG4.XZXZ);
                a_1 = Sse.Shuffle(y, z, (byte)ShuffleControlG4.YWYW);
                a_2 = Sse.Shuffle(z, x, (byte)ShuffleControlG4.XZYW);
                // 2 b_0 x0 y0 z0 x1 b_1 y1 z1 x2 y2 b_2 z2 x3 y3 z3
                b_0 = Sse.Shuffle(a_0, a_2, (byte)ShuffleControlG4.XZXZ);
                b_1 = Sse.Shuffle(a_1, a_0, (byte)ShuffleControlG4.XZYW);
                b_2 = Sse.Shuffle(a_2, a_1, (byte)ShuffleControlG4.YWYW);
                data1 = b_1;
                data2 = b_2;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3Zip_ShuffleXImm(Vector128<double> x, Vector128<double> y, Vector128<double> z, out Vector128<double> data1, out Vector128<double> data2) {
                // 0 data0 x0 x1 data1 y0 y1 data2 z0 z1
                // 1 a_0 x0 y0 a_1 z0 x1 a_2 y1 z1
                var a0 = Sse2.Shuffle(x, y, (byte)ShuffleControlG2.XX);
                var a1 = Sse2.Shuffle(z, x, (byte)ShuffleControlG2.XY);
                var a2 = Sse2.Shuffle(y, z, (byte)ShuffleControlG2.YY);
                data1 = a1;
                data2 = a2;
                return a0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3Zip_ShuffleXImm(Vector128<int> x, Vector128<int> y, Vector128<int> z, out Vector128<int> data1, out Vector128<int> data2) {
                var d0 = YGroup3Zip_ShuffleXImm(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), out var d1, out var d2);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3Zip_ShuffleXImm(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, out Vector128<uint> data1, out Vector128<uint> data2) {
                var d0 = YGroup3Zip_ShuffleXImm(x.AsSingle(), y.AsSingle(), z.AsSingle(), out var d1, out var d2);
                data1 = d1.AsUInt32();
                data2 = d2.AsUInt32();
                return d0.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3Zip_ShuffleXImm(Vector128<long> x, Vector128<long> y, Vector128<long> z, out Vector128<long> data1, out Vector128<long> data2) {
                var d0 = YGroup3Zip_ShuffleXImm(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), out var d1, out var d2);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3Zip_ShuffleXImm(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, out Vector128<ulong> data1, out Vector128<ulong> data2) {
                var d0 = YGroup3Zip_ShuffleXImm(x.AsDouble(), y.AsDouble(), z.AsDouble(), out var d1, out var d2);
                data1 = d1.AsUInt64();
                data2 = d2.AsUInt64();
                return d0.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup3ZipX2_AcceleratedTypes {
                get {
                    return YGroup2Zip_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3ZipX2(Vector128<float> x, Vector128<float> xB, Vector128<float> y, Vector128<float> yB, Vector128<float> z, Vector128<float> zB, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3, out Vector128<float> data4, out Vector128<float> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3ZipX2(Vector128<double> x, Vector128<double> xB, Vector128<double> y, Vector128<double> yB, Vector128<double> z, Vector128<double> zB, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3, out Vector128<double> data4, out Vector128<double> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3ZipX2(Vector128<sbyte> x, Vector128<sbyte> xB, Vector128<sbyte> y, Vector128<sbyte> yB, Vector128<sbyte> z, Vector128<sbyte> zB, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3, out Vector128<sbyte> data4, out Vector128<sbyte> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3ZipX2(Vector128<byte> x, Vector128<byte> xB, Vector128<byte> y, Vector128<byte> yB, Vector128<byte> z, Vector128<byte> zB, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3, out Vector128<byte> data4, out Vector128<byte> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
                //return YGroup3ZipX2_Unzip(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3ZipX2(Vector128<short> x, Vector128<short> xB, Vector128<short> y, Vector128<short> yB, Vector128<short> z, Vector128<short> zB, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3, out Vector128<short> data4, out Vector128<short> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3ZipX2(Vector128<ushort> x, Vector128<ushort> xB, Vector128<ushort> y, Vector128<ushort> yB, Vector128<ushort> z, Vector128<ushort> zB, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3, out Vector128<ushort> data4, out Vector128<ushort> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3ZipX2(Vector128<int> x, Vector128<int> xB, Vector128<int> y, Vector128<int> yB, Vector128<int> z, Vector128<int> zB, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3, out Vector128<int> data4, out Vector128<int> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3ZipX2(Vector128<uint> x, Vector128<uint> xB, Vector128<uint> y, Vector128<uint> yB, Vector128<uint> z, Vector128<uint> zB, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3, out Vector128<uint> data4, out Vector128<uint> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3ZipX2(Vector128<long> x, Vector128<long> xB, Vector128<long> y, Vector128<long> yB, Vector128<long> z, Vector128<long> zB, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3, out Vector128<long> data4, out Vector128<long> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3ZipX2(Vector128<ulong> x, Vector128<ulong> xB, Vector128<ulong> y, Vector128<ulong> yB, Vector128<ulong> z, Vector128<ulong> zB, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3, out Vector128<ulong> data4, out Vector128<ulong> data5) {
                return YGroup3ZipX2_X2(x, xB, y, yB, z, zB, out data1, out data2, out data3, out data4, out data5);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3ZipX2_Unzip(Vector128<float> x, Vector128<float> xB, Vector128<float> y, Vector128<float> yB, Vector128<float> z, Vector128<float> zB, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3, out Vector128<float> data4, out Vector128<float> data5) {
                Vector128<float> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 _x_ x0 x1 x2 x3 _xB x4 x5 x6 x7 _y_ y0 y1 y2 y3 _yB y4 y5 y6 y7 _z_ z0 z1 z2 z3 _zB z4 z5 z6 z7
                // 1 a_0 x0 x2 x4 x6 a_1 y0 y2 y4 y6 a_2 z0 z2 z4 z6 a_3 x1 x3 x5 x7 a_4 y1 y3 y5 y7 a_5 z1 z3 z5 z7
                a_0 = YGroup2Unzip(x, xB, out a_3);
                a_1 = YGroup2Unzip(y, yB, out a_4);
                a_2 = YGroup2Unzip(z, zB, out a_5);
                // 2 b_0 x0 x4 y0 y4 b_1 z0 z4 x1 x5 b_2 y1 y5 z1 z5 b_3 x2 x6 y2 y6 b_4 z2 z6 x3 x7 b_5 y3 y7 z3 z7
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 3 a_0 x0 y0 z0 x1 a_1 y1 z1 x2 y2 a_2 z2 x3 y3 z3 a_3 x4 y4 z4 x5 a_4 y5 z5 x6 y6 a_5 z6 x7 y7 z7
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                data4 = a_4;
                data5 = a_5;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_Unzip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3ZipX2_Unzip(Vector128<double> x, Vector128<double> xB, Vector128<double> y, Vector128<double> yB, Vector128<double> z, Vector128<double> zB, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3, out Vector128<double> data4, out Vector128<double> data5) {
                Vector128<double> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 _x_ x0 x1 _xB x2 x3 _y_ y0 y1 _yB y2 y3 _z_ z0 z1 _zB z2 z3
                // 1 a_0 x0 x2 a_1 y0 y2 a_2 z0 z2 a_3 x1 x3 a_4 y1 y3 a_5 z1 z3
                a_0 = YGroup2Unzip(x, xB, out a_3);
                a_1 = YGroup2Unzip(y, yB, out a_4);
                a_2 = YGroup2Unzip(z, zB, out a_5);
                // 2 b_0 x0 y0 b_1 z0 x1 b_2 y1 z1 b_3 x2 y2 b_4 z2 x3 b_5 y3 z3
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                data4 = b_4;
                data5 = b_5;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3ZipX2_Unzip(Vector128<sbyte> x, Vector128<sbyte> xB, Vector128<sbyte> y, Vector128<sbyte> yB, Vector128<sbyte> z, Vector128<sbyte> zB, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3, out Vector128<sbyte> data4, out Vector128<sbyte> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsByte(), xB.AsByte(), y.AsByte(), yB.AsByte(), z.AsByte(), zB.AsByte(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                data4 = d4.AsSByte();
                data5 = d5.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3ZipX2_Unzip(Vector128<byte> x, Vector128<byte> xB, Vector128<byte> y, Vector128<byte> yB, Vector128<byte> z, Vector128<byte> zB, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3, out Vector128<byte> data4, out Vector128<byte> data5) {
                Vector128<byte> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 x16 x17 x18 x19 x20 x21 x22 x23 x24 x25 x26 x27 x28 x29 x30 x31 b_2 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 b_3 y16 y17 y18 y19 y20 y21 y22 y23 y24 y25 y26 y27 y28 y29 y30 y31 b_4 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 b_5 z16 z17 z18 z19 z20 z21 z22 z23 z24 z25 z26 z27 z28 z29 z30 z31
                // 1 a_0 x0 x2 x4 x6 x8 x10 x12 x14 x16 x18 x20 x22 x24 x26 x28 x30 a_1 y0 y2 y4 y6 y8 y10 y12 y14 y16 y18 y20 y22 y24 y26 y28 y30 a_2 z0 z2 z4 z6 z8 z10 z12 z14 z16 z18 z20 z22 z24 z26 z28 z30 a_3 x1 x3 x5 x7 x9 x11 x13 x15 x17 x19 x21 x23 x25 x27 x29 x31 a_4 y1 y3 y5 y7 y9 y11 y13 y15 y17 y19 y21 y23 y25 y27 y29 y31 a_5 z1 z3 z5 z7 z9 z11 z13 z15 z17 z19 z21 z23 z25 z27 z29 z31
                a_0 = YGroup2Unzip(x, xB, out a_3);
                a_1 = YGroup2Unzip(y, yB, out a_4);
                a_2 = YGroup2Unzip(z, zB, out a_5);
                // 2 b_0 x0 x4 x8 x12 x16 x20 x24 x28 y0 y4 y8 y12 y16 y20 y24 y28 b_1 z0 z4 z8 z12 z16 z20 z24 z28 x1 x5 x9 x13 x17 x21 x25 x29 b_2 y1 y5 y9 y13 y17 y21 y25 y29 z1 z5 z9 z13 z17 z21 z25 z29 b_3 x2 x6 x10 x14 x18 x22 x26 x30 y2 y6 y10 y14 y18 y22 y26 y30 b_4 z2 z6 z10 z14 z18 z22 z26 z30 x3 x7 x11 x15 x19 x23 x27 x31 b_5 y3 y7 y11 y15 y19 y23 y27 y31 z3 z7 z11 z15 z19 z23 z27 z31
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 3 a_0 x0 x8 x16 x24 y0 y8 y16 y24 z0 z8 z16 z24 x1 x9 x17 x25 a_1 y1 y9 y17 y25 z1 z9 z17 z25 x2 x10 x18 x26 y2 y10 y18 y26 a_2 z2 z10 z18 z26 x3 x11 x19 x27 y3 y11 y19 y27 z3 z11 z19 z27 a_3 x4 x12 x20 x28 y4 y12 y20 y28 z4 z12 z20 z28 x5 x13 x21 x29 a_4 y5 y13 y21 y29 z5 z13 z21 z29 x6 x14 x22 x30 y6 y14 y22 y30 a_5 z6 z14 z22 z30 x7 x15 x23 x31 y7 y15 y23 y31 z7 z15 z23 z31
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                // 4 b_0 x0 x16 y0 y16 z0 z16 x1 x17 y1 y17 z1 z17 x2 x18 y2 y18 b_1 z2 z18 x3 x19 y3 y19 z3 z19 x4 x20 y4 y20 z4 z20 x5 x21 b_2 y5 y21 z5 z21 x6 x22 y6 y22 z6 z22 x7 x23 y7 y23 z7 z23 b_3 x8 x24 y8 y24 z8 z24 x9 x25 y9 y25 z9 z25 x10 x26 y10 y26 b_4 z10 z26 x11 x27 y11 y27 z11 z27 x12 x28 y12 y28 z12 z28 x13 x29 b_5 y13 y29 z13 z29 x14 x30 y14 y30 z14 z30 x15 x31 y15 y31 z15 z31
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 5 a_0 x0 y0 z0 x1 y1 z1 x2 y2 z2 x3 y3 z3 x4 y4 z4 x5 a_1 y5 z5 x6 y6 z6 x7 y7 z7 x8 y8 z8 x9 y9 z9 x10 y10 a_2 z10 x11 y11 z11 x12 y12 z12 x13 y13 z13 x14 y14 z14 x15 y15 z15 a_3 x16 y16 z16 x17 y17 z17 x18 y18 z18 x19 y19 z19 x20 y20 z20 x21 a_4 y21 z21 x22 y22 z22 x23 y23 z23 x24 y24 z24 x25 y25 z25 x26 y26 a_5 z26 x27 y27 z27 x28 y28 z28 x29 y29 z29 x30 y30 z30 x31 y31 z31
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                data4 = a_4;
                data5 = a_5;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_Unzip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3ZipX2_Unzip(Vector128<short> x, Vector128<short> xB, Vector128<short> y, Vector128<short> yB, Vector128<short> z, Vector128<short> zB, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3, out Vector128<short> data4, out Vector128<short> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsUInt16(), xB.AsUInt16(), y.AsUInt16(), yB.AsUInt16(), z.AsUInt16(), zB.AsUInt16(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                data4 = d4.AsInt16();
                data5 = d5.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3ZipX2_Unzip(Vector128<ushort> x, Vector128<ushort> xB, Vector128<ushort> y, Vector128<ushort> yB, Vector128<ushort> z, Vector128<ushort> zB, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3, out Vector128<ushort> data4, out Vector128<ushort> data5) {
                Vector128<ushort> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 _xB x8 x9 x10 x11 x12 x13 x14 x15 _y_ y0 y1 y2 y3 y4 y5 y6 y7 _yB y8 y9 y10 y11 y12 y13 y14 y15 _z_ z0 z1 z2 z3 z4 z5 z6 z7 _zB z8 z9 z10 z11 z12 z13 z14 z15
                // 1 a_0 x0 x2 x4 x6 x8 x10 x12 x14 a_1 y0 y2 y4 y6 y8 y10 y12 y14 a_2 z0 z2 z4 z6 z8 z10 z12 z14 a_3 x1 x3 x5 x7 x9 x11 x13 x15 a_4 y1 y3 y5 y7 y9 y11 y13 y15 a_5 z1 z3 z5 z7 z9 z11 z13 z15
                a_0 = YGroup2Unzip(x, xB, out a_3);
                a_1 = YGroup2Unzip(y, yB, out a_4);
                a_2 = YGroup2Unzip(z, zB, out a_5);
                // 2 b_0 x0 x4 x8 x12 y0 y4 y8 y12 b_1 z0 z4 z8 z12 x1 x5 x9 x13 b_2 y1 y5 y9 y13 z1 z5 z9 z13 b_3 x2 x6 x10 x14 y2 y6 y10 y14 b_4 z2 z6 z10 z14 x3 x7 x11 x15 b_5 y3 y7 y11 y15 z3 z7 z11 z15
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 3 a_0 x0 x8 y0 y8 z0 z8 x1 x9 a_1 y1 y9 z1 z9 x2 x10 y2 y10 a_2 z2 z10 x3 x11 y3 y11 z3 z11 a_3 x4 x12 y4 y12 z4 z12 x5 x13 a_4 y5 y13 z5 z13 x6 x14 y6 y14 a_5 z6 z14 x7 x15 y7 y15 z7 z15
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                // 4 b_0 x0 y0 z0 x1 y1 z1 x2 y2 b_1 z2 x3 y3 z3 x4 y4 z4 x5 b_2 y5 z5 x6 y6 z6 x7 y7 z7 b_3 x8 y8 z8 x9 y9 z9 x10 y10 b_4 z10 x11 y11 z11 x12 y12 z12 x13 b_5 y13 z13 x14 y14 z14 x15 y15 z15
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                data4 = b_4;
                data5 = b_5;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_Unzip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3ZipX2_Unzip(Vector128<int> x, Vector128<int> xB, Vector128<int> y, Vector128<int> yB, Vector128<int> z, Vector128<int> zB, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3, out Vector128<int> data4, out Vector128<int> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsUInt32(), xB.AsUInt32(), y.AsUInt32(), yB.AsUInt32(), z.AsUInt32(), zB.AsUInt32(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                data4 = d4.AsInt32();
                data5 = d5.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3ZipX2_Unzip(Vector128<uint> x, Vector128<uint> xB, Vector128<uint> y, Vector128<uint> yB, Vector128<uint> z, Vector128<uint> zB, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3, out Vector128<uint> data4, out Vector128<uint> data5) {
                Vector128<uint> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 _x_ x0 x1 x2 x3 _xB x4 x5 x6 x7 _y_ y0 y1 y2 y3 _yB y4 y5 y6 y7 _z_ z0 z1 z2 z3 _zB z4 z5 z6 z7
                // 1 a_0 x0 x2 x4 x6 a_1 y0 y2 y4 y6 a_2 z0 z2 z4 z6 a_3 x1 x3 x5 x7 a_4 y1 y3 y5 y7 a_5 z1 z3 z5 z7
                a_0 = YGroup2Unzip(x, xB, out a_3);
                a_1 = YGroup2Unzip(y, yB, out a_4);
                a_2 = YGroup2Unzip(z, zB, out a_5);
                // 2 b_0 x0 x4 y0 y4 b_1 z0 z4 x1 x5 b_2 y1 y5 z1 z5 b_3 x2 x6 y2 y6 b_4 z2 z6 x3 x7 b_5 y3 y7 z3 z7
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                // 3 a_0 x0 y0 z0 x1 a_1 y1 z1 x2 y2 a_2 z2 x3 y3 z3 a_3 x4 y4 z4 x5 a_4 y5 z5 x6 y6 a_5 z6 x7 y7 z7
                a_0 = YGroup2Unzip(b_0, b_1, out a_3);
                a_1 = YGroup2Unzip(b_2, b_3, out a_4);
                a_2 = YGroup2Unzip(b_4, b_5, out a_5);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                data4 = a_4;
                data5 = a_5;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_Unzip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3ZipX2_Unzip(Vector128<long> x, Vector128<long> xB, Vector128<long> y, Vector128<long> yB, Vector128<long> z, Vector128<long> zB, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3, out Vector128<long> data4, out Vector128<long> data5) {
                var d0 = YGroup3ZipX2_Unzip(x.AsUInt64(), xB.AsUInt64(), y.AsUInt64(), yB.AsUInt64(), z.AsUInt64(), zB.AsUInt64(), out var d1, out var d2, out var d3, out var d4, out var d5);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                data3 = d3.AsInt64();
                data4 = d4.AsInt64();
                data5 = d5.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3ZipX2_Unzip(Vector128<ulong> x, Vector128<ulong> xB, Vector128<ulong> y, Vector128<ulong> yB, Vector128<ulong> z, Vector128<ulong> zB, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3, out Vector128<ulong> data4, out Vector128<ulong> data5) {
                Vector128<ulong> a_0, a_1, a_2, a_3, a_4, a_5, b_0, b_1, b_2, b_3, b_4, b_5;
                // 0 _x_ x0 x1 _xB x2 x3 _y_ y0 y1 _yB y2 y3 _z_ z0 z1 _zB z2 z3
                // 1 a_0 x0 x2 a_1 y0 y2 a_2 z0 z2 a_3 x1 x3 a_4 y1 y3 a_5 z1 z3
                a_0 = YGroup2Unzip(x, xB, out a_3);
                a_1 = YGroup2Unzip(y, yB, out a_4);
                a_2 = YGroup2Unzip(z, zB, out a_5);
                // 2 b_0 x0 y0 b_1 z0 x1 b_2 y1 z1 b_3 x2 y2 b_4 z2 x3 b_5 y3 z3
                b_0 = YGroup2Unzip(a_0, a_1, out b_3);
                b_1 = YGroup2Unzip(a_2, a_3, out b_4);
                b_2 = YGroup2Unzip(a_4, a_5, out b_5);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                data4 = b_4;
                data5 = b_5;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_X2(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup3ZipX2_X2(Vector128<float> x, Vector128<float> xB, Vector128<float> y, Vector128<float> yB, Vector128<float> z, Vector128<float> zB, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3, out Vector128<float> data4, out Vector128<float> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_X2(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup3ZipX2_X2(Vector128<double> x, Vector128<double> xB, Vector128<double> y, Vector128<double> yB, Vector128<double> z, Vector128<double> zB, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3, out Vector128<double> data4, out Vector128<double> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_X2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup3ZipX2_X2(Vector128<sbyte> x, Vector128<sbyte> xB, Vector128<sbyte> y, Vector128<sbyte> yB, Vector128<sbyte> z, Vector128<sbyte> zB, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3, out Vector128<sbyte> data4, out Vector128<sbyte> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_X2(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup3ZipX2_X2(Vector128<byte> x, Vector128<byte> xB, Vector128<byte> y, Vector128<byte> yB, Vector128<byte> z, Vector128<byte> zB, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3, out Vector128<byte> data4, out Vector128<byte> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_X2(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup3ZipX2_X2(Vector128<short> x, Vector128<short> xB, Vector128<short> y, Vector128<short> yB, Vector128<short> z, Vector128<short> zB, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3, out Vector128<short> data4, out Vector128<short> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_X2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup3ZipX2_X2(Vector128<ushort> x, Vector128<ushort> xB, Vector128<ushort> y, Vector128<ushort> yB, Vector128<ushort> z, Vector128<ushort> zB, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3, out Vector128<ushort> data4, out Vector128<ushort> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_X2(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup3ZipX2_X2(Vector128<int> x, Vector128<int> xB, Vector128<int> y, Vector128<int> yB, Vector128<int> z, Vector128<int> zB, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3, out Vector128<int> data4, out Vector128<int> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_X2(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup3ZipX2_X2(Vector128<uint> x, Vector128<uint> xB, Vector128<uint> y, Vector128<uint> yB, Vector128<uint> z, Vector128<uint> zB, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3, out Vector128<uint> data4, out Vector128<uint> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_X2(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup3ZipX2_X2(Vector128<long> x, Vector128<long> xB, Vector128<long> y, Vector128<long> yB, Vector128<long> z, Vector128<long> zB, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3, out Vector128<long> data4, out Vector128<long> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup3ZipX2_X2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup3ZipX2_X2(Vector128<ulong> x, Vector128<ulong> xB, Vector128<ulong> y, Vector128<ulong> yB, Vector128<ulong> z, Vector128<ulong> zB, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3, out Vector128<ulong> data4, out Vector128<ulong> data5) {
                var data0 = YGroup3Zip(x, y, z, out data1, out data2);
                data3 = YGroup3Zip(xB, yB, zB, out data4, out data5);
                return data0;
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4ToGroup3_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4ToGroup3(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> result1, out Vector128<float> result2) {
                //var d0 = YGroup4ToGroup3(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2);
                //result1 = d1.AsSingle();
                //result2 = d2.AsSingle();
                //return d0.AsSingle();
                return YGroup4ToGroup3_ShuffleXImm(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4ToGroup3(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> result1, out Vector128<double> result2) {
                //var d0 = YGroup4ToGroup3(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2);
                //result1 = d1.AsDouble();
                //result2 = d2.AsDouble();
                //return d0.AsDouble();
                return YGroup4ToGroup3_ShuffleXImm(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4ToGroup3(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> result1, out Vector128<sbyte> result2) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup4ToGroup3_ShuffleX(data0, data1, data2, data3, out result1, out result2);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup4ToGroup3_Shuffle(data0, data1, data2, data3, out result1, out result2);
                }
                return SuperStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4ToGroup3(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> result1, out Vector128<byte> result2) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return YGroup4ToGroup3_ShuffleX(data0, data1, data2, data3, out result1, out result2);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup4ToGroup3_Shuffle(data0, data1, data2, data3, out result1, out result2);
                }
                return SuperStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4ToGroup3(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> result1, out Vector128<short> result2) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup4ToGroup3_ShuffleX(data0, data1, data2, data3, out result1, out result2);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup4ToGroup3_Shuffle(data0, data1, data2, data3, out result1, out result2);
                }
                return SuperStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4ToGroup3(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> result1, out Vector128<ushort> result2) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return YGroup4ToGroup3_ShuffleX(data0, data1, data2, data3, out result1, out result2);
                }
#endif // NET8_0_OR_GREATER
                if (Ssse3.IsSupported) {
                    return YGroup4ToGroup3_Shuffle(data0, data1, data2, data3, out result1, out result2);
                }
                return SuperStatics.YGroup4ToGroup3(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4ToGroup3(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> result1, out Vector128<int> result2) {
                return YGroup4ToGroup3_ShuffleXImm(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4ToGroup3(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> result1, out Vector128<uint> result2) {
                return YGroup4ToGroup3_ShuffleXImm(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4ToGroup3(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> result1, out Vector128<long> result2) {
                return YGroup4ToGroup3_ShuffleXImm(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4ToGroup3(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> result1, out Vector128<ulong> result2) {
                return YGroup4ToGroup3_ShuffleXImm(data0, data1, data2, data3, out result1, out result2);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4ToGroup3_Shuffle(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> result1, out Vector128<sbyte> result2) {
                var d0 = YGroup4ToGroup3_Shuffle(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4ToGroup3_Shuffle(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> result1, out Vector128<byte> result2) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup4ToGroup3_Shuffle_Byte_0A;
                var f0B = Vector128Constants.YGroup4ToGroup3_Shuffle_Byte_0B;
                var f1A = Vector128Constants.YGroup4ToGroup3_Shuffle_Byte_1A;
                var f1B = Vector128Constants.YGroup4ToGroup3_Shuffle_Byte_1B;
                var f2A = Vector128Constants.YGroup4ToGroup3_Shuffle_Byte_2A;
                var f2B = Vector128Constants.YGroup4ToGroup3_Shuffle_Byte_2B;
                var a_0 = Sse2.Or(Ssse3.Shuffle(data0, f0A), Ssse3.Shuffle(data1, f0B));
                var a_1 = Sse2.Or(Ssse3.Shuffle(data1, f1A), Ssse3.Shuffle(data2, f1B));
                var a_2 = Sse2.Or(Ssse3.Shuffle(data2, f2A), Ssse3.Shuffle(data3, f2B));
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4ToGroup3_Shuffle(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> result1, out Vector128<short> result2) {
                var d0 = YGroup4ToGroup3_Shuffle(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4ToGroup3_Shuffle(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> result1, out Vector128<ushort> result2) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_0A;
                var f0B = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_0B;
                var f1A = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_1A;
                var f1B = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_1B;
                var f2A = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_2A;
                var f2B = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt16_2B;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var s3 = data3.AsByte();
                var a_0 = Sse2.Or(Ssse3.Shuffle(s0, f0A), Ssse3.Shuffle(s1, f0B)).AsUInt16();
                var a_1 = Sse2.Or(Ssse3.Shuffle(s1, f1A), Ssse3.Shuffle(s2, f1B)).AsUInt16();
                var a_2 = Sse2.Or(Ssse3.Shuffle(s2, f2A), Ssse3.Shuffle(s3, f2B)).AsUInt16();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4ToGroup3_Shuffle(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> result1, out Vector128<int> result2) {
                var d0 = YGroup4ToGroup3_Shuffle(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4ToGroup3_Shuffle(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> result1, out Vector128<uint> result2) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f0A = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_0A;
                var f0B = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_0B;
                var f1A = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_1A;
                var f1B = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_1B;
                var f2A = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_2A;
                var f2B = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt32_2B;
                var s0 = data0.AsByte();
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var s3 = data3.AsByte();
                var a_0 = Sse2.Or(Ssse3.Shuffle(s0, f0A), Ssse3.Shuffle(s1, f0B)).AsUInt32();
                var a_1 = Sse2.Or(Ssse3.Shuffle(s1, f1A), Ssse3.Shuffle(s2, f1B)).AsUInt32();
                var a_2 = Sse2.Or(Ssse3.Shuffle(s2, f2A), Ssse3.Shuffle(s3, f2B)).AsUInt32();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4ToGroup3_Shuffle(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> result1, out Vector128<long> result2) {
                var d0 = YGroup4ToGroup3_Shuffle(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4ToGroup3_Shuffle(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> result1, out Vector128<ulong> result2) {
                if (!Ssse3.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Ssse3");
                var f1A = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_1A;
                var f1B = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_1B;
                var f2A = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_2A;
                var f2B = Vector128Constants.YGroup4ToGroup3_ShuffleOnByte_UInt64_2B;
                var s1 = data1.AsByte();
                var s2 = data2.AsByte();
                var s3 = data3.AsByte();
                var a_0 = data0;
                var a_1 = Sse2.Or(Ssse3.Shuffle(s1, f1A), Ssse3.Shuffle(s2, f1B)).AsUInt64();
                var a_2 = Sse2.Or(Ssse3.Shuffle(s2, f2A), Ssse3.Shuffle(s3, f2B)).AsUInt64();
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4ToGroup3_ShuffleX(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> result1, out Vector128<sbyte> result2) {
                var d0 = YGroup4ToGroup3_ShuffleX(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2);
                result1 = d1.AsSByte();
                result2 = d2.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4ToGroup3_ShuffleX(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> result1, out Vector128<byte> result2) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                var f0 = Vector128Constants.YGroup4ToGroup3_Shuffle_Byte_0;
                var f1 = Vector128Constants.YGroup4ToGroup3_Shuffle_Byte_1;
                var f2 = Vector128Constants.YGroup4ToGroup3_Shuffle_Byte_2;
                var a_0 = Avx512Vbmi.VL.PermuteVar16x8x2(data0, f0, data1);
                var a_1 = Avx512Vbmi.VL.PermuteVar16x8x2(data1, f1, data2);
                var a_2 = Avx512Vbmi.VL.PermuteVar16x8x2(data2, f2, data3);
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4ToGroup3_ShuffleX(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> result1, out Vector128<short> result2) {
                var d0 = YGroup4ToGroup3_ShuffleX(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2);
                result1 = d1.AsInt16();
                result2 = d2.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4ToGroup3_ShuffleX(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> result1, out Vector128<ushort> result2) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                var f0 = Vector128Constants.YGroup4ToGroup3_Shuffle_UInt16_0;
                var f1 = Vector128Constants.YGroup4ToGroup3_Shuffle_UInt16_1;
                var f2 = Vector128Constants.YGroup4ToGroup3_Shuffle_UInt16_2;
                var a_0 = Avx512BW.VL.PermuteVar8x16x2(data0, f0, data1);
                var a_1 = Avx512BW.VL.PermuteVar8x16x2(data1, f1, data2);
                var a_2 = Avx512BW.VL.PermuteVar8x16x2(data2, f2, data3);
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4ToGroup3_ShuffleX(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> result1, out Vector128<int> result2) {
                var d0 = YGroup4ToGroup3_ShuffleX(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4ToGroup3_ShuffleX(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> result1, out Vector128<uint> result2) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var f0 = Vector128Constants.YGroup4ToGroup3_Shuffle_UInt32_0;
                var f1 = Vector128Constants.YGroup4ToGroup3_Shuffle_UInt32_1;
                var f2 = Vector128Constants.YGroup4ToGroup3_Shuffle_UInt32_2;
                var a_0 = Avx512F.VL.PermuteVar4x32x2(data0, f0, data1);
                var a_1 = Avx512F.VL.PermuteVar4x32x2(data1, f1, data2);
                var a_2 = Avx512F.VL.PermuteVar4x32x2(data2, f2, data3);
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4ToGroup3_ShuffleX(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> result1, out Vector128<long> result2) {
                var d0 = YGroup4ToGroup3_ShuffleX(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4ToGroup3_ShuffleX(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> result1, out Vector128<ulong> result2) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var f1 = Vector128Constants.YGroup4ToGroup3_Shuffle_UInt64_1;
                var f2 = Vector128Constants.YGroup4ToGroup3_Shuffle_UInt64_2;
                var a_0 = data0;
                var a_1 = Avx512F.VL.PermuteVar2x64x2(data1, f1, data2);
                var a_2 = Avx512F.VL.PermuteVar2x64x2(data2, f2, data3);
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4ToGroup3_ShuffleXImm(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> result1, out Vector128<float> result2) {
                Vector128<float> a_0, a_1, b_0, b_1, b_2;
                // 0 data0 x0 y0 z0 w0 data1 x1 y1 z1 w1 data2 x2 y2 z2 w2 data3 x3 y3 z3 w3
                // 1 a_0 x1 y1 z0 w0 a_1 x3 y3 z2 w2
                a_0 = Sse.Shuffle(data1, data0, (byte)ShuffleControlG4.XYZW);
                a_1 = Sse.Shuffle(data3, data2, (byte)ShuffleControlG4.XYZW);
                // 2 b_0 x0 y0 z0 x1 b_1 y1 z1 x2 y2 b_2 z2 x3 y3 z3
                b_0 = Sse.Shuffle(data0, a_0, (byte)ShuffleControlG4.XYZX);
                b_1 = Sse.Shuffle(data1, data2, (byte)ShuffleControlG4.YZXY);
                b_2 = Sse.Shuffle(a_1, data3, (byte)ShuffleControlG4.ZXYZ);
                result1 = b_1;
                result2 = b_2;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4ToGroup3_ShuffleXImm(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> result1, out Vector128<double> result2) {
                // 0 data0 x0 y0 data1 z0 w0 data2 x1 y1 data3 z1 w1
                // 1 a_0 x0 y0 a_1 z0 x1 a_2 y1 z1
                var a_0 = data0;
                var a_1 = Sse2.Shuffle(data1, data2, (byte)ShuffleControlG2.XX);
                var a_2 = Sse2.Shuffle(data2, data3, (byte)ShuffleControlG2.YX);
                result1 = a_1;
                result2 = a_2;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4ToGroup3_ShuffleXImm(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> result1, out Vector128<int> result2) {
                var d0 = YGroup4ToGroup3_ShuffleXImm(data0.AsSingle(), data1.AsSingle(), data2.AsSingle(), data3.AsSingle(), out var d1, out var d2);
                result1 = d1.AsInt32();
                result2 = d2.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4ToGroup3_ShuffleXImm(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> result1, out Vector128<uint> result2) {
                var d0 = YGroup4ToGroup3_ShuffleXImm(data0.AsSingle(), data1.AsSingle(), data2.AsSingle(), data3.AsSingle(), out var d1, out var d2);
                result1 = d1.AsUInt32();
                result2 = d2.AsUInt32();
                return d0.AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4ToGroup3_ShuffleXImm(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> result1, out Vector128<long> result2) {
                var d0 = YGroup4ToGroup3_ShuffleXImm(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2);
                result1 = d1.AsInt64();
                result2 = d2.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4ToGroup3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4ToGroup3_ShuffleXImm(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> result1, out Vector128<ulong> result2) {
                var d0 = YGroup4ToGroup3_ShuffleXImm(data0.AsDouble(), data1.AsDouble(), data2.AsDouble(), data3.AsDouble(), out var d1, out var d2);
                result1 = d1.AsUInt64();
                result2 = d2.AsUInt64();
                return d0.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Unzip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> y, out Vector128<float> z, out Vector128<float> w) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> y, out Vector128<double> z, out Vector128<double> w) {
#if NET8_0_OR_GREATER
                if (Avx512F.IsSupported) {
                    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> y, out Vector128<sbyte> z, out Vector128<sbyte> w) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.IsSupported) {
                    return YGroup4Unzip_PermuteLonger(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Narrow(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> y, out Vector128<byte> z, out Vector128<byte> w) {
                // None Avx512: _Unpack > _Unzip > _Narrow
                // Have Avx512: _PermuteLonger > _Unzip > _Unpack > _Narrow
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.IsSupported) {
                    return YGroup4Unzip_PermuteLonger(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> y, out Vector128<short> z, out Vector128<short> w) {
#if NET8_0_OR_GREATER
                if (Avx512BW.IsSupported) {
                    return YGroup4Unzip_PermuteLonger(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> y, out Vector128<ushort> z, out Vector128<ushort> w) {
#if NET8_0_OR_GREATER
                if (Avx512BW.IsSupported) {
                    return YGroup4Unzip_PermuteLonger(data0, data1, data2, data3, out y, out z, out w);
                }
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> y, out Vector128<int> z, out Vector128<int> w) {
                // None Avx512: _Unpack > _Unzip
                // Have Avx512: _Unpack > _PermuteLonger > _Unzip
#if NET8_0_OR_GREATER
                //if (Avx512F.IsSupported) {
                //    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                //}
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> y, out Vector128<uint> z, out Vector128<uint> w) {
#if NET8_0_OR_GREATER
                //if (Avx512F.IsSupported) {
                //    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                //}
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> y, out Vector128<long> z, out Vector128<long> w) {
                // None Avx512: _Unzip >= _Unpack
                // Have Avx512: _Unpack > _Unzip > _PermuteLonger
#if NET8_0_OR_GREATER
                //if (Avx512F.IsSupported) {
                //    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                //}
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> y, out Vector128<ulong> z, out Vector128<ulong> w) {
#if NET8_0_OR_GREATER
                //if (Avx512F.IsSupported) {
                //    return YGroup4Unzip_Unzip(data0, data1, data2, data3, out y, out z, out w);
                //}
#endif // NET8_0_OR_GREATER
                return YGroup4Unzip_Unpack(data0, data1, data2, data3, out y, out z, out w);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Unzip_Narrow(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> y, out Vector128<sbyte> z, out Vector128<sbyte> w) {
                var d0 = YGroup4Unzip_Narrow(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Unzip_Narrow(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> y, out Vector128<byte> z, out Vector128<byte> w) {
                const int L = 8;
                Vector128<byte> rt0, rt1, rt2, rt3;
                Vector128<uint> temp0, temp1, temp2, temp3;
                temp0 = data0.AsUInt32();
                temp1 = data1.AsUInt32();
                temp2 = data2.AsUInt32();
                temp3 = data3.AsUInt32();
                rt0 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Sse2.ShiftRightLogical(temp0, L);
                temp1 = Sse2.ShiftRightLogical(temp1, L);
                temp2 = Sse2.ShiftRightLogical(temp2, L);
                temp3 = Sse2.ShiftRightLogical(temp3, L);
                rt1 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Sse2.ShiftRightLogical(temp0, L);
                temp1 = Sse2.ShiftRightLogical(temp1, L);
                temp2 = Sse2.ShiftRightLogical(temp2, L);
                temp3 = Sse2.ShiftRightLogical(temp3, L);
                rt2 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Sse2.ShiftRightLogical(temp0, L);
                temp1 = Sse2.ShiftRightLogical(temp1, L);
                temp2 = Sse2.ShiftRightLogical(temp2, L);
                temp3 = Sse2.ShiftRightLogical(temp3, L);
                rt3 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                y = rt1;
                z = rt2;
                w = rt3;
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Unzip_Narrow(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> y, out Vector128<short> z, out Vector128<short> w) {
                var d0 = YGroup4Unzip_Narrow(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Unzip_Narrow(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> y, out Vector128<ushort> z, out Vector128<ushort> w) {
                const int L = 16;
                Vector128<ushort> rt0, rt1, rt2, rt3;
                Vector128<ulong> temp0, temp1, temp2, temp3;
                temp0 = data0.AsUInt64();
                temp1 = data1.AsUInt64();
                temp2 = data2.AsUInt64();
                temp3 = data3.AsUInt64();
                rt0 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Sse2.ShiftRightLogical(temp0, L);
                temp1 = Sse2.ShiftRightLogical(temp1, L);
                temp2 = Sse2.ShiftRightLogical(temp2, L);
                temp3 = Sse2.ShiftRightLogical(temp3, L);
                rt1 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Sse2.ShiftRightLogical(temp0, L);
                temp1 = Sse2.ShiftRightLogical(temp1, L);
                temp2 = Sse2.ShiftRightLogical(temp2, L);
                temp3 = Sse2.ShiftRightLogical(temp3, L);
                rt2 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                temp0 = Sse2.ShiftRightLogical(temp0, L);
                temp1 = Sse2.ShiftRightLogical(temp1, L);
                temp2 = Sse2.ShiftRightLogical(temp2, L);
                temp3 = Sse2.ShiftRightLogical(temp3, L);
                rt3 = Narrow(Narrow(temp0, temp1), Narrow(temp2, temp3));
                y = rt1;
                z = rt2;
                w = rt3;
                return rt0;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4Unzip_PermuteLonger(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> y, out Vector128<float> z, out Vector128<float> w) {
                var d0 = YGroup4Unzip_PermuteLonger(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4Unzip_PermuteLonger(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> y, out Vector128<double> z, out Vector128<double> w) {
                var d0 = YGroup4Unzip_PermuteLonger(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Unzip_PermuteLonger(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> y, out Vector128<sbyte> z, out Vector128<sbyte> w) {
                var d0 = YGroup4Unzip_PermuteLonger(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Unzip_PermuteLonger(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> y, out Vector128<byte> z, out Vector128<byte> w) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                var a0 = data0.ToVector256Unsafe().WithUpper(data1);
                var a1 = data2.ToVector256Unsafe().WithUpper(data3);
                var b0 = Avx512Vbmi.VL.PermuteVar32x8x2(a0, Vector256Constants.YGroup4Unzip_ShuffleX2Longer_Byte_XY, a1);
                var b1 = Avx512Vbmi.VL.PermuteVar32x8x2(a0, Vector256Constants.YGroup4Unzip_ShuffleX2Longer_Byte_ZW, a1);
                y = b0.GetUpper();
                z = b1.GetLower();
                w = b1.GetUpper();
                return b0.GetLower();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Unzip_PermuteLonger(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> y, out Vector128<short> z, out Vector128<short> w) {
                var d0 = YGroup4Unzip_PermuteLonger(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Unzip_PermuteLonger(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> y, out Vector128<ushort> z, out Vector128<ushort> w) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                var a0 = data0.ToVector256Unsafe().WithUpper(data1);
                var a1 = data2.ToVector256Unsafe().WithUpper(data3);
                var b0 = Avx512BW.VL.PermuteVar16x16x2(a0, Vector256Constants.YGroup4Unzip_ShuffleX2Longer_UInt16_XY, a1);
                var b1 = Avx512BW.VL.PermuteVar16x16x2(a0, Vector256Constants.YGroup4Unzip_ShuffleX2Longer_UInt16_ZW, a1);
                y = b0.GetUpper();
                z = b1.GetLower();
                w = b1.GetUpper();
                return b0.GetLower();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4Unzip_PermuteLonger(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> y, out Vector128<int> z, out Vector128<int> w) {
                var d0 = YGroup4Unzip_PermuteLonger(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4Unzip_PermuteLonger(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> y, out Vector128<uint> z, out Vector128<uint> w) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var a0 = data0.ToVector256Unsafe().WithUpper(data1);
                var a1 = data2.ToVector256Unsafe().WithUpper(data3);
                var b0 = Avx512F.VL.PermuteVar8x32x2(a0, Vector256Constants.YGroup4Unzip_ShuffleX2Longer_UInt32_XY, a1);
                var b1 = Avx512F.VL.PermuteVar8x32x2(a0, Vector256Constants.YGroup4Unzip_ShuffleX2Longer_UInt32_ZW, a1);
                y = b0.GetUpper();
                z = b1.GetLower();
                w = b1.GetUpper();
                return b0.GetLower();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4Unzip_PermuteLonger(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> y, out Vector128<long> z, out Vector128<long> w) {
                var d0 = YGroup4Unzip_PermuteLonger(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4Unzip_PermuteLonger(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> y, out Vector128<ulong> z, out Vector128<ulong> w) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var a0 = data0.ToVector256Unsafe().WithUpper(data1);
                var a1 = data2.ToVector256Unsafe().WithUpper(data3);
                var b0 = Avx512F.VL.PermuteVar4x64x2(a0, Vector256Constants.YGroup4Unzip_ShuffleX2Longer_UInt64_XY, a1);
                var b1 = Avx512F.VL.PermuteVar4x64x2(a0, Vector256Constants.YGroup4Unzip_ShuffleX2Longer_UInt64_ZW, a1);
                y = b0.GetUpper();
                z = b1.GetLower();
                w = b1.GetUpper();
                return b0.GetLower();
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4Unzip_Unpack(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> y, out Vector128<float> z, out Vector128<float> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4Unzip_Unpack(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> y, out Vector128<double> z, out Vector128<double> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Unzip_Unpack(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> y, out Vector128<sbyte> z, out Vector128<sbyte> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Unzip_Unpack(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> y, out Vector128<byte> z, out Vector128<byte> w) {
                Vector128<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 data1 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 data2 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 data3 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15
                // 1 a_0 x0 x8 y0 y8 z0 z8 w0 w8 x1 x9 y1 y9 z1 z9 w1 w9 a_1 x2 x10 y2 y10 z2 z10 w2 w10 x3 x11 y3 y11 z3 z11 w3 w11 a_2 x4 x12 y4 y12 z4 z12 w4 w12 x5 x13 y5 y13 z5 z13 w5 w13 a_3 x6 x14 y6 y14 z6 z14 w6 w14 x7 x15 y7 y15 z7 z15 w7 w15
                a_0 = Sse2.UnpackLow(data0, data2);
                a_1 = Sse2.UnpackHigh(data0, data2);
                a_2 = Sse2.UnpackLow(data1, data3);
                a_3 = Sse2.UnpackHigh(data1, data3);
                // 2 b_0 x0 x4 x8 x12 y0 y4 y8 y12 z0 z4 z8 z12 w0 w4 w8 w12 b_1 x1 x5 x9 x13 y1 y5 y9 y13 z1 z5 z9 z13 w1 w5 w9 w13 b_2 x2 x6 x10 x14 y2 y6 y10 y14 z2 z6 z10 z14 w2 w6 w10 w14 b_3 x3 x7 x11 x15 y3 y7 y11 y15 z3 z7 z11 z15 w3 w7 w11 w15
                b_0 = Sse2.UnpackLow(a_0, a_2);
                b_1 = Sse2.UnpackHigh(a_0, a_2);
                b_2 = Sse2.UnpackLow(a_1, a_3);
                b_3 = Sse2.UnpackHigh(a_1, a_3);
                // 3 a_0 x0 x2 x4 x6 x8 x10 x12 x14 y0 y2 y4 y6 y8 y10 y12 y14 a_1 z0 z2 z4 z6 z8 z10 z12 z14 w0 w2 w4 w6 w8 w10 w12 w14 a_2 x1 x3 x5 x7 x9 x11 x13 x15 y1 y3 y5 y7 y9 y11 y13 y15 a_3 z1 z3 z5 z7 z9 z11 z13 z15 w1 w3 w5 w7 w9 w11 w13 w15
                a_0 = Sse2.UnpackLow(b_0, b_2);
                a_1 = Sse2.UnpackHigh(b_0, b_2);
                a_2 = Sse2.UnpackLow(b_1, b_3);
                a_3 = Sse2.UnpackHigh(b_1, b_3);
                // 4 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15
                b_0 = Sse2.UnpackLow(a_0, a_2);
                b_1 = Sse2.UnpackHigh(a_0, a_2);
                b_2 = Sse2.UnpackLow(a_1, a_3);
                b_3 = Sse2.UnpackHigh(a_1, a_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Unzip_Unpack(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> y, out Vector128<short> z, out Vector128<short> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Unzip_Unpack(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> y, out Vector128<ushort> z, out Vector128<ushort> w) {
                Vector128<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 x1 y1 z1 w1 data1 x2 y2 z2 w2 x3 y3 z3 w3 data2 x4 y4 z4 w4 x5 y5 z5 w5 data3 x6 y6 z6 w6 x7 y7 z7 w7
                // 1 a_0 x0 x4 y0 y4 z0 z4 w0 w4 a_1 x1 x5 y1 y5 z1 z5 w1 w5 a_2 x2 x6 y2 y6 z2 z6 w2 w6 a_3 x3 x7 y3 y7 z3 z7 w3 w7
                a_0 = Sse2.UnpackLow(data0, data2);
                a_1 = Sse2.UnpackHigh(data0, data2);
                a_2 = Sse2.UnpackLow(data1, data3);
                a_3 = Sse2.UnpackHigh(data1, data3);
                // 2 b_0 x0 x2 x4 x6 y0 y2 y4 y6 b_1 z0 z2 z4 z6 w0 w2 w4 w6 b_2 x1 x3 x5 x7 y1 y3 y5 y7 b_3 z1 z3 z5 z7 w1 w3 w5 w7
                b_0 = Sse2.UnpackLow(a_0, a_2);
                b_1 = Sse2.UnpackHigh(a_0, a_2);
                b_2 = Sse2.UnpackLow(a_1, a_3);
                b_3 = Sse2.UnpackHigh(a_1, a_3);
                // 3 a_0 x0 x1 x2 x3 x4 x5 x6 x7 a_1 y0 y1 y2 y3 y4 y5 y6 y7 a_2 z0 z1 z2 z3 z4 z5 z6 z7 a_3 w0 w1 w2 w3 w4 w5 w6 w7
                a_0 = Sse2.UnpackLow(b_0, b_2);
                a_1 = Sse2.UnpackHigh(b_0, b_2);
                a_2 = Sse2.UnpackLow(b_1, b_3);
                a_3 = Sse2.UnpackHigh(b_1, b_3);
                y = a_1;
                z = a_2;
                w = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4Unzip_Unpack(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> y, out Vector128<int> z, out Vector128<int> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4Unzip_Unpack(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> y, out Vector128<uint> z, out Vector128<uint> w) {
                Vector128<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 data1 x1 y1 z1 w1 data2 x2 y2 z2 w2 data3 x3 y3 z3 w3
                // 1 a_0 x0 x2 y0 y2 a_1 z0 z2 w0 w2 a_2 x1 x3 y1 y3 a_3 z1 z3 w1 w3
                a_0 = Sse2.UnpackLow(data0, data2);
                a_1 = Sse2.UnpackHigh(data0, data2);
                a_2 = Sse2.UnpackLow(data1, data3);
                a_3 = Sse2.UnpackHigh(data1, data3);
                // 2 b_0 x0 x1 x2 x3 b_1 y0 y1 y2 y3 b_2 z0 z1 z2 z3 b_3 w0 w1 w2 w3
                b_0 = Sse2.UnpackLow(a_0, a_2);
                b_1 = Sse2.UnpackHigh(a_0, a_2);
                b_2 = Sse2.UnpackLow(a_1, a_3);
                b_3 = Sse2.UnpackHigh(a_1, a_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4Unzip_Unpack(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> y, out Vector128<long> z, out Vector128<long> w) {
                var d0 = YGroup4Unzip_Unpack(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4Unzip_Unpack(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> y, out Vector128<ulong> z, out Vector128<ulong> w) {
                Vector128<ulong> a_0, a_1, a_2, a_3;
                // 0 data0 x0 y0 data1 z0 w0 data2 x1 y1 data3 z1 w1
                // 1 a_0 x0 x1 a_1 y0 y1 a_2 z0 z1 a_3 w0 w1
                a_0 = Sse2.UnpackLow(data0, data2);
                a_1 = Sse2.UnpackHigh(data0, data2);
                a_2 = Sse2.UnpackLow(data1, data3);
                a_3 = Sse2.UnpackHigh(data1, data3);
                y = a_1;
                z = a_2;
                w = a_3;
                return a_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4Unzip_Unzip(Vector128<float> data0, Vector128<float> data1, Vector128<float> data2, Vector128<float> data3, out Vector128<float> y, out Vector128<float> z, out Vector128<float> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsSingle();
                z = d2.AsSingle();
                w = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4Unzip_Unzip(Vector128<double> data0, Vector128<double> data1, Vector128<double> data2, Vector128<double> data3, out Vector128<double> y, out Vector128<double> z, out Vector128<double> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsDouble();
                z = d2.AsDouble();
                w = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Unzip_Unzip(Vector128<sbyte> data0, Vector128<sbyte> data1, Vector128<sbyte> data2, Vector128<sbyte> data3, out Vector128<sbyte> y, out Vector128<sbyte> z, out Vector128<sbyte> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsByte(), data1.AsByte(), data2.AsByte(), data3.AsByte(), out var d1, out var d2, out var d3);
                y = d1.AsSByte();
                z = d2.AsSByte();
                w = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Unzip_Unzip(Vector128<byte> data0, Vector128<byte> data1, Vector128<byte> data2, Vector128<byte> data3, out Vector128<byte> y, out Vector128<byte> z, out Vector128<byte> w) {
                Vector128<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 data1 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 data2 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 data3 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 a_1 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 a_3 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15
                a_0 = YGroup2Unzip(data0, data1, out a_2);
                a_1 = YGroup2Unzip(data2, data3, out a_3);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15
                b_0 = YGroup2Unzip(a_0, a_1, out b_2);
                b_1 = YGroup2Unzip(a_2, a_3, out b_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Unzip_Unzip(Vector128<short> data0, Vector128<short> data1, Vector128<short> data2, Vector128<short> data3, out Vector128<short> y, out Vector128<short> z, out Vector128<short> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt16(), data1.AsUInt16(), data2.AsUInt16(), data3.AsUInt16(), out var d1, out var d2, out var d3);
                y = d1.AsInt16();
                z = d2.AsInt16();
                w = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Unzip_Unzip(Vector128<ushort> data0, Vector128<ushort> data1, Vector128<ushort> data2, Vector128<ushort> data3, out Vector128<ushort> y, out Vector128<ushort> z, out Vector128<ushort> w) {
                Vector128<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 x1 y1 z1 w1 data1 x2 y2 z2 w2 x3 y3 z3 w3 data2 x4 y4 z4 w4 x5 y5 z5 w5 data3 x6 y6 z6 w6 x7 y7 z7 w7
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 a_1 x4 z4 x5 z5 x6 z6 x7 z7 a_2 y0 w0 y1 w1 y2 w2 y3 w3 a_3 y4 w4 y5 w5 y6 w6 y7 w7
                a_0 = YGroup2Unzip(data0, data1, out a_2);
                a_1 = YGroup2Unzip(data2, data3, out a_3);
                // 2 b_0 x0 x1 x2 x3 x4 x5 x6 x7 b_1 y0 y1 y2 y3 y4 y5 y6 y7 b_2 z0 z1 z2 z3 z4 z5 z6 z7 b_3 w0 w1 w2 w3 w4 w5 w6 w7
                b_0 = YGroup2Unzip(a_0, a_1, out b_2);
                b_1 = YGroup2Unzip(a_2, a_3, out b_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4Unzip_Unzip(Vector128<int> data0, Vector128<int> data1, Vector128<int> data2, Vector128<int> data3, out Vector128<int> y, out Vector128<int> z, out Vector128<int> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt32(), data1.AsUInt32(), data2.AsUInt32(), data3.AsUInt32(), out var d1, out var d2, out var d3);
                y = d1.AsInt32();
                z = d2.AsInt32();
                w = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4Unzip_Unzip(Vector128<uint> data0, Vector128<uint> data1, Vector128<uint> data2, Vector128<uint> data3, out Vector128<uint> y, out Vector128<uint> z, out Vector128<uint> w) {
                Vector128<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 data0 x0 y0 z0 w0 data1 x1 y1 z1 w1 data2 x2 y2 z2 w2 data3 x3 y3 z3 w3
                // 1 a_0 x0 z0 x1 z1 a_1 x2 z2 x3 z3 a_2 y0 w0 y1 w1 a_3 y2 w2 y3 w3
                a_0 = YGroup2Unzip(data0, data1, out a_2);
                a_1 = YGroup2Unzip(data2, data3, out a_3);
                // 2 b_0 x0 x1 x2 x3 b_1 y0 y1 y2 y3 b_2 z0 z1 z2 z3 b_3 w0 w1 w2 w3
                b_0 = YGroup2Unzip(a_0, a_1, out b_2);
                b_1 = YGroup2Unzip(a_2, a_3, out b_3);
                y = b_1;
                z = b_2;
                w = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4Unzip_Unzip(Vector128<long> data0, Vector128<long> data1, Vector128<long> data2, Vector128<long> data3, out Vector128<long> y, out Vector128<long> z, out Vector128<long> w) {
                var d0 = YGroup4Unzip_Unzip(data0.AsUInt64(), data1.AsUInt64(), data2.AsUInt64(), data3.AsUInt64(), out var d1, out var d2, out var d3);
                y = d1.AsInt64();
                z = d2.AsInt64();
                w = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Unzip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4Unzip_Unzip(Vector128<ulong> data0, Vector128<ulong> data1, Vector128<ulong> data2, Vector128<ulong> data3, out Vector128<ulong> y, out Vector128<ulong> z, out Vector128<ulong> w) {
                Vector128<ulong> a_0, a_1, a_2, a_3;
                // 0 data0 x0 y0 data1 z0 w0 data2 x1 y1 data3 z1 w1
                // 1 a_0 x0 x1 a_1 y0 y1 a_2 z0 z1 a_3 w0 w1
                a_0 = YGroup2Unzip(data0, data2, out a_1);
                a_2 = YGroup2Unzip(data1, data3, out a_3);
                y = a_1;
                z = a_2;
                w = a_3;
                return a_0;
            }


            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip_AcceleratedTypes"/>
            public static TypeCodeFlags YGroup4Zip_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlagsUtil.AllTypes;
                    return rt;
                }
            }
            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z, Vector128<float> w, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z, Vector128<double> w, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, Vector128<sbyte> w, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, Vector128<byte> w, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z, Vector128<short> w, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, Vector128<ushort> w, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z, Vector128<int> w, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, Vector128<uint> w, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z, Vector128<long> w, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, Vector128<ulong> w, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3) {
                return YGroup4Zip_Zip(x, y, z, w, out data1, out data2, out data3);
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4Zip_PermuteLonger(Vector128<float> x, Vector128<float> y, Vector128<float> z, Vector128<float> w, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3) {
                var d0 = YGroup4Zip_PermuteLonger(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4Zip_PermuteLonger(Vector128<double> x, Vector128<double> y, Vector128<double> z, Vector128<double> w, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3) {
                var d0 = YGroup4Zip_PermuteLonger(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                data3 = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Zip_PermuteLonger(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, Vector128<sbyte> w, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3) {
                var d0 = YGroup4Zip_PermuteLonger(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Zip_PermuteLonger(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, Vector128<byte> w, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3) {
                if (!Avx512Vbmi.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512Vbmi, Avx512VL");
                var a0 = x.ToVector256Unsafe().WithUpper(y);
                var a1 = z.ToVector256Unsafe().WithUpper(w);
                var b0 = Avx512Vbmi.VL.PermuteVar32x8x2(a0, Vector256Constants.YGroup4Zip_ShuffleX2Longer_Byte_Data01, a1);
                var b1 = Avx512Vbmi.VL.PermuteVar32x8x2(a0, Vector256Constants.YGroup4Zip_ShuffleX2Longer_Byte_Data23, a1);
                data1 = b0.GetUpper();
                data2 = b1.GetLower();
                data3 = b1.GetUpper();
                return b0.GetLower();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Zip_PermuteLonger(Vector128<short> x, Vector128<short> y, Vector128<short> z, Vector128<short> w, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3) {
                var d0 = YGroup4Zip_PermuteLonger(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Zip_PermuteLonger(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, Vector128<ushort> w, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3) {
                if (!Avx512BW.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512BW, Avx512VL");
                var a0 = x.ToVector256Unsafe().WithUpper(y);
                var a1 = z.ToVector256Unsafe().WithUpper(w);
                var b0 = Avx512BW.VL.PermuteVar16x16x2(a0, Vector256Constants.YGroup4Zip_ShuffleX2Longer_UInt16_Data01, a1);
                var b1 = Avx512BW.VL.PermuteVar16x16x2(a0, Vector256Constants.YGroup4Zip_ShuffleX2Longer_UInt16_Data23, a1);
                data1 = b0.GetUpper();
                data2 = b1.GetLower();
                data3 = b1.GetUpper();
                return b0.GetLower();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4Zip_PermuteLonger(Vector128<int> x, Vector128<int> y, Vector128<int> z, Vector128<int> w, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3) {
                var d0 = YGroup4Zip_PermuteLonger(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4Zip_PermuteLonger(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, Vector128<uint> w, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var a0 = x.ToVector256Unsafe().WithUpper(y);
                var a1 = z.ToVector256Unsafe().WithUpper(w);
                var b0 = Avx512F.VL.PermuteVar8x32x2(a0, Vector256Constants.YGroup4Zip_ShuffleX2Longer_UInt32_Data01, a1);
                var b1 = Avx512F.VL.PermuteVar8x32x2(a0, Vector256Constants.YGroup4Zip_ShuffleX2Longer_UInt32_Data23, a1);
                data1 = b0.GetUpper();
                data2 = b1.GetLower();
                data3 = b1.GetUpper();
                return b0.GetLower();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4Zip_PermuteLonger(Vector128<long> x, Vector128<long> y, Vector128<long> z, Vector128<long> w, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3) {
                var d0 = YGroup4Zip_PermuteLonger(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                data3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4Zip_PermuteLonger(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, Vector128<ulong> w, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3) {
                if (!Avx512F.VL.IsSupported) VectorMessageFormats.ThrowNewUnsupported("Avx512F, Avx512VL");
                var a0 = x.ToVector256Unsafe().WithUpper(y);
                var a1 = z.ToVector256Unsafe().WithUpper(w);
                var b0 = Avx512F.VL.PermuteVar4x64x2(a0, Vector256Constants.YGroup4Zip_ShuffleX2Longer_UInt64_Data01, a1);
                var b1 = Avx512F.VL.PermuteVar4x64x2(a0, Vector256Constants.YGroup4Zip_ShuffleX2Longer_UInt64_Data23, a1);
                data1 = b0.GetUpper();
                data2 = b1.GetLower();
                data3 = b1.GetUpper();
                return b0.GetLower();
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Zip_Widen(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, Vector128<sbyte> w, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3) {
                var d0 = YGroup4Zip_Widen(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Zip_Widen(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, Vector128<byte> w, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3) {
                const int L = 8;
                Vector128<ushort> t0, t1;
                Vector128<uint> r0, r1, r2, r3, d0, d1, d2, d3;
                // Part 0
                Widen(w, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = ShiftLeft(r0, L);
                d1 = ShiftLeft(r1, L);
                d2 = ShiftLeft(r2, L);
                d3 = ShiftLeft(r3, L);
                // Part 1
                Widen(z, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = BitwiseOr(d0, r0);
                d1 = BitwiseOr(d1, r1);
                d2 = BitwiseOr(d2, r2);
                d3 = BitwiseOr(d3, r3);
                d0 = ShiftLeft(d0, L);
                d1 = ShiftLeft(d1, L);
                d2 = ShiftLeft(d2, L);
                d3 = ShiftLeft(d3, L);
                // Part 2
                Widen(y, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = BitwiseOr(d0, r0);
                d1 = BitwiseOr(d1, r1);
                d2 = BitwiseOr(d2, r2);
                d3 = BitwiseOr(d3, r3);
                d0 = ShiftLeft(d0, L);
                d1 = ShiftLeft(d1, L);
                d2 = ShiftLeft(d2, L);
                d3 = ShiftLeft(d3, L);
                // Part 3
                Widen(x, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = BitwiseOr(d0, r0);
                d1 = BitwiseOr(d1, r1);
                d2 = BitwiseOr(d2, r2);
                d3 = BitwiseOr(d3, r3);
                // done.
                data1 = d1.AsByte();
                data2 = d2.AsByte();
                data3 = d3.AsByte();
                return d0.AsByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Zip_Widen(Vector128<short> x, Vector128<short> y, Vector128<short> z, Vector128<short> w, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3) {
                var d0 = YGroup4Zip_Widen(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Zip_Widen(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, Vector128<ushort> w, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3) {
                const int L = 16;
                Vector128<uint> t0, t1;
                Vector128<ulong> r0, r1, r2, r3, d0, d1, d2, d3;
                // Part 0
                Widen(w, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = ShiftLeft(r0, L);
                d1 = ShiftLeft(r1, L);
                d2 = ShiftLeft(r2, L);
                d3 = ShiftLeft(r3, L);
                // Part 1
                Widen(z, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = BitwiseOr(d0, r0);
                d1 = BitwiseOr(d1, r1);
                d2 = BitwiseOr(d2, r2);
                d3 = BitwiseOr(d3, r3);
                d0 = ShiftLeft(d0, L);
                d1 = ShiftLeft(d1, L);
                d2 = ShiftLeft(d2, L);
                d3 = ShiftLeft(d3, L);
                // Part 2
                Widen(y, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = BitwiseOr(d0, r0);
                d1 = BitwiseOr(d1, r1);
                d2 = BitwiseOr(d2, r2);
                d3 = BitwiseOr(d3, r3);
                d0 = ShiftLeft(d0, L);
                d1 = ShiftLeft(d1, L);
                d2 = ShiftLeft(d2, L);
                d3 = ShiftLeft(d3, L);
                // Part 3
                Widen(x, out t0, out t1);
                Widen(t0, out r0, out r1);
                Widen(t1, out r2, out r3);
                d0 = BitwiseOr(d0, r0);
                d1 = BitwiseOr(d1, r1);
                d2 = BitwiseOr(d2, r2);
                d3 = BitwiseOr(d3, r3);
                // done.
                data1 = d1.AsUInt16();
                data2 = d2.AsUInt16();
                data3 = d3.AsUInt16();
                return d0.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, out Vector128{float}, out Vector128{float}, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YGroup4Zip_Zip(Vector128<float> x, Vector128<float> y, Vector128<float> z, Vector128<float> w, out Vector128<float> data1, out Vector128<float> data2, out Vector128<float> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsSingle();
                data2 = d2.AsSingle();
                data3 = d3.AsSingle();
                return d0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, out Vector128{double}, out Vector128{double}, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YGroup4Zip_Zip(Vector128<double> x, Vector128<double> y, Vector128<double> z, Vector128<double> w, out Vector128<double> data1, out Vector128<double> data2, out Vector128<double> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsDouble();
                data2 = d2.AsDouble();
                data3 = d3.AsDouble();
                return d0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YGroup4Zip_Zip(Vector128<sbyte> x, Vector128<sbyte> y, Vector128<sbyte> z, Vector128<sbyte> w, out Vector128<sbyte> data1, out Vector128<sbyte> data2, out Vector128<sbyte> data3) {
                var d0 = YGroup4Zip_Zip(x.AsByte(), y.AsByte(), z.AsByte(), w.AsByte(), out var d1, out var d2, out var d3);
                data1 = d1.AsSByte();
                data2 = d2.AsSByte();
                data3 = d3.AsSByte();
                return d0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YGroup4Zip_Zip(Vector128<byte> x, Vector128<byte> y, Vector128<byte> z, Vector128<byte> w, out Vector128<byte> data1, out Vector128<byte> data2, out Vector128<byte> data3) {
                Vector128<byte> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 b_0 x0 x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 b_1 y0 y1 y2 y3 y4 y5 y6 y7 y8 y9 y10 y11 y12 y13 y14 y15 b_2 z0 z1 z2 z3 z4 z5 z6 z7 z8 z9 z10 z11 z12 z13 z14 z15 b_3 w0 w1 w2 w3 w4 w5 w6 w7 w8 w9 w10 w11 w12 w13 w14 w15
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 x4 z4 x5 z5 x6 z6 x7 z7 a_1 x8 z8 x9 z9 x10 z10 x11 z11 x12 z12 x13 z13 x14 z14 x15 z15 a_2 y0 w0 y1 w1 y2 w2 y3 w3 y4 w4 y5 w5 y6 w6 y7 w7 a_3 y8 w8 y9 w9 y10 w10 y11 w11 y12 w12 y13 w13 y14 w14 y15 w15
                a_0 = YGroup2Zip(x, z, out a_1);
                a_2 = YGroup2Zip(y, w, out a_3);
                // 2 b_0 x0 y0 z0 w0 x1 y1 z1 w1 x2 y2 z2 w2 x3 y3 z3 w3 b_1 x4 y4 z4 w4 x5 y5 z5 w5 x6 y6 z6 w6 x7 y7 z7 w7 b_2 x8 y8 z8 w8 x9 y9 z9 w9 x10 y10 z10 w10 x11 y11 z11 w11 b_3 x12 y12 z12 w12 x13 y13 z13 w13 x14 y14 z14 w14 x15 y15 z15 w15
                b_0 = YGroup2Zip(a_0, a_2, out b_1);
                b_2 = YGroup2Zip(a_1, a_3, out b_3);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YGroup4Zip_Zip(Vector128<short> x, Vector128<short> y, Vector128<short> z, Vector128<short> w, out Vector128<short> data1, out Vector128<short> data2, out Vector128<short> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt16(), y.AsUInt16(), z.AsUInt16(), w.AsUInt16(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt16();
                data2 = d2.AsInt16();
                data3 = d3.AsInt16();
                return d0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YGroup4Zip_Zip(Vector128<ushort> x, Vector128<ushort> y, Vector128<ushort> z, Vector128<ushort> w, out Vector128<ushort> data1, out Vector128<ushort> data2, out Vector128<ushort> data3) {
                Vector128<ushort> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 _x_ x0 x1 x2 x3 x4 x5 x6 x7 _y_ y0 y1 y2 y3 y4 y5 y6 y7 _z_ z0 z1 z2 z3 z4 z5 z6 z7 _w_ w0 w1 w2 w3 w4 w5 w6 w7
                // 1 a_0 x0 z0 x1 z1 x2 z2 x3 z3 a_1 x4 z4 x5 z5 x6 z6 x7 z7 a_2 y0 w0 y1 w1 y2 w2 y3 w3 a_3 y4 w4 y5 w5 y6 w6 y7 w7
                a_0 = YGroup2Zip(x, z, out a_1);
                a_2 = YGroup2Zip(y, w, out a_3);
                // 2 b_0 x0 y0 z0 w0 x1 y1 z1 w1 b_1 x2 y2 z2 w2 x3 y3 z3 w3 b_2 x4 y4 z4 w4 x5 y5 z5 w5 b_3 x6 y6 z6 w6 x7 y7 z7 w7
                b_0 = YGroup2Zip(a_0, a_2, out b_1);
                b_2 = YGroup2Zip(a_1, a_3, out b_3);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YGroup4Zip_Zip(Vector128<int> x, Vector128<int> y, Vector128<int> z, Vector128<int> w, out Vector128<int> data1, out Vector128<int> data2, out Vector128<int> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt32(), y.AsUInt32(), z.AsUInt32(), w.AsUInt32(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt32();
                data2 = d2.AsInt32();
                data3 = d3.AsInt32();
                return d0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YGroup4Zip_Zip(Vector128<uint> x, Vector128<uint> y, Vector128<uint> z, Vector128<uint> w, out Vector128<uint> data1, out Vector128<uint> data2, out Vector128<uint> data3) {
                Vector128<uint> a_0, a_1, a_2, a_3, b_0, b_1, b_2, b_3;
                // 0 _x_ x0 x1 x2 x3 _y_ y0 y1 y2 y3 _z_ z0 z1 z2 z3 _w_ w0 w1 w2 w3
                // 1 a_0 x0 z0 x1 z1 a_1 x2 z2 x3 z3 a_2 y0 w0 y1 w1 a_3 y2 w2 y3 w3
                a_0 = YGroup2Zip(x, z, out a_1);
                a_2 = YGroup2Zip(y, w, out a_3);
                // 2 b_0 x0 y0 z0 w0 b_1 x1 y1 z1 w1 b_2 x2 y2 z2 w2 b_3 x3 y3 z3 w3
                b_0 = YGroup2Zip(a_0, a_2, out b_1);
                b_2 = YGroup2Zip(a_1, a_3, out b_3);
                data1 = b_1;
                data2 = b_2;
                data3 = b_3;
                return b_0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YGroup4Zip_Zip(Vector128<long> x, Vector128<long> y, Vector128<long> z, Vector128<long> w, out Vector128<long> data1, out Vector128<long> data2, out Vector128<long> data3) {
                var d0 = YGroup4Zip_Zip(x.AsUInt64(), y.AsUInt64(), z.AsUInt64(), w.AsUInt64(), out var d1, out var d2, out var d3);
                data1 = d1.AsInt64();
                data2 = d2.AsInt64();
                data3 = d3.AsInt64();
                return d0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YGroup4Zip(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YGroup4Zip_Zip(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z, Vector128<ulong> w, out Vector128<ulong> data1, out Vector128<ulong> data2, out Vector128<ulong> data3) {
                Vector128<ulong> a_0, a_1, a_2, a_3;
                // 0 a_0 x0 x1 a_1 y0 y1 a_2 z0 z1 a_3 w0 w1
                // 1 a_0 x0 y0 a_1 z0 w0 a_2 x1 y1 a_3 z1 w1
                a_0 = YGroup2Zip(x, y, out a_2);
                a_1 = YGroup2Zip(z, w, out a_3);
                data1 = a_1;
                data2 = a_2;
                data3 = a_3;
                return a_0;
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
