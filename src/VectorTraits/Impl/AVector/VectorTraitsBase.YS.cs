using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.Util;

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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(source, VectorConstants.YShuffleG2_Byte_Indices[(int)control]);
#else
                return YShuffleG2_Base(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(source.AsByte(), VectorConstants.YShuffleG2_UInt16_ByteIndices[(int)control]).AsUInt16();
#else
                return YShuffleG2_Base(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(source.AsByte(), VectorConstants.YShuffleG2_UInt32_ByteIndices[(int)control]).AsUInt32();
#else
                return YShuffleG2_Base(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector.Shuffle(source.AsByte(), VectorConstants.YShuffleG2_UInt64_ByteIndices[(int)control]).AsUInt64();
#else
                return YShuffleG2_Base(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG2_Base(Vector<float> source, ShuffleControlG2 control) {
                return YShuffleG2_Base(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG2_Base(Vector<double> source, ShuffleControlG2 control) {
                return YShuffleG2_Base(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG2_Base(Vector<sbyte> source, ShuffleControlG2 control) {
                return YShuffleG2_Base(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG2_Base(Vector<byte> source, ShuffleControlG2 control) {
                UnsafeEx.SkipInit(out Vector<byte> rt);
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
            public static Vector<short> YShuffleG2_Base(Vector<short> source, ShuffleControlG2 control) {
                return YShuffleG2_Base(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG2_Base(Vector<ushort> source, ShuffleControlG2 control) {
                UnsafeEx.SkipInit(out Vector<ushort> rt);
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
            public static Vector<int> YShuffleG2_Base(Vector<int> source, ShuffleControlG2 control) {
                return YShuffleG2_Base(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG2_Base(Vector<uint> source, ShuffleControlG2 control) {
                UnsafeEx.SkipInit(out Vector<uint> rt);
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
            public static Vector<long> YShuffleG2_Base(Vector<long> source, ShuffleControlG2 control) {
                return YShuffleG2_Base(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG2(Vector{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG2_Base(Vector<ulong> source, ShuffleControlG2 control) {
                UnsafeEx.SkipInit(out Vector<ulong> rt);
                ref ulong q = ref Unsafe.As<Vector<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector<ulong>, ulong>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector<ulong>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

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
                return YShuffleG4_Base(source, control);
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
                return YShuffleG4_Base(source, control);
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
                return YShuffleG4_Base(source, control);
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
                return YShuffleG4_Base(source, control);
#endif // BCL_OVERRIDE_BASE_VAR && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YShuffleG4_Base(Vector<float> source, ShuffleControlG4 control) {
                return YShuffleG4_Base(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4_Base(Vector<double> source, ShuffleControlG4 control) {
                return YShuffleG4_Base(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4_Base(Vector<sbyte> source, ShuffleControlG4 control) {
                return YShuffleG4_Base(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4_Base(Vector<byte> source, ShuffleControlG4 control) {
                UnsafeEx.SkipInit(out Vector<byte> rt);
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
            public static Vector<short> YShuffleG4_Base(Vector<short> source, ShuffleControlG4 control) {
                return YShuffleG4_Base(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4_Base(Vector<ushort> source, ShuffleControlG4 control) {
                UnsafeEx.SkipInit(out Vector<ushort> rt);
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
            public static Vector<int> YShuffleG4_Base(Vector<int> source, ShuffleControlG4 control) {
                return YShuffleG4_Base(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4_Base(Vector<uint> source, ShuffleControlG4 control) {
                UnsafeEx.SkipInit(out Vector<uint> rt);
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
            public static Vector<long> YShuffleG4_Base(Vector<long> source, ShuffleControlG4 control) {
                return YShuffleG4_Base(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4(Vector{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4_Base(Vector<ulong> source, ShuffleControlG4 control) {
                if (Vector<ulong>.Count < 4) {
                    throw new NotSupportedException(string.Format(VectorMessageFormats.FORMAT_YSHUFFLEG4_MUST4_1, Vector<ulong>.Count));
                }
                UnsafeEx.SkipInit(out Vector<ulong> rt);
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
            public static Vector<float> YShuffleG4X2(Vector<float> source0, Vector<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<float> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{double}, Vector{double}, ShuffleControlG4, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YShuffleG4X2(Vector<double> source0, Vector<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<double> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt64(), source1.AsUInt64(), control, out var rt1);
                result1 = rt1.AsDouble();
                return rt0.AsDouble();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{sbyte}, Vector{sbyte}, ShuffleControlG4, out Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YShuffleG4X2(Vector<sbyte> source0, Vector<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<sbyte> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{byte}, Vector{byte}, ShuffleControlG4, out Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleG4X2(Vector<byte> source0, Vector<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<byte> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{short}, Vector{short}, ShuffleControlG4, out Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YShuffleG4X2(Vector<short> source0, Vector<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<short> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ushort}, Vector{ushort}, ShuffleControlG4, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YShuffleG4X2(Vector<ushort> source0, Vector<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ushort> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{int}, Vector{int}, ShuffleControlG4, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YShuffleG4X2(Vector<int> source0, Vector<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<int> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{uint}, Vector{uint}, ShuffleControlG4, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YShuffleG4X2(Vector<uint> source0, Vector<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<uint> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{long}, Vector{long}, ShuffleControlG4, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YShuffleG4X2(Vector<long> source0, Vector<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<long> result1) {
                var rt0 = YShuffleG4X2(source0.AsUInt64(), source1.AsUInt64(), control, out var rt1);
                result1 = rt1.AsInt64();
                return rt0.AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4X2(Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ulong> result1) {
                return YShuffleG4X2_Base(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleG4X2(Vector{ulong}, Vector{ulong}, ShuffleControlG4, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YShuffleG4X2_Base(Vector<ulong> source0, Vector<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector<ulong> result1) {
                if (Vector<ulong>.Count >= 4) {
                    var rt0 = YShuffleG4(source0, control);
                    result1 = YShuffleG4(source1, control);
                    return rt0;
                }
                UnsafeEx.SkipInit(out (Vector<ulong> Result0, Vector<ulong> Result1) rt);
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                Vector<byte> mask = Vector.GreaterThan(Vector.Create((byte)Vector<byte>.Count), indices);
                Vector<byte> raw = Vector.Shuffle(vector, indices);
                Vector<byte> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Base(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                Vector<ushort> mask = Vector.GreaterThan(Vector.Create((ushort)Vector<ushort>.Count), indices);
                Vector<ushort> raw = Vector.Shuffle(vector, indices);
                Vector<ushort> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Base(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                Vector<uint> mask = Vector.GreaterThan(Vector.Create((uint)Vector<uint>.Count), indices);
                Vector<uint> raw = Vector.Shuffle(vector, indices);
                Vector<uint> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Base(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                Vector<ulong> mask = Vector.GreaterThan(Vector.Create((ulong)Vector<ulong>.Count), indices);
                Vector<ulong> raw = Vector.Shuffle(vector, indices);
                Vector<ulong> rt = Vector.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Base(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YShuffleInsert_Base(Vector<byte> back, Vector<byte> vector, Vector<byte> indices) {
                UnsafeEx.SkipInit(out Vector<byte> rt);
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
            public static Vector<ushort> YShuffleInsert_Base(Vector<ushort> back, Vector<ushort> vector, Vector<ushort> indices) {
                UnsafeEx.SkipInit(out Vector<ushort> rt);
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
            public static Vector<uint> YShuffleInsert_Base(Vector<uint> back, Vector<uint> vector, Vector<uint> indices) {
                UnsafeEx.SkipInit(out Vector<uint> rt);
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
            public static Vector<ulong> YShuffleInsert_Base(Vector<ulong> back, Vector<ulong> vector, Vector<ulong> indices) {
                UnsafeEx.SkipInit(out Vector<ulong> rt);
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

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte}))"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1, out Vector<sbyte> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((byte)Vector<byte>.Count), indices.AsByte()).AsSByte();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{byte}, out Vector{byte}, out Vector{byte}, out Vector{byte}))"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1, out Vector<byte> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((byte)Vector<byte>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{short}, out Vector{short}, out Vector{short}, out Vector{short}))"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1, out Vector<short> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((ushort)Vector<ushort>.Count), indices.AsUInt16()).AsInt16();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort}, out Vector{ushort}))"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1, out Vector<ushort> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((ushort)Vector<ushort>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{int}, out Vector{int}, out Vector{int}, out Vector{int}))"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1, out Vector<int> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((uint)Vector<uint>.Count), indices.AsUInt32()).AsInt32();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{uint}, out Vector{uint}, out Vector{uint}, out Vector{uint}))"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1, out Vector<uint> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((uint)Vector<uint>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{long}, out Vector{long}, out Vector{long}, out Vector{long}))"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1, out Vector<long> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((ulong)Vector<ulong>.Count), indices.AsUInt64()).AsInt64();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.YShuffleInsert_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong}, out Vector{ulong}))"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1, out Vector<ulong> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                args2 = Vector.GreaterThan(Vector.Create((ulong)Vector<ulong>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                var raw = Vector.Shuffle(vector, args0);
                var rt = Vector.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Base(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                var raw = Vector.Shuffle(vector, args0);
                var rt = Vector.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Base(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                var raw = Vector.Shuffle(vector, args0);
                var rt = Vector.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Base(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                var raw = Vector.Shuffle(vector, args0);
                var rt = Vector.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Base(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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


        }
    }
}
