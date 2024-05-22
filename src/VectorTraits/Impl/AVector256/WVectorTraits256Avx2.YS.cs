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
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;
using System.Numerics;

namespace Zyl.VectorTraits.Impl.AVector256 {
    using SuperStatics = WVectorTraits256Base.Statics;

    partial class WVectorTraits256Avx2 {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG2_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleG2(Vector256<float> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleG2(Vector256<double> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleG2(Vector256<sbyte> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleG2(Vector256<byte> source, ShuffleControlG2 control) {
                Vector256<byte> indices = Vector256Constants.GetYShuffleG2_Byte_Indices(control); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
                return Avx2.Shuffle(source, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleG2(Vector256<short> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleG2(Vector256<ushort> source, ShuffleControlG2 control) {
                Vector256<byte> indices = Vector256Constants.GetYShuffleG2_UInt16_ByteIndices(control).AsByte(); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
                return Avx2.Shuffle(source.AsByte(), indices).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleG2(Vector256<int> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG2(Vector256<uint> source, ShuffleControlG2 control) {
                return YShuffleG2_Byte(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG2_Byte(Vector256<uint> source, ShuffleControlG2 control) {
                Vector256<byte> indices = Vector256Constants.GetYShuffleG2_UInt32_ByteIndices(control); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
                return Avx2.Shuffle(source.AsByte(), indices).AsUInt32();
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG2_UInt32(Vector256<uint> source, ShuffleControlG2 control) {
                Vector256<int> indices = Vector256Constants.GetYShuffleG2_UInt32_Indices(control).AsInt32(); // It also supports _mm256_permutevar_ps for 128-bit lanes .
                return Avx.PermuteVar(source.AsSingle(), indices).AsUInt32();
            }
#endif // !REDUCE_MEMORY_USAGE

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleG2(Vector256<long> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleG2(Vector256<ulong> source, ShuffleControlG2 control) {
                Vector256<byte> indices = Vector256Constants.GetYShuffleG2_UInt64_ByteIndices(control).AsByte(); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
                return Avx2.Shuffle(source.AsByte(), indices).AsUInt64();
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleG2_Const(Vector256<float> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleG2_Const(Vector256<double> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleG2_Const(Vector256<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleG2_Const(Vector256<byte> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleG2_Const(Vector256<short> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleG2_Const(Vector256<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleG2_Const(Vector256<int> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG2_Const(Vector256<uint> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleG2_Const(Vector256<long> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleG2_Const(Vector256<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleG2_Const_Imm(Vector256<float> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const_Imm(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleG2_Const_Imm(Vector256<double> source, [ConstantExpected] ShuffleControlG2 control) {
                byte ctl = (byte)((byte)control * 5);
                return Avx.Shuffle(source, source, ctl);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleG2_Const_Imm(Vector256<short> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const_Imm(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleG2_Const_Imm(Vector256<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
                byte n = (byte)control;
                byte ctl = (byte)(0xA0 + (n & 2) * 0x22 + (n & 1) * 0x11); // ShuffleControlG2 to ShuffleControlG4
                return Avx2.ShuffleHigh(Avx2.ShuffleLow(source, ctl), ctl);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleG2_Const_Imm(Vector256<int> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const_Imm(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleG2_Const_ImmByte(Vector256<int> source, [ConstantExpected(Max = 3)] byte control) {
                byte ctl = (byte)(0xA0 + (control & 2) * 0x22 + (control & 1) * 0x11); // ShuffleControlG2 to ShuffleControlG4
                return Avx2.Shuffle(source, ctl);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG2_Const_Imm(Vector256<uint> source, [ConstantExpected] ShuffleControlG2 control) {
                byte n = (byte)control;
                byte ctl = (byte)(0xA0 + (n & 2) * 0x22 + (n & 1) * 0x11); // ShuffleControlG2 to ShuffleControlG4
                return Avx2.Shuffle(source, ctl);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleG2_Const_Imm(Vector256<long> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const_Imm(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleG2_Const_Imm(Vector256<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const_Imm(source.AsDouble(), control).AsUInt64();
                //// _mm256_permute4x64_epi64
                // byte n = (byte)control;
                //byte ctl = (byte)(0xA0 + (n & 2) * 0x22 + (n & 1) * 0x11); // ShuffleControlG2 to ShuffleControlG4
                //return Avx2.Permute4x64(source, ctl);
            }
#endif // !REDUCE_MEMORY_USAGE


            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleG4(Vector256<float> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleG4(Vector256<double> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleG4(Vector256<sbyte> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleG4(Vector256<byte> source, ShuffleControlG4 control) {
                Vector256<byte> indices = Vector256Constants.GetYShuffleG4_Byte_Indices(control); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
                return Avx2.Shuffle(source, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleG4(Vector256<short> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleG4(Vector256<ushort> source, ShuffleControlG4 control) {
                Vector256<byte> indices = Vector256Constants.GetYShuffleG4_UInt16_ByteIndices(control).AsByte(); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
                return Avx2.Shuffle(source.AsByte(), indices).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleG4(Vector256<int> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG4(Vector256<uint> source, ShuffleControlG4 control) {
                return YShuffleG4_Byte(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG4_Byte(Vector256<uint> source, ShuffleControlG4 control) {
                Vector256<byte> indices = Vector256Constants.GetYShuffleG4_UInt32_ByteIndices(control).AsByte(); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
                return Avx2.Shuffle(source.AsByte(), indices).AsUInt32(); // _mm256_shuffle_epi8
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG4_UInt32(Vector256<uint> source, ShuffleControlG4 control) {
                Vector256<int> indices = Vector256Constants.GetYShuffleG4_UInt32_Indices(control).AsInt32(); // It also supports _mm256_permutevar_ps for 128-bit lanes .
                return Avx.PermuteVar(source.AsSingle(), indices).AsUInt32(); // _mm256_permutevar_ps
            }
#endif // !REDUCE_MEMORY_USAGE

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleG4(Vector256<long> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleG4(Vector256<ulong> source, ShuffleControlG4 control) {
                Vector256<uint> indices = Vector256Constants.GetYShuffleG4_UInt64_UInt32Indices(control);
                return Avx2.PermuteVar8x32(source.AsUInt32(), indices).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleG4_Const(Vector256<float> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleG4_Const(Vector256<double> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleG4_Const(Vector256<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleG4_Const(Vector256<byte> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleG4_Const(Vector256<short> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleG4_Const(Vector256<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleG4_Const(Vector256<int> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG4_Const(Vector256<uint> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleG4_Const(Vector256<long> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleG4_Const(Vector256<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleG4_Const_Imm(Vector256<float> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4_Const_Imm(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleG4_Const_Imm(Vector256<double> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx2.Permute4x64(source, (byte)control); // _mm256_permute4x64_epi64
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleG4_Const_Imm(Vector256<short> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx2.ShuffleHigh(Avx2.ShuffleLow(source, (byte)control), (byte)control);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleG4_Const_Imm(Vector256<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx2.ShuffleHigh(Avx2.ShuffleLow(source, (byte)control), (byte)control);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleG4_Const_Imm(Vector256<int> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx2.Shuffle(source, (byte)control);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleG4_Const_ImmByte(Vector256<int> source, [ConstantExpected(Max = 255)] byte control) {
                return Avx2.Shuffle(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG4_Const_Imm(Vector256<uint> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx2.Shuffle(source, (byte)control);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleG4_Const_Imm(Vector256<long> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx2.Permute4x64(source, (byte)control); // _mm256_permute4x64_epi64
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleG4_Const_Imm(Vector256<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx2.Permute4x64(source, (byte)control); // _mm256_permute4x64_epi64
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
                get {
                    return YShuffleG4_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{float}, Vector256{float}, ShuffleControlG4, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleG4X2(Vector256<float> source0, Vector256<float> source1, ShuffleControlG4 control, out Vector256<float> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt32(), source1.AsUInt32(), control, out var rt1);
                result1 = rt1.AsSingle();
                return rt0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{double}, Vector256{double}, ShuffleControlG4, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleG4X2(Vector256<double> source0, Vector256<double> source1, ShuffleControlG4 control, out Vector256<double> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt64(), source1.AsUInt64(), control, out var rt1);
                result1 = rt1.AsDouble();
                return rt0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{sbyte}, Vector256{sbyte}, ShuffleControlG4, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleG4X2(Vector256<sbyte> source0, Vector256<sbyte> source1, ShuffleControlG4 control, out Vector256<sbyte> result1) {
                var rt0 = YShuffleG4X2(source0.AsByte(), source1.AsByte(), control, out var rt1);
                result1 = rt1.AsSByte();
                return rt0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleG4X2(Vector256<byte> source0, Vector256<byte> source1, ShuffleControlG4 control, out Vector256<byte> result1) {
                Vector256<byte> indices = Vector256Constants.GetYShuffleG4_Byte_Indices(control); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
                var rt0 = Avx2.Shuffle(source0, indices);
                result1 = Avx2.Shuffle(source1, indices);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{short}, Vector256{short}, ShuffleControlG4, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleG4X2(Vector256<short> source0, Vector256<short> source1, ShuffleControlG4 control, out Vector256<short> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt16(), source1.AsUInt16(), control, out var rt1);
                result1 = rt1.AsInt16();
                return rt0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{ushort}, Vector256{ushort}, ShuffleControlG4, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleG4X2(Vector256<ushort> source0, Vector256<ushort> source1, ShuffleControlG4 control, out Vector256<ushort> result1) {
                Vector256<byte> indices = Vector256Constants.GetYShuffleG4_UInt16_ByteIndices(control).AsByte(); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
                var rt0 = Avx2.Shuffle(source0.AsByte(), indices).AsUInt16();
                result1 = Avx2.Shuffle(source1.AsByte(), indices).AsUInt16();
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{int}, Vector256{int}, ShuffleControlG4, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleG4X2(Vector256<int> source0, Vector256<int> source1, ShuffleControlG4 control, out Vector256<int> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt32(), source1.AsUInt32(), control, out var rt1);
                result1 = rt1.AsInt32();
                return rt0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{uint}, Vector256{uint}, ShuffleControlG4, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG4X2(Vector256<uint> source0, Vector256<uint> source1, ShuffleControlG4 control, out Vector256<uint> result1) {
                Vector256<byte> indices = Vector256Constants.GetYShuffleG4_UInt32_ByteIndices(control).AsByte(); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
                var rt0 = Avx2.Shuffle(source0.AsByte(), indices).AsUInt32();
                result1 = Avx2.Shuffle(source1.AsByte(), indices).AsUInt32();
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{long}, Vector256{long}, ShuffleControlG4, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleG4X2(Vector256<long> source0, Vector256<long> source1, ShuffleControlG4 control, out Vector256<long> result1) {
                Vector256<uint> indices = Vector256Constants.GetYShuffleG4_UInt64_UInt32Indices(control);
                var rt0 = Avx2.PermuteVar8x32(source0.AsUInt32(), indices).AsInt64();
                result1 = Avx2.PermuteVar8x32(source1.AsUInt32(), indices).AsInt64();
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{ulong}, Vector256{ulong}, ShuffleControlG4, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleG4X2(Vector256<ulong> source0, Vector256<ulong> source1, ShuffleControlG4 control, out Vector256<ulong> result1) {
                Vector256<uint> indices = Vector256Constants.GetYShuffleG4_UInt64_UInt32Indices(control);
                var rt0 = Avx2.PermuteVar8x32(source0.AsUInt32(), indices).AsUInt64();
                result1 = Avx2.PermuteVar8x32(source1.AsUInt32(), indices).AsUInt64();
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{float}, Vector256{float}, ShuffleControlG4, out Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleG4X2_Const(Vector256<float> source0, Vector256<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<float> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{double}, Vector256{double}, ShuffleControlG4, out Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleG4X2_Const(Vector256<double> source0, Vector256<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<double> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{sbyte}, Vector256{sbyte}, ShuffleControlG4, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleG4X2_Const(Vector256<sbyte> source0, Vector256<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<sbyte> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleG4X2_Const(Vector256<byte> source0, Vector256<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<byte> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{short}, Vector256{short}, ShuffleControlG4, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleG4X2_Const(Vector256<short> source0, Vector256<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<short> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{ushort}, Vector256{ushort}, ShuffleControlG4, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleG4X2_Const(Vector256<ushort> source0, Vector256<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<ushort> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{int}, Vector256{int}, ShuffleControlG4, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleG4X2_Const(Vector256<int> source0, Vector256<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<int> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{uint}, Vector256{uint}, ShuffleControlG4, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG4X2_Const(Vector256<uint> source0, Vector256<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<uint> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{long}, Vector256{long}, ShuffleControlG4, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleG4X2_Const(Vector256<long> source0, Vector256<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<long> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{ulong}, Vector256{ulong}, ShuffleControlG4, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleG4X2_Const(Vector256<ulong> source0, Vector256<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<ulong> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
                get {
                    return YShuffleKernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleInsert(Vector256<float> back, Vector256<float> vector, Vector256<int> indices) {
                //return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsSingle();
                Vector256<float> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<int>.Zero).AsSingle(); // Unsigned compare: (i < 8)
                raw = YShuffleKernel(vector, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back); // Avx2.BlendVariable(back, raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleInsert(Vector256<double> back, Vector256<double> vector, Vector256<long> indices) {
                //return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsDouble();
                Vector256<double> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 2), Vector256<long>.Zero).AsDouble(); // Unsigned compare: (i < 4)
                raw = YShuffleKernel(vector, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back); // Avx2.BlendVariable(back, raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleInsert(Vector256<sbyte> back, Vector256<sbyte> vector, Vector256<sbyte> indices) {
                return YShuffleInsert(back.AsByte(), vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleInsert(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    Vector256<byte> mask;
                    if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                        mask = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)32), indices);
                    } else {
                        var indicesAdded = Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue));
                        mask = Avx2.CompareGreaterThan(
                            Vector256.Create((sbyte)(32 + sbyte.MinValue)),
                            indicesAdded
                        ).AsByte(); // Unsigned compare: (i < 32)
                    }
                    Vector256<byte> raw = YShuffleKernel(vector, indices);
                    Vector256<byte> rt = ConditionalSelect(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleInsert_Add1(back, vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleInsert_Add1(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
                var indicesAdded = Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue));
                Vector256<byte> mask = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(32 + sbyte.MinValue)),
                    indicesAdded
                ).AsByte(); // Unsigned compare: (i < 32)
                Vector256<byte> raw = YShuffleKernel(vector, indices);
                Vector256<byte> rt = ConditionalSelect_Relaxed(mask, raw, back); // Avx2.BlendVariable(back, raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleInsert_Add2(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
                Vector256<byte> mask = GreaterThan(Vector256.Create((byte)32), indices);
                Vector256<byte> raw = YShuffleKernel(vector, indices);
                Vector256<byte> rt = ConditionalSelect_Relaxed(mask, raw, back); // Avx2.BlendVariable(back, raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleInsert_Cmp2(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
                Vector256<byte> mask = Avx2.AndNot(
                    Avx2.CompareGreaterThan(Vector256<sbyte>.Zero, indices.AsSByte()),
                    Avx2.CompareGreaterThan(Vector256.Create((sbyte)32), indices.AsSByte())
                ).AsByte(); // (0<=i && i<32)
                Vector256<byte> raw = YShuffleKernel(vector, indices);
                Vector256<byte> rt = ConditionalSelect_Relaxed(mask, raw, back); // Avx2.BlendVariable(back, raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleInsert_EqualAnd(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
                Vector256<byte> maskOverflow = Vector256.Create((byte)0xE0); // ((byte)~(System.Runtime.Intrinsics.Vector256<byte>.Count - 1)).ToString("X2") = "E0"
                Vector256<byte> mask = Avx2.CompareEqual(
                    Vector256<byte>.Zero,
                    Avx2.And(indices, maskOverflow)
                ); // (0<=i && i<32)
                Vector256<byte> raw = YShuffleKernel(vector, indices);
                Vector256<byte> rt = ConditionalSelect_Relaxed(mask, raw, back); // Avx2.BlendVariable(back, raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleInsert(Vector256<short> back, Vector256<short> vector, Vector256<short> indices) {
                return YShuffleInsert(back.AsUInt16(), vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleInsert(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> indices) {
                Vector256<ushort> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<ushort>.Zero); // Unsigned compare: (i < 16)
                raw = YShuffleKernel(vector, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back); // Avx2.BlendVariable(back, raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleInsert(Vector256<int> back, Vector256<int> vector, Vector256<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleInsert(Vector256<uint> back, Vector256<uint> vector, Vector256<uint> indices) {
                Vector256<uint> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<uint>.Zero); // Unsigned compare: (i < 8)
                raw = YShuffleKernel(vector, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back); // Avx2.BlendVariable(back, raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleInsert(Vector256<long> back, Vector256<long> vector, Vector256<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleInsert(Vector256<ulong> back, Vector256<ulong> vector, Vector256<ulong> indices) {
                Vector256<ulong> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 2), Vector256<ulong>.Zero); // Unsigned compare: (i < 4)
                raw = YShuffleKernel(vector, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back); // Avx2.BlendVariable(back, raw, mask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2) {
                YShuffleInsert_Args(indices.AsByte(), out var a0, out var a1, out var a2);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2) {
                YShuffleKernel_Args(indices, out args0, out args1);
#if NET8_0_OR_GREATER
                if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                    args2 = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)32), indices);
                    return;
                }
#endif // NET8_0_OR_GREATER
                var indicesAdded = Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue));
                args2 = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(32 + sbyte.MinValue)),
                    indicesAdded
                ).AsByte(); // Unsigned compare: (i < 32)
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2) {
                YShuffleInsert_Args(indices.AsUInt16(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2) {
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<ushort>.Zero); // Unsigned compare: (i < 16)
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2) {
                YShuffleInsert_Args(indices.AsUInt32(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2) {
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<uint>.Zero); // Unsigned compare: (i < 8)
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2) {
                YShuffleInsert_Args(indices.AsUInt64(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2) {
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 2), Vector256<ulong>.Zero); // Unsigned compare: (i < 4)
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleInsert_Core(Vector256<float> back, Vector256<float> vector, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) {
                //return YShuffleInsert_Core(back.AsUInt32(), vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32()).AsSingle();
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = ConditionalSelect_Relaxed(args2.AsSingle(), raw, back); // Avx2.BlendVariable(back, raw, args2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleInsert_Core(Vector256<double> back, Vector256<double> vector, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) {
                //return YShuffleInsert_Core(back.AsUInt64(), vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64()).AsDouble();
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = ConditionalSelect_Relaxed(args2.AsDouble(), raw, back); // Avx2.BlendVariable(back, raw, args2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleInsert_Core(Vector256<sbyte> back, Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2) {
                return YShuffleInsert_Core(back.AsByte(), vector.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleInsert_Core(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2) {
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = ConditionalSelect_Relaxed(args2, raw, back); // Avx2.BlendVariable(back, raw, args2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleInsert_Core(Vector256<short> back, Vector256<short> vector, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2) {
                return YShuffleInsert_Core(back.AsUInt16(), vector.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleInsert_Core(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2) {
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = ConditionalSelect_Relaxed(args2, raw, back); // Avx2.BlendVariable(back, raw, args2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleInsert_Core(Vector256<int> back, Vector256<int> vector, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) {
                return YShuffleInsert_Core(back.AsUInt32(), vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleInsert_Core(Vector256<uint> back, Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2) {
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = ConditionalSelect_Relaxed(args2, raw, back); // Avx2.BlendVariable(back, raw, args2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleInsert_Core(Vector256<long> back, Vector256<long> vector, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) {
                return YShuffleInsert_Core(back.AsUInt64(), vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleInsert_Core(Vector256<ulong> back, Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2) {
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = ConditionalSelect_Relaxed(args2, raw, back); // Avx2.BlendVariable(back, raw, args2);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleKernel(Vector256<float> vector, Vector256<int> indices) {
                return Avx2.PermuteVar8x32(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleKernel(Vector256<double> vector, Vector256<long> indices) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.PermuteVar4x64(vector, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleKernel(vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleKernel(Vector256<sbyte> vector, Vector256<sbyte> indices) {
                return YShuffleKernel(vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleKernel(Vector256<byte> vector, Vector256<byte> indices) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return Avx512Vbmi.VL.PermuteVar32x8(vector, indices);
                    //__m256i _mm256_permutexvar_epi8 (__m256i idx, __m256i a)
                    //#include <immintrin.h>
                    //Instruction: vpermb ymm, ymm, ymm
                    //CPUID Flags: AVX512_VBMI + AVX512VL
                    //Latency and Throughput
                    //Architecture	Latency	Throughput (CPI)
                    //Icelake Intel Core	-	1
                    //Icelake Xeon	3	1
                    //Sapphire Rapids	5	1
                }
#endif // NET8_0_OR_GREATER
                return YShuffleKernel_ByteAdd2(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleKernel_ByteAdd(Vector256<byte> vector, Vector256<byte> indices) {
                // Shuffle elements of __m256i vector
                // https://stackoverflow.com/questions/30669556/shuffle-elements-of-m256i-vector
                // ErmIg answered Jun 5, 2015 at 14:54
                return Avx2.Or(
                    Avx2.Shuffle(Avx2.Permute4x64(vector.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(), Avx2.Add(indices, Vector256Constants.Shuffle_Byte_LaneAdd_K1))
                    , Avx2.Shuffle(vector, Avx2.Add(indices, Vector256Constants.Shuffle_Byte_LaneAdd_K0))
                );
                // Remark: The value of each element must be less than count
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleKernel_ByteAdd2(Vector256<byte> vector, Vector256<byte> indices) {
                // Format: Code; //Latency, Throughput(references IceLake)
                Vector256<byte> vector1 = Avx2.Permute4x64(vector.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                Vector256<byte> indices0 = Avx2.Add(indices, Vector256Constants.Shuffle_Byte_LaneAdd_K0); // 1,0.33
                Vector256<byte> indices1 = Avx2.Add(indices, Vector256Constants.Shuffle_Byte_LaneAdd_K1); // 1,0.33
                Vector256<byte> v0 = Avx2.Shuffle(vector, indices0); // 1,0.5
                Vector256<byte> v1 = Avx2.Shuffle(vector1, indices1); // 1,0.5
                Vector256<byte> rt = Avx2.Or(v0, v1); // 1,0.33
                return rt; //total latency: 8, total throughput CPI: 3
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleKernel(Vector256<short> vector, Vector256<short> indices) {
                return YShuffleKernel(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleKernel(Vector256<ushort> vector, Vector256<ushort> indices) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return Avx512BW.VL.PermuteVar16x16(vector, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleKernel_Multiply(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleKernel_Multiply(Vector256<ushort> vector, Vector256<ushort> indices) {
                Vector256<byte> indices2 = Avx2.Add(Multiply(indices, Vector256Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector256Constants.Shuffle_UInt16_ByteOffset);
                return YShuffleKernel(vector.AsByte(), indices2).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleKernel_ShiftLane(Vector256<ushort> vector, Vector256<ushort> indices) {
                Vector256<ushort> m = Avx2.ShiftLeftLogical(indices, 1); // n*2 = n << 1;
                Vector256<byte> temp = Avx2.Or(m, Avx2.ShiftLeftLogical128BitLane(m, 1)).AsByte();
                Vector256<byte> indices2 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt16_ByteOffset);
                return YShuffleKernel(vector.AsByte(), indices2).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleKernel(Vector256<int> vector, Vector256<int> indices) {
                return Avx2.PermuteVar8x32(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleKernel(Vector256<uint> vector, Vector256<uint> indices) {
                return Avx2.PermuteVar8x32(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleKernel(Vector256<long> vector, Vector256<long> indices) {
                return YShuffleKernel(vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleKernel(Vector256<ulong> vector, Vector256<ulong> indices) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.PermuteVar4x64(vector, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleKernel_DuplicateEven(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleKernel_AlignRight(Vector256<ulong> vector, Vector256<ulong> indices) {
                Vector256<uint> temp = Avx2.Or(indices, Avx2.AlignRight(indices, indices, 4)).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                Vector256<uint> indices2 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset);
                return Avx2.PermuteVar8x32(vector.AsUInt32(), indices2).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleKernel_DuplicateEven(Vector256<ulong> vector, Vector256<ulong> indices) {
                Vector256<uint> temp = Avx.DuplicateEvenIndexed(indices.AsSingle()).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                Vector256<uint> indices2 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset);
                return Avx2.PermuteVar8x32(vector.AsUInt32(), indices2).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleKernel_Multiply(Vector256<ulong> vector, Vector256<ulong> indices) {
                Vector256<uint> indices2 = Avx2.Add(Multiply(indices, Vector256Constants.Shuffle_UInt64_Multiplier).AsUInt32(), Vector256Constants.Shuffle_UInt64_UInt32Offset);
                return Avx2.PermuteVar8x32(vector.AsUInt32(), indices2).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleKernel_ShiftLane(Vector256<ulong> vector, Vector256<ulong> indices) {
                Vector256<uint> temp = Avx2.Or(indices, Avx2.ShiftLeftLogical128BitLane(indices, 4)).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                Vector256<uint> indices2 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset);
                return Avx2.PermuteVar8x32(vector.AsUInt32(), indices2).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1) {
                YShuffleKernel_Args(indices.AsByte(), out var a0, out var a1);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                args0 = Avx2.Add(indices, Vector256Constants.Shuffle_Byte_LaneAdd_K0);
                args1 = Avx2.Add(indices, Vector256Constants.Shuffle_Byte_LaneAdd_K1);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1) {
                YShuffleKernel_Args(indices.AsUInt16(), out var a0, out var a1);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<byte> indices2 = Avx2.Add(Multiply(indices, Vector256Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector256Constants.Shuffle_UInt16_ByteOffset);
                YShuffleKernel_Args(indices2, out var a0, out var a1);
                args0 = a0.AsUInt16();
                args1 = a1.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1) {
                YShuffleKernel_Args(indices.AsUInt64(), out var a0, out var a1);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1) {
                args1 = default;
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    args0 = indices;
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<uint> temp = Avx.DuplicateEvenIndexed(indices.AsSingle()).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                args0 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleKernel_Core(Vector256<float> vector, Vector256<int> args0, Vector256<int> args1) {
                _ = args1;
                return Avx2.PermuteVar8x32(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleKernel_Core(Vector256<double> vector, Vector256<long> args0, Vector256<long> args1) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.PermuteVar4x64(vector, args0);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleKernel_Core(vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleKernel_Core(Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1) {
                return YShuffleKernel_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleKernel_Core(Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return Avx512Vbmi.VL.PermuteVar32x8(vector, args0);
                }
#endif // NET8_0_OR_GREATER
                // Format: Code; //Latency, Throughput(references IceLake)
                Vector256<byte> vector1 = Avx2.Permute4x64(vector.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                Vector256<byte> v0 = Avx2.Shuffle(vector, args0); // 1,0.5
                Vector256<byte> v1 = Avx2.Shuffle(vector1, args1); // 1,0.5
                Vector256<byte> rt = Avx2.Or(v0, v1); // 1,0.33
                return rt; //total latency: 6, total throughput CPI: 2.33
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleKernel_Core(Vector256<short> vector, Vector256<short> args0, Vector256<short> args1) {
                return YShuffleKernel_Core(vector.AsUInt16(), args0.AsUInt16(), args1.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleKernel_Core(Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return Avx512BW.VL.PermuteVar16x16(vector, args0);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleKernel_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleKernel_Core(Vector256<int> vector, Vector256<int> args0, Vector256<int> args1) {
                _ = args1;
                return Avx2.PermuteVar8x32(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleKernel_Core(Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1) {
                _ = args1;
                return Avx2.PermuteVar8x32(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleKernel_Core(Vector256<long> vector, Vector256<long> args0, Vector256<long> args1) {
                return YShuffleKernel_Core(vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleKernel_Core(Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1) {
                _ = args1;
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.PermuteVar4x64(vector, args0);
                }
#endif // NET8_0_OR_GREATER
                return Avx2.PermuteVar8x32(vector.AsUInt32(), args0.AsUInt32()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2_AcceleratedTypes {
                get {
                    return YShuffleX2Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX2(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
                //return YShuffleX2(vector0.AsInt32(), vector1.AsInt32(), indices).AsSingle();
                Vector256<float> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<int>.Zero).AsSingle(); // Unsigned compare: (i < 16)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    rt = Avx.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = Avx.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX2(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
                //return YShuffleX2(vector0.AsInt64(), vector1.AsInt64(), indices).AsDouble();
                Vector256<double> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<long>.Zero).AsDouble(); // Unsigned compare: (i < 8)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    rt = Avx.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = Avx.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX2(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
                return YShuffleX2(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX2(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
                Vector256<byte> mask, raw, rt;
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                        mask = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)64), indices);
                    } else {
                        mask = Avx2.CompareGreaterThan(
                            Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                            Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                        ).AsByte(); // Unsigned compare: (i < 64)
                    }
                    raw = Avx512Vbmi.VL.PermuteVar32x8x2(vector0, indices, vector1);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                mask = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                    Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < 64)
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX2(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
                return YShuffleX2(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX2(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
                Vector256<ushort> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 5), Vector256<ushort>.Zero); // Unsigned compare: (i < 32)
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    raw = Avx512BW.VL.PermuteVar16x16x2(vector0, indices, vector1);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX2(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
                return YShuffleX2(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX2(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
                Vector256<uint> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<uint>.Zero); // Unsigned compare: (i < 16)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX2(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
                return YShuffleX2(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX2(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
                Vector256<ulong> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<ulong>.Zero); // Unsigned compare: (i < 8)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
                YShuffleX2_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
                args4 = a4.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
                YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                        args4 = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)64), indices);
                    } else {
                        args4 = Avx2.CompareGreaterThan(
                            Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                            Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                        ).AsByte(); // Unsigned compare: (i < 64)
                    }
                    return;
                }
#endif // NET8_0_OR_GREATER
                args4 = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                    Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < 64)
                Vector256<byte> mask = OnesComplement(args4); // Used for _mm256_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = Avx2.Or(args0, mask);
                args1 = Avx2.Or(args1, mask);
                args2 = Avx2.Or(args2, mask);
                args3 = Avx2.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
                YShuffleX2_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
                args4 = a4.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
                YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 5), Vector256<ushort>.Zero); // Unsigned compare: (i < 32)
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<ushort> mask = OnesComplement(args4); // Used for _mm256_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = Avx2.Or(args0, mask);
                args1 = Avx2.Or(args1, mask);
                args2 = Avx2.Or(args2, mask);
                args3 = Avx2.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
                YShuffleX2_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
                args4 = a4.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
                YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<uint>.Zero); // Unsigned compare: (i < 16)
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
                YShuffleX2_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
                args4 = a4.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
                YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<ulong>.Zero); // Unsigned compare: (i < 8)
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX2_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
                //return YShuffleX2_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
                Vector256<float> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx.And(rt, args4.AsSingle());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX2_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
                //return YShuffleX2_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
                Vector256<double> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx.And(rt, args4.AsDouble());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX2_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
                return YShuffleX2_Core(vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX2_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
                Vector256<byte> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    rt = Avx2.And(rt, args4);
                }
#endif // NET8_0_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX2_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
                return YShuffleX2_Core(vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX2_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
                Vector256<ushort> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    rt = Avx2.And(rt, args4);
                }
#endif // NET8_0_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX2_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
                return YShuffleX2_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX2_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
                Vector256<uint> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx2.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX2_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
                return YShuffleX2_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX2_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
                Vector256<ulong> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx2.And(rt, args4);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
                get {
                    return YShuffleX2Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX2Insert(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
                //return YShuffleX2Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
                Vector256<float> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<int>.Zero).AsSingle(); // Unsigned compare: (i < 16)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX2Insert(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
                //return YShuffleX2Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
                Vector256<double> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<long>.Zero).AsDouble(); // Unsigned compare: (i < 8)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX2Insert(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
                return YShuffleX2Insert(back.AsByte(), vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX2Insert(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
                Vector256<byte> mask, raw, rt;
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                        mask = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)64), indices);
                    } else {
                        mask = Avx2.CompareGreaterThan(
                            Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                            Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                        ).AsByte(); // Unsigned compare: (i < 64)
                    }
                    raw = Avx512Vbmi.VL.PermuteVar32x8x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                mask = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                    Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < 64)
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX2Insert(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
                return YShuffleX2Insert(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX2Insert(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
                Vector256<ushort> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 5), Vector256<ushort>.Zero); // Unsigned compare: (i < 32)
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    raw = Avx512BW.VL.PermuteVar16x16x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX2Insert(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
                return YShuffleX2Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX2Insert(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
                Vector256<uint> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<uint>.Zero); // Unsigned compare: (i < 16)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX2Insert(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
                return YShuffleX2Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX2Insert(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
                Vector256<ulong> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<ulong>.Zero); // Unsigned compare: (i < 8)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX2Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX2Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
                //return YShuffleX2Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
                Vector256<float> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4.AsSingle(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX2Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
                //return YShuffleX2Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
                Vector256<double> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4.AsDouble(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX2Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
                return YShuffleX2Insert_Core(back.AsByte(), vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX2Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
                Vector256<byte> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX2Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
                return YShuffleX2Insert_Core(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX2Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
                Vector256<ushort> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX2Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
                return YShuffleX2Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX2Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
                Vector256<uint> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX2Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
                return YShuffleX2Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX2Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
                Vector256<ulong> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4, rt, back);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX2Kernel(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX2Kernel(vector0.AsInt32(), vector1.AsInt32(), indices).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX2Kernel(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX2Kernel(vector0.AsInt64(), vector1.AsInt64(), indices).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX2Kernel(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
                return YShuffleX2Kernel(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX2Kernel(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    return Avx512Vbmi.VL.PermuteVar32x8x2(vector0, indices, vector1);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX2Kernel_Combine3(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX2Kernel_Combine(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
                return YShuffleX2Kernel_Combine3(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX2Kernel_Combine(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
                Vector256<byte> vCount = Vector256.Create((byte)Vector256<byte>.Count);
                Vector256<byte> indices1 = Avx2.Subtract(indices, vCount);
                Vector256<byte> rt0 = YShuffleKernel_ByteAdd2(vector0, indices);
                Vector256<byte> mask = Avx2.CompareGreaterThan(vCount.AsSByte(), indices.AsSByte()).AsByte(); // vCount[i]>indices[i] ==> indices[i]<vCount[i].
                Vector256<byte> rt1 = YShuffleKernel_ByteAdd2(vector1, indices1);
                Vector256<byte> rt = ConditionalSelect_Relaxed(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX2Kernel_Combine2(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
                Vector256<byte> vCount = Vector256.Create((byte)Vector256<byte>.Count);
                Vector256<byte> K0 = Vector256Constants.Shuffle_Byte_LaneAdd_K0;
                Vector256<byte> K1 = Vector256Constants.Shuffle_Byte_LaneAdd_K1;
                Vector256<byte> indices1 = Avx2.Subtract(indices, vCount);
                //Vector256<byte> rt0 = YShuffleKernel(vector0, indices);
                Vector256<byte> rt0 = Avx2.Or(
                    Avx2.Shuffle(Avx2.Permute4x64(vector0.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(), Avx2.Add(indices, K1))
                    , Avx2.Shuffle(vector0, Avx2.Add(indices, K0))
                );
                Vector256<byte> mask = Avx2.CompareGreaterThan(vCount.AsSByte(), indices.AsSByte()).AsByte(); // vCount[i]>indices[i] ==> indices[i]<vCount[i].
                //Vector256<byte> rt1 = YShuffleKernel(vector1, indices1);
                Vector256<byte> rt1 = Avx2.Or(
                    Avx2.Shuffle(Avx2.Permute4x64(vector1.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(), Avx2.Add(indices1, K1))
                    , Avx2.Shuffle(vector1, Avx2.Add(indices1, K0))
                );
                Vector256<byte> rt = ConditionalSelect_Relaxed(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX2Kernel_Combine3(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
                Vector256<byte> vCount = Vector256.Create((byte)Vector256<byte>.Count);
                // Format: Code; //Latency, Throughput(references IceLake)
                Vector256<byte> vector0B = Avx2.Permute4x64(vector0.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                Vector256<byte> vector1B = Avx2.Permute4x64(vector1.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                Vector256<byte> indices1 = Avx2.Subtract(indices, vCount); // 1,0.33
                Vector256<byte> indices0A = Avx2.Add(indices, Vector256Constants.Shuffle_Byte_LaneAdd_K0); // 1,0.33
                Vector256<byte> indices0B = Avx2.Add(indices, Vector256Constants.Shuffle_Byte_LaneAdd_K1); // 1,0.33
                Vector256<byte> indices1A = Avx2.Add(indices1, Vector256Constants.Shuffle_Byte_LaneAdd_K0); // 1,0.33
                Vector256<byte> indices1B = Avx2.Add(indices1, Vector256Constants.Shuffle_Byte_LaneAdd_K1); // 1,0.33
                Vector256<byte> rt0A = Avx2.Shuffle(vector0, indices0A); // 1,0.5
                Vector256<byte> rt0B = Avx2.Shuffle(vector0B, indices0B); // 1,0.5
                Vector256<byte> rt1A = Avx2.Shuffle(vector1, indices1A); // 1,0.5
                Vector256<byte> rt1B = Avx2.Shuffle(vector1B, indices1B); // 1,0.5
                Vector256<byte> mask = Avx2.CompareGreaterThan(vCount.AsSByte(), indices.AsSByte()).AsByte(); // 1,0.5. vCount[i]>indices[i] ==> indices[i]<vCount[i].
                Vector256<byte> rt0 = Avx2.Or(rt0A, rt0B); // 1,0.33
                Vector256<byte> rt1 = Avx2.Or(rt1A, rt1B); // 1,0.33
                Vector256<byte> rt = ConditionalSelect_Relaxed(mask, rt0, rt1); // 3,1
                return rt; //total latency: 21, total throughput CPI: 7.83
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX2Kernel(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
                return YShuffleX2Kernel(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX2Kernel(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return Avx512BW.VL.PermuteVar16x16x2(vector0, indices, vector1);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX2Kernel_Combine(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{short}, Vector256{short}, Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX2Kernel_Combine(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
                return YShuffleX2Kernel_Combine(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX2Kernel_Combine(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
                Vector256<byte> indices2 = Avx2.Add(Multiply(indices, Vector256Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector256Constants.Shuffle_UInt16_ByteOffset);
                return YShuffleX2Kernel_Combine3(vector0.AsByte(), vector1.AsByte(), indices2).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX2Kernel(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
                return YShuffleX2Kernel(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX2Kernel(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX2Kernel_Combine(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{int}, Vector256{int}, Vector256{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX2Kernel_Combine(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
                return YShuffleX2Kernel_Combine(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX2Kernel_Combine(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
                Vector256<uint> vCount = Vector256.Create((uint)Vector256<uint>.Count);
                Vector256<uint> indices1 = Avx2.Subtract(indices, vCount);
                Vector256<uint> rt0 = Avx2.PermuteVar8x32(vector0, indices);
                Vector256<uint> mask = Avx2.CompareGreaterThan(vCount.AsInt32(), indices.AsInt32()).AsUInt32(); // vCount[i]>indices[i] ==> indices[i]<vCount[i].
                Vector256<uint> rt1 = Avx2.PermuteVar8x32(vector1, indices1);
                Vector256<uint> rt = ConditionalSelect_Relaxed(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX2Kernel(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
                return YShuffleX2Kernel(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX2Kernel(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX2Kernel_Combine(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{long}, Vector256{long}, Vector256{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX2Kernel_Combine(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
                return YShuffleX2Kernel_Combine(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX2Kernel_Combine(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
                Vector256<uint> temp = Avx.DuplicateEvenIndexed(indices.AsSingle()).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                Vector256<uint> indices2 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset);
                return YShuffleX2Kernel_Combine(vector0.AsUInt32(), vector1.AsUInt32(), indices2).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3) {
                YShuffleX2Kernel_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    args2 = default;
                    args3 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<byte> vCount = Vector256.Create((byte)Vector256<byte>.Count);
                Vector256<byte> K0 = Vector256Constants.Shuffle_Byte_LaneAdd_K0;
                Vector256<byte> K1 = Vector256Constants.Shuffle_Byte_LaneAdd_K1;
                Vector256<byte> indices1 = Avx2.Subtract(indices, vCount);
                Vector256<byte> mask = Avx2.CompareGreaterThan(vCount.AsSByte(), indices.AsSByte()).AsByte(); // vCount[i]>indices[i] ==> indices[i]<vCount[i].
                args0 = YOrNot(Avx2.Add(indices, K0), mask);
                args1 = YOrNot(Avx2.Add(indices, K1), mask);
                args2 = Avx2.Or(Avx2.Add(indices1, K0), mask);
                args3 = Avx2.Or(Avx2.Add(indices1, K1), mask);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3) {
                YShuffleX2Kernel_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    args2 = default;
                    args3 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<byte> indices2 = Avx2.Add(Multiply(indices, Vector256Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector256Constants.Shuffle_UInt16_ByteOffset);
                YShuffleX2Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt16();
                args1 = a1.AsUInt16();
                args2 = a2.AsUInt16();
                args3 = a3.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3) {
                YShuffleX2Kernel_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    args2 = default;
                    args3 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<uint> vCount = Vector256.Create((uint)Vector256<uint>.Count);
                Vector256<uint> indices1 = Avx2.Subtract(indices, vCount);
                Vector256<uint> mask = Avx2.CompareGreaterThan(vCount.AsInt32(), indices.AsInt32()).AsUInt32(); // vCount[i]>indices[i] ==> indices[i]<vCount[i].
                args0 = indices;
                args1 = indices1;
                args2 = mask;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3) {
                YShuffleX2Kernel_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    args2 = default;
                    args3 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<uint> temp = Avx.DuplicateEvenIndexed(indices.AsSingle()).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                Vector256<uint> indices2 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset);
                YShuffleX2Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt64();
                args1 = a1.AsUInt64();
                args2 = a2.AsUInt64();
                args3 = a3.AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX2Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.PermuteVar8x32x2(vector0, args0, vector1);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX2Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX2Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    _ = args1;
                    _ = args2;
                    _ = args3;
                    return Avx512F.VL.PermuteVar4x64x2(vector0, args0, vector1);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX2Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX2Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) {
                return YShuffleX2Kernel_Core(vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX2Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) {
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    _ = args1;
                    _ = args2;
                    _ = args3;
                    return Avx512Vbmi.VL.PermuteVar32x8x2(vector0, args0, vector1);
                }
#endif // NET8_0_OR_GREATER
                // Format: Code; //Latency, Throughput(references IceLake)
                Vector256<byte> vector0B = Avx2.Permute4x64(vector0.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                Vector256<byte> vector1B = Avx2.Permute4x64(vector1.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                Vector256<byte> rt0A = Avx2.Shuffle(vector0, args0); // 1,0.5
                Vector256<byte> rt0B = Avx2.Shuffle(vector0B, args1); // 1,0.5
                Vector256<byte> rt1A = Avx2.Shuffle(vector1, args2); // 1,0.5
                Vector256<byte> rt1B = Avx2.Shuffle(vector1B, args3); // 1,0.5
                Vector256<byte> rt0 = Avx2.Or(rt0A, rt0B); // 1,0.33
                Vector256<byte> rt1 = Avx2.Or(rt1A, rt1B); // 1,0.33
                Vector256<byte> rt = Avx2.Or(rt0, rt1); // 1,0.33
                return rt; //total latency: 13, total throughput CPI: 5
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX2Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) {
                return YShuffleX2Kernel_Core(vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX2Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) {
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return Avx512BW.VL.PermuteVar16x16x2(vector0, args0, vector1);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX2Kernel_Core(vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX2Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
                return YShuffleX2Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX2Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    return Avx512F.VL.PermuteVar8x32x2(vector0, args0, vector1);
                }
#endif // NET8_0_OR_GREATER
                _ = args3;
                Vector256<uint> rt0 = Avx2.PermuteVar8x32(vector0, args0);
                Vector256<uint> rt1 = Avx2.PermuteVar8x32(vector1, args1);
                Vector256<uint> rt = ConditionalSelect_Relaxed(args2, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX2Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
                return YShuffleX2Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX2Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX2Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) {
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    _ = args1;
                    _ = args2;
                    _ = args3;
                    return Avx512F.VL.PermuteVar4x64x2(vector0, args0, vector1);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX2Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsUInt64();
            }

/*
            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3_AcceleratedTypes {
                get {
                    return YShuffleX3Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX3(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
                //return YShuffleX3(vector0.AsInt32(), vector1.AsInt32(), indices).AsSingle();
                Vector256<float> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<int>.Zero).AsSingle(); // Unsigned compare: (i < 16)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    rt = Avx.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX3Kernel(vector0, vector1, indices);
                rt = Avx.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX3(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
                //return YShuffleX3(vector0.AsInt64(), vector1.AsInt64(), indices).AsDouble();
                Vector256<double> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<long>.Zero).AsDouble(); // Unsigned compare: (i < 8)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    rt = Avx.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX3Kernel(vector0, vector1, indices);
                rt = Avx.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX3(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
                return YShuffleX3(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX3(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
                Vector256<byte> mask, raw, rt;
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                        mask = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)64), indices);
                    } else {
                        mask = Avx2.CompareGreaterThan(
                            Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                            Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                        ).AsByte(); // Unsigned compare: (i < 64)
                    }
                    raw = Avx512Vbmi.VL.PermuteVar32x8x2(vector0, indices, vector1);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                mask = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                    Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < 64)
                raw = YShuffleX3Kernel(vector0, vector1, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX3(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
                return YShuffleX3(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX3(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
                Vector256<ushort> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 5), Vector256<ushort>.Zero); // Unsigned compare: (i < 32)
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    raw = Avx512BW.VL.PermuteVar16x16x2(vector0, indices, vector1);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX3Kernel(vector0, vector1, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX3(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
                return YShuffleX3(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX3(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
                Vector256<uint> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<uint>.Zero); // Unsigned compare: (i < 16)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX3Kernel(vector0, vector1, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX3(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
                return YShuffleX3(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX3(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
                Vector256<ulong> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<ulong>.Zero); // Unsigned compare: (i < 8)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX3Kernel(vector0, vector1, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
                YShuffleX3_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
                args4 = a4.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                        args4 = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)64), indices);
                    } else {
                        args4 = Avx2.CompareGreaterThan(
                            Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                            Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                        ).AsByte(); // Unsigned compare: (i < 64)
                    }
                    return;
                }
#endif // NET8_0_OR_GREATER
                args4 = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                    Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < 64)
                Vector256<byte> mask = OnesComplement(args4); // Used for _mm256_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = Avx2.Or(args0, mask);
                args1 = Avx2.Or(args1, mask);
                args2 = Avx2.Or(args2, mask);
                args3 = Avx2.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
                YShuffleX3_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
                args4 = a4.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 5), Vector256<ushort>.Zero); // Unsigned compare: (i < 32)
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<ushort> mask = OnesComplement(args4); // Used for _mm256_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = Avx2.Or(args0, mask);
                args1 = Avx2.Or(args1, mask);
                args2 = Avx2.Or(args2, mask);
                args3 = Avx2.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
                YShuffleX3_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
                args4 = a4.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<uint>.Zero); // Unsigned compare: (i < 16)
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
                YShuffleX3_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
                args4 = a4.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<ulong>.Zero); // Unsigned compare: (i < 8)
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX3_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
                //return YShuffleX3_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
                Vector256<float> rt = YShuffleX3Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx.And(rt, args4.AsSingle());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX3_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
                //return YShuffleX3_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
                Vector256<double> rt = YShuffleX3Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx.And(rt, args4.AsDouble());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX3_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
                return YShuffleX3_Core(vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX3_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
                Vector256<byte> rt = YShuffleX3Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    rt = Avx2.And(rt, args4);
                }
#endif // NET8_0_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX3_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
                return YShuffleX3_Core(vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX3_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
                Vector256<ushort> rt = YShuffleX3Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    rt = Avx2.And(rt, args4);
                }
#endif // NET8_0_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX3_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
                return YShuffleX3_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX3_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
                Vector256<uint> rt = YShuffleX3Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx2.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX3_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
                return YShuffleX3_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX3_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
                Vector256<ulong> rt = YShuffleX3Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx2.And(rt, args4);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Insert_AcceleratedTypes {
                get {
                    return YShuffleX3Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX3Insert(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
                //return YShuffleX3Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
                Vector256<float> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<int>.Zero).AsSingle(); // Unsigned compare: (i < 16)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX3Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX3Insert(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
                //return YShuffleX3Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
                Vector256<double> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<long>.Zero).AsDouble(); // Unsigned compare: (i < 8)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX3Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX3Insert(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
                return YShuffleX3Insert(back.AsByte(), vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX3Insert(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
                Vector256<byte> mask, raw, rt;
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                        mask = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)64), indices);
                    } else {
                        mask = Avx2.CompareGreaterThan(
                            Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                            Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                        ).AsByte(); // Unsigned compare: (i < 64)
                    }
                    raw = Avx512Vbmi.VL.PermuteVar32x8x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                mask = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                    Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < 64)
                raw = YShuffleX3Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX3Insert(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
                return YShuffleX3Insert(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX3Insert(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
                Vector256<ushort> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 5), Vector256<ushort>.Zero); // Unsigned compare: (i < 32)
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    raw = Avx512BW.VL.PermuteVar16x16x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX3Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX3Insert(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
                return YShuffleX3Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX3Insert(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
                Vector256<uint> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<uint>.Zero); // Unsigned compare: (i < 16)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX3Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX3Insert(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
                return YShuffleX3Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX3Insert(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
                Vector256<ulong> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<ulong>.Zero); // Unsigned compare: (i < 8)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX3Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX3Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
                //return YShuffleX3Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
                Vector256<float> rt = YShuffleX3Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4.AsSingle(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX3Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
                //return YShuffleX3Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
                Vector256<double> rt = YShuffleX3Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4.AsDouble(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX3Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
                return YShuffleX3Insert_Core(back.AsByte(), vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX3Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
                Vector256<byte> rt = YShuffleX3Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX3Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
                return YShuffleX3Insert_Core(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX3Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
                Vector256<ushort> rt = YShuffleX3Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX3Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
                return YShuffleX3Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX3Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
                Vector256<uint> rt = YShuffleX3Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX3Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
                return YShuffleX3Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX3Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
                Vector256<ulong> rt = YShuffleX3Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4, rt, back);
                return rt;
            }
*/

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX3Kernel(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> indices) {
                //return YShuffleX3Kernel(vector0.AsInt32(), vector1.AsInt32(), vector2.AsInt32(), indices).AsSingle();
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    return YShuffleX3Kernel_PermuteLonger(vector0, vector1, vector2, indices);
                } else if (Avx512F.VL.IsSupported) {
                    return YShuffleX3Kernel_Permute(vector0, vector1, vector2, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX3Kernel_Combine(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> indices) {
                Vector256<int> vCount = Vector256.Create((int)Vector256<float>.Count);
                Vector256<int> vzero = Vector256<int>.Zero;
                Vector256<int> indices1 = Avx2.Subtract(indices, vCount);
                Vector256<int> indices2 = Avx2.Subtract(indices1, vCount);
                Vector256<int> indices3 = Avx2.Subtract(indices2, vCount);
                Vector256<float> mask1 = Avx2.CompareGreaterThan(vzero, indices1.AsInt32()).AsSingle(); // 0>indices1[i] ==> indices1[i]<0 ==> indices[i]<Count.
                Vector256<float> rt0 = Avx2.PermuteVar8x32(vector0, indices);
                Vector256<float> rt1 = Avx2.PermuteVar8x32(vector1, indices1);
                Vector256<float> mask2 = Avx2.CompareGreaterThan(vzero, indices2.AsInt32()).AsSingle(); // 0>indices2[i] ==> indices2[i]<0 ==> indices[i]<Count*2.
                Vector256<float> rt2 = Avx2.PermuteVar8x32(vector2, indices2);
                rt0 = ConditionalSelect_Relaxed(mask1, rt0, rt1);
                Vector256<float> rt = ConditionalSelect_Relaxed(mask2, rt0, rt2);
                return rt;
            }

#if NET8_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX3Kernel_Permute(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> indices) {
                if (Avx512F.VL.IsSupported) {
                    Vector256<int> vCount2 = Vector256.Create((int)(Vector256<float>.Count * 2));
                    Vector256<int> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<float> mask = Avx2.CompareGreaterThan(vCount2.AsInt32(), indices.AsInt32()).AsSingle(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    Vector256<float> rt0 = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    Vector256<float> rt1 = Avx2.PermuteVar8x32(vector2, indices1);
                    Vector256<float> rt = ConditionalSelect(mask, rt0, rt1);
                    return rt;
                }
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX3Kernel_PermuteLonger(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> indices) {
                if (Avx512F.IsSupported) {
                    Vector512<float> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<float> u = vector2.ToVector512Unsafe();
                    return Avx512F.PermuteVar16x32x2(l, indices.ToVector512Unsafe(), u).GetLower();
                }
                return YShuffleX3Kernel_Permute(vector0, vector1, vector2, indices);
            }
#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX3Kernel(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> indices) {
                // return YShuffleX3Kernel(vector0.AsInt64(), vector1.AsInt64(), vector2.AsInt64(), indices).AsDouble();
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    return YShuffleX3Kernel_PermuteLonger(vector0, vector1, vector2, indices);
                } else if (Avx512F.VL.IsSupported) {
                    return YShuffleX3Kernel_Permute(vector0, vector1, vector2, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX3Kernel_Combine(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> indices) {
                Vector256<uint> temp = Avx.DuplicateEvenIndexed(indices.AsSingle()).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                Vector256<int> indices2 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset).AsInt32();
                return YShuffleX3Kernel_Combine(vector0.AsSingle(), vector1.AsSingle(), vector2.AsSingle(), indices2).AsDouble();
            }

#if NET8_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX3Kernel_Permute(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> indices) {
                if (Avx512F.VL.IsSupported) {
                    Vector256<long> vCount2 = Vector256.Create((long)(Vector256<long>.Count * 2));
                    Vector256<long> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<double> mask = Avx2.CompareGreaterThan(vCount2.AsInt64(), indices.AsInt64()).AsDouble(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    Vector256<double> rt0 = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    Vector256<double> rt1 = Avx512F.VL.PermuteVar4x64(vector2, indices1);
                    Vector256<double> rt = ConditionalSelect(mask, rt0, rt1);
                    return rt;
                }
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX3Kernel_PermuteLonger(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> indices) {
                if (Avx512F.IsSupported) {
                    Vector512<double> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<double> u = vector2.ToVector512Unsafe();
                    return Avx512F.PermuteVar8x64x2(l, indices.ToVector512Unsafe(), u).GetLower();
                }
                return YShuffleX3Kernel_Permute(vector0, vector1, vector2, indices);
            }
#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX3Kernel(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> indices) {
                return YShuffleX3Kernel(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX3Kernel(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> indices) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    return YShuffleX3Kernel_PermuteLonger(vector0, vector1, vector2, indices);
                } else if (Avx512F.VL.IsSupported) {
                    return YShuffleX3Kernel_Permute(vector0, vector1, vector2, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX3Kernel_Combine(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> indices) {
                return YShuffleX3Kernel_Combine(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX3Kernel_Combine(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> indices) {
                Vector256<byte> vCount2 = Vector256.Create((byte)(Vector256<byte>.Count * 2));
                Vector256<byte> indices1 = Avx2.Subtract(indices, vCount2);
                Vector256<byte> rt0 = YShuffleX2Kernel_Combine3(vector0, vector1, indices);
                Vector256<byte> mask = Avx2.CompareGreaterThan(vCount2.AsSByte(), indices.AsSByte()).AsByte(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector256<byte> rt1 = YShuffleKernel_ByteAdd2(vector2, indices1);
                Vector256<byte> rt = ConditionalSelect_Relaxed(mask, rt0, rt1);
                return rt;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX3Kernel_Permute(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> indices) {
                return YShuffleX3Kernel_Permute(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX3Kernel_Permute(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> indices) {
                if (Avx512Vbmi.VL.IsSupported) {
                    Vector256<byte> vCount2 = Vector256.Create((byte)(Vector256<byte>.Count * 2));
                    Vector256<byte> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<byte> mask = Avx2.CompareGreaterThan(vCount2.AsSByte(), indices.AsSByte()).AsByte(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    Vector256<byte> rt0 = Avx512Vbmi.VL.PermuteVar32x8x2(vector0, indices, vector1);
                    Vector256<byte> rt1 = Avx512Vbmi.VL.PermuteVar32x8(vector2, indices1);
                    Vector256<byte> rt = ConditionalSelect(mask, rt0, rt1);
                    return rt;
                }
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX3Kernel_PermuteLonger(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> indices) {
                return YShuffleX3Kernel_Permute(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX3Kernel_PermuteLonger(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> indices) {
                if (Avx512Vbmi.IsSupported) {
                    Vector512<byte> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<byte> u = vector2.ToVector512Unsafe();
                    return Avx512Vbmi.PermuteVar64x8x2(l, indices.ToVector512Unsafe(), u).GetLower();
                }
                return YShuffleX3Kernel_Permute(vector0, vector1, vector2, indices);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX3Kernel(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> indices) {
                return YShuffleX3Kernel(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX3Kernel(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> indices) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    return YShuffleX3Kernel_PermuteLonger(vector0, vector1, vector2, indices);
                } else if (Avx512F.VL.IsSupported) {
                    return YShuffleX3Kernel_Permute(vector0, vector1, vector2, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX3Kernel_Combine(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> indices) {
                return YShuffleX3Kernel_Combine(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX3Kernel_Combine(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> indices) {
                Vector256<byte> indices2 = Avx2.Add(Multiply(indices, Vector256Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector256Constants.Shuffle_UInt16_ByteOffset);
                return YShuffleX3Kernel_Combine(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices2).AsUInt16();
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX3Kernel_Permute(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> indices) {
                return YShuffleX3Kernel_Permute(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX3Kernel_Permute(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> indices) {
                if (Avx512BW.VL.IsSupported) {
                    Vector256<ushort> vCount2 = Vector256.Create((ushort)(Vector256<ushort>.Count * 2));
                    Vector256<ushort> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<ushort> mask = Avx2.CompareGreaterThan(vCount2.AsInt16(), indices.AsInt16()).AsUInt16(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    Vector256<ushort> rt0 = Avx512BW.VL.PermuteVar16x16x2(vector0, indices, vector1);
                    Vector256<ushort> rt1 = Avx512BW.VL.PermuteVar16x16(vector2, indices1);
                    Vector256<ushort> rt = ConditionalSelect(mask, rt0, rt1);
                    return rt;
                }
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX3Kernel_PermuteLonger(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> indices) {
                return YShuffleX3Kernel_PermuteLonger(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX3Kernel_PermuteLonger(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> indices) {
                if (Avx512BW.IsSupported) {
                    Vector512<ushort> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<ushort> u = vector2.ToVector512Unsafe();
                    return Avx512BW.PermuteVar32x16x2(l, indices.ToVector512Unsafe(), u).GetLower();
                }
                return YShuffleX3Kernel_Permute(vector0, vector1, vector2, indices);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX3Kernel(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> indices) {
                return YShuffleX3Kernel(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX3Kernel(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> indices) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    return YShuffleX3Kernel_PermuteLonger(vector0, vector1, vector2, indices);
                } else if (Avx512F.VL.IsSupported) {
                    return YShuffleX3Kernel_Permute(vector0, vector1, vector2, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX3Kernel_Combine(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> indices) {
                return YShuffleX3Kernel_Combine(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX3Kernel_Combine(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> indices) {
                Vector256<uint> vCount = Vector256.Create((uint)Vector256<uint>.Count);
                Vector256<int> vzero = Vector256<int>.Zero;
                Vector256<uint> indices1 = Avx2.Subtract(indices, vCount);
                Vector256<uint> indices2 = Avx2.Subtract(indices1, vCount);
                Vector256<uint> mask1 = Avx2.CompareGreaterThan(vzero, indices1.AsInt32()).AsUInt32(); // 0>indices1[i] ==> indices1[i]<0 ==> indices[i]<Count.
                Vector256<uint> rt0 = Avx2.PermuteVar8x32(vector0, indices);
                Vector256<uint> rt1 = Avx2.PermuteVar8x32(vector1, indices1);
                Vector256<uint> mask2 = Avx2.CompareGreaterThan(vzero, indices2.AsInt32()).AsUInt32(); // 0>indices2[i] ==> indices2[i]<0 ==> indices[i]<Count*2.
                Vector256<uint> rt2 = Avx2.PermuteVar8x32(vector2, indices2);
                rt0 = ConditionalSelect_Relaxed(mask1, rt0, rt1);
                Vector256<uint> rt = ConditionalSelect_Relaxed(mask2, rt0, rt2);
                return rt;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX3Kernel_Permute(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> indices) {
                return YShuffleX3Kernel_Permute(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX3Kernel_Permute(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> indices) {
                if (Avx512F.VL.IsSupported) {
                    Vector256<uint> vCount2 = Vector256.Create((uint)(Vector256<uint>.Count * 2));
                    Vector256<uint> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<uint> mask = Avx2.CompareGreaterThan(vCount2.AsInt32(), indices.AsInt32()).AsUInt32(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    Vector256<uint> rt0 = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    Vector256<uint> rt1 = Avx2.PermuteVar8x32(vector2, indices1);
                    Vector256<uint> rt = ConditionalSelect(mask, rt0, rt1);
                    return rt;
                }
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX3Kernel_PermuteLonger(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> indices) {
                return YShuffleX3Kernel_PermuteLonger(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX3Kernel_PermuteLonger(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> indices) {
                if (Avx512F.IsSupported) {
                    Vector512<uint> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<uint> u = vector2.ToVector512Unsafe();
                    return Avx512F.PermuteVar16x32x2(l, indices.ToVector512Unsafe(), u).GetLower();
                }
                return YShuffleX3Kernel_Permute(vector0, vector1, vector2, indices);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX3Kernel(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> indices) {
                return YShuffleX3Kernel(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX3Kernel(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> indices) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    return YShuffleX3Kernel_PermuteLonger(vector0, vector1, vector2, indices);
                } else if (Avx512F.VL.IsSupported) {
                    return YShuffleX3Kernel_Permute(vector0, vector1, vector2, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX3Kernel_Combine(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> indices) {
                return YShuffleX3Kernel_Combine(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX3Kernel_Combine(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> indices) {
                Vector256<uint> temp = Avx.DuplicateEvenIndexed(indices.AsSingle()).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                Vector256<uint> indices2 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset);
                return YShuffleX3Kernel_Combine(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices2).AsUInt64();
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX3Kernel_Permute(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> indices) {
                return YShuffleX3Kernel_Permute(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX3Kernel_Permute(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> indices) {
                if (Avx512F.VL.IsSupported) {
                    Vector256<ulong> vCount2 = Vector256.Create((ulong)(Vector256<ulong>.Count * 2));
                    Vector256<ulong> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<ulong> mask = Avx2.CompareGreaterThan(vCount2.AsInt64(), indices.AsInt64()).AsUInt64(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    Vector256<ulong> rt0 = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    Vector256<ulong> rt1 = Avx512F.VL.PermuteVar4x64(vector2, indices1);
                    Vector256<ulong> rt = ConditionalSelect(mask, rt0, rt1);
                    return rt;
                }
                return YShuffleX3Kernel_Combine(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX3Kernel_PermuteLonger(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> indices) {
                return YShuffleX3Kernel_PermuteLonger(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX3Kernel_PermuteLonger(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> indices) {
                if (Avx512F.IsSupported) {
                    Vector512<ulong> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<ulong> u = vector2.ToVector512Unsafe();
                    return Avx512F.PermuteVar8x64x2(l, indices.ToVector512Unsafe(), u).GetLower();
                }
                return YShuffleX3Kernel_Permute(vector0, vector1, vector2, indices);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3) {
                YShuffleX3Kernel_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512Vbmi.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    args2 = default;
                    args3 = default;
                    return;
                } else if (Avx512Vbmi.VL.IsSupported) {
                    Vector256<byte> vCount2 = Vector256.Create((byte)(Vector256<byte>.Count * 2));
                    Vector256<byte> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<byte> mask = Avx2.CompareGreaterThan(vCount2.AsSByte(), indices.AsSByte()).AsByte(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    args0 = indices;
                    args1 = indices1;
                    args2 = mask;
                    args3 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                YShuffleX3Kernel_Args_Combine(indices, out args0, out args1, out args2, out args3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args_Combine(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3) {
                Vector256<byte> vCount = Vector256.Create((byte)(Vector256<byte>.Count));
                Vector256<sbyte> vzero = Vector256<sbyte>.Zero;
                Vector256<byte> indices1 = Avx2.Subtract(indices, vCount);
                Vector256<byte> indices2 = Avx2.Subtract(indices1, vCount);
                Vector256<byte> mask0 = Avx2.CompareGreaterThan(vzero, indices1.AsSByte()).AsByte(); // 0>indices1[i] ==> indices1[i]<0 ==> indices[i]<Count.
                Vector256<byte> mask2 = Avx2.CompareGreaterThan(vzero, indices2.AsSByte()).AsByte(); // 0>indices2[i] ==> indices2[i]<0 ==> indices[i]<Count*2.
                Vector256<byte> mask1 = AndNot(mask2, mask0);
                args0 = ConditionalSelect_Relaxed(mask0, indices, Vector256Constants.Byte_VMinSByte);
                args1 = ConditionalSelect_Relaxed(mask1, indices1, Vector256Constants.Byte_VMinSByte);
                args2 = Avx2.Or(Avx2.Add(indices2, Vector256Constants.Shuffle_Byte_LaneAdd_K0), mask2);
                args3 = Avx2.Or(Avx2.Add(indices2, Vector256Constants.Shuffle_Byte_LaneAdd_K1), mask2);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3) {
                YShuffleX3Kernel_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512BW.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    args2 = default;
                    args3 = default;
                    return;
                } else if (Avx512BW.VL.IsSupported) {
                    Vector256<ushort> vCount2 = Vector256.Create((ushort)(Vector256<ushort>.Count * 2));
                    Vector256<ushort> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<ushort> mask = Avx2.CompareGreaterThan(vCount2.AsInt16(), indices.AsInt16()).AsUInt16(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    args0 = indices;
                    args1 = indices1;
                    args2 = mask;
                    args3 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<byte> indices2 = Avx2.Add(Multiply(indices, Vector256Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector256Constants.Shuffle_UInt16_ByteOffset);
                YShuffleX3Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt16();
                args1 = a1.AsUInt16();
                args2 = a2.AsUInt16();
                args3 = a3.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3) {
                YShuffleX3Kernel_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    args2 = default;
                    args3 = default;
                    return;
                } else if (Avx512F.VL.IsSupported) {
                    Vector256<uint> vCount2 = Vector256.Create((uint)(Vector256<uint>.Count * 2));
                    Vector256<uint> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<uint> mask = Avx2.CompareGreaterThan(vCount2.AsInt32(), indices.AsInt32()).AsUInt32(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    args0 = indices;
                    args1 = indices1;
                    args2 = mask;
                    args3 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<uint> vCount = Vector256.Create((uint)Vector256<uint>.Count);
                args0 = indices;
                args1 = Avx2.Subtract(indices, vCount);
                args2 = Avx2.Subtract(args1, vCount);
                args3 = Avx2.CompareGreaterThan(vCount.AsInt32(), args1.AsInt32()).AsUInt32(); // vCount[i]>args1[i] ==> args1[i]<vCount[i]  ==> indices[i]<Count*2.
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3) {
                YShuffleX3Kernel_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    args2 = default;
                    args3 = default;
                    return;
                } else if (Avx512F.VL.IsSupported) {
                    Vector256<ulong> vCount2 = Vector256.Create((ulong)(Vector256<ulong>.Count * 2));
                    Vector256<ulong> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<ulong> mask = Avx2.CompareGreaterThan(vCount2.AsInt64(), indices.AsInt64()).AsUInt64(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    args0 = indices;
                    args1 = indices1;
                    args2 = mask;
                    args3 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<uint> temp = Avx.DuplicateEvenIndexed(indices.AsSingle()).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                Vector256<uint> indices2 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset);
                YShuffleX3Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt64();
                args1 = a1.AsUInt64();
                args2 = a2.AsUInt64();
                args3 = a3.AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX3Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    Vector512<float> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<float> u = vector2.ToVector512Unsafe();
                    return Avx512F.PermuteVar16x32x2(l, args0.ToVector512Unsafe(), u).GetLower();
                } else if (Avx512F.VL.IsSupported) {
                    Vector256<float> rt0 = Avx512F.VL.PermuteVar8x32x2(vector0, args0, vector1);
                    Vector256<float> rt1 = Avx2.PermuteVar8x32(vector2, args1);
                    Vector256<float> rt = ConditionalSelect(args2.AsSingle(), rt0, rt1);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX3Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX3Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    Vector512<double> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<double> u = vector2.ToVector512Unsafe();
                    return Avx512F.PermuteVar8x64x2(l, args0.ToVector512Unsafe(), u).GetLower();
                } else if (Avx512F.VL.IsSupported) {
                    Vector256<double> rt0 = Avx512F.VL.PermuteVar4x64x2(vector0, args0, vector1);
                    Vector256<double> rt1 = Avx512F.VL.PermuteVar4x64(vector2, args1);
                    Vector256<double> rt = ConditionalSelect(args2.AsDouble(), rt0, rt1);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX3Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX3Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) {
                return YShuffleX3Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX3Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512Vbmi.IsSupported) {
                    Vector512<byte> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<byte> u = vector2.ToVector512Unsafe();
                    return Avx512Vbmi.PermuteVar64x8x2(l, args0.ToVector512Unsafe(), u).GetLower();
                } else if (Avx512Vbmi.VL.IsSupported) {
                    Vector256<byte> rt0 = Avx512Vbmi.VL.PermuteVar32x8x2(vector0, args0, vector1);
                    Vector256<byte> rt1 = Avx512Vbmi.VL.PermuteVar32x8(vector2, args1);
                    Vector256<byte> rt = ConditionalSelect(args2, rt0, rt1);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX3Kernel_Core_Combine(vector0, vector1, vector2, args0, args1, args2, args3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX3Kernel_Core_Combine(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) {
                Vector256<byte> vzero = Vector256<byte>.Zero;
                // Format: Code; //Latency, Throughput(references IceLake)
                // -- vector0, vector1.
                Vector256<byte> vector0B = Avx2.Permute4x64(vector0.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                Vector256<byte> vector1B = Avx2.Permute4x64(vector1.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                Vector256<byte> rt0A = Avx2.Shuffle(vector0, Avx2.Add(args0, Vector256Constants.Shuffle_Byte_LaneAdd_K0));  // (1,0.5)+(1,0.33) = (2,0.83)
                Vector256<byte> rt0B = Avx2.Shuffle(vector0B, Avx2.Add(args0, Vector256Constants.Shuffle_Byte_LaneAdd_K1)); // (1,0.5)+(1,0.33) = (2,0.83)
                Vector256<byte> rt1A = Avx2.Shuffle(vector1, Avx2.Add(args1, Vector256Constants.Shuffle_Byte_LaneAdd_K0));  // (1,0.5)+(1,0.33) = (2,0.83)
                Vector256<byte> rt1B = Avx2.Shuffle(vector1B, Avx2.Add(args1, Vector256Constants.Shuffle_Byte_LaneAdd_K1)); // (1,0.5)+(1,0.33) = (2,0.83)
                Vector256<byte> rt0 = Avx2.Or(rt0A, rt0B); // 1,0.33
                Vector256<byte> rt1 = Avx2.Or(rt1A, rt1B); // 1,0.33
                rt0 = Avx2.BlendVariable(rt0, vzero, args0); // 3,1
                rt1 = Avx2.BlendVariable(rt1, vzero, args1); // 3,1
                Vector256<byte> rt = Avx2.Or(rt0, rt1); // 1,0.33
                // -- vector2.
                vector0B = Avx2.Permute4x64(vector2.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                rt0A = Avx2.Shuffle(vector2, args2);  // 1,0.5
                rt0B = Avx2.Shuffle(vector0B, args3); // 1,0.5
                rt0 = Avx2.Or(rt0A, rt0B); // 1,0.33
                // done.
                rt = Avx2.Or(rt, rt0); // 1,0.33
                return rt; //total latency: 30, total throughput CPI: 11.
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX3Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) {
                return YShuffleX3Kernel_Core(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX3Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512BW.IsSupported) {
                    Vector512<ushort> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<ushort> u = vector2.ToVector512Unsafe();
                    return Avx512BW.PermuteVar32x16x2(l, args0.ToVector512Unsafe(), u).GetLower();
                } else if (Avx512BW.VL.IsSupported) {
                    Vector256<ushort> rt0 = Avx512BW.VL.PermuteVar16x16x2(vector0, args0, vector1);
                    Vector256<ushort> rt1 = Avx512BW.VL.PermuteVar16x16(vector2, args1);
                    Vector256<ushort> rt = ConditionalSelect(args2, rt0, rt1);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX3Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX3Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
                return YShuffleX3Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX3Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    Vector512<uint> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<uint> u = vector2.ToVector512Unsafe();
                    return Avx512F.PermuteVar16x32x2(l, args0.ToVector512Unsafe(), u).GetLower();
                } else if (Avx512F.VL.IsSupported) {
                    Vector256<uint> rt0 = Avx512F.VL.PermuteVar8x32x2(vector0, args0, vector1);
                    Vector256<uint> rt1 = Avx2.PermuteVar8x32(vector2, args1);
                    Vector256<uint> rt = ConditionalSelect(args2, rt0, rt1);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX3Kernel_Core_Combine(vector0, vector1, vector2, args0, args1, args2, args3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX3Kernel_Core_Combine(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) {
                Vector256<int> vzero = Vector256<int>.Zero;
                Vector256<uint> mask1 = Avx2.CompareGreaterThan(vzero, args1.AsInt32()).AsUInt32(); // 0>indices1[i] ==> indices1[i]<0 ==> indices[i]<Count.
                Vector256<uint> rt0 = Avx2.PermuteVar8x32(vector0, args0);
                Vector256<uint> rt1 = Avx2.PermuteVar8x32(vector1, args1);
                Vector256<uint> rt2 = Avx2.PermuteVar8x32(vector2, args2);
                rt0 = ConditionalSelect_Relaxed(mask1, rt0, rt1);
                Vector256<uint> mask2 = args3; // // 0>indices2[i] ==> indices2[i]<0 ==> indices[i]<Count*2.
                Vector256<uint> rt = ConditionalSelect_Relaxed(mask2, rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX3Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
                return YShuffleX3Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX3Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX3Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    Vector512<ulong> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<ulong> u = vector2.ToVector512Unsafe();
                    return Avx512F.PermuteVar8x64x2(l, args0.ToVector512Unsafe(), u).GetLower();
                } else if (Avx512F.VL.IsSupported) {
                    Vector256<ulong> rt0 = Avx512F.VL.PermuteVar4x64x2(vector0, args0, vector1);
                    Vector256<ulong> rt1 = Avx512F.VL.PermuteVar4x64(vector2, args1);
                    Vector256<ulong> rt = ConditionalSelect(args2, rt0, rt1);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX3Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsUInt64();
            }

/*
            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4_AcceleratedTypes {
                get {
                    return YShuffleX4Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX4(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
                return YShuffleX4(vector0.AsInt32(), vector1.AsInt32(), indices).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX4(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
                return YShuffleX4(vector0.AsInt64(), vector1.AsInt64(), indices).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX4(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
                return YShuffleX4(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX4(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
                Vector256<byte> mask, raw, rt;
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                        mask = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)64), indices);
                    } else {
                        mask = Avx2.CompareGreaterThan(
                            Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                            Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                        ).AsByte(); // Unsigned compare: (i < 64)
                    }
                    raw = Avx512Vbmi.VL.PermuteVar32x8x2(vector0, indices, vector1);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                mask = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                    Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < 64)
                raw = YShuffleX4Kernel(vector0, vector1, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX4(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
                return YShuffleX4(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX4(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
                Vector256<ushort> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 5), Vector256<ushort>.Zero); // Unsigned compare: (i < 32)
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    raw = Avx512BW.VL.PermuteVar16x16x2(vector0, indices, vector1);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX4Kernel(vector0, vector1, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX4(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
                return YShuffleX4(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX4(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
                Vector256<uint> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<uint>.Zero); // Unsigned compare: (i < 16)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX4Kernel(vector0, vector1, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX4(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
                return YShuffleX4(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX4(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
                Vector256<ulong> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<ulong>.Zero); // Unsigned compare: (i < 8)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    rt = Avx2.And(raw, mask);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX4Kernel(vector0, vector1, indices);
                rt = Avx2.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
                YShuffleX4_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
                args4 = a4.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                        args4 = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)64), indices);
                    } else {
                        args4 = Avx2.CompareGreaterThan(
                            Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                            Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                        ).AsByte(); // Unsigned compare: (i < 64)
                    }
                    return;
                }
#endif // NET8_0_OR_GREATER
                args4 = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                    Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < 64)
                Vector256<byte> mask = OnesComplement(args4); // Used for _mm256_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = Avx2.Or(args0, mask);
                args1 = Avx2.Or(args1, mask);
                args2 = Avx2.Or(args2, mask);
                args3 = Avx2.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
                YShuffleX4_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
                args4 = a4.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 5), Vector256<ushort>.Zero); // Unsigned compare: (i < 32)
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<ushort> mask = OnesComplement(args4); // Used for _mm256_shuffle_epi8. Change mask to `0 is keep; AllBitsSet is set zero`.
                args0 = Avx2.Or(args0, mask);
                args1 = Avx2.Or(args1, mask);
                args2 = Avx2.Or(args2, mask);
                args3 = Avx2.Or(args3, mask);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
                YShuffleX4_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
                args4 = a4.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<uint>.Zero); // Unsigned compare: (i < 16)
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
                YShuffleX4_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
                args4 = a4.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<ulong>.Zero); // Unsigned compare: (i < 8)
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX4_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
                return YShuffleX4_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX4_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
                return YShuffleX4_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX4_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
                return YShuffleX4_Core(vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX4_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
                Vector256<byte> rt = YShuffleX4Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    rt = Avx2.And(rt, args4);
                }
#endif // NET8_0_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX4_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
                return YShuffleX4_Core(vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX4_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
                Vector256<ushort> rt = YShuffleX4Kernel_Core(vector0, vector1, args0, args1, args2, args3);
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    rt = Avx2.And(rt, args4);
                }
#endif // NET8_0_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX4_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
                return YShuffleX4_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX4_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
                Vector256<uint> rt = YShuffleX4Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx2.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX4_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
                return YShuffleX4_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX4_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
                Vector256<ulong> rt = YShuffleX4Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx2.And(rt, args4);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Insert_AcceleratedTypes {
                get {
                    return YShuffleX4Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX4Insert(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<int> indices) {
                return YShuffleX4Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX4Insert(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<long> indices) {
                return YShuffleX4Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX4Insert(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> indices) {
                return YShuffleX4Insert(back.AsByte(), vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX4Insert(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> indices) {
                Vector256<byte> mask, raw, rt;
#if NET8_0_OR_GREATER
                if (Avx512Vbmi.VL.IsSupported) {
                    if (Avx512_Compare_Used && Avx512BW.VL.IsSupported) {
                        mask = Avx512BW.VL.CompareGreaterThan(Vector256.Create((byte)64), indices);
                    } else {
                        mask = Avx2.CompareGreaterThan(
                            Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                            Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                        ).AsByte(); // Unsigned compare: (i < 64)
                    }
                    raw = Avx512Vbmi.VL.PermuteVar32x8x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                mask = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(64 + sbyte.MinValue)),
                    Avx2.Add(indices.AsSByte(), Vector256.Create(sbyte.MinValue))
                ).AsByte(); // Unsigned compare: (i < 64)
                raw = YShuffleX4Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX4Insert(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> indices) {
                return YShuffleX4Insert(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX4Insert(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> indices) {
                Vector256<ushort> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 5), Vector256<ushort>.Zero); // Unsigned compare: (i < 32)
#if NET8_0_OR_GREATER
                if (Avx512BW.VL.IsSupported) {
                    raw = Avx512BW.VL.PermuteVar16x16x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX4Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX4Insert(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> indices) {
                return YShuffleX4Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX4Insert(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> indices) {
                Vector256<uint> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 4), Vector256<uint>.Zero); // Unsigned compare: (i < 16)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX4Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX4Insert(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> indices) {
                return YShuffleX4Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX4Insert(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> indices) {
                Vector256<ulong> mask, raw, rt;
                mask = Avx2.CompareEqual(Avx2.ShiftRightLogical(indices, 3), Vector256<ulong>.Zero); // Unsigned compare: (i < 8)
#if NET8_0_OR_GREATER
                if (Avx512F.VL.IsSupported) {
                    raw = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    rt = ConditionalSelect_Relaxed(mask, raw, back);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                raw = YShuffleX4Kernel(vector0, vector1, indices);
                rt = ConditionalSelect_Relaxed(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3, out Vector256<sbyte> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3, out Vector256<byte> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3, out Vector256<short> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3, out Vector256<ushort> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3, out Vector256<int> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3, out Vector256<uint> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3, out Vector256<long> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3, out Vector256<ulong> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX4Insert_Core(Vector256<float> back, Vector256<float> vector0, Vector256<float> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
                return YShuffleX4Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX4Insert_Core(Vector256<double> back, Vector256<double> vector0, Vector256<double> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
                return YShuffleX4Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX4Insert_Core(Vector256<sbyte> back, Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3, Vector256<sbyte> args4) {
                return YShuffleX4Insert_Core(back.AsByte(), vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX4Insert_Core(Vector256<byte> back, Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3, Vector256<byte> args4) {
                Vector256<byte> rt = YShuffleX4Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX4Insert_Core(Vector256<short> back, Vector256<short> vector0, Vector256<short> vector1, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3, Vector256<short> args4) {
                return YShuffleX4Insert_Core(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX4Insert_Core(Vector256<ushort> back, Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3, Vector256<ushort> args4) {
                Vector256<ushort> rt = YShuffleX4Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX4Insert_Core(Vector256<int> back, Vector256<int> vector0, Vector256<int> vector1, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3, Vector256<int> args4) {
                return YShuffleX4Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX4Insert_Core(Vector256<uint> back, Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3, Vector256<uint> args4) {
                Vector256<uint> rt = YShuffleX4Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX4Insert_Core(Vector256<long> back, Vector256<long> vector0, Vector256<long> vector1, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3, Vector256<long> args4) {
                return YShuffleX4Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Insert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX4Insert_Core(Vector256<ulong> back, Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3, Vector256<ulong> args4) {
                Vector256<ulong> rt = YShuffleX4Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect_Relaxed(args4, rt, back);
                return rt;
            }
*/

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX4Kernel(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> indices) {
                //return YShuffleX4Kernel(vector0.AsInt32(), vector1.AsInt32(), vector2.AsInt32(), vector3.AsInt32(), indices).AsSingle();
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    return YShuffleX4Kernel_PermuteLonger(vector0, vector1, vector2, vector3, indices);
                } else if (Avx512F.VL.IsSupported) {
                    return YShuffleX4Kernel_Permute(vector0, vector1, vector2, vector3, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX4Kernel_Combine(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> indices) {
                Vector256<int> vCount = Vector256.Create((int)Vector256<float>.Count);
                Vector256<int> vzero = Vector256<int>.Zero;
                Vector256<int> indices1 = Avx2.Subtract(indices, vCount);
                Vector256<int> indices2 = Avx2.Subtract(indices1, vCount);
                Vector256<int> indices3 = Avx2.Subtract(indices2, vCount);
                Vector256<float> mask1 = Avx2.CompareGreaterThan(vzero, indices1.AsInt32()).AsSingle(); // 0>indices1[i] ==> indices1[i]<0 ==> indices[i]<Count.
                Vector256<float> rt0 = Avx2.PermuteVar8x32(vector0, indices);
                Vector256<float> rt1 = Avx2.PermuteVar8x32(vector1, indices1);
                Vector256<float> mask3 = Avx2.CompareGreaterThan(vzero, indices3.AsInt32()).AsSingle(); // 0>indices3[i] ==> indices3[i]<0 ==> indices[i]<Count*3.
                Vector256<float> rt2 = Avx2.PermuteVar8x32(vector2, indices2);
                Vector256<float> rt3 = Avx2.PermuteVar8x32(vector3, indices3);
                Vector256<float> mask2 = Avx2.CompareGreaterThan(vzero, indices2.AsInt32()).AsSingle(); // 0>indices2[i] ==> indices2[i]<0 ==> indices[i]<Count*2.
                rt0 = ConditionalSelect_Relaxed(mask1, rt0, rt1);
                rt2 = ConditionalSelect_Relaxed(mask3, rt2, rt3);
                Vector256<float> rt = ConditionalSelect_Relaxed(mask2, rt0, rt2);
                return rt;
            }

#if NET8_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX4Kernel_Permute(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> indices) {
                if (Avx512F.VL.IsSupported) {
                    Vector256<int> vCount2 = Vector256.Create((int)(Vector256<float>.Count * 2));
                    Vector256<int> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<float> mask = Avx2.CompareGreaterThan(vCount2.AsInt32(), indices.AsInt32()).AsSingle(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    Vector256<float> rt0 = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    Vector256<float> rt1 = Avx512F.VL.PermuteVar8x32x2(vector2, indices1, vector3);
                    Vector256<float> rt = ConditionalSelect(mask, rt0, rt1);
                    return rt;
                }
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX4Kernel_PermuteLonger(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> indices) {
                if (Avx512F.IsSupported) {
                    Vector512<float> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<float> u = vector2.ToVector512Unsafe().WithUpper(vector3);
                    return Avx512F.PermuteVar16x32x2(l, indices.ToVector512Unsafe(), u).GetLower();
                }
                return YShuffleX4Kernel_Permute(vector0, vector1, vector2, vector3, indices);
            }
#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX4Kernel(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> indices) {
                //return YShuffleX4Kernel(vector0.AsInt64(), vector1.AsInt64(), vector2.AsInt64(), vector3.AsInt64(), indices).AsDouble();
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    return YShuffleX4Kernel_PermuteLonger(vector0, vector1, vector2, vector3, indices);
                } else if (Avx512F.VL.IsSupported) {
                    return YShuffleX4Kernel_Permute(vector0, vector1, vector2, vector3, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX4Kernel_Combine(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> indices) {
                Vector256<uint> temp = Avx.DuplicateEvenIndexed(indices.AsSingle()).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                Vector256<int> indices2 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset).AsInt32();
                return YShuffleX4Kernel_Combine(vector0.AsSingle(), vector1.AsSingle(), vector2.AsSingle(), vector3.AsSingle(), indices2).AsDouble();
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX4Kernel_Permute(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> indices) {
                if (Avx512F.VL.IsSupported) {
                    Vector256<long> vCount2 = Vector256.Create((long)(Vector256<long>.Count * 2));
                    Vector256<long> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<double> mask = Avx2.CompareGreaterThan(vCount2.AsInt64(), indices.AsInt64()).AsDouble(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    Vector256<double> rt0 = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    Vector256<double> rt1 = Avx512F.VL.PermuteVar4x64x2(vector2, indices1, vector3);
                    Vector256<double> rt = ConditionalSelect(mask, rt0, rt1);
                    return rt;
                }
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX4Kernel_PermuteLonger(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> indices) {
                if (Avx512F.IsSupported) {
                    Vector512<double> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<double> u = vector2.ToVector512Unsafe().WithUpper(vector3);
                    return Avx512F.PermuteVar8x64x2(l, indices.ToVector512Unsafe(), u).GetLower();
                }
                return YShuffleX4Kernel_Permute(vector0, vector1, vector2, vector3, indices);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX4Kernel(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> indices) {
                return YShuffleX4Kernel(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX4Kernel(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> indices) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512Vbmi.IsSupported) {
                    return YShuffleX4Kernel_PermuteLonger(vector0, vector1, vector2, vector3, indices);
                } else if (Avx512Vbmi.VL.IsSupported) {
                    return YShuffleX4Kernel_Permute(vector0, vector1, vector2, vector3, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX4Kernel_Combine(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> indices) {
                return YShuffleX4Kernel_Combine(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX4Kernel_Combine(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> indices) {
                Vector256<byte> vCount2 = Vector256.Create((byte)(Vector256<byte>.Count * 2));
                Vector256<byte> indices1 = Avx2.Subtract(indices, vCount2);
                Vector256<byte> rt0 = YShuffleX2Kernel_Combine3(vector0, vector1, indices);
                Vector256<byte> mask = Avx2.CompareGreaterThan(vCount2.AsSByte(), indices.AsSByte()).AsByte(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector256<byte> rt1 = YShuffleX2Kernel_Combine3(vector2, vector3, indices1);
                Vector256<byte> rt = ConditionalSelect_Relaxed(mask, rt0, rt1);
                return rt;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX4Kernel_Permute(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> indices) {
                return YShuffleX4Kernel_Permute(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX4Kernel_Permute(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> indices) {
                if (Avx512Vbmi.VL.IsSupported) {
                    Vector256<byte> vCount2 = Vector256.Create((byte)(Vector256<byte>.Count * 2));
                    Vector256<byte> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<byte> mask = Avx2.CompareGreaterThan(vCount2.AsSByte(), indices.AsSByte()).AsByte(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    Vector256<byte> rt0 = Avx512Vbmi.VL.PermuteVar32x8x2(vector0, indices, vector1);
                    Vector256<byte> rt1 = Avx512Vbmi.VL.PermuteVar32x8x2(vector2, indices1, vector3);
                    Vector256<byte> rt = ConditionalSelect(mask, rt0, rt1);
                    return rt;
                }
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX4Kernel_PermuteLonger(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> indices) {
                return YShuffleX4Kernel_PermuteLonger(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX4Kernel_PermuteLonger(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> indices) {
                if (Avx512Vbmi.IsSupported) {
                    Vector512<byte> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<byte> u = vector2.ToVector512Unsafe().WithUpper(vector3);
                    return Avx512Vbmi.PermuteVar64x8x2(l, indices.ToVector512Unsafe(), u).GetLower();
                }
                return YShuffleX4Kernel_Permute(vector0, vector1, vector2, vector3, indices);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX4Kernel(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> indices) {
                return YShuffleX4Kernel(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX4Kernel(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> indices) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512BW.IsSupported) {
                    return YShuffleX4Kernel_PermuteLonger(vector0, vector1, vector2, vector3, indices);
                } else if (Avx512BW.VL.IsSupported) {
                    return YShuffleX4Kernel_Permute(vector0, vector1, vector2, vector3, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX4Kernel_Combine(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> indices) {
                return YShuffleX4Kernel_Combine(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX4Kernel_Combine(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> indices) {
                Vector256<byte> indices2 = Avx2.Add(Multiply(indices, Vector256Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector256Constants.Shuffle_UInt16_ByteOffset);
                return YShuffleX4Kernel_Combine(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices2).AsUInt16();
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX4Kernel_Permute(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> indices) {
                return YShuffleX4Kernel_Permute(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX4Kernel_Permute(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> indices) {
                if (Avx512BW.VL.IsSupported) {
                    Vector256<ushort> vCount2 = Vector256.Create((ushort)(Vector256<ushort>.Count * 2));
                    Vector256<ushort> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<ushort> mask = Avx2.CompareGreaterThan(vCount2.AsInt16(), indices.AsInt16()).AsUInt16(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    Vector256<ushort> rt0 = Avx512BW.VL.PermuteVar16x16x2(vector0, indices, vector1);
                    Vector256<ushort> rt1 = Avx512BW.VL.PermuteVar16x16x2(vector2, indices1, vector3);
                    Vector256<ushort> rt = ConditionalSelect(mask, rt0, rt1);
                    return rt;
                }
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX4Kernel_PermuteLonger(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> indices) {
                return YShuffleX4Kernel_PermuteLonger(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX4Kernel_PermuteLonger(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> indices) {
                if (Avx512BW.IsSupported) {
                    Vector512<ushort> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<ushort> u = vector2.ToVector512Unsafe().WithUpper(vector3);
                    return Avx512BW.PermuteVar32x16x2(l, indices.ToVector512Unsafe(), u).GetLower();
                }
                return YShuffleX4Kernel_Permute(vector0, vector1, vector2, vector3, indices);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX4Kernel(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> indices) {
                return YShuffleX4Kernel(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX4Kernel(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> indices) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    return YShuffleX4Kernel_PermuteLonger(vector0, vector1, vector2, vector3, indices);
                } else if (Avx512F.VL.IsSupported) {
                    return YShuffleX4Kernel_Permute(vector0, vector1, vector2, vector3, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX4Kernel_Combine(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> indices) {
                return YShuffleX4Kernel_Combine(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX4Kernel_Combine(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> indices) {
                Vector256<uint> vCount = Vector256.Create((uint)Vector256<uint>.Count);
                Vector256<int> vzero = Vector256<int>.Zero;
                Vector256<uint> indices1 = Avx2.Subtract(indices, vCount);
                Vector256<uint> indices2 = Avx2.Subtract(indices1, vCount);
                Vector256<uint> indices3 = Avx2.Subtract(indices2, vCount);
                Vector256<uint> mask1 = Avx2.CompareGreaterThan(vzero, indices1.AsInt32()).AsUInt32(); // 0>indices1[i] ==> indices1[i]<0 ==> indices[i]<Count.
                Vector256<uint> rt0 = Avx2.PermuteVar8x32(vector0, indices);
                Vector256<uint> rt1 = Avx2.PermuteVar8x32(vector1, indices1);
                Vector256<uint> mask3 = Avx2.CompareGreaterThan(vzero, indices3.AsInt32()).AsUInt32(); // 0>indices3[i] ==> indices3[i]<0 ==> indices[i]<Count*3.
                Vector256<uint> rt2 = Avx2.PermuteVar8x32(vector2, indices2);
                Vector256<uint> rt3 = Avx2.PermuteVar8x32(vector3, indices3);
                Vector256<uint> mask2 = Avx2.CompareGreaterThan(vzero, indices2.AsInt32()).AsUInt32(); // 0>indices2[i] ==> indices2[i]<0 ==> indices[i]<Count*2.
                rt0 = ConditionalSelect_Relaxed(mask1, rt0, rt1);
                rt2 = ConditionalSelect_Relaxed(mask3, rt2, rt3);
                Vector256<uint> rt = ConditionalSelect_Relaxed(mask2, rt0, rt2);
                return rt;
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX4Kernel_Permute(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> indices) {
                return YShuffleX4Kernel_Permute(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX4Kernel_Permute(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> indices) {
                if (Avx512F.VL.IsSupported) {
                    Vector256<uint> vCount2 = Vector256.Create((uint)(Vector256<uint>.Count * 2));
                    Vector256<uint> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<uint> mask = Avx2.CompareGreaterThan(vCount2.AsInt32(), indices.AsInt32()).AsUInt32(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    Vector256<uint> rt0 = Avx512F.VL.PermuteVar8x32x2(vector0, indices, vector1);
                    Vector256<uint> rt1 = Avx512F.VL.PermuteVar8x32x2(vector2, indices1, vector3);
                    Vector256<uint> rt = ConditionalSelect(mask, rt0, rt1);
                    return rt;
                }
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX4Kernel_PermuteLonger(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> indices) {
                return YShuffleX4Kernel_PermuteLonger(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX4Kernel_PermuteLonger(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> indices) {
                if (Avx512F.IsSupported) {
                    Vector512<uint> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<uint> u = vector2.ToVector512Unsafe().WithUpper(vector3);
                    return Avx512F.PermuteVar16x32x2(l, indices.ToVector512Unsafe(), u).GetLower();
                }
                return YShuffleX4Kernel_Permute(vector0, vector1, vector2, vector3, indices);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX4Kernel(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> indices) {
                return YShuffleX4Kernel(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX4Kernel(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> indices) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    return YShuffleX4Kernel_PermuteLonger(vector0, vector1, vector2, vector3, indices);
                } else if (Avx512F.VL.IsSupported) {
                    return YShuffleX4Kernel_Permute(vector0, vector1, vector2, vector3, indices);
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX4Kernel_Combine(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> indices) {
                return YShuffleX4Kernel_Combine(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX4Kernel_Combine(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> indices) {
                Vector256<uint> temp = Avx.DuplicateEvenIndexed(indices.AsSingle()).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                Vector256<uint> indices2 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset);
                return YShuffleX4Kernel_Combine(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices2).AsUInt64();
            }

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX4Kernel_Permute(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> indices) {
                return YShuffleX4Kernel_Permute(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX4Kernel_Permute(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> indices) {
                if (Avx512F.VL.IsSupported) {
                    Vector256<ulong> vCount2 = Vector256.Create((ulong)(Vector256<ulong>.Count * 2));
                    Vector256<ulong> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<ulong> mask = Avx2.CompareGreaterThan(vCount2.AsInt64(), indices.AsInt64()).AsUInt64(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    Vector256<ulong> rt0 = Avx512F.VL.PermuteVar4x64x2(vector0, indices, vector1);
                    Vector256<ulong> rt1 = Avx512F.VL.PermuteVar4x64x2(vector2, indices1, vector3);
                    Vector256<ulong> rt = ConditionalSelect(mask, rt0, rt1);
                    return rt;
                }
                return YShuffleX4Kernel_Combine(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX4Kernel_PermuteLonger(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> indices) {
                return YShuffleX4Kernel_PermuteLonger(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX4Kernel_PermuteLonger(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> indices) {
                if (Avx512F.IsSupported) {
                    Vector512<ulong> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<ulong> u = vector2.ToVector512Unsafe().WithUpper(vector3);
                    return Avx512F.PermuteVar8x64x2(l, indices.ToVector512Unsafe(), u).GetLower();
                }
                return YShuffleX4Kernel_Permute(vector0, vector1, vector2, vector3, indices);
            }

#endif // NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2, out Vector256<sbyte> args3) {
                YShuffleX4Kernel_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512Vbmi.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    args2 = default;
                    args3 = default;
                    return;
                } else if (Avx512Vbmi.VL.IsSupported) {
                    Vector256<byte> vCount2 = Vector256.Create((byte)(Vector256<byte>.Count * 2));
                    Vector256<byte> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<byte> mask = Avx2.CompareGreaterThan(vCount2.AsSByte(), indices.AsSByte()).AsByte(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    args0 = indices;
                    args1 = indices1;
                    args2 = mask;
                    args3 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                YShuffleX4Kernel_Args_Combine2(indices, out args0, out args1, out args2, out args3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args_Combine1(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3) {
                Vector256<byte> vCount2 = Vector256.Create((byte)(Vector256<byte>.Count * 2));
                Vector256<byte> indices1 = Avx2.Subtract(indices, vCount2);
                Vector256<byte> mask = Avx2.CompareGreaterThan(vCount2.AsSByte(), indices.AsSByte()).AsByte(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                args0 = indices;
                args1 = indices1;
                args2 = mask;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args_Combine2(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2, out Vector256<byte> args3) {
                Vector256<byte> vCount = Vector256.Create((byte)(Vector256<byte>.Count));
                Vector256<sbyte> vzero = Vector256<sbyte>.Zero;
                Vector256<byte> indices1 = Avx2.Subtract(indices, vCount);
                Vector256<byte> indices2 = Avx2.Subtract(indices1, vCount);
                Vector256<byte> indices3 = Avx2.Subtract(indices2, vCount);
                Vector256<byte> mask0 = Avx2.CompareGreaterThan(vzero, indices1.AsSByte()).AsByte(); // 0>indices1[i] ==> indices1[i]<0 ==> indices[i]<Count.
                Vector256<byte> mask1 = Avx2.CompareGreaterThan(vzero, indices2.AsSByte()).AsByte(); // 0>indices2[i] ==> indices2[i]<0 ==> indices[i]<Count*2.
                Vector256<byte> mask2 = Avx2.CompareGreaterThan(vzero, indices3.AsSByte()).AsByte(); // 0>indices3[i] ==> indices3[i]<0 ==> indices[i]<Count*3.
                Vector256<byte> mask3 = OnesComplement(mask2); // indices[i]>=Count*3.
                mask2 = AndNot(mask2, mask1);
                mask1 = AndNot(mask1, mask0);
                args0 = ConditionalSelect_Relaxed(mask0, indices, Vector256Constants.Byte_VMinSByte);
                args1 = ConditionalSelect_Relaxed(mask1, indices1, Vector256Constants.Byte_VMinSByte);
                args2 = ConditionalSelect_Relaxed(mask2, indices2, Vector256Constants.Byte_VMinSByte);
                args3 = ConditionalSelect_Relaxed(mask3, indices3, Vector256Constants.Byte_VMinSByte);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2, out Vector256<short> args3) {
                YShuffleX4Kernel_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2, out Vector256<ushort> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512BW.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    args2 = default;
                    args3 = default;
                    return;
                } else if (Avx512BW.VL.IsSupported) {
                    Vector256<ushort> vCount2 = Vector256.Create((ushort)(Vector256<ushort>.Count * 2));
                    Vector256<ushort> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<ushort> mask = Avx2.CompareGreaterThan(vCount2.AsInt16(), indices.AsInt16()).AsUInt16(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    args0 = indices;
                    args1 = indices1;
                    args2 = mask;
                    args3 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<byte> indices2 = Avx2.Add(Multiply(indices, Vector256Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector256Constants.Shuffle_UInt16_ByteOffset);
                YShuffleX4Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt16();
                args1 = a1.AsUInt16();
                args2 = a2.AsUInt16();
                args3 = a3.AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2, out Vector256<int> args3) {
                YShuffleX4Kernel_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2, out Vector256<uint> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    args2 = default;
                    args3 = default;
                    return;
                } else if (Avx512F.VL.IsSupported) {
                    Vector256<uint> vCount2 = Vector256.Create((uint)(Vector256<uint>.Count * 2));
                    Vector256<uint> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<uint> mask = Avx2.CompareGreaterThan(vCount2.AsInt32(), indices.AsInt32()).AsUInt32(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    args0 = indices;
                    args1 = indices1;
                    args2 = mask;
                    args3 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<uint> vCount = Vector256.Create((uint)Vector256<uint>.Count);
                args0 = indices;
                args1 = Avx2.Subtract(indices, vCount);
                args2 = Avx2.Subtract(args1, vCount);
                args3 = Avx2.Subtract(args2, vCount);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2, out Vector256<long> args3) {
                YShuffleX4Kernel_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2, out Vector256<ulong> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    args0 = indices;
                    args1 = default;
                    args2 = default;
                    args3 = default;
                    return;
                } else if (Avx512F.VL.IsSupported) {
                    Vector256<ulong> vCount2 = Vector256.Create((ulong)(Vector256<ulong>.Count * 2));
                    Vector256<ulong> indices1 = Avx2.Subtract(indices, vCount2);
                    Vector256<ulong> mask = Avx2.CompareGreaterThan(vCount2.AsInt64(), indices.AsInt64()).AsUInt64(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                    args0 = indices;
                    args1 = indices1;
                    args2 = mask;
                    args3 = default;
                    return;
                }
#endif // NET8_0_OR_GREATER
                Vector256<uint> temp = Avx.DuplicateEvenIndexed(indices.AsSingle()).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                Vector256<uint> indices2 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset);
                YShuffleX4Kernel_Args(indices2, out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsUInt64();
                args1 = a1.AsUInt64();
                args2 = a2.AsUInt64();
                args3 = a3.AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{float}, Vector256{float}, Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleX4Kernel_Core(Vector256<float> vector0, Vector256<float> vector1, Vector256<float> vector2, Vector256<float> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    Vector512<float> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<float> u = vector2.ToVector512Unsafe().WithUpper(vector3);
                    return Avx512F.PermuteVar16x32x2(l, args0.ToVector512Unsafe(), u).GetLower();
                } else if (Avx512F.VL.IsSupported) {
                    Vector256<float> rt0 = Avx512F.VL.PermuteVar8x32x2(vector0, args0, vector1);
                    Vector256<float> rt1 = Avx512F.VL.PermuteVar8x32x2(vector2, args1, vector3);
                    Vector256<float> rt = ConditionalSelect(args2.AsSingle(), rt0, rt1);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX4Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{double}, Vector256{double}, Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleX4Kernel_Core(Vector256<double> vector0, Vector256<double> vector1, Vector256<double> vector2, Vector256<double> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    Vector512<double> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<double> u = vector2.ToVector512Unsafe().WithUpper(vector3);
                    return Avx512F.PermuteVar8x64x2(l, args0.ToVector512Unsafe(), u).GetLower();
                } else if (Avx512F.VL.IsSupported) {
                    Vector256<double> rt0 = Avx512F.VL.PermuteVar4x64x2(vector0, args0, vector1);
                    Vector256<double> rt1 = Avx512F.VL.PermuteVar4x64x2(vector2, args1, vector3);
                    Vector256<double> rt = ConditionalSelect(args2.AsDouble(), rt0, rt1);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX4Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YShuffleX4Kernel_Core(Vector256<sbyte> vector0, Vector256<sbyte> vector1, Vector256<sbyte> vector2, Vector256<sbyte> vector3, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2, Vector256<sbyte> args3) {
                return YShuffleX4Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX4Kernel_Core(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512Vbmi.IsSupported) {
                    Vector512<byte> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<byte> u = vector2.ToVector512Unsafe().WithUpper(vector3);
                    return Avx512Vbmi.PermuteVar64x8x2(l, args0.ToVector512Unsafe(), u).GetLower();
                } else if (Avx512Vbmi.VL.IsSupported) {
                    Vector256<byte> rt0 = Avx512Vbmi.VL.PermuteVar32x8x2(vector0, args0, vector1);
                    Vector256<byte> rt1 = Avx512Vbmi.VL.PermuteVar32x8x2(vector2, args1, vector3);
                    Vector256<byte> rt = ConditionalSelect(args2, rt0, rt1);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX4Kernel_Core_Combine2B(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX4Kernel_Core_Combine1(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) {
                Vector256<byte> rt0 = YShuffleX2Kernel_Combine3(vector0, vector1, args0);
                Vector256<byte> rt1 = YShuffleX2Kernel_Combine3(vector2, vector3, args1);
                Vector256<byte> rt = ConditionalSelect_Relaxed(args2, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX4Kernel_Core_Combine2(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) {
                Vector256<sbyte> vzero = Vector256<sbyte>.Zero;
                // Format: Code; //Latency, Throughput(references IceLake)
                // -- vector0, vector1.
                Vector256<byte> vector0B = Avx2.Permute4x64(vector0.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                Vector256<byte> vector1B = Avx2.Permute4x64(vector1.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                Vector256<byte> flag0 = Avx2.CompareGreaterThan(vzero, args0.AsSByte()).AsByte(); // 1,0.33
                Vector256<byte> flag1 = Avx2.CompareGreaterThan(vzero, args1.AsSByte()).AsByte(); // 1,0.33
                Vector256<byte> rt0A = Avx2.Shuffle(vector0, Avx2.Add(args0, Vector256Constants.Shuffle_Byte_LaneAdd_K0));  // (1,0.5)+(1,0.33) = (2,0.83)
                Vector256<byte> rt0B = Avx2.Shuffle(vector0B, Avx2.Add(args0, Vector256Constants.Shuffle_Byte_LaneAdd_K1)); // (1,0.5)+(1,0.33) = (2,0.83)
                Vector256<byte> rt1A = Avx2.Shuffle(vector1, Avx2.Add(args1, Vector256Constants.Shuffle_Byte_LaneAdd_K0));  // (1,0.5)+(1,0.33) = (2,0.83)
                Vector256<byte> rt1B = Avx2.Shuffle(vector1B, Avx2.Add(args1, Vector256Constants.Shuffle_Byte_LaneAdd_K1)); // (1,0.5)+(1,0.33) = (2,0.83)
                Vector256<byte> rt0 = Avx2.Or(rt0A, rt0B); // 1,0.33
                Vector256<byte> rt1 = Avx2.Or(rt1A, rt1B); // 1,0.33
                rt0 = AndNot(rt0, flag0); // 1,0.33
                rt1 = AndNot(rt1, flag1); // 1,0.33
                Vector256<byte> rt = Avx2.Or(rt0, rt1); // 1,0.33
                // -- vector2, vector3.
                vector0B = Avx2.Permute4x64(vector2.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                vector1B = Avx2.Permute4x64(vector3.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                flag0 = Avx2.CompareGreaterThan(vzero, args2.AsSByte()).AsByte(); // 1,0.33
                flag1 = Avx2.CompareGreaterThan(vzero, args3.AsSByte()).AsByte(); // 1,0.33
                rt0A = Avx2.Shuffle(vector2, Avx2.Add(args2, Vector256Constants.Shuffle_Byte_LaneAdd_K0));  // (1,0.5)+(1,0.33) = (2,0.83)
                rt0B = Avx2.Shuffle(vector0B, Avx2.Add(args2, Vector256Constants.Shuffle_Byte_LaneAdd_K1)); // (1,0.5)+(1,0.33) = (2,0.83)
                rt1A = Avx2.Shuffle(vector3, Avx2.Add(args3, Vector256Constants.Shuffle_Byte_LaneAdd_K0));  // (1,0.5)+(1,0.33) = (2,0.83)
                rt1B = Avx2.Shuffle(vector1B, Avx2.Add(args3, Vector256Constants.Shuffle_Byte_LaneAdd_K1)); // (1,0.5)+(1,0.33) = (2,0.83)
                rt0 = Avx2.Or(rt0A, rt0B); // 1,0.33
                rt1 = Avx2.Or(rt1A, rt1B); // 1,0.33
                rt0 = AndNot(rt0, flag0); // 1,0.33
                rt1 = AndNot(rt1, flag1); // 1,0.33
                rt0 = Avx2.Or(rt0, rt1); // 1,0.33
                // done.
                rt = Avx2.Or(rt, rt0); // 1,0.33
                return rt; //total latency: 43, total throughput CPI: 15.66
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleX4Kernel_Core_Combine2B(Vector256<byte> vector0, Vector256<byte> vector1, Vector256<byte> vector2, Vector256<byte> vector3, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2, Vector256<byte> args3) {
                Vector256<byte> vzero = Vector256<byte>.Zero;
                // Format: Code; //Latency, Throughput(references IceLake)
                // -- vector0, vector1.
                Vector256<byte> vector0B = Avx2.Permute4x64(vector0.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                Vector256<byte> vector1B = Avx2.Permute4x64(vector1.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                Vector256<byte> rt0A = Avx2.Shuffle(vector0, Avx2.Add(args0, Vector256Constants.Shuffle_Byte_LaneAdd_K0));  // (1,0.5)+(1,0.33) = (2,0.83)
                Vector256<byte> rt0B = Avx2.Shuffle(vector0B, Avx2.Add(args0, Vector256Constants.Shuffle_Byte_LaneAdd_K1)); // (1,0.5)+(1,0.33) = (2,0.83)
                Vector256<byte> rt1A = Avx2.Shuffle(vector1, Avx2.Add(args1, Vector256Constants.Shuffle_Byte_LaneAdd_K0));  // (1,0.5)+(1,0.33) = (2,0.83)
                Vector256<byte> rt1B = Avx2.Shuffle(vector1B, Avx2.Add(args1, Vector256Constants.Shuffle_Byte_LaneAdd_K1)); // (1,0.5)+(1,0.33) = (2,0.83)
                Vector256<byte> rt0 = Avx2.Or(rt0A, rt0B); // 1,0.33
                Vector256<byte> rt1 = Avx2.Or(rt1A, rt1B); // 1,0.33
                rt0 = Avx2.BlendVariable(rt0, vzero, args0); // 3,1
                rt1 = Avx2.BlendVariable(rt1, vzero, args1); // 3,1
                Vector256<byte> rt = Avx2.Or(rt0, rt1); // 1,0.33
                // -- vector2, vector3.
                vector0B = Avx2.Permute4x64(vector2.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                vector1B = Avx2.Permute4x64(vector3.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(); // 3,1
                rt0A = Avx2.Shuffle(vector2, Avx2.Add(args2, Vector256Constants.Shuffle_Byte_LaneAdd_K0));  // (1,0.5)+(1,0.33) = (2,0.83)
                rt0B = Avx2.Shuffle(vector0B, Avx2.Add(args2, Vector256Constants.Shuffle_Byte_LaneAdd_K1)); // (1,0.5)+(1,0.33) = (2,0.83)
                rt1A = Avx2.Shuffle(vector3, Avx2.Add(args3, Vector256Constants.Shuffle_Byte_LaneAdd_K0));  // (1,0.5)+(1,0.33) = (2,0.83)
                rt1B = Avx2.Shuffle(vector1B, Avx2.Add(args3, Vector256Constants.Shuffle_Byte_LaneAdd_K1)); // (1,0.5)+(1,0.33) = (2,0.83)
                rt0 = Avx2.Or(rt0A, rt0B); // 1,0.33
                rt1 = Avx2.Or(rt1A, rt1B); // 1,0.33
                rt0 = Avx2.BlendVariable(rt0, vzero, args2); // 3,1
                rt1 = Avx2.BlendVariable(rt1, vzero, args3); // 3,1
                rt0 = Avx2.Or(rt0, rt1); // 1,0.33
                // done.
                rt = Avx2.Or(rt, rt0); // 1,0.33
                return rt; //total latency: 47, total throughput CPI: 17. Reduced number of registers (flag0, flag1).
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YShuffleX4Kernel_Core(Vector256<short> vector0, Vector256<short> vector1, Vector256<short> vector2, Vector256<short> vector3, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2, Vector256<short> args3) {
                return YShuffleX4Kernel_Core(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleX4Kernel_Core(Vector256<ushort> vector0, Vector256<ushort> vector1, Vector256<ushort> vector2, Vector256<ushort> vector3, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2, Vector256<ushort> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512BW.IsSupported) {
                    Vector512<ushort> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<ushort> u = vector2.ToVector512Unsafe().WithUpper(vector3);
                    return Avx512BW.PermuteVar32x16x2(l, args0.ToVector512Unsafe(), u).GetLower();
                } else if (Avx512BW.VL.IsSupported) {
                    Vector256<ushort> rt0 = Avx512BW.VL.PermuteVar16x16x2(vector0, args0, vector1);
                    Vector256<ushort> rt1 = Avx512BW.VL.PermuteVar16x16x2(vector2, args1, vector3);
                    Vector256<ushort> rt = ConditionalSelect(args2, rt0, rt1);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX4Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleX4Kernel_Core(Vector256<int> vector0, Vector256<int> vector1, Vector256<int> vector2, Vector256<int> vector3, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2, Vector256<int> args3) {
                return YShuffleX4Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX4Kernel_Core(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    Vector512<uint> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<uint> u = vector2.ToVector512Unsafe().WithUpper(vector3);
                    return Avx512F.PermuteVar16x32x2(l, args0.ToVector512Unsafe(), u).GetLower();
                } else if (Avx512F.VL.IsSupported) {
                    Vector256<uint> rt0 = Avx512F.VL.PermuteVar8x32x2(vector0, args0, vector1);
                    Vector256<uint> rt1 = Avx512F.VL.PermuteVar8x32x2(vector2, args1, vector3);
                    Vector256<uint> rt = ConditionalSelect(args2, rt0, rt1);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX4Kernel_Core_Combine(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleX4Kernel_Core_Combine(Vector256<uint> vector0, Vector256<uint> vector1, Vector256<uint> vector2, Vector256<uint> vector3, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2, Vector256<uint> args3) {
                Vector256<int> vzero = Vector256<int>.Zero;
                Vector256<uint> mask1 = Avx2.CompareGreaterThan(vzero, args1.AsInt32()).AsUInt32(); // 0>indices1[i] ==> indices1[i]<0 ==> indices[i]<Count.
                Vector256<uint> rt0 = Avx2.PermuteVar8x32(vector0, args0);
                Vector256<uint> rt1 = Avx2.PermuteVar8x32(vector1, args1);
                Vector256<uint> mask3 = Avx2.CompareGreaterThan(vzero, args3.AsInt32()).AsUInt32(); // 0>indices3[i] ==> indices3[i]<0 ==> indices[i]<Count*3.
                Vector256<uint> rt2 = Avx2.PermuteVar8x32(vector2, args2);
                Vector256<uint> rt3 = Avx2.PermuteVar8x32(vector3, args3);
                Vector256<uint> mask2 = Avx2.CompareGreaterThan(vzero, args2.AsInt32()).AsUInt32(); // 0>indices2[i] ==> indices2[i]<0 ==> indices[i]<Count*2.
                rt0 = ConditionalSelect_Relaxed(mask1, rt0, rt1);
                rt2 = ConditionalSelect_Relaxed(mask3, rt2, rt3);
                Vector256<uint> rt = ConditionalSelect_Relaxed(mask2, rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleX4Kernel_Core(Vector256<long> vector0, Vector256<long> vector1, Vector256<long> vector2, Vector256<long> vector3, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2, Vector256<long> args3) {
                return YShuffleX4Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleX4Kernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleX4Kernel_Core(Vector256<ulong> vector0, Vector256<ulong> vector1, Vector256<ulong> vector2, Vector256<ulong> vector3, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2, Vector256<ulong> args3) {
#if NET8_0_OR_GREATER
                if (Shuffle_Use_Longer && Avx512F.IsSupported) {
                    Vector512<ulong> l = vector0.ToVector512Unsafe().WithUpper(vector1);
                    Vector512<ulong> u = vector2.ToVector512Unsafe().WithUpper(vector3);
                    return Avx512F.PermuteVar8x64x2(l, args0.ToVector512Unsafe(), u).GetLower();
                } else if (Avx512F.VL.IsSupported) {
                    Vector256<ulong> rt0 = Avx512F.VL.PermuteVar4x64x2(vector0, args0, vector1);
                    Vector256<ulong> rt1 = Avx512F.VL.PermuteVar4x64x2(vector2, args1, vector3);
                    Vector256<ulong> rt = ConditionalSelect(args2, rt0, rt1);
                    return rt;
                }
#endif // NET8_0_OR_GREATER
                return YShuffleX4Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.YSign_AcceleratedTypes"/>
            public static TypeCodeFlags YSign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YSign(Vector256<float> value) {
                Vector256<float> zero = Vector256<float>.Zero;
                Vector256<int> m = LessThan(value, zero).AsInt32();
                Vector256<int> n = GreaterThan(value, zero).AsInt32();
                Vector256<int> rt = Avx2.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YSign(Vector256<double> value) {
                Vector256<double> zero = Vector256<double>.Zero;
                Vector256<long> m = LessThan(value, zero).AsInt64();
                Vector256<long> n = GreaterThan(value, zero).AsInt64();
                Vector256<long> rt = Avx2.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YSign(Vector256<sbyte> value) {
                Vector256<sbyte> zero = Vector256<sbyte>.Zero;
                Vector256<sbyte> m = LessThan(value, zero);
                Vector256<sbyte> n = GreaterThan(value, zero);
                Vector256<sbyte> rt = Avx2.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YSign(Vector256<short> value) {
                Vector256<short> zero = Vector256<short>.Zero;
                Vector256<short> m = LessThan(value, zero);
                Vector256<short> n = GreaterThan(value, zero);
                Vector256<short> rt = Avx2.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YSign(Vector256<int> value) {
                Vector256<int> zero = Vector256<int>.Zero;
                Vector256<int> m = LessThan(value, zero);
                Vector256<int> n = GreaterThan(value, zero);
                Vector256<int> rt = Avx2.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YSign(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YSign(Vector256<long> value) {
                Vector256<long> zero = Vector256<long>.Zero;
                Vector256<long> m = LessThan(value, zero);
                Vector256<long> n = GreaterThan(value, zero);
                Vector256<long> rt = Avx2.Subtract(m, n);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YSignFloat_AcceleratedTypes"/>
            public static TypeCodeFlags YSignFloat_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    rt |= (TypeCodeFlags.Single) & YIsNaN_AcceleratedTypes & ConvertToSingle_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Double) & YIsNaN_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YSignFloat(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YSignFloat(Vector256<float> value) {
                Vector256<int> signVal = YSign(value);
                Vector256<float> nanMask = YIsNaN(value).AsSingle();
                Vector256<float> rt = ConvertToSingle(signVal);
                rt = BitwiseOr(rt, BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YSignFloat(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YSignFloat(Vector256<double> value) {
                return YSignFloat_Compare(value);
            }

            /// <inheritdoc cref="IWVectorTraits256.YSignFloat(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YSignFloat_Compare(Vector256<double> value) {
                Vector256<double> negativeOne = Vector256.Create(-1.0);
                Vector256<double> zero = Vector256<double>.Zero;
                Vector256<double> one = Vector256.Create(1.0);
                Vector256<double> rt = BitwiseAnd(LessThan(value, zero), negativeOne);
                Vector256<double> nanMask = YIsNaN(value).AsDouble();
                rt = BitwiseOr(rt, BitwiseAnd(GreaterThan(value, zero), one)); // rt = ConvertToDouble(YSign(value));
                rt = BitwiseOr(rt, BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YSignFloat(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YSignFloat_Convert(Vector256<double> value) {
                Vector256<long> signVal = YSign(value);
                Vector256<double> nanMask = YIsNaN(value).AsDouble();
                Vector256<double> rt = ConvertToDouble_Range52(signVal);
                rt = BitwiseOr(rt, BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
