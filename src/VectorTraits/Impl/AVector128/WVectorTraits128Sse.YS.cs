using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128Sse {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG2_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Ssse3.IsSupported) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG2(Vector128<float> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleG2(Vector128<double> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG2(Vector128<sbyte> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG2(Vector128<byte> source, ShuffleControlG2 control) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices = Vector128Constants.GetYShuffleG2_Byte_Indices(control); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                    return Ssse3.Shuffle(source, indices);
                } else {
                    return YShuffleG2(source, control);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG2(Vector128<short> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG2(Vector128<ushort> source, ShuffleControlG2 control) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices = Vector128Constants.GetYShuffleG2_UInt16_ByteIndices(control).AsByte(); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                    return Ssse3.Shuffle(source.AsByte(), indices).AsUInt16();
                } else {
                    return YShuffleG2(source, control);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG2(Vector128<int> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG2(Vector128<uint> source, ShuffleControlG2 control) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices = Vector128Constants.GetYShuffleG2_UInt32_ByteIndices(control); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                    return Ssse3.Shuffle(source.AsByte(), indices).AsUInt32();
                } else {
                    return YShuffleG2(source, control);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleG2(Vector128<long> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleG2(Vector128<ulong> source, ShuffleControlG2 control) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices = Vector128Constants.GetYShuffleG2_UInt64_ByteIndices(control).AsByte(); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                    return Ssse3.Shuffle(source.AsByte(), indices).AsUInt64();
                } else {
                    return YShuffleG2(source, control);
                }
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Ssse3.IsSupported) {
                        rt |= TypeCodeFlagsUtil.Most32Types;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4(Vector128<float> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG4(Vector128<sbyte> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG4(Vector128<byte> source, ShuffleControlG4 control) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices = Vector128Constants.GetYShuffleG4_Byte_Indices(control); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                    return Ssse3.Shuffle(source, indices);
                } else {
                    return YShuffleG4(source, control);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG4(Vector128<short> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4(Vector128<ushort> source, ShuffleControlG4 control) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices = Vector128Constants.GetYShuffleG4_UInt16_ByteIndices(control).AsByte(); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                    return Ssse3.Shuffle(source.AsByte(), indices).AsUInt16();
                } else {
                    return YShuffleG4(source, control);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4(Vector128<int> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4(Vector128<uint> source, ShuffleControlG4 control) {
                return YShuffleG4_Byte(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4_Byte(Vector128<uint> source, ShuffleControlG4 control) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices = Vector128Constants.GetYShuffleG4_UInt32_ByteIndices(control).AsByte(); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                    return Ssse3.Shuffle(source.AsByte(), indices).AsUInt32(); // _mm128_shuffle_epi8
                } else {
                    return YShuffleG4(source, control);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG4_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG4_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG4_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4_Const_Imm(Vector128<float> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4_Const_Imm(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG4_Const_Imm(Vector128<short> source, [ConstantExpected] ShuffleControlG4 control) {
                return Sse2.ShuffleHigh(Sse2.ShuffleLow(source, (byte)control), (byte)control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4_Const_Imm(Vector128<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
                return Sse2.ShuffleHigh(Sse2.ShuffleLow(source, (byte)control), (byte)control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4_Const_Imm(Vector128<int> source, [ConstantExpected] ShuffleControlG4 control) {
                return Sse2.Shuffle(source, (byte)control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4_Const_ImmByte(Vector128<int> source, [ConstantExpected(Max = 255)] byte control) {
                return Sse2.Shuffle(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4_Const_Imm(Vector128<uint> source, [ConstantExpected] ShuffleControlG4 control) {
                return Sse2.Shuffle(source, (byte)control);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Ssse3.IsSupported) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4X2(Vector128<float> source0, Vector128<float> source1, ShuffleControlG4 control, out Vector128<float> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt32(), source1.AsUInt32(), control, out var rt1);
                result1 = rt1.AsSingle();
                return rt0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{double}, Vector128{double}, ShuffleControlG4, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleG4X2(Vector128<double> source0, Vector128<double> source1, ShuffleControlG4 control, out Vector128<double> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt64(), source1.AsUInt64(), control, out var rt1);
                result1 = rt1.AsDouble();
                return rt0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG4X2(Vector128<sbyte> source0, Vector128<sbyte> source1, ShuffleControlG4 control, out Vector128<sbyte> result1) {
                var rt0 = YShuffleG4X2(source0.AsByte(), source1.AsByte(), control, out var rt1);
                result1 = rt1.AsSByte();
                return rt0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG4X2(Vector128<byte> source0, Vector128<byte> source1, ShuffleControlG4 control, out Vector128<byte> result1) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices = Vector128Constants.GetYShuffleG4_Byte_Indices(control); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                    var rt0 = Ssse3.Shuffle(source0, indices);
                    result1 = Ssse3.Shuffle(source1, indices);
                    return rt0;
                } else {
                    return YShuffleG4X2(source0, source1, control, out result1);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG4X2(Vector128<short> source0, Vector128<short> source1, ShuffleControlG4 control, out Vector128<short> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt16(), source1.AsUInt16(), control, out var rt1);
                result1 = rt1.AsInt16();
                return rt0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4X2(Vector128<ushort> source0, Vector128<ushort> source1, ShuffleControlG4 control, out Vector128<ushort> result1) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices = Vector128Constants.GetYShuffleG4_UInt16_ByteIndices(control).AsByte(); // It also supports _mm128_shuffle_epi8 for 128-bit lanes .
                    var rt0 = Ssse3.Shuffle(source0.AsByte(), indices).AsUInt16();
                    result1 = Ssse3.Shuffle(source1.AsByte(), indices).AsUInt16();
                    return rt0;
                } else {
                    return YShuffleG4X2(source0, source1, control, out result1);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4X2(Vector128<int> source0, Vector128<int> source1, ShuffleControlG4 control, out Vector128<int> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt32(), source1.AsUInt32(), control, out var rt1);
                result1 = rt1.AsInt32();
                return rt0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4X2(Vector128<uint> source0, Vector128<uint> source1, ShuffleControlG4 control, out Vector128<uint> result1) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices = Vector128Constants.GetYShuffleG4_UInt32_ByteIndices(control).AsByte();
                    var rt0 = Ssse3.Shuffle(source0.AsByte(), indices).AsUInt32();
                    result1 = Ssse3.Shuffle(source1.AsByte(), indices).AsUInt32();
                    return rt0;
                } else {
                    return YShuffleG4X2(source0, source1, control, out result1);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleG4X2(Vector128<long> source0, Vector128<long> source1, ShuffleControlG4 control, out Vector128<long> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt64(), source1.AsUInt64(), control, out var rt1);
                result1 = rt1.AsInt64();
                return rt0.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleG4X2(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control, out Vector128<ulong> result1) {
                ref Vector128<byte> indices = ref Vector128Constants.GetYShuffleG4X2_UInt64_ByteIndices(control);
                var result0 = Sse2.Or(
                    YShuffleKernel(source0.AsByte(), indices),
                    YShuffleKernel(source1.AsByte(), Unsafe.Add(ref indices, 1))
                ).AsUInt64();
                result1 = Sse2.Or(
                    YShuffleKernel(source0.AsByte(), Unsafe.Add(ref indices, 2)),
                    YShuffleKernel(source1.AsByte(), Unsafe.Add(ref indices, 3))
                ).AsUInt64();
                return result0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4X2_Const(Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<float> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{double}, Vector128{double}, ShuffleControlG4, out Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleG4X2_Const(Vector128<double> source0, Vector128<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<double> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{sbyte}, Vector128{sbyte}, ShuffleControlG4, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG4X2_Const(Vector128<sbyte> source0, Vector128<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<sbyte> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG4X2_Const(Vector128<byte> source0, Vector128<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<byte> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG4X2_Const(Vector128<short> source0, Vector128<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<short> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4X2_Const(Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ushort> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4X2_Const(Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<int> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4X2_Const(Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<uint> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{long}, Vector128{long}, ShuffleControlG4, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleG4X2_Const(Vector128<long> source0, Vector128<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<long> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleG4X2_Const(Vector128<ulong> source0, Vector128<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ulong> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
                get {
                    return YShuffleKernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleInsert(Vector128<float> back, Vector128<float> vector, Vector128<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleInsert(Vector128<double> back, Vector128<double> vector, Vector128<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleInsert(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> indices) {
                return YShuffleInsert(back.AsByte(), vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleInsert(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
                if (Ssse3.IsSupported) {
                    Vector128<sbyte> indicesAdded = Sse2.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue));
                    Vector128<byte> mask = Sse2.CompareGreaterThan(
                        Vector128.Create((sbyte)(16 + sbyte.MinValue)),
                        indicesAdded
                    ).AsByte(); // Unsigned compare: (i < 16)
                    Vector128<byte> raw = YShuffleKernel(vector, indices);
                    Vector128<byte> rt;
                    if (Sse41.IsSupported) {
                        rt = Sse41.BlendVariable(back, raw, mask);
                    } else {
                        rt = ConditionalSelect(mask, raw, back);
                    }
                    return rt;
                } else {
                    return SuperStatics.YShuffleInsert(back, vector, indices);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleInsert(Vector128<short> back, Vector128<short> vector, Vector128<short> indices) {
                return YShuffleInsert(back.AsUInt16(), vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleInsert(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
                if (Ssse3.IsSupported) {
                    Vector128<short> indicesAdded = Sse2.Add(indices.AsInt16(), Vector128.Create(short.MinValue));
                    Vector128<ushort> mask = Sse2.CompareGreaterThan(
                        Vector128.Create((short)(8 + short.MinValue)),
                        indicesAdded
                    ).AsUInt16(); // Unsigned compare: (i < 8)
                    Vector128<ushort> raw = YShuffleKernel(vector, indices);
                    Vector128<ushort> rt;
                    if (Sse41.IsSupported) {
                        rt = Sse41.BlendVariable(back, raw, mask);
                    } else {
                        rt = ConditionalSelect(mask, raw, back);
                    }
                    return rt;
                } else {
                    return SuperStatics.YShuffleInsert(back, vector, indices);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleInsert(Vector128<int> back, Vector128<int> vector, Vector128<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleInsert(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices) {
                if (Ssse3.IsSupported) {
                    Vector128<int> indicesAdded = Sse2.Add(indices.AsInt32(), Vector128.Create(int.MinValue));
                    Vector128<uint> mask = Sse2.CompareGreaterThan(
                        Vector128.Create((int)(4 + int.MinValue)),
                        indicesAdded
                    ).AsUInt32(); // Unsigned compare: (i < 4)
                    Vector128<uint> raw = YShuffleKernel(vector, indices);
                    Vector128<uint> rt;
                    if (Sse41.IsSupported) {
                        rt = Sse41.BlendVariable(back, raw, mask);
                    } else {
                        rt = ConditionalSelect(mask, raw, back);
                    }
                    return rt;
                } else {
                    return SuperStatics.YShuffleInsert(back, vector, indices);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleInsert(Vector128<long> back, Vector128<long> vector, Vector128<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleInsert(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices) {
                if (Ssse3.IsSupported) {
                    Vector128<long> indicesAdded = Sse2.Add(indices.AsInt64(), Vector128Constants.Int64_MinValue);
                    Vector128<ulong> mask = GreaterThan(
                        Vector128Constants.Int64_MinValue_2,
                        indicesAdded
                    ).AsUInt64(); // Unsigned compare: (i < 2)
                    Vector128<ulong> raw = YShuffleKernel(vector, indices);
                    Vector128<ulong> rt;
                    if (Sse41.IsSupported) {
                        rt = Sse41.BlendVariable(back, raw, mask);
                    } else {
                        rt = ConditionalSelect(mask, raw, back);
                    }
                    return rt;
                } else {
                    return SuperStatics.YShuffleInsert(back, vector, indices);
                }
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2) {
                YShuffleInsert_Args(indices.AsByte(), out var a0, out var a1, out var a2);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2) {
                if (Ssse3.IsSupported) {
                    YShuffleKernel_Args(indices, out args0, out args1);
                    Vector128<sbyte> indicesAdded = Sse2.Add(indices.AsSByte(), Vector128.Create(sbyte.MinValue));
                    args2 = Sse2.CompareGreaterThan(
                        Vector128.Create((sbyte)(16 + sbyte.MinValue)),
                        indicesAdded
                    ).AsByte(); // Unsigned compare: (i < 16)
                } else {
                    SuperStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2) {
                YShuffleInsert_Args(indices.AsUInt16(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2) {
                if (Ssse3.IsSupported) {
                    YShuffleKernel_Args(indices, out args0, out args1);
                    var indicesAdded = Sse2.Add(indices.AsInt16(), Vector128.Create(short.MinValue));
                    args2 = Sse2.CompareGreaterThan(
                        Vector128.Create((short)(8 + short.MinValue)),
                        indicesAdded
                    ).AsUInt16(); // Unsigned compare: (i < 8)
                } else {
                    SuperStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2) {
                YShuffleInsert_Args(indices.AsUInt32(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2) {
                if (Ssse3.IsSupported) {
                    YShuffleKernel_Args(indices, out args0, out args1);
                    var indicesAdded = Sse2.Add(indices.AsInt32(), Vector128.Create(int.MinValue));
                    args2 = Sse2.CompareGreaterThan(
                        Vector128.Create((int)(4 + int.MinValue)),
                        indicesAdded
                    ).AsUInt32(); // Unsigned compare: (i < 4)
                } else {
                    SuperStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2) {
                YShuffleInsert_Args(indices.AsUInt64(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2) {
                if (Ssse3.IsSupported) {
                    YShuffleKernel_Args(indices, out args0, out args1);
                    var indicesAdded = Sse2.Add(indices.AsInt64(), Vector128Constants.Int64_MinValue);
                    args2 = GreaterThan(
                        Vector128Constants.Int64_MinValue_2,
                        indicesAdded
                    ).AsUInt64(); // Unsigned compare: (i < 2)
                } else {
                    SuperStatics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
                }
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleInsert_Core(Vector128<float> back, Vector128<float> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
                return YShuffleInsert_Core(back.AsUInt32(), vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleInsert_Core(Vector128<double> back, Vector128<double> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
                return YShuffleInsert_Core(back.AsUInt64(), vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleInsert_Core(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2) {
                return YShuffleInsert_Core(back.AsByte(), vector.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleInsert_Core(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2) {
                if (Ssse3.IsSupported) {
                    var raw = YShuffleKernel_Core(vector, args0, args1);
                    Vector128<byte> rt;
                    if (Sse41.IsSupported) {
                        rt = Sse41.BlendVariable(back, raw, args2);
                    } else {
                        rt = ConditionalSelect(args2, raw, back);
                    }
                    return rt;
                } else {
                    return SuperStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleInsert_Core(Vector128<short> back, Vector128<short> vector, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2) {
                return YShuffleInsert_Core(back.AsUInt16(), vector.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleInsert_Core(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2) {
                if (Ssse3.IsSupported) {
                    var raw = YShuffleKernel_Core(vector, args0, args1);
                    Vector128<ushort> rt;
                    if (Sse41.IsSupported) {
                        rt = Sse41.BlendVariable(back, raw, args2);
                    } else {
                        rt = ConditionalSelect(args2, raw, back);
                    }
                    return rt;
                } else {
                    return SuperStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleInsert_Core(Vector128<int> back, Vector128<int> vector, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2) {
                return YShuffleInsert_Core(back.AsUInt32(), vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleInsert_Core(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2) {
                if (Ssse3.IsSupported) {
                    var raw = YShuffleKernel_Core(vector, args0, args1);
                    Vector128<uint> rt;
                    if (Sse41.IsSupported) {
                        rt = Sse41.BlendVariable(back, raw, args2);
                    } else {
                        rt = ConditionalSelect(args2, raw, back);
                    }
                    return rt;
                } else {
                    return SuperStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleInsert_Core(Vector128<long> back, Vector128<long> vector, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2) {
                return YShuffleInsert_Core(back.AsUInt64(), vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleInsert_Core(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2) {
                if (Ssse3.IsSupported) {
                    var raw = YShuffleKernel_Core(vector, args0, args1);
                    Vector128<ulong> rt;
                    if (Sse41.IsSupported) {
                        rt = Sse41.BlendVariable(back, raw, args2);
                    } else {
                        rt = ConditionalSelect(args2, raw, back);
                    }
                    return rt;
                } else {
                    return SuperStatics.YShuffleInsert_Core(back, vector, args0, args1, args2);
                }
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Ssse3.IsSupported) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleKernel(Vector128<float> vector, Vector128<int> indices) {
                return YShuffleKernel(vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleKernel(Vector128<double> vector, Vector128<long> indices) {
                return YShuffleKernel(vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices) {
                return YShuffleKernel(vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices) {
                if (Ssse3.IsSupported) {
                    return Ssse3.Shuffle(vector, indices);
                    // Remark: The value of each element must be less than count
                } else {
                    return SuperStatics.YShuffleKernel(vector, indices);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices) {
                return YShuffleKernel(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices) {
                if (Ssse3.IsSupported) {
                    return YShuffleKernel_Multiply(vector, indices);
                } else {
                    return SuperStatics.YShuffleKernel(vector, indices);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleKernel_Multiply(Vector128<ushort> vector, Vector128<ushort> indices) {
                Vector128<byte> indices2 = Sse2.Add(Multiply(indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt16_ByteOffset);
                return YShuffleKernel(vector.AsByte(), indices2).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleKernel_ShiftLane(Vector128<ushort> vector, Vector128<ushort> indices) {
                Vector128<ushort> m = Sse2.ShiftLeftLogical(indices, 1); // n*2 = n << 1;
                Vector128<byte> temp = Sse2.Or(m, Sse2.ShiftLeftLogical128BitLane(m, 1)).AsByte();
                Vector128<byte> indices2 = Sse2.Add(temp, Vector128Constants.Shuffle_UInt16_ByteOffset);
                return YShuffleKernel(vector.AsByte(), indices2).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleKernel(Vector128<int> vector, Vector128<int> indices) {
                return YShuffleKernel(vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleKernel(Vector128<uint> vector, Vector128<uint> indices) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices2 = Sse2.Add(Multiply(indices, Vector128Constants.Shuffle_UInt32_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt32_ByteOffset);
                    return YShuffleKernel(vector.AsByte(), indices2).AsUInt32();
                } else {
                    return SuperStatics.YShuffleKernel(vector, indices);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleKernel(Vector128<long> vector, Vector128<long> indices) {
                return YShuffleKernel(vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel(Vector128<ulong> vector, Vector128<ulong> indices) {
                return YShuffleKernel_MultiplyDuplicate(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel_DuplicateEven(Vector128<ulong> vector, Vector128<ulong> indices) {
                Vector128<uint> temp = Sse2.Shuffle(indices.AsUInt32(), (byte)ShuffleControlG4.XXZZ);
                temp = Sse2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                Vector128<uint> indices2 = Sse2.Add(temp, Vector128Constants.Shuffle_UInt64_UInt32Offset);
                return YShuffleKernel(vector.AsUInt32(), indices2).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel_Multiply(Vector128<ulong> vector, Vector128<ulong> indices) {
                Vector128<byte> indices2 = Sse2.Add(Multiply(indices, Vector128Constants.Shuffle_UInt64_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
                return YShuffleKernel(vector.AsByte(), indices2).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel_MultiplyDuplicate(Vector128<ulong> vector, Vector128<ulong> indices) {
                Vector128<uint> temp = Sse2.Multiply(indices.AsUInt32(), Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsUInt32(); // (temp0, 0, temp1, 0)
                temp = Sse2.Shuffle(temp, (byte)ShuffleControlG4.XXZZ);  // (temp0, temp0, temp1, temp1)
                Vector128<byte> indices2 = Sse2.Add(temp.AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset);
                return YShuffleKernel(vector.AsByte(), indices2).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
                YShuffleKernel_Args(indices.AsByte(), out var a0, out var a1);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
                if (Ssse3.IsSupported) {
                    args0 = indices;
                    args1 = default;
                } else {
                    SuperStatics.YShuffleKernel_Args(indices, out args0, out args1);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
                YShuffleKernel_Args(indices.AsUInt16(), out var a0, out var a1);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices2 = Sse2.Add(Multiply(indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt16_ByteOffset);
                    YShuffleKernel_Args(indices2, out var a0, out var a1);
                    args0 = a0.AsUInt16();
                    args1 = a1.AsUInt16();
                } else {
                    SuperStatics.YShuffleKernel_Args(indices, out args0, out args1);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
                YShuffleKernel_Args(indices.AsUInt32(), out var a0, out var a1);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
                if (Ssse3.IsSupported) {
                    Vector128<byte> indices2 = Sse2.Add(Multiply(indices, Vector128Constants.Shuffle_UInt32_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt32_ByteOffset);
                    YShuffleKernel_Args(indices2, out var a0, out var a1);
                    args0 = a0.AsUInt32();
                    args1 = a1.AsUInt32();
                } else {
                    SuperStatics.YShuffleKernel_Args(indices, out args0, out args1);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
                YShuffleKernel_Args(indices.AsUInt64(), out var a0, out var a1);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
                if (Ssse3.IsSupported) {
                    args1 = default;
                    //args0 = Sse2.Add(Multiply(indices, Vector128Constants.Shuffle_UInt64_Multiplier).AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset).AsUInt64();
                    Vector128<uint> temp = Sse2.Multiply(indices.AsUInt32(), Vector128Constants.Shuffle_UInt64_Multiplier.AsUInt32()).AsUInt32(); // (temp0, 0, temp1, 0)
                    temp = Sse2.Shuffle(temp, (byte)ShuffleControlG4.XXZZ);  // (temp0, temp0, temp1, temp1)
                    args0 = Sse2.Add(temp.AsByte(), Vector128Constants.Shuffle_UInt64_ByteOffset).AsUInt64();
                } else {
                    SuperStatics.YShuffleKernel_Args(indices, out args0, out args1);
                }
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleKernel_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
                return YShuffleKernel_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleKernel_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
                return YShuffleKernel_Core(vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleKernel_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                return YShuffleKernel_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleKernel_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
                if (Ssse3.IsSupported) {
                    _ = args1;
                    return Ssse3.Shuffle(vector, args0);
                } else {
                    return SuperStatics.YShuffleKernel_Core(vector, args0, args1);
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleKernel_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
                return YShuffleKernel_Core(vector.AsUInt16(), args0.AsUInt16(), args1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleKernel_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
                return YShuffleKernel_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleKernel_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
                return YShuffleKernel_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleKernel_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
                return YShuffleKernel_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleKernel_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
                return YShuffleKernel_Core(vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
                return YShuffleKernel_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.YSign_AcceleratedTypes"/>
            public static TypeCodeFlags YSign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YSign(Vector128<float> value) {
                Vector128<float> zero = Vector128<float>.Zero;
                Vector128<int> m = LessThan(value, zero).AsInt32();
                Vector128<int> n = GreaterThan(value, zero).AsInt32();
                Vector128<int> rt = Sse2.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YSign(Vector128<double> value) {
                Vector128<double> zero = Vector128<double>.Zero;
                Vector128<long> m = LessThan(value, zero).AsInt64();
                Vector128<long> n = GreaterThan(value, zero).AsInt64();
                Vector128<long> rt = Sse2.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YSign(Vector128<sbyte> value) {
                Vector128<sbyte> zero = Vector128<sbyte>.Zero;
                Vector128<sbyte> m = LessThan(value, zero);
                Vector128<sbyte> n = GreaterThan(value, zero);
                Vector128<sbyte> rt = Sse2.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YSign(Vector128<short> value) {
                Vector128<short> zero = Vector128<short>.Zero;
                Vector128<short> m = LessThan(value, zero);
                Vector128<short> n = GreaterThan(value, zero);
                Vector128<short> rt = Sse2.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YSign(Vector128<int> value) {
                Vector128<int> zero = Vector128<int>.Zero;
                Vector128<int> m = LessThan(value, zero);
                Vector128<int> n = GreaterThan(value, zero);
                Vector128<int> rt = Sse2.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YSign(Vector128<long> value) {
                Vector128<long> zero = Vector128<long>.Zero;
                Vector128<long> m = LessThan(value, zero);
                Vector128<long> n = GreaterThan(value, zero);
                Vector128<long> rt = Sse2.Subtract(m, n);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YSignFloat_AcceleratedTypes"/>
            public static TypeCodeFlags YSignFloat_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    rt |= (TypeCodeFlags.Single) & YIsNaN_AcceleratedTypes & ConvertToSingle_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Double) & YIsNaN_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YSignFloat(Vector128<float> value) {
                Vector128<int> signVal = YSign(value);
                Vector128<float> nanMask = YIsNaN(value).AsSingle();
                Vector128<float> rt = ConvertToSingle(signVal);
                rt = BitwiseOr(rt, BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YSignFloat(Vector128<double> value) {
                return YSignFloat_Compare(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YSignFloat_Compare(Vector128<double> value) {
                Vector128<double> negativeOne = Vector128.Create(-1.0);
                Vector128<double> zero = Vector128<double>.Zero;
                Vector128<double> one = Vector128.Create(1.0);
                Vector128<double> rt = BitwiseAnd(LessThan(value, zero), negativeOne);
                Vector128<double> nanMask = YIsNaN(value).AsDouble();
                rt = BitwiseOr(rt, BitwiseAnd(GreaterThan(value, zero), one)); // rt = ConvertToDouble(YSign(value));
                rt = BitwiseOr(rt, BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YSignFloat_Convert(Vector128<double> value) {
                Vector128<long> signVal = YSign(value);
                Vector128<double> nanMask = YIsNaN(value).AsDouble();
                Vector128<double> rt = ConvertToDouble_Range52(signVal);
                rt = BitwiseOr(rt, BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
