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
                Vector256<byte> indices = Vector256Constants.YShuffleG2_Byte_Indices[(int)control]; // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
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
                Vector256<byte> indices = Vector256Constants.YShuffleG2_UInt16_ByteIndices[(int)control].AsByte(); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
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
                Vector256<byte> indices = Vector256Constants.YShuffleG2_UInt32_ByteIndices[(int)control].AsByte(); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
                return Avx2.Shuffle(source.AsByte(), indices).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG2_UInt32(Vector256<uint> source, ShuffleControlG2 control) {
                Vector256<int> indices = Vector256Constants.YShuffleG2_UInt32_Indices[(int)control].AsInt32(); // It also supports _mm256_permutevar_ps for 128-bit lanes .
                return Avx.PermuteVar(source.AsSingle(), indices).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleG2(Vector256<long> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleG2(Vector256<ulong> source, ShuffleControlG2 control) {
                Vector256<byte> indices = Vector256Constants.YShuffleG2_UInt64_ByteIndices[(int)control].AsByte(); // It also supports _mm256_shuffle_epi8 for 128-bit lanes .
                return Avx2.Shuffle(source.AsByte(), indices).AsUInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleG2_Const(Vector256<float> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleG2_Const(Vector256<double> source, [ConstantExpected] ShuffleControlG2 control) {
                byte ctl = (byte)((byte)control * 5);
                return Avx.Shuffle(source, source, ctl);
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
                return YShuffleG2_Const(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YShuffleG2_Const(Vector256<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
                byte n = (byte)control;
                byte ctl = (byte)(0xA0 + (n & 2) * 0x22 + (n & 1) * 0x11); // ShuffleControlG2 to ShuffleControlG4
                return Avx2.ShuffleHigh(Avx2.ShuffleLow(source, ctl), ctl);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleG2_Const(Vector256<int> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YShuffleG2_Const(Vector256<uint> source, [ConstantExpected] ShuffleControlG2 control) {
                byte n = (byte)control;
                byte ctl = (byte)(0xA0 + (n & 2) * 0x22 + (n & 1) * 0x11); // ShuffleControlG2 to ShuffleControlG4
                return Avx2.Shuffle(source, ctl);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YShuffleG2_Const(Vector256<long> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YShuffleG2_Const(Vector256<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2_Const(source.AsDouble(), control).AsUInt64();
                //// _mm256_permute4x64_epi64
                // byte n = (byte)control;
                //byte ctl = (byte)(0xA0 + (n & 2) * 0x22 + (n & 1) * 0x11); // ShuffleControlG2 to ShuffleControlG4
                //return Avx2.Permute4x64(source, ctl);
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
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{double}, Vector256{double}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleInsert(Vector256<double> back, Vector256<double> vector, Vector256<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsDouble();
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
                return YShuffleInsert_Cmp2(back, vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleInsert_Add1(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
                Vector256<byte> mask = Avx2.CompareGreaterThan(
                    Vector256.Create((sbyte)(32 + sbyte.MinValue)),
                    Avx2.Add(indices.AsSByte(), Vector256s<sbyte>.MinValue)
                ).AsByte(); // Unsigned compare: (i < 32)
                Vector256<byte> raw = YShuffleKernel(vector, indices);
                Vector256<byte> rt = Avx2.BlendVariable(back, raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleInsert_Add2(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
                Vector256<byte> mask = GreaterThan(Vector256.Create((byte)32), indices);
                Vector256<byte> raw = YShuffleKernel(vector, indices);
                Vector256<byte> rt = Avx2.BlendVariable(back, raw, mask);
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
                Vector256<byte> rt = Avx2.BlendVariable(back, raw, mask);
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
                Vector256<ushort> mask = Avx2.AndNot(
                    Avx2.CompareGreaterThan(Vector256<short>.Zero, indices.AsInt16()),
                    Avx2.CompareGreaterThan(Vector256.Create((short)16), indices.AsInt16())
                ).AsUInt16(); // (0<=i && i<16)
                Vector256<ushort> raw = YShuffleKernel(vector, indices);
                Vector256<ushort> rt = Avx2.BlendVariable(back, raw, mask);
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
                Vector256<uint> mask = Avx2.AndNot(
                    Avx2.CompareGreaterThan(Vector256<int>.Zero, indices.AsInt32()),
                    Avx2.CompareGreaterThan(Vector256.Create((int)8), indices.AsInt32())
                ).AsUInt32(); // (0<=i && i<8)
                Vector256<uint> raw = YShuffleKernel(vector, indices);
                Vector256<uint> rt = Avx2.BlendVariable(back, raw, mask);
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
                Vector256<ulong> mask = Avx2.AndNot(
                    Avx2.CompareGreaterThan(Vector256<long>.Zero, indices.AsInt64()),
                    Avx2.CompareGreaterThan(Vector256.Create((long)4), indices.AsInt64())
                ).AsUInt64(); // (0<=i && i<4)
                Vector256<ulong> raw = YShuffleKernel(vector, indices);
                Vector256<ulong> rt = Avx2.BlendVariable(back, raw, mask);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}))"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2) {
                YShuffleInsert_Args(indices.AsByte(), out var a0, out var a1, out var a2);
                args0 = a0.AsSByte();
                args1 = a1.AsSByte();
                args2 = a2.AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte}))"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2) {
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = Avx2.AndNot(
                    Avx2.CompareGreaterThan(Vector256<sbyte>.Zero, indices.AsSByte()),
                    Avx2.CompareGreaterThan(Vector256.Create((sbyte)32), indices.AsSByte())
                ).AsByte(); // (0<=i && i<32)
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short}))"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2) {
                YShuffleInsert_Args(indices.AsUInt16(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt16();
                args1 = a1.AsInt16();
                args2 = a2.AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}))"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2) {
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = Avx2.AndNot(
                    Avx2.CompareGreaterThan(Vector256<short>.Zero, indices.AsInt16()),
                    Avx2.CompareGreaterThan(Vector256.Create((short)16), indices.AsInt16())
                ).AsUInt16(); // (0<=i && i<16)
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int}))"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2) {
                YShuffleInsert_Args(indices.AsUInt32(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt32();
                args1 = a1.AsInt32();
                args2 = a2.AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint}))"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2) {
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = Avx2.AndNot(
                    Avx2.CompareGreaterThan(Vector256<int>.Zero, indices.AsInt32()),
                    Avx2.CompareGreaterThan(Vector256.Create((int)8), indices.AsInt32())
                ).AsUInt32(); // (0<=i && i<8)
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long}))"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2) {
                YShuffleInsert_Args(indices.AsUInt64(), out var a0, out var a1, out var a2);
                args0 = a0.AsInt64();
                args1 = a1.AsInt64();
                args2 = a2.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}))"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2) {
                YShuffleKernel_Args(indices, out args0, out args1);
                args2 = Avx2.AndNot(
                    Avx2.CompareGreaterThan(Vector256<long>.Zero, indices.AsInt64()),
                    Avx2.CompareGreaterThan(Vector256.Create((long)4), indices.AsInt64())
                ).AsUInt64(); // (0<=i && i<4)
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleInsert_Core(Vector256<float> back, Vector256<float> vector, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) {
                return YShuffleInsert_Core(back.AsUInt32(), vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleInsert_Core(Vector256<double> back, Vector256<double> vector, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) {
                return YShuffleInsert_Core(back.AsUInt64(), vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64()).AsDouble();
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
                var rt = Avx2.BlendVariable(back, raw, args2);
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
                var rt = Avx2.BlendVariable(back, raw, args2);
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
                var rt = Avx2.BlendVariable(back, raw, args2);
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
                var rt = Avx2.BlendVariable(back, raw, args2);
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
                return YShuffleKernel_ByteAdd(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YShuffleKernel_ByteAdd(Vector256<byte> vector, Vector256<byte> indices) {
                // Shuffle elements of __m256i vector
                // https://stackoverflow.com/questions/30669556/shuffle-elements-of-m256i-vector
                // ErmIg answered Jun 5, 2015 at 14:54
                return Avx2.Or(
                    Avx2.Shuffle(vector, Avx2.Add(indices, Vector256Constants.Shuffle_Byte_LaneAdd_K0)),
                    Avx2.Shuffle(Avx2.Permute4x64(vector.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(), Avx2.Add(indices, Vector256Constants.Shuffle_Byte_LaneAdd_K1))
                );
                // Remark: The value of each element must be less than count
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
                Vector256<uint> temp = Avx.DuplicateEvenIndexed(indices.AsSingle()).AsUInt32();
                temp = Avx2.ShiftLeftLogical(temp, 1); // n*2 = n << 1;
                args0 = Avx2.Add(temp, Vector256Constants.Shuffle_UInt64_UInt32Offset).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YShuffleKernel_Core(Vector256<float> vector, Vector256<int> args0, Vector256<int> args1) {
                return YShuffleKernel_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YShuffleKernel_Core(Vector256<double> vector, Vector256<long> args0, Vector256<long> args1) {
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
                return Avx2.Or(
                    Avx2.Shuffle(vector, args0),
                    Avx2.Shuffle(Avx2.Permute4x64(vector.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(), args1)
                );
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
                return YShuffleKernel_Core(vector.AsByte(), args0.AsByte(), args1.AsByte()).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YShuffleKernel_Core(Vector256<int> vector, Vector256<int> args0, Vector256<int> args1) {
                return YShuffleKernel_Core(vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32()).AsInt32();
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
                return Avx2.PermuteVar8x32(vector.AsUInt32(), args0.AsUInt32()).AsUInt64();
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
