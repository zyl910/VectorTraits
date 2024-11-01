#define VECTOR_HAS_METHOD
#if NETX_0_OR_GREATER
#define BCL_HAS_SHUFFLE
#endif // NETX_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Impl.AVector {

    partial class VectorTraitsBase {

        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG2_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG2(Vector<float> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG2(Vector<double> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG2(Vector<sbyte> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG2(Vector<byte> source, ShuffleControlG2 control) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.Shuffle(source, VectorConstants.YShuffleG2_Byte_Indices[(int)control]);
#else
                return YShuffleG2_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG2(Vector<short> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG2(Vector<ushort> source, ShuffleControlG2 control) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.Shuffle(source.AsByte(), VectorConstants.YShuffleG2_UInt16_ByteIndices[(int)control]).AsUInt16();
#else
                return YShuffleG2_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG2(Vector<int> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG2(Vector<uint> source, ShuffleControlG2 control) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.Shuffle(source.AsByte(), VectorConstants.YShuffleG2_UInt32_ByteIndices[(int)control]).AsUInt32();
#else
                return YShuffleG2_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG2(Vector<long> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG2(Vector<ulong> source, ShuffleControlG2 control) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.Shuffle(source.AsByte(), VectorConstants.YShuffleG2_UInt64_ByteIndices[(int)control]).AsUInt64();
#else
                return YShuffleG2_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG2_Basic(Vector<float> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG2_Basic(Vector<double> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG2_Basic(Vector<sbyte> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG2_Basic(Vector<byte> source, ShuffleControlG2 control) {
                Unsafe.SkipInit(out Vector<byte> rt);
                ref byte q = ref Unsafe.As<Vector<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG2_Basic(Vector<short> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG2_Basic(Vector<ushort> source, ShuffleControlG2 control) {
                Unsafe.SkipInit(out Vector<ushort> rt);
                ref ushort q = ref Unsafe.As<Vector<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG2_Basic(Vector<int> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG2_Basic(Vector<uint> source, ShuffleControlG2 control) {
                Unsafe.SkipInit(out Vector<uint> rt);
                ref uint q = ref Unsafe.As<Vector<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector<uint>, uint>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG2_Basic(Vector<long> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG2_Basic(Vector<ulong> source, ShuffleControlG2 control) {
                Unsafe.SkipInit(out Vector<ulong> rt);
                ref ulong q = ref Unsafe.As<Vector<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector<ulong>, ulong>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG2_Const(Vector<float> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG2_Const(Vector<double> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG2_Const(Vector<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG2_Const(Vector<byte> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG2_Const(Vector<short> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG2_Const(Vector<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG2_Const(Vector<int> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG2_Const(Vector<uint> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG2_Const(Vector<long> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2_Const(Vector{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG2_Const(Vector<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }
#endif // !REDUCE_MEMORY_USAGE


            /// <inheritdoc cref="IVectorTraits.YShuffleG4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4(Vector<float> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4(Vector<double> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4(Vector<sbyte> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4(Vector<byte> source, ShuffleControlG4 control) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.Shuffle(source, VectorConstants.YShuffleG4_Byte_Indices[(int)control]);
#else
                return YShuffleG4_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4(Vector<short> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4(Vector<ushort> source, ShuffleControlG4 control) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.Shuffle(source.AsByte(), VectorConstants.YShuffleG4_UInt16_ByteIndices[(int)control]).AsUInt16();
#else
                return YShuffleG4_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4(Vector<int> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4(Vector<uint> source, ShuffleControlG4 control) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.Shuffle(source.AsByte(), VectorConstants.YShuffleG4_UInt32_ByteIndices[(int)control]).AsUInt32();
#else
                return YShuffleG4_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG4(Vector<long> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4(Vector<ulong> source, ShuffleControlG4 control) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                return Vector.Shuffle(source.AsByte(), VectorConstants.YShuffleG4_UInt64_ByteIndices[(int)control]).AsUInt64();
#else
                return YShuffleG4_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4_Basic(Vector<float> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4_Basic(Vector<double> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4_Basic(Vector<sbyte> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4_Basic(Vector<byte> source, ShuffleControlG4 control) {
                Unsafe.SkipInit(out Vector<byte> rt);
                ref byte q = ref Unsafe.As<Vector<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4_Basic(Vector<short> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4_Basic(Vector<ushort> source, ShuffleControlG4 control) {
                Unsafe.SkipInit(out Vector<ushort> rt);
                ref ushort q = ref Unsafe.As<Vector<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4_Basic(Vector<int> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4_Basic(Vector<uint> source, ShuffleControlG4 control) {
                Unsafe.SkipInit(out Vector<uint> rt);
                ref uint q = ref Unsafe.As<Vector<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector<uint>, uint>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG4_Basic(Vector<long> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4_Basic(Vector<ulong> source, ShuffleControlG4 control) {
                if (Vector<ulong>.Count < 4) {
                    throw new NotSupportedException(string.Format(VectorMessageFormats.FORMAT_YSHUFFLEG4_MUST4_1, Vector<ulong>.Count));
                }
                Unsafe.SkipInit(out Vector<ulong> rt);
                ref ulong q = ref Unsafe.As<Vector<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector<ulong>, ulong>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4_Const(Vector<float> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4_Const(Vector<double> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4_Const(Vector<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4_Const(Vector<byte> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4_Const(Vector<short> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4_Const(Vector<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4_Const(Vector<int> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4_Const(Vector<uint> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG4_Const(Vector<long> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4_Const(Vector{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4_Const(Vector<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if ((YShuffleKernel_AcceleratedTypes & TypeCodeFlags.Byte) != TypeCodeFlags.None) {
                        rt = TypeCodeFlagsUtil.AllTypes;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{float}, Vector{float}, ShuffleControlG4, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4X2(Vector<float> source0, Vector<float> source1, ShuffleControlG4 control, out Vector<float> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{double}, Vector{double}, ShuffleControlG4, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4X2(Vector<double> source0, Vector<double> source1, ShuffleControlG4 control, out Vector<double> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt64(), source1.AsUInt64(), control, out var rt1);
                result1 = rt1.AsDouble();
                return rt0.AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4X2(Vector<sbyte> source0, Vector<sbyte> source1, ShuffleControlG4 control, out Vector<sbyte> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4X2(Vector<byte> source0, Vector<byte> source1, ShuffleControlG4 control, out Vector<byte> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{short}, Vector{short}, ShuffleControlG4, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4X2(Vector<short> source0, Vector<short> source1, ShuffleControlG4 control, out Vector<short> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ushort}, Vector{ushort}, ShuffleControlG4, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4X2(Vector<ushort> source0, Vector<ushort> source1, ShuffleControlG4 control, out Vector<ushort> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{int}, Vector{int}, ShuffleControlG4, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4X2(Vector<int> source0, Vector<int> source1, ShuffleControlG4 control, out Vector<int> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{uint}, Vector{uint}, ShuffleControlG4, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4X2(Vector<uint> source0, Vector<uint> source1, ShuffleControlG4 control, out Vector<uint> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{long}, Vector{long}, ShuffleControlG4, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG4X2(Vector<long> source0, Vector<long> source1, ShuffleControlG4 control, out Vector<long> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt64(), source1.AsUInt64(), control, out var rt1);
                result1 = rt1.AsInt64();
                return rt0.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4X2(Vector<ulong> source0, Vector<ulong> source1, ShuffleControlG4 control, out Vector<ulong> result1) {
                return YShuffleG4X2_Basic(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4X2_Basic(Vector<ulong> source0, Vector<ulong> source1, ShuffleControlG4 control, out Vector<ulong> result1) {
                if (Vector<ulong>.Count >= 4) {
                    var rt0 = YShuffleG4(source0, control);
                    result1 = YShuffleG4(source1, control);
                    return rt0;
                }
                Unsafe.SkipInit(out (Vector<ulong> Result0, Vector<ulong> Result1) rt);
                ValueTuple<Vector<ulong>, Vector<ulong>> src = (source0, source1);
                ref ulong q = ref Unsafe.As<ValueTuple<Vector<ulong>, Vector<ulong>>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<ValueTuple<Vector<ulong>, Vector<ulong>>, ulong>(ref src);
                int ctl = (byte)control;
                for (int i = 0; i < 4; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                result1 = rt.Result1;
                return rt.Result0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{float}, Vector{float}, ShuffleControlG4, out Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4X2_Const(Vector<float> source0, Vector<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<float> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{double}, Vector{double}, ShuffleControlG4, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4X2_Const(Vector<double> source0, Vector<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<double> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4X2_Const(Vector<sbyte> source0, Vector<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<sbyte> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4X2_Const(Vector<byte> source0, Vector<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<byte> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{short}, Vector{short}, ShuffleControlG4, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4X2_Const(Vector<short> source0, Vector<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<short> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{ushort}, Vector{ushort}, ShuffleControlG4, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4X2_Const(Vector<ushort> source0, Vector<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ushort> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{int}, Vector{int}, ShuffleControlG4, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4X2_Const(Vector<int> source0, Vector<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<int> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{uint}, Vector{uint}, ShuffleControlG4, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4X2_Const(Vector<uint> source0, Vector<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<uint> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{long}, Vector{long}, ShuffleControlG4, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG4X2_Const(Vector<long> source0, Vector<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<long> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2_Const(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4X2_Const(Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ulong> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleInsert(Vector<float> back, Vector<float> vector, Vector<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleInsert(Vector<double> back, Vector<double> vector, Vector<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleInsert(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> indices) {
                return YShuffleInsert(back.AsByte(), vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleInsert(Vector<byte> back, Vector<byte> vector, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                Vector<byte> mask = Vector.GreaterThan(Vector.Create((byte)Vector<byte>.Count), indices);
                Vector<byte> raw = Vector.Shuffle(vector, indices);
                Vector<byte> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleInsert(Vector<short> back, Vector<short> vector, Vector<short> indices) {
                return YShuffleInsert(back.AsUInt16(), vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleInsert(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> indices) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                Vector<ushort> mask = Vector.GreaterThan(Vector.Create((ushort)Vector<ushort>.Count), indices);
                Vector<ushort> raw = Vector.Shuffle(vector, indices);
                Vector<ushort> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleInsert(Vector<int> back, Vector<int> vector, Vector<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleInsert(Vector<uint> back, Vector<uint> vector, Vector<uint> indices) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                Vector<uint> mask = Vector.GreaterThan(Vector.Create((uint)Vector<uint>.Count), indices);
                Vector<uint> raw = Vector.Shuffle(vector, indices);
                Vector<uint> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleInsert(Vector<long> back, Vector<long> vector, Vector<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleInsert(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> indices) {
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                Vector<ulong> mask = Vector.GreaterThan(Vector.Create((ulong)Vector<ulong>.Count), indices);
                Vector<ulong> raw = Vector.Shuffle(vector, indices);
                Vector<ulong> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleInsert_Basic(Vector<byte> back, Vector<byte> vector, Vector<byte> indices) {
                Unsafe.SkipInit(out Vector<byte> rt);
                byte cnt = (byte)Vector<byte>.Count;
                ref byte q = ref Unsafe.As<Vector<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref vector);
                ref byte pindices = ref Unsafe.As<Vector<byte>, byte>(ref indices);
                ref byte pback = ref Unsafe.As<Vector<byte>, byte>(ref back);
                for (nint i = 0; i < Vector<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleInsert_Basic(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> indices) {
                Unsafe.SkipInit(out Vector<ushort> rt);
                ushort cnt = (ushort)Vector<ushort>.Count;
                ref ushort q = ref Unsafe.As<Vector<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref vector);
                ref ushort pindices = ref Unsafe.As<Vector<ushort>, ushort>(ref indices);
                ref ushort pback = ref Unsafe.As<Vector<ushort>, ushort>(ref back);
                for (nint i = 0; i < Vector<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleInsert_Basic(Vector<uint> back, Vector<uint> vector, Vector<uint> indices) {
                Unsafe.SkipInit(out Vector<uint> rt);
                uint cnt = (uint)Vector<uint>.Count;
                ref uint q = ref Unsafe.As<Vector<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector<uint>, uint>(ref vector);
                ref uint pindices = ref Unsafe.As<Vector<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector<uint>, uint>(ref back);
                for (nint i = 0; i < Vector<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleInsert_Basic(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> indices) {
                Unsafe.SkipInit(out Vector<ulong> rt);
                ulong cnt = (ulong)Vector<ulong>.Count;
                ref ulong q = ref Unsafe.As<Vector<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector<ulong>, ulong>(ref vector);
                ref ulong pindices = ref Unsafe.As<Vector<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector<ulong>, ulong>(ref back);
                for (nint i = 0; i < Vector<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((byte)Vector<byte>.Count), indices.AsByte()).AsSByte();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((byte)Vector<byte>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((ushort)Vector<ushort>.Count), indices.AsUInt16()).AsInt16();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((ushort)Vector<ushort>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((uint)Vector<uint>.Count), indices.AsUInt32()).AsInt32();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((uint)Vector<uint>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((ulong)Vector<ulong>.Count), indices.AsUInt64()).AsInt64();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((ulong)Vector<ulong>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleInsert_Core(Vector<float> back, Vector<float> vector, Vector<int> args0, Vector<int> args1, Vector<int> args2) {
                return YShuffleInsert_Core(back.AsUInt32(), vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleInsert_Core(Vector<double> back, Vector<double> vector, Vector<long> args0, Vector<long> args1, Vector<long> args2) {
                return YShuffleInsert_Core(back.AsUInt64(), vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleInsert_Core(Vector<sbyte> back, Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2) {
                return YShuffleInsert_Core(back.AsByte(), vector.AsByte(), args0.AsByte(), args1.AsByte(), args2.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleInsert_Core(Vector<byte> back, Vector<byte> vector, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2) {
                _ = args1;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                var raw = Vector.Shuffle(vector, args0);
                var rt = Vector.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Basic(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleInsert_Core(Vector<short> back, Vector<short> vector, Vector<short> args0, Vector<short> args1, Vector<short> args2) {
                return YShuffleInsert_Core(back.AsUInt16(), vector.AsUInt16(), args0.AsUInt16(), args1.AsUInt16(), args2.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleInsert_Core(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2) {
                _ = args1;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                var raw = Vector.Shuffle(vector, args0);
                var rt = Vector.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Basic(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleInsert_Core(Vector<int> back, Vector<int> vector, Vector<int> args0, Vector<int> args1, Vector<int> args2) {
                return YShuffleInsert_Core(back.AsUInt32(), vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleInsert_Core(Vector<uint> back, Vector<uint> vector, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2) {
                _ = args1;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                var raw = Vector.Shuffle(vector, args0);
                var rt = Vector.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Basic(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleInsert_Core(Vector<long> back, Vector<long> vector, Vector<long> args0, Vector<long> args1, Vector<long> args2) {
                return YShuffleInsert_Core(back.AsUInt64(), vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleInsert_Core(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2) {
                _ = args1;
#if BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
                var raw = Vector.Shuffle(vector, args0);
                var rt = Vector.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Basic(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleKernel(Vector<float> vector, Vector<int> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleKernel(Vector<double> vector, Vector<long> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleKernel(Vector<sbyte> vector, Vector<sbyte> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleKernel(Vector<byte> vector, Vector<byte> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleKernel(Vector<short> vector, Vector<short> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleKernel(Vector<ushort> vector, Vector<ushort> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleKernel(Vector<int> vector, Vector<int> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleKernel(Vector<uint> vector, Vector<uint> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleKernel(Vector<long> vector, Vector<long> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleKernel(Vector<ulong> vector, Vector<ulong> indices) {
                return Shuffle(vector, indices);
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1) {
                args0 = indices;
                args1 = default;
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{float}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleKernel_Core(Vector<float> vector, Vector<int> args0, Vector<int> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{double}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleKernel_Core(Vector<double> vector, Vector<long> args0, Vector<long> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleKernel_Core(Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleKernel_Core(Vector<byte> vector, Vector<byte> args0, Vector<byte> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleKernel_Core(Vector<short> vector, Vector<short> args0, Vector<short> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleKernel_Core(Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleKernel_Core(Vector<int> vector, Vector<int> args0, Vector<int> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleKernel_Core(Vector<uint> vector, Vector<uint> args0, Vector<uint> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleKernel_Core(Vector<long> vector, Vector<long> args0, Vector<long> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleKernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleKernel_Core(Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2_AcceleratedTypes {
                get {
                    return YShuffleX2Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2(Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2(Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2(Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2(Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2(Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2_Basic(Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2_Basic(Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2_Basic(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2_Basic(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2_Basic(Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2_Basic(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2_Basic(Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2_Basic(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2_Basic(Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2_Basic(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2_Bit(Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
                return YShuffleX2_Bit(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2_Bit(Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
                return YShuffleX2_Bit(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2_Bit(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
                return YShuffleX2_Bit(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2_Bit(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
                byte total = (byte)(2 * Vector<byte>.Count);
                Vector<byte> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<byte> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector<byte> rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2_Bit(Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
                return YShuffleX2_Bit(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2_Bit(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
                ushort total = (ushort)(2 * Vector<ushort>.Count);
                Vector<ushort> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<ushort> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector<ushort> rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2_Bit(Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
                return YShuffleX2_Bit(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2_Bit(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
                uint total = (uint)(2 * Vector<uint>.Count);
                Vector<uint> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<uint> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector<uint> rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2_Bit(Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
                return YShuffleX2_Bit(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2_Bit(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
                ulong total = (ulong)(2 * Vector<ulong>.Count);
                Vector<ulong> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<ulong> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector<ulong> rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2_Core(Vector<float> vector0, Vector<float> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2_Core(Vector<double> vector0, Vector<double> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
                get {
                    return YShuffleX2Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2Insert(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2Insert(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2Insert(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2Insert(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2Insert(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2Insert(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2Insert(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2Insert(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2Insert(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2Insert(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
#else
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2Insert_Basic(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2Insert_Basic(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2Insert_Basic(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
                return YShuffleX2Insert_Basic(back.AsByte(), vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2Insert_Basic(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
                byte total = (byte)(2 * Vector<byte>.Count);
                Span<Vector<byte>> rt = stackalloc Vector<byte>[1];
                Span<Vector<byte>> temp = [vector0, vector1];
                Span<byte> p = MemoryMarshal.Cast<Vector<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector<byte>, byte>(ref indices);
                ref byte pback = ref Unsafe.As<Vector<byte>, byte>(ref back);
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2Insert_Basic(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2Insert_Basic(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
                ushort total = (ushort)(2 * Vector<ushort>.Count);
                Span<Vector<ushort>> rt = stackalloc Vector<ushort>[1];
                Span<Vector<ushort>> temp = [vector0, vector1];
                Span<ushort> p = MemoryMarshal.Cast<Vector<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector<ushort>, ushort>(ref indices);
                ref ushort pback = ref Unsafe.As<Vector<ushort>, ushort>(ref back);
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2Insert_Basic(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2Insert_Basic(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
                uint total = (uint)(2 * Vector<uint>.Count);
                Span<Vector<uint>> rt = stackalloc Vector<uint>[1];
                Span<Vector<uint>> temp = [vector0, vector1];
                Span<uint> p = MemoryMarshal.Cast<Vector<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector<uint>, uint>(ref back);
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2Insert_Basic(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2Insert_Basic(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
                ulong total = (ulong)(2 * Vector<ulong>.Count);
                Span<Vector<ulong>> rt = stackalloc Vector<ulong>[1];
                Span<Vector<ulong>> temp = [vector0, vector1];
                Span<ulong> p = MemoryMarshal.Cast<Vector<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector<ulong>, ulong>(ref back);
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2Insert_Bit(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2Insert_Bit(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2Insert_Bit(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
                return YShuffleX2Insert_Bit(back.AsByte(), vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2Insert_Bit(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
                byte total = (byte)(2 * Vector<byte>.Count);
                Vector<byte> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<byte> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector<byte> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2Insert_Bit(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2Insert_Bit(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
                ushort total = (ushort)(2 * Vector<ushort>.Count);
                Vector<ushort> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<ushort> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector<ushort> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2Insert_Bit(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2Insert_Bit(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
                uint total = (uint)(2 * Vector<uint>.Count);
                Vector<uint> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<uint> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector<uint> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2Insert_Bit(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2Insert_Bit(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
                ulong total = (ulong)(2 * Vector<ulong>.Count);
                Vector<ulong> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<ulong> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector<ulong> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2Kernel(Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2Kernel(Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2Kernel(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2Kernel(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2Kernel(Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2Kernel(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2Kernel(Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2Kernel(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2Kernel(Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2Kernel(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2Kernel_Basic(Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2Kernel_Basic(Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2Kernel_Basic(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2Kernel_Basic(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
                byte total = (byte)(2 * Vector<byte>.Count);
                Span<Vector<byte>> rt = stackalloc Vector<byte>[1];
                Span<Vector<byte>> temp = [vector0, vector1];
                Span<byte> p = MemoryMarshal.Cast<Vector<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector<byte>, byte>(ref indices);
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2Kernel_Basic(Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2Kernel_Basic(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
                ushort total = (ushort)(2 * Vector<ushort>.Count);
                Span<Vector<ushort>> rt = stackalloc Vector<ushort>[1];
                Span<Vector<ushort>> temp = [vector0, vector1];
                Span<ushort> p = MemoryMarshal.Cast<Vector<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector<ushort>, ushort>(ref indices);
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2Kernel_Basic(Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2Kernel_Basic(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
                uint total = (uint)(2 * Vector<uint>.Count);
                Span<Vector<uint>> rt = stackalloc Vector<uint>[1];
                Span<Vector<uint>> temp = [vector0, vector1];
                Span<uint> p = MemoryMarshal.Cast<Vector<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector<uint>, uint>(ref indices);
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2Kernel_Basic(Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2Kernel_Basic(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
                ulong total = (ulong)(2 * Vector<ulong>.Count);
                Span<Vector<ulong>> rt = stackalloc Vector<ulong>[1];
                Span<Vector<ulong>> temp = [vector0, vector1];
                Span<ulong> p = MemoryMarshal.Cast<Vector<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector<ulong>, ulong>(ref indices);
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2Kernel_Bit(Vector<float> vector0, Vector<float> vector1, Vector<int> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2Kernel_Bit(Vector<double> vector0, Vector<double> vector1, Vector<long> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2Kernel_Bit(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2Kernel_Bit(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> indices) {
                Vector<byte> vCount = Vector.Create((byte)Vector<byte>.Count);
                Vector<byte> indices1 = Vector.Subtract(indices, vCount);
                Vector<byte> rt0 = Vector.Shuffle(vector0, indices);
                Vector<byte> rt1 = Vector.Shuffle(vector1, indices1);
                Vector<byte> rt = Vector.BitwiseOr(rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2Kernel_Bit(Vector<short> vector0, Vector<short> vector1, Vector<short> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2Kernel_Bit(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> indices) {
                Vector<ushort> vCount = Vector.Create((ushort)Vector<ushort>.Count);
                Vector<ushort> indices1 = Vector.Subtract(indices, vCount);
                Vector<ushort> rt0 = Vector.Shuffle(vector0, indices);
                Vector<ushort> rt1 = Vector.Shuffle(vector1, indices1);
                Vector<ushort> rt = Vector.BitwiseOr(rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2Kernel_Bit(Vector<int> vector0, Vector<int> vector1, Vector<int> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2Kernel_Bit(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> indices) {
                Vector<uint> vCount = Vector.Create((uint)Vector<uint>.Count);
                Vector<uint> indices1 = Vector.Subtract(indices, vCount);
                Vector<uint> rt0 = Vector.Shuffle(vector0, indices);
                Vector<uint> rt1 = Vector.Shuffle(vector1, indices1);
                Vector<uint> rt = Vector.BitwiseOr(rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2Kernel_Bit(Vector<long> vector0, Vector<long> vector1, Vector<long> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2Kernel_Bit(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> indices) {
                Vector<ulong> vCount = Vector.Create((ulong)Vector<ulong>.Count);
                Vector<ulong> indices1 = Vector.Subtract(indices, vCount);
                Vector<ulong> rt0 = Vector.Shuffle(vector0, indices);
                Vector<ulong> rt1 = Vector.Shuffle(vector1, indices1);
                Vector<ulong> rt = Vector.BitwiseOr(rt0, rt1);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX2Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX2Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX2Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX2Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX2Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX2Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX2Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX2Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX2Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX2Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX2Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX3_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3_AcceleratedTypes {
                get {
                    return YShuffleX3Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3_Basic(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3_Basic(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3_Basic(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
                Vector<sbyte> mask, raw, rt;
                mask = Vector.GreaterThanOrEqual(indices, Vector<sbyte>.Zero); // i >= 0
                raw = YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
                rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3_Basic(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3_Basic(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3_Basic(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3_Basic(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3_Basic(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3_Basic(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3_Basic(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3_Bit(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
                return YShuffleX3_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3_Bit(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
                return YShuffleX3_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3_Bit(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
                Vector<sbyte> mask, raw, rt;
                mask = Vector.GreaterThanOrEqual(indices, Vector<sbyte>.Zero); // i >= 0
                raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3_Bit(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
                byte total = (byte)(3 * Vector<byte>.Count);
                Vector<byte> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<byte> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector<byte> rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3_Bit(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
                return YShuffleX3_Bit(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3_Bit(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
                ushort total = (ushort)(3 * Vector<ushort>.Count);
                Vector<ushort> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<ushort> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector<ushort> rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3_Bit(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
                return YShuffleX3_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3_Bit(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
                uint total = (uint)(3 * Vector<uint>.Count);
                Vector<uint> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<uint> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector<uint> rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3_Bit(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
                return YShuffleX3_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3_Bit(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
                ulong total = (ulong)(3 * Vector<ulong>.Count);
                Vector<ulong> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<ulong> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector<ulong> rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Insert_AcceleratedTypes {
                get {
                    return YShuffleX3Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3Insert(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3Insert(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3Insert(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3Insert(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3Insert(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3Insert(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3Insert(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3Insert(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3Insert(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3Insert(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3Insert_Basic(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3Insert_Basic(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3Insert_Basic(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
                Vector<sbyte> mask, raw, rt;
                mask = Vector.GreaterThanOrEqual(indices, Vector<sbyte>.Zero); // i >= 0
                raw = YShuffleX3Insert_Basic(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
                rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3Insert_Basic(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
                byte total = (byte)(3 * Vector<byte>.Count);
                Span<Vector<byte>> rt = stackalloc Vector<byte>[1];
                Span<Vector<byte>> temp = [vector0, vector1, vector2];
                Span<byte> p = MemoryMarshal.Cast<Vector<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector<byte>, byte>(ref indices);
                ref byte pback = ref Unsafe.As<Vector<byte>, byte>(ref back);
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3Insert_Basic(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3Insert_Basic(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
                ushort total = (ushort)(3 * Vector<ushort>.Count);
                Span<Vector<ushort>> rt = stackalloc Vector<ushort>[1];
                Span<Vector<ushort>> temp = [vector0, vector1, vector2];
                Span<ushort> p = MemoryMarshal.Cast<Vector<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector<ushort>, ushort>(ref indices);
                ref ushort pback = ref Unsafe.As<Vector<ushort>, ushort>(ref back);
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3Insert_Basic(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3Insert_Basic(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
                uint total = (uint)(3 * Vector<uint>.Count);
                Span<Vector<uint>> rt = stackalloc Vector<uint>[1];
                Span<Vector<uint>> temp = [vector0, vector1, vector2];
                Span<uint> p = MemoryMarshal.Cast<Vector<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector<uint>, uint>(ref back);
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3Insert_Basic(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3Insert_Basic(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
                ulong total = (ulong)(3 * Vector<ulong>.Count);
                Span<Vector<ulong>> rt = stackalloc Vector<ulong>[1];
                Span<Vector<ulong>> temp = [vector0, vector1, vector2];
                Span<ulong> p = MemoryMarshal.Cast<Vector<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector<ulong>, ulong>(ref back);
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3Insert_Bit(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3Insert_Bit(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3Insert_Bit(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
                Vector<sbyte> mask, raw, rt;
                mask = Vector.GreaterThanOrEqual(indices, Vector<sbyte>.Zero); // i >= 0
                raw = YShuffleX3Insert_Bit(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
                rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3Insert_Bit(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
                byte total = (byte)(3 * Vector<byte>.Count);
                Vector<byte> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<byte> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector<byte> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3Insert_Bit(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3Insert_Bit(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
                ushort total = (ushort)(3 * Vector<ushort>.Count);
                Vector<ushort> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<ushort> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector<ushort> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3Insert_Bit(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3Insert_Bit(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
                uint total = (uint)(3 * Vector<uint>.Count);
                Vector<uint> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<uint> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector<uint> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3Insert_Bit(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3Insert_Bit(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
                ulong total = (ulong)(3 * Vector<ulong>.Count);
                Vector<ulong> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<ulong> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector<ulong> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3Kernel(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3Kernel(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3Kernel(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3Kernel(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3Kernel(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3Kernel(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3Kernel(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3Kernel(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3Kernel(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3Kernel(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3Kernel_Basic(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3Kernel_Basic(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3Kernel_Basic(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3Kernel_Basic(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
                byte total = (byte)(3 * Vector<byte>.Count);
                Span<Vector<byte>> rt = stackalloc Vector<byte>[1];
                Span<Vector<byte>> temp = [vector0, vector1, vector2];
                Span<byte> p = MemoryMarshal.Cast<Vector<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector<byte>, byte>(ref indices);
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3Kernel_Basic(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3Kernel_Basic(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
                ushort total = (ushort)(3 * Vector<ushort>.Count);
                Span<Vector<ushort>> rt = stackalloc Vector<ushort>[1];
                Span<Vector<ushort>> temp = [vector0, vector1, vector2];
                Span<ushort> p = MemoryMarshal.Cast<Vector<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector<ushort>, ushort>(ref indices);
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3Kernel_Basic(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3Kernel_Basic(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
                uint total = (uint)(3 * Vector<uint>.Count);
                Span<Vector<uint>> rt = stackalloc Vector<uint>[1];
                Span<Vector<uint>> temp = [vector0, vector1, vector2];
                Span<uint> p = MemoryMarshal.Cast<Vector<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector<uint>, uint>(ref indices);
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3Kernel_Basic(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3Kernel_Basic(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
                ulong total = (ulong)(3 * Vector<ulong>.Count);
                Span<Vector<ulong>> rt = stackalloc Vector<ulong>[1];
                Span<Vector<ulong>> temp = [vector0, vector1, vector2];
                Span<ulong> p = MemoryMarshal.Cast<Vector<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector<ulong>, ulong>(ref indices);
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3Kernel_Bit(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3Kernel_Bit(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3Kernel_Bit(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3Kernel_Bit(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> indices) {
                Vector<byte> vCount = Vector.Create((byte)Vector<byte>.Count);
                Vector<byte> indices1 = Vector.Subtract(indices, vCount);
                Vector<byte> indices2 = Vector.Subtract(indices1, vCount);
                Vector<byte> rt0 = Vector.Shuffle(vector0, indices);
                Vector<byte> rt1 = Vector.Shuffle(vector1, indices1);
                Vector<byte> rt2 = Vector.Shuffle(vector2, indices2);
                rt0 = Vector.BitwiseOr(rt0, rt1);
                Vector<byte> rt = Vector.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3Kernel_Bit(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3Kernel_Bit(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> indices) {
                Vector<ushort> vCount = Vector.Create((ushort)Vector<ushort>.Count);
                Vector<ushort> indices1 = Vector.Subtract(indices, vCount);
                Vector<ushort> indices2 = Vector.Subtract(indices1, vCount);
                Vector<ushort> rt0 = Vector.Shuffle(vector0, indices);
                Vector<ushort> rt1 = Vector.Shuffle(vector1, indices1);
                Vector<ushort> rt2 = Vector.Shuffle(vector2, indices2);
                rt0 = Vector.BitwiseOr(rt0, rt1);
                Vector<ushort> rt = Vector.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3Kernel_Bit(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3Kernel_Bit(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> indices) {
                Vector<uint> vCount = Vector.Create((uint)Vector<uint>.Count);
                Vector<uint> indices1 = Vector.Subtract(indices, vCount);
                Vector<uint> indices2 = Vector.Subtract(indices1, vCount);
                Vector<uint> rt0 = Vector.Shuffle(vector0, indices);
                Vector<uint> rt1 = Vector.Shuffle(vector1, indices1);
                Vector<uint> rt2 = Vector.Shuffle(vector2, indices2);
                rt0 = Vector.BitwiseOr(rt0, rt1);
                Vector<uint> rt = Vector.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3Kernel_Bit(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3Kernel_Bit(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> indices) {
                Vector<ulong> vCount = Vector.Create((ulong)Vector<ulong>.Count);
                Vector<ulong> indices1 = Vector.Subtract(indices, vCount);
                Vector<ulong> indices2 = Vector.Subtract(indices1, vCount);
                Vector<ulong> rt0 = Vector.Shuffle(vector0, indices);
                Vector<ulong> rt1 = Vector.Shuffle(vector1, indices1);
                Vector<ulong> rt2 = Vector.Shuffle(vector2, indices2);
                rt0 = Vector.BitwiseOr(rt0, rt1);
                Vector<ulong> rt = Vector.BitwiseOr(rt0, rt2);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX3Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX3Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX3Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX3Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX3Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX3Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX3Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX3Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX3Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX3Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX3Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4_AcceleratedTypes {
                get {
                    return YShuffleX4Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4_Basic(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4_Basic(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4_Basic(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
                Vector<sbyte> mask, raw, rt;
                mask = Vector.GreaterThanOrEqual(indices, Vector<sbyte>.Zero); // i >= 0
                raw = YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices).AsSByte();
                rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4_Basic(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4_Basic(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4_Basic(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4_Basic(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4_Basic(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4_Basic(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4_Basic(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4_Bit(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
                return YShuffleX4_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4_Bit(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
                return YShuffleX4_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4_Bit(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
                Vector<sbyte> mask, raw, rt;
                mask = Vector.GreaterThanOrEqual(indices, Vector<sbyte>.Zero); // i >= 0
                raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices).AsSByte();
                rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4_Bit(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
                byte total = (byte)(4 * Vector<byte>.Count);
                Vector<byte> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<byte> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector<byte> rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4_Bit(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
                return YShuffleX4_Bit(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4_Bit(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
                ushort total = (ushort)(4 * Vector<ushort>.Count);
                Vector<ushort> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<ushort> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector<ushort> rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4_Bit(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
                return YShuffleX4_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4_Bit(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
                uint total = (uint)(4 * Vector<uint>.Count);
                Vector<uint> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<uint> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector<uint> rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4_Bit(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
                return YShuffleX4_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4_Bit(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
                ulong total = (ulong)(4 * Vector<ulong>.Count);
                Vector<ulong> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<ulong> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector<ulong> rt = Vector.BitwiseAnd(raw, mask);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Insert_AcceleratedTypes {
                get {
                    return YShuffleX4Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4Insert(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4Insert(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4Insert(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4Insert(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4Insert(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4Insert(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4Insert(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4Insert(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4Insert(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4Insert(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4Insert_Basic(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4Insert_Basic(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4Insert_Basic(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
                Vector<sbyte> mask, raw, rt;
                mask = Vector.GreaterThanOrEqual(indices, Vector<sbyte>.Zero); // i >= 0
                raw = YShuffleX4Insert_Basic(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
                rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4Insert_Basic(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
                byte total = (byte)(4 * Vector<byte>.Count);
                Span<Vector<byte>> rt = stackalloc Vector<byte>[1];
                Span<Vector<byte>> temp = [vector0, vector1, vector2, vector3];
                Span<byte> p = MemoryMarshal.Cast<Vector<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector<byte>, byte>(ref indices);
                ref byte pback = ref Unsafe.As<Vector<byte>, byte>(ref back);
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4Insert_Basic(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4Insert_Basic(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
                ushort total = (ushort)(4 * Vector<ushort>.Count);
                Span<Vector<ushort>> rt = stackalloc Vector<ushort>[1];
                Span<Vector<ushort>> temp = [vector0, vector1, vector2, vector3];
                Span<ushort> p = MemoryMarshal.Cast<Vector<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector<ushort>, ushort>(ref indices);
                ref ushort pback = ref Unsafe.As<Vector<ushort>, ushort>(ref back);
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4Insert_Basic(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4Insert_Basic(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
                uint total = (uint)(4 * Vector<uint>.Count);
                Span<Vector<uint>> rt = stackalloc Vector<uint>[1];
                Span<Vector<uint>> temp = [vector0, vector1, vector2, vector3];
                Span<uint> p = MemoryMarshal.Cast<Vector<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector<uint>, uint>(ref back);
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4Insert_Basic(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4Insert_Basic(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
                ulong total = (ulong)(4 * Vector<ulong>.Count);
                Span<Vector<ulong>> rt = stackalloc Vector<ulong>[1];
                Span<Vector<ulong>> temp = [vector0, vector1, vector2, vector3];
                Span<ulong> p = MemoryMarshal.Cast<Vector<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector<ulong>, ulong>(ref back);
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4Insert_Bit(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4Insert_Bit(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4Insert_Bit(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
                Vector<sbyte> mask, raw, rt;
                mask = Vector.GreaterThanOrEqual(indices, Vector<sbyte>.Zero); // i >= 0
                raw = YShuffleX4Insert_Bit(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
                rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4Insert_Bit(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
                byte total = (byte)(4 * Vector<byte>.Count);
                Vector<byte> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<byte> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector<byte> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4Insert_Bit(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4Insert_Bit(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
                ushort total = (ushort)(4 * Vector<ushort>.Count);
                Vector<ushort> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<ushort> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector<ushort> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4Insert_Bit(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4Insert_Bit(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
                uint total = (uint)(4 * Vector<uint>.Count);
                Vector<uint> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<uint> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector<uint> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4Insert_Bit(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4Insert_Bit(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
                ulong total = (ulong)(4 * Vector<ulong>.Count);
                Vector<ulong> mask = Vector.GreaterThan(Vector.Create(total), indices);
                Vector<ulong> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector<ulong> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3, out Vector<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3, out Vector<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3, out Vector<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3, out Vector<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3, out Vector<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3, out Vector<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3, out Vector<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3, out Vector<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4Insert_Core(Vector<float> back, Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4Insert_Core(Vector<double> back, Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4Insert_Core(Vector<sbyte> back, Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3, Vector<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4Insert_Core(Vector<byte> back, Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3, Vector<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4Insert_Core(Vector<short> back, Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3, Vector<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4Insert_Core(Vector<ushort> back, Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3, Vector<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4Insert_Core(Vector<int> back, Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3, Vector<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4Insert_Core(Vector<uint> back, Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3, Vector<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4Insert_Core(Vector<long> back, Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3, Vector<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Insert_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4Insert_Core(Vector<ulong> back, Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3, Vector<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }


            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4Kernel(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4Kernel(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4Kernel(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4Kernel(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4Kernel(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4Kernel(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4Kernel(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4Kernel(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4Kernel(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4Kernel(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
#if BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_VAR && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4Kernel_Basic(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4Kernel_Basic(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4Kernel_Basic(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4Kernel_Basic(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
                byte total = (byte)(4 * Vector<byte>.Count);
                Span<Vector<byte>> rt = stackalloc Vector<byte>[1];
                Span<Vector<byte>> temp = [vector0, vector1, vector2, vector3];
                Span<byte> p = MemoryMarshal.Cast<Vector<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector<byte>, byte>(ref indices);
                for (int i = 0; i < Vector<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4Kernel_Basic(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4Kernel_Basic(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
                ushort total = (ushort)(4 * Vector<ushort>.Count);
                Span<Vector<ushort>> rt = stackalloc Vector<ushort>[1];
                Span<Vector<ushort>> temp = [vector0, vector1, vector2, vector3];
                Span<ushort> p = MemoryMarshal.Cast<Vector<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector<ushort>, ushort>(ref indices);
                for (int i = 0; i < Vector<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4Kernel_Basic(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4Kernel_Basic(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
                uint total = (uint)(4 * Vector<uint>.Count);
                Span<Vector<uint>> rt = stackalloc Vector<uint>[1];
                Span<Vector<uint>> temp = [vector0, vector1, vector2, vector3];
                Span<uint> p = MemoryMarshal.Cast<Vector<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector<uint>, uint>(ref indices);
                for (int i = 0; i < Vector<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4Kernel_Basic(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4Kernel_Basic(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
                ulong total = (ulong)(4 * Vector<ulong>.Count);
                Span<Vector<ulong>> rt = stackalloc Vector<ulong>[1];
                Span<Vector<ulong>> temp = [vector0, vector1, vector2, vector3];
                Span<ulong> p = MemoryMarshal.Cast<Vector<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector<ulong>, ulong>(ref indices);
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4Kernel_Bit(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4Kernel_Bit(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4Kernel_Bit(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4Kernel_Bit(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> indices) {
                Vector<byte> vCount = Vector.Create((byte)Vector<byte>.Count);
                Vector<byte> indices1 = Vector.Subtract(indices, vCount);
                Vector<byte> indices2 = Vector.Subtract(indices1, vCount);
                Vector<byte> indices3 = Vector.Subtract(indices2, vCount);
                Vector<byte> rt0 = Vector.Shuffle(vector0, indices);
                Vector<byte> rt1 = Vector.Shuffle(vector1, indices1);
                Vector<byte> rt2 = Vector.Shuffle(vector2, indices2);
                Vector<byte> rt3 = Vector.Shuffle(vector3, indices3);
                rt0 = Vector.BitwiseOr(rt0, rt1);
                rt2 = Vector.BitwiseOr(rt2, rt3);
                Vector<byte> rt = Vector.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4Kernel_Bit(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4Kernel_Bit(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> indices) {
                Vector<ushort> vCount = Vector.Create((ushort)Vector<ushort>.Count);
                Vector<ushort> indices1 = Vector.Subtract(indices, vCount);
                Vector<ushort> indices2 = Vector.Subtract(indices1, vCount);
                Vector<ushort> indices3 = Vector.Subtract(indices2, vCount);
                Vector<ushort> rt0 = Vector.Shuffle(vector0, indices);
                Vector<ushort> rt1 = Vector.Shuffle(vector1, indices1);
                Vector<ushort> rt2 = Vector.Shuffle(vector2, indices2);
                Vector<ushort> rt3 = Vector.Shuffle(vector3, indices3);
                rt0 = Vector.BitwiseOr(rt0, rt1);
                rt2 = Vector.BitwiseOr(rt2, rt3);
                Vector<ushort> rt = Vector.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4Kernel_Bit(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4Kernel_Bit(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> indices) {
                Vector<uint> vCount = Vector.Create((uint)Vector<uint>.Count);
                Vector<uint> indices1 = Vector.Subtract(indices, vCount);
                Vector<uint> indices2 = Vector.Subtract(indices1, vCount);
                Vector<uint> indices3 = Vector.Subtract(indices2, vCount);
                Vector<uint> rt0 = Vector.Shuffle(vector0, indices);
                Vector<uint> rt1 = Vector.Shuffle(vector1, indices1);
                Vector<uint> rt2 = Vector.Shuffle(vector2, indices2);
                Vector<uint> rt3 = Vector.Shuffle(vector3, indices3);
                rt0 = Vector.BitwiseOr(rt0, rt1);
                rt2 = Vector.BitwiseOr(rt2, rt3);
                Vector<uint> rt = Vector.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4Kernel_Bit(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4Kernel_Bit(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> indices) {
                Vector<ulong> vCount = Vector.Create((ulong)Vector<ulong>.Count);
                Vector<ulong> indices1 = Vector.Subtract(indices, vCount);
                Vector<ulong> indices2 = Vector.Subtract(indices1, vCount);
                Vector<ulong> indices3 = Vector.Subtract(indices2, vCount);
                Vector<ulong> rt0 = Vector.Shuffle(vector0, indices);
                Vector<ulong> rt1 = Vector.Shuffle(vector1, indices1);
                Vector<ulong> rt2 = Vector.Shuffle(vector2, indices2);
                Vector<ulong> rt3 = Vector.Shuffle(vector3, indices3);
                rt0 = Vector.BitwiseOr(rt0, rt1);
                rt2 = Vector.BitwiseOr(rt2, rt3);
                Vector<ulong> rt = Vector.BitwiseOr(rt0, rt2);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2, out Vector<sbyte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2, out Vector<byte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2, out Vector<short> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2, out Vector<ushort> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2, out Vector<int> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2, out Vector<uint> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2, out Vector<long> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2, out Vector<ulong> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{float}, Vector{float}, Vector{float}, Vector{float}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleX4Kernel_Core(Vector<float> vector0, Vector<float> vector1, Vector<float> vector2, Vector<float> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{double}, Vector{double}, Vector{double}, Vector{double}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleX4Kernel_Core(Vector<double> vector0, Vector<double> vector1, Vector<double> vector2, Vector<double> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleX4Kernel_Core(Vector<sbyte> vector0, Vector<sbyte> vector1, Vector<sbyte> vector2, Vector<sbyte> vector3, Vector<sbyte> args0, Vector<sbyte> args1, Vector<sbyte> args2, Vector<sbyte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleX4Kernel_Core(Vector<byte> vector0, Vector<byte> vector1, Vector<byte> vector2, Vector<byte> vector3, Vector<byte> args0, Vector<byte> args1, Vector<byte> args2, Vector<byte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleX4Kernel_Core(Vector<short> vector0, Vector<short> vector1, Vector<short> vector2, Vector<short> vector3, Vector<short> args0, Vector<short> args1, Vector<short> args2, Vector<short> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleX4Kernel_Core(Vector<ushort> vector0, Vector<ushort> vector1, Vector<ushort> vector2, Vector<ushort> vector3, Vector<ushort> args0, Vector<ushort> args1, Vector<ushort> args2, Vector<ushort> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleX4Kernel_Core(Vector<int> vector0, Vector<int> vector1, Vector<int> vector2, Vector<int> vector3, Vector<int> args0, Vector<int> args1, Vector<int> args2, Vector<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleX4Kernel_Core(Vector<uint> vector0, Vector<uint> vector1, Vector<uint> vector2, Vector<uint> vector3, Vector<uint> args0, Vector<uint> args1, Vector<uint> args2, Vector<uint> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleX4Kernel_Core(Vector<long> vector0, Vector<long> vector1, Vector<long> vector2, Vector<long> vector3, Vector<long> args0, Vector<long> args1, Vector<long> args2, Vector<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleX4Kernel_Core(Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleX4Kernel_Core(Vector<ulong> vector0, Vector<ulong> vector1, Vector<ulong> vector2, Vector<ulong> vector3, Vector<ulong> args0, Vector<ulong> args1, Vector<ulong> args2, Vector<ulong> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }


            /// <inheritdoc cref="IVectorTraits.YSign_AcceleratedTypes"/>
            public static TypeCodeFlags YSign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YSign(Vector<float> value) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YSign(Vector<double> value) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YSign(Vector<sbyte> value) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YSign(Vector<short> value) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YSign(Vector<int> value) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YSign(Vector<long> value) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YSign_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathBitConverter.Int32BitsToSingle(MathINumber.Sign(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YSign_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathBitConverter.Int64BitsToDouble(MathINumber.Sign(p));
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YSign_Basic(Vector<sbyte> value) {
                Vector<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector<sbyte>, sbyte>(ref rt);
                for (nint i = 0; i < Vector<sbyte>.Count; ++i) {
                    p = (sbyte)MathINumber.Sign(p);
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YSign_Basic(Vector<short> value) {
                Vector<short> rt = value;
                ref short p = ref Unsafe.As<Vector<short>, short>(ref rt);
                for (nint i = 0; i < Vector<short>.Count; ++i) {
                    p = (short)MathINumber.Sign(p);
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YSign_Basic(Vector<int> value) {
                Vector<int> rt = value;
                ref int p = ref Unsafe.As<Vector<int>, int>(ref rt);
                for (nint i = 0; i < Vector<int>.Count; ++i) {
                    p = MathINumber.Sign(p);
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YSign_Basic(Vector<long> value) {
                Vector<long> rt = value;
                ref long p = ref Unsafe.As<Vector<long>, long>(ref rt);
                for (nint i = 0; i < Vector<long>.Count; ++i) {
                    p = MathINumber.Sign(p);
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YSign(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YSign_Bit(Vector<float> value) {
                // (x > 0) - (x < 0); //From "Hacker's Delight" 2.7, Page 19.
                // = (-to_mask(x > 0)) - (-to_mask(x < 0))
                // = to_mask(x < 0) - to_mask(x > 0).
                Vector<float> zero = Vector<float>.Zero;
                Vector<int> m = Vector.LessThan(value, zero).AsInt32();
                Vector<int> n = Vector.GreaterThan(value, zero).AsInt32();
                Vector<int> rt = Vector.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YSign_Bit(Vector<double> value) {
                Vector<double> zero = Vector<double>.Zero;
                Vector<long> m = Vector.LessThan(value, zero).AsInt64();
                Vector<long> n = Vector.GreaterThan(value, zero).AsInt64();
                Vector<long> rt = Vector.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YSign_Bit(Vector<sbyte> value) {
                Vector<sbyte> zero = Vector<sbyte>.Zero;
                Vector<sbyte> m = Vector.LessThan(value, zero);
                Vector<sbyte> n = Vector.GreaterThan(value, zero);
                Vector<sbyte> rt = Vector.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YSign_Bit(Vector<short> value) {
                Vector<short> zero = Vector<short>.Zero;
                Vector<short> m = Vector.LessThan(value, zero);
                Vector<short> n = Vector.GreaterThan(value, zero);
                Vector<short> rt = Vector.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YSign_Bit(Vector<int> value) {
                Vector<int> zero = Vector<int>.Zero;
                Vector<int> m = Vector.LessThan(value, zero);
                Vector<int> n = Vector.GreaterThan(value, zero);
                Vector<int> rt = Vector.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YSign(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YSign_Bit(Vector<long> value) {
                Vector<long> zero = Vector<long>.Zero;
                Vector<long> m = Vector.LessThan(value, zero);
                Vector<long> n = Vector.GreaterThan(value, zero);
                Vector<long> rt = Vector.Subtract(m, n);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IVectorTraits.YSignFloat_AcceleratedTypes"/>
            public static TypeCodeFlags YSignFloat_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    if (Vector.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.Single) & YIsNaN_AcceleratedTypes & YSign_AcceleratedTypes & ConvertToSingle_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YSignFloat(Vector<float> value) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YSignFloat_Bit(value);
#else
                return YSignFloat_Basic(value);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YSignFloat(Vector<double> value) {
#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
                return YSignFloat_Bit(value);
#else
                return YSignFloat_Basic(value);
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YSignFloat_Basic(Vector<float> value) {
                Vector<float> rt = value;
                ref float p = ref Unsafe.As<Vector<float>, float>(ref rt);
                for (nint i = 0; i < Vector<float>.Count; ++i) {
                    p = MathINumber.SignFloat(p);
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YSignFloat_Basic(Vector<double> value) {
                Vector<double> rt = value;
                ref double p = ref Unsafe.As<Vector<double>, double>(ref rt);
                for (nint i = 0; i < Vector<double>.Count; ++i) {
                    p = MathINumber.SignFloat(p);
                    p = ref Unsafe.Add(ref p, 1);
                }
                return rt;
            }

#if BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YSignFloat_Bit(Vector<float> value) {
                Vector<int> signVal = YSign(value);
                Vector<float> nanMask = YIsNaN(value).AsSingle();
                Vector<float> rt = ConvertToSingle(signVal);
                rt = Vector.ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YSignFloat_Bit(Vector<double> value) {
                return YSignFloat_Compare(value);
            }

            /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YSignFloat_Compare(Vector<double> value) {
                Vector<double> negativeOne = new Vector<double>(-1.0);
                Vector<double> zero = Vector<double>.Zero;
                Vector<double> one = new Vector<double>(1.0);
                Vector<double> rt = Vector.BitwiseAnd(Vector.LessThan(value, zero).AsDouble(), negativeOne);
                Vector<double> nanMask = YIsNaN(value).AsDouble();
                rt = Vector.BitwiseOr(rt, Vector.BitwiseAnd(Vector.GreaterThan(value, zero).AsDouble(), one)); // rt = ConvertToDouble(YSign(value));
                rt = Vector.BitwiseOr(rt, Vector.BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.YSignFloat(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YSignFloat_Convert(Vector<double> value) {
                Vector<long> signVal = YSign(value);
                Vector<double> nanMask = YIsNaN(value).AsDouble();
                Vector<double> rt = ConvertToDouble(signVal);
                rt = Vector.BitwiseOr(rt, Vector.BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_VAR && VECTOR_HAS_METHOD

        }
    }
}
