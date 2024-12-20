﻿using System;
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

namespace Zyl.VectorTraits.Impl.AVector512 {
    using SuperStatics = WVectorTraits512Base.Statics;

    partial class WVectorTraits512Avx512 {

        partial class Statics {

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG2_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG2(Vector512<float> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG2(Vector512<double> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleG2(Vector512<sbyte> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleG2(Vector512<byte> source, ShuffleControlG2 control) {
                Vector512<byte> indices = Vector512Constants.GetYShuffleG2_Byte_Indices(control); // It also supports _mm512_shuffle_epi8 for 128-bit lanes .
                return Avx512BW.Shuffle(source, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleG2(Vector512<short> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG2(Vector512<ushort> source, ShuffleControlG2 control) {
                Vector512<byte> indices = Vector512Constants.GetYShuffleG2_UInt16_ByteIndices(control).AsByte(); // It also supports _mm512_shuffle_epi8 for 128-bit lanes .
                return Avx512BW.Shuffle(source.AsByte(), indices).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG2(Vector512<int> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG2(Vector512<uint> source, ShuffleControlG2 control) {
                return YShuffleG2_Byte(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG2_Byte(Vector512<uint> source, ShuffleControlG2 control) {
                Vector512<byte> indices = Vector512Constants.GetYShuffleG2_UInt32_ByteIndices(control); // It also supports _mm512_shuffle_epi8 for 128-bit lanes .
                return Avx512BW.Shuffle(source.AsByte(), indices).AsUInt32();
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG2_UInt32(Vector512<uint> source, ShuffleControlG2 control) {
                Vector512<int> indices = Vector512Constants.GetYShuffleG2_UInt32_Indices(control).AsInt32(); // It also supports _mm512_permutevar_ps for 128-bit lanes .
                return Avx512F.PermuteVar4x32(source.AsSingle(), indices).AsUInt32();
            }
#endif // !REDUCE_MEMORY_USAGE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG2(Vector512<long> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG2(Vector512<ulong> source, ShuffleControlG2 control) {
                Vector512<byte> indices = Vector512Constants.GetYShuffleG2_UInt64_ByteIndices(control).AsByte(); // It also supports _mm512_shuffle_epi8 for 128-bit lanes .
                return Avx512BW.Shuffle(source.AsByte(), indices).AsUInt64();
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG2_Const(Vector512<float> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG2_Const(Vector512<double> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleG2_Const(Vector512<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleG2_Const(Vector512<byte> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleG2_Const(Vector512<short> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG2_Const(Vector512<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG2_Const(Vector512<int> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG2_Const(Vector512<uint> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG2_Const(Vector512<long> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG2_Const(Vector512<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
#if NETX_0_OR_GREATER // Requires support for compiling constants to immediate numbers
                return YShuffleG2_Const_Imm(source, control);
#else
                return YShuffleG2(source, control);
#endif // NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG2_Const_Imm(Vector512<float> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const_Imm(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG2_Const_Imm(Vector512<double> source, [ConstantExpected] ShuffleControlG2 control) {
                byte ctl = (byte)((byte)control * 5);
                return Avx512BW.Shuffle(source, source, ctl);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleG2_Const_Imm(Vector512<short> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const_Imm(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG2_Const_Imm(Vector512<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
                byte n = (byte)control;
                byte ctl = (byte)(0xA0 + (n & 2) * 0x22 + (n & 1) * 0x11); // ShuffleControlG2 to ShuffleControlG4
                return Avx512BW.ShuffleHigh(Avx512BW.ShuffleLow(source, ctl), ctl);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG2_Const_Imm(Vector512<int> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const_Imm(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG2_Const_ImmByte(Vector512<int> source, [ConstantExpected(Max = 3)] byte control) {
                byte ctl = (byte)(0xA0 + (control & 2) * 0x22 + (control & 1) * 0x11); // ShuffleControlG2 to ShuffleControlG4
                return Avx512F.Shuffle(source, ctl);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG2_Const_Imm(Vector512<uint> source, [ConstantExpected] ShuffleControlG2 control) {
                byte n = (byte)control;
                byte ctl = (byte)(0xA0 + (n & 2) * 0x22 + (n & 1) * 0x11); // ShuffleControlG2 to ShuffleControlG4
                return Avx512F.Shuffle(source, ctl);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG2_Const_Imm(Vector512<long> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const_Imm(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG2_Const_Imm(Vector512<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const_Imm(source.AsDouble(), control).AsUInt64();
                //// _mm512_permute4x64_epi64
                // byte n = (byte)control;
                //byte ctl = (byte)(0xA0 + (n & 2) * 0x22 + (n & 1) * 0x11); // ShuffleControlG2 to ShuffleControlG4
                //return Avx512F.Permute4x64(source, ctl);
            }
#endif // !REDUCE_MEMORY_USAGE


            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG4(Vector512<float> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG4(Vector512<double> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleG4(Vector512<sbyte> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleG4(Vector512<byte> source, ShuffleControlG4 control) {
                Vector512<byte> indices = Vector512Constants.GetYShuffleG4_Byte_Indices(control); // It also supports _mm512_shuffle_epi8 for 128-bit lanes .
                return Avx512BW.Shuffle(source, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleG4(Vector512<short> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG4(Vector512<ushort> source, ShuffleControlG4 control) {
                Vector512<byte> indices = Vector512Constants.GetYShuffleG4_UInt16_ByteIndices(control).AsByte(); // It also supports _mm512_shuffle_epi8 for 128-bit lanes .
                return Avx512BW.Shuffle(source.AsByte(), indices).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG4(Vector512<int> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG4(Vector512<uint> source, ShuffleControlG4 control) {
                return YShuffleG4_Byte(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG4_Byte(Vector512<uint> source, ShuffleControlG4 control) {
                Vector512<byte> indices = Vector512Constants.GetYShuffleG4_UInt32_ByteIndices(control).AsByte(); // It also supports _mm512_shuffle_epi8 for 128-bit lanes .
                return Avx512BW.Shuffle(source.AsByte(), indices).AsUInt32(); // _mm512_shuffle_epi8
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG4_UInt32(Vector512<uint> source, ShuffleControlG4 control) {
                Vector512<int> indices = Vector512Constants.GetYShuffleG4_UInt32_Indices(control).AsInt32(); // It also supports _mm512_permutevar_ps for 128-bit lanes .
                return Avx512F.PermuteVar4x32(source.AsSingle(), indices).AsUInt32(); // _mm512_permutevar_ps
            }
#endif // !REDUCE_MEMORY_USAGE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG4(Vector512<long> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG4(Vector512<ulong> source, ShuffleControlG4 control) {
                Vector512<uint> indices = Vector512Constants.GetYShuffleG4_UInt64_UInt32Indices(control);
                return Avx512F.PermuteVar16x32(source.AsUInt32(), indices).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG4_Const(Vector512<float> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG4_Const(Vector512<double> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleG4_Const(Vector512<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleG4_Const(Vector512<byte> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleG4_Const(Vector512<short> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG4_Const(Vector512<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG4_Const(Vector512<int> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG4_Const(Vector512<uint> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG4_Const(Vector512<long> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG4_Const(Vector512<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
#if NETCOREAPP3_0_OR_GREATER
                return YShuffleG4_Const_Imm(source, control);
#else
                return YShuffleG4(source, control);
#endif // NETCOREAPP3_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG4_Const_Imm(Vector512<float> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4_Const_Imm(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG4_Const_Imm(Vector512<double> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx512F.Permute4x64(source, (byte)control); // _mm512_permute4x64_epi64
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleG4_Const_Imm(Vector512<short> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx512BW.ShuffleHigh(Avx512BW.ShuffleLow(source, (byte)control), (byte)control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG4_Const_Imm(Vector512<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx512BW.ShuffleHigh(Avx512BW.ShuffleLow(source, (byte)control), (byte)control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG4_Const_Imm(Vector512<int> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx512BW.Shuffle(source, (byte)control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG4_Const_ImmByte(Vector512<int> source, [ConstantExpected(Max = 255)] byte control) {
                return Avx512BW.Shuffle(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG4_Const_Imm(Vector512<uint> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx512F.Shuffle(source, (byte)control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG4_Const_Imm(Vector512<long> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx512F.Permute4x64(source, (byte)control); // _mm512_permute4x64_epi64
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG4_Const_Imm(Vector512<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
                return Avx512F.Permute4x64(source, (byte)control); // _mm512_permute4x64_epi64
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
                get {
                    return YShuffleG4_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{float}, Vector512{float}, ShuffleControlG4, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG4X2(Vector512<float> source0, Vector512<float> source1, ShuffleControlG4 control, out Vector512<float> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt32(), source1.AsUInt32(), control, out var rt1);
                result1 = rt1.AsSingle();
                return rt0.AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{double}, Vector512{double}, ShuffleControlG4, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG4X2(Vector512<double> source0, Vector512<double> source1, ShuffleControlG4 control, out Vector512<double> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt64(), source1.AsUInt64(), control, out var rt1);
                result1 = rt1.AsDouble();
                return rt0.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{sbyte}, Vector512{sbyte}, ShuffleControlG4, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleG4X2(Vector512<sbyte> source0, Vector512<sbyte> source1, ShuffleControlG4 control, out Vector512<sbyte> result1) {
                var rt0 = YShuffleG4X2(source0.AsByte(), source1.AsByte(), control, out var rt1);
                result1 = rt1.AsSByte();
                return rt0.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{byte}, Vector512{byte}, ShuffleControlG4, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleG4X2(Vector512<byte> source0, Vector512<byte> source1, ShuffleControlG4 control, out Vector512<byte> result1) {
                Vector512<byte> indices = Vector512Constants.GetYShuffleG4_Byte_Indices(control); // It also supports _mm512_shuffle_epi8 for 128-bit lanes .
                var rt0 = Avx512BW.Shuffle(source0, indices);
                result1 = Avx512BW.Shuffle(source1, indices);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{short}, Vector512{short}, ShuffleControlG4, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleG4X2(Vector512<short> source0, Vector512<short> source1, ShuffleControlG4 control, out Vector512<short> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt16(), source1.AsUInt16(), control, out var rt1);
                result1 = rt1.AsInt16();
                return rt0.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG4X2(Vector512<ushort> source0, Vector512<ushort> source1, ShuffleControlG4 control, out Vector512<ushort> result1) {
                Vector512<byte> indices = Vector512Constants.GetYShuffleG4_UInt16_ByteIndices(control).AsByte(); // It also supports _mm512_shuffle_epi8 for 128-bit lanes .
                var rt0 = Avx512BW.Shuffle(source0.AsByte(), indices).AsUInt16();
                result1 = Avx512BW.Shuffle(source1.AsByte(), indices).AsUInt16();
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{int}, Vector512{int}, ShuffleControlG4, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG4X2(Vector512<int> source0, Vector512<int> source1, ShuffleControlG4 control, out Vector512<int> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt32(), source1.AsUInt32(), control, out var rt1);
                result1 = rt1.AsInt32();
                return rt0.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{uint}, Vector512{uint}, ShuffleControlG4, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG4X2(Vector512<uint> source0, Vector512<uint> source1, ShuffleControlG4 control, out Vector512<uint> result1) {
                Vector512<byte> indices = Vector512Constants.GetYShuffleG4_UInt32_ByteIndices(control).AsByte(); // It also supports _mm512_shuffle_epi8 for 128-bit lanes .
                var rt0 = Avx512BW.Shuffle(source0.AsByte(), indices).AsUInt32();
                result1 = Avx512BW.Shuffle(source1.AsByte(), indices).AsUInt32();
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{long}, Vector512{long}, ShuffleControlG4, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG4X2(Vector512<long> source0, Vector512<long> source1, ShuffleControlG4 control, out Vector512<long> result1) {
                Vector512<uint> indices = Vector512Constants.GetYShuffleG4_UInt64_UInt32Indices(control);
                var rt0 = Avx512F.PermuteVar16x32(source0.AsUInt32(), indices).AsInt64();
                result1 = Avx512F.PermuteVar16x32(source1.AsUInt32(), indices).AsInt64();
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG4X2(Vector512<ulong> source0, Vector512<ulong> source1, ShuffleControlG4 control, out Vector512<ulong> result1) {
                Vector512<uint> indices = Vector512Constants.GetYShuffleG4_UInt64_UInt32Indices(control);
                var rt0 = Avx512F.PermuteVar16x32(source0.AsUInt32(), indices).AsUInt64();
                result1 = Avx512F.PermuteVar16x32(source1.AsUInt32(), indices).AsUInt64();
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{float}, Vector512{float}, ShuffleControlG4, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG4X2_Const(Vector512<float> source0, Vector512<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<float> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{double}, Vector512{double}, ShuffleControlG4, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG4X2_Const(Vector512<double> source0, Vector512<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<double> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{sbyte}, Vector512{sbyte}, ShuffleControlG4, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleG4X2_Const(Vector512<sbyte> source0, Vector512<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<sbyte> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{byte}, Vector512{byte}, ShuffleControlG4, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleG4X2_Const(Vector512<byte> source0, Vector512<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<byte> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{short}, Vector512{short}, ShuffleControlG4, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleG4X2_Const(Vector512<short> source0, Vector512<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<short> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG4X2_Const(Vector512<ushort> source0, Vector512<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<ushort> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{int}, Vector512{int}, ShuffleControlG4, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG4X2_Const(Vector512<int> source0, Vector512<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<int> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{uint}, Vector512{uint}, ShuffleControlG4, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG4X2_Const(Vector512<uint> source0, Vector512<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<uint> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{long}, Vector512{long}, ShuffleControlG4, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG4X2_Const(Vector512<long> source0, Vector512<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<long> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG4X2_Const(Vector512<ulong> source0, Vector512<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<ulong> result1) {
                var rt0 = YShuffleG4_Const(source0, control);
                result1 = YShuffleG4_Const(source1, control);
                return rt0;
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
                get {
                    return YShuffleKernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleInsert(Vector512<float> back, Vector512<float> vector, Vector512<int> indices) {
                //return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsSingle();
                Vector512<float> mask = Avx512F.CompareEqual(Avx512F.ShiftRightLogical(indices, 4), Vector512<int>.Zero).AsSingle(); // Unsigned compare: (i < 16)
                Vector512<float> raw = YShuffleKernel(vector, indices);
                Vector512<float> rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleInsert(Vector512<double> back, Vector512<double> vector, Vector512<long> indices) {
                //return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsDouble();
                Vector512<double> mask = Avx512F.CompareEqual(Avx512F.ShiftRightLogical(indices, 3), Vector512<long>.Zero).AsDouble(); // Unsigned compare: (i < 8)
                Vector512<double> raw = YShuffleKernel(vector, indices);
                Vector512<double> rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleInsert(Vector512<sbyte> back, Vector512<sbyte> vector, Vector512<sbyte> indices) {
                return YShuffleInsert(back.AsByte(), vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleInsert(Vector512<byte> back, Vector512<byte> vector, Vector512<byte> indices) {
                Vector512<byte> mask = Avx512BW.CompareGreaterThan(Vector512.Create((byte)64), indices); // Unsigned compare: (i < 64)
                Vector512<byte> raw = YShuffleKernel(vector, indices);
                Vector512<byte> rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleInsert(Vector512<short> back, Vector512<short> vector, Vector512<short> indices) {
                return YShuffleInsert(back.AsUInt16(), vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleInsert(Vector512<ushort> back, Vector512<ushort> vector, Vector512<ushort> indices) {
                Vector512<ushort> mask = Avx512BW.CompareEqual(Avx512BW.ShiftRightLogical(indices, 5), Vector512<ushort>.Zero); // Unsigned compare: (i < 32)
                Vector512<ushort> raw = YShuffleKernel(vector, indices);
                Vector512<ushort> rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleInsert(Vector512<int> back, Vector512<int> vector, Vector512<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleInsert(Vector512<uint> back, Vector512<uint> vector, Vector512<uint> indices) {
                Vector512<uint> mask = Avx512F.CompareEqual(Avx512F.ShiftRightLogical(indices, 4), Vector512<uint>.Zero); // Unsigned compare: (i < 16)
                Vector512<uint> raw = YShuffleKernel(vector, indices);
                Vector512<uint> rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleInsert(Vector512<long> back, Vector512<long> vector, Vector512<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleInsert(Vector512<ulong> back, Vector512<ulong> vector, Vector512<ulong> indices) {
                Vector512<ulong> mask = Avx512F.CompareEqual(Avx512F.ShiftRightLogical(indices, 3), Vector512<ulong>.Zero); // Unsigned compare: (i < 8)
                Vector512<ulong> raw = YShuffleKernel(vector, indices);
                Vector512<ulong> rt = ConditionalSelect(mask, raw, back);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2) {
                YShuffleInsert_Args(indices.AsByte(), out var a0, out var a1, out var a2);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2) {
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = Avx512BW.CompareGreaterThan(Vector512.Create((byte)64), indices); // Unsigned compare: (i < 64)
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2) {
                YShuffleInsert_Args(indices.AsUInt16(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2) {
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = Avx512BW.CompareEqual(Avx512BW.ShiftRightLogical(indices, 5), Vector512<ushort>.Zero); // Unsigned compare: (i < 32)
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2) {
                YShuffleInsert_Args(indices.AsUInt32(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2) {
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = Avx512F.CompareEqual(Avx512F.ShiftRightLogical(indices, 4), Vector512<uint>.Zero); // Unsigned compare: (i < 16)
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2) {
                YShuffleInsert_Args(indices.AsUInt64(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2) {
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = Avx512F.CompareEqual(Avx512F.ShiftRightLogical(indices, 3), Vector512<ulong>.Zero); // Unsigned compare: (i < 8)
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleInsert_Core(Vector512<float> back, Vector512<float> vector, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2) {
                //return YShuffleInsert_Core(back.AsUInt32(), vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32()).AsSingle();
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = ConditionalSelect(args2.AsSingle(), raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleInsert_Core(Vector512<double> back, Vector512<double> vector, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2) {
                //return YShuffleInsert_Core(back.AsUInt64(), vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64()).AsDouble();
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = ConditionalSelect(args2.AsDouble(), raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleInsert_Core(Vector512<sbyte> back, Vector512<sbyte> vector, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2) {
                return YShuffleInsert_Core(back.AsByte(), vector.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleInsert_Core(Vector512<byte> back, Vector512<byte> vector, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2) {
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = ConditionalSelect(args2, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleInsert_Core(Vector512<short> back, Vector512<short> vector, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2) {
                return YShuffleInsert_Core(back.AsUInt16(), vector.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleInsert_Core(Vector512<ushort> back, Vector512<ushort> vector, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2) {
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = ConditionalSelect(args2, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleInsert_Core(Vector512<int> back, Vector512<int> vector, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2) {
                return YShuffleInsert_Core(back.AsUInt32(), vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleInsert_Core(Vector512<uint> back, Vector512<uint> vector, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2) {
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = ConditionalSelect(args2, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleInsert_Core(Vector512<long> back, Vector512<long> vector, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2) {
                return YShuffleInsert_Core(back.AsUInt64(), vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleInsert_Core(Vector512<ulong> back, Vector512<ulong> vector, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2) {
                var raw = YShuffleKernel_Core(vector, args0, args1);
                var rt = ConditionalSelect(args2, raw, back);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleKernel(Vector512<float> vector, Vector512<int> indices) {
                return Avx512F.PermuteVar16x32(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleKernel(Vector512<double> vector, Vector512<long> indices) {
                return Avx512F.PermuteVar8x64(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleKernel(Vector512<sbyte> vector, Vector512<sbyte> indices) {
                return Avx512Vbmi.PermuteVar64x8(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleKernel(Vector512<byte> vector, Vector512<byte> indices) {
                return Avx512Vbmi.PermuteVar64x8(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleKernel(Vector512<short> vector, Vector512<short> indices) {
                return Avx512BW.PermuteVar32x16(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleKernel(Vector512<ushort> vector, Vector512<ushort> indices) {
                return Avx512BW.PermuteVar32x16(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleKernel(Vector512<int> vector, Vector512<int> indices) {
                return Avx512F.PermuteVar16x32(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleKernel(Vector512<uint> vector, Vector512<uint> indices) {
                return Avx512F.PermuteVar16x32(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleKernel(Vector512<long> vector, Vector512<long> indices) {
                return Avx512F.PermuteVar8x64(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleKernel(Vector512<ulong> vector, Vector512<ulong> indices) {
                return Avx512F.PermuteVar8x64(vector, indices);
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1) {
                args0 = indices;
                args1 = default;
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{float}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleKernel_Core(Vector512<float> vector, Vector512<int> args0, Vector512<int> args1) {
                _ = args1;
                return Avx512F.PermuteVar16x32(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{double}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleKernel_Core(Vector512<double> vector, Vector512<long> args0, Vector512<long> args1) {
                _ = args1;
                return Avx512F.PermuteVar8x64(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleKernel_Core(Vector512<sbyte> vector, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                _ = args1;
                return Avx512Vbmi.PermuteVar64x8(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleKernel_Core(Vector512<byte> vector, Vector512<byte> args0, Vector512<byte> args1) {
                _ = args1;
                return Avx512Vbmi.PermuteVar64x8(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleKernel_Core(Vector512<short> vector, Vector512<short> args0, Vector512<short> args1) {
                _ = args1;
                return Avx512BW.PermuteVar32x16(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleKernel_Core(Vector512<ushort> vector, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = args1;
                return Avx512BW.PermuteVar32x16(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleKernel_Core(Vector512<int> vector, Vector512<int> args0, Vector512<int> args1) {
                _ = args1;
                return Avx512F.PermuteVar16x32(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleKernel_Core(Vector512<uint> vector, Vector512<uint> args0, Vector512<uint> args1) {
                _ = args1;
                return Avx512F.PermuteVar16x32(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleKernel_Core(Vector512<long> vector, Vector512<long> args0, Vector512<long> args1) {
                _ = args1;
                return Avx512F.PermuteVar8x64(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleKernel_Core(Vector512<ulong> vector, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = args1;
                return Avx512F.PermuteVar8x64(vector, args0);
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2_AcceleratedTypes {
                get {
                    return YShuffleX2Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
                //return YShuffleX2(vector0.AsInt32(), vector1.AsInt32(), indices).AsSingle();
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector256<uint>.Count
                Vector512<float> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices.AsUInt32()).AsSingle();
                raw = Avx512F.PermuteVar16x32x2(vector0, indices, vector1);
                rt = Avx512DQ.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
                //return YShuffleX2(vector0.AsInt64(), vector1.AsInt64(), indices).AsDouble();
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector256<ulong>.Count
                Vector512<double> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices.AsUInt64()).AsDouble();
                raw = Avx512F.PermuteVar8x64x2(vector0, indices, vector1);
                rt = Avx512DQ.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
                return YShuffleX2(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector512<byte>.Count
                Vector512<byte> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
                raw = Avx512Vbmi.PermuteVar64x8x2(vector0, indices, vector1);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
                return YShuffleX2(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
                const ushort total = 2 * ByteCountValue / sizeof(ushort); // 2 * Vector256<ushort>.Count
                Vector512<ushort> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
                raw = Avx512BW.PermuteVar32x16x2(vector0, indices, vector1);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
                return YShuffleX2(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector256<uint>.Count
                Vector512<uint> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
                raw = Avx512F.PermuteVar16x32x2(vector0, indices, vector1);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
                return YShuffleX2(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector256<ulong>.Count
                Vector512<ulong> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
                raw = Avx512F.PermuteVar8x64x2(vector0, indices, vector1);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
                YShuffleX2_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
                args4 = a4.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector512<byte>.Count
                YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
                YShuffleX2_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
                args4 = a4.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
                const ushort total = 2 * ByteCountValue / sizeof(ushort); // 2 * Vector256<ushort>.Count
                YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
                YShuffleX2_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
                args4 = a4.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector256<uint>.Count
                YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
                YShuffleX2_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
                args4 = a4.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector256<ulong>.Count
                YShuffleX2Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                //return YShuffleX2_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
                Vector512<float> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx512DQ.And(rt, args4.AsSingle());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                //return YShuffleX2_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
                Vector512<double> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx512DQ.And(rt, args4.AsDouble());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
                return YShuffleX2_Core(vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
                Vector512<byte> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx512F.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
                return YShuffleX2_Core(vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
                Vector512<ushort> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx512F.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                return YShuffleX2_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
                Vector512<uint> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx512F.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                return YShuffleX2_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
                Vector512<ulong> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = Avx512F.And(rt, args4);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
                get {
                    return YShuffleX2Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2Insert(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
                //return YShuffleX2Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector256<uint>.Count
                Vector512<float> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices.AsUInt32()).AsSingle();
                raw = Avx512F.PermuteVar16x32x2(vector0, indices, vector1);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2Insert(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
                //return YShuffleX2Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector256<ulong>.Count
                Vector512<double> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices.AsUInt64()).AsDouble();
                raw = Avx512F.PermuteVar8x64x2(vector0, indices, vector1);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2Insert(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
                return YShuffleX2Insert(back.AsByte(), vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2Insert(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector512<byte>.Count
                Vector512<byte> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
                raw = Avx512Vbmi.PermuteVar64x8x2(vector0, indices, vector1);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2Insert(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
                return YShuffleX2Insert(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2Insert(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
                const ushort total = 2 * ByteCountValue / sizeof(ushort); // 2 * Vector256<ushort>.Count
                Vector512<ushort> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
                raw = Avx512BW.PermuteVar32x16x2(vector0, indices, vector1);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2Insert(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
                return YShuffleX2Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2Insert(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector256<uint>.Count
                Vector512<uint> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
                raw = Avx512F.PermuteVar16x32x2(vector0, indices, vector1);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2Insert(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
                return YShuffleX2Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2Insert(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector256<ulong>.Count
                Vector512<ulong> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
                raw = Avx512F.PermuteVar8x64x2(vector0, indices, vector1);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
                YShuffleX2_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2Insert_Core(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                //return YShuffleX2Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
                Vector512<float> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect(args4.AsSingle(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2Insert_Core(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                //return YShuffleX2Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
                Vector512<double> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect(args4.AsDouble(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2Insert_Core(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
                return YShuffleX2Insert_Core(back.AsByte(), vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2Insert_Core(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
                Vector512<byte> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2Insert_Core(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
                return YShuffleX2Insert_Core(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2Insert_Core(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
                Vector512<ushort> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2Insert_Core(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                return YShuffleX2Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2Insert_Core(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
                Vector512<uint> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2Insert_Core(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                return YShuffleX2Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2Insert_Core(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
                Vector512<ulong> rt = YShuffleX2Kernel_Core(vector0, vector1, args0, args1, args2, args3);
                rt = ConditionalSelect(args4, rt, back);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2Kernel(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
                return Avx512F.PermuteVar16x32x2(vector0, indices, vector1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2Kernel(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
                return Avx512F.PermuteVar8x64x2(vector0, indices, vector1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2Kernel(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
                return YShuffleX2Kernel(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2Kernel(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
                return Avx512Vbmi.PermuteVar64x8x2(vector0, indices, vector1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2Kernel(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
                return YShuffleX2Kernel(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2Kernel(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
                return Avx512BW.PermuteVar32x16x2(vector0, indices, vector1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2Kernel(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
                return YShuffleX2Kernel(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2Kernel(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
                return Avx512F.PermuteVar16x32x2(vector0, indices, vector1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2Kernel(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
                return YShuffleX2Kernel(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2Kernel(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
                return Avx512F.PermuteVar8x64x2(vector0, indices, vector1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3) {
                YShuffleX2Kernel_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3) {
                YShuffleX2Kernel_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3) {
                YShuffleX2Kernel_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3) {
                YShuffleX2Kernel_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2Kernel_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return Avx512F.PermuteVar16x32x2(vector0, args0, vector1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2Kernel_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return Avx512F.PermuteVar8x64x2(vector0, args0, vector1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2Kernel_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) {
                return YShuffleX2Kernel_Core(vector0.AsByte(), vector1.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2Kernel_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return Avx512Vbmi.PermuteVar64x8x2(vector0, args0, vector1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2Kernel_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) {
                return YShuffleX2Kernel_Core(vector0.AsUInt16(), vector1.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2Kernel_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return Avx512BW.PermuteVar32x16x2(vector0, args0, vector1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2Kernel_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
                return YShuffleX2Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2Kernel_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return Avx512F.PermuteVar16x32x2(vector0, args0, vector1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2Kernel_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
                return YShuffleX2Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2Kernel_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return Avx512F.PermuteVar8x64x2(vector0, args0, vector1);
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3_AcceleratedTypes {
                get {
                    return YShuffleX3Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
                //return YShuffleX3(vector0.AsInt32(), vector1.AsInt32(), vector2.AsInt32(), indices).AsSingle();
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector512<uint>.Count
                Vector512<float> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices.AsUInt32()).AsSingle();
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = Avx512DQ.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
                //return YShuffleX3(vector0.AsInt64(), vector1.AsInt64(), indices).AsDouble();
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector512<ulong>.Count
                Vector512<double> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices.AsUInt64()).AsDouble();
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = Avx512DQ.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
                //return YShuffleX3(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
                Vector512<sbyte> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector512<byte>.Count
                Vector512<byte> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
                return YShuffleX3(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector512<ushort>.Count
                Vector512<ushort> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
                return YShuffleX3(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector512<uint>.Count
                Vector512<uint> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
                return YShuffleX3(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector512<ulong>.Count
                Vector512<ulong> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512BW.CompareGreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector512<byte>.Count
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
                YShuffleX3_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
                args4 = a4.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector512<ushort>.Count
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
                YShuffleX3_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
                args4 = a4.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector512<uint>.Count
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
                YShuffleX3_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
                args4 = a4.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector512<ulong>.Count
                YShuffleX3Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                //return YShuffleX3_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
                Vector512<float> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = Avx512DQ.And(rt, args4.AsSingle());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                //return YShuffleX3_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
                Vector512<double> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = Avx512DQ.And(rt, args4.AsDouble());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
                return YShuffleX3_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
                Vector512<byte> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = Avx512F.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
                return YShuffleX3_Core(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
                Vector512<ushort> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = Avx512F.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                return YShuffleX3_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
                Vector512<uint> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = Avx512F.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                return YShuffleX3_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
                Vector512<ulong> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = Avx512F.And(rt, args4);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Insert_AcceleratedTypes {
                get {
                    return YShuffleX3Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3Insert(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
                //return YShuffleX3Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector512<uint>.Count
                Vector512<float> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices.AsUInt32()).AsSingle();
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3Insert(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
                //return YShuffleX3Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector512<ulong>.Count
                Vector512<double> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices.AsUInt64()).AsDouble();
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3Insert(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
                //return YShuffleX3Insert(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
                Vector512<sbyte> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3Insert(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector512<byte>.Count
                Vector512<byte> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3Insert(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
                return YShuffleX3Insert(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3Insert(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector512<ushort>.Count
                Vector512<ushort> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3Insert(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
                return YShuffleX3Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3Insert(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector512<uint>.Count
                Vector512<uint> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3Insert(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
                return YShuffleX3Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3Insert(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector512<ulong>.Count
                Vector512<ulong> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX3Kernel(vector0, vector1, vector2, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
                YShuffleX3_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3Insert_Core(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                //return YShuffleX3Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsSingle();
                Vector512<float> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = ConditionalSelect(args4.AsSingle(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3Insert_Core(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                //return YShuffleX3Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsDouble();
                Vector512<double> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = ConditionalSelect(args4.AsDouble(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3Insert_Core(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
                return YShuffleX3Insert_Core(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte(), args4.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3Insert_Core(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
                Vector512<byte> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3Insert_Core(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
                return YShuffleX3Insert_Core(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3Insert_Core(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
                Vector512<ushort> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3Insert_Core(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                return YShuffleX3Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3Insert_Core(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
                Vector512<uint> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3Insert_Core(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                return YShuffleX3Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3Insert_Core(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
                Vector512<ulong> rt = YShuffleX3Kernel_Core(vector0, vector1, vector2, args0, args1, args2, args3);
                rt = ConditionalSelect(args4, rt, back);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3Kernel(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
                //return YShuffleX3Kernel(vector0.AsInt32(), vector1.AsInt32(), vector2.AsInt32(), indices).AsSingle();
                Vector512<int> vCount2 = Vector512.Create((int)(Vector512<float>.Count * 2));
                Vector512<int> indices1 = Avx512F.Subtract(indices, vCount2);
                Vector512<float> mask = Avx512F.CompareGreaterThan(vCount2, indices).AsSingle(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector512<float> rt0 = Avx512F.PermuteVar16x32x2(vector0, indices, vector1);
                Vector512<float> rt1 = Avx512F.PermuteVar16x32(vector2, indices1);
                Vector512<float> rt = ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3Kernel(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
                // return YShuffleX3Kernel(vector0.AsInt64(), vector1.AsInt64(), vector2.AsInt64(), indices).AsDouble();
                Vector512<long> vCount2 = Vector512.Create((long)(Vector512<long>.Count * 2));
                Vector512<long> indices1 = Avx512F.Subtract(indices, vCount2);
                Vector512<double> mask = Avx512F.CompareGreaterThan(vCount2, indices).AsDouble(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector512<double> rt0 = Avx512F.PermuteVar8x64x2(vector0, indices, vector1);
                Vector512<double> rt1 = Avx512F.PermuteVar8x64(vector2, indices1);
                Vector512<double> rt = ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3Kernel(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
                return YShuffleX3Kernel(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3Kernel(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
                Vector512<byte> vCount2 = Vector512.Create((byte)(Vector512<byte>.Count * 2));
                Vector512<byte> indices1 = Avx512BW.Subtract(indices, vCount2);
                Vector512<byte> mask = Avx512BW.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector512<byte> rt0 = Avx512Vbmi.PermuteVar64x8x2(vector0, indices, vector1);
                Vector512<byte> rt1 = Avx512Vbmi.PermuteVar64x8(vector2, indices1);
                Vector512<byte> rt = ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3Kernel(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
                return YShuffleX3Kernel(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3Kernel(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
                Vector512<ushort> vCount2 = Vector512.Create((ushort)(Vector512<ushort>.Count * 2));
                Vector512<ushort> indices1 = Avx512BW.Subtract(indices, vCount2);
                Vector512<ushort> mask = Avx512BW.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector512<ushort> rt0 = Avx512BW.PermuteVar32x16x2(vector0, indices, vector1);
                Vector512<ushort> rt1 = Avx512BW.PermuteVar32x16(vector2, indices1);
                Vector512<ushort> rt = ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3Kernel(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
                return YShuffleX3Kernel(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3Kernel(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
                Vector512<uint> vCount2 = Vector512.Create((uint)(Vector512<uint>.Count * 2));
                Vector512<uint> indices1 = Avx512F.Subtract(indices, vCount2);
                Vector512<uint> mask = Avx512F.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector512<uint> rt0 = Avx512F.PermuteVar16x32x2(vector0, indices, vector1);
                Vector512<uint> rt1 = Avx512F.PermuteVar16x32(vector2, indices1);
                Vector512<uint> rt = ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3Kernel(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
                return YShuffleX3Kernel(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3Kernel(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
                Vector512<ulong> vCount2 = Vector512.Create((ulong)(Vector512<ulong>.Count * 2));
                Vector512<ulong> indices1 = Avx512F.Subtract(indices, vCount2);
                Vector512<ulong> mask = Avx512F.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector512<ulong> rt0 = Avx512F.PermuteVar8x64x2(vector0, indices, vector1);
                Vector512<ulong> rt1 = Avx512F.PermuteVar8x64(vector2, indices1);
                Vector512<ulong> rt = ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3) {
                YShuffleX3Kernel_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3) {
                Vector512<byte> vCount2 = Vector512.Create((byte)(Vector512<byte>.Count * 2));
                Vector512<byte> indices1 = Avx512BW.Subtract(indices, vCount2);
                Vector512<byte> mask = Avx512BW.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                args0 = indices;
                args1 = indices1;
                args2 = mask;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3) {
                YShuffleX3Kernel_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3) {
                Vector512<ushort> vCount2 = Vector512.Create((ushort)(Vector512<ushort>.Count * 2));
                Vector512<ushort> indices1 = Avx512BW.Subtract(indices, vCount2);
                Vector512<ushort> mask = Avx512BW.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                args0 = indices;
                args1 = indices1;
                args2 = mask;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3) {
                YShuffleX3Kernel_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3) {
                Vector512<uint> vCount2 = Vector512.Create((uint)(Vector512<uint>.Count * 2));
                Vector512<uint> indices1 = Avx512F.Subtract(indices, vCount2);
                Vector512<uint> mask = Avx512F.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                args0 = indices;
                args1 = indices1;
                args2 = mask;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3) {
                YShuffleX3Kernel_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3) {
                Vector512<ulong> vCount2 = Vector512.Create((ulong)(Vector512<ulong>.Count * 2));
                Vector512<ulong> indices1 = Avx512F.Subtract(indices, vCount2);
                Vector512<ulong> mask = Avx512F.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                args0 = indices;
                args1 = indices1;
                args2 = mask;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3Kernel_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
                _ = args3;
                Vector512<float> rt0 = Avx512F.PermuteVar16x32x2(vector0, args0, vector1);
                Vector512<float> rt1 = Avx512F.PermuteVar16x32(vector2, args1);
                Vector512<float> rt = ConditionalSelect(args2.AsSingle(), rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3Kernel_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
                _ = args3;
                Vector512<double> rt0 = Avx512F.PermuteVar8x64x2(vector0, args0, vector1);
                Vector512<double> rt1 = Avx512F.PermuteVar8x64(vector2, args1);
                Vector512<double> rt = ConditionalSelect(args2.AsDouble(), rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3Kernel_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) {
                return YShuffleX3Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3Kernel_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) {
                _ = args3;
                Vector512<byte> rt0 = Avx512Vbmi.PermuteVar64x8x2(vector0, args0, vector1);
                Vector512<byte> rt1 = Avx512Vbmi.PermuteVar64x8(vector2, args1);
                Vector512<byte> rt = ConditionalSelect(args2, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3Kernel_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) {
                return YShuffleX3Kernel_Core(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3Kernel_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) {
                _ = args3;
                Vector512<ushort> rt0 = Avx512BW.PermuteVar32x16x2(vector0, args0, vector1);
                Vector512<ushort> rt1 = Avx512BW.PermuteVar32x16(vector2, args1);
                Vector512<ushort> rt = ConditionalSelect(args2, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3Kernel_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
                return YShuffleX3Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3Kernel_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) {
                _ = args3;
                Vector512<uint> rt0 = Avx512F.PermuteVar16x32x2(vector0, args0, vector1);
                Vector512<uint> rt1 = Avx512F.PermuteVar16x32(vector2, args1);
                Vector512<uint> rt = ConditionalSelect(args2, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3Kernel_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
                return YShuffleX3Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3Kernel_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) {
                _ = args3;
                Vector512<ulong> rt0 = Avx512F.PermuteVar8x64x2(vector0, args0, vector1);
                Vector512<ulong> rt1 = Avx512F.PermuteVar8x64(vector2, args1);
                Vector512<ulong> rt = ConditionalSelect(args2, rt0, rt1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4_AcceleratedTypes {
                get {
                    return YShuffleX4Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
                const int total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector256<uint>.Count
                Vector512<float> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices).AsSingle(); // Unsigned compare: (i < 64)
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = Avx512DQ.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
                const long total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector256<ulong>.Count
                Vector512<double> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices).AsDouble(); // Unsigned compare: (i < 32)
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = Avx512DQ.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
                Vector512<sbyte> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
                //const byte total = 4 * ByteCountValue / sizeof(byte); // 4 * Vector512<byte>.Count // Number overflow
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
                return YShuffleX4(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
                const ushort total = 4 * ByteCountValue / sizeof(ushort); // 4 * Vector256<ushort>.Count
                Vector512<ushort> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
                return YShuffleX4(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
                const uint total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector256<uint>.Count
                Vector512<uint> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
                return YShuffleX4(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
                const ulong total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector256<ulong>.Count
                Vector512<ulong> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = Avx512F.And(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512BW.CompareGreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Vector512<byte>.AllBitsSet;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
                YShuffleX4_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
                args4 = a4.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
                const ushort total = 4 * ByteCountValue / sizeof(ushort); // 4 * Vector256<ushort>.Count
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
                YShuffleX4_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
                args4 = a4.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
                const uint total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector256<uint>.Count
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
                YShuffleX4_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3, out var a4);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
                args4 = a4.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
                const ulong total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector256<ulong>.Count
                YShuffleX4Kernel_Args(indices, out args0, out args1, out args2, out args3);
                args4 = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                Vector512<float> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = Avx512DQ.And(rt, args4.AsSingle());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                Vector512<double> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = Avx512DQ.And(rt, args4.AsDouble());
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
                Vector512<sbyte> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = Avx512F.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
                Vector512<byte> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
                return YShuffleX4_Core(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
                Vector512<ushort> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = Avx512F.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                return YShuffleX4_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
                Vector512<uint> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = Avx512F.And(rt, args4);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                return YShuffleX4_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
                Vector512<ulong> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = Avx512F.And(rt, args4);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Insert_AcceleratedTypes {
                get {
                    return YShuffleX4Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4Insert(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
                //return YShuffleX4Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
                const int total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector256<uint>.Count
                Vector512<float> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices).AsSingle(); // Unsigned compare: (i < 64)
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4Insert(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
                //return YShuffleX4Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
                const long total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector256<ulong>.Count
                Vector512<double> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices).AsDouble(); // Unsigned compare: (i < 32)
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4Insert(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
                Vector512<sbyte> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4Insert(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
                //const byte total = 4 * ByteCountValue / sizeof(byte); // 4 * Vector512<byte>.Count // Number overflow
                _ = back;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4Insert(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
                return YShuffleX4Insert(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4Insert(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
                const ushort total = 4 * ByteCountValue / sizeof(ushort); // 4 * Vector256<ushort>.Count
                Vector512<ushort> mask, raw, rt;
                mask = Avx512BW.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4Insert(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
                return YShuffleX4Insert(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4Insert(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
                const uint total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector256<uint>.Count
                Vector512<uint> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4Insert(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
                return YShuffleX4Insert(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4Insert(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
                const ulong total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector256<ulong>.Count
                Vector512<ulong> mask, raw, rt;
                mask = Avx512F.CompareGreaterThan(Vector512.Create(total), indices);
                raw = YShuffleX4Kernel(vector0, vector1, vector2, vector3, indices);
                rt = ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
                YShuffleX4_Args(indices, out args0, out args1, out args2, out args3, out args4);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4Insert_Core(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                Vector512<float> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = ConditionalSelect(args4.AsSingle(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4Insert_Core(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                Vector512<double> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = ConditionalSelect(args4.AsDouble(), rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4Insert_Core(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
                Vector512<sbyte> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4Insert_Core(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
                Vector512<byte> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                _ = args4;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4Insert_Core(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
                return YShuffleX4Insert_Core(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16(), args4.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4Insert_Core(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
                Vector512<ushort> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4Insert_Core(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                return YShuffleX4Insert_Core(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32(), args4.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4Insert_Core(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
                Vector512<uint> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = ConditionalSelect(args4, rt, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4Insert_Core(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                return YShuffleX4Insert_Core(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64(), args4.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4Insert_Core(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
                Vector512<ulong> rt = YShuffleX4Kernel_Core(vector0, vector1, vector2, vector3, args0, args1, args2, args3);
                rt = ConditionalSelect(args4, rt, back);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlagsUtil.IntTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4Kernel(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
                //return YShuffleX4Kernel(vector0.AsInt32(), vector1.AsInt32(), vector2.AsInt32(), vector3.AsInt32(), indices).AsSingle();
                Vector512<int> vCount2 = Vector512.Create((int)(Vector512<float>.Count * 2));
                Vector512<int> indices1 = Avx512F.Subtract(indices, vCount2);
                Vector512<float> mask = Avx512F.CompareGreaterThan(vCount2, indices).AsSingle(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector512<float> rt0 = Avx512F.PermuteVar16x32x2(vector0, indices, vector1);
                Vector512<float> rt1 = Avx512F.PermuteVar16x32x2(vector2, indices1, vector3);
                Vector512<float> rt = ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4Kernel(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
                //return YShuffleX4Kernel(vector0.AsInt64(), vector1.AsInt64(), vector2.AsInt64(), vector3.AsInt64(), indices).AsDouble();
                Vector512<long> vCount2 = Vector512.Create((long)(Vector512<long>.Count * 2));
                Vector512<long> indices1 = Avx512F.Subtract(indices, vCount2);
                Vector512<double> mask = Avx512F.CompareGreaterThan(vCount2, indices).AsDouble(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector512<double> rt0 = Avx512F.PermuteVar8x64x2(vector0, indices, vector1);
                Vector512<double> rt1 = Avx512F.PermuteVar8x64x2(vector2, indices1, vector3);
                Vector512<double> rt = ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4Kernel(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
                return YShuffleX4Kernel(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4Kernel(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
                Vector512<byte> vCount2 = Vector512.Create((byte)(Vector512<byte>.Count * 2));
                Vector512<byte> indices1 = Avx512BW.Subtract(indices, vCount2);
                Vector512<byte> mask = Avx512BW.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector512<byte> rt0 = Avx512Vbmi.PermuteVar64x8x2(vector0, indices, vector1);
                Vector512<byte> rt1 = Avx512Vbmi.PermuteVar64x8x2(vector2, indices1, vector3);
                Vector512<byte> rt = ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4Kernel(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
                return YShuffleX4Kernel(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4Kernel(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
                Vector512<ushort> vCount2 = Vector512.Create((ushort)(Vector512<ushort>.Count * 2));
                Vector512<ushort> indices1 = Avx512BW.Subtract(indices, vCount2);
                Vector512<ushort> mask = Avx512BW.CompareGreaterThan(vCount2, indices).AsUInt16(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector512<ushort> rt0 = Avx512BW.PermuteVar32x16x2(vector0, indices, vector1);
                Vector512<ushort> rt1 = Avx512BW.PermuteVar32x16x2(vector2, indices1, vector3);
                Vector512<ushort> rt = ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4Kernel(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
                return YShuffleX4Kernel(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4Kernel(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
                Vector512<uint> vCount2 = Vector512.Create((uint)(Vector512<uint>.Count * 2));
                Vector512<uint> indices1 = Avx512F.Subtract(indices, vCount2);
                Vector512<uint> mask = Avx512F.CompareGreaterThan(vCount2, indices).AsUInt32(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector512<uint> rt0 = Avx512F.PermuteVar16x32x2(vector0, indices, vector1);
                Vector512<uint> rt1 = Avx512F.PermuteVar16x32x2(vector2, indices1, vector3);
                Vector512<uint> rt = ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4Kernel(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
                return YShuffleX4Kernel(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4Kernel(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
                Vector512<ulong> vCount2 = Vector512.Create((ulong)(Vector512<ulong>.Count * 2));
                Vector512<ulong> indices1 = Avx512F.Subtract(indices, vCount2);
                Vector512<ulong> mask = Avx512F.CompareGreaterThan(vCount2, indices).AsUInt64(); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                Vector512<ulong> rt0 = Avx512F.PermuteVar8x64x2(vector0, indices, vector1);
                Vector512<ulong> rt1 = Avx512F.PermuteVar8x64x2(vector2, indices1, vector3);
                Vector512<ulong> rt = ConditionalSelect(mask, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3) {
                YShuffleX4Kernel_Args(indices.AsByte(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
                args3 = a3.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3) {
                Vector512<byte> vCount2 = Vector512.Create((byte)(Vector512<byte>.Count * 2));
                Vector512<byte> indices1 = Avx512BW.Subtract(indices, vCount2);
                Vector512<byte> mask = Avx512BW.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                args0 = indices;
                args1 = indices1;
                args2 = mask;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3) {
                YShuffleX4Kernel_Args(indices.AsUInt16(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
                args3 = a3.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3) {
                Vector512<ushort> vCount2 = Vector512.Create((ushort)(Vector512<ushort>.Count * 2));
                Vector512<ushort> indices1 = Avx512BW.Subtract(indices, vCount2);
                Vector512<ushort> mask = Avx512BW.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                args0 = indices;
                args1 = indices1;
                args2 = mask;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3) {
                YShuffleX4Kernel_Args(indices.AsUInt32(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
                args3 = a3.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3) {
                Vector512<uint> vCount2 = Vector512.Create((uint)(Vector512<uint>.Count * 2));
                Vector512<uint> indices1 = Avx512F.Subtract(indices, vCount2);
                Vector512<uint> mask = Avx512F.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                args0 = indices;
                args1 = indices1;
                args2 = mask;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3) {
                YShuffleX4Kernel_Args(indices.AsUInt64(), out var a0, out var a1, out var a2, out var a3);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
                args3 = a3.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3) {
                Vector512<ulong> vCount2 = Vector512.Create((ulong)(Vector512<ulong>.Count * 2));
                Vector512<ulong> indices1 = Avx512F.Subtract(indices, vCount2);
                Vector512<ulong> mask = Avx512F.CompareGreaterThan(vCount2, indices); // vCount2[i]>indices[i] ==> indices[i]<vCount2[i].
                args0 = indices;
                args1 = indices1;
                args2 = mask;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4Kernel_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
                _ = args3;
                Vector512<float> rt0 = Avx512F.PermuteVar16x32x2(vector0, args0, vector1);
                Vector512<float> rt1 = Avx512F.PermuteVar16x32x2(vector2, args1, vector3);
                Vector512<float> rt = ConditionalSelect(args2.AsSingle(), rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4Kernel_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
                _ = args3;
                Vector512<double> rt0 = Avx512F.PermuteVar8x64x2(vector0, args0, vector1);
                Vector512<double> rt1 = Avx512F.PermuteVar8x64x2(vector2, args1, vector3);
                Vector512<double> rt = ConditionalSelect(args2.AsDouble(), rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4Kernel_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) {
                return YShuffleX4Kernel_Core(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte(), args3.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4Kernel_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) {
                _ = args3;
                Vector512<byte> rt0 = Avx512Vbmi.PermuteVar64x8x2(vector0, args0, vector1);
                Vector512<byte> rt1 = Avx512Vbmi.PermuteVar64x8x2(vector2, args1, vector3);
                Vector512<byte> rt = ConditionalSelect(args2, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4Kernel_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) {
                return YShuffleX4Kernel_Core(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16(), args3.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4Kernel_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) {
                _ = args3;
                Vector512<ushort> rt0 = Avx512BW.PermuteVar32x16x2(vector0, args0, vector1);
                Vector512<ushort> rt1 = Avx512BW.PermuteVar32x16x2(vector2, args1, vector3);
                Vector512<ushort> rt = ConditionalSelect(args2, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4Kernel_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
                return YShuffleX4Kernel_Core(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32(), args3.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4Kernel_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) {
                _ = args3;
                Vector512<uint> rt0 = Avx512F.PermuteVar16x32x2(vector0, args0, vector1);
                Vector512<uint> rt1 = Avx512F.PermuteVar16x32x2(vector2, args1, vector3);
                Vector512<uint> rt = ConditionalSelect(args2, rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4Kernel_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
                return YShuffleX4Kernel_Core(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64(), args3.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4Kernel_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) {
                _ = args3;
                Vector512<ulong> rt0 = Avx512F.PermuteVar8x64x2(vector0, args0, vector1);
                Vector512<ulong> rt1 = Avx512F.PermuteVar8x64x2(vector2, args1, vector3);
                Vector512<ulong> rt = ConditionalSelect(args2, rt0, rt1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YSign_AcceleratedTypes"/>
            public static TypeCodeFlags YSign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YSign(Vector512<float> value) {
                Vector512<float> zero = Vector512<float>.Zero;
                Vector512<int> m = LessThan(value, zero).AsInt32();
                Vector512<int> n = GreaterThan(value, zero).AsInt32();
                Vector512<int> rt = Avx512F.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YSign(Vector512<double> value) {
                Vector512<double> zero = Vector512<double>.Zero;
                Vector512<long> m = LessThan(value, zero).AsInt64();
                Vector512<long> n = GreaterThan(value, zero).AsInt64();
                Vector512<long> rt = Avx512F.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YSign(Vector512<sbyte> value) {
                Vector512<sbyte> zero = Vector512<sbyte>.Zero;
                Vector512<sbyte> m = LessThan(value, zero);
                Vector512<sbyte> n = GreaterThan(value, zero);
                Vector512<sbyte> rt = Avx512BW.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YSign(Vector512<short> value) {
                Vector512<short> zero = Vector512<short>.Zero;
                Vector512<short> m = LessThan(value, zero);
                Vector512<short> n = GreaterThan(value, zero);
                Vector512<short> rt = Avx512BW.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YSign(Vector512<int> value) {
                Vector512<int> zero = Vector512<int>.Zero;
                Vector512<int> m = LessThan(value, zero);
                Vector512<int> n = GreaterThan(value, zero);
                Vector512<int> rt = Avx512F.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YSign(Vector512<long> value) {
                Vector512<long> zero = Vector512<long>.Zero;
                Vector512<long> m = LessThan(value, zero);
                Vector512<long> n = GreaterThan(value, zero);
                Vector512<long> rt = Avx512F.Subtract(m, n);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YSignFloat_AcceleratedTypes"/>
            public static TypeCodeFlags YSignFloat_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    rt |= (TypeCodeFlags.Single) & YIsNaN_AcceleratedTypes & ConvertToSingle_AcceleratedTypes;
                    rt |= (TypeCodeFlags.Double) & YIsNaN_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YSignFloat(Vector512<float> value) {
                Vector512<int> signVal = YSign(value);
                Vector512<float> nanMask = YIsNaN(value).AsSingle();
                Vector512<float> rt = ConvertToSingle(signVal);
                rt = BitwiseOr(rt, BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YSignFloat(Vector512<double> value) {
                return YSignFloat_Compare(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YSignFloat_Compare(Vector512<double> value) {
                Vector512<double> negativeOne = Vector512.Create(-1.0);
                Vector512<double> zero = Vector512<double>.Zero;
                Vector512<double> one = Vector512.Create(1.0);
                Vector512<double> rt = BitwiseAnd(LessThan(value, zero), negativeOne);
                Vector512<double> nanMask = YIsNaN(value).AsDouble();
                rt = BitwiseOr(rt, BitwiseAnd(GreaterThan(value, zero), one)); // rt = ConvertToDouble(YSign(value));
                rt = BitwiseOr(rt, BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YSignFloat_Convert(Vector512<double> value) {
                Vector512<long> signVal = YSign(value);
                Vector512<double> nanMask = YIsNaN(value).AsDouble();
                Vector512<double> rt = ConvertToDouble_Range52(signVal);
                rt = BitwiseOr(rt, BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

#endif // NET8_0_OR_GREATER
        }
    }
}
